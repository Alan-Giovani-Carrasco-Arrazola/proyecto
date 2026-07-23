using System.Data.SqlClient;
using System;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using Integrador;
internal class Pacientes
{
    public void visualizarPacientes()
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();
            string query = "SELECT * FROM Paciente";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id_Paciente = reader.GetInt16(0);
                int expediente = reader.GetInt32(1);
                string nombre = reader.GetString(2);
                string apellidoP = reader.GetString(3);
                string apellidoM = reader.GetString(4);
                DateTime fechaNacimiento = reader.GetDateTime(5);
                string genero = reader.GetString(6);
                string estadoCivil = reader.GetString(7);
                string curp = reader.GetString(8);
                string tipoSangre = reader.GetString(9);
                string domicilio = reader.GetString(10);
                string telefonoCorreo = reader.GetString(11);
            }
        }
    }
    public static void registraPacientes(int expediente, string nombre, string apellidoP, string apellidoM, DateTime fechaNacimiento, string genero, string estadoCivil, string curp, string tipoSangre, string domicilio, string telefonoCorreo)
    {
        Conexion con = new Conexion();
        using (SqlConnection conexion = con.estableceConexion())
        {
            conexion.Open();

            string query = "INSERT INTO Paciente (numero_expediente, nombre, apellido_paterno, apellido_materno, fecha_nacimiento, genero, estado_civil, CURP, tipo_sangre, domicilio, telefonocorreo) VALUES (@expediente, @nombreP, @apellidoP, @apellidoM, @fechaNacimiento, @genero, @estadoCivil, @curp, @tipoSangre, @domicilio, @telefonoCorreo)";

            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@expediente", expediente);
            cmd.Parameters.AddWithValue("@nombreP", nombre);
            cmd.Parameters.AddWithValue("@apellidoP", apellidoP);
            cmd.Parameters.AddWithValue("@apellidoM", apellidoM);
            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@genero", genero);
            cmd.Parameters.AddWithValue("@estadoCivil", estadoCivil);
            cmd.Parameters.AddWithValue("@curp", curp);
            cmd.Parameters.AddWithValue("@tipoSangre", tipoSangre);
            cmd.Parameters.AddWithValue("@domicilio", domicilio);
            cmd.Parameters.AddWithValue("@telefonoCorreo", telefonoCorreo);

        }
    }
}