using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Inventario.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void controlBotones()
        {
            if(usuario.Text.Trim() != string.Empty && usuario.Text.All(char.IsLetter))
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(usuario, "");
            }
            else
            {
                if (!(usuario.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(usuario, "El nombre debe contener solo letras...");
                }
                else
                {
                    errorProvider1.SetError(usuario, "Debe introducir su usuario");
                }
                btnIngresar.Enabled = false;
                usuario.Focus();
            }
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "admi" && contra.Text == "1351018500")
            {
                MessageBox.Show("Datos validos. Bienvenido Administrador!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.CConexion conexion = new Clases.CConexion();
                conexion.establecerConexion();
                using (Inicio ventanaInicio = new Inicio(usuario.Text))
                    ventanaInicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se econtraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
