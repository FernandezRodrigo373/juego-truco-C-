using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public delegate void DelegateString(string msg);
    public class Jugador
    {
        private List<CartaTruco> cartasObtenidas;

        private int idJugador;
        private string nombreJugador;
        private string passwordJugador;


      

        private bool cantarEnvido;
        private bool quererEnvido;
        private bool cantarTruco;
        private bool quererTruco;

        private int cantidadPuntos = 0;

        private bool esMano;
        public bool estaJugando;

        private int partidasGanadasPorJugador = 0;
        private int partidasPerdidasPorJugador = 0;

        public event DelegateString EventoString;

        public Jugador(int idJugador, string nombreJugador, string passwordJugador, int partidasGanadas, int PartidasPerdidasPorJugador, bool estaJugando)
        {
            this.idJugador = idJugador;
            this.nombreJugador = nombreJugador;
            this.passwordJugador = passwordJugador;
            this.partidasGanadasPorJugador = partidasGanadas;
            this.partidasPerdidasPorJugador = PartidasPerdidasPorJugador;
            this.estaJugando = estaJugando;
        }

        public Jugador(int idJugador, string nombre, string contrasenia, int partidasGanadas, int partidasPerdidas, List<CartaTruco> cartasObtenidas, bool envido, bool quererEnvido, bool truco, bool quererTruco, int cantidadPuntos, bool esMano, bool estaEnPartida) : this(idJugador, nombre, contrasenia, partidasGanadas, partidasPerdidas, estaEnPartida)
        {
            this.cartasObtenidas = cartasObtenidas;
            this.cantarEnvido = envido;
            this.quererEnvido = quererEnvido;
            this.cantarTruco = truco;
            this.quererTruco = quererTruco;
            this.cantidadPuntos = cantidadPuntos;
            this.esMano = esMano;
        }

        public int IdJugador
        {
            get
            {
                return this.idJugador;
            }
        }

        public string NombreJugador
        {
            get
            {
                return this.nombreJugador;
            }
            set
            {
                this.nombreJugador = value;
                EventoString(nombreJugador);
            }
        }

        public string PassWordJugador

        {
            get
            {
                return this.passwordJugador;
            }
        }

        public int PartidasGanadasPorJugador
        {
            get
            {
                return this.partidasGanadasPorJugador;
            }
            set
            {
                this.partidasGanadasPorJugador = value;
            }
        }

        public int PartidasPerdidasPorJugador
        {
            get
            {
                return this.partidasPerdidasPorJugador;
            }
            set
            {
                this.partidasPerdidasPorJugador = value;
            }
        }

        public int CantidadDePartidas
        {
            get
            {
                return this.partidasPerdidasPorJugador + this.partidasGanadasPorJugador;
            }

        }

        public List<CartaTruco> CartasObtenidas
        {
            get
            {
                return this.cartasObtenidas;
            }
            set
            {
                this.cartasObtenidas = value;
            }
        }

        public bool CantarEnvido
        {
            get
            {
                return this.cantarEnvido;
            }
        }

        public bool QuererEnvido
        {
            get
            {
                return this.quererEnvido;
            }
        }

        public bool CantarTruco
        {
            get
            {
                return this.cantarTruco;
            }
        }

        public bool QuererTruco
        {
            get
            {
                return this.quererTruco;
            }
        }

        public int CantidadPuntos
        {
            get
            {
                return this.cantidadPuntos;
            }
            set
            {
                this.cantidadPuntos = value;
            }
        }

        public bool EsMano
        {
            get
            {
                return this.esMano;
            }
        }

        public string EstaEnPartida
        {
            get
            {
                return EstaJugando();
            }
        }

        public string EstaJugando()
        {

            if (this.estaJugando == true)
            {
                return "Esta Jugando aguarde a que termine";
            }
            else if (this.estaJugando == false)
            {
                return "Disponible para Jugar";
            }
            return "";

        }



        public static int PasarEstadoInt(bool estado)
        {
            int estadoInt = 3;

            if (estado == true)
            {
                estadoInt = 1;
            }
            else if (estado == false)
            {
                estadoInt = 0;
            }

            return estadoInt;
        }

        public static bool ObtenerEstadoSql(string estadoEntero)
        {
            bool estado = false;

            if (estadoEntero == "false")
            {
                estado = false;
            }
            else if (estadoEntero == "True")
            {
                estado = true;
            }

            return estado;
        }



        public static Jugador ObtenerJugador(string nombreDelJugador)
        {
            Jugador jugadorABuscar;

                
            foreach (Jugador jugadorEnLista in JugadorSql.LeerSql())
            {
                if (jugadorEnLista.nombreJugador == nombreDelJugador)
                {
                    jugadorABuscar = jugadorEnLista;
                    return jugadorABuscar;
                }
            }
            return null;

        }

        public static string ObtenerNombreDelJugador(Jugador jugador)
        {
            try
            {
                if (jugador == null)
                {
                    throw new ArgumentNullException("El jugador no existe");
                }

                List<Jugador> jugadoresEncontrados = JugadorSql.LeerSql();

                string nombreJugadorBuscado = "";

                foreach (Jugador jugadorAObtner in jugadoresEncontrados)
                {
                    if (jugadorAObtner.nombreJugador == jugador.nombreJugador)
                    {
                        nombreJugadorBuscado = jugadorAObtner.nombreJugador;
                        break;
                    }
                }

                return nombreJugadorBuscado;
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentException("El jugador aun no esta instanciado", e);
            }
        }



        public void CantarEnvidoJugador()
        {
            Random numeroRandomParaEnvido = new Random();

            int cantarEnvidoRandom = numeroRandomParaEnvido.Next(1, 3);


            if (cantarEnvidoRandom == 1)
            {
                this.cantarEnvido = true;
            }
            else
            {
                this.cantarEnvido = false;
            }
        }

        public void QuererEnvidoJugador()
        {
            Random numeroRandomParaQuererEnvido = new Random();

            int quererEnvidoRandom = numeroRandomParaQuererEnvido.Next(1, 3);

            if (quererEnvidoRandom == 1)
            {
                this.quererEnvido = true;
            }
            else
            {
                this.quererEnvido = false;
            }
        }

        public void CantarTrucoJugador()
        {
            Random numeroRandomParaTruco = new Random();
            int cantarTrucoRandom = numeroRandomParaTruco.Next(1, 3);

            if (cantarTrucoRandom == 1)
            {
                this.cantarTruco = true;
            }
            else
            {
                this.cantarTruco = false;
            }
        }

        public void QuererTrucoJugador()
        {
            Random numeroRandomParaQuererTruco = new Random();

            int quererTrucoRandom = numeroRandomParaQuererTruco.Next(1, 3);

            if (quererTrucoRandom == 1)
            {
                this.quererTruco = true;
            }
            else
            {
                this.quererTruco = false;
            }
        }

        public void ConfirmarEsMano()
        {
            Random numeroRandomParaSaberSiEsMano = new Random();
            int esManoRandom = numeroRandomParaSaberSiEsMano.Next(1, 3);

            if (esManoRandom == 1)
            {
                this.esMano = true;
            }
            else
            {
                this.esMano = false;
            }
        }

        public void AcumularPuntosDePartida(int puntos)
        {
            this.cantidadPuntos += puntos;
        }

        public int AumentarCantidadPartidasGanadas()
        {
            return this.partidasGanadasPorJugador++;
        }

        public int AumentarCantidadPartidasPerdidas()
        {
            return this.partidasPerdidasPorJugador++;
        }

        //sobrecarga operadores
        public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos)
        {
            return jugadorUno.NombreJugador == jugadorDos.NombreJugador;
        }

        public static bool operator !=(Jugador jugadorUno, Jugador jugadorDos)
        {
            return !(jugadorUno == jugadorDos);
        }

        public string MostrarJugador()
        {
            return this.nombreJugador;
        }
    }
}
