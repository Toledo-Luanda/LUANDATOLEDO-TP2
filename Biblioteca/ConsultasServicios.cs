using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ConsultasServicios
    {
        // CREAR UNA NUEVA FILA 
        // precio, nombre, descripcion 
        public string CrearServicioNuevo(int precio, string nombre, string descripcion)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "INSERT INTO Servicios (precio, nombre, descripcion) " +
                                   "VALUES (@Precio, @Nombre, @Descripcion)";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    command.ExecuteNonQuery();
                }

                return "Servicio creado exitosamente";
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return "Error en la base de datos al crear el servicio";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return "Error general al crear el servicio";
            }
        }

        // MODIFICAR UNA FILA 
        public string ModificarServicio(int idServicio, int precio, string nombre, string descripcion)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "UPDATE Servicios SET precio = @Precio, " +
                                   "nombre = @Nombre, descripcion = @Descripcion " + "WHERE IdServiciosCodigoInt = @IdServiciosCodigoInt";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@IdServiciosCodigoInt", idServicio);

                    int filasModificadas = command.ExecuteNonQuery();

                    if (filasModificadas > 0)
                    {
                        return "Servicio modificado exitosamente";
                    }
                    else
                    {
                        return "No se encontró el servicio para modificar";
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return "Error en la base de datos al modificar el servicio";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return "Error general al modificar el servicio";
            }
        }

        // OBTENER EL ULTIMO ID 
        public int ObtenerUltimoIDServicio()
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT IDENT_CURRENT('Servicios') AS IdServiciosCodigoInt"; // Consulta para obtener el último ID insertado

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
        public string BorrarServicio(int idServicio)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "DELETE FROM Servicios WHERE IdServiciosCodigoInt = @IdServiciosCodigoInt";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@IdServiciosCodigoInt", idServicio);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        return "Servicio eliminado exitosamente";
                    }
                    else
                    {
                        return "No se encontró el servicio para eliminar";
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return "Error en la base de datos al eliminar el servicio";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return "Error general al eliminar el servicio";
            }
        }

        // LEER SERVICIO 
        public Servicio LeerServicioPorId(int idServicio)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";
            Servicio servicio = null;

            try
            {
                // Otra inicialización previa para el objeto Cliente
                 servicio = new Servicio();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT * FROM Servicios WHERE IdServiciosCodigoInt = @IdServiciosCodigoInt";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@IdServiciosCodigoInt", idServicio);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            servicio.Precio = int.Parse(reader["Precio"].ToString());
                            servicio.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                            servicio.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));
                        }
                    }
                }

                return servicio;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return servicio; // Devolver null o manejar el error según tu lógica
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return servicio; // Devolver null o manejar el error según tu lógica
            }
        }

        // LEER TODOS LOS SERVICIOS 
        public List<Servicio> ObtenerTodosLosSericios()
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";
            List<Servicio> servicios = new List<Servicio>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT * FROM Servicios";

                    SqlCommand command = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Servicio servicio = new Servicio
                            {
                                Precio = int.Parse(reader["Precio"].ToString()),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"))
                            };

                            servicios.Add(servicio);
                        }
                    }
                }

                return servicios;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return servicios; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return servicios; 
            }
        }
    }
}
