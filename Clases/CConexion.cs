using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Inventario.Clases
{
    public class CConexion
    {
        NpgsqlConnection conex = new NpgsqlConnection();

        static string servidor = "localhost";
        static string bd = "Proyecto_Inventario";
        static string bdUser = "gqueirolo";
        static string bdContra = "15051709aA";
        static string puerto = "5432";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + bdUser + ";" 
            + "password=" + bdContra + ";" + "database=" + bd + ";";

        public NpgsqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto a la Base de Datos.");
            }

            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede conectar a la Base de Datos. Error: " + e.ToString());
            }
            return conex;
        }
    }
}
