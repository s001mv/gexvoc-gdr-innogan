namespace GEXVOC.UI
{
    partial class FindPastoreo
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
            this.cmbParcela = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarParcela = new System.Windows.Forms.Button();
            this.lblParcela = new System.Windows.Forms.Label();
            this.cmbLote = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarLote = new System.Windows.Forms.Button();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecha);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.lblLote);
            this.pnlBusqueda.Controls.Add(this.cmbLote);
            this.pnlBusqueda.Controls.Add(this.btnBuscarLote);
            this.pnlBusqueda.Controls.Add(this.lblParcela);
            this.pnlBusqueda.Controls.Add(this.cmbParcela);
            this.pnlBusqueda.Controls.Add(this.btnBuscarParcela);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 135);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 172);
            this.panel1.Size = new System.Drawing.Size(610, 246);
            // 
            // cmbParcela
            // 
            this.cmbParcela.BackColor = System.Drawing.SystemColors.Control;
            this.cmbParcela.btnBusqueda = this.btnBuscarParcela;
            this.cmbParcela.ClaseActiva = null;
            this.cmbParcela.ControlVisible = true;
            this.cmbParcela.DisplayMember = "Nombre";
            this.cmbParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.IdClaseActiva = 0;
            this.cmbParcela.Location = new System.Drawing.Point(158, 27);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.PermitirEliminar = true;
            this.cmbParcela.PermitirLimpiar = true;
            this.cmbParcela.ReadOnly = false;
            this.cmbParcela.Size = new System.Drawing.Size(168, 21);
            this.cmbParcela.TabIndex = 1;
            this.cmbParcela.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbParcela.TipoDatos = null;
            // 
            // btnBuscarParcela
            // 
            this.btnBuscarParcela.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarParcela.Location = new System.Drawing.Point(329, 27);
            this.btnBuscarParcela.Name = "btnBuscarParcela";
            this.btnBuscarParcela.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarParcela.TabIndex = 2;
            this.btnBuscarParcela.UseVisualStyleBackColor = true;
            this.btnBuscarParcela.Click += new System.EventHandler(this.btnBuscarParcela_Click);
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(61, 31);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(46, 13);
            this.lblParcela.TabIndex = 57;
            this.lblParcela.Text = "Parcela:";
            // 
            // cmbLote
            // 
            this.cmbLote.BackColor = System.Drawing.SystemColors.Control;
            this.cmbLote.btnBusqueda = this.btnBuscarLote;
            this.cmbLote.ClaseActiva = null;
            this.cmbLote.ControlVisible = true;
            this.cmbLote.DisplayMember = "Descripcion";
            this.cmbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.IdClaseActiva = 0;
            this.cmbLote.Location = new System.Drawing.Point(158, 58);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.PermitirEliminar = true;
            this.cmbLote.PermitirLimpiar = true;
            this.cmbLote.ReadOnly = false;
            this.cmbLote.Size = new System.Drawing.Size(168, 21);
            this.cmbLote.TabIndex = 3;
            this.cmbLote.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbLote.TipoDatos = null;
            // 
            // btnBuscarLote
            // 
            this.btnBuscarLote.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarLote.Location = new System.Drawing.Point(329, 58);
            this.btnBuscarLote.Name = "btnBuscarLote";
            this.btnBuscarLote.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarLote.TabIndex = 4;
            this.btnBuscarLote.UseVisualStyleBackColor = true;
            this.btnBuscarLote.Click += new System.EventHandler(this.btnBuscarLote_Click);
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(61, 62);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(91, 13);
            this.lblLote.TabIndex = 60;
            this.lblLote.Text = "Lote de Animales:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(61, 95);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 13);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha de Inicio:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(158, 95);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.Value = null;
            // 
            // FindPastoreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 246);
            this.Name = "FindPastoreo";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 135);
            this.Text = "Pastoreos";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbParcela;
        private System.Windows.Forms.Button btnBuscarParcela;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLote;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLote;
        private System.Windows.Forms.Button btnBuscarLote;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
