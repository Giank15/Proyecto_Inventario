using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Inventario.Clases
{
    class funcionesDepartamento
    {
        static string servidor = "localhost";
        static string bd = "Proyecto_Inventario";
        static string bdUser = "gqueirolo";
        static string bdContra = "15051709aA";
        static string puerto = "5432";


        NpgsqlConnection conex = new NpgsqlConnection("server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + bdUser + ";"
            + "password=" + bdContra + ";" + "database=" + bd + ";");

        public DataTable ListaDepartID()
        {
            string query = "select DEPART_ID as ID from DEPARTAMENTO;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ActualizarDepartamentos()
        {
            string query = "select DEPART_ID as ID, DEPART_NAME as DEPARTAMENTO, DEPART_ADMINM as ADMINISTRADOR, " +
                "DEPART_NUMEROEMP as EMPLEADOS, DEPART_JERARQUIA as JERARQUIA from DEPARTAMENTO;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable DatosDepartamentos(int id)
        {
            string query = "select DEPART_ID, DEPART_NAME, DEPART_ADMINM, DEPART_NUMEROEMP, DEPART_JERARQUIA from DEPARTAMENTO " +
                "where DEPART_ID = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable BuscarDepartamento(string nombre)
        {
            string query = "select DEPART_ID as ID, DEPART_NAME as DEPARTAMENTO, DEPART_ADMINM as ADMINISTRADOR, " +
                "DEPART_NUMEROEMP as EMPLEADOS, DEPART_JERARQUIA as JERARQUIA from DEPARTAMENTO " +
                "where DEPART_NAME like '%" + nombre + "%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void InsertarDepartamento(int id, string departamento, string administrador, int empleados, string jerarquia)
        {
            string query = "insert into DEPARTAMENTO (DEPART_ID, DEPART_NAME, DEPART_ADMINM, DEPART_NUMEROEMP, DEPART_JERARQUIA) values " +
                "('" + id + "', '" + departamento + "', '" + administrador + "', '" + empleados + "', '" + jerarquia + "');";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void InsertarDepartamentoNull(string departamento, string administrador, int empleados, string jerarquia)
        {
            string query = "insert into DEPARTAMENTO (DEPART_NAME, DEPART_ADMINM, DEPART_NUMEROEMP, DEPART_JERARQUIA) values " +
                "('" + departamento + "', '" + administrador + "', '" + empleados + "', '" + jerarquia + "');";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void ModificarDepartamento(int id, string departamento, string administrador, int empleados, string jerarquia)
        {
            string query = "update DEPARTAMENTO set DEPART_NAME = '" + departamento + "', DEPART_ADMINM = '" + administrador + "', " +
                "DEPART_NUMEROEMP = '" + empleados + "', DEPART_JERARQUIA = '" + jerarquia + "' " +
                "where DEPART_ID = '" + id + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void EliminarDepartamento(int id)
        {
            string query = "delete from DEPARTAMENTO where DEPART_ID = " + id + ";";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }
    }
}
