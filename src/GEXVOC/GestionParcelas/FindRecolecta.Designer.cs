namespace GEXVOC.UI
{
    partial class FindRecolecta
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
            this.lblForraje = new System.Windows.Forms.Label();
            this.cmbForraje = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarForraje = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
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
            this.pnlBusqueda.Controls.Add(this.lblFechaHasta);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.cmbForraje);
            this.pnlBusqueda.Controls.Add(this.btnBuscarForraje);
            this.pnlBusqueda.Controls.Add(this.lblForraje);
            this.pnlBusqueda.Controls.Add(this.lblParcela);
            this.pnlBusqueda.Controls.Add(this.cmbParcela);
            this.pnlBusqueda.Controls.Add(this.btnBuscarParcela);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 116);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 153);
            this.panel1.Size = new System.Drawing.Size(610, 265);
            // 
            // cmbParcela
            // 
            this.cmbParcela.BackColor = System.Drawing.SystemColors.Control;
            this.cmbParcela.btnBusqueda = null;
            this.cmbParcela.ClaseActiva = null;
            this.cmbParcela.ControlVisible = true;
            this.cmbParcela.DisplayMember = "Nombre";
            this.cmbParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.IdClaseActiva = 0;
            this.cmbParcela.Location = new System.Drawing.Point(99, 20);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.PermitirEliminar = true;
            this.cmbParcela.PermitirLimpiar = true;
            this.cmbParcela.ReadOnly = false;
            this.cmbParcela.Size = new System.Drawing.Size(240, 21);
            this.cmbParcela.TabIndex = 0;
            this.cmbParcela.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbParcela.TipoDatos = null;
            // 
            // btnBuscarParcela
            // 
            this.btnBuscarParcela.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarParcela.Location = new System.Drawing.Point(345, 20);
            this.btnBuscarParcela.Name = "btnBuscarParcela";
            this.btnBuscarParcela.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarParcela.TabIndex = 1;
            this.btnBuscarParcela.UseVisualStyleBackColor = true;
            this.btnBuscarParcela.Click += new System.EventHandler(this.btnBuscarParcela_Click);
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(52, 23);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(46, 13);
            this.lblParcela.TabIndex = 57;
            this.lblParcela.Text = "Parcela:";
            // 
            // lblForraje
            // 
            this.lblForraje.AutoSize = true;
            this.lblForraje.Location = new System.Drawing.Point(52, 54);
            this.lblForraje.Name = "lblForraje";
            this.lblForraje.Size = new System.Drawing.Size(42, 13);
            this.lblForraje.TabIndex = 58;
            this.lblForraje.Text = "Forraje:";
            this.lblForraje.Click += new System.EventHandler(this.lblForraje_Click);
            // 
            // cmbForraje
            // 
            this.cmbForraje.BackColor = System.Drawing.SystemColors.Control;
            this.cmbForraje.btnBusqueda = this.btnBuscarForraje;
            this.cmbForraje.ClaseActiva = null;
            this.cmbForraje.ControlVisible = true;
            this.cmbForraje.DisplayMember = "Descripcion";
            this.cmbForraje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbForraje.FormattingEnabled = true;
            this.cmbForraje.IdClaseActiva = 0;
            this.cmbForraje.Location = new System.Drawing.Point(100, 50);
            this.cmbForraje.Name = "cmbForraje";
            this.cmbForraje.PermitirEliminar = true;
            this.cmbForraje.PermitirLimpiar = true;
            this.cmbForraje.ReadOnly = false;
            this.cmbForraje.Size = new System.Drawing.Size(240, 21);
            this.cmbForraje.TabIndex = 2;
            this.cmbForraje.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbForraje.TipoDatos = null;
            this.cmbForraje.SelectedIndexChanged += new System.EventHandler(this.cmbForraje_SelectedIndexChanged);
            // 
            // btnBuscarForraje
            // 
            this.btnBuscarForraje.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarForraje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarForraje.Location = new System.Drawing.Point(346, 50);
            this.btnBuscarForraje.Name = "btnBuscarForraje";
            this.btnBuscarForraje.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarForraje.TabIndex = 3;
            this.btnBuscarForraje.UseVisualStyleBackColor = true;
            this.btnBuscarForraje.Click += new System.EventHandler(this.btnBuscarForraje_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(52, 81);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 13);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha (desde) :";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(235, 79);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaHasta.TabIndex = 63;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaDesde.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaDesde.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaDesde.Location = new System.Drawing.Point(141, 77);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.ReadOnly = false;
            this.txtFechaDesde.Size = new System.Drawing.Size(88, 20);
            this.txtFechaDesde.TabIndex = 4;
            this.txtFechaDesde.Value = null;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaHasta.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaHasta.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaHasta.Location = new System.Drawing.Point(279, 76);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.ReadOnly = false;
            this.txtFechaHasta.Size = new System.Drawing.Size(88, 20);
            this.txtFechaHasta.TabIndex = 5;
            this.txtFechaHasta.Value = null;
            // 
            // FindRecolecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 265);
            this.Name = "FindRecolecta";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 116);
            this.Text = "Recolectas";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForraje;
        private System.Windows.Forms.Label lblParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbParcela;
        private System.Windows.Forms.Button btnBuscarParcela;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFecha;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbForraje;
        private System.Windows.Forms.Button btnBuscarForraje;
        private GEXVOC.Core.Controles.ctlFecha txtFechaHasta;
        private GEXVOC.Core.Controles.ctlFecha txtFechaDesde;
    }
}
