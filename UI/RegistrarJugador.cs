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
    public partial class RegistrarJugador : Form
    {
        public RegistrarJugador()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            List<Jugador> listaAux = JugadorSql.LeerSql();
            Jugador nuevoJugador = new Jugador(12, txb_NombreJugador.Text, txb_Clave.Text, 0, 0, false);
            try
            {
                validarTxtIngresados();
            }
            catch (Exception)
            {
                lbl_Error.Text = ("Error. Se ingresaron mal los datos");
            }


            if (nuevoJugador + listaAux)
            {
                lbl_Jugador.Visible = true;
                nuevoJugador.EventoString += NotificarCambio;
                nuevoJugador.NombreJugador = "Error. El jugador ya esta registrado en el sistema";
                lbl_Jugador.Text = nuevoJugador.MostrarJugador();

            }
            else
            {
                try
                {
                    JugadorSql.Guardar(nuevoJugador);
                    MessageBox.Show("El jugador se registro en el sistema con exitos!!");


                }
                catch (Exception)
                {
                    MessageBox.Show("Error. El jugador ya esta registrado en el sistema");
                }
            }
        }

        public void NotificarCambio(string msj)
        {
            MessageBox.Show(msj);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarTxtIngresados()
        {
            bool todoOK = false;

            if (!String.IsNullOrEmpty(txb_NombreJugador.Text) && !String.IsNullOrEmpty(txb_Clave.Text))
            {
                todoOK = true;
            }
            else
            {
                lbl_Error.Text = "ERROR";
            }


            if (Validadora.ValidarCadena(txb_NombreJugador.Text))
            {
                todoOK = true;
            }


            return todoOK;
        }
    }
}
