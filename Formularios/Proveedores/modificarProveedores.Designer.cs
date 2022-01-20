
namespace Proyecto_Inventario.Formularios.Proveedores
{
    partial class modificarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarModProv = new System.Windows.Forms.Button();
            this.btnAceptarProv = new System.Windows.Forms.Button();
            this.buscarMod = new System.Windows.Forms.TextBox();
            this.btnCancelarPov = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empresaMod = new System.Windows.Forms.TextBox();
            this.telefonoMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoprovMod = new System.Windows.Forms.ComboBox();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar el ID del registro a modificar:";
            // 
            // btnBuscarModProv
            // 
            this.btnBuscarModProv.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarModProv.Location = new System.Drawing.Point(263, 65);
            this.btnBuscarModProv.Name = "btnBuscarModProv";
            this.btnBuscarModProv.Size = new System.Drawing.Size(104, 25);
            this.btnBuscarModProv.TabIndex = 1;
            this.btnBuscarModProv.Text = "Buscar";
            this.btnBuscarModProv.UseVisualStyleBackColor = true;
            this.btnBuscarModProv.Click += new System.EventHandler(this.btnBuscarModProv_Click);
            // 
            // btnAceptarProv
            // 
            this.btnAceptarProv.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarProv.Location = new System.Drawing.Point(379, 300);
            this.btnAceptarProv.Name = "btnAceptarProv";
            this.btnAceptarProv.Size = new System.Drawing.Size(112, 34);
            this.btnAceptarProv.TabIndex = 2;
            this.btnAceptarProv.Text = "Aceptar";
            this.btnAceptarProv.UseVisualStyleBackColor = true;
            this.btnAceptarProv.Click += new System.EventHandler(this.btnAceptarProv_Click);
            // 
            // buscarMod
            // 
            this.buscarMod.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarMod.Location = new System.Drawing.Point(41, 65);
            this.buscarMod.Name = "buscarMod";
            this.buscarMod.Size = new System.Drawing.Size(191, 25);
            this.buscarMod.TabIndex = 3;
            // 
            // btnCancelarPov
            // 
            this.btnCancelarPov.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPov.Location = new System.Drawing.Point(41, 300);
            this.btnCancelarPov.Name = "btnCancelarPov";
            this.btnCancelarPov.Size = new System.Drawing.Size(112, 34);
            this.btnCancelarPov.TabIndex = 4;
            this.btnCancelarPov.Text = "Cancelar";
            this.btnCancelarPov.UseVisualStyleBackColor = true;
            this.btnCancelarPov.Click += new System.EventHandler(this.btnCancelarPov_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // nombreMod
            // 
            this.nombreMod.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMod.Location = new System.Drawing.Point(41, 154);
            this.nombreMod.Name = "nombreMod";
            this.nombreMod.Size = new System.Drawing.Size(191, 25);
            this.nombreMod.TabIndex = 6;
            this.nombreMod.TextChanged += new System.EventHandler(this.nombreMod_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Empresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefono:";
            // 
            // empresaMod
            // 
            this.empresaMod.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaMod.Location = new System.Drawing.Point(41, 245);
            this.empresaMod.Name = "empresaMod";
            this.empresaMod.Size = new System.Drawing.Size(191, 25);
            this.empresaMod.TabIndex = 10;
            this.empresaMod.TextChanged += new System.EventHandler(this.empresaMod_TextChanged);
            // 
            // telefonoMod
            // 
            this.telefonoMod.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoMod.Location = new System.Drawing.Point(300, 154);
            this.telefonoMod.Name = "telefonoMod";
            this.telefonoMod.Size = new System.Drawing.Size(191, 25);
            this.telefonoMod.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo:";
            // 
            // tipoprovMod
            // 
            this.tipoprovMod.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoprovMod.FormattingEnabled = true;
            this.tipoprovMod.Location = new System.Drawing.Point(300, 245);
            this.tipoprovMod.Name = "tipoprovMod";
            this.tipoprovMod.Size = new System.Drawing.Size(191, 26);
            this.tipoprovMod.TabIndex = 13;
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
            // modificarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.ControlBox = false;
            this.Controls.Add(this.tipoprovMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefonoMod);
            this.Controls.Add(this.empresaMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombreMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelarPov);
            this.Controls.Add(this.buscarMod);
            this.Controls.Add(this.btnAceptarProv);
            this.Controls.Add(this.btnBuscarModProv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "modificarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.modificarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarModProv;
        private System.Windows.Forms.Button btnAceptarProv;
        private System.Windows.Forms.TextBox buscarMod;
        private System.Windows.Forms.Button btnCancelarPov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empresaMod;
        private System.Windows.Forms.TextBox telefonoMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoprovMod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}