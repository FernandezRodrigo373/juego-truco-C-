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
            connectionStriing = @"Data Source = DESKTOP-P0TBI04; Database = UTN_SALAS_FECHA_DE_CREACION; Trusted_Connection=True";   //modificar
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
                command.CommandText = "SELECT * FROM SALAS_PARA_JUGAR";
                SqlDataReader dataReader = command.ExecuteReader();


                while (dataReader.Read())
                {
                    salasDeJuego.Add(new MesaDeJuego(int.Parse(dataReader["ID_MESA"].ToString()),
                        int.Parse(dataReader["NUMERO_MESA"].ToString()),
                        Jugador.ObtenerJugador(dataReader["JUGADOR_UNO"].ToString()),
                        Jugador.ObtenerJugador(dataReader["JUGADOR_DOS"].ToString()),
                        MesaDeJuego.DuracionDeLaPartida(dataReader["FECHA_PARTIDA"].ToString())));
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
                command.CommandText = $"INSERT INTO SALAS_PARA_JUGAR (NUMERO_MESA, JUGADOR_UNO, JUGADOR_DOS, FECHA_PARTIDA)" +
                    $"  VALUES (@NUMERO_MESA, @JUGADOR_UNO, @JUGADOR_DOS, @FECHA_PARTIDA)";
                command.Parameters.AddWithValue("@NUMERO_MESA", mesaDeJuego.NumeroMesaDeJuego);
                command.Parameters.AddWithValue("@JUGADOR_UNO", mesaDeJuego.JugadorUno.NombreJugador);
                command.Parameters.AddWithValue("@JUGADOR_DOS", mesaDeJuego.JugadorDos.NombreJugador);
                command.Parameters.AddWithValue("@FECHA_PARTIDA", mesaDeJuego.DuracionPartida);

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
                command.CommandText = "DELETE SALAS_PARA_JUGAR WHERE NUMERO_MESA = @NUMERO_MESA";

                command.Parameters.AddWithValue("@NUMERO_MESA", mesaDeJuego.NumeroMesaDeJuego);

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
