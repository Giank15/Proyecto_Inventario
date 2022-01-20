
namespace Proyecto_Inventario.Formularios.Productos
{
    partial class modificarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAceptarProd = new System.Windows.Forms.Button();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.idprod = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.proveedor = new System.Windows.Forms.ComboBox();
            this.departamento = new System.Windows.Forms.ComboBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar el ID del registro a modificar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Departamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tipo:";
            // 
            // btnAceptarProd
            // 
            this.btnAceptarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarProd.Location = new System.Drawing.Point(379, 399);
            this.btnAceptarProd.Name = "btnAceptarProd";
            this.btnAceptarProd.Size = new System.Drawing.Size(112, 34);
            this.btnAceptarProd.TabIndex = 31;
            this.btnAceptarProd.Text = "Aceptar";
            this.btnAceptarProd.UseVisualStyleBackColor = true;
            this.btnAceptarProd.Click += new System.EventHandler(this.btnAceptarProd_Click);
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProd.Location = new System.Drawing.Point(41, 399);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(112, 34);
            this.btnCancelarProd.TabIndex = 32;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = true;
            this.btnCancelarProd.Click += new System.EventHandler(this.btnCancelarProd_Click);
            // 
            // idprod
            // 
            this.idprod.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idprod.Location = new System.Drawing.Point(71, 72);
            this.idprod.Name = "idprod";
            this.idprod.Size = new System.Drawing.Size(82, 25);
            this.idprod.TabIndex = 33;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(41, 154);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(191, 25);
            this.nombre.TabIndex = 34;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(358, 72);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(82, 25);
            this.precio.TabIndex = 35;
            this.precio.TextChanged += new System.EventHandler(this.precio_TextChanged);
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(41, 245);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(191, 25);
            this.descripcion.TabIndex = 36;
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(300, 154);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(191, 25);
            this.cantidad.TabIndex = 37;
            // 
            // proveedor
            // 
            this.proveedor.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor.FormattingEnabled = true;
            this.proveedor.Location = new System.Drawing.Point(300, 245);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(191, 26);
            this.proveedor.TabIndex = 38;
            // 
            // departamento
            // 
            this.departamento.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento.FormattingEnabled = true;
            this.departamento.Location = new System.Drawing.Point(41, 344);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(191, 26);
            this.departamento.TabIndex = 39;
            // 
            // tipo
            // 
            this.tipo.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(300, 344);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(191, 26);
            this.tipo.TabIndex = 40;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(187, 72);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(73, 25);
            this.btnBuscarProd.TabIndex = 41;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // modificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.proveedor);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.idprod);
            this.Controls.Add(this.btnCancelarProd);
            this.Controls.Add(this.btnAceptarProd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 500);
            this.MinimumSize = new System.Drawing.Size(550, 500);
            this.Name = "modificarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarProductos";
            this.Load += new System.EventHandler(this.modificarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAceptarProd;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.TextBox idprod;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.ComboBox proveedor;
        private System.Windows.Forms.ComboBox departamento;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}