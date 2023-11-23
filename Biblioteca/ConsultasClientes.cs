using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca
{
    static public class ConsultasClientes
    {
        // CREAR UNA NUEVA FILA 
        // condicionFrenteAlIva, cuit, razonSocial, domicilioComercial
        static public string CrearClienteNuevo(string condicionFrenteAlIva, int cuit, string razonSocial, string domicilioComercial)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "INSERT INTO Clientes (condicionFrenteAlIva, cuit, razonSocial, domicilioComecial) " +
                                   "VALUES (@CondicionFrenteAlIva, @Cuit, @RazonSocial, @DomicilioComecial)";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@CondicionFrenteAlIva", condicionFrenteAlIva);
                    command.Parameters.AddWithValue("@Cuit", cuit);
                    command.Parameters.AddWithValue("@RazonSocial", razonSocial);
                    command.Parameters.AddWithValue("@DomicilioComecial", domicilioComercial);

                    command.ExecuteNonQuery();
                }

                return "Cliente creado exitosamente";
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return "Error en la base de datos al crear el cliente";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return "Error general al crear el cliente";
            }
        }

        // MODIFICAR UNA FILA 
        static public string ModificarCliente(int idCliente, string nuevaCondicionFrenteAlIva, int nuevoCuit, string nuevaRazonSocial, string nuevoDomicilioComercial)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "UPDATE Clientes SET condicionFrenteAlIva = @NuevaCondicionFrenteAlIva, " +
                                   "cuit = @NuevoCuit, razonSocial = @NuevaRazonSocial, domicilioComecial = @NuevoDomicilioComecial " +
                                   "WHERE IdCliente = @IdCliente";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@NuevaCondicionFrenteAlIva", nuevaCondicionFrenteAlIva);
                    command.Parameters.AddWithValue("@NuevoCuit", nuevoCuit);
                    command.Parameters.AddWithValue("@NuevaRazonSocial", nuevaRazonSocial);
                    command.Parameters.AddWithValue("@NuevoDomicilioComecial", nuevoDomicilioComercial);
                    command.Parameters.AddWithValue("@IdCliente", idCliente);

                    int filasModificadas = command.ExecuteNonQuery();

                    if (filasModificadas > 0)
                    {
                        return "Cliente modificado exitosamente";
                    }
                    else
                    {
                        return "No se encontró el cliente para modificar";
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return "Error en la base de datos al modificar el cliente";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return "Error general al modificar el cliente";
            }
        }

        // OBTENER EL ULTIMO ID 
        static public int ObtenerUltimoIDCliente()
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT IDENT_CURRENT('Clientes') AS IdCliente"; // Consulta para obtener el último ID insertado

                    SqlCommand command = new SqlCommand(query, conexion);

                    // Ejecutar la consulta y obtener el último ID de cliente insertado
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int ultimoID = Convert.ToInt32(result);
                        return ultimoID;
                    }
                    else
                    {
                        return -1; // Si no se encuentra ningún cliente en la tabla
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return -1; // Si hay un error en la base de datos
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1; // Si hay un error general
            }
        }

        // BORRAR UNA FILA
        static public string BorrarCliente(int idCliente)
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

        // LEER CLIENTE 
        static public Cliente LeerClientePorId(int idCliente)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";
            Cliente cliente = null;

            try
            {
                // Otra inicialización previa para el objeto Cliente
                cliente = new Cliente();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT * FROM Clientes WHERE IdCliente = @IdCliente";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@IdCliente", idCliente);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente.CondicionFrenteAlIva = reader.GetString(reader.GetOrdinal("CondicionFrenteAlIva"));
                            cliente.Cuit = int.Parse(reader["Cuit"].ToString());
                            cliente.RazonSocial = reader.GetString(reader.GetOrdinal("RazonSocial"));
                            cliente.DomicilioComercial = reader.GetString(reader.GetOrdinal("DomicilioComecial"));
                        }
                    }
                }

                return cliente;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return cliente; // Devolver null o manejar el error según tu lógica
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return cliente; // Devolver null o manejar el error según tu lógica
            }
        }

        // LEER TODOS LOS CLIENTES
        static public List<Cliente> ObtenerTodosLosClientes()
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT * FROM Clientes";

                    SqlCommand command = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                CondicionFrenteAlIva = reader.GetString(reader.GetOrdinal("CondicionFrenteAlIva")),
                                Cuit = int.Parse(reader["Cuit"].ToString()),
                                RazonSocial = reader.GetString(reader.GetOrdinal("RazonSocial")),
                                DomicilioComercial = reader.GetString(reader.GetOrdinal("DomicilioComecial"))
                            };

                            clientes.Add(cliente);
                        }
                    }
                }

                return clientes;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return clientes; // Devolver una lista vacía o manejar el error según tu lógica
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return clientes; // Devolver una lista vacía o manejar el error según tu lógica
            }
        }

    }
}
