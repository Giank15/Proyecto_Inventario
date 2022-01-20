using Proyecto_Inventario.Formularios.Departamentos;
using Proyecto_Inventario.Formularios.Facturas;
using Proyecto_Inventario.Formularios.Inventario;
using Proyecto_Inventario.Formularios.Productos;
using Proyecto_Inventario.Formularios.Proveedores;
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
    public partial class Inicio : Form
    {
        string usuario_sistema;
        
        public Inicio(string usuario)
        {
            InitializeComponent();
            usuario_sistema = usuario;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            saludo.Text += usuario_sistema;
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            using (menuProductos ventanaProductos = new menuProductos())
                ventanaProductos.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            using (menuProveedores ventanaProveedores = new menuProveedores())
                ventanaProveedores.ShowDialog();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            using (menuDepartamentos ventanaDepartamentos = new menuDepartamentos())
                ventanaDepartamentos.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            using (menuFactura ventanaFacturas = new menuFactura())
                ventanaFacturas.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            using (menuInventario ventanaInventario = new menuInventario())
                ventanaInventario.ShowDialog();
        }
    }
    
}
