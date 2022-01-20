using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Inventario.Formularios.Productos
{
    public partial class modificarProductos : Form
    {
        Clases.funcionesProductos fproductos = new Clases.funcionesProductos();
        DataTable Prod = new DataTable();
        string[,] datos;
        DataTable columnaTipos = new DataTable();
        string[,] tipos;
        DataTable columnaProv = new DataTable();
        string[,] prov;
        DataTable columnaDepart = new DataTable();
        string[,] depart;
        DataTable columnaID = new DataTable();
        int[] ID;

        public string[,] datosProd()
        {
            Prod = fproductos.DatosProductos(Convert.ToInt32(idprod.Text));
            datos = new string[1, Prod.Columns.Count];

            for (int i = 0; i < Prod.Columns.Count; i++)
            {
                datos[0, i] = Prod.Rows[0][i].ToString();
            }
            return datos;
        }

        void datosTipos()
        {
            columnaTipos = fproductos.ListaTipos();
            tipos = new string[columnaTipos.Rows.Count, 2];
            for (int i = 0; i < columnaTipos.Rows.Count; i++)
            {
                tipos[i, 0] = columnaTipos.Rows[i]["ID"].ToString();
                tipos[i, 1] = columnaTipos.Rows[i]["TIPO"].ToString();
            }
            for (int i = 0; i < columnaTipos.Rows.Count; i++)
            {
                tipo.Items.Add(tipos[i, 0]);
            }
        }

        void datosProv()
        {
            columnaProv = fproductos.ListaProv();
            prov = new string[columnaProv.Rows.Count, 2];
            for (int i = 0; i < columnaProv.Rows.Count; i++)
            {
                prov[i, 0] = columnaProv.Rows[i]["ID"].ToString();
                prov[i, 1] = columnaProv.Rows[i]["EMPRESA"].ToString();
            }
            for (int i = 0; i < columnaProv.Rows.Count; i++)
            {
                proveedor.Items.Add(prov[i, 0]);
            }
        }

        void datosDepart()
        {
            columnaDepart = fproductos.ListaDepart();
            depart = new string[columnaDepart.Rows.Count, 2];
            for (int i = 0; i < columnaDepart.Rows.Count; i++)
            {
                depart[i, 0] = columnaDepart.Rows[i]["ID"].ToString();
                depart[i, 1] = columnaDepart.Rows[i]["DEPARTAMENTO"].ToString();
            }
            for (int i = 0; i < columnaDepart.Rows.Count; i++)
            {
                departamento.Items.Add(depart[i, 0]);
            }
        }

        public int[] datosProdID()
        {
            columnaID = fproductos.ListaProdID();
            ID = new int[columnaID.Rows.Count];
            for (int i = 0; i < columnaID.Rows.Count; i++)
            {
                ID[i] = int.Parse(columnaID.Rows[i]["ID"].ToString());
            }
            return ID;
        }

        private void controlAceptar()
        {
            if (nombre.Text.Trim() != string.Empty && precio.Text.Trim() != string.Empty)
            {
                btnAceptarProd.Enabled = true;
                errorProvider1.SetError(nombre, "");
                errorProvider2.SetError(precio, "");
            }
            else
            {
                if (nombre.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(nombre, "Debe llenar el campo...");
                }
                if (precio.Text.Trim() == string.Empty)
                {
                    errorProvider2.SetError(precio, "Debe llenar el campo...");
                }
                btnAceptarProd.Enabled = false;
            }
        }

        public modificarProductos()
        {
            InitializeComponent();
        }

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarProd_Click(object sender, EventArgs e)
        {
            fproductos.ModificarProducto(Convert.ToInt32(idprod.Text),
                    nombre.Text, descripcion.Text, Convert.ToInt32(cantidad.Text),
                    float.Parse(precio.Text), Convert.ToInt32(tipo.SelectedItem),
                    Convert.ToInt32(proveedor.SelectedItem), Convert.ToInt32(departamento.SelectedItem));
            this.Close();
            MessageBox.Show("Datos modificados con exito!");
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            int[] id = datosProdID();
            bool existe = false;

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == Convert.ToInt32(idprod.Text))
                {
                    existe = true;
                }
            }
            if (existe == true)
            {
                nombre.Enabled = true;
                precio.Enabled = true;
                cantidad.Enabled = true;
                descripcion.Enabled = true;
                proveedor.Enabled = true;
                departamento.Enabled = true;
                tipo.Enabled = true;
                idprod.Enabled = false;

                string[,] dato = datosProd();
                nombre.Text = dato[0, 1].ToString();
                descripcion.Text = dato[0, 2].ToString();
                cantidad.Text = dato[0, 3].ToString();
                precio.Text = dato[0, 4].ToString();
                tipo.Text = dato[0, 5].ToString();
                proveedor.Text = dato[0, 6].ToString();
                departamento.Text = dato[0, 7].ToString();

                MessageBox.Show("Registro encontrado!");
            }
            else
            {
                MessageBox.Show("El ID ingresado es incorrecto...");
            }
        }

        private void modificarProductos_Load(object sender, EventArgs e)
        {
            datosTipos();
            datosProv();
            datosDepart();
            if (idprod.Text.Trim() == string.Empty)
            {
                btnAceptarProd.Enabled = false;
                nombre.Enabled = false;
                precio.Enabled = false;
                cantidad.Enabled = false;
                descripcion.Enabled = false;
                proveedor.Enabled = false;
                departamento.Enabled = false;
                tipo.Enabled = false;
                errorProvider3.SetError(idprod, "Primero busque por ID");
            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void precio_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
