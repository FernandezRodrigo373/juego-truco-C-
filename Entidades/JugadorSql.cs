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
            connectionString = @"Data Source=.;Initial Catalog=DB_Truco;Integrated Security=True";
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
                command.CommandText = "SELECT * FROM TABLAJUGADOR";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listaDeJugadores.Add(new Jugador
                        (int.Parse(dataReader["IDJUGADOR"].ToString()),
                        dataReader["NOMBREJUGADOR"].ToString(),
                        dataReader["PASSWORDJUGADOR"].ToString(),
                        int.Parse(dataReader["PARTIDASGANADASPORJUGADOR"].ToString()),
                        int.Parse(dataReader["PARTIDASPERDIDASPORJUGADOR"].ToString()),
                        Jugador.ObtenerEstadoSql(dataReader["ESTAJUGANDO"].ToString())));
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
                command.CommandText = $"INSERT INTO TABLAJUGADOR (NOMBREJUGADOR, PASSWORDJUGADOR, PARTIDASGANADASPORJUGADOR, PARTIDASPERDIDASPORJUGADOR, ESTAJUGANDO)" +
                    $"  VALUES (@NOMBREJUGADOR, @PASSWORDJUGADOR, @PARTIDASGANADASPORJUGADOR, @PARTIDASPERDIDASPORJUGADOR, @ESTAJUGANDO)";
                command.Parameters.AddWithValue("@NOMBREJUGADOR", unJugador.NombreJugador);
                command.Parameters.AddWithValue("@PASSWORDJUGADOR", unJugador.PassWordJugador);
                command.Parameters.AddWithValue("@PARTIDASGANADASPORJUGADOR", unJugador.PartidasGanadasPorJugador);
                command.Parameters.AddWithValue("@PARTIDASPERDIDASPORJUGADOR", unJugador.PartidasPerdidasPorJugador);
                command.Parameters.AddWithValue("@ESTAJUGANDO", Jugador.PasarEstadoInt(unJugador.estaJugando));

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
                command.CommandText = "SELECT * FROM TABLAJUGADOR WHERE PARTIDASGANADASPORJUGADOR >= 12 OR PARTIDASPERDIDASPORJUGADOR >= 10";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new Jugador
                        (int.Parse(dataReader["IDJUGADOR"].ToString()),
                        dataReader["NOMBREJUGADOR"].ToString(),
                        dataReader["PASSWORDJUGADOR"].ToString(),
                        int.Parse(dataReader["PARTIDASGANADASPORJUGADOR"].ToString()),
                        int.Parse(dataReader["PARTIDASPERDIDASPORJUGADOR"].ToString()),
                        Jugador.ObtenerEstadoSql(dataReader["ESTAJUGANDO"].ToString())));
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
                command.CommandText = "UPDATE TABLAJUGADOR SET ESTAJUGANDO = @ESTAJUGANDO , PARTIDASPERDIDASPORJUGADOR = @PARTIDASPERDIDASPORJUGADOR, PARTIDASGANADASPORJUGADOR = @PARTIDASGANADASPORJUGADOR  WHERE NOMBREJUGADOR = @NOMBREJUGADOR";
                command.Parameters.AddWithValue("@NOMBREJUGADOR", unJugador.NombreJugador);
                command.Parameters.AddWithValue("@PASSWORDJUGADOR", unJugador.PassWordJugador);
                command.Parameters.AddWithValue("@PARTIDASGANADASPORJUGADOR", unJugador.PartidasGanadasPorJugador);
                command.Parameters.AddWithValue("@PARTIDASPERDIDASPORJUGADOR", unJugador.PartidasPerdidasPorJugador);
                command.Parameters.AddWithValue("@ESTAJUGANDO", unJugador.estaJugando = false);

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
                command.CommandText = "UPDATE TABLAJUGADOR SET  ESTAJUGANDO = @ESTAJUGANDO  WHERE NOMBREJUGADOR = @NOMBREJUGADOR";
                command.Parameters.AddWithValue("@NOMBREJUGADOR", unJugador.NombreJugador);
                command.Parameters.AddWithValue("@PASSWORDJUGADOR", unJugador.PassWordJugador);
                command.Parameters.AddWithValue("@PARTIDASGANADASPORJUGADOR", unJugador.PartidasGanadasPorJugador);
                command.Parameters.AddWithValue("@PARTIDASPERDIDASPORJUGADOR", unJugador.PartidasPerdidasPorJugador);
                command.Parameters.AddWithValue("@ESTAJUGANDO", Jugador.PasarEstadoInt(unJugador.estaJugando));

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
                command.CommandText = "SELECT * FROM TABLAJUGADOR WHERE PARTIDASGANADASPORJUGADOR >= 26";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    listaDeJugadores.Add(new Jugador
                        (int.Parse(dataReader["IDJUGADOR"].ToString()),
                        dataReader["NOMBREJUGADOR"].ToString(),
                        dataReader["PASSWORDJUGADOR"].ToString(),
                        int.Parse(dataReader["PARTIDASGANADASPORJUGADOR"].ToString()),
                        int.Parse(dataReader["PARTIDASPERDIDASPORJUGADOR"].ToString()),
                        Jugador.ObtenerEstadoSql(dataReader["ESTAJUGANDO"].ToString())));
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
                command.CommandText = "SELECT * FROM TABLAJUGADOR WHERE PARTIDASGANADASPORJUGADOR = 0 AND PARTIDASPERDIDASPORJUGADOR = 0";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    jugadores.Add(new Jugador
                        (int.Parse(dataReader["IDJUGADOR"].ToString()),
                        dataReader["NOMBREJUGADOR"].ToString(),
                        dataReader["PASSWORDJUGADOR"].ToString(),
                        int.Parse(dataReader["PARTIDASGANADASPORJUGADOR"].ToString()),
                        int.Parse(dataReader["PARTIDASPERDIDASPORJUGADOR"].ToString()),
                        Jugador.ObtenerEstadoSql(dataReader["ESTAJUGANDO"].ToString())));
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
