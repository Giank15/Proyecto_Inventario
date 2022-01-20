
namespace Proyecto_Inventario.Formularios.Productos
{
    partial class menuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarProd = new System.Windows.Forms.Button();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.btnIngresarProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.atras = new System.Windows.Forms.PictureBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnNuevoTProd = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnModificarProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "-PRODUCTOS-";
            // 
            // btnActualizarProd
            // 
            this.btnActualizarProd.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProd.Location = new System.Drawing.Point(559, 51);
            this.btnActualizarProd.Name = "btnActualizarProd";
            this.btnActualizarProd.Size = new System.Drawing.Size(108, 34);
            this.btnActualizarProd.TabIndex = 4;
            this.btnActualizarProd.Text = "Actualizar";
            this.btnActualizarProd.UseVisualStyleBackColor = true;
            this.btnActualizarProd.Click += new System.EventHandler(this.btnActualizarProd_Click);
            // 
            // tablaProductos
            // 
            this.tablaProductos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(35, 123);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.Size = new System.Drawing.Size(731, 229);
            this.tablaProductos.TabIndex = 5;
            // 
            // btnIngresarProd
            // 
            this.btnIngresarProd.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarProd.Location = new System.Drawing.Point(348, 381);
            this.btnIngresarProd.Name = "btnIngresarProd";
            this.btnIngresarProd.Size = new System.Drawing.Size(108, 34);
            this.btnIngresarProd.TabIndex = 6;
            this.btnIngresarProd.Text = "Ingresar";
            this.btnIngresarProd.UseVisualStyleBackColor = true;
            this.btnIngresarProd.Click += new System.EventHandler(this.btnIngresarProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Inventario.Properties.Resources.Productos;
            this.pictureBox1.Location = new System.Drawing.Point(35, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // atras
            // 
            this.atras.Image = global::Proyecto_Inventario.Properties.Resources.Atras;
            this.atras.Location = new System.Drawing.Point(711, 40);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(56, 46);
            this.atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.atras.TabIndex = 0;
            this.atras.TabStop = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(35, 381);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(108, 34);
            this.btnBuscarProd.TabIndex = 7;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnNuevoTProd
            // 
            this.btnNuevoTProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTProd.Location = new System.Drawing.Point(193, 381);
            this.btnNuevoTProd.Name = "btnNuevoTProd";
            this.btnNuevoTProd.Size = new System.Drawing.Size(108, 34);
            this.btnNuevoTProd.TabIndex = 8;
            this.btnNuevoTProd.Text = "Nuevo Tipo";
            this.btnNuevoTProd.UseVisualStyleBackColor = true;
            this.btnNuevoTProd.Click += new System.EventHandler(this.btnNuevoTProd_Click);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.Location = new System.Drawing.Point(658, 381);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(108, 34);
            this.btnEliminarProd.TabIndex = 9;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.UseVisualStyleBackColor = true;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnModificarProd
            // 
            this.btnModificarProd.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProd.Location = new System.Drawing.Point(501, 381);
            this.btnModificarProd.Name = "btnModificarProd";
            this.btnModificarProd.Size = new System.Drawing.Size(108, 34);
            this.btnModificarProd.TabIndex = 10;
            this.btnModificarProd.Text = "Modificar";
            this.btnModificarProd.UseVisualStyleBackColor = true;
            this.btnModificarProd.Click += new System.EventHandler(this.btnModificarProd_Click);
            // 
            // menuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnModificarProd);
            this.Controls.Add(this.btnEliminarProd);
            this.Controls.Add(this.btnNuevoTProd);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.btnIngresarProd);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.btnActualizarProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.atras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "menuProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.menuProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox atras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarProd;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Button btnIngresarProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnNuevoTProd;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Button btnModificarProd;
    }
}