namespace GEXVOC.UI
{
    partial class FindCita
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbContacto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.txtFechaDesde = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaHasta = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFechaHasta);
            this.pnlBusqueda.Controls.Add(this.txtFechaDesde);
            this.pnlBusqueda.Controls.Add(this.txtTema);
            this.pnlBusqueda.Controls.Add(this.lblTema);
            this.pnlBusqueda.Controls.Add(this.txtLugar);
            this.pnlBusqueda.Controls.Add(this.lblLugar);
            this.pnlBusqueda.Controls.Add(this.lblFechaHasta);
            this.pnlBusqueda.Controls.Add(this.lblFechaDesde);
            this.pnlBusqueda.Controls.Add(this.cmbContacto);
            this.pnlBusqueda.Controls.Add(this.btnBuscarContacto);
            this.pnlBusqueda.Controls.Add(this.label2);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 131);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 168);
            this.panel1.Size = new System.Drawing.Size(610, 250);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Contacto:";
            // 
            // cmbContacto
            // 
            this.cmbContacto.BackColor = System.Drawing.SystemColors.Control;
            this.cmbContacto.btnBusqueda = null;
            this.cmbContacto.ClaseActiva = null;
            this.cmbContacto.ControlVisible = true;
            this.cmbContacto.DisplayMember = "Nombre";
            this.cmbContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbContacto.FormattingEnabled = true;
            this.cmbContacto.IdClaseActiva = 0;
            this.cmbContacto.Location = new System.Drawing.Point(100, 26);
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.PermitirEliminar = true;
            this.cmbContacto.PermitirLimpiar = true;
            this.cmbContacto.ReadOnly = false;
            this.cmbContacto.Size = new System.Drawing.Size(243, 21);
            this.cmbContacto.TabIndex = 0;
            this.cmbContacto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbContacto.TipoDatos = null;
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarContacto.Location = new System.Drawing.Point(349, 26);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarContacto.TabIndex = 1;
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(18, 56);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(78, 13);
            this.lblFechaDesde.TabIndex = 61;
            this.lblFechaDesde.Text = "Fecha (desde):";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(227, 56);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaHasta.TabIndex = 63;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(100, 79);
            this.txtLugar.MaxLength = 100;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(388, 20);
            this.txtLugar.TabIndex = 4;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(18, 82);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 66;
            this.lblLugar.Text = "Lugar:";
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(100, 105);
            this.txtTema.MaxLength = 255;
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(388, 20);
            this.txtTema.TabIndex = 5;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(18, 106);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(37, 13);
            this.lblTema.TabIndex = 68;
            this.lblTema.Text = "Tema:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaDesde.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaDesde.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaDesde.Location = new System.Drawing.Point(100, 53);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.ReadOnly = false;
            this.txtFechaDesde.Size = new System.Drawing.Size(88, 20);
            this.txtFechaDesde.TabIndex = 2;
            this.txtFechaDesde.Value = null;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaHasta.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaHasta.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaHasta.Location = new System.Drawing.Point(282, 53);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.ReadOnly = false;
            this.txtFechaHasta.Size = new System.Drawing.Size(88, 20);
            this.txtFechaHasta.TabIndex = 3;
            this.txtFechaHasta.Value = null;
            // 
            // FindCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 250);
            this.Name = "FindCita";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 131);
            this.Text = "Citas";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbContacto;
        private System.Windows.Forms.Button btnBuscarContacto;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label lblTema;
        private GEXVOC.Core.Controles.ctlFecha txtFechaHasta;
        private GEXVOC.Core.Controles.ctlFecha txtFechaDesde;
    }
}
