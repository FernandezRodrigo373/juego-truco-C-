using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public class JugadorSql
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;


        static JugadorSql()
        {
            connectionString = @"Data Source = DESKTOP-P0TBI04; Database = UTN_SALAS_FECHA_DE_CREACION; Trusted_Connection=True";   //modificar
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Jugador> LeerSql()
        {
            List<Jugador> listaDeJugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM JUGADORES_DATO";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listaDeJugadores.Add(new Jugador
                        (int.Parse(dataReader["ID_JUGADOR"].ToString()),
                        dataReader["NOMBRE"].ToString(),
                        dataReader["CONTRASENIA"].ToString(),
                        int.Parse(dataReader["PARTIDAS_GANADAS"].ToString()),
                        int.Parse(dataReader["PARTIDAS_PERDIDAS"].ToString()),
                        Jugador.ObtenerEstadoSql(dataReader["ESTADO"].ToString())));
                }

                return listaDeJugadores;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Guardar(Jugador unJugador)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO JUGADORES_DATO (NOMBRE, CONTRASENIA, PARTIDAS_GANADAS, PARTIDAS_PERDIDAS, ESTADO)" +
                    $"  VALUES (@NOMBRE, @CONTRASENIA, @PARTIDAS_GANADAS, @PARTIDAS_PERDIDAS, @ESTADO)";
                command.Parameters.AddWithValue("@NOMBRE", unJugador.NombreJugador);
                command.Parameters.AddWithValue("@CONTRASENIA", unJugador.PassWordJugador);
                command.Parameters.AddWithValue("@PARTIDAS_GANADAS", unJugador.PartidasGanadasPorJugador);
                command.Parameters.AddWithValue("@PARTIDAS_PERDIDAS", unJugador.PartidasPerdidasPorJugador);
                command.Parameters.AddWithValue("@ESTADO", Jugador.PasarEstadoInt(unJugador.estaJugando));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Jugador> FiltrarJugadoresConMasPartidas()
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM JUGADORES_DATO WHERE PARTIDAS_GANADAS >= 12 OR PARTIDAS_PERDIDAS >= 10";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new Jugador
                        (int.Parse(dataReader["ID_JUGADOR"].ToString()),
                        dataReader["NOMBRE"].ToString(),
                        dataReader["CONTRASENIA"].ToString(),
                        int.Parse(dataReader["PARTIDAS_GANADAS"].ToString()),
                        int.Parse(dataReader["PARTIDAS_PERDIDAS"].ToString()),
                        Jugador.ObtenerEstadoSql(dataReader["ESTADO"].ToString())));
                }

                return jugadores;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ModificarJugador(Jugador unJugador)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE JUGADORES_DATO SET ESTADO = @ESTADo , PARTIDAS_PERDIDAS = @PARTIDAS_PERDIDAS, PARTIDAS_GANADAS = @PARTIDAS_GANADAS  WHERE NOMBRE = @NOMBRE";
                command.Parameters.AddWithValue("@NOMBRE", unJugador.NombreJugador);
                command.Parameters.AddWithValue("@CONTRASENIA", unJugador.PassWordJugador);
                command.Parameters.AddWithValue("@PARTIDAS_GANADAS", unJugador.PartidasGanadasPorJugador);
                command.Parameters.AddWithValue("@PARTIDAS_PERDIDAS", unJugador.PartidasPerdidasPorJugador);
                command.Parameters.AddWithValue("@ESTADO", unJugador.estaJugando = false);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void ModificarJugadorEstado(Jugador unJugador)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE JUGADORES_DATO SET  ESTADO = @ESTADO  WHERE NOMBRE = @NOMBRE";
                command.Parameters.AddWithValue("@NOMBRE", unJugador.NombreJugador);
                command.Parameters.AddWithValue("@CONTRASENIA", unJugador.PassWordJugador);
                command.Parameters.AddWithValue("@PARTIDAS_GANADAS", unJugador.PartidasGanadasPorJugador);
                command.Parameters.AddWithValue("@PARTIDAS_PERDIDAS", unJugador.PartidasPerdidasPorJugador);
                command.Parameters.AddWithValue("@ESTADO", Jugador.PasarEstadoInt(unJugador.estaJugando));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static List<Jugador> FiltrarJugadoresPorCantidadPartidosGanadas()
        {
            List<Jugador> listaDeJugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM JUGADORES_DATO WHERE PARTIDAS_GANADAS >= 26";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listaDeJugadores.Add(new Jugador
                        (int.Parse(dataReader["ID_JUGADOR"].ToString()),
                        dataReader["NOMBRE"].ToString(),
                        dataReader["CONTRASENIA"].ToString(),
                        int.Parse(dataReader["PARTIDAS_GANADAS"].ToString()),
                        int.Parse(dataReader["PARTIDAS_PERDIDAS"].ToString()),
                        Jugador.ObtenerEstadoSql(dataReader["ESTADO"].ToString())));
                }

                return listaDeJugadores;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Jugador> FiltrarJugadoresSinPartidas()
        {
            List<Jugador> jugadores = new List<Jugador>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM JUGADORES_DATO WHERE PARTIDAS_GANADAS = 0 AND PARTIDAS_PERDIDAS = 0";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new Jugador
                        (int.Parse(dataReader["ID_JUGADOR"].ToString()),
                        dataReader["NOMBRE"].ToString(),
                        dataReader["CONTRASENIA"].ToString(),
                        int.Parse(dataReader["PARTIDAS_GANADAS"].ToString()),
                        int.Parse(dataReader["PARTIDAS_PERDIDAS"].ToString()),
                        Jugador.ObtenerEstadoSql(dataReader["ESTADO"].ToString())));
                }

                return jugadores;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        
    }
}
