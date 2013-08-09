namespace GEXVOC.UI
{
    partial class FindContacto
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.lblMovil = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtMovil);
            this.pnlBusqueda.Controls.Add(this.lblMovil);
            this.pnlBusqueda.Controls.Add(this.txtTelefono);
            this.pnlBusqueda.Controls.Add(this.lblTelefono);
            this.pnlBusqueda.Controls.Add(this.cmbTipo);
            this.pnlBusqueda.Controls.Add(this.lblTipo);
            this.pnlBusqueda.Controls.Add(this.txtEmail);
            this.pnlBusqueda.Controls.Add(this.lblEmail);
            this.pnlBusqueda.Controls.Add(this.txtDireccion);
            this.pnlBusqueda.Controls.Add(this.lblDireccion);
            this.pnlBusqueda.Controls.Add(this.txtNombre);
            this.pnlBusqueda.Controls.Add(this.lblNombre);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 164);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 201);
            this.panel1.Size = new System.Drawing.Size(610, 217);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(49, 108);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 59;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(117, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(319, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(49, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(117, 23);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(196, 21);
            this.cmbTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(49, 26);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 165;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtMovil
            // 
            this.txtMovil.Location = new System.Drawing.Point(309, 79);
            this.txtMovil.MaxLength = 9;
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(127, 20);
            this.txtMovil.TabIndex = 168;
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Location = new System.Drawing.Point(268, 82);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(35, 13);
            this.lblMovil.TabIndex = 169;
            this.lblMovil.Text = "Móvil:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(117, 79);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(126, 20);
            this.txtTelefono.TabIndex = 167;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(49, 82);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 166;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // FindContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 217);
            this.Name = "FindContacto";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 164);
            this.Text = "Contactos";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
    }
}
