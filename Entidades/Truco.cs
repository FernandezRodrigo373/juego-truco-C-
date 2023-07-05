using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public class Truco
    {
        private List<CartaTruco> mazoDeCartas;

        public Truco(List<CartaTruco> mazoDeCartas)
        {
            this.mazoDeCartas = mazoDeCartas;
        }

        public List<CartaTruco> MazoDeCartas
        {
            get
            {
                return this.mazoDeCartas;
            }
            set
            {
                this.mazoDeCartas = value;
            }
        }


        public void RepartirCartas(List<CartaTruco> mazoDeCartas, Jugador jugadorUno, Jugador jugadorDos)
        {
            List<CartaTruco> mazoJugadorUno = new List<CartaTruco>();
            List<CartaTruco> mazoJugadorDos = new List<CartaTruco>();

            jugadorUno.CartasObtenidas = mazoJugadorUno;
            jugadorDos.CartasObtenidas = mazoJugadorDos;

            try
            {
                Random randomCartaRepartida = new Random();

                for (int i = 0; i < 3; i++)
                {
                    int indiceCartaObtenida = randomCartaRepartida.Next(1, mazoDeCartas.Count);

                    if (indiceCartaObtenida >= 0 && indiceCartaObtenida < mazoDeCartas.Count)
                    {
                        jugadorUno.CartasObtenidas.Add(mazoDeCartas[indiceCartaObtenida]);
                        mazoDeCartas.RemoveAt(indiceCartaObtenida);

                        indiceCartaObtenida = randomCartaRepartida.Next(1, mazoDeCartas.Count);

                        jugadorDos.CartasObtenidas.Add(mazoDeCartas[indiceCartaObtenida]);
                        mazoDeCartas.RemoveAt(indiceCartaObtenida);
                    }
                    else
                    {
                        Console.WriteLine("El índice generado está fuera del rango válido.");
                    }
                }


            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine($"Ocurrio un problema: {e.Message}");
            }
        }

        public Jugador TirarCartas(Jugador jugadorUno, Jugador jugadorDos, int ronda) //jugar
        {
            ronda -= 1;

            if (jugadorUno.CartasObtenidas[ronda].Valor > jugadorDos.CartasObtenidas[ronda].Valor)
            {
                return jugadorUno;

            }
            else if (jugadorUno.CartasObtenidas[ronda].Valor < jugadorDos.CartasObtenidas[ronda].Valor)
            {
                return jugadorDos;
            }
            else if (jugadorUno.CartasObtenidas[ronda].Valor == jugadorDos.CartasObtenidas[ronda].Valor && jugadorUno.EsMano == true)
            {
                return jugadorUno;
            }
            else if (jugadorUno.CartasObtenidas[ronda].Valor == jugadorDos.CartasObtenidas[ronda].Valor && jugadorUno.EsMano == false)
            {
                return jugadorDos;
            }


            return null;
            
        }



        public string MostrarCartasJugadas(Jugador jugadorUno, Jugador jugadorDos, int ronda)
        {

            StringBuilder sb = new StringBuilder();
            ronda -= 1;

            CartaTruco cartaUno = jugadorUno.CartasObtenidas[ronda];
            CartaTruco cartaDos = jugadorDos.CartasObtenidas[ronda];

            sb.AppendLine($"El Jugador {jugadorUno.NombreJugador} tiro: {cartaUno.Palo} {cartaUno.Numero}");
            Thread.Sleep(new Random().Next(250, 400));
            sb.AppendLine($"El Jugadpor {jugadorDos.NombreJugador} tiro: {cartaDos.Palo} {cartaDos.Numero}");
            Thread.Sleep(new Random().Next(250, 400));

            string jugadorMano = jugadorUno.NombreJugador;
            string jugadorNoMano = jugadorDos.NombreJugador;
            if (!jugadorUno.EsMano)
            {
                jugadorMano = jugadorDos.NombreJugador;
                jugadorNoMano = jugadorUno.NombreJugador;
            }

            if (cartaUno.Valor > cartaDos.Valor)
            {
                sb.AppendLine($"El Jugador {jugadorMano} mato a la carta del jugador {jugadorNoMano}");
            }
            else if (cartaUno.Valor < cartaDos.Valor)
            {
                sb.AppendLine($"El Jugador {jugadorNoMano} mato a la carta del jugador {jugadorMano}");
            }
            else
            {
                sb.AppendLine($"El Jugador {jugadorMano} mato a la carta del jugador {jugadorNoMano} porque es Mano");
            }

            Thread.Sleep(new Random().Next(250, 400));

            return sb.ToString();
            
        }

        public Jugador DevolverGanadorTruco(Jugador jugadorUno, Jugador jugadorDos)
        {
            Jugador jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 1);

            if (jugadorGanadorRonda is not null)
            {
                if (jugadorUno.EsMano)
                {
                    if (jugadorUno.CantarTruco && jugadorDos.QuererTruco)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 2);
                        if (jugadorGanadorRonda == jugadorUno)
                        {
                            jugadorUno.AcumularPuntosDePartida(2);
                        }
                        else if (jugadorGanadorRonda == jugadorDos)
                        {
                            jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 3);
                            if (jugadorGanadorRonda == jugadorDos)
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                            else
                            {
                                jugadorUno.AcumularPuntosDePartida(2);
                            }
                        }
                        else
                        {
                            jugadorUno.AcumularPuntosDePartida(2);
                        }
                    }
                    else if (jugadorUno.CantarTruco && !jugadorDos.QuererTruco)
                    {
                        jugadorUno.AcumularPuntosDePartida(3);
                    }
                    else if (!jugadorUno.CantarTruco)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 2);
                        if (jugadorGanadorRonda == jugadorDos && jugadorDos.CantarTruco && jugadorUno.QuererTruco)
                        {
                            jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 3);
                            if (jugadorGanadorRonda == jugadorDos)
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                            else
                            {
                                jugadorUno.AcumularPuntosDePartida(2);
                            }
                        }
                        else if (jugadorGanadorRonda == jugadorDos && jugadorDos.CantarTruco && !jugadorUno.QuererTruco)
                        {
                            jugadorDos.AcumularPuntosDePartida(3);
                        }
                    }
                }
                else
                {
                    if (jugadorDos.CantarTruco && jugadorUno.QuererTruco)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorUno, 2);
                        if (jugadorGanadorRonda == jugadorDos)
                        {
                            jugadorDos.AcumularPuntosDePartida(2);
                        }
                        else
                        {
                            jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 3);
                            if (jugadorGanadorRonda == jugadorUno)
                            {
                                jugadorUno.AcumularPuntosDePartida(2);
                            }
                            else
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                        }
                    }
                    else if (jugadorDos.CantarTruco && !jugadorUno.QuererTruco)
                    {
                        jugadorDos.AcumularPuntosDePartida(3);
                    }
                    else if (!jugadorDos.CantarTruco)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 2);
                        if (jugadorGanadorRonda == jugadorUno && jugadorUno.CantarTruco && jugadorDos.QuererTruco)
                        {
                            jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 3);
                            if (jugadorGanadorRonda == jugadorUno)
                            {
                                jugadorUno.AcumularPuntosDePartida(2);
                            }
                            else
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                        }
                        else if (jugadorGanadorRonda == jugadorUno && jugadorUno.CantarTruco && !jugadorDos.QuererTruco)
                        {
                            jugadorUno.AcumularPuntosDePartida(3);
                        }
                    }
                }
            }

            if (jugadorUno.CantidadPuntos > jugadorDos.CantidadPuntos)
            {
                jugadorGanadorRonda = jugadorUno;
            }
            else if (jugadorUno.CantidadPuntos < jugadorDos.CantidadPuntos)
            {
                jugadorGanadorRonda = jugadorDos;
            }

            return jugadorGanadorRonda;
        }

        public string MostrarCartasTruco(Jugador jugadorUno, Jugador jugadorDos)
        {
            Jugador jugadorGanadorRonda = null;
            StringBuilder sb = new StringBuilder();

            jugadorUno.CantarTrucoJugador();
            jugadorUno.QuererTrucoJugador();
            jugadorDos.CantarEnvidoJugador();
            jugadorDos.QuererEnvidoJugador();


            jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 1);

            sb.AppendLine("1ra Ronda:");
            sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 1));


            if (jugadorGanadorRonda is not null && jugadorUno.EsMano == true)
            {
                if (jugadorUno.CantarTruco == true && jugadorDos.QuererTruco == true) 
                {
                    jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 2);
                    sb.AppendLine("2da Ronda:");
                    Thread.Sleep(new Random().Next(1000, 2500));
                    sb.AppendLine($"El Jugador {jugadorUno.NombreJugador} canto Truco!!, y el jugador {jugadorDos.NombreJugador} dijo quiero!!\n");
                    Thread.Sleep(new Random().Next(1000, 2500));
                    sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 2));

                    if (jugadorGanadorRonda == jugadorUno)
                    {
                        jugadorUno.AcumularPuntosDePartida(4);
                    }
                    else if (jugadorGanadorRonda == jugadorDos)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 3);
                        sb.AppendLine("3era Ronda:");
                        Thread.Sleep(new Random().Next(1000, 2500));
                        sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));

                        if (jugadorGanadorRonda == jugadorUno)
                        {
                            jugadorUno.AcumularPuntosDePartida(4);
                        }
                        else if (jugadorGanadorRonda == jugadorDos)
                        {
                            jugadorDos.AcumularPuntosDePartida(4);
                        }
                        else 
                        {
                            jugadorUno.AcumularPuntosDePartida(4);
                        }
                    }
                    else
                    {
                        sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));
                        jugadorUno.AcumularPuntosDePartida(4);
                    }
                }
                else if (jugadorUno.CantarTruco  == true && jugadorDos.QuererTruco == false)
                {
                    Thread.Sleep(new Random().Next(1000, 2500));
                    sb.AppendLine($"El Jugador {jugadorUno.NombreJugador} canto Truco!!, y el jugador {jugadorDos.NombreJugador} dijo no quiero!!\n");
                    jugadorUno.AcumularPuntosDePartida(3);
                }
                else if (jugadorUno.CantarTruco == false)
                {
                    jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 2);
                    sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 2));

                    if (jugadorGanadorRonda == jugadorDos)
                    {
                        if (jugadorDos.CantarTruco == true && jugadorUno.QuererTruco == true)
                        {
                            jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 3);
                            Thread.Sleep(new Random().Next(1000, 2500));
                            sb.AppendLine("3era Ronda:");
                            sb.AppendLine($"El Jugador {jugadorDos.NombreJugador} canto Truco!!, y el jugador {jugadorUno.NombreJugador} dijo quiero!!\n");
                            Thread.Sleep(new Random().Next(1000, 2500));
                            sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));

                            if (jugadorGanadorRonda == jugadorDos)
                            {
                                jugadorDos.AcumularPuntosDePartida(4);
                            }
                            else if (jugadorGanadorRonda == jugadorUno)
                            {
                                jugadorUno.AcumularPuntosDePartida(4);
                            }
                            else // si entra aca empataron en el truco
                            {
                                jugadorUno.AcumularPuntosDePartida(4);
                            }
                        }
                        else if (jugadorDos.CantarTruco == true && jugadorUno.QuererTruco == false)
                        {
                            Thread.Sleep(new Random().Next(1000, 3000));
                            sb.AppendLine($"El Jugador {jugadorDos.NombreJugador} canto Truco!!, y el jugador {jugadorUno.NombreJugador} dijo no quiero!!\n");
                            jugadorDos.AcumularPuntosDePartida(3);
                        }
                    }
                }
            }
            else if (jugadorGanadorRonda is not null && jugadorUno.EsMano == false)
            {
                if (jugadorDos.CantarTruco == true && jugadorUno.QuererTruco == true)
                {
                    jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorUno, 2);
                    Thread.Sleep(new Random().Next(1000, 2500));
                    sb.AppendLine("2da Ronda:");
                    sb.AppendLine($"El Jugador {jugadorDos.NombreJugador} canto Truco!!, y el jugador {jugadorUno.NombreJugador} dijo quiero!!\n");
                    Thread.Sleep(new Random().Next(1000, 2500));
                    sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 2));

                    if (jugadorGanadorRonda == jugadorDos)
                    {
                        jugadorDos.AcumularPuntosDePartida(4);
                    }
                    else if (jugadorGanadorRonda == jugadorUno)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 3);
                        Thread.Sleep(new Random().Next(1000, 3000));
                        sb.AppendLine("3era Ronda:");
                        sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));

                        if (jugadorGanadorRonda == jugadorDos)
                        {
                            jugadorDos.AcumularPuntosDePartida(2);
                        }
                        else if (jugadorGanadorRonda == jugadorUno)
                        {
                            jugadorUno.AcumularPuntosDePartida(2);
                        }
                        else 
                        {
                            jugadorDos.AcumularPuntosDePartida(2);
                        }
                    }
                    else
                    {
                        jugadorDos.AcumularPuntosDePartida(4);
                    }
                }
                else if (jugadorDos.CantarTruco == true && jugadorUno.QuererTruco == false)// no al truco
                {
                    Thread.Sleep(new Random().Next(1000, 2500));
                    sb.AppendLine($"El Jugador {jugadorDos.NombreJugador} canto Truco!!, y el jugador {jugadorUno.NombreJugador} dijo no quiero!!\n");
                    jugadorDos.AcumularPuntosDePartida(3);
                }
                else if (jugadorDos.CantarTruco == false)
                {
                    jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 2);
                    Thread.Sleep(new Random().Next(1000, 2500));
                    sb.AppendLine("2da Ronda:");
                    sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 2));

                    if (jugadorGanadorRonda == jugadorUno)
                    {
                        if (jugadorUno.CantarTruco == true && jugadorDos.QuererTruco == true)
                        {
                            jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 3);
                            Thread.Sleep(new Random().Next(1000, 2500));
                            sb.AppendLine("3era Ronda:");
                            sb.AppendLine($"El Jugador {jugadorUno.NombreJugador} canto Truco!!, y el jugador {jugadorDos.NombreJugador} dijo quiero!!\n");
                            Thread.Sleep(new Random().Next(1000, 2500));
                            sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));

                            if (jugadorGanadorRonda == jugadorUno)
                            {
                                jugadorUno.AcumularPuntosDePartida(2);
                            }
                            else if (jugadorGanadorRonda == jugadorDos)
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                            else // si entra aca empataron en el truco
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                        }
                        else if (jugadorUno.CantarTruco == true && jugadorDos.QuererTruco == false)
                        {
                            Thread.Sleep(new Random().Next(1000, 2500));
                            sb.AppendLine($"El Jugador {jugadorUno.NombreJugador} canto Truco!!, y el jugador {jugadorDos.NombreJugador} dijo no quiero!!\n");
                            jugadorUno.AcumularPuntosDePartida(3);
                        }
                    }
                }
            }
            else
            {
                if (jugadorGanadorRonda == jugadorUno)// gano la 1era ronda jugador Uno
                {
                    if (jugadorUno.CantarTruco == true && jugadorDos.QuererTruco == true)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 2);
                        Thread.Sleep(new Random().Next(1000, 2500));
                        sb.AppendLine("2da Ronda:");
                        sb.AppendLine($"El Jugador {jugadorUno.NombreJugador} canto Truco!!, y el jugador {jugadorDos.NombreJugador} dijo quiero!!\n");
                        Thread.Sleep(new Random().Next(1000, 2500));
                        sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 2));

                        if (jugadorGanadorRonda == jugadorUno)
                        {
                            jugadorUno.AcumularPuntosDePartida(4);
                        }
                        else if (jugadorGanadorRonda == jugadorDos)
                        {
                            jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 3);
                            sb.AppendLine("3era Ronda:");
                            sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));

                            if (jugadorGanadorRonda == jugadorUno)
                            {
                                jugadorUno.AcumularPuntosDePartida(2);
                            }
                            else if (jugadorGanadorRonda == jugadorDos)
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                            else // si entra aca empataron en el truco
                            {
                                jugadorUno.AcumularPuntosDePartida(2);
                            }
                        }
                        else// si entra aca empataron en el truco
                        {
                            jugadorUno.AcumularPuntosDePartida(2);
                        }
                    }
                    else if (jugadorUno.CantarTruco == true && jugadorDos.QuererTruco == false)// no al truco
                    {
                        Thread.Sleep(new Random().Next(1000, 2500));
                        sb.AppendLine($"El Jugador {jugadorUno.NombreJugador} canto Truco!!, y el jugador {jugadorDos.NombreJugador} dijo no quiero!!\n");
                        jugadorUno.AcumularPuntosDePartida(3);
                    }
                    else if (jugadorUno.CantarTruco == false)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 2);
                        sb.AppendLine("2da Ronda:");
                        sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 2));

                        if (jugadorGanadorRonda == jugadorDos)
                        {
                            if (jugadorDos.CantarTruco == true && jugadorUno.QuererTruco == true)
                            {
                                jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorDos, 3);
                                Thread.Sleep(new Random().Next(1000, 2500));
                                sb.AppendLine("3era Ronda:");
                                sb.AppendLine($"El Jugador {jugadorDos.NombreJugador} canto Truco!!, y el jugador {jugadorUno.NombreJugador} dijo quiero!!\n");
                                Thread.Sleep(new Random().Next(1000, 2500));
                                sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));

                                if (jugadorGanadorRonda == jugadorDos)
                                {
                                    jugadorDos.AcumularPuntosDePartida(2);
                                }
                                else if (jugadorGanadorRonda == jugadorUno)
                                {
                                    jugadorUno.AcumularPuntosDePartida(2);
                                }
                                else 
                                {
                                    jugadorUno.AcumularPuntosDePartida(2);
                                }
                            }
                            else if (jugadorDos.CantarTruco == true && jugadorUno.QuererTruco == false)
                            {
                                sb.AppendLine($"El Jugador {jugadorDos.NombreJugador} canto Truco!!, y el jugador {jugadorUno.NombreJugador} dijo no quiero!!\n");
                                Thread.Sleep(new Random().Next(1000, 3000));
                                jugadorDos.AcumularPuntosDePartida(3);
                            }
                        }
                    }
                }
                else if (jugadorGanadorRonda == jugadorDos)// gano la 1era ronda jugador Dos
                {
                    if (jugadorDos.CantarTruco == true && jugadorUno.QuererTruco == true)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorUno, jugadorUno, 2);
                        Thread.Sleep(new Random().Next(1000, 2000));
                        sb.AppendLine("2da Ronda:");
                        sb.AppendLine($"El Jugador {jugadorDos.NombreJugador} canto Truco!!, y el jugador {jugadorUno.NombreJugador} dijo quiero!!\n");
                        Thread.Sleep(new Random().Next(1000, 2000));
                        sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 2));

                        if (jugadorGanadorRonda == jugadorDos)
                        {
                            jugadorDos.AcumularPuntosDePartida(4);
                        }
                        else if (jugadorGanadorRonda == jugadorUno)
                        {
                            jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 3);
                            sb.AppendLine("3era Ronda:");
                            Thread.Sleep(new Random().Next(1000, 2000));
                            sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));

                            if (jugadorGanadorRonda == jugadorDos)
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                            else if (jugadorGanadorRonda == jugadorUno)
                            {
                                jugadorUno.AcumularPuntosDePartida(2);
                            }
                            else // si entra aca empataron en el truco
                            {
                                jugadorDos.AcumularPuntosDePartida(2);
                            }
                        }
                        else// si entra aca empataron en el truco
                        {
                            jugadorDos.AcumularPuntosDePartida(4);
                        }
                    }
                    else if (jugadorDos.CantarTruco == true && jugadorUno.QuererTruco == false)// no al truco
                    {
                        Thread.Sleep(new Random().Next(1000, 2000));
                        sb.AppendLine($"El Jugador {jugadorDos.CantarTruco} canto Truco!!, y el jugador {jugadorUno.QuererTruco} dijo no quiero!!\n");
                        jugadorDos.AcumularPuntosDePartida(3);
                    }
                    else if (jugadorDos.CantarTruco == false)
                    {
                        jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 2);
                        sb.AppendLine("2da Ronda:");
                        Thread.Sleep(new Random().Next(1000, 2000));
                        sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 2));

                        if (jugadorGanadorRonda == jugadorUno)
                        {
                            if (jugadorUno.CantarTruco == true && jugadorDos.QuererTruco == true)
                            {
                                jugadorGanadorRonda = TirarCartas(jugadorDos, jugadorUno, 3);
                                sb.AppendLine("3era Ronda:");
                                sb.AppendLine($"El Jugador {jugadorUno.NombreJugador} canto Truco!!, y el jugador {jugadorDos.NombreJugador} dijo quiero!!\n");
                                Thread.Sleep(new Random().Next(1000, 2000));
                                sb.AppendLine(MostrarCartasJugadas(jugadorUno, jugadorDos, 3));

                                if (jugadorGanadorRonda == jugadorUno)
                                {
                                    jugadorUno.AcumularPuntosDePartida(2);
                                }
                                else if (jugadorGanadorRonda == jugadorDos)
                                {
                                    jugadorDos.AcumularPuntosDePartida(2);
                                }
                                else // si entra aca empataron en el truco
                                {
                                    jugadorDos.AcumularPuntosDePartida(2);
                                }
                            }
                        }
                    }
                }
            }


            return sb.ToString();
        }


        public static Jugador DevolverGanadorEnvido(Jugador jugadorUno, Jugador jugadorDos)
        {
            Jugador jugadorGanador = null;
            int sumaCartasEnvidoJugadorUno;
            int sumaCartasEnvidoJugadorDos;

            jugadorUno.ConfirmarEsMano();

            CartaTruco.EstablecerValorParaEnvido(jugadorUno, jugadorDos);

            if (jugadorDos.CartasObtenidas[0].Palo == jugadorDos.CartasObtenidas[1].Palo)
            {
                sumaCartasEnvidoJugadorDos = jugadorDos.CartasObtenidas[0].Numero + jugadorDos.CartasObtenidas[1].Numero;
            }
            else if (jugadorUno.CartasObtenidas[0].Palo == jugadorDos.CartasObtenidas[2].Palo)
            {
                sumaCartasEnvidoJugadorDos = jugadorDos.CartasObtenidas[0].Numero + jugadorDos.CartasObtenidas[2].Numero;
            }
            else if (jugadorUno.CartasObtenidas[1].Palo == jugadorDos.CartasObtenidas[2].Palo)
            {
                sumaCartasEnvidoJugadorDos = jugadorDos.CartasObtenidas[1].Numero + jugadorDos.CartasObtenidas[2].Numero;
            }
            else
            {
                sumaCartasEnvidoJugadorDos = 0;
            }

            if (jugadorUno.CartasObtenidas[0].Palo == jugadorUno.CartasObtenidas[1].Palo)
            {
                sumaCartasEnvidoJugadorUno = jugadorUno.CartasObtenidas[0].Numero + jugadorUno.CartasObtenidas[1].Numero;
            }
            else if (jugadorUno.CartasObtenidas[0].Palo == jugadorUno.CartasObtenidas[2].Palo)
            {
                sumaCartasEnvidoJugadorUno = jugadorUno.CartasObtenidas[0].Numero + jugadorUno.CartasObtenidas[2].Numero;
            }
            else if (jugadorUno.CartasObtenidas[1].Palo == jugadorUno.CartasObtenidas[2].Palo)
            {
                sumaCartasEnvidoJugadorUno = jugadorUno.CartasObtenidas[1].Numero + jugadorUno.CartasObtenidas[2].Numero;
            }
            else
            {
                sumaCartasEnvidoJugadorUno = 0;
            }


            if (jugadorUno.EsMano == true && sumaCartasEnvidoJugadorUno == sumaCartasEnvidoJugadorDos)
            {
                jugadorGanador = jugadorUno;
            }
            else if (jugadorUno.EsMano == false && sumaCartasEnvidoJugadorUno == sumaCartasEnvidoJugadorDos)
            {
                jugadorGanador = jugadorDos;
            }
            else
            {
                if (sumaCartasEnvidoJugadorUno > sumaCartasEnvidoJugadorDos)
                {
                    jugadorGanador = jugadorUno;
                }
                else if (sumaCartasEnvidoJugadorUno < sumaCartasEnvidoJugadorDos)
                {
                    jugadorGanador = jugadorDos;
                }
            }

            return jugadorGanador;
        }

        public List<CartaTruco> CrearMazoDeCartas()
        {
            string rutaArchivo = $"{AppDomain.CurrentDomain.BaseDirectory}" + @"valorCartasTruco.xml";

            List<CartaTruco> masoAux = Serializadora.DeserializarDesdeAXml<List<CartaTruco>>(rutaArchivo);

            return masoAux;
        }

        public string AcumularPuntosJugadores(Jugador jugadorUno, Jugador jugadorDos)
        {
            Jugador auxJugadorGanador;
            StringBuilder sb = new StringBuilder();

            jugadorUno.CantarTrucoJugador();
            jugadorUno.QuererTrucoJugador();
            jugadorUno.CantarEnvidoJugador();
            jugadorUno.QuererEnvidoJugador();

            jugadorDos.CantarTrucoJugador();
            jugadorDos.QuererTrucoJugador();
            jugadorDos.CantarEnvidoJugador();
            jugadorDos.QuererEnvidoJugador();


            auxJugadorGanador = DevolverGanadorEnvido(jugadorUno, jugadorDos);

            if (jugadorUno.CantarEnvido == true && jugadorDos.QuererEnvido == true)
            {
                if (jugadorUno == auxJugadorGanador)
                {
                    jugadorUno.AcumularPuntosDePartida(2);
                }
                else
                {
                    jugadorDos.AcumularPuntosDePartida(2);
                }
            }
            else if (jugadorUno.CantarEnvido == true && jugadorDos.QuererEnvido == false)
            {
                jugadorUno.AcumularPuntosDePartida(1);
            }

            if (jugadorDos.CantarEnvido == true && jugadorUno.QuererEnvido == true)
            {
                if (jugadorDos == auxJugadorGanador)
                {
                    jugadorDos.AcumularPuntosDePartida(2);
                }
                else
                {
                    jugadorUno.AcumularPuntosDePartida(2);
                }
            }
            else if (jugadorDos.CantarEnvido == true && jugadorUno.QuererEnvido == false)
            {
                jugadorDos.AcumularPuntosDePartida(1);
            }

            Thread.Sleep(2000);

            sb.AppendLine(MostrarCartasTruco(jugadorUno, jugadorDos));

            return sb.ToString();
        }
    }
}
