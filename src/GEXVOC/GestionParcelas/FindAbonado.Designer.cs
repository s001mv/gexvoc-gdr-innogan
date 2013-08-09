namespace GEXVOC.UI
{
    partial class FindAbonado
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoAbono = new System.Windows.Forms.Label();
            this.lblFinca = new System.Windows.Forms.Label();
            this.cmbParcela = new System.Windows.Forms.ComboBox();
            this.cmbAbono = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAbono = new System.Windows.Forms.Button();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecha);
            this.pnlBusqueda.Controls.Add(this.cmbAbono);
            this.pnlBusqueda.Controls.Add(this.btnBuscarAbono);
            this.pnlBusqueda.Controls.Add(this.cmbParcela);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.lblTipoAbono);
            this.pnlBusqueda.Controls.Add(this.lblFinca);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 127);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 164);
            this.panel1.Size = new System.Drawing.Size(610, 254);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(54, 89);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 143;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTipoAbono
            // 
            this.lblTipoAbono.AutoSize = true;
            this.lblTipoAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAbono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipoAbono.Location = new System.Drawing.Point(54, 59);
            this.lblTipoAbono.Name = "lblTipoAbono";
            this.lblTipoAbono.Size = new System.Drawing.Size(51, 13);
            this.lblTipoAbono.TabIndex = 142;
            this.lblTipoAbono.Text = "T.Abono:";
            // 
            // lblFinca
            // 
            this.lblFinca.AutoSize = true;
            this.lblFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFinca.Location = new System.Drawing.Point(54, 33);
            this.lblFinca.Name = "lblFinca";
            this.lblFinca.Size = new System.Drawing.Size(46, 13);
            this.lblFinca.TabIndex = 141;
            this.lblFinca.Text = "Parcela:";
            // 
            // cmbParcela
            // 
            this.cmbParcela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParcela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.Location = new System.Drawing.Point(122, 33);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.Size = new System.Drawing.Size(223, 21);
            this.cmbParcela.TabIndex = 0;
            // 
            // cmbAbono
            // 
            this.cmbAbono.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAbono.btnBusqueda = this.btnBuscarAbono;
            this.cmbAbono.ClaseActiva = null;
            this.cmbAbono.ControlVisible = true;
            this.cmbAbono.DisplayMember = "Descripcion";
            this.cmbAbono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAbono.FormattingEnabled = true;
            this.cmbAbono.IdClaseActiva = 0;
            this.cmbAbono.Location = new System.Drawing.Point(122, 60);
            this.cmbAbono.Name = "cmbAbono";
            this.cmbAbono.PermitirEliminar = true;
            this.cmbAbono.PermitirLimpiar = true;
            this.cmbAbono.ReadOnly = false;
            this.cmbAbono.Size = new System.Drawing.Size(196, 21);
            this.cmbAbono.TabIndex = 1;
            this.cmbAbono.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAbono.TipoDatos = null;
            // 
            // btnBuscarAbono
            // 
            this.btnBuscarAbono.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAbono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAbono.Location = new System.Drawing.Point(324, 60);
            this.btnBuscarAbono.Name = "btnBuscarAbono";
            this.btnBuscarAbono.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAbono.TabIndex = 2;
            this.btnBuscarAbono.UseVisualStyleBackColor = true;
            this.btnBuscarAbono.Click += new System.EventHandler(this.btnBuscarAbono_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(122, 87);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.Value = null;
            // 
            // FindAbonado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 254);
            this.Name = "FindAbonado";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 127);
            this.Text = "Abonados";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoAbono;
        private System.Windows.Forms.Label lblFinca;
        private System.Windows.Forms.ComboBox cmbParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAbono;
        private System.Windows.Forms.Button btnBuscarAbono;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;

    }
}
