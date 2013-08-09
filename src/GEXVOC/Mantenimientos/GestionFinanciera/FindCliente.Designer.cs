namespace GEXVOC.UI
{
    partial class FindCliente
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
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTlfno = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.chkTodasExplotaciones = new System.Windows.Forms.CheckBox();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.chkTodasExplotaciones);
            this.pnlBusqueda.Controls.Add(this.txtCP);
            this.pnlBusqueda.Controls.Add(this.lblCodPostal);
            this.pnlBusqueda.Controls.Add(this.txtTelefono);
            this.pnlBusqueda.Controls.Add(this.lblTlfno);
            this.pnlBusqueda.Controls.Add(this.txtDireccion);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.txtNombre);
            this.pnlBusqueda.Controls.Add(this.lblNombre);
            this.pnlBusqueda.Controls.Add(this.txtDNI);
            this.pnlBusqueda.Controls.Add(this.lblDNI);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 110);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 147);
            this.panel1.Size = new System.Drawing.Size(610, 277);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(471, 74);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(116, 20);
            this.txtCP.TabIndex = 21;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodPostal.Location = new System.Drawing.Point(438, 79);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(27, 13);
            this.lblCodPostal.TabIndex = 24;
            this.lblCodPostal.Text = "C.P:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(278, 48);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 19;
            // 
            // lblTlfno
            // 
            this.lblTlfno.AutoSize = true;
            this.lblTlfno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTlfno.Location = new System.Drawing.Point(220, 53);
            this.lblTlfno.Name = "lblTlfno";
            this.lblTlfno.Size = new System.Drawing.Size(52, 13);
            this.lblTlfno.TabIndex = 23;
            this.lblTlfno.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(83, 74);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(347, 20);
            this.txtDireccion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(83, 22);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(347, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(22, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(83, 48);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(129, 20);
            this.txtDNI.TabIndex = 17;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDNI.Location = new System.Drawing.Point(22, 53);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 13;
            this.lblDNI.Text = "DNI:";
            // 
            // chkTodasExplotaciones
            // 
            this.chkTodasExplotaciones.AutoSize = true;
            this.chkTodasExplotaciones.Location = new System.Drawing.Point(471, 25);
            this.chkTodasExplotaciones.Name = "chkTodasExplotaciones";
            this.chkTodasExplotaciones.Size = new System.Drawing.Size(94, 17);
            this.chkTodasExplotaciones.TabIndex = 25;
            this.chkTodasExplotaciones.Text = "Mostrar Todos";
            this.toolTip1.SetToolTip(this.chkTodasExplotaciones, "Muestra los Clientes de todas las Explotaciones.");
            this.chkTodasExplotaciones.UseVisualStyleBackColor = true;
            // 
            // FindCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 277);
            this.Name = "FindCliente";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 110);
            this.Text = "Clientes";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTlfno;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.CheckBox chkTodasExplotaciones;
    }
}
