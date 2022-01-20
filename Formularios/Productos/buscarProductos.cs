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
    public partial class buscarProductos : Form
    {
        Clases.funcionesProductos fproductos = new Clases.funcionesProductos();

        private void controlAceptar()
        {
            if (buscarprod.Text.Trim() != string.Empty)
            {
                btnAceptarProd.Enabled = true;
                errorProvider1.SetError(buscarprod, "");
            }
            else
            {
                if (buscarprod.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(buscarprod, "Campo obligatorio");
                }
                btnAceptarProd.Enabled = false;
            }
        }

        public buscarProductos()
        {
            InitializeComponent();
        }

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarProd_Click(object sender, EventArgs e)
        {
            tablaBuscarProd.DataSource = fproductos.BuscarProductos(buscarprod.Text);
            MessageBox.Show("Registros encontrados...");
        }

        private void buscarProductos_Load(object sender, EventArgs e)
        {
            if (buscarprod.Text.Trim() == string.Empty)
            {
                btnAceptarProd.Enabled = false;
                errorProvider1.SetError(buscarprod, "Campo obligatorio");
            }
        }

        private void buscarprod_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
