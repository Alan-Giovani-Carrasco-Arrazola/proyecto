using Integrador;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics.Contracts;

internal class Medico
{
    public static void mostrarMedico()
    {
        Conexion con = new Conexion();
       /* try
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Medico", con.estableceConexion());
            // el DataTable es una clase que representa una tabla de datos en memoria, se crea el objeto dt
            DataTable dt = new DataTable();
            adapter.Fill(dt); 
            tablaMedico.DataSource = dt;
            con.cerrarConexion();        
        }
        catch (Exception ex)
        {
            MessageBox.Show("No hay acceso a la TablaAlumnos"
                + ex.ToString());
        }
       */

    }
}