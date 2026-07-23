using Integrador;
using System.Data.SqlClient;
using System;
using System.Diagnostics.Contracts;

internal class RegistroLlegada
{
    public static void registrarLLegada(int expediente, string nombrePaciente, DateTime hraLlegada, int tipoVisita, int usuario)
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();

            string query = "INSERT INTO Registro_Llegada (id_expediente, nombre_paciente, hora_llegada, id_tipo_visita, id_usuario) value(@expediente, @nombrePaciente, @horaLlegada, @tipoVisita, @usuario)";

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@expediente", expediente);
            cmd.Parameters.AddWithValue("@nombrePaciente", nombrePaciente);
            cmd.Parameters.AddWithValue("@horaLlegada", hraLlegada);
            cmd.Parameters.AddWithValue("@tipoVisita", tipoVisita);
            cmd.Parameters.AddWithValue("@usuario", usuario);

        }
    }
}