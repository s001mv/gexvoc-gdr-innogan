namespace GEXVOC.UI
{
    partial class FindPersonal
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
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTlfno = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbTipo);
            this.pnlBusqueda.Controls.Add(this.lblTipo);
            this.pnlBusqueda.Controls.Add(this.txtCP);
            this.pnlBusqueda.Controls.Add(this.lblCodPostal);
            this.pnlBusqueda.Controls.Add(this.txtTelefono);
            this.pnlBusqueda.Controls.Add(this.lblTlfno);
            this.pnlBusqueda.Controls.Add(this.txtDireccion);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.txtApellidos);
            this.pnlBusqueda.Controls.Add(this.lblApellidos);
            this.pnlBusqueda.Controls.Add(this.txtNombre);
            this.pnlBusqueda.Controls.Add(this.lblNombre);
            this.pnlBusqueda.Controls.Add(this.txtDNI);
            this.pnlBusqueda.Controls.Add(this.lblDNI);
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 37);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 111);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 154);
            this.panel1.Size = new System.Drawing.Size(610, 264);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(482, 76);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(103, 20);
            this.txtCP.TabIndex = 6;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodPostal.Location = new System.Drawing.Point(425, 81);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(27, 13);
            this.lblCodPostal.TabIndex = 24;
            this.lblCodPostal.Text = "C.P:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(482, 52);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(103, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // lblTlfno
            // 
            this.lblTlfno.AutoSize = true;
            this.lblTlfno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTlfno.Location = new System.Drawing.Point(424, 57);
            this.lblTlfno.Name = "lblTlfno";
            this.lblTlfno.Size = new System.Drawing.Size(52, 13);
            this.lblTlfno.TabIndex = 23;
            this.lblTlfno.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(69, 78);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(347, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dirección:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(307, 24);
            this.txtApellidos.MaxLength = 60;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(278, 20);
            this.txtApellidos.TabIndex = 1;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApellidos.Location = new System.Drawing.Point(249, 27);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 18;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(69, 24);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(6, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(307, 52);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(109, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDNI.Location = new System.Drawing.Point(249, 55);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 13;
            this.lblDNI.Text = "DNI:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(69, 49);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(162, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(6, 52);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 120;
            this.lblTipo.Text = "Tipo:";
            // 
            // FindPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 264);
            this.Name = "FindPersonal";
            this.pnlBusquedaPosicion = new System.Drawing.Point(12, 37);
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 111);
            this.Text = "Personal";
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
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}
