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
    public partial class SalasDeJuego : Form,IMensajeFormulario
    {
        private MesaDeJuego MesaDeJuego;
        private string textoDelLabel = "Elija la sala de juego que desea ver";
        private int indiceLetra = 0;
        public SalasDeJuego()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }

        private void SalasDeJuego_Load(object sender, EventArgs e)
        {
            dtg_Salas.DataSource = MesaDeJuegoSql.Leer();
            RefrescarDataGrid();
            MostrarMensaje();
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
    }
}
