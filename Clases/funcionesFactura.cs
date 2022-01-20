using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Inventario.Clases
{
    class funcionesFactura
    {
        static string servidor = "localhost";
        static string bd = "Proyecto_Inventario";
        static string bdUser = "gqueirolo";
        static string bdContra = "15051709aA";
        static string puerto = "5432";


        NpgsqlConnection conex = new NpgsqlConnection("server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + bdUser + ";"
            + "password=" + bdContra + ";" + "database=" + bd + ";");

        public DataTable ListaProv()
        {
            string query = "select PROV_ID as ID, PROV_EMPRENM as EMPRESA from PROVEEDOR;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ListaProd()
        {
            string query = "select PROD_ID as ID from PRODUCTO;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ListaFact()
        {
            string query = "select FACT_ID as ID from FACTURA;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable DatosFacturas(int id)
        {
            string query = "select FACT_ID, FACT_VALOR, FACT_PROV_ID from FACTURA " + 
                "where FACT_ID = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ActualizarFactura()
        {
            string query = "select FACT_ID as ID, PRODUCTO.PROD_NAME as PRODUCTO, PROVEEDOR.PROV_EMPRENM as PROVEEDOR, FACT_VALOR as VALOR, HISTORIAL.HIS_ID as TRANSACCION, HISTORIAL.HIS_FECHA as FECHA " +
                "from FACTURA inner join PROVEEDOR on PROV_ID= FACT_PROV_ID " +
                "\ninner join HISTORIAL ON FACT_ID= HIS_FACT_ID " +
                "\ninner join PRODUCTO on PROD_ID= HIS_PROD_ID";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable BuscarFacturas(string consulta)
        {
            string query = "select FACT_ID as ID, PRODUCTO.PROD_NAME as PRODUCTO, PROVEEDOR.PROV_EMPRENM as PROVEEDOR, FACT_VALOR as VALOR, HISTORIAL.HIS_ID as TRANSACCION, HISTORIAL.HIS_FECHA as FECHA " +
                "from FACTURA inner join PROVEEDOR on PROV_ID= FACT_PROV_ID " +
                "\ninner join HISTORIAL ON FACT_ID= HIS_FACT_ID " +
                "\ninner join PRODUCTO on PROD_ID= HIS_PROD_ID" +
                "\nwhere PRODUCTO.PROD_NAME like '%" + consulta + "%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void InsertarFactura(int id, float valor, int proveedor)
        {
            string query = "insert into FACTURA (FACT_ID, FACT_VALOR, FACT_PROV_ID) values " +
                "(" + id + ", " + valor + ", " + proveedor + ");";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void InsertarMovimiento(int id, int factura, int producto)
        {
            string query = "insert into HISTORIAL (HIS_ID, HIS_FACT_ID, HIS_PROD_ID) values " +
                "(" + id + ", " + factura + ", " + producto + ");";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void ModificarFactura(int id, float valor, int proveedor)
        {
            string query = "update FACTURA set FACT_VALOR = " + valor + ", FACT_PROV_ID = " + proveedor +
                 " where FACT_ID = '" + id + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void EliminarFactura(int ID)
        {
            string query = "delete from HISTORIAL where HIS_FACT_ID = " + ID + "; " +
                "\ndelete from FACTURA where FACT_ID = " + ID + ";";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }
    }
}
