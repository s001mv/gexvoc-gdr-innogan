namespace GEXVOC.UI
{
    partial class FindSiembra
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
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBuscarParcela = new System.Windows.Forms.Button();
            this.btnBuscarSemilla = new System.Windows.Forms.Button();
            this.cmbSemilla = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.cmbParcela = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecha);
            this.pnlBusqueda.Controls.Add(this.cmbSemilla);
            this.pnlBusqueda.Controls.Add(this.btnBuscarSemilla);
            this.pnlBusqueda.Controls.Add(this.cmbParcela);
            this.pnlBusqueda.Controls.Add(this.btnBuscarParcela);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.lblSemilla);
            this.pnlBusqueda.Controls.Add(this.lblParcela);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 107);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 144);
            this.panel1.Size = new System.Drawing.Size(610, 274);
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(46, 20);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(46, 13);
            this.lblParcela.TabIndex = 0;
            this.lblParcela.Text = "Parcela:";
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Location = new System.Drawing.Point(46, 47);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(43, 13);
            this.lblSemilla.TabIndex = 1;
            this.lblSemilla.Text = "Semilla:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(46, 74);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnBuscarParcela
            // 
            this.btnBuscarParcela.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarParcela.Location = new System.Drawing.Point(304, 17);
            this.btnBuscarParcela.Name = "btnBuscarParcela";
            this.btnBuscarParcela.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarParcela.TabIndex = 1;
            this.btnBuscarParcela.UseVisualStyleBackColor = true;
            this.btnBuscarParcela.Click += new System.EventHandler(this.btnBuscarParcela_Click);
            // 
            // btnBuscarSemilla
            // 
            this.btnBuscarSemilla.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarSemilla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarSemilla.Location = new System.Drawing.Point(304, 44);
            this.btnBuscarSemilla.Name = "btnBuscarSemilla";
            this.btnBuscarSemilla.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarSemilla.TabIndex = 3;
            this.btnBuscarSemilla.UseVisualStyleBackColor = true;
            this.btnBuscarSemilla.Click += new System.EventHandler(this.btnBuscarSemilla_Click);
            // 
            // cmbSemilla
            // 
            this.cmbSemilla.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSemilla.btnBusqueda = this.btnBuscarSemilla;
            this.cmbSemilla.ClaseActiva = null;
            this.cmbSemilla.ControlVisible = true;
            this.cmbSemilla.DisplayMember = "Descripcion";
            this.cmbSemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbSemilla.FormattingEnabled = true;
            this.cmbSemilla.IdClaseActiva = 0;
            this.cmbSemilla.Location = new System.Drawing.Point(98, 44);
            this.cmbSemilla.Name = "cmbSemilla";
            this.cmbSemilla.PermitirEliminar = true;
            this.cmbSemilla.PermitirLimpiar = true;
            this.cmbSemilla.ReadOnly = false;
            this.cmbSemilla.Size = new System.Drawing.Size(200, 21);
            this.cmbSemilla.TabIndex = 2;
            this.cmbSemilla.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbSemilla.TipoDatos = null;
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
            this.cmbParcela.Location = new System.Drawing.Point(98, 17);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.PermitirEliminar = true;
            this.cmbParcela.PermitirLimpiar = true;
            this.cmbParcela.ReadOnly = false;
            this.cmbParcela.Size = new System.Drawing.Size(200, 21);
            this.cmbParcela.TabIndex = 0;
            this.cmbParcela.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbParcela.TipoDatos = null;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(98, 71);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.Value = null;
            // 
            // FindSiembra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 274);
            this.Name = "FindSiembra";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 107);
            this.Text = "Sembrado de parcelas";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Label lblParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbParcela;
        private System.Windows.Forms.Button btnBuscarParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbSemilla;
        private System.Windows.Forms.Button btnBuscarSemilla;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
