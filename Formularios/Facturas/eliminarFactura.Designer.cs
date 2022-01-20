
namespace Proyecto_Inventario.Formularios.Facturas
{
    partial class eliminarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eliminarFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarFact = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.TextBox();
            this.btnAceptarFact = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese el ID del registro que eliminara:";
            // 
            // btnCancelarFact
            // 
            this.btnCancelarFact.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFact.Location = new System.Drawing.Point(35, 106);
            this.btnCancelarFact.Name = "btnCancelarFact";
            this.btnCancelarFact.Size = new System.Drawing.Size(101, 30);
            this.btnCancelarFact.TabIndex = 7;
            this.btnCancelarFact.Text = "Cancelar";
            this.btnCancelarFact.UseVisualStyleBackColor = true;
            this.btnCancelarFact.Click += new System.EventHandler(this.btnCancelarFact_Click);
            // 
            // eliminar
            // 
            this.eliminar.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(35, 56);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(363, 25);
            this.eliminar.TabIndex = 8;
            this.eliminar.TextChanged += new System.EventHandler(this.eliminar_TextChanged);
            // 
            // btnAceptarFact
            // 
            this.btnAceptarFact.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFact.Location = new System.Drawing.Point(297, 106);
            this.btnAceptarFact.Name = "btnAceptarFact";
            this.btnAceptarFact.Size = new System.Drawing.Size(101, 30);
            this.btnAceptarFact.TabIndex = 9;
            this.btnAceptarFact.Text = "Aceptar";
            this.btnAceptarFact.UseVisualStyleBackColor = true;
            this.btnAceptarFact.Click += new System.EventHandler(this.btnAceptarFact_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // eliminarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptarFact);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.btnCancelarFact);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 200);
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "eliminarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Factura";
            this.Load += new System.EventHandler(this.eliminarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarFact;
        private System.Windows.Forms.TextBox eliminar;
        private System.Windows.Forms.Button btnAceptarFact;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}