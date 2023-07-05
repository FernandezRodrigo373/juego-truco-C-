using FernandezBarbero.Rodrigo.TP2_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UI
{
    public partial class MenuPrincipalTruco : Form, IMensajeFormulario
    {
        private string textoDelLabel = "Bienvenido a CeliTruco. Que lo disfrutes!!!";
        private int indiceLetra = 0;

        public MenuPrincipalTruco()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
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
            MostrarMensaje();

            List<CartaTruco> cartas = new List<CartaTruco>
            {
            new CartaTruco { Numero = 1, Palo = "Espada", Valor = 14 },
            new CartaTruco { Numero = 2, Palo = "Espada", Valor = 9 },
            new CartaTruco { Numero = 3, Palo = "Espada", Valor = 10 },
            new CartaTruco { Numero = 4, Palo = "Espada", Valor = 1 },
            new CartaTruco { Numero = 5, Palo = "Espada", Valor = 2 },
            new CartaTruco { Numero = 6, Palo = "Espada", Valor = 3 },
            new CartaTruco { Numero = 7, Palo = "Espada", Valor = 12 },
            new CartaTruco { Numero = 10, Palo = "Espada", Valor = 5 },
            new CartaTruco { Numero = 11, Palo = "Espada", Valor = 6 },
            new CartaTruco { Numero = 12, Palo = "Espada", Valor = 7 },
            new CartaTruco { Numero = 1, Palo = "Oro", Valor = 8 },
            new CartaTruco { Numero = 2, Palo = "Oro", Valor = 9 },
            new CartaTruco { Numero = 3, Palo = "Oro", Valor = 10 },
            new CartaTruco { Numero = 4, Palo = "Oro", Valor = 1 },
            new CartaTruco { Numero = 5, Palo = "Oro", Valor = 2 },
            new CartaTruco { Numero = 6, Palo = "Oro", Valor = 3 },
            new CartaTruco { Numero = 7, Palo = "Oro", Valor = 11 },
            new CartaTruco { Numero = 10, Palo = "Oro", Valor = 5 },
            new CartaTruco { Numero = 11, Palo = "Oro", Valor = 6 },
            new CartaTruco { Numero = 12, Palo = "Oro", Valor = 7 },
            new CartaTruco { Numero = 1, Palo = "Copa", Valor = 8 },
            new CartaTruco { Numero = 2, Palo = "Copa", Valor = 9 },
            new CartaTruco { Numero = 3, Palo = "Copa", Valor = 10 },
            new CartaTruco { Numero = 4, Palo = "Copa", Valor = 1 },
            new CartaTruco { Numero = 5, Palo = "Copa", Valor = 2 },
            new CartaTruco { Numero = 6, Palo = "Copa", Valor = 3 },
            new CartaTruco { Numero = 7, Palo = "Copa", Valor = 4 },
            new CartaTruco { Numero = 10, Palo = "Copa", Valor = 5 },
            new CartaTruco { Numero = 11, Palo = "Copa", Valor = 6 },
            new CartaTruco { Numero = 12, Palo = "Copa", Valor = 7 },
            new CartaTruco { Numero = 1, Palo = "Basto", Valor = 13 },
            new CartaTruco { Numero = 2, Palo = "Basto", Valor = 9 },
            new CartaTruco { Numero = 3, Palo = "Basto", Valor = 10 },
            new CartaTruco { Numero = 4, Palo = "Basto", Valor = 1 },
            new CartaTruco { Numero = 5, Palo = "Basto", Valor = 2 },
            new CartaTruco { Numero = 6, Palo = "Basto", Valor = 3 },
            new CartaTruco { Numero = 7, Palo = "Basto", Valor = 4 },
            new CartaTruco { Numero = 10, Palo = "Basto", Valor = 5 },
            new CartaTruco { Numero = 11, Palo = "Basto", Valor = 6 },
            new CartaTruco { Numero = 12, Palo = "Basto", Valor = 7 }
            };

            Serializadora.SerializarAXml("valorCartasTruco.xml", cartas);
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
