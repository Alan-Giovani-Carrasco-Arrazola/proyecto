using Integrador;
using System.Data.SqlClient;
using System;
using System.Diagnostics.Contracts;

internal class TipoConsulta
{
    public static void visualizarTipoConsulta()
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();
            string query = "SELECT * FROM Tipo_Consulta";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idTipoConsulta = reader.GetInt32(0);
                string nombreTipoConsulta = reader.GetString(1);
            }
        }
    }
}