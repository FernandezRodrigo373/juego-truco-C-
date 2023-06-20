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
        static string connectionStriing;
        static SqlCommand command;
        static SqlConnection connection;

        static PartidasJugadasSql()
        {
            connectionStriing = @"Data Source = .; Database = DB_Truco; Trusted_Connection=True";   //modificar
            command = new SqlCommand();
            connection = new SqlConnection(connectionStriing);
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
