using System;
using Integrador;
using System.Data.SqlClient;

internal class Usuario
{
    public  int verificarUsuario(string usuario, string contra)
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            string query = "SELECT COUNT(*) FROM Usuario WHERE nombreUsuario = @user AND contraseña = @pass";

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@pass", contra);

            int existe = Convert.ToInt32(cmd.ExecuteScalar());

            return existe;
        }
    }
}
