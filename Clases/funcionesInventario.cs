using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Inventario.Clases
{
    class funcionesInventario
    {
        static string servidor = "localhost";
        static string bd = "Proyecto_Inventario";
        static string bdUser = "gqueirolo";
        static string bdContra = "15051709aA";
        static string puerto = "5432";


        NpgsqlConnection conex = new NpgsqlConnection("server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + bdUser + ";"
            + "password=" + bdContra + ";" + "database=" + bd + ";");

        public DataTable ActualizarInventario()
        {
            string query = "select PROD_ID as ID, PROD_NAME as PRODUCTO, PROD_CANTIDAD as EXISTENCIA, PROD_PRECIO as PRECIO, FACTURA.FACT_ID as FACTURA, " +
                "TIPO_PRODUCTO.TPROD_NAME as TIPO_PRODUCTO, PROVEEDOR.PROV_VENDNM as VENDEDOR, PROVEEDOR.PROV_EMPRENM as EMPRESA, " +
                "TIPO_PROVEEDOR.TPROV_NAME as TIPO_PROVEEDOR, PROVEEDOR.PROV_TELF as TELEFONO, DEPARTAMENTO.DEPART_NAME as DEPARTAMENTO, " +
                "DEPARTAMENTO.DEPART_ADMINM as ADMINISTRADOR, DEPARTAMENTO.DEPART_NUMEROEMP as EMPLEADOS " +
                "from PRODUCTO inner join PROVEEDOR ON PROV_ID= PROD_PROV_ID " +
                "\ninner join TIPO_PROVEEDOR ON TPROV_ID= PROV_TPROV_ID " +
                "\ninner join TIPO_PRODUCTO ON TPROD_ID= PROD_TPROD_ID " +
                "\ninner join FACTURA ON FACT_PROV_ID= PROV_ID " +
                "\ninner join DEPARTAMENTO ON DEPART_ID= PROD_DEPART_ID";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable BuscarInventario(string consulta)
        {
            string query = "select PROD_ID as ID, PROD_NAME as PRODUCTO, PROD_CANTIDAD as EXISTENCIA, PROD_PRECIO as PRECIO, FACTURA.FACT_ID as FACTURA, " +
                "TIPO_PRODUCTO.TPROD_NAME as TIPO_PRODUCTO, PROVEEDOR.PROV_VENDNM as VENDEDOR, PROVEEDOR.PROV_EMPRENM as EMPRESA, " +
                "TIPO_PROVEEDOR.TPROV_NAME as TIPO_PROVEEDOR, PROVEEDOR.PROV_TELF as TELEFONO, DEPARTAMENTO.DEPART_NAME as DEPARTAMENTO, " +
                "DEPARTAMENTO.DEPART_ADMINM as ADMINISTRADOR, DEPARTAMENTO.DEPART_NUMEROEMP as EMPLEADOS " +
                "from PRODUCTO inner join PROVEEDOR ON PROV_ID= PROD_PROV_ID " +
                "\ninner join TIPO_PROVEEDOR ON TPROV_ID= PROV_TPROV_ID " +
                "\ninner join TIPO_PRODUCTO ON TPROD_ID= PROD_TPROD_ID " +
                "\ninner join DEPARTAMENTO ON DEPART_ID= PROD_DEPART_ID " +
                "\ninner join FACTURA ON FACT_PROV_ID= PROV_ID " +
                "\nwhere PROD_NAME like '%" + consulta + "%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }
    }
}
