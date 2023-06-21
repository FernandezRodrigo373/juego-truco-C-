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
    public partial class MenuEstadisticas : Form
    {
        public MenuEstadisticas()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_JugadoresConMasVictorias_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = JugadorSql.FiltrarJugadoresPorCantidadPartidosGanadas();
            dtg_Datos.Columns["passwordJugador"].Visible = false;
            dtg_Datos.Columns["cantarEnvido"].Visible = false;
            dtg_Datos.Columns["quererEnvido"].Visible = false;
            dtg_Datos.Columns["cantarTruco"].Visible = false;
            dtg_Datos.Columns["quererTruco"].Visible = false;
            dtg_Datos.Columns["cantidadPuntos"].Visible = false;
            dtg_Datos.Columns["esMano"].Visible = false;
            //dtg_Datos.Columns["estaJugando"].Visible = false;
        
        }

        private void btn_JugadoresConMasPartidas_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = JugadorSql.FiltrarJugadoresConMasPartidas();
            dtg_Datos.Columns["passwordJugador"].Visible = false;
            dtg_Datos.Columns["cantarEnvido"].Visible = false;
            dtg_Datos.Columns["quererEnvido"].Visible = false;
            dtg_Datos.Columns["cantarTruco"].Visible = false;
            dtg_Datos.Columns["quererTruco"].Visible = false;
            dtg_Datos.Columns["cantidadPuntos"].Visible = false;
            dtg_Datos.Columns["esMano"].Visible = false;
            //dtg_Datos.Columns["estaJugando"].Visible = false;


        }

        private void btn_JugadoresSinPartidas_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = JugadorSql.FiltrarJugadoresSinPartidas();
            dtg_Datos.Columns["passwordJugador"].Visible = false;
            dtg_Datos.Columns["cantarEnvido"].Visible = false;
            dtg_Datos.Columns["quererEnvido"].Visible = false;
            dtg_Datos.Columns["cantarTruco"].Visible = false;
            dtg_Datos.Columns["quererTruco"].Visible = false;
            dtg_Datos.Columns["cantidadPuntos"].Visible = false;
            dtg_Datos.Columns["esMano"].Visible = false;
            ////dtg_Datos.Columns["estaJugando"].Visible = false;


        }

        private void btn_HistorialDePartidas_Click(object sender, EventArgs e)
        {
            RefrescarDataGrid();

        }

        private void RefrescarDataGrid()
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = PartidasJugadasSql.Leer();
            dtg_Datos.Columns["NombreJugadorUno"].Visible = false;
            dtg_Datos.Columns["NombreJugadorDos"].Visible = false;
            dtg_Datos.Columns["PuntajeJugadorUno"].Visible = false;
            dtg_Datos.Columns["PuntajeJugadorDos"].Visible = false;
            dtg_Datos.Columns["JugadorUno"].Visible = false;
            dtg_Datos.Columns["JugadorDos"].Visible = false;
            dtg_Datos.Columns["DuracionPartida"].Visible = false;
            dtg_Datos.Columns["DeleGADOCartas"].Visible = false;

            dtg_Datos.Update();
            dtg_Datos.Refresh();
        }
    }
}
