using Biblioteca;
using System.Data.SqlClient;

namespace GeneradorDetallesFacturas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string m = BorrarCliente(5);
            Console.WriteLine(m);   

            static string BorrarCliente(int idCliente)
            {
                string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

                try
                {
                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        conexion.Open();

                        string query = "DELETE FROM Clientes WHERE IdCliente = @IdCliente";

                        SqlCommand command = new SqlCommand(query, conexion);
                        command.Parameters.AddWithValue("@IdCliente", idCliente);

                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return "Cliente eliminado exitosamente";
                        }
                        else
                        {
                            return "No se encontró el cliente para eliminar";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error de SQL: " + ex.Message);
                    return "Error en la base de datos al eliminar el cliente";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return "Error general al eliminar el cliente";
                }
            }
        }
    }
}