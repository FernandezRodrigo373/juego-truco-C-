using System;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public class CartaTruco
    {
        private int numero;
        private string palo; 
        private int valor;

        public CartaTruco()
        {

        }

        public CartaTruco(int numero, string palo, int valor)
        {
            this.numero = numero;
            this.palo = palo;
            this.valor = valor;
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public string Palo
        {
            get
            {
                return this.palo;
            }
            set
            {
                this.palo = value;
            }
        }

        public int Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                this.valor = value;
            }
        }

        public static void EstablecerValorParaEnvido(Jugador jugadorUno, Jugador jugadorDos)
        {
            foreach (CartaTruco unaCarta in jugadorUno.CartasObtenidas)
            {
                if (unaCarta.numero > 9 && unaCarta.numero < 13)
                {
                    unaCarta.valor = 0;
                }
            }   
            
            foreach (CartaTruco unaCarta in jugadorDos.CartasObtenidas)
            {
                if (unaCarta.numero > 9 && unaCarta.numero < 13)
                {
                    unaCarta.valor = 0;
                }
            }


        }

    }
}
