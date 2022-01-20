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
    public partial class ingresarProductos : Form
    {
        Clases.funcionesProductos fproductos = new Clases.funcionesProductos();
        DataTable columnaTipos = new DataTable();
        string[,] tipos;
        DataTable columnaProv = new DataTable();
        string[,] prov;
        DataTable columnaDepart = new DataTable();
        string[,] depart;
        DataTable columnaID = new DataTable();
        int[] ID;

        void datosTipos()
        {
            columnaTipos = fproductos.ListaTipos();
            tipos = new string[columnaTipos.Rows.Count, 2];
            for (int i = 0; i < columnaTipos.Rows.Count; i++)
            {
                tipos[i,0] = columnaTipos.Rows[i]["ID"].ToString();
                tipos[i,1] = columnaTipos.Rows[i]["TIPO"].ToString();
            }
            for (int i = 0; i < columnaTipos.Rows.Count; i++)
            {
                tipo.Items.Add(tipos[i,0]);
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

        public ingresarProductos()
        {
            InitializeComponent();
        }

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarProd_Click(object sender, EventArgs e)
        {
            int[] id = datosProdID();
            bool existe = false;
            //DataTable columnat = new DataTable();
            //columnat = fproductos.ListaTipos();
            //DataRow data = (DataRow)tipo.SelectedItem;
            //int dato1 = int.Parse(columnat.Rows[Convert.ToInt32(columnat.Rows.IndexOf((DataRow)tipo.SelectedItem))]["ID"].ToString());

            if (idprod.Text.Trim() != string.Empty)
            {
                for (int i = 0; i < id.Length; i++)
                {
                    if (id[i] == Convert.ToInt32(idprod.Text))
                    {
                        existe = true;
                    }
                }
                if (existe == true)
                {
                    MessageBox.Show("El ID ingresado ya esta registrado...");
                }
                else
                {
                    fproductos.InsertarProducto(Convert.ToInt32(idprod.Text),
                    nombre.Text, descripcion.Text, Convert.ToInt32(cantidad.Text),
                    float.Parse(precio.Text), Convert.ToInt32(tipo.SelectedItem),
                    Convert.ToInt32(proveedor.SelectedItem), Convert.ToInt32(departamento.SelectedItem));
                    this.Close();
                    MessageBox.Show("Datos guardados con exito!");
                }
            }
            else
            {
                fproductos.InsertarProductoNull(nombre.Text, descripcion.Text, Convert.ToInt32(cantidad.Text),
                    float.Parse(precio.Text), Convert.ToInt32(tipo.SelectedItem),
                    Convert.ToInt32(proveedor.SelectedItem), Convert.ToInt32(departamento.SelectedItem));
                this.Close();
                MessageBox.Show("Datos guardados con exito!");
            }
        }

        private void ingresarProductos_Load(object sender, EventArgs e)
        {
            datosTipos();
            datosProv();
            datosDepart();
            if (nombre.Text.Trim() == string.Empty && precio.Text.Trim() == string.Empty)
            {
                btnAceptarProd.Enabled = false;
                errorProvider1.SetError(nombre, "Debe llenar el campo...");
                errorProvider2.SetError(precio, "Debe llenar el campo...");
            }
            if (idprod.Text.Trim() == string.Empty)
            {
                errorProvider3.SetError(idprod, "Complete el campo si necesita un id especifico...");
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
