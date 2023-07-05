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
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static MesaDeJuegoSql()
        {
            /*string servidor = "."; 
            string nombreBaseDeDatos = "DB_Truco"; 
            string usuario = "sa"; 
            string password = "alumno"; 
            connectionString = $"Data Source={servidor};Initial Catalog={nombreBaseDeDatos};User ID={usuario};Password={password}";*/

            connectionString = @"Data Source=.;Initial Catalog=DB_Truco;Integrated Security=True";


            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
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
                        MesaDeJuego.TransformarTiempoDeJuego(dataReader["DURACION"].ToString())));
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
            int duracion = MesaDeJuego.DuracionActualizada;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO MESADEJUEGOSALAS (NUMEROMESADEJUEGO, JUGADORUNO, JUGADORDOS, DURACION)" +
                    $"  VALUES (@NUMEROMESADEJUEGO, @JUGADORUNO, @JUGADORDOS, @DURACION)";
                command.Parameters.AddWithValue("@NUMEROMESADEJUEGO", mesaDeJuego.NumeroMesaDeJuego);
                command.Parameters.AddWithValue("@JUGADORUNO", mesaDeJuego.JugadorUno.NombreJugador);
                command.Parameters.AddWithValue("@JUGADORDOS", mesaDeJuego.JugadorDos.NombreJugador);
                
                command.Parameters.AddWithValue("@DURACION", duracion.ToString());

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
