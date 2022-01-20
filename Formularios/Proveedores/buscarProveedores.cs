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
    public partial class buscarProveedores : Form
    {
        Clases.funcionesProveedor fproveedores = new Clases.funcionesProveedor();

        private void controlAceptar()
        {
            if (buscarProv.Text.Trim() != string.Empty)
            {
                btnAceptarBuscar.Enabled = true;
                errorProvider1.SetError(buscarProv, "");
            }
            else
            {
                if (buscarProv.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(buscarProv, "Campo obligatorio");
                }
                btnAceptarBuscar.Enabled = false;
            }
        }

        public buscarProveedores()
        {
            InitializeComponent();
        }

        private void btnCancelarBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarBuscar_Click(object sender, EventArgs e)
        {
            tablaBuscar.DataSource = fproveedores.BuscarProveedores(buscarProv.Text);
            MessageBox.Show("Registros encontrados...");
        }

        private void buscarProveedores_Load(object sender, EventArgs e)
        {
            if (buscarProv.Text.Trim() == string.Empty)
            {
                btnAceptarBuscar.Enabled = false;
                errorProvider1.SetError(buscarProv, "Campo obligatorio");
            }
        }

        private void buscarProv_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
