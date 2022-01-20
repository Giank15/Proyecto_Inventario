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
    public partial class modificarDepartamentos : Form
    {
        Clases.funcionesDepartamento fdepartamentos = new Clases.funcionesDepartamento();
        DataTable Depart = new DataTable();
        string[,] datos;
        DataTable columnaID = new DataTable();
        int[] ID;
        string[] jerarquiaop = new string[] { "Nivel 1", "Nivel 2", "Nivel 3" };

        public string[,] datosDepart()
        {
            Depart = fdepartamentos.DatosDepartamentos(Convert.ToInt32(iddepart.Text));
            datos = new string[1, Depart.Columns.Count];

            for (int i = 0; i < Depart.Columns.Count; i++)
            {
                datos[0, i] = Depart.Rows[0][i].ToString();
            }
            return datos;
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

        public modificarDepartamentos()
        {
            InitializeComponent();
        }

        private void btnCancelarDepart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarMod_Click(object sender, EventArgs e)
        {
            int[] id = datosDepartID();
            bool existe = false;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == Convert.ToInt32(iddepart.Text))
                {
                    existe = true;
                }
            }
            if (existe == true)
            {
                departamento.Enabled = true;
                administrador.Enabled = true;
                nempleado.Enabled = true;
                jerarquia.Enabled = true;
                iddepart.Enabled = false;

                string[,] dato = datosDepart();
                departamento.Text = dato[0, 1].ToString();
                administrador.Text = dato[0, 2].ToString();
                nempleado.Text = dato[0, 3].ToString();
                jerarquia.Text = dato[0, 4].ToString();

                MessageBox.Show("Registro encontrado!");
            }
            else
            {
                MessageBox.Show("El ID ingresado es incorrecto...");
            }
        }

        private void modificarDepartamentos_Load(object sender, EventArgs e)
        {
            jerarquia.Items.Add(jerarquiaop[0]);
            jerarquia.Items.Add(jerarquiaop[1]);
            jerarquia.Items.Add(jerarquiaop[2]);
            if (iddepart.Text.Trim() == string.Empty)
            {
                btnAceptarDepart.Enabled = false;
                departamento.Enabled = false;
                administrador.Enabled = false;
                nempleado.Enabled = false;
                jerarquia.Enabled = false;
                errorProvider3.SetError(iddepart, "Primero busque por ID");
            }
        }

        private void btnAceptarDepart_Click(object sender, EventArgs e)
        {
            fdepartamentos.ModificarDepartamento(Convert.ToInt32(iddepart.Text),
                    departamento.Text, administrador.Text, Convert.ToInt32(nempleado.Text),
                    Convert.ToString(jerarquia.SelectedItem));
            this.Close();
            MessageBox.Show("Datos modificados con exito!");
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
