using System;
using System.Collections.Generic;
using System.Data; // llamar
using Microsoft.Data.SqlClient; // llamar
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // llamar

namespace Integrador{
internal class Conexion
{
    // Se crea el objeto de una nueva conexion
SqlConnection conex = new SqlConnection(); 
// Datos de la conexión
static string servidor = "localhost"; 
static string bd = "Sistema";
static string usuario = "root2";
static string pass = "root2";
static string puerto = "1433";
// Se crea el string de conexión
string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + "User ID=" + usuario + ";" + "Password=" + pass + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=True;";

// Se crea método establece Conexion
public SqlConnection estableceConexion()
{
    try
    {
        conex.ConnectionString = cadenaConexion;
        conex.Open();
        MessageBox.Show("Conexión reealizada a la BD");
    }
    catch (Exception ex)
    {
        MessageBox.Show("No hay conexión a la BD" + ex.ToString());
    }
    return conex;
}

// Se crea metodo cerrarCponexion
public void cerrarConexion()
{
    conex.Close();
}

}
}
