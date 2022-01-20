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
    public partial class modificarProveedores : Form
    {
        Clases.funcionesProveedor fproveedores = new Clases.funcionesProveedor();
        DataTable Prov = new DataTable();
        string[,] datos;
        DataTable columnaID = new DataTable();
        int[] ID;
        DataTable columnaTipos = new DataTable();
        int[] tipos;

        public string[,] datosProv()
        {
            Prov = fproveedores.DatosProveedores(Convert.ToInt32(buscarMod.Text));
            datos = new string[1, Prov.Columns.Count];

            for (int i = 0; i < Prov.Columns.Count; i++)
            {
                datos[0,i] = Prov.Rows[0][i].ToString();
            }
            return datos;
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
                tipoprovMod.Items.Add(tipos[i]);
            }
        }

        private void controlAceptar()
        {
            if (nombreMod.Text.Trim() != string.Empty && empresaMod.Text.Trim() != string.Empty)
            {
                btnAceptarProv.Enabled = true;
                errorProvider1.SetError(nombreMod, "");
                errorProvider2.SetError(empresaMod, "");
            }
            else
            {
                if (nombreMod.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(nombreMod, "Campo obligatorio...");
                }
                if (empresaMod.Text.Trim() == string.Empty)
                {
                    errorProvider2.SetError(empresaMod, "Campo obligatorio...");
                }
                btnAceptarProv.Enabled = false;
            }
        }

        public modificarProveedores()
        {
            InitializeComponent();
        }

        private void btnCancelarPov_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarModProv_Click(object sender, EventArgs e)
        {
            int[] id = datosProvID();
            bool existe = false;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == Convert.ToInt32(buscarMod.Text))
                {
                    existe = true;
                }
            }
            if (existe == true)
            {
                nombreMod.Enabled = true;
                telefonoMod.Enabled = true;
                empresaMod.Enabled = true;
                tipoprovMod.Enabled = true;
                buscarMod.Enabled = false;

                string[,] dato = datosProv();
                nombreMod.Text = dato[0, 1].ToString();
                telefonoMod.Text = dato[0, 2].ToString();
                empresaMod.Text = dato[0, 3].ToString();
                tipoprovMod.Text = dato[0, 4].ToString();

                MessageBox.Show("Registro encontrado!");
            }
            else
            {
                MessageBox.Show("El ID ingresado es incorrecto...");
            }
        }

        private void btnAceptarProv_Click(object sender, EventArgs e)
        {
            fproveedores.ModificarProveedor(Convert.ToInt32(buscarMod.Text), nombreMod.Text,
                telefonoMod.Text, empresaMod.Text,
                Convert.ToInt32(tipoprovMod.SelectedItem));
            this.Close();
            MessageBox.Show("Datos modificados con exito!");
        }

        private void modificarProveedores_Load(object sender, EventArgs e)
        {
            datosTipos();
            if (buscarMod.Text.Trim() == string.Empty)
            {
                btnAceptarProv.Enabled = false;
                nombreMod.Enabled = false;
                telefonoMod.Enabled = false;
                empresaMod.Enabled = false;
                tipoprovMod.Enabled = false;
                errorProvider3.SetError(buscarMod, "Primero busque por ID");
            }
        }

        private void nombreMod_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void empresaMod_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
