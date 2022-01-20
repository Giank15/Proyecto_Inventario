
namespace Proyecto_Inventario.Formularios.Productos
{
    partial class ingresarTipoProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresarTipoProd));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.tipoProducto = new System.Windows.Forms.TextBox();
            this.btnAceptarProd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el nuevo tipo de producto:";
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProd.Location = new System.Drawing.Point(33, 112);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(93, 27);
            this.btnCancelarProd.TabIndex = 5;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = true;
            this.btnCancelarProd.Click += new System.EventHandler(this.btnCancelarProd_Click);
            // 
            // tipoProducto
            // 
            this.tipoProducto.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoProducto.Location = new System.Drawing.Point(33, 57);
            this.tipoProducto.Name = "tipoProducto";
            this.tipoProducto.Size = new System.Drawing.Size(374, 25);
            this.tipoProducto.TabIndex = 6;
            this.tipoProducto.TextChanged += new System.EventHandler(this.tipoProducto_TextChanged);
            // 
            // btnAceptarProd
            // 
            this.btnAceptarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarProd.Location = new System.Drawing.Point(314, 112);
            this.btnAceptarProd.Name = "btnAceptarProd";
            this.btnAceptarProd.Size = new System.Drawing.Size(93, 27);
            this.btnAceptarProd.TabIndex = 7;
            this.btnAceptarProd.Text = "Aceptar";
            this.btnAceptarProd.UseVisualStyleBackColor = true;
            this.btnAceptarProd.Click += new System.EventHandler(this.btnAceptarProd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ingresarTipoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptarProd);
            this.Controls.Add(this.tipoProducto);
            this.Controls.Add(this.btnCancelarProd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 200);
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "ingresarTipoProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Tipo";
            this.Load += new System.EventHandler(this.ingresarTipoProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.TextBox tipoProducto;
        private System.Windows.Forms.Button btnAceptarProd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}