using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Inventario.Clases
{
    class funcionesProveedor
    {
        static string servidor = "localhost";
        static string bd = "Proyecto_Inventario";
        static string bdUser = "gqueirolo";
        static string bdContra = "15051709aA";
        static string puerto = "5432";


        NpgsqlConnection conex = new NpgsqlConnection("server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + bdUser + ";"
            + "password=" + bdContra + ";" + "database=" + bd + ";");

        public DataTable ListaTipos()
        {
            string query = "select TPROV_ID as ID from TIPO_PROVEEDOR;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ListaProvID()
        {
            string query = "select PROV_ID as ID from PROVEEDOR;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ActualizarProveedores()
        {
            string query = "select PROV_ID as ID, PROV_VENDNM as EJECUTIVO_VENTAS, PROV_TELF as TELEFONO, PROV_EMPRENM as DISTRIBUIDORA, TPROV_NAME as TIPO " +
                "from PROVEEDOR inner join TIPO_PROVEEDOR ON TPROV_ID= PROV_TPROV_ID";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable DatosProveedores(int id)
        {
            string query = "select PROV_ID, PROV_VENDNM, PROV_TELF, PROV_EMPRENM, TPROV_ID " +
                "from PROVEEDOR inner join TIPO_PROVEEDOR ON TPROV_ID= PROV_TPROV_ID " +
                "where PROV_ID = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable BuscarProveedores(string nombre)
        {
            string query = "select PROV_ID as ID, PROV_VENDNM as EJECUTIVO_VENTAS, PROV_TELF as TELEFONO, PROV_EMPRENM as DISTRIBUIDORA, TPROV_NAME as TIPO " +
                "from PROVEEDOR inner join TIPO_PROVEEDOR ON TPROV_ID= PROV_TPROV_ID " +
                "where PROV_VENDNM like '%" + nombre + "%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void InsertarTipoProv(string nombre)
        {
            string query = "insert into TIPO_PROVEEDOR (TPROV_NAME) values ('" + nombre + "');";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void InsertarProveedor(int id, string nombre, string telefono, string empresa, int tipo)
        {
            string query = "insert into PROVEEDOR (PROV_ID, PROV_VENDNM, PROV_TELF, PROV_EMPRENM, PROV_TPROV_ID) values " +
                "('" + id + "', '" + nombre + "', '" + telefono + "', '" + empresa + "', " + tipo + ");";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void InsertarProveedorNull(string nombre, string telefono, string empresa, int tipo)
        {
            string query = "insert into PROVEEDOR (PROV_VENDNM, PROV_TELF, PROV_EMPRENM, PROV_TPROV_ID) values " +
                "('" + nombre + "', '" + telefono + "', '" + empresa + "', " + tipo + ");";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void EliminarProveedor(int ID)
        {
            string query = "delete from PROVEEDOR where PROV_ID = " + ID + ";";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void ModificarProveedor(int id, string nombre, string telefono, string empresa, int tipo)
        {
            string query = "update PROVEEDOR set PROV_VENDNM = '" + nombre + "', PROV_TELF = '" + telefono + "', " +
                "PROV_EMPRENM = '" + empresa + "', PROV_TPROV_ID = " + tipo + " " +
                "where PROV_ID = '" + id + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }
    }
}
