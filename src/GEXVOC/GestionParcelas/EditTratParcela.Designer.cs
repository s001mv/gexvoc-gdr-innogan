namespace GEXVOC.UI
{
    partial class EditTratParcela
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.txtTipoTratamiento = new System.Windows.Forms.TextBox();
            this.lblSituacion = new System.Windows.Forms.Label();
            this.txtSituacion = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtCaldo = new System.Windows.Forms.TextBox();
            this.lblCaldo = new System.Windows.Forms.Label();
            this.lblPlaga = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.cmbParcela = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarParcela = new System.Windows.Forms.Button();
            this.cmbPlaga = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarPlaga = new System.Windows.Forms.Button();
            this.cmbProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(537, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 157;
            this.label1.Text = "hectáreas";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(465, 94);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(66, 20);
            this.txtSuperficie.TabIndex = 7;
            this.txtSuperficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSuperficie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSuperficie.Location = new System.Drawing.Point(347, 97);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(112, 13);
            this.lblSuperficie.TabIndex = 156;
            this.lblSuperficie.Text = "Superficie tratada:";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTratamiento.Location = new System.Drawing.Point(21, 175);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(95, 13);
            this.lblTratamiento.TabIndex = 155;
            this.lblTratamiento.Text = "Observaciones:";
            // 
            // txtTipoTratamiento
            // 
            this.txtTipoTratamiento.Location = new System.Drawing.Point(119, 172);
            this.txtTipoTratamiento.MaxLength = 255;
            this.txtTipoTratamiento.Name = "txtTipoTratamiento";
            this.txtTipoTratamiento.Size = new System.Drawing.Size(541, 20);
            this.txtTipoTratamiento.TabIndex = 10;
            // 
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSituacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSituacion.Location = new System.Drawing.Point(21, 149);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(64, 13);
            this.lblSituacion.TabIndex = 154;
            this.lblSituacion.Text = "Situación:";
            // 
            // txtSituacion
            // 
            this.txtSituacion.Location = new System.Drawing.Point(119, 146);
            this.txtSituacion.MaxLength = 255;
            this.txtSituacion.Name = "txtSituacion";
            this.txtSituacion.Size = new System.Drawing.Size(541, 20);
            this.txtSituacion.TabIndex = 9;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProducto.Location = new System.Drawing.Point(347, 67);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(113, 13);
            this.lblProducto.TabIndex = 153;
            this.lblProducto.Text = "Producto utilizado:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(21, 123);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 152;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLitros.Location = new System.Drawing.Point(191, 97);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(32, 13);
            this.lblLitros.TabIndex = 146;
            this.lblLitros.Text = "Litros";
            // 
            // txtCaldo
            // 
            this.txtCaldo.Location = new System.Drawing.Point(119, 94);
            this.txtCaldo.Name = "txtCaldo";
            this.txtCaldo.Size = new System.Drawing.Size(66, 20);
            this.txtCaldo.TabIndex = 6;
            this.txtCaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCaldo
            // 
            this.lblCaldo.AutoSize = true;
            this.lblCaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCaldo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCaldo.Location = new System.Drawing.Point(21, 97);
            this.lblCaldo.Name = "lblCaldo";
            this.lblCaldo.Size = new System.Drawing.Size(95, 13);
            this.lblCaldo.TabIndex = 151;
            this.lblCaldo.Text = "Litros de caldo:";
            // 
            // lblPlaga
            // 
            this.lblPlaga.AutoSize = true;
            this.lblPlaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPlaga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlaga.Location = new System.Drawing.Point(21, 66);
            this.lblPlaga.Name = "lblPlaga";
            this.lblPlaga.Size = new System.Drawing.Size(88, 13);
            this.lblPlaga.TabIndex = 150;
            this.lblPlaga.Text = "Plaga a tratar:";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblParcela.Location = new System.Drawing.Point(21, 41);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(54, 13);
            this.lblParcela.TabIndex = 149;
            this.lblParcela.Text = "Parcela:";
            // 
            // cmbParcela
            // 
            this.cmbParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbParcela.btnBusqueda = this.btnBuscarParcela;
            this.cmbParcela.ClaseActiva = null;
            this.cmbParcela.ControlVisible = true;
            this.cmbParcela.DisplayMember = "Nombre";
            this.cmbParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.IdClaseActiva = 0;
            this.cmbParcela.Location = new System.Drawing.Point(119, 37);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.PermitirEliminar = true;
            this.cmbParcela.PermitirLimpiar = true;
            this.cmbParcela.ReadOnly = false;
            this.cmbParcela.Size = new System.Drawing.Size(177, 21);
            this.cmbParcela.TabIndex = 0;
            this.cmbParcela.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbParcela.TipoDatos = null;
            this.cmbParcela.CrearNuevo += new System.EventHandler(this.cmbParcela_CrearNuevo);
            // 
            // btnBuscarParcela
            // 
            this.btnBuscarParcela.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarParcela.Location = new System.Drawing.Point(302, 37);
            this.btnBuscarParcela.Name = "btnBuscarParcela";
            this.btnBuscarParcela.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarParcela.TabIndex = 1;
            this.btnBuscarParcela.UseVisualStyleBackColor = true;
            this.btnBuscarParcela.Click += new System.EventHandler(this.btnBuscarParcela_Click);
            // 
            // cmbPlaga
            // 
            this.cmbPlaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbPlaga.btnBusqueda = this.btnBuscarPlaga;
            this.cmbPlaga.ClaseActiva = null;
            this.cmbPlaga.ControlVisible = true;
            this.cmbPlaga.DisplayMember = "Descripcion";
            this.cmbPlaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPlaga.FormattingEnabled = true;
            this.cmbPlaga.IdClaseActiva = 0;
            this.cmbPlaga.Location = new System.Drawing.Point(119, 63);
            this.cmbPlaga.Name = "cmbPlaga";
            this.cmbPlaga.PermitirEliminar = true;
            this.cmbPlaga.PermitirLimpiar = true;
            this.cmbPlaga.ReadOnly = false;
            this.cmbPlaga.Size = new System.Drawing.Size(177, 21);
            this.cmbPlaga.TabIndex = 2;
            this.cmbPlaga.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPlaga.TipoDatos = null;
            this.cmbPlaga.CrearNuevo += new System.EventHandler(this.cmbPlaga_CrearNuevo);
            // 
            // btnBuscarPlaga
            // 
            this.btnBuscarPlaga.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPlaga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPlaga.Location = new System.Drawing.Point(302, 64);
            this.btnBuscarPlaga.Name = "btnBuscarPlaga";
            this.btnBuscarPlaga.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPlaga.TabIndex = 3;
            this.btnBuscarPlaga.UseVisualStyleBackColor = true;
            this.btnBuscarPlaga.Click += new System.EventHandler(this.btnBuscarPlaga_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbProducto.btnBusqueda = this.btnBuscarProducto;
            this.cmbProducto.ClaseActiva = null;
            this.cmbProducto.ControlVisible = true;
            this.cmbProducto.DisplayMember = "Descripcion";
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IdClaseActiva = 0;
            this.cmbProducto.Location = new System.Drawing.Point(465, 63);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.PermitirEliminar = true;
            this.cmbProducto.PermitirLimpiar = true;
            this.cmbProducto.ReadOnly = false;
            this.cmbProducto.Size = new System.Drawing.Size(168, 21);
            this.cmbProducto.TabIndex = 4;
            this.cmbProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbProducto.TipoDatos = null;
            this.cmbProducto.CrearNuevo += new System.EventHandler(this.cmbProducto_CrearNuevo);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProducto.Location = new System.Drawing.Point(636, 63);
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
            this.txtFecha.Location = new System.Drawing.Point(119, 121);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.Value = null;
            // 
            // EditTratParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(701, 238);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.cmbPlaga);
            this.Controls.Add(this.btnBuscarPlaga);
            this.Controls.Add(this.cmbParcela);
            this.Controls.Add(this.btnBuscarParcela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.lblTratamiento);
            this.Controls.Add(this.txtTipoTratamiento);
            this.Controls.Add(this.lblSituacion);
            this.Controls.Add(this.txtSituacion);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.txtCaldo);
            this.Controls.Add(this.lblCaldo);
            this.Controls.Add(this.lblPlaga);
            this.Controls.Add(this.lblParcela);
            this.Name = "EditTratParcela";
            this.Text = "Tratamiento";
            this.Controls.SetChildIndex(this.lblParcela, 0);
            this.Controls.SetChildIndex(this.lblPlaga, 0);
            this.Controls.SetChildIndex(this.lblCaldo, 0);
            this.Controls.SetChildIndex(this.txtCaldo, 0);
            this.Controls.SetChildIndex(this.lblLitros, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblProducto, 0);
            this.Controls.SetChildIndex(this.txtSituacion, 0);
            this.Controls.SetChildIndex(this.lblSituacion, 0);
            this.Controls.SetChildIndex(this.txtTipoTratamiento, 0);
            this.Controls.SetChildIndex(this.lblTratamiento, 0);
            this.Controls.SetChildIndex(this.lblSuperficie, 0);
            this.Controls.SetChildIndex(this.txtSuperficie, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnBuscarParcela, 0);
            this.Controls.SetChildIndex(this.cmbParcela, 0);
            this.Controls.SetChildIndex(this.btnBuscarPlaga, 0);
            this.Controls.SetChildIndex(this.cmbPlaga, 0);
            this.Controls.SetChildIndex(this.btnBuscarProducto, 0);
            this.Controls.SetChildIndex(this.cmbProducto, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtTipoTratamiento;
        private System.Windows.Forms.Label lblSituacion;
        private System.Windows.Forms.TextBox txtSituacion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtCaldo;
        private System.Windows.Forms.Label lblCaldo;
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
