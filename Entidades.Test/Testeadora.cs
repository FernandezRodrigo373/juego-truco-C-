using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System;
using Entidades;
using FernandezBarbero.Rodrigo.TP2_;

namespace Entidades.Test
{
    [TestClass]
    public class Testeadora
    {
        [TestMethod]
        public void ValidarAlfanumericoTest()
        {
            string cadenaAux = "prueba";
            bool resultadoMetodo = Validadora.ValidarCadena(cadenaAux);

            Assert.AreEqual(true, resultadoMetodo);
        }

        [TestMethod]
        public void DeserializarDesdeAXml()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "valorCartasTruco.xml");

            List<CartaTruco> listaCartaPrueba = Serializadora.DeserializarDesdeAXml<List<CartaTruco>>(rutaArchivo);

            Assert.IsNotNull(listaCartaPrueba);
            Assert.IsTrue(listaCartaPrueba.Count > 0);
        }

        [TestMethod]
        public void ProbarDevolverGanadorEnvidoNoSeaNull()
        {
            List<CartaTruco> Cartas1 = new List<CartaTruco>();
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            List<CartaTruco> auxMasoCarta = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas1, true, true, true, true, 0, true, false);
            Jugador auxPruebajugadorDos = new Jugador(1, "Laura", "pato34", 1, 0, Cartas2, true, true, true, true, 0, false, false);
            Jugador jugadorGanadorAux = null;
            Truco auxPruebaTruco = new Truco(auxMasoCarta);

            auxMasoCarta = auxPruebaTruco.CrearMazoDeCartas();

            auxPruebaTruco.RepartirCartas(auxMasoCarta, auxPruebajugadorUno, auxPruebajugadorDos);

            jugadorGanadorAux = Truco.DevolverGanadorEnvido(auxPruebajugadorUno, auxPruebajugadorDos);

            Assert.IsNotNull(jugadorGanadorAux);
        }

        [TestMethod]
        public void ProbarDevolverGanadorJugarCartas()
        {
            List<CartaTruco> Cartas1 = new List<CartaTruco>();
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            List<CartaTruco> auxMasoCarta = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas1, true, true, true, true, 0, true, false);
            Jugador auxPruebajugadorDos = new Jugador(1, "Laura", "pato34", 1, 0, Cartas2, true, true, true, true, 0, false, false);
            Jugador jugadorGanadorAux = null;
            Truco auxPruebaTruco = new Truco(auxMasoCarta);

            auxMasoCarta = auxPruebaTruco.CrearMazoDeCartas();

            auxPruebaTruco.RepartirCartas(auxMasoCarta, auxPruebajugadorUno, auxPruebajugadorDos);

            jugadorGanadorAux = auxPruebaTruco.TirarCartas(auxPruebajugadorUno, auxPruebajugadorDos, 1);

            Assert.IsNotNull(jugadorGanadorAux);
        }

        [TestMethod]
        public void ProbarRepartirCartasDeMaso()
        {
            List<CartaTruco> Cartas1 = new List<CartaTruco>();
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            List<CartaTruco> auxMasoCarta = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas1, true, true, true, true, 0, true, false);
            Jugador auxPruebajugadorDos = new Jugador(1, "Laura", "pato34", 1, 0, Cartas2, true, true, true, true, 0, false, false);
            Truco auxPruebaTruco = new Truco(auxMasoCarta);

            auxMasoCarta = auxPruebaTruco.CrearMazoDeCartas();

            auxPruebaTruco.RepartirCartas(auxMasoCarta, auxPruebajugadorUno, auxPruebajugadorDos);

            Assert.IsTrue(auxMasoCarta.Count > 0);
            Assert.IsTrue(auxPruebajugadorUno.CartasObtenidas.Count > 0);
            Assert.IsTrue(auxPruebajugadorDos.CartasObtenidas.Count > 0);
            Assert.IsTrue(auxPruebajugadorUno.CartasObtenidas.Count == 3);
            Assert.IsTrue(auxPruebajugadorDos.CartasObtenidas.Count == 3);
        }

        [TestMethod]
        public void ProbarAcumularPuntosJugadores()
        {
            List<CartaTruco> Cartas1 = new List<CartaTruco>();
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            List<CartaTruco> auxMasoCarta = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas1, true, true, true, true, 0, true, false);
            Jugador auxPruebajugadorDos = new Jugador(1, "Laura", "pato34", 1, 0, Cartas2, true, true, true, true, 0, false, false);
            Truco auxPruebaTruco = new Truco(auxMasoCarta);

            auxMasoCarta = auxPruebaTruco.CrearMazoDeCartas();

            auxPruebaTruco.RepartirCartas(auxMasoCarta, auxPruebajugadorUno, auxPruebajugadorDos);

            auxPruebaTruco.AcumularPuntosJugadores(auxPruebajugadorUno, auxPruebajugadorDos);

            Assert.IsTrue(auxPruebajugadorUno.CantidadPuntos >= 0);
            Assert.IsTrue(auxPruebajugadorDos.CantidadPuntos >= 0);
        }

        [TestMethod]
        public void ProbarDevolverGanadorTruco()
        {
            List<CartaTruco> Cartas1 = new List<CartaTruco>();
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            List<CartaTruco> auxMasoCarta = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas1, true, true, true, true, 0, true, false);
            Jugador auxPruebajugadorDos = new Jugador(1, "Laura", "pato34", 1, 0, Cartas2, true, true, true, true, 0, false, false);
            Truco auxPruebaTruco = new Truco(auxMasoCarta);

            auxMasoCarta = auxPruebaTruco.CrearMazoDeCartas();

            auxPruebaTruco.RepartirCartas(auxMasoCarta, auxPruebajugadorUno, auxPruebajugadorDos);

            auxPruebaTruco.DevolverGanadorTruco(auxPruebajugadorUno, auxPruebajugadorDos);

            Assert.IsTrue(auxPruebajugadorUno.CantidadPuntos >= 0);
            Assert.IsTrue(auxPruebajugadorDos.CantidadPuntos >= 0);
        }

        [TestMethod]
        public void ProbarSqlLeerUnaMesa()
        {
            List<MesaDeJuego> mesaPruebaAux = PartidasJugadasSql.Leer();

            Assert.IsTrue(mesaPruebaAux.Count > 0);
            Assert.IsNotNull(mesaPruebaAux);
        }

        [TestMethod]
        public void ProbarMostrarGanadorSala()
        {
            CancellationToken cancellationToken = new CancellationToken();
            string pruebaAuxGanador = null;
            string auxGanadorSala;
            List<CartaTruco> Cartas1 = new List<CartaTruco>();
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            List<CartaTruco> auxMasoCarta = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas1, true, true, true, true, 0, true, false);
            Jugador auxPruebajugadorDos = new Jugador(1, "Laura", "pato34", 1, 0, Cartas2, true, true, true, true, 0, false, false);
            Truco auxPruebaTruco = new Truco(auxMasoCarta);

            MesaDeJuego auxPruebaMesa = new MesaDeJuego(1, 1, auxPruebajugadorUno, auxPruebajugadorDos, DateTime.Now);

            auxPruebaMesa.JugarPartida(auxPruebaTruco, cancellationToken);

            pruebaAuxGanador = auxPruebaMesa.SumarEstadisticasGanador();
            auxGanadorSala = auxPruebaMesa.EstablecerGanador();

            Assert.IsNotNull(pruebaAuxGanador);
            Assert.IsNotNull(auxGanadorSala);
            Assert.IsTrue(pruebaAuxGanador.Length > 0);
        }

        [TestMethod]
        public void ProbarJugarPartida()
        {
            CancellationToken cancellationToken = new CancellationToken();
            string auxGanador;
            string auxHistorialCartasGanador;
            List<CartaTruco> Cartas1 = new List<CartaTruco>();
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            List<CartaTruco> auxMasoCarta = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas1, true, true, true, true, 0, true, false);
            Jugador auxPruebajugadorDos = new Jugador(1, "Laura", "pato34", 1, 0, Cartas2, true, true, true, true, 0, false, false);
            Truco auxPruebaTruco = new Truco(auxMasoCarta);


            MesaDeJuego auxPruebaMesa = new MesaDeJuego(1, 1, auxPruebajugadorUno, auxPruebajugadorDos, DateTime.Now);


            auxPruebaMesa.JugarPartida(auxPruebaTruco, cancellationToken);
            auxHistorialCartasGanador = auxPruebaMesa.MostrarCartas();

            auxGanador = auxPruebaMesa.SumarEstadisticasGanador();

            Assert.IsTrue(auxHistorialCartasGanador.Length > 0);
            Assert.IsNotNull(auxGanador);
        }



        [TestMethod]
        public void ProbarEncrontarUltimoId()
        {
            int auxUltimoIdAux;
            auxUltimoIdAux = MesaDeJuego.ObtenerUltimoIdTabla(PartidasJugadasSql.Leer());

            Assert.IsTrue(auxUltimoIdAux >= 0);
        }

        [TestMethod]
        public void ProbarObtenerJugadorPorElnombre()
        {
            Jugador auxJugador = Jugador.ObtenerJugador("Raul");

            Assert.IsTrue(auxJugador.NombreJugador == "Raul");
            Assert.IsNotNull(auxJugador);
        }

        [TestMethod]
        public void ProbarObtenerNombreDelJugador()
        {
            Jugador auxJugador = Jugador.ObtenerJugador("Raul");

            string auxNombre = Jugador.ObtenerNombreDelJugador(auxJugador);

            Assert.IsTrue(auxNombre == "Juanse77");
            Assert.IsNotNull(auxNombre);
        }

        [TestMethod]
        public void ProbarEstaEnPartidaCambiarEstado()
        {
            string pruebaAuxEstado;
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "utn123", 0, 0, Cartas2, true, true, true, true, 0, true, false);

            pruebaAuxEstado = auxPruebajugadorUno.EstaJugando();

            Assert.IsTrue(pruebaAuxEstado == "Disponible");
        }

        [TestMethod]
        public void ProbarPasarEstadoInt()
        {
            int estadoAuxEntero = Jugador.PasarEstadoInt(true);

            Assert.IsTrue(estadoAuxEntero == 1);
        }

        [TestMethod]
        public void ProbarObtenerEstadoSql()
        {
            bool estadoAux = Jugador.ObtenerEstadoSql("Disponible");

            Assert.IsTrue(estadoAux == false);
        }

        [TestMethod]
        public void ProbarAcumularPuntosDePartida()
        {
            Jugador auxJugador = Jugador.ObtenerJugador("ramiro");

            auxJugador.AcumularPuntosDePartida(3);

            Assert.IsTrue(auxJugador.CantidadPuntos > 2);
        }

        [TestMethod]
        public void ProbarAumentarCantidadPartidasGanadas()
        {
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas2, true, true, true, true, 0, true, false);

            auxPruebajugadorUno.AumentarCantidadPartidasGanadas();

            Assert.IsTrue(auxPruebajugadorUno.PartidasGanadasPorJugador >= 1);
        }

        [TestMethod]
        public void ProbarAumentarCantidadPartidasPerdidas()
        {
            List<CartaTruco> Cartas2 = new List<CartaTruco>();
            Jugador auxPruebajugadorUno = new Jugador(2, "Pablo", "sdai9", 0, 0, Cartas2, true, true, true, true, 0, true, false);

            auxPruebajugadorUno.AumentarCantidadPartidasPerdidas();

            Assert.IsTrue(auxPruebajugadorUno.PartidasPerdidasPorJugador >= 1);
        }

        [TestMethod]
        public void ProbarObtenerUltimoNumeroMesa()
        {
            int ultimoNumeroMesa = MesaDeJuego.ObtenerUltimoNumeroMesa(MesaDeJuegoSql.Leer());

            Assert.IsTrue(ultimoNumeroMesa >= 0);
        }
    }
}
