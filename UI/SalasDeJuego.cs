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
    public partial class SalasDeJuego : Form
    {
        private MesaDeJuego MesaDeJuego;
        public SalasDeJuego()
        {
            InitializeComponent();
        }

        private void SalasDeJuego_Load(object sender, EventArgs e)
        {
            dtg_Salas.DataSource = MesaDeJuegoSql.Leer();
            RefrescarDataGrid();
        }
        private void RefrescarDataGrid()
        {
            dtg_Salas.DataSource = MesaDeJuegoSql.Leer();
            dtg_Salas.Columns["jugadorUno"].Visible = false;
            dtg_Salas.Columns["jugadorDos"].Visible = false;
            dtg_Salas.Columns["puntajeJugadorUno"].Visible = false;
            dtg_Salas.Columns["puntajeJugadorDos"].Visible = false;
            dtg_Salas.Columns["fecha"].Visible = false;
            dtg_Salas.Columns["delegadoCartas"].Visible = false;
            dtg_Salas.Update();
            dtg_Salas.Refresh();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_MostrarSalas_Click(object sender, EventArgs e)
        {

            if (dtg_Salas.SelectedRows.Count > 0)
            {
                MesaDeJuego = (MesaDeJuego)dtg_Salas.CurrentRow.DataBoundItem;

                MostrarPartida mostrarPartidaForm = new MostrarPartida(MesaDeJuego);

                mostrarPartidaForm.Show();

            }
        }
    }
}
