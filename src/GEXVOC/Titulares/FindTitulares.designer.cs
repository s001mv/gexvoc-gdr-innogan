﻿namespace GEXVOC.UI
{
    partial class FindTitulares
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
            this.SubBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnCuentas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExplotaciones = new System.Windows.Forms.ToolStripButton();
            this.chkTodasExplotaciones = new System.Windows.Forms.CheckBox();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SubBarraHerramientas.SuspendLayout();
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
            this.pnlBusqueda.Controls.Add(this.txtApellidos);
            this.pnlBusqueda.Controls.Add(this.lblApellidos);
            this.pnlBusqueda.Controls.Add(this.txtNombre);
            this.pnlBusqueda.Controls.Add(this.lblNombre);
            this.pnlBusqueda.Controls.Add(this.txtDNI);
            this.pnlBusqueda.Controls.Add(this.lblDNI);
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 53);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 160);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(472, 86);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(116, 20);
            this.txtCP.TabIndex = 21;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodPostal.Location = new System.Drawing.Point(439, 91);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(27, 13);
            this.lblCodPostal.TabIndex = 24;
            this.lblCodPostal.Text = "C.P:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(279, 60);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 19;
            // 
            // lblTlfno
            // 
            this.lblTlfno.AutoSize = true;
            this.lblTlfno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTlfno.Location = new System.Drawing.Point(221, 65);
            this.lblTlfno.Name = "lblTlfno";
            this.lblTlfno.Size = new System.Drawing.Size(52, 13);
            this.lblTlfno.TabIndex = 23;
            this.lblTlfno.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 86);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(347, 20);
            this.txtDireccion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dirección:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(279, 34);
            this.txtApellidos.MaxLength = 60;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(309, 20);
            this.txtApellidos.TabIndex = 15;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApellidos.Location = new System.Drawing.Point(221, 37);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 18;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(84, 34);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(23, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(84, 60);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(129, 20);
            this.txtDNI.TabIndex = 17;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDNI.Location = new System.Drawing.Point(23, 65);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 13;
            this.lblDNI.Text = "DNI:";
            // 
            // SubBarraHerramientas
            // 
            this.SubBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCuentas,
            this.toolStripSeparator2,
            this.btnExplotaciones});
            this.SubBarraHerramientas.Location = new System.Drawing.Point(0, 25);
            this.SubBarraHerramientas.Name = "SubBarraHerramientas";
            this.SubBarraHerramientas.Size = new System.Drawing.Size(636, 25);
            this.SubBarraHerramientas.TabIndex = 6;
            // 
            // btnCuentas
            // 
            this.btnCuentas.Image = global::GEXVOC.Properties.Resources.info;
            this.btnCuentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(67, 22);
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.ToolTipText = "Ver cuentas";
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExplotaciones
            // 
            this.btnExplotaciones.Image = global::GEXVOC.Properties.Resources.info;
            this.btnExplotaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExplotaciones.Name = "btnExplotaciones";
            this.btnExplotaciones.Size = new System.Drawing.Size(93, 22);
            this.btnExplotaciones.Text = "Explotaciones";
            this.btnExplotaciones.ToolTipText = "Ver explotaciones";
            this.btnExplotaciones.Click += new System.EventHandler(this.btnExplotaciones_Click);
            // 
            // chkTodasExplotaciones
            // 
            this.chkTodasExplotaciones.AutoSize = true;
            this.chkTodasExplotaciones.Location = new System.Drawing.Point(84, 112);
            this.chkTodasExplotaciones.Name = "chkTodasExplotaciones";
            this.chkTodasExplotaciones.Size = new System.Drawing.Size(94, 17);
            this.chkTodasExplotaciones.TabIndex = 27;
            this.chkTodasExplotaciones.Text = "Mostrar Todos";
            this.toolTip1.SetToolTip(this.chkTodasExplotaciones, "Muestra los Clientes de todas las Explotaciones.");
            this.chkTodasExplotaciones.UseVisualStyleBackColor = true;
            // 
            // FindTitulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(636, 445);
            this.Controls.Add(this.SubBarraHerramientas);
            this.Name = "FindTitulares";
            this.pnlBusquedaPosicion = new System.Drawing.Point(12, 53);
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 160);
            this.Text = "Titulares";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.SubBarraHerramientas, 0);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.SubBarraHerramientas.ResumeLayout(false);
            this.SubBarraHerramientas.PerformLayout();
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
        private System.Windows.Forms.ToolStrip SubBarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnCuentas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExplotaciones;
        private System.Windows.Forms.CheckBox chkTodasExplotaciones;
    }
}