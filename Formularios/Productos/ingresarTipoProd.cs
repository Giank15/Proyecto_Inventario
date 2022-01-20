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
    public partial class ingresarTipoProd : Form
    {
        Clases.funcionesProductos fproductos = new Clases.funcionesProductos();

        private void controlAceptar()
        {
            if (tipoProducto.Text.Trim() != string.Empty)
            {
                btnAceptarProd.Enabled = true;
                errorProvider1.SetError(tipoProducto, "");
            }
            else
            {
                if (tipoProducto.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(tipoProducto, "Debe llenar el campo...");
                }
                btnAceptarProd.Enabled = false;
            }
        }

        public ingresarTipoProd()
        {
            InitializeComponent();
        }

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarProd_Click(object sender, EventArgs e)
        {
            fproductos.InsertarTipoProd(tipoProducto.Text);
            this.Close();
            MessageBox.Show("Datos guardados con exito!");
        }

        private void ingresarTipoProd_Load(object sender, EventArgs e)
        {
            if (tipoProducto.Text.Trim() == string.Empty)
            {
                btnAceptarProd.Enabled = false;
                errorProvider1.SetError(tipoProducto, "Debe llenar el campo...");
            }
        }

        private void tipoProducto_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
