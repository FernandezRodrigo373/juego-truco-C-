using FernandezBarbero.Rodrigo.TP2_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UI
{
    public partial class MostrarPartida : Form
    {
        private MesaDeJuego mesaAsu;
        CancellationTokenSource cts;
        private Task taskPartida;
        bool move = false;

        public MostrarPartida(MesaDeJuego mesa)
        {
            InitializeComponent();
            mesaAsu = mesa;
            cts = new CancellationTokenSource();
        }

        private void MostrarPartida_Load(object sender, EventArgs e)
        {
            mesaAsu.DelegadoCartas += MostrarPartidaEnCurso;
            taskPartida = Task.Run(JugarUnaPartida);

            lbl_JugadorUno.Text = mesaAsu.JugadorUno.NombreJugador;
            lbl_JugadorDos.Text = mesaAsu.JugadorDos.NombreJugador;
            lbl_PuntajeJugadorUno.Text = mesaAsu.JugadorUno.CantidadPuntos.ToString();
            lbl_PuntajeJugadorDos.Text = mesaAsu.JugadorDos.CantidadPuntos.ToString();
            lbl_Tiempo.Visible = false;
            lbl_PuntajeJugadorUno.Visible = false;
            lbl_PuntajeJugadorDos.Visible = false;
        }
        public void JugarUnaPartida()
        {

            List<CartaTruco> maso = new List<CartaTruco>();
            Truco reglas = new Truco(maso);
            mesaAsu.JugarPartida(reglas, this.cts.Token);

        }

        public void PartidaTerminada()
        {
            string ganador = mesaAsu.EstablecerGanador();

            if (ganador == mesaAsu.JugadorUno.NombreJugador || ganador == mesaAsu.JugadorDos.NombreJugador)
            {
                GuardarHistorialPuntosPartida();
                mesaAsu.JugadorUno.estaJugando = false;
                mesaAsu.JugadorDos.estaJugando = false;
                JugadorSql.ModificarJugador(mesaAsu.JugadorUno);
                JugadorSql.ModificarJugador(mesaAsu.JugadorDos);
                MesaDeJuegoSql.Eliminar(mesaAsu);
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

                lbl_PuntajeJugadorUno.Visible = true;
                lbl_PuntajeJugadorDos.Visible = true;
                lbl_Tiempo.Text = mesaAsu.DuracionPartida.ToString();
                lbl_PuntajeJugadorUno.Text = mesaAsu.JugadorUno.CantidadPuntos.ToString();
                lbl_PuntajeJugadorDos.Text = mesaAsu.JugadorDos.CantidadPuntos.ToString();
            }
        }

        private void GuardarHistorialPuntosPartida()
        {
            string ganador = mesaAsu.EstablecerGanador();
            StreamWriter escribir = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}" + "HistorialPuntos", true);

            try
            {
                escribir.WriteLine($"Id Mesa: {mesaAsu.IdMesaDeJuego}");
                escribir.WriteLine($"Numero Mesa: {mesaAsu.NumeroMesaDeJuego}");
                escribir.WriteLine($"Jugador uno: {mesaAsu.JugadorUno.NombreJugador}, Puntos: {mesaAsu.JugadorUno.CantidadPuntos}");
                escribir.WriteLine($"Jugador dos: {mesaAsu.JugadorDos.NombreJugador}, Puntos: {mesaAsu.JugadorDos.CantidadPuntos}");
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
