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
    public partial class modificarFactura : Form
    {
        Clases.funcionesFactura ffacturas = new Clases.funcionesFactura();
        DataTable columnaProv = new DataTable();
        string[,] prov;
        DataTable Fact = new DataTable();
        string[,] datos;
        DataTable columnaID = new DataTable();
        int[] ID;

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

        public string[,] datosfact()
        {
            Fact = ffacturas.DatosFacturas(Convert.ToInt32(idfact.Text));
            datos = new string[1, Fact.Columns.Count];

            for (int i = 0; i < Fact.Columns.Count; i++)
            {
                datos[0, i] = Fact.Rows[0][i].ToString();
            }
            return datos;
        }

        public int[] datosFactID()
        {
            columnaID = ffacturas.ListaFact();
            ID = new int[columnaID.Rows.Count];
            for (int i = 0; i < columnaID.Rows.Count; i++)
            {
                ID[i] = int.Parse(columnaID.Rows[i]["ID"].ToString());
            }
            return ID;
        }

        private void controlAceptar()
        {
            if (proveedor.Text.Trim() != string.Empty && valor.Text.Trim() != string.Empty)
            {
                btnAceptarFact.Enabled = true;
                errorProvider1.SetError(proveedor, "");
                errorProvider2.SetError(valor, "");
            }
            else
            {
                if (proveedor.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(proveedor, "Debe llenar el campo...");
                }
                if (valor.Text.Trim() == string.Empty)
                {
                    errorProvider2.SetError(valor, "Debe llenar el campo...");
                }
                btnAceptarFact.Enabled = false;
            }
        }

        public modificarFactura()
        {
            InitializeComponent();
        }

        private void btnCancelarFact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarFact_Click(object sender, EventArgs e)
        {
            ffacturas.ModificarFactura(Convert.ToInt32(idfact.Text),
                    float.Parse(valor.Text), Convert.ToInt32(proveedor.SelectedItem));
            this.Close();
            MessageBox.Show("Datos guardados con exito!");
        }

        private void btnBuscarFact_Click(object sender, EventArgs e)
        {
            int[] id = datosFactID();
            bool existe = false;

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == Convert.ToInt32(idfact.Text))
                {
                    existe = true;
                }
            }
            if (existe == true)
            {
                valor.Enabled = true;
                proveedor.Enabled = true;

                string[,] dato = datosfact();
                valor.Text = dato[0, 1].ToString();
                proveedor.Text = dato[0, 2].ToString();

                MessageBox.Show("Registro encontrado!");
            }
            else
            {
                MessageBox.Show("El ID ingresado es incorrecto...");
            }
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void modificarFactura_Load(object sender, EventArgs e)
        {
            datosProv();
            if (idfact.Text.Trim() == string.Empty)
            {
                btnAceptarFact.Enabled = false;
                valor.Enabled = false;
                proveedor.Enabled = false;
                errorProvider3.SetError(idfact, "Primero busque por ID");
            }
        }
    }
}
