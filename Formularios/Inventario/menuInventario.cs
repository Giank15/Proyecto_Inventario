using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Inventario.Formularios.Inventario
{
    public partial class menuInventario : Form
    {
        Clases.funcionesInventario finventario = new Clases.funcionesInventario();
        
        private void controlAceptar()
        {
            if (buscarinv.Text.Trim() != string.Empty)
            {
                btnBuscarInv.Enabled = true;
                errorProvider1.SetError(buscarinv, "");
            }
            else
            {
                if (buscarinv.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(buscarinv, "Campo necesario");
                }
                btnBuscarInv.Enabled = false;
            }
        }

        public menuInventario()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuInventario_Load(object sender, EventArgs e)
        {
            tablainventario.DataSource = finventario.ActualizarInventario();
            if (buscarinv.Text.Trim() == string.Empty)
            {
                btnBuscarInv.Enabled = false;
                errorProvider1.SetError(buscarinv, "Campo obligatorio");
            }
        }

        private void btnActualizarInv_Click(object sender, EventArgs e)
        {
            tablainventario.DataSource = finventario.ActualizarInventario();
        }

        private void buscarinv_TextChanged(object sender, EventArgs e)
        {
            controlAceptar();
        }

        private void btnBuscarInv_Click(object sender, EventArgs e)
        {
            tablainventario.DataSource = finventario.BuscarInventario(buscarinv.Text);
            MessageBox.Show("Registros encontrados...");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbmp = new Bitmap(this.tablainventario.Width, this.tablainventario.Height);
            tablainventario.DrawToBitmap(objbmp, new Rectangle(0, 0, this.tablainventario.Width, this.tablainventario.Height));

            e.Graphics.DrawImage(objbmp, 200, 200);
            e.Graphics.DrawString(label1.Text, new Font("Lato", 24, FontStyle.Bold), Brushes.Black, new Point(200, 120));
        }

        private void btnImprimirInv_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
