namespace GEXVOC.UI
{
    partial class FindTratParcela
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPlaga = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.cmbParcela = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarParcela = new System.Windows.Forms.Button();
            this.cmbPlaga = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarPlaga = new System.Windows.Forms.Button();
            this.cmbProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecha);
            this.pnlBusqueda.Controls.Add(this.cmbProducto);
            this.pnlBusqueda.Controls.Add(this.btnBuscarProducto);
            this.pnlBusqueda.Controls.Add(this.cmbPlaga);
            this.pnlBusqueda.Controls.Add(this.btnBuscarPlaga);
            this.pnlBusqueda.Controls.Add(this.cmbParcela);
            this.pnlBusqueda.Controls.Add(this.btnBuscarParcela);
            this.pnlBusqueda.Controls.Add(this.lblProducto);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.lblPlaga);
            this.pnlBusqueda.Controls.Add(this.lblParcela);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 106);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Size = new System.Drawing.Size(610, 275);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProducto.Location = new System.Drawing.Point(33, 49);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 148;
            this.lblProducto.Text = "Producto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(33, 75);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 145;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblPlaga
            // 
            this.lblPlaga.AutoSize = true;
            this.lblPlaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPlaga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlaga.Location = new System.Drawing.Point(327, 23);
            this.lblPlaga.Name = "lblPlaga";
            this.lblPlaga.Size = new System.Drawing.Size(37, 13);
            this.lblPlaga.TabIndex = 144;
            this.lblPlaga.Text = "Plaga:";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblParcela.Location = new System.Drawing.Point(33, 23);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(46, 13);
            this.lblParcela.TabIndex = 143;
            this.lblParcela.Text = "Parcela:";
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
            this.cmbParcela.Location = new System.Drawing.Point(91, 19);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.PermitirEliminar = true;
            this.cmbParcela.PermitirLimpiar = true;
            this.cmbParcela.ReadOnly = false;
            this.cmbParcela.Size = new System.Drawing.Size(177, 21);
            this.cmbParcela.TabIndex = 0;
            this.cmbParcela.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbParcela.TipoDatos = null;
            // 
            // btnBuscarParcela
            // 
            this.btnBuscarParcela.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarParcela.Location = new System.Drawing.Point(274, 19);
            this.btnBuscarParcela.Name = "btnBuscarParcela";
            this.btnBuscarParcela.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarParcela.TabIndex = 1;
            this.btnBuscarParcela.UseVisualStyleBackColor = true;
            this.btnBuscarParcela.Click += new System.EventHandler(this.btnBuscarParcela_Click);
            // 
            // cmbPlaga
            // 
            this.cmbPlaga.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPlaga.btnBusqueda = this.btnBuscarPlaga;
            this.cmbPlaga.ClaseActiva = null;
            this.cmbPlaga.ControlVisible = true;
            this.cmbPlaga.DisplayMember = "Descripcion";
            this.cmbPlaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPlaga.FormattingEnabled = true;
            this.cmbPlaga.IdClaseActiva = 0;
            this.cmbPlaga.Location = new System.Drawing.Point(383, 19);
            this.cmbPlaga.Name = "cmbPlaga";
            this.cmbPlaga.PermitirEliminar = true;
            this.cmbPlaga.PermitirLimpiar = true;
            this.cmbPlaga.ReadOnly = false;
            this.cmbPlaga.Size = new System.Drawing.Size(168, 21);
            this.cmbPlaga.TabIndex = 2;
            this.cmbPlaga.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPlaga.TipoDatos = null;
            // 
            // btnBuscarPlaga
            // 
            this.btnBuscarPlaga.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPlaga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPlaga.Location = new System.Drawing.Point(554, 19);
            this.btnBuscarPlaga.Name = "btnBuscarPlaga";
            this.btnBuscarPlaga.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPlaga.TabIndex = 3;
            this.btnBuscarPlaga.UseVisualStyleBackColor = true;
            this.btnBuscarPlaga.Click += new System.EventHandler(this.btnBuscarPlaga_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.SystemColors.Control;
            this.cmbProducto.btnBusqueda = this.btnBuscarProducto;
            this.cmbProducto.ClaseActiva = null;
            this.cmbProducto.ControlVisible = true;
            this.cmbProducto.DisplayMember = "Descripcion";
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IdClaseActiva = 0;
            this.cmbProducto.Location = new System.Drawing.Point(91, 46);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.PermitirEliminar = true;
            this.cmbProducto.PermitirLimpiar = true;
            this.cmbProducto.ReadOnly = false;
            this.cmbProducto.Size = new System.Drawing.Size(177, 21);
            this.cmbProducto.TabIndex = 4;
            this.cmbProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbProducto.TipoDatos = null;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProducto.Location = new System.Drawing.Point(274, 45);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarProducto.TabIndex = 5;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(91, 73);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.Value = null;
            // 
            // FindTratParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 275);
            this.Name = "FindTratParcela";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 106);
            this.Text = "Tratamiento";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPlaga;
        private System.Windows.Forms.Label lblParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbParcela;
        private System.Windows.Forms.Button btnBuscarParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbPlaga;
        private System.Windows.Forms.Button btnBuscarPlaga;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
