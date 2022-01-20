
namespace Proyecto_Inventario.Formularios.Facturas
{
    partial class ingresarMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresarMovimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarFact = new System.Windows.Forms.Button();
            this.nfactura = new System.Windows.Forms.ComboBox();
            this.idmov = new System.Windows.Forms.TextBox();
            this.producto = new System.Windows.Forms.ComboBox();
            this.btnAceptarFact = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Complete los siguientes datos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Producto:";
            // 
            // btnCancelarFact
            // 
            this.btnCancelarFact.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFact.Location = new System.Drawing.Point(41, 204);
            this.btnCancelarFact.Name = "btnCancelarFact";
            this.btnCancelarFact.Size = new System.Drawing.Size(112, 34);
            this.btnCancelarFact.TabIndex = 18;
            this.btnCancelarFact.Text = "Cancelar";
            this.btnCancelarFact.UseVisualStyleBackColor = true;
            this.btnCancelarFact.Click += new System.EventHandler(this.btnCancelarFact_Click);
            // 
            // nfactura
            // 
            this.nfactura.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfactura.FormattingEnabled = true;
            this.nfactura.Location = new System.Drawing.Point(41, 154);
            this.nfactura.Name = "nfactura";
            this.nfactura.Size = new System.Drawing.Size(191, 26);
            this.nfactura.TabIndex = 19;
            this.nfactura.Text = "-Seleccione-";
            this.nfactura.SelectedIndexChanged += new System.EventHandler(this.nfactura_SelectedIndexChanged);
            // 
            // idmov
            // 
            this.idmov.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idmov.Location = new System.Drawing.Point(71, 72);
            this.idmov.Name = "idmov";
            this.idmov.Size = new System.Drawing.Size(100, 25);
            this.idmov.TabIndex = 20;
            // 
            // producto
            // 
            this.producto.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto.FormattingEnabled = true;
            this.producto.Location = new System.Drawing.Point(300, 154);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(191, 26);
            this.producto.TabIndex = 21;
            this.producto.Text = "-Seleccione-";
            this.producto.SelectedIndexChanged += new System.EventHandler(this.producto_SelectedIndexChanged);
            // 
            // btnAceptarFact
            // 
            this.btnAceptarFact.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFact.Location = new System.Drawing.Point(379, 204);
            this.btnAceptarFact.Name = "btnAceptarFact";
            this.btnAceptarFact.Size = new System.Drawing.Size(112, 34);
            this.btnAceptarFact.TabIndex = 22;
            this.btnAceptarFact.Text = "Aceptar";
            this.btnAceptarFact.UseVisualStyleBackColor = true;
            this.btnAceptarFact.Click += new System.EventHandler(this.btnAceptarFact_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ingresarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptarFact);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.idmov);
            this.Controls.Add(this.nfactura);
            this.Controls.Add(this.btnCancelarFact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 300);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "ingresarMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento";
            this.Load += new System.EventHandler(this.ingresarMovimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarFact;
        private System.Windows.Forms.ComboBox nfactura;
        private System.Windows.Forms.TextBox idmov;
        private System.Windows.Forms.ComboBox producto;
        private System.Windows.Forms.Button btnAceptarFact;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}