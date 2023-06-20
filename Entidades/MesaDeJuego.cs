using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public class MesaDeJuego
    {

        private Action<string> delegadoCartas;

        private int idMesaDeJuego;
        private int numeroMesaDeJuego;

        private Jugador jugadorUno;
        private Jugador jugadorDos;
        private int puntajeJugadorUno;
        private int puntajeJugadorDos;


        private DateTime fecha;
        private DateTime duracionPartida;



        public MesaDeJuego(int idMesaDeJuego, int numeroMesaDeJuego, DateTime fecha)
        {
            this.idMesaDeJuego = idMesaDeJuego;
            this.numeroMesaDeJuego = numeroMesaDeJuego;
            this.fecha = fecha;
        }

        public MesaDeJuego(int idMesa, int numeroMesa, int puntajeJugadorUno, int puntajeJugadorDos, DateTime duracionPartida)
        {
            this.idMesaDeJuego = idMesa;
            this.numeroMesaDeJuego = numeroMesa;
            this.puntajeJugadorUno = puntajeJugadorUno;
            this.puntajeJugadorDos = puntajeJugadorDos;
            this.duracionPartida = duracionPartida;

        }

        public MesaDeJuego(int idMesa, int numeroMesa, Jugador jugadorUno, Jugador jugadorDos, DateTime duracionPartida) : this(idMesa, numeroMesa, duracionPartida)// Para jugar al truco
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.duracionPartida = duracionPartida;
        }

        public Jugador JugadorUno 
        { 
            get { return this.jugadorUno; }
            set { this.jugadorUno = value; }
        }

        public Jugador JugadorDos
        {
            get { return this.jugadorDos; }
            set { this.jugadorDos = value; }
        }


        public Action<string> DelegadoCartas
        {
            get
            {
                return this.delegadoCartas;
            }
            set
            {
                this.delegadoCartas = value;
            }
        }

        public int IdMesaDeJuego
        {
            get
            {
                return this.idMesaDeJuego;
            }
        }

        public int NumeroMesaDeJuego
        {
            get
            {
                return this.numeroMesaDeJuego;
            }
        }

        public string NombreJugadorUno
        {
            get
            {
                return this.ObtenerNombreJugadorUno();
            }
        }

        public string NombreJugadorDos
        {
            get
            {
                return this.ObtenerNombreJugadorDos();
            }
        }

        public string ObtenerNombreJugadorUno()
        {
            if (this.jugadorUno is null)
            {
                return "";
            }
            else
            {
                return this.JugadorUno.NombreJugador;
            }

        }

        public string ObtenerNombreJugadorDos()
        {

            if (this.jugadorDos is null)
            {
                return "";
            }
            else
            {
                return this.JugadorDos.NombreJugador;
            }

        }



        public int PuntajeJugadorUno
        {
            get
            {
                return this.puntajeJugadorUno;
            }
        }

        public int PuntajeJugadorDos
        {
            get
            {
                return this.puntajeJugadorDos;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        public string DuracionPartida
        {
            get
            {
                return ObtenerDuracion(this.duracionPartida);
            }
        }

        public string ObtenerDuracion(DateTime fecha)
        {
            return fecha.ToString("mm:ss");
        }

        public static DateTime DuracionDeLaPartida(string tiempo)
        {
            try
            {
                int minutosTotales = int.Parse(tiempo);
                int horas = minutosTotales / 60;
                int minutos = minutosTotales - horas * 60;

                DateTime dateTime = DateTime.Now.Date.AddHours(horas).AddMinutes(minutos);
                return dateTime;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERROR.", ex);
            }
        }

        public static DateTime TransformarTiempoDeJuego(string tiempo)
        {
            string[] arraytiempo = new string[2];
            DateTime dateTime = DateTime.Now;
            arraytiempo = tiempo.Split(':');

            foreach (string item in arraytiempo)
            {
                dateTime.AddMinutes(Double.Parse(item));
            }



            return dateTime;
        }

        public static int ObtenerUltimoIdTabla(List<MesaDeJuego> mesaAux)
        {
            int auxGuardarUltimoId = 0;
            int flag = 0;

            for (int i = 0; i < mesaAux.Count; i++)
            {
                if (flag == 0 || mesaAux[i].idMesaDeJuego > auxGuardarUltimoId)
                {
                    auxGuardarUltimoId = mesaAux[i].idMesaDeJuego;
                    flag = 1;
                }
            }

            return auxGuardarUltimoId;
        }

        public static int ObtenerUltimoNumeroMesa(List<MesaDeJuego> mesaAux)
        {
            int auxGuardarUltimoIdMesa = 0;
            int flagUltimoId = 0;

            for (int i = 0; i < mesaAux.Count; i++)
            {
                if (flagUltimoId == 0 || mesaAux[i].numeroMesaDeJuego > auxGuardarUltimoIdMesa)
                {
                    auxGuardarUltimoIdMesa = mesaAux[i].numeroMesaDeJuego;
                    flagUltimoId = 1;
                }
            }

            return auxGuardarUltimoIdMesa;
        }


        public string EstablecerGanador()
        {
            string jugadorGanador = "empataron";

            if (this.jugadorUno.CantidadPuntos >= 15)
            {
                jugadorGanador = this.jugadorUno.NombreJugador;
            }
            else if (this.jugadorDos.CantidadPuntos >= 15)
            {
                jugadorGanador = this.jugadorDos.NombreJugador;
            }

            return jugadorGanador;
        }

        public string SumarEstadisticasGanador()
        {
            string jugadorGanador = "empataron";

            if (this.jugadorUno.CantidadPuntos >= 15)
            {
                jugadorGanador = this.jugadorUno.NombreJugador;
                this.jugadorUno.AumentarCantidadPartidasGanadas();
                this.jugadorDos.AumentarCantidadPartidasPerdidas();
            }
            else if (this.jugadorDos.CantidadPuntos >= 15)
            {
                jugadorGanador = this.jugadorDos.NombreJugador;
                this.jugadorDos.AumentarCantidadPartidasGanadas();
                this.jugadorUno.AumentarCantidadPartidasPerdidas();
            }

            return jugadorGanador;
        }


        public void JugarPartida(Truco maso, CancellationToken ct)
        {
            List<CartaTruco> masoCartas;
            masoCartas = maso.CrearMazoDeCartas();

            maso.RepartirCartas(masoCartas, this.jugadorUno, this.jugadorDos);

            Random tiempoDeEspera = new Random();
            Thread.Sleep(tiempoDeEspera.Next(1500, 3000));

            MostrarDatosPartida();

            this.delegadoCartas?.Invoke(maso.AcumularPuntosJugadores(this.jugadorUno, this.jugadorDos));


            while ((this.jugadorUno.CantidadPuntos <= 15 && this.jugadorDos.CantidadPuntos <= 15) && !ct.IsCancellationRequested)
            {
                this.jugadorUno.CartasObtenidas.Clear();
                this.jugadorDos.CartasObtenidas.Clear();

                masoCartas = maso.CrearMazoDeCartas();
                maso.RepartirCartas(masoCartas, this.jugadorUno, this.jugadorDos);
                MostrarDatosPartida();

                this.delegadoCartas?.Invoke(maso.AcumularPuntosJugadores(this.jugadorUno, this.jugadorDos));
            }

            if (ct.IsCancellationRequested)
            {
                this.delegadoCartas?.Invoke("Se cancelo la partida");
            }
            else
            {
                this.delegadoCartas?.Invoke($"El ganador de la sala es: {SumarEstadisticasGanador()}");
            }

        }




        public string MostrarCartas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n__________________________________________");
            sb.AppendLine("|                                                                    |");
            sb.AppendFormat("|   Cartas Jugador: {0, -15}      |\n", this.JugadorUno.NombreJugador);
            sb.AppendLine("|_________________________________________|");


            sb.AppendLine(" ____________________________");
            foreach (CartaTruco cartaJugadorUno in jugadorUno.CartasObtenidas)
            {
                sb.AppendFormat("|    {0, -3}     |     {1, -10}       |\n", cartaJugadorUno.Numero, cartaJugadorUno.Palo);
            }
            sb.AppendLine("|___________|______________|");

            sb.AppendLine("\n__________________________________________");
            sb.AppendLine("|                                                                    |");
            sb.AppendFormat("|   Cartas Jugador: {0, -15}      |\n", this.JugadorDos.NombreJugador);
            sb.AppendLine("|_________________________________________|");

            sb.AppendLine(" ____________________________");
            foreach (CartaTruco cartaJugadorDos in jugadorDos.CartasObtenidas)
            {
                sb.AppendFormat("|    {0, -3}     |     {1, -10}       |\n", cartaJugadorDos.Numero, cartaJugadorDos.Palo);
            }
            sb.AppendLine("|___________|______________|");


            return sb.ToString();
        }

        public void MostrarDatosPartida()
        {

            if (this.JugadorUno.EsMano == true)
            {
                delegadoCartas?.Invoke($"{this.JugadorUno.NombreJugador} es Mano");
            }

            delegadoCartas?.Invoke($"{this.JugadorDos.NombreJugador} es Mano");


            delegadoCartas?.Invoke(MostrarCartas());

            if (this.JugadorUno.CantarEnvido == false && this.JugadorDos.CantarEnvido == false)
            {
                delegadoCartas?.Invoke("Ningun jugador canto envido");
            }
            else
            {
                if (jugadorUno.CantarEnvido == true && jugadorDos.QuererEnvido == true)
                {
                    delegadoCartas?.Invoke($"El jugador {jugadorUno.NombreJugador}, canto Envido!!! y el jugador {jugadorDos.NombreJugador} quiso.");
                }
                else if (jugadorUno.CantarEnvido == true && jugadorDos.QuererEnvido == false)
                {
                    delegadoCartas?.Invoke($"El jugador {jugadorUno.NombreJugador}, canto Envido!!! y el jugador {jugadorDos.NombreJugador} no quiso.");
                }
                else if (jugadorDos.CantarEnvido == true && jugadorUno.QuererEnvido == true)
                {
                    delegadoCartas?.Invoke($"El jugador {jugadorDos.NombreJugador}, canto Envido!!! y el jugador {jugadorUno.NombreJugador} quiso.");
                }
                else if (jugadorDos.CantarEnvido == true && jugadorUno.QuererEnvido == false)
                {
                    delegadoCartas?.Invoke($"El jugador {jugadorDos.NombreJugador}, canto Envido!!! y el jugador {jugadorUno.NombreJugador} quiso.");
                }

                Jugador ganadorEnvido = Truco.DevolverGanadorEnvido(jugadorUno, jugadorDos);

                if (ganadorEnvido == jugadorUno)
                {
                    delegadoCartas?.Invoke($"El Ganador Del Envido es: {jugadorUno.NombreJugador}");
                }
                else if (ganadorEnvido == jugadorDos)
                {
                    delegadoCartas?.Invoke($"El Ganador Del Envido es: {jugadorDos.NombreJugador}");

                }
            }

            delegadoCartas?.Invoke("\n");
        }
    }
}
