
namespace Proyecto_Inventario.Formularios.Facturas
{
    partial class buscarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarFactura));
            this.tablaBuscar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarFact = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.TextBox();
            this.btnCancelarFact = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaBuscar
            // 
            this.tablaBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBuscar.Location = new System.Drawing.Point(12, 113);
            this.tablaBuscar.Name = "tablaBuscar";
            this.tablaBuscar.Size = new System.Drawing.Size(510, 136);
            this.tablaBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresar el nombre que desea buscar:";
            // 
            // btnAceptarFact
            // 
            this.btnAceptarFact.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFact.Location = new System.Drawing.Point(270, 62);
            this.btnAceptarFact.Name = "btnAceptarFact";
            this.btnAceptarFact.Size = new System.Drawing.Size(87, 30);
            this.btnAceptarFact.TabIndex = 7;
            this.btnAceptarFact.Text = "Aceptar";
            this.btnAceptarFact.UseVisualStyleBackColor = true;
            this.btnAceptarFact.Click += new System.EventHandler(this.btnAceptarFact_Click);
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(41, 65);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(191, 25);
            this.buscar.TabIndex = 8;
            this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            // 
            // btnCancelarFact
            // 
            this.btnCancelarFact.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFact.Location = new System.Drawing.Point(383, 62);
            this.btnCancelarFact.Name = "btnCancelarFact";
            this.btnCancelarFact.Size = new System.Drawing.Size(87, 30);
            this.btnCancelarFact.TabIndex = 9;
            this.btnCancelarFact.Text = "Cancelar";
            this.btnCancelarFact.UseVisualStyleBackColor = true;
            this.btnCancelarFact.Click += new System.EventHandler(this.btnCancelarFact_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarFact);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.btnAceptarFact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 300);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "buscarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.buscarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarFact;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Button btnCancelarFact;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}