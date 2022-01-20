
namespace Proyecto_Inventario.Formularios.Departamentos
{
    partial class buscarDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarDepartamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarBuscar = new System.Windows.Forms.Button();
            this.btnCancelarBuscar = new System.Windows.Forms.Button();
            this.buscarDepart = new System.Windows.Forms.TextBox();
            this.tablaBuscar = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // btnAceptarBuscar
            // 
            this.btnAceptarBuscar.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarBuscar.Location = new System.Drawing.Point(270, 62);
            this.btnAceptarBuscar.Name = "btnAceptarBuscar";
            this.btnAceptarBuscar.Size = new System.Drawing.Size(87, 30);
            this.btnAceptarBuscar.TabIndex = 6;
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
            this.btnCancelarBuscar.TabIndex = 7;
            this.btnCancelarBuscar.Text = "Cancelar";
            this.btnCancelarBuscar.UseVisualStyleBackColor = true;
            this.btnCancelarBuscar.Click += new System.EventHandler(this.btnCancelarBuscar_Click);
            // 
            // buscarDepart
            // 
            this.buscarDepart.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDepart.Location = new System.Drawing.Point(41, 65);
            this.buscarDepart.Name = "buscarDepart";
            this.buscarDepart.Size = new System.Drawing.Size(191, 25);
            this.buscarDepart.TabIndex = 8;
            this.buscarDepart.TextChanged += new System.EventHandler(this.buscarDepart_TextChanged);
            // 
            // tablaBuscar
            // 
            this.tablaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBuscar.Location = new System.Drawing.Point(12, 113);
            this.tablaBuscar.Name = "tablaBuscar";
            this.tablaBuscar.Size = new System.Drawing.Size(510, 136);
            this.tablaBuscar.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buscarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.ControlBox = false;
            this.Controls.Add(this.tablaBuscar);
            this.Controls.Add(this.buscarDepart);
            this.Controls.Add(this.btnCancelarBuscar);
            this.Controls.Add(this.btnAceptarBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 300);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "buscarDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.buscarDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarBuscar;
        private System.Windows.Forms.Button btnCancelarBuscar;
        private System.Windows.Forms.TextBox buscarDepart;
        private System.Windows.Forms.DataGridView tablaBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}