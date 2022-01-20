using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Inventario.Formularios.Proveedores
{
    public partial class ingresarTipoProv : Form
    {
        Clases.funcionesProveedor fproveedores = new Clases.funcionesProveedor();

        private void controlAceptar()
        {
            if (tipoProveedor.Text.Trim() != string.Empty)
            {
                btnAceptarTProv.Enabled = true;
                errorProvider1.SetError(tipoProveedor, "");
            }
            else
            {
                if (tipoProveedor.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(tipoProveedor, "Debe llenar el campo...");
                }
                btnAceptarTProv.Enabled = false;
                tipoProveedor.Focus();
            }
        }

        public ingresarTipoProv()
        {
            InitializeComponent();
        }

        private void btnCancelarTProv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarTProv_Click(object sender, EventArgs e)
        {
            fproveedores.InsertarTipoProv(tipoProveedor.Text);
            this.Close();
            MessageBox.Show("Datos guardados con exito!");
        }

        private void ingresarTipoProv_Load(object sender, EventArgs e)
        {
            if (tipoProveedor.Text.Trim() == string.Empty)
            {
                btnAceptarTProv.Enabled = false;
                errorProvider1.SetError(tipoProveedor, "Debe llenar el campo...");
            }
        }

        private void tipoProveedor_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
