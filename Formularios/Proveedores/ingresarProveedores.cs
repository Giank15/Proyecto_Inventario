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
    public partial class ingresarProveedores : Form
    {
        Clases.funcionesProveedor fproveedores = new Clases.funcionesProveedor();
        DataTable columnaID = new DataTable();
        int[] ID;
        DataTable columnaTipos = new DataTable();
        int[] tipos;

        void datosTipos()
        {
            columnaTipos = fproveedores.ListaTipos();
            tipos = new int[columnaTipos.Rows.Count];
            for (int i = 0; i < columnaTipos.Rows.Count; i++)
            {
                tipos[i] = int.Parse(columnaTipos.Rows[i]["ID"].ToString());
            }
            for (int i = 0; i < tipos.Length; i++)
            {
                tipoprov.Items.Add(tipos[i]);
            }
        }

        public int[] datosProvID()
        {
            columnaID = fproveedores.ListaProvID();
            ID = new int[columnaID.Rows.Count];
            for (int i = 0; i < columnaID.Rows.Count; i++)
            {
                ID[i] = int.Parse(columnaID.Rows[i]["ID"].ToString());
            }
            return ID;
        }

        private void controlAceptar()
        {
            if (nombrevendedor.Text.Trim() != string.Empty && empresa.Text.Trim() != string.Empty)
            {
                btnAceptarProv.Enabled = true;
                errorProvider1.SetError(nombrevendedor, "");
                errorProvider2.SetError(empresa, "");
            }
            else
            {
                if (nombrevendedor.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(nombrevendedor, "Debe llenar el campo...");
                }
                if (empresa.Text.Trim() == string.Empty)
                {
                    errorProvider2.SetError(empresa, "Debe llenar el campo...");
                }
                btnAceptarProv.Enabled = false;
            }
        }

        public ingresarProveedores()
        {
            InitializeComponent();
        }

        private void btnCancelarProv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarProv_Click(object sender, EventArgs e)
        {
            int[] id = datosProvID();
            bool existe = false;
            if (idprov.Text.Trim() != string.Empty)
            {
                for (int i = 0; i < id.Length; i++)
                {
                    if (id[i] == Convert.ToInt32(idprov.Text))
                    {
                        existe = true;
                    }
                }
                if (existe == true)
                {
                    MessageBox.Show("El ID ingresado ya esta registrado...");
                }
                else
                {
                    fproveedores.InsertarProveedor(Convert.ToInt32(idprov.Text),
                    nombrevendedor.Text, telefono.Text, empresa.Text,
                    Convert.ToInt32(tipoprov.SelectedItem));
                    this.Close();
                    MessageBox.Show("Datos guardados con exito!");
                }
            }
            else
            {
                fproveedores.InsertarProveedorNull(nombrevendedor.Text,
                telefono.Text, empresa.Text,
                Convert.ToInt32(tipoprov.SelectedItem));
                this.Close();
                MessageBox.Show("Datos guardados con exito!");
            }
        }

        private void ingresarProveedores_Load(object sender, EventArgs e)
        {
            datosTipos();
            if (nombrevendedor.Text.Trim() == string.Empty && empresa.Text.Trim() == string.Empty)
            {
                btnAceptarProv.Enabled = false;
                errorProvider1.SetError(nombrevendedor, "Debe llenar el campo...");
                errorProvider2.SetError(empresa, "Debe llenar el campo...");
            }
            if (idprov.Text.Trim() == string.Empty)
            {
                errorProvider3.SetError(idprov, "Complete el campo si necesita un id especifico...");
            }
        }

        private void nombrevendedor_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void empresa_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
