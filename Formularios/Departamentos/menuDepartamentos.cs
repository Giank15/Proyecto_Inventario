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
    public partial class menuDepartamentos : Form
    {
        Clases.funcionesDepartamento fdepartamentos = new Clases.funcionesDepartamento();

        public menuDepartamentos()
        {
            InitializeComponent();
        }

        private void btnAtrasDepart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuDepartamentos_Load(object sender, EventArgs e)
        {
            tablaDepartamentos.DataSource = fdepartamentos.ActualizarDepartamentos();
        }

        private void btnActualizarDepart_Click(object sender, EventArgs e)
        {
            tablaDepartamentos.DataSource = fdepartamentos.ActualizarDepartamentos();
        }

        private void btnBuscarDepart_Click(object sender, EventArgs e)
        {
            using (buscarDepartamentos ventanaBuscar = new buscarDepartamentos())
                ventanaBuscar.ShowDialog();
        }

        private void btnIngresarDepart_Click(object sender, EventArgs e)
        {
            using (ingresarDepartamentos ventanaIngresar = new ingresarDepartamentos())
                ventanaIngresar.ShowDialog();
        }

        private void btnModificarDepart_Click(object sender, EventArgs e)
        {
            using (modificarDepartamentos ventanaModificar = new modificarDepartamentos())
                ventanaModificar.ShowDialog();
        }

        private void btnEliminarDepart_Click(object sender, EventArgs e)
        {
            using (eliminarDepartamentos ventanaEliminar = new eliminarDepartamentos())
                ventanaEliminar.ShowDialog();
        }
    }
}
