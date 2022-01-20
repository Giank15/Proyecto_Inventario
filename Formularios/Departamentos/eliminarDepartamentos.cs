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
    public partial class eliminarDepartamentos : Form
    {
        Clases.funcionesDepartamento fdepartamentos = new Clases.funcionesDepartamento();
        DataTable columnaID = new DataTable();
        int[] ID;

        private void controlAceptar()
        {
            if (eliminar.Text.Trim() != string.Empty)
            {
                btnAceptarDepart.Enabled = true;
                errorProvider1.SetError(eliminar, "");
            }
            else
            {
                if (eliminar.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(eliminar, "Debe llenar el campo...");
                }
                btnAceptarDepart.Enabled = false;
                eliminar.Focus();
            }
        }

        public int[] datosDepartID()
        {
            columnaID = fdepartamentos.ListaDepartID();
            ID = new int[columnaID.Rows.Count];
            for (int i = 0; i < columnaID.Rows.Count; i++)
            {
                ID[i] = int.Parse(columnaID.Rows[i]["ID"].ToString());
            }
            return ID;
        }

        public eliminarDepartamentos()
        {
            InitializeComponent();
        }

        private void btnCancelarDepart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarDepart_Click(object sender, EventArgs e)
        {
            int[] id = datosDepartID();
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
                fdepartamentos.EliminarDepartamento(Convert.ToInt32(eliminar.Text));
                this.Close();
                MessageBox.Show("Datos eliminados con exito!");
            }
            else
            {
                MessageBox.Show("El ID ingresado es incorrecto...");
            }
        }

        private void eliminarDepartamentos_Load(object sender, EventArgs e)
        {
            if (eliminar.Text.Trim() == string.Empty)
            {
                btnAceptarDepart.Enabled = false;
                errorProvider1.SetError(eliminar, "Debe llenar el campo...");
            }
        }

        private void eliminar_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
