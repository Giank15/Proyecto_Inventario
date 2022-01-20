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
    public partial class menuProveedores : Form
    {
        Clases.funcionesProveedor fproveedores = new Clases.funcionesProveedor();

        public menuProveedores()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuDepartamentos_Load(object sender, EventArgs e)
        {
            tablaProveedores.DataSource = fproveedores.ActualizarProveedores();
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            using (buscarProveedores ventanaBuscar = new buscarProveedores())
                ventanaBuscar.ShowDialog();
        }

        private void btnIngresarProv_Click(object sender, EventArgs e)
        {
            using (ingresarProveedores ventanaProv = new ingresarProveedores())
                ventanaProv.ShowDialog();
        }

        private void btnNuevoTipo_Click(object sender, EventArgs e)
        {
            using (ingresarTipoProv ventanaTipos = new ingresarTipoProv())
                ventanaTipos.ShowDialog();
        }

        private void btnActualizarProv_Click(object sender, EventArgs e)
        {
            tablaProveedores.DataSource = fproveedores.ActualizarProveedores();
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            using (modificarProveedores ventanaModificar = new modificarProveedores())
                ventanaModificar.ShowDialog();
        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            using (eliminarProveedores ventanaEliminar = new eliminarProveedores())
                ventanaEliminar.ShowDialog();
        }
    }
}
