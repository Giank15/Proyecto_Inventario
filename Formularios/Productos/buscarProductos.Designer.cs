
namespace Proyecto_Inventario.Formularios.Productos
{
    partial class buscarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarProductos));
            this.tablaBuscarProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarProd = new System.Windows.Forms.Button();
            this.buscarprod = new System.Windows.Forms.TextBox();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscarProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaBuscarProd
            // 
            this.tablaBuscarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBuscarProd.Location = new System.Drawing.Point(12, 113);
            this.tablaBuscarProd.Name = "tablaBuscarProd";
            this.tablaBuscarProd.Size = new System.Drawing.Size(510, 136);
            this.tablaBuscarProd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresar el nombre que desea buscar:";
            // 
            // btnAceptarProd
            // 
            this.btnAceptarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarProd.Location = new System.Drawing.Point(270, 62);
            this.btnAceptarProd.Name = "btnAceptarProd";
            this.btnAceptarProd.Size = new System.Drawing.Size(87, 30);
            this.btnAceptarProd.TabIndex = 6;
            this.btnAceptarProd.Text = "Aceptar";
            this.btnAceptarProd.UseVisualStyleBackColor = true;
            this.btnAceptarProd.Click += new System.EventHandler(this.btnAceptarProd_Click);
            // 
            // buscarprod
            // 
            this.buscarprod.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarprod.Location = new System.Drawing.Point(41, 65);
            this.buscarprod.Name = "buscarprod";
            this.buscarprod.Size = new System.Drawing.Size(191, 25);
            this.buscarprod.TabIndex = 8;
            this.buscarprod.TextChanged += new System.EventHandler(this.buscarprod_TextChanged);
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProd.Location = new System.Drawing.Point(383, 62);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(87, 30);
            this.btnCancelarProd.TabIndex = 9;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = true;
            this.btnCancelarProd.Click += new System.EventHandler(this.btnCancelarProd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarProd);
            this.Controls.Add(this.buscarprod);
            this.Controls.Add(this.btnAceptarProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaBuscarProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 300);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "buscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.buscarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscarProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaBuscarProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarProd;
        private System.Windows.Forms.TextBox buscarprod;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}