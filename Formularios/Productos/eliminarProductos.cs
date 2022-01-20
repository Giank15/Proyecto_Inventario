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
    public partial class eliminarProductos : Form
    {
        Clases.funcionesProductos fproductos = new Clases.funcionesProductos();
        DataTable columnaID = new DataTable();
        int[] ID;

        private void controlAceptar()
        {
            if (eliminar.Text.Trim() != string.Empty)
            {
                btnAceptarProd.Enabled = true;
                errorProvider1.SetError(eliminar, "");
            }
            else
            {
                if (eliminar.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(eliminar, "Debe llenar el campo...");
                }
                btnAceptarProd.Enabled = false;
                eliminar.Focus();
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

        public eliminarProductos()
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
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == Convert.ToInt32(eliminar.Text))
                {
                    existe = true;
                }
            }
            if (existe == true)
            {
                fproductos.EliminarProducto(Convert.ToInt32(eliminar.Text));
                this.Close();
                MessageBox.Show("Datos eliminados con exito!");
            }
            else
            {
                MessageBox.Show("El ID ingresado es incorrecto...");
            }
        }

        private void eliminarProductos_Load(object sender, EventArgs e)
        {
            if (eliminar.Text.Trim() == string.Empty)
            {
                btnAceptarProd.Enabled = false;
                errorProvider1.SetError(eliminar, "Debe llenar el campo...");
            }
        }

        private void eliminar_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
