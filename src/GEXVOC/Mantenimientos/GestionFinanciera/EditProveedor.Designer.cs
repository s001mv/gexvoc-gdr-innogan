namespace GEXVOC.UI
{
    partial class EditProveedor
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
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.lblMovil = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTlfno = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtFecBaja = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFecAlta = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFecBaja = new System.Windows.Forms.Label();
            this.lblFecAlta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMovil
            // 
            this.txtMovil.Location = new System.Drawing.Point(336, 106);
            this.txtMovil.MaxLength = 9;
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(126, 20);
            this.txtMovil.TabIndex = 4;
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Location = new System.Drawing.Point(281, 109);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(35, 13);
            this.lblMovil.TabIndex = 186;
            this.lblMovil.Text = "Móvil:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(114, 166);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(32, 169);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 185;
            this.lblemail.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 49);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(348, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 139);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(348, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDireccion.Location = new System.Drawing.Point(32, 142);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 180;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTlfno
            // 
            this.lblTlfno.AutoSize = true;
            this.lblTlfno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTlfno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTlfno.Location = new System.Drawing.Point(32, 112);
            this.lblTlfno.Name = "lblTlfno";
            this.lblTlfno.Size = new System.Drawing.Size(52, 13);
            this.lblTlfno.TabIndex = 181;
            this.lblTlfno.Text = "Teléfono:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(114, 79);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(114, 20);
            this.txtDNI.TabIndex = 1;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDNI.Location = new System.Drawing.Point(32, 82);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(56, 13);
            this.lblDNI.TabIndex = 178;
            this.lblDNI.Text = "CIF/NIF:";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(336, 79);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(73, 20);
            this.txtCP.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(114, 109);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(114, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(32, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 179;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCodPostal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodPostal.Location = new System.Drawing.Point(281, 82);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(27, 13);
            this.lblCodPostal.TabIndex = 182;
            this.lblCodPostal.Text = "C.P:";
            // 
            // txtFecBaja
            // 
            this.txtFecBaja.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecBaja.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecBaja.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecBaja.Location = new System.Drawing.Point(284, 192);
            this.txtFecBaja.Name = "txtFecBaja";
            this.txtFecBaja.ReadOnly = false;
            this.txtFecBaja.Size = new System.Drawing.Size(88, 20);
            this.txtFecBaja.TabIndex = 188;
            this.txtFecBaja.Value = null;
            // 
            // txtFecAlta
            // 
            this.txtFecAlta.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecAlta.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecAlta.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecAlta.Location = new System.Drawing.Point(114, 192);
            this.txtFecAlta.Name = "txtFecAlta";
            this.txtFecAlta.ReadOnly = false;
            this.txtFecAlta.Size = new System.Drawing.Size(88, 20);
            this.txtFecAlta.TabIndex = 187;
            this.txtFecAlta.Value = null;
            // 
            // lblFecBaja
            // 
            this.lblFecBaja.AutoSize = true;
            this.lblFecBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecBaja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecBaja.Location = new System.Drawing.Point(235, 197);
            this.lblFecBaja.Name = "lblFecBaja";
            this.lblFecBaja.Size = new System.Drawing.Size(43, 13);
            this.lblFecBaja.TabIndex = 190;
            this.lblFecBaja.Text = "F. Baja:";
            // 
            // lblFecAlta
            // 
            this.lblFecAlta.AutoSize = true;
            this.lblFecAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecAlta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecAlta.Location = new System.Drawing.Point(32, 197);
            this.lblFecAlta.Name = "lblFecAlta";
            this.lblFecAlta.Size = new System.Drawing.Size(48, 13);
            this.lblFecAlta.TabIndex = 189;
            this.lblFecAlta.Text = "F. Alta:";
            // 
            // EditProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(500, 269);
            this.Controls.Add(this.txtFecBaja);
            this.Controls.Add(this.txtFecAlta);
            this.Controls.Add(this.lblFecBaja);
            this.Controls.Add(this.lblFecAlta);
            this.Controls.Add(this.txtMovil);
            this.Controls.Add(this.lblMovil);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTlfno);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodPostal);
            this.Name = "EditProveedor";
            this.Text = "Proveedor";
            this.Controls.SetChildIndex(this.lblCodPostal, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.txtCP, 0);
            this.Controls.SetChildIndex(this.lblDNI, 0);
            this.Controls.SetChildIndex(this.txtDNI, 0);
            this.Controls.SetChildIndex(this.lblTlfno, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblemail, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.lblMovil, 0);
            this.Controls.SetChildIndex(this.txtMovil, 0);
            this.Controls.SetChildIndex(this.lblFecAlta, 0);
            this.Controls.SetChildIndex(this.lblFecBaja, 0);
            this.Controls.SetChildIndex(this.txtFecAlta, 0);
            this.Controls.SetChildIndex(this.txtFecBaja, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTlfno;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        public System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodPostal;
        private GEXVOC.Core.Controles.ctlFecha txtFecBaja;
        private GEXVOC.Core.Controles.ctlFecha txtFecAlta;
        private System.Windows.Forms.Label lblFecBaja;
        private System.Windows.Forms.Label lblFecAlta;

    }
}
