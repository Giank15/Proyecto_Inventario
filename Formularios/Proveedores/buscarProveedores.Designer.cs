
namespace Proyecto_Inventario.Formularios.Proveedores
{
    partial class buscarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarProveedores));
            this.btnAceptarBuscar = new System.Windows.Forms.Button();
            this.btnCancelarBuscar = new System.Windows.Forms.Button();
            this.buscarProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaBuscar = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarBuscar
            // 
            this.btnAceptarBuscar.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarBuscar.Location = new System.Drawing.Point(270, 62);
            this.btnAceptarBuscar.Name = "btnAceptarBuscar";
            this.btnAceptarBuscar.Size = new System.Drawing.Size(87, 30);
            this.btnAceptarBuscar.TabIndex = 0;
            this.btnAceptarBuscar.Text = "Aceptar";
            this.btnAceptarBuscar.UseVisualStyleBackColor = true;
            this.btnAceptarBuscar.Click += new System.EventHandler(this.btnAceptarBuscar_Click);
            // 
            // btnCancelarBuscar
            // 
            this.btnCancelarBuscar.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarBuscar.Location = new System.Drawing.Point(383, 62);
            this.btnCancelarBuscar.Name = "btnCancelarBuscar";
            this.btnCancelarBuscar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelarBuscar.TabIndex = 1;
            this.btnCancelarBuscar.Text = "Cancelar";
            this.btnCancelarBuscar.UseVisualStyleBackColor = true;
            this.btnCancelarBuscar.Click += new System.EventHandler(this.btnCancelarBuscar_Click);
            // 
            // buscarProv
            // 
            this.buscarProv.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarProv.Location = new System.Drawing.Point(41, 65);
            this.buscarProv.Name = "buscarProv";
            this.buscarProv.Size = new System.Drawing.Size(191, 25);
            this.buscarProv.TabIndex = 3;
            this.buscarProv.TextChanged += new System.EventHandler(this.buscarProv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar el nombre que desea buscar:";
            // 
            // tablaBuscar
            // 
            this.tablaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBuscar.Location = new System.Drawing.Point(12, 113);
            this.tablaBuscar.Name = "tablaBuscar";
            this.tablaBuscar.Size = new System.Drawing.Size(510, 136);
            this.tablaBuscar.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buscarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.ControlBox = false;
            this.Controls.Add(this.tablaBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarProv);
            this.Controls.Add(this.btnCancelarBuscar);
            this.Controls.Add(this.btnAceptarBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 300);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "buscarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.buscarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarBuscar;
        private System.Windows.Forms.Button btnCancelarBuscar;
        private System.Windows.Forms.TextBox buscarProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}