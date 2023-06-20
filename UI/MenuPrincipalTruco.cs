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
    public partial class MenuPrincipalTruco : Form
    {
        public MenuPrincipalTruco()
        {
            InitializeComponent();
        }

        private void btn_RegistrarJugador_Click(object sender, EventArgs e)
        {
            RegistrarJugador registrarJugadorForm = new RegistrarJugador();
            registrarJugadorForm.Show();
        }

        private void btn_CrearSala_Click(object sender, EventArgs e)
        {
            CrearSalasDeJuego crearSalaForm = new CrearSalasDeJuego();
            crearSalaForm.Show();
        }

        private void btn_MostrarSalas_Click(object sender, EventArgs e)
        {
            SalasDeJuego mostrarSalasForm = new SalasDeJuego();
            mostrarSalasForm.Show();
        }

        private void btn_MostrarEstaditicas_Click(object sender, EventArgs e)
        {
            MenuEstadisticas estadisticasForm = new MenuEstadisticas();
            estadisticasForm.Show();
        }

        private void MenuPrincipalTruco_Load(object sender, EventArgs e)
        {

        }
    }
}
