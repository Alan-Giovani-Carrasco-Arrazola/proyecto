using Integrador;
using System.Data.SqlClient;
using System;
using System.Data;

internal class RegistroLlegada
{
    // 1. REGISTRAR - Ya corregido
    public static void registrarLlegada(int expediente, string nombrePaciente, DateTime hraLlegada, int tipoVisita, int usuario)
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();
            // OJO: era VALUES no VALUE
            string query = "INSERT INTO Registro_Llegada (id_expediente, nombre_paciente, hora_llegada, id_tipo_visita, id_usuario, estado) VALUES (@expediente, @nombrePaciente, @horaLlegada, @tipoVisita, @usuario, 'En Espera')";

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@expediente", expediente);
                cmd.Parameters.AddWithValue("@nombrePaciente", nombrePaciente); 
                cmd.Parameters.AddWithValue("@tipoVisita", tipoVisita);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                cmd.ExecuteNonQuery();
            }

        }
    }

    // 2. VISUALIZAR - Para llenar tu DataGridView
    public static DataTable visualizarLlegadas()
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();
            string query = "SELECT * FROM Registro_Llegada WHERE CAST(hora_llegada AS DATE) = CAST(GETDATE() AS DATE) ORDER BY hora_llegada DESC";
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

    // 3. BORRAR
    public static void borrarLlegada(int idLlegada)
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();
            string query = "DELETE FROM Registro_Llegada WHERE id_llegada = @id";
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@id", idLlegada);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // 4. CAMBIAR ESTADO A EN ESPERA
    public static void marcarEnEspera(int idLlegada)
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();
            string query = "UPDATE Registro_Llegada SET estado = 'En Espera' WHERE id_llegada = @id";
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@id", idLlegada);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // 5. FINALIZAR CONSULTA
    public static void finalizarConsulta(int idLlegada)
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();
            string query = "UPDATE Registro_Llegada SET estado = 'Finalizada', hora_salida = GETDATE() WHERE id_llegada = @id";
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@id", idLlegada);
                cmd.ExecuteNonQuery();
            }
        }
    }
}