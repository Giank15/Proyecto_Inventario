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
    public partial class ingresarMovimiento : Form
    {
        Clases.funcionesFactura ffacturas = new Clases.funcionesFactura();
        DataTable columnaProd = new DataTable();
        string[] prod;
        DataTable columnaFact = new DataTable();
        string[] fact;

        void datosProd()
        {
            columnaProd = ffacturas.ListaProd();
            prod = new string[columnaProd.Rows.Count];
            for (int i = 0; i < columnaProd.Rows.Count; i++)
            {
                prod[i] = columnaProd.Rows[i]["ID"].ToString();
            }
            for (int i = 0; i < columnaProd.Rows.Count; i++)
            {
                producto.Items.Add(prod[i]);
            }
        }

        void datosFact()
        {
            columnaFact = ffacturas.ListaFact();
            fact = new string[columnaFact.Rows.Count];
            for (int i = 0; i < columnaFact.Rows.Count; i++)
            {
                fact[i] = columnaFact.Rows[i]["ID"].ToString();
            }
            for (int i = 0; i < columnaFact.Rows.Count; i++)
            {
                nfactura.Items.Add(fact[i]);
            }
        }

        private void controlAceptar()
        {
            if (nfactura.Text.Trim() != string.Empty && producto.Text.Trim() != string.Empty)
            {
                btnAceptarFact.Enabled = true;
                errorProvider1.SetError(nfactura, "");
                errorProvider2.SetError(producto, "");
            }
            else
            {
                if (nfactura.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(nfactura, "Debe llenar el campo...");
                }
                if (producto.Text.Trim() == string.Empty)
                {
                    errorProvider2.SetError(producto, "Debe llenar el campo...");
                }
                btnAceptarFact.Enabled = false;
            }
        }

        public ingresarMovimiento()
        {
            InitializeComponent();
        }

        private void btnCancelarFact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarFact_Click(object sender, EventArgs e)
        {
            ffacturas.InsertarMovimiento(Convert.ToInt32(idmov.Text),
                    Convert.ToInt32(nfactura.SelectedItem), 
                    Convert.ToInt32(producto.SelectedItem));
            this.Close();
            MessageBox.Show("Datos guardados con exito!");
        }

        private void ingresarMovimiento_Load(object sender, EventArgs e)
        {
            datosProd();
            datosFact();
            if (nfactura.Text.Trim() == string.Empty && producto.Text.Trim() == string.Empty)
            {
                btnAceptarFact.Enabled = false;
                errorProvider1.SetError(nfactura, "Debe llenar el campo...");
                errorProvider2.SetError(producto, "Debe llenar el campo...");
            }
        }

        private void nfactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
