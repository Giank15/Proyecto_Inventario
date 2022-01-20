using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Inventario.Formularios.Productos
{
    public partial class menuProductos : Form
    {
        Clases.funcionesProductos fproductos = new Clases.funcionesProductos();

        public menuProductos()
        {
            InitializeComponent();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarProd_Click(object sender, EventArgs e)
        {
            tablaProductos.DataSource = fproductos.ActualizarProductos();
        }

        private void menuProductos_Load(object sender, EventArgs e)
        {
            tablaProductos.DataSource = fproductos.ActualizarProductos();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            using (buscarProductos ventanaBuscar = new buscarProductos())
                ventanaBuscar.ShowDialog();
        }

        private void btnNuevoTProd_Click(object sender, EventArgs e)
        {
            using (ingresarTipoProd ventanaTipos = new ingresarTipoProd())
                ventanaTipos.ShowDialog();
        }

        private void btnIngresarProd_Click(object sender, EventArgs e)
        {
            using (ingresarProductos ventanaProv = new ingresarProductos())
                ventanaProv.ShowDialog();
        }

        private void btnModificarProd_Click(object sender, EventArgs e)
        {
            using (modificarProductos ventanaModificar = new modificarProductos())
                ventanaModificar.ShowDialog();
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            using (eliminarProductos ventanaEliminar = new eliminarProductos())
                ventanaEliminar.ShowDialog();
        }
    }
}
