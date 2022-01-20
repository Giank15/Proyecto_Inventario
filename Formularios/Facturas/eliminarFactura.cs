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
    public partial class eliminarFactura : Form
    {
        Clases.funcionesFactura ffacturas = new Clases.funcionesFactura();
        DataTable columnaID = new DataTable();
        int[] ID;

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
            if (eliminar.Text.Trim() != string.Empty)
            {
                btnAceptarFact.Enabled = true;
                errorProvider1.SetError(eliminar, "");
            }
            else
            {
                if (eliminar.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(eliminar, "Debe llenar el campo...");
                }
                btnAceptarFact.Enabled = false;
                eliminar.Focus();
            }
        }

        public eliminarFactura()
        {
            InitializeComponent();
        }

        private void btnCancelarFact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarFact_Click(object sender, EventArgs e)
        {
            int[] id = datosFactID();
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
                ffacturas.EliminarFactura(Convert.ToInt32(eliminar.Text));
                this.Close();
                MessageBox.Show("Datos eliminados con exito!");
            }
            else
            {
                MessageBox.Show("El ID ingresado es incorrecto...");
            }
        }

        private void eliminarFactura_Load(object sender, EventArgs e)
        {
            if (eliminar.Text.Trim() == string.Empty)
            {
                btnAceptarFact.Enabled = false;
                errorProvider1.SetError(eliminar, "Debe llenar el campo...");
            }
        }

        private void eliminar_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
