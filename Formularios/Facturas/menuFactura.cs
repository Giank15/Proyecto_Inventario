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
    public partial class menuFactura : Form
    {
        Clases.funcionesFactura ffacturas = new Clases.funcionesFactura();

        public menuFactura()
        {
            InitializeComponent();
        }

        private void btnAtrasFact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuFactura_Load(object sender, EventArgs e)
        {
            tablaFacturas.DataSource = ffacturas.ActualizarFactura();
        }

        private void btnActualizarFact_Click(object sender, EventArgs e)
        {
            tablaFacturas.DataSource = ffacturas.ActualizarFactura();
        }

        private void btnBuscarFact_Click(object sender, EventArgs e)
        {
            using (buscarFactura ventanaBuscar = new buscarFactura())
                ventanaBuscar.ShowDialog();
        }

        private void btnIngresarFact_Click(object sender, EventArgs e)
        {
            using (ingresarFactura ventanaIngresar = new ingresarFactura())
                ventanaIngresar.ShowDialog();
        }

        private void btnModificarFact_Click(object sender, EventArgs e)
        {
            using (modificarFactura ventanaModificar = new modificarFactura())
                ventanaModificar.ShowDialog();
        }

        private void btnEliminarFact_Click(object sender, EventArgs e)
        {
            using (eliminarFactura ventanaEliminar = new eliminarFactura())
                ventanaEliminar.ShowDialog();
        }

        private void btnIngresarMov_Click(object sender, EventArgs e)
        {
            using (ingresarMovimiento ventanaMovimiento = new ingresarMovimiento())
                ventanaMovimiento.ShowDialog();
        }
    }
}
