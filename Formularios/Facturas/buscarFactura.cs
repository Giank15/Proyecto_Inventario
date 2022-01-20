using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Inventario.Formularios.Facturas
{
    public partial class buscarFactura : Form
    {
        Clases.funcionesFactura ffacturas = new Clases.funcionesFactura();

        private void controlAceptar()
        {
            if (buscar.Text.Trim() != string.Empty)
            {
                btnAceptarFact.Enabled = true;
                errorProvider1.SetError(buscar, "");
            }
            else
            {
                if (buscar.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(buscar, "Campo obligatorio");
                }
                btnAceptarFact.Enabled = false;
            }
        }

        public buscarFactura()
        {
            InitializeComponent();
        }

        private void btnCancelarFact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarFact_Click(object sender, EventArgs e)
        {
            tablaBuscar.DataSource = ffacturas.BuscarFacturas(buscar.Text);
            MessageBox.Show("Registros encontrados...");
        }

        private void buscarFactura_Load(object sender, EventArgs e)
        {
            if (buscar.Text.Trim() == string.Empty)
            {
                btnAceptarFact.Enabled = false;
                errorProvider1.SetError(buscar, "Campo obligatorio");
            }
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
