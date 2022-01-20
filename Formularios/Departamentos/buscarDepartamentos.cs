using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Inventario.Formularios.Departamentos
{
    public partial class buscarDepartamentos : Form
    {
        Clases.funcionesDepartamento fdepartamentos = new Clases.funcionesDepartamento();

        private void controlAceptar()
        {
            if (buscarDepart.Text.Trim() != string.Empty)
            {
                btnAceptarBuscar.Enabled = true;
                errorProvider1.SetError(buscarDepart, "");
            }
            else
            {
                if (buscarDepart.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(buscarDepart, "Campo obligatorio");
                }
                btnAceptarBuscar.Enabled = false;
            }
        }

        public buscarDepartamentos()
        {
            InitializeComponent();
        }

        private void btnCancelarBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarBuscar_Click(object sender, EventArgs e)
        {
            tablaBuscar.DataSource = fdepartamentos.BuscarDepartamento(buscarDepart.Text);
            MessageBox.Show("Registros encontrados...");
        }

        private void buscarDepartamentos_Load(object sender, EventArgs e)
        {
            if (buscarDepart.Text.Trim() == string.Empty)
            {
                btnAceptarBuscar.Enabled = false;
                errorProvider1.SetError(buscarDepart, "Campo obligatorio");
            }
        }

        private void buscarDepart_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
