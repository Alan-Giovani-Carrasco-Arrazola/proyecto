using System.Data.SqlClient;
using System.Windows.Forms;

namespace Integrador
{
    internal class Conexion
    {
        static string servidor = "localhost";
        static string bd = "MedCenter2";
        static string usuario = "root2";
        static string pass = "root2";
        static string puerto = "1433";

        string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";User ID=" + usuario + ";Password=" + pass + ";Initial Catalog=" + bd + ";Persist Security Info=True;";

        public SqlConnection estableceConexion()
        {
            try
            {
                SqlConnection conex = new SqlConnection(cadenaConexion);
                conex.Open();
                return conex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay conexión a la BD" + ex.ToString());
                return null;
            }
        }
    }
}
