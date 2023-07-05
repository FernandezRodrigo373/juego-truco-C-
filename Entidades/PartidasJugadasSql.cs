using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public class PartidasJugadasSql
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PartidasJugadasSql()
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
            List<MesaDeJuego> salas = new List<MesaDeJuego>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM MESADEJUEGOESTADISTICAS";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    salas.Add(new MesaDeJuego(int.Parse(dataReader["IDMESADEJUEGO"].ToString()), int.Parse(dataReader["NUMEROMESADEJUEGO"].ToString()), Convert.ToDateTime(dataReader["FECHA"].ToString())));
                }

                return salas;
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

        public static void Guardar(MesaDeJuego mesa)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO MESADEJUEGOESTADISTICAS (NUMEROMESADEJUEGO,  FECHA)" +
                    $"  VALUES (@NUMEROMESADEJUEGO,  @FECHA)";
                command.Parameters.AddWithValue("@NUMEROMESADEJUEGO", mesa.NumeroMesaDeJuego);
                command.Parameters.AddWithValue("@FECHA", mesa.Fecha);

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
    }
}
