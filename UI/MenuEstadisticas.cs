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
            dtg_Datos.Columns["PassWord"].Visible = false;
            dtg_Datos.Columns["CantarEnvido"].Visible = false;
            dtg_Datos.Columns["QuererEnvido"].Visible = false;
            dtg_Datos.Columns["CantarTruco"].Visible = false;
            dtg_Datos.Columns["QuererTruco"].Visible = false;
            dtg_Datos.Columns["CantidadPuntos"].Visible = false;
            dtg_Datos.Columns["EsMano"].Visible = false;
            dtg_Datos.Columns["EstaEnPartida"].Visible = false;
        
        }

        private void btn_JugadoresConMasPartidas_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = JugadorSql.FiltrarJugadoresConMasPartidas();
            dtg_Datos.Columns["PassWord"].Visible = false;
            dtg_Datos.Columns["CantarEnvido"].Visible = false;
            dtg_Datos.Columns["QuererEnvido"].Visible = false;
            dtg_Datos.Columns["CantarTruco"].Visible = false;
            dtg_Datos.Columns["QuererTruco"].Visible = false;
            dtg_Datos.Columns["CantidadPuntos"].Visible = false;
            dtg_Datos.Columns["EsMano"].Visible = false;
            dtg_Datos.Columns["EstaEnPartida"].Visible = false;
        
        }

        private void btn_JugadoresSinPartidas_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = JugadorSql.FiltrarJugadoresSinPartidas();
            dtg_Datos.Columns["PassWord"].Visible = false;
            dtg_Datos.Columns["CantarEnvido"].Visible = false;
            dtg_Datos.Columns["QuererEnvido"].Visible = false;
            dtg_Datos.Columns["CantarTruco"].Visible = false;
            dtg_Datos.Columns["QuererTruco"].Visible = false;
            dtg_Datos.Columns["CantidadPuntos"].Visible = false;
            dtg_Datos.Columns["EsMano"].Visible = false;
            dtg_Datos.Columns["EstaEnPartida"].Visible = false;

        }

        private void btn_HistorialDePartidas_Click(object sender, EventArgs e)
        {
            RefrescarDataGrid();

        }

        private void RefrescarDataGrid()
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = SqlMesaConFechaCreacion.Leer();
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
