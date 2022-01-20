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
    public partial class ingresarDepartamentos : Form
    {
        Clases.funcionesDepartamento fdepartamentos = new Clases.funcionesDepartamento();
        DataTable columnaID = new DataTable();
        int[] ID;
        string[] jerarquiaop = new string[] { "Nivel 1" , "Nivel 2", "Nivel 3" };

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

        private void controlAceptar()
        {
            if (departamento.Text.Trim() != string.Empty && administrador.Text.Trim() != string.Empty)
            {
                btnAceptarDepart.Enabled = true;
                errorProvider1.SetError(departamento, "");
                errorProvider2.SetError(administrador, "");
            }
            else
            {
                if (departamento.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(departamento, "Debe llenar el campo...");
                }
                if (administrador.Text.Trim() == string.Empty)
                {
                    errorProvider2.SetError(administrador, "Debe llenar el campo...");
                }
                btnAceptarDepart.Enabled = false;
            }
        }

        public ingresarDepartamentos()
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
            if (iddepart.Text.Trim() != string.Empty)
            {
                for (int i = 0; i < id.Length; i++)
                {
                    if (id[i] == Convert.ToInt32(iddepart.Text))
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
                    fdepartamentos.InsertarDepartamento(Convert.ToInt32(iddepart.Text),
                    departamento.Text, administrador.Text, Convert.ToInt32(nempleados.Text),
                    Convert.ToString(jerarquia.SelectedItem));
                    this.Close();
                    MessageBox.Show("Datos guardados con exito!");
                }
            }
            else
            {
                fdepartamentos.InsertarDepartamentoNull(departamento.Text,
                administrador.Text, Convert.ToInt32(nempleados.Text),
                Convert.ToString(jerarquia.SelectedItem));
                this.Close();
                MessageBox.Show("Datos guardados con exito!");
            }
        }

        private void ingresarDepartamentos_Load(object sender, EventArgs e)
        {
            jerarquia.Items.Add(jerarquiaop[0]);
            jerarquia.Items.Add(jerarquiaop[1]);
            jerarquia.Items.Add(jerarquiaop[2]);
            if (departamento.Text.Trim() == string.Empty && administrador.Text.Trim() == string.Empty)
            {
                btnAceptarDepart.Enabled = false;
                errorProvider1.SetError(departamento, "Debe llenar el campo...");
                errorProvider2.SetError(administrador, "Debe llenar el campo...");
            }
            if (iddepart.Text.Trim() == string.Empty)
            {
                errorProvider3.SetError(iddepart, "Complete el campo si necesita un id especifico...");
            }
        }

        private void departamento_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void administrador_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }
    }
}
