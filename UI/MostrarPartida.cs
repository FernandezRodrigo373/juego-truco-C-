using FernandezBarbero.Rodrigo.TP2_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UI
{
    public partial class MostrarPartida : Form,IMensajeFormulario
    {
        private MesaDeJuego mesaAux;
        CancellationTokenSource cts;
        private Task taskPartida;
        private string textoDelLabel = "Partida en curso. Haga silencio por favor";
        private int indiceLetra = 0;

        public MostrarPartida(MesaDeJuego mesa)
        {
            InitializeComponent();
            mesaAux = mesa;
            cts = new CancellationTokenSource();
            timer1.Tick += timer1_Tick;
        }

        private void MostrarPartida_Load(object sender, EventArgs e)
        {
            MostrarMensaje();
            mesaAux.DelegadoCartas += MostrarPartidaEnCurso;
            taskPartida = Task.Run(JugarUnaPartida);

            lbl_JugadorUno.Text = mesaAux.JugadorUno.NombreJugador;
            lbl_JugadorDos.Text = mesaAux.JugadorDos.NombreJugador;
            lbl_PuntajeJugadorUno.Text = mesaAux.JugadorUno.CantidadPuntos.ToString();
            lbl_PuntajeJugadorDos.Text = mesaAux.JugadorDos.CantidadPuntos.ToString();
            lbl_Tiempo.Visible = false;
            lbl_PuntajeJugadorUno.Visible = false;
            lbl_PuntajeJugadorDos.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (indiceLetra < textoDelLabel.Length)
            {
                label1.Text += textoDelLabel[indiceLetra];
                indiceLetra++;
            }
            else
            {
                timer1.Stop();
            }
        }

        public void MostrarMensaje()
        {
            timer1.Start();
        }



        public void JugarUnaPartida()
        {

            List<CartaTruco> maso = new List<CartaTruco>();
            Truco reglas = new Truco(maso);
            mesaAux.JugarPartida(reglas, this.cts.Token);

        }

        public void PartidaTerminada()
        {
            string ganador = mesaAux.EstablecerGanador();

            if (ganador == mesaAux.JugadorUno.NombreJugador || ganador == mesaAux.JugadorDos.NombreJugador)
            {
                GuardarHistorialPuntosPartida();
                mesaAux.JugadorUno.estaJugando = false;
                mesaAux.JugadorDos.estaJugando = false;
                JugadorSql.ModificarJugador(mesaAux.JugadorUno);
                JugadorSql.ModificarJugador(mesaAux.JugadorDos);
                MesaDeJuegoSql.Eliminar(mesaAux);
                this.Close();
            }
        }

        public void MostrarPartidaEnCurso(string texto)
        {
            if (this.rtb_Partida.InvokeRequired)
            {
                this.rtb_Partida.BeginInvoke((MethodInvoker)delegate ()
                {
                    rtb_Partida.AppendText(texto);
                }
                );
            }
        }




        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_MostrarMarcador_Click(object sender, EventArgs e)
        {
            if (taskPartida.IsCompleted)
            {
                lbl_PuntajeJugadorUno.Text = null;
                lbl_PuntajeJugadorUno.Visible = true;
                lbl_PuntajeJugadorDos.Visible = true;
                lbl_Tiempo.Visible = true;
                lbl_Tiempo.Text = MesaDeJuego.DuracionActualizada.ToString();
                lbl_PuntajeJugadorUno.Text = mesaAux.JugadorUno.CantidadPuntos.ToString();
                lbl_PuntajeJugadorDos.Text = mesaAux.JugadorDos.CantidadPuntos.ToString();
            }
            else
            {
                lbl_PuntajeJugadorUno.Visible = true;
                lbl_PuntajeJugadorUno.Text = "Aguarde a que termine la partida para ver los resultados";
            }
        }

        private void GuardarHistorialPuntosPartida()
        {
            string ganador = mesaAux.EstablecerGanador();

            StreamWriter escribir = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}" + "HistorialPuntos", true);

            try
            {
                escribir.WriteLine($"Id Mesa: {mesaAux.IdMesaDeJuego}");
                escribir.WriteLine($"Numero Mesa: {mesaAux.NumeroMesaDeJuego}");
                escribir.WriteLine($"Jugador uno: {mesaAux.JugadorUno.NombreJugador}, Puntos: {mesaAux.JugadorUno.CantidadPuntos}");
                escribir.WriteLine($"Jugador dos: {mesaAux.JugadorDos.NombreJugador}, Puntos: {mesaAux.JugadorDos.CantidadPuntos}");
                escribir.WriteLine($"El ganador es: {ganador}\n");
            }
            catch
            {

                MessageBox.Show("Error al guardar historial...");
            }

            escribir.Close();
        }

        private void btn_FinalizarProceso_Click(object sender, EventArgs e)
        {
            PartidaTerminada();
        }

        private void btn_TerminarPartida_Click(object sender, EventArgs e)
        {
            this.cts.Cancel();
        }
    }
}
