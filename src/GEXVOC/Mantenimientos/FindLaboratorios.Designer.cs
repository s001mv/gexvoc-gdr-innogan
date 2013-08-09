namespace GEXVOC.UI
{
    partial class FindLaboratorios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtTelefono);
            this.pnlBusqueda.Controls.Add(this.lblTelefono);
            this.pnlBusqueda.Controls.Add(this.txtNombre);
            this.pnlBusqueda.Controls.Add(this.lblNombre);
            this.pnlBusqueda.Controls.Add(this.txtDireccion);
            this.pnlBusqueda.Controls.Add(this.lblDireccion);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 82);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Size = new System.Drawing.Size(610, 305);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(432, 19);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(95, 20);
            this.txtTelefono.TabIndex = 17;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTelefono.Location = new System.Drawing.Point(374, 22);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 19);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(15, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(78, 50);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(449, 20);
            this.txtDireccion.TabIndex = 18;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDireccion.Location = new System.Drawing.Point(15, 53);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Dirección:";
            // 
            // FindLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 305);
            this.Name = "FindLaboratorios";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 82);
            this.Text = "Laboratorios";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
    }
}
