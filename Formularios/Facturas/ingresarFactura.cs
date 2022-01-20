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
    public partial class ingresarFactura : Form
    {
        Clases.funcionesFactura ffacturas = new Clases.funcionesFactura();
        DataTable columnaProv = new DataTable();
        string[,] prov;

        void datosProv()
        {
            columnaProv = ffacturas.ListaProv();
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

        private void controlAceptar()
        {
            if (idfactura.Text.Trim() != string.Empty && valor.Text.Trim() != string.Empty)
            {
                btnAceptarFact.Enabled = true;
                errorProvider1.SetError(idfactura, "");
                errorProvider2.SetError(valor, "");
            }
            else
            {
                if (idfactura.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(idfactura, "Debe llenar el campo...");
                }
                if (valor.Text.Trim() == string.Empty)
                {
                    errorProvider2.SetError(valor, "Debe llenar el campo...");
                }
                btnAceptarFact.Enabled = false;
            }
        }

        public ingresarFactura()
        {
            InitializeComponent();
        }

        private void btnCancelarFact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarFact_Click(object sender, EventArgs e)
        {
            ffacturas.InsertarFactura(Convert.ToInt32(idfactura.Text),
                    float.Parse(valor.Text), Convert.ToInt32(proveedor.SelectedItem));
            this.Close();
            MessageBox.Show("Datos guardados con exito!");
        }

        private void ingresarFactura_Load(object sender, EventArgs e)
        {
            datosProv();
            if (idfactura.Text.Trim() == string.Empty && valor.Text.Trim() == string.Empty)
            {
                btnAceptarFact.Enabled = false;
                errorProvider1.SetError(idfactura, "Debe llenar el campo...");
                errorProvider2.SetError(valor, "Debe llenar el campo...");
            }
        }

        private void idfactura_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
