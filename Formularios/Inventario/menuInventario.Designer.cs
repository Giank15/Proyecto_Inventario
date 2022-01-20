
namespace Proyecto_Inventario.Formularios.Inventario
{
    partial class menuInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuInventario));
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablainventario = new System.Windows.Forms.DataGridView();
            this.btnActualizarInv = new System.Windows.Forms.Button();
            this.btnBuscarInv = new System.Windows.Forms.Button();
            this.buscarinv = new System.Windows.Forms.TextBox();
            this.btnImprimirInv = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablainventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::Proyecto_Inventario.Properties.Resources.Atras;
            this.btnAtras.Location = new System.Drawing.Point(711, 40);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(55, 45);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtras.TabIndex = 1;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Inventario.Properties.Resources.Proveedores;
            this.pictureBox2.Location = new System.Drawing.Point(35, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "-INVENTARIO-";
            // 
            // tablainventario
            // 
            this.tablainventario.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablainventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablainventario.Location = new System.Drawing.Point(35, 123);
            this.tablainventario.Name = "tablainventario";
            this.tablainventario.Size = new System.Drawing.Size(731, 229);
            this.tablainventario.TabIndex = 4;
            // 
            // btnActualizarInv
            // 
            this.btnActualizarInv.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarInv.Location = new System.Drawing.Point(559, 51);
            this.btnActualizarInv.Name = "btnActualizarInv";
            this.btnActualizarInv.Size = new System.Drawing.Size(108, 34);
            this.btnActualizarInv.TabIndex = 5;
            this.btnActualizarInv.Text = "Actualizar";
            this.btnActualizarInv.UseVisualStyleBackColor = true;
            this.btnActualizarInv.Click += new System.EventHandler(this.btnActualizarInv_Click);
            // 
            // btnBuscarInv
            // 
            this.btnBuscarInv.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInv.Location = new System.Drawing.Point(279, 378);
            this.btnBuscarInv.Name = "btnBuscarInv";
            this.btnBuscarInv.Size = new System.Drawing.Size(108, 34);
            this.btnBuscarInv.TabIndex = 6;
            this.btnBuscarInv.Text = "Buscar";
            this.btnBuscarInv.UseVisualStyleBackColor = true;
            this.btnBuscarInv.Click += new System.EventHandler(this.btnBuscarInv_Click);
            // 
            // buscarinv
            // 
            this.buscarinv.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarinv.Location = new System.Drawing.Point(35, 384);
            this.buscarinv.Name = "buscarinv";
            this.buscarinv.Size = new System.Drawing.Size(211, 25);
            this.buscarinv.TabIndex = 7;
            this.buscarinv.TextChanged += new System.EventHandler(this.buscarinv_TextChanged);
            // 
            // btnImprimirInv
            // 
            this.btnImprimirInv.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirInv.Location = new System.Drawing.Point(425, 51);
            this.btnImprimirInv.Name = "btnImprimirInv";
            this.btnImprimirInv.Size = new System.Drawing.Size(108, 34);
            this.btnImprimirInv.TabIndex = 8;
            this.btnImprimirInv.Text = "Imprimir";
            this.btnImprimirInv.UseVisualStyleBackColor = true;
            this.btnImprimirInv.Click += new System.EventHandler(this.btnImprimirInv_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimirInv);
            this.Controls.Add(this.buscarinv);
            this.Controls.Add(this.btnBuscarInv);
            this.Controls.Add(this.btnActualizarInv);
            this.Controls.Add(this.tablainventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "menuInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.menuInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablainventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablainventario;
        private System.Windows.Forms.Button btnActualizarInv;
        private System.Windows.Forms.Button btnBuscarInv;
        private System.Windows.Forms.TextBox buscarinv;
        private System.Windows.Forms.Button btnImprimirInv;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}