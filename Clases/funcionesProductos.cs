using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Inventario.Clases
{
    class funcionesProductos
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
            string query = "select TPROD_ID as ID, TPROD_NAME as TIPO from TIPO_PRODUCTO;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ListaProv()
        {
            string query = "select PROV_ID as ID, PROV_EMPRENM as EMPRESA from PROVEEDOR;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ListaDepart()
        {
            string query = "select DEPART_ID as ID, DEPART_NAME as DEPARTAMENTO from DEPARTAMENTO;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ListaProdID()
        {
            string query = "select PROD_ID as ID from PRODUCTO;";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable DatosProductos(int id)
        {
            string query = "select PROD_ID, PROD_NAME, PROD_DESCRIP, PROD_CANTIDAD, PROD_PRECIO, PROD_TPROD_ID, PROD_PROV_ID, PROD_DEPART_ID " +
                "from PRODUCTO " + "where PROD_ID = '" + id + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable ActualizarProductos()
        {
            string query = "select PROD_ID as ID, PROD_NAME as PRODUCTO, PROD_DESCRIP as DESCRIPCION, PROD_CANTIDAD as EXISTENCIA, TIPO_PRODUCTO.TPROD_NAME as TIPO_PRODUCTO, PROVEEDOR.PROV_EMPRENM as PROVEEDOR, PROD_PRECIO as PRECIO, DEPARTAMENTO.DEPART_NAME as DEPARTAMENTO " +
                "from PRODUCTO inner join PROVEEDOR ON PROV_ID= PROD_PROV_ID " +
                "\ninner join TIPO_PRODUCTO ON TPROD_ID= PROD_TPROD_ID " +
                "\ninner join DEPARTAMENTO ON DEPART_ID= PROD_DEPART_ID";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable BuscarProductos(string consulta)
        {
            string query = "select PROD_ID as ID, PROD_NAME as PRODUCTO, PROD_DESCRIP as DESCRIPCION, PROD_CANTIDAD as EXISTENCIA, TIPO_PRODUCTO.TPROD_NAME as TIPO_PRODUCTO, PROVEEDOR.PROV_EMPRENM as PROVEEDOR, PROD_PRECIO as PRECIO, DEPARTAMENTO.DEPART_NAME as DEPARTAMENTO " +
                "from PRODUCTO inner join PROVEEDOR ON PROV_ID= PROD_PROV_ID " +
                "\ninner join TIPO_PRODUCTO ON TPROD_ID= PROD_TPROD_ID " +
                "\ninner join DEPARTAMENTO ON DEPART_ID= PROD_DEPART_ID " +
                "\nwhere PROD_NAME like '%" + consulta + "%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void InsertarTipoProd(string nombre)
        {
            string query = "insert into TIPO_PRODUCTO (TPROD_NAME) values ('" + nombre + "');";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void InsertarProducto(int id, string nombre, string descripcion, int cantidad, float precio, int tipo, int proveedor, int departamento)
        {
            string query = "insert into PRODUCTO (PROD_ID, PROD_NAME, PROD_DESCRIP, PROD_CANTIDAD, PROD_PRECIO, PROD_TPROD_ID, PROD_PROV_ID, PROD_DEPART_ID) values " +
                "('" + id + "', '" + nombre + "', '" + descripcion + "', " + cantidad + ", " + precio + ", " + tipo + ", " + proveedor + ", " + departamento + ");";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void InsertarProductoNull(string nombre, string descripcion, int cantidad, float precio, int tipo, int proveedor, int departamento)
        {
            string query = "insert into PRODUCTO (PROD_NAME, PROD_DESCRIP, PROD_CANTIDAD, PROD_PRECIO, PROD_TPROD_ID, PROD_PROV_ID, PROD_DEPART_ID) values " +
                "('" + nombre + "', '" + descripcion + "', " + cantidad + ", " + precio + ", " + tipo + ", " + proveedor + ", " + departamento + ");";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void ModificarProducto(int id, string nombre, string descripcion, int cantidad, float precio, int tipo, int proveedor, int departamento)
        {
            string query = "update PRODUCTO set PROD_NAME = '" + nombre + "', PROD_DESCRIP = '" + descripcion + "', " + "', PROD_CANTIDAD = " + cantidad +
                ", PROD_PRECIO = " + precio + ", PROD_TPROD_ID = " + tipo + ", PROD_PROV_ID = " + proveedor + ", PROD_DEPART_ID = " + departamento + " " +
                "where PROD_ID = '" + id + "';";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }

        public void EliminarProducto(int ID)
        {
            string query = "delete from PRODUCTO where PROD_ID = " + ID + ";";
            NpgsqlCommand conector = new NpgsqlCommand(query, conex);
            conex.Open();
            conector.ExecuteNonQuery();
        }
    }
}
