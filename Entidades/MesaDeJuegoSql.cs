using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public class MesaDeJuegoSql
    {
        static string connectionStriing;
        static SqlCommand command;
        static SqlConnection connection;

        static MesaDeJuegoSql()
        {
            connectionStriing = @"Data Source = .; Database = DB_TRUCO; Trusted_Connection=True";   
            command = new SqlCommand();
            connection = new SqlConnection(connectionStriing);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<MesaDeJuego> Leer()
        {
            List<MesaDeJuego> salasDeJuego = new List<MesaDeJuego>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM MESADEJUEGOSALAS";
                SqlDataReader dataReader = command.ExecuteReader();
                DateTime tiempo = DateTime.Now;

                while (dataReader.Read())
                {
                    salasDeJuego.Add(new MesaDeJuego(int.Parse(dataReader["IDMESADEJUEGO"].ToString()),
                        int.Parse(dataReader["NUMEROMESADEJUEGO"].ToString()),
                        Jugador.ObtenerJugador(dataReader["JUGADORUNO"].ToString()),
                        Jugador.ObtenerJugador(dataReader["JUGADORDOS"].ToString()),
                        tiempo));
                }

                return salasDeJuego;
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

        public static void Guardar(MesaDeJuego mesaDeJuego)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO MESADEJUEGOSALAS (NUMEROMESADEJUEGO, JUGADORUNO, JUGADORDOS, FECHA)" +
                    $"  VALUES (@NUMEROMESADEJUEGO, @JUGADORUNO, @JUGADORDOS, @FECHA)";
                command.Parameters.AddWithValue("@NUMEROMESADEJUEGO", mesaDeJuego.NumeroMesaDeJuego);
                command.Parameters.AddWithValue("@JUGADORUNO", mesaDeJuego.JugadorUno.NombreJugador);
                command.Parameters.AddWithValue("@JUGADORDOS", mesaDeJuego.JugadorDos.NombreJugador);
                
                command.Parameters.AddWithValue("@FECHA", mesaDeJuego.DuracionPartida);

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



        public static void Eliminar(MesaDeJuego mesaDeJuego)
        {

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "DELETE MESADEJUEGOSALAS WHERE NUMEROMESADEJUEGO = @NUMEROMESADEJUEGO";

                command.Parameters.AddWithValue("@NUMEROMESADEJUEGO", mesaDeJuego.NumeroMesaDeJuego);

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
    }
}
