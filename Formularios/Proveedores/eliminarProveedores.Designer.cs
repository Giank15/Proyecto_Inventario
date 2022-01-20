
namespace Proyecto_Inventario.Formularios.Proveedores
{
    partial class eliminarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eliminarProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarEliminar = new System.Windows.Forms.Button();
            this.btnAceptarEliminar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.TextBox();
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
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el ID del registro que eliminara:";
            // 
            // btnCancelarEliminar
            // 
            this.btnCancelarEliminar.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEliminar.Location = new System.Drawing.Point(35, 106);
            this.btnCancelarEliminar.Name = "btnCancelarEliminar";
            this.btnCancelarEliminar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelarEliminar.TabIndex = 5;
            this.btnCancelarEliminar.Text = "Cancelar";
            this.btnCancelarEliminar.UseVisualStyleBackColor = true;
            this.btnCancelarEliminar.Click += new System.EventHandler(this.btnCancelarEliminar_Click);
            // 
            // btnAceptarEliminar
            // 
            this.btnAceptarEliminar.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEliminar.Location = new System.Drawing.Point(297, 106);
            this.btnAceptarEliminar.Name = "btnAceptarEliminar";
            this.btnAceptarEliminar.Size = new System.Drawing.Size(101, 30);
            this.btnAceptarEliminar.TabIndex = 6;
            this.btnAceptarEliminar.Text = "Aceptar";
            this.btnAceptarEliminar.UseVisualStyleBackColor = true;
            this.btnAceptarEliminar.Click += new System.EventHandler(this.btnAceptarEliminar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Font = new System.Drawing.Font("Lato Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(35, 56);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(363, 25);
            this.eliminar.TabIndex = 7;
            this.eliminar.TextChanged += new System.EventHandler(this.eliminar_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // eliminarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.ControlBox = false;
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.btnAceptarEliminar);
            this.Controls.Add(this.btnCancelarEliminar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 200);
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "eliminarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.eliminarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarEliminar;
        private System.Windows.Forms.Button btnAceptarEliminar;
        private System.Windows.Forms.TextBox eliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}