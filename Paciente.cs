using Integrador;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
internal class Paciente
{
    public static DataTable visualizarPacientes()
    {
        Conexion con = new Conexion();
        using (var conexion = con.estableceConexion())
        {
            conexion.Open();
            string query = "SELECT * FROM Paciente";
            using (var adapter = new System.Data.SqlClient.SqlDataAdapter(query, conexion))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
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

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
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

                cmd.ExecuteNonQuery(); // <-- ESTO TE FALTABA
            }
        }
    }
}