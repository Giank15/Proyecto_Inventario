
namespace Proyecto_Inventario.Formularios
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.Apagar = new System.Windows.Forms.PictureBox();
            this.saludo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.PictureBox();
            this.btnProveedores = new System.Windows.Forms.PictureBox();
            this.btnDepartamentos = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.PictureBox();
            this.btnFacturas = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Apagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "-SISTEMAS DE INVENTARIO-";
            // 
            // Apagar
            // 
            this.Apagar.Image = global::Proyecto_Inventario.Properties.Resources.Apagar_Sistema;
            this.Apagar.Location = new System.Drawing.Point(725, 48);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(50, 42);
            this.Apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Apagar.TabIndex = 1;
            this.Apagar.TabStop = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.Location = new System.Drawing.Point(40, 90);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(110, 23);
            this.saludo.TabIndex = 2;
            this.saludo.Text = "Bienvenido ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(721, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apagar";
            // 
            // btnProductos
            // 
            this.btnProductos.Image = global::Proyecto_Inventario.Properties.Resources.Productos;
            this.btnProductos.Location = new System.Drawing.Point(213, 127);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(140, 113);
            this.btnProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProductos.TabIndex = 4;
            this.btnProductos.TabStop = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Image = global::Proyecto_Inventario.Properties.Resources.Proveedores;
            this.btnProveedores.Location = new System.Drawing.Point(445, 127);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(140, 113);
            this.btnProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProveedores.TabIndex = 5;
            this.btnProveedores.TabStop = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.Image = global::Proyecto_Inventario.Properties.Resources.Departamento;
            this.btnDepartamentos.Location = new System.Drawing.Point(121, 285);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(140, 113);
            this.btnDepartamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDepartamentos.TabIndex = 6;
            this.btnDepartamentos.TabStop = false;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Image = global::Proyecto_Inventario.Properties.Resources.Inventario;
            this.btnInventario.Location = new System.Drawing.Point(329, 285);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(140, 113);
            this.btnInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInventario.TabIndex = 7;
            this.btnInventario.TabStop = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Image = global::Proyecto_Inventario.Properties.Resources.Facturas;
            this.btnFacturas.Location = new System.Drawing.Point(535, 285);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(140, 113);
            this.btnFacturas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFacturas.TabIndex = 8;
            this.btnFacturas.TabStop = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proveedores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inventario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departamentos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Facturas";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnDepartamentos);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saludo);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Apagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Apagar;
        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnProductos;
        private System.Windows.Forms.PictureBox btnProveedores;
        private System.Windows.Forms.PictureBox btnDepartamentos;
        private System.Windows.Forms.PictureBox btnInventario;
        private System.Windows.Forms.PictureBox btnFacturas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}