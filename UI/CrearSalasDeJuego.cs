using FernandezBarbero.Rodrigo.TP2_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CrearSalasDeJuego : Form
    {
        private Jugador jugadorUno;
        private Jugador jugadorDos;
        private Action<string> delegadoUnoCartas;

        public CrearSalasDeJuego()
        {
            InitializeComponent();
            delegadoUnoCartas = MostrarCartasRepartidas;

        }

        private void CrearSalasDeJuego_Load(object sender, EventArgs e)
        {
            RefrescarDataGrid();
            rtb_Sala.Visible = false;
            btn_CrearSala.Visible = false;

        }

        private void RefrescarDataGrid()
        {
            dtg_Jugadores.DataSource = null;
            dtg_Jugadores.DataSource = JugadorSql.LeerSql();
            dtg_Jugadores.Columns["PassWord"].Visible = false;
            dtg_Jugadores.Columns["CantarEnvido"].Visible = false;
            dtg_Jugadores.Columns["QuiereEnvido"].Visible = false;
            dtg_Jugadores.Columns["CantarTruco"].Visible = false;
            dtg_Jugadores.Columns["QuiereTruco"].Visible = false;
            dtg_Jugadores.Columns["CantidadPuntos"].Visible = false;
            dtg_Jugadores.Columns["EsMano"].Visible = false;
            dtg_Jugadores.Update();
            dtg_Jugadores.Refresh();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SeleccionarJugadorUno_Click(object sender, EventArgs e)
        {
            if (dtg_Jugadores.SelectedRows.Count > 0)
            {
                jugadorUno = (Jugador)dtg_Jugadores.CurrentRow.DataBoundItem;

                lbl_JugadorUno.Text = jugadorUno.NombreJugador;
            }
        }

        private void btn_JugadorDos_Click(object sender, EventArgs e)
        {
            if (dtg_Jugadores.SelectedRows.Count > 0)
            {
                jugadorUno = (Jugador)dtg_Jugadores.CurrentRow.DataBoundItem;

                lbl_JugadorDos.Text = jugadorUno.NombreJugador;
            }
        }

        public bool ValidarJugadoresNoSeanIguales(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (jugadorUno is not null && jugadorDos is not null && jugadorUno != jugadorDos)
            {
                return true;
            }

            return false;
        }

        public string MostrarSala()
        {
            StringBuilder sb = new StringBuilder();

            rtb_Sala.Visible = true;

            if (ValidarJugadoresNoSeanIguales(jugadorUno, jugadorDos) == true)
            {
                sb.AppendLine($"El jugador {jugadorUno.NombreJugador} vs el jugador {jugadorDos.NombreJugador}");
            }
            else
            {
                sb.AppendLine("Se han ingresado los mismos Jugadores");
            }

            return sb.ToString();
        }

        private void btn_CrearSala_Click(object sender, EventArgs e)
        {
            if (ValidarJugadoresNoSeanIguales(jugadorUno, jugadorDos) == true)
            {
                int ultimoIdMesa = MesaDeJuego.ObtenerUltimoIdTabla(SqlMesaConFechaCreacion.Leer());
                ultimoIdMesa += 1;
                int ultimoNumeroMesa = MesaDeJuego.ObtenerUltimoNumeroMesa(SqlMesaConFechaCreacion.Leer());
                ultimoNumeroMesa += 1;


                if (jugadorUno.EstaEnPartida == "Disponible" && jugadorDos.EstaEnPartida == "Disponible")
                {
                    MesaDeJuego nuevaMesaConFecha = new MesaDeJuego(ultimoIdMesa, ultimoNumeroMesa, DateTime.Now);
                    MesaDeJuego nuevaMesaJugar = new MesaDeJuego(ultimoIdMesa, ultimoNumeroMesa, jugadorUno, jugadorDos, DateTime.Now);

                    jugadorUno.estaJugando = true;
                    jugadorDos.estaJugando = true;

                    JugadorSql.ModificarJugadorEstado(jugadorUno);
                    JugadorSql.ModificarJugadorEstado(jugadorDos);

                    SqlMesaConFechaCreacion.Guardar(nuevaMesaConFecha);
                    MesaDeJuegoSql.Guardar(nuevaMesaJugar);
                    this.Close();
                }
                else
                {
                    if (jugadorUno.EstaEnPartida == "En Partida" && jugadorDos.EstaEnPartida == "En Partida")
                    {
                        MessageBox.Show("No se pudo crear la sala los jugadores estan en partida...");
                    }
                    else if (jugadorDos.EstaEnPartida == "En Partida")
                    {
                        MessageBox.Show($"Error. El jugador {jugadorDos.NombreJugador} se encuentra en una partida...");
                    }
                    else if (jugadorUno.EstaEnPartida == "En Partida")
                    {
                        MessageBox.Show($"Error. El jugador {jugadorUno.NombreJugador} se encuentra en una partida...");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se pudo crear la sala...");
            }
        }

        public void MostrarCartasRepartidas(string mensaje)
        {
            Console.WriteLine("Cartas repartidas: ");
            Console.WriteLine(mensaje);
        }

        private void btn_MostrarSala_Click(object sender, EventArgs e)
        {
            rtb_Sala.Text = MostrarSala();
            btn_CrearSala.Visible = true;
        }
    }
}
