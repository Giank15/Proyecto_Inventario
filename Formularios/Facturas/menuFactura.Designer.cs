
namespace Proyecto_Inventario.Formularios.Facturas
{
    partial class menuFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuFactura));
            this.btnAtrasFact = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaFacturas = new System.Windows.Forms.DataGridView();
            this.btnBuscarFact = new System.Windows.Forms.Button();
            this.btnModificarFact = new System.Windows.Forms.Button();
            this.btnActualizarFact = new System.Windows.Forms.Button();
            this.btnIngresarFact = new System.Windows.Forms.Button();
            this.btnEliminarFact = new System.Windows.Forms.Button();
            this.btnIngresarMov = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtrasFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtrasFact
            // 
            this.btnAtrasFact.Image = global::Proyecto_Inventario.Properties.Resources.Atras;
            this.btnAtrasFact.Location = new System.Drawing.Point(711, 40);
            this.btnAtrasFact.Name = "btnAtrasFact";
            this.btnAtrasFact.Size = new System.Drawing.Size(55, 45);
            this.btnAtrasFact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtrasFact.TabIndex = 1;
            this.btnAtrasFact.TabStop = false;
            this.btnAtrasFact.Click += new System.EventHandler(this.btnAtrasFact_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Inventario.Properties.Resources.Facturas;
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
            this.label1.Location = new System.Drawing.Point(118, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "-FACTURAS-";
            // 
            // tablaFacturas
            // 
            this.tablaFacturas.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFacturas.Location = new System.Drawing.Point(35, 123);
            this.tablaFacturas.Name = "tablaFacturas";
            this.tablaFacturas.Size = new System.Drawing.Size(731, 229);
            this.tablaFacturas.TabIndex = 4;
            // 
            // btnBuscarFact
            // 
            this.btnBuscarFact.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFact.Location = new System.Drawing.Point(35, 381);
            this.btnBuscarFact.Name = "btnBuscarFact";
            this.btnBuscarFact.Size = new System.Drawing.Size(108, 34);
            this.btnBuscarFact.TabIndex = 5;
            this.btnBuscarFact.Text = "Buscar";
            this.btnBuscarFact.UseVisualStyleBackColor = true;
            this.btnBuscarFact.Click += new System.EventHandler(this.btnBuscarFact_Click);
            // 
            // btnModificarFact
            // 
            this.btnModificarFact.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFact.Location = new System.Drawing.Point(501, 381);
            this.btnModificarFact.Name = "btnModificarFact";
            this.btnModificarFact.Size = new System.Drawing.Size(108, 34);
            this.btnModificarFact.TabIndex = 6;
            this.btnModificarFact.Text = "Modificar";
            this.btnModificarFact.UseVisualStyleBackColor = true;
            this.btnModificarFact.Click += new System.EventHandler(this.btnModificarFact_Click);
            // 
            // btnActualizarFact
            // 
            this.btnActualizarFact.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarFact.Location = new System.Drawing.Point(559, 51);
            this.btnActualizarFact.Name = "btnActualizarFact";
            this.btnActualizarFact.Size = new System.Drawing.Size(108, 34);
            this.btnActualizarFact.TabIndex = 7;
            this.btnActualizarFact.Text = "Actualizar";
            this.btnActualizarFact.UseVisualStyleBackColor = true;
            this.btnActualizarFact.Click += new System.EventHandler(this.btnActualizarFact_Click);
            // 
            // btnIngresarFact
            // 
            this.btnIngresarFact.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarFact.Location = new System.Drawing.Point(193, 381);
            this.btnIngresarFact.Name = "btnIngresarFact";
            this.btnIngresarFact.Size = new System.Drawing.Size(108, 34);
            this.btnIngresarFact.TabIndex = 8;
            this.btnIngresarFact.Text = "Factura";
            this.btnIngresarFact.UseVisualStyleBackColor = true;
            this.btnIngresarFact.Click += new System.EventHandler(this.btnIngresarFact_Click);
            // 
            // btnEliminarFact
            // 
            this.btnEliminarFact.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFact.Location = new System.Drawing.Point(658, 381);
            this.btnEliminarFact.Name = "btnEliminarFact";
            this.btnEliminarFact.Size = new System.Drawing.Size(108, 34);
            this.btnEliminarFact.TabIndex = 9;
            this.btnEliminarFact.Text = "Eliminar";
            this.btnEliminarFact.UseVisualStyleBackColor = true;
            this.btnEliminarFact.Click += new System.EventHandler(this.btnEliminarFact_Click);
            // 
            // btnIngresarMov
            // 
            this.btnIngresarMov.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarMov.Location = new System.Drawing.Point(348, 381);
            this.btnIngresarMov.Name = "btnIngresarMov";
            this.btnIngresarMov.Size = new System.Drawing.Size(108, 34);
            this.btnIngresarMov.TabIndex = 10;
            this.btnIngresarMov.Text = "Movimiento";
            this.btnIngresarMov.UseVisualStyleBackColor = true;
            this.btnIngresarMov.Click += new System.EventHandler(this.btnIngresarMov_Click);
            // 
            // menuFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnIngresarMov);
            this.Controls.Add(this.btnEliminarFact);
            this.Controls.Add(this.btnIngresarFact);
            this.Controls.Add(this.btnActualizarFact);
            this.Controls.Add(this.btnModificarFact);
            this.Controls.Add(this.btnBuscarFact);
            this.Controls.Add(this.tablaFacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAtrasFact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "menuFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.menuFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtrasFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtrasFact;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaFacturas;
        private System.Windows.Forms.Button btnBuscarFact;
        private System.Windows.Forms.Button btnModificarFact;
        private System.Windows.Forms.Button btnActualizarFact;
        private System.Windows.Forms.Button btnIngresarFact;
        private System.Windows.Forms.Button btnEliminarFact;
        private System.Windows.Forms.Button btnIngresarMov;
    }
}