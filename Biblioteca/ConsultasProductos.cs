using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ConsultasProductos
    {
        // CREAR UNA NUEVA FILA 
        // precio, nombre, descripcion 
        public string CrearProductoNuevo(int precio, string nombre, string descripcion)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "INSERT INTO Productos (precio, nombre, descripcion) " +
                                   "VALUES (@Precio, @Nombre, @Descripcion)";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);

                    command.ExecuteNonQuery();
                }

                return "Producto creado exitosamente";
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
        public string ModificarProducto(int idProducto, int precio, string nombre, string descripcion)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "UPDATE Productos SET precio = @Precio, " +
                                   "nombre = @Nombre, descripcion = @Descripcion " + "WHERE IdProductosCodigoInt = @IdProductosCodigoInt";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@IdProductosCodigoInt", idProducto);

                    int filasModificadas = command.ExecuteNonQuery();

                    if (filasModificadas > 0)
                    {
                        return "Producto modificado exitosamente";
                    }
                    else
                    {
                        return "No se encontró el producto para modificar";
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
        public int ObtenerUltimoIDProductos()
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT IDENT_CURRENT('Productos') AS IdProductosCodigoInt"; // Consulta para obtener el último ID insertado

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
        public string BorrarProductos(int idProductos)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "DELETE FROM Productos WHERE IdProductosCodigoInt = @IdProductosCodigoInt";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@IdProductosCodigoInt", idProductos);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        return "Producto eliminado exitosamente";
                    }
                    else
                    {
                        return "No se encontró el producto para eliminar";
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

        // LEER PRODUCTO 
        public Producto LeerProductoPorId(int idProducto)
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";
            Producto producto = null;

            try
            {
                // Otra inicialización previa para el objeto Cliente
                producto = new Producto();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT * FROM Productos WHERE IdProductosCodigoInt = @IdProductosCodigoInt";

                    SqlCommand command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@IdProductosCodigoInt", idProducto);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            producto.Precio = int.Parse(reader["Precio"].ToString());
                            producto.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                            producto.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));
                        }
                    }
                }

                return producto;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return producto; // Devolver null o manejar el error según tu lógica
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return producto; // Devolver null o manejar el error según tu lógica
            }
        }

        // LEER TODOS LOS PRODUCTOS 
        public List<Producto> ObtenerTodosLosProductos()
        {
            string connectionString = "Data Source=DESKTOP-EQICBJC;Initial Catalog=DetallesComerciales;Integrated Security=True";
            List<Producto> productos = new List<Producto>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT * FROM Productos";

                    SqlCommand command = new SqlCommand(query, conexion);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                Precio = int.Parse(reader["Precio"].ToString()),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"))
                            };

                            productos.Add(producto);
                        }
                    }
                }

                return productos;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                return productos; // Devolver una lista vacía o manejar el error según tu lógica
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return productos; // Devolver una lista vacía o manejar el error según tu lógica
            }
        }
    }
}
