
namespace Proyecto_Inventario.Formularios.Departamentos
{
    partial class modificarDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarDepartamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iddepart = new System.Windows.Forms.TextBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.nempleado = new System.Windows.Forms.TextBox();
            this.administrador = new System.Windows.Forms.TextBox();
            this.jerarquia = new System.Windows.Forms.ComboBox();
            this.btnBuscarMod = new System.Windows.Forms.Button();
            this.btnCancelarDepart = new System.Windows.Forms.Button();
            this.btnAceptarDepart = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar el ID del registro a modificar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Administrador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero de empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jerarquia:";
            // 
            // iddepart
            // 
            this.iddepart.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iddepart.Location = new System.Drawing.Point(41, 65);
            this.iddepart.Name = "iddepart";
            this.iddepart.Size = new System.Drawing.Size(191, 25);
            this.iddepart.TabIndex = 14;
            // 
            // departamento
            // 
            this.departamento.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamento.Location = new System.Drawing.Point(41, 154);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(191, 25);
            this.departamento.TabIndex = 15;
            this.departamento.TextChanged += new System.EventHandler(this.departamento_TextChanged);
            // 
            // nempleado
            // 
            this.nempleado.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nempleado.Location = new System.Drawing.Point(41, 245);
            this.nempleado.Name = "nempleado";
            this.nempleado.Size = new System.Drawing.Size(191, 25);
            this.nempleado.TabIndex = 16;
            // 
            // administrador
            // 
            this.administrador.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrador.Location = new System.Drawing.Point(300, 154);
            this.administrador.Name = "administrador";
            this.administrador.Size = new System.Drawing.Size(191, 25);
            this.administrador.TabIndex = 17;
            this.administrador.TextChanged += new System.EventHandler(this.administrador_TextChanged);
            // 
            // jerarquia
            // 
            this.jerarquia.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jerarquia.FormattingEnabled = true;
            this.jerarquia.Location = new System.Drawing.Point(300, 245);
            this.jerarquia.Name = "jerarquia";
            this.jerarquia.Size = new System.Drawing.Size(191, 26);
            this.jerarquia.TabIndex = 18;
            this.jerarquia.Text = "--Seleccione--";
            // 
            // btnBuscarMod
            // 
            this.btnBuscarMod.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMod.Location = new System.Drawing.Point(263, 65);
            this.btnBuscarMod.Name = "btnBuscarMod";
            this.btnBuscarMod.Size = new System.Drawing.Size(104, 25);
            this.btnBuscarMod.TabIndex = 19;
            this.btnBuscarMod.Text = "Buscar";
            this.btnBuscarMod.UseVisualStyleBackColor = true;
            this.btnBuscarMod.Click += new System.EventHandler(this.btnBuscarMod_Click);
            // 
            // btnCancelarDepart
            // 
            this.btnCancelarDepart.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDepart.Location = new System.Drawing.Point(41, 300);
            this.btnCancelarDepart.Name = "btnCancelarDepart";
            this.btnCancelarDepart.Size = new System.Drawing.Size(112, 34);
            this.btnCancelarDepart.TabIndex = 20;
            this.btnCancelarDepart.Text = "Cancelar";
            this.btnCancelarDepart.UseVisualStyleBackColor = true;
            this.btnCancelarDepart.Click += new System.EventHandler(this.btnCancelarDepart_Click);
            // 
            // btnAceptarDepart
            // 
            this.btnAceptarDepart.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarDepart.Location = new System.Drawing.Point(379, 300);
            this.btnAceptarDepart.Name = "btnAceptarDepart";
            this.btnAceptarDepart.Size = new System.Drawing.Size(112, 34);
            this.btnAceptarDepart.TabIndex = 21;
            this.btnAceptarDepart.Text = "Aceptar";
            this.btnAceptarDepart.UseVisualStyleBackColor = true;
            this.btnAceptarDepart.Click += new System.EventHandler(this.btnAceptarDepart_Click);
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
            // modificarDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptarDepart);
            this.Controls.Add(this.btnCancelarDepart);
            this.Controls.Add(this.btnBuscarMod);
            this.Controls.Add(this.jerarquia);
            this.Controls.Add(this.administrador);
            this.Controls.Add(this.nempleado);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.iddepart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "modificarDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.modificarDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iddepart;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.TextBox nempleado;
        private System.Windows.Forms.TextBox administrador;
        private System.Windows.Forms.ComboBox jerarquia;
        private System.Windows.Forms.Button btnBuscarMod;
        private System.Windows.Forms.Button btnCancelarDepart;
        private System.Windows.Forms.Button btnAceptarDepart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}