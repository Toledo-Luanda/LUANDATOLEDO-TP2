using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class VerificacionDeIngreso
    {
        public static string Ingreso(string usuario, string contraseña)
        {
            string connectionString = "Data Source = DESKTOP-EQICBJC; Initial Catalog = DetallesComerciales; Integrated Security = True";
           
            
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    return VerificaUsuariosYContraseña(conexion, usuario, contraseña);
                }
        }

        private static string VerificaUsuariosYContraseña(SqlConnection conexion, string usuario, string contraseña)
        {
            try
            { 
                string commandUsuarios = $"SELECT * FROM Usuarios WHERE usuario = '{usuario}'";
                string commandString = $"SELECT * FROM Usuarios WHERE usuario = '{usuario}' AND contraseña = '{contraseña}'";
                conexion.Open();

                SqlCommand command = new SqlCommand(commandUsuarios, conexion);
                command.Parameters.AddWithValue("@usuario", usuario);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return "El usuario no existe";
                    }
                }

                SqlCommand commandDos = new SqlCommand(commandString, conexion);
                commandDos.Parameters.AddWithValue("@usuario", usuario);
                commandDos.Parameters.AddWithValue("@contraseña", contraseña);
                using (SqlDataReader reader = commandDos.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return "La contraseña es inválida";
                    }
                }

                return "valido";
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); // Asegurarse de cerrar la conexión en todos los casos
                }
            }
        }
    }
}
