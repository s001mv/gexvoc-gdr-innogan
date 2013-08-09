namespace GEXVOC.UI
{
    partial class EditAbonado
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
            this.lblKg = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTipoAbono = new System.Windows.Forms.Label();
            this.lblFinca = new System.Windows.Forms.Label();
            this.cmbAbono = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAbono = new System.Windows.Forms.Button();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbParcela = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(348, 82);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 133;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKg.Location = new System.Drawing.Point(479, 52);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(42, 13);
            this.lblKg.TabIndex = 129;
            this.lblKg.Text = "Kgs/ha";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(415, 49);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(58, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCantidad.Location = new System.Drawing.Point(348, 52);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 132;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblTipoAbono
            // 
            this.lblTipoAbono.AutoSize = true;
            this.lblTipoAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoAbono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipoAbono.Location = new System.Drawing.Point(21, 52);
            this.lblTipoAbono.Name = "lblTipoAbono";
            this.lblTipoAbono.Size = new System.Drawing.Size(59, 13);
            this.lblTipoAbono.TabIndex = 131;
            this.lblTipoAbono.Text = "T.Abono:";
            // 
            // lblFinca
            // 
            this.lblFinca.AutoSize = true;
            this.lblFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFinca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFinca.Location = new System.Drawing.Point(21, 82);
            this.lblFinca.Name = "lblFinca";
            this.lblFinca.Size = new System.Drawing.Size(54, 13);
            this.lblFinca.TabIndex = 130;
            this.lblFinca.Text = "Parcela:";
            // 
            // cmbAbono
            // 
            this.cmbAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbAbono.btnBusqueda = this.btnBuscarAbono;
            this.cmbAbono.ClaseActiva = null;
            this.cmbAbono.ControlVisible = true;
            this.cmbAbono.DisplayMember = "Descripcion";
            this.cmbAbono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAbono.FormattingEnabled = true;
            this.cmbAbono.IdClaseActiva = 0;
            this.cmbAbono.Location = new System.Drawing.Point(81, 48);
            this.cmbAbono.Name = "cmbAbono";
            this.cmbAbono.PermitirEliminar = true;
            this.cmbAbono.PermitirLimpiar = true;
            this.cmbAbono.ReadOnly = false;
            this.cmbAbono.Size = new System.Drawing.Size(194, 21);
            this.cmbAbono.TabIndex = 0;
            this.cmbAbono.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAbono.TipoDatos = null;
            this.cmbAbono.CrearNuevo += new System.EventHandler(this.cmbAbono_CrearNuevo);
            // 
            // btnBuscarAbono
            // 
            this.btnBuscarAbono.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAbono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAbono.Location = new System.Drawing.Point(279, 48);
            this.btnBuscarAbono.Name = "btnBuscarAbono";
            this.btnBuscarAbono.Size = new System.Drawing.Size(25, 21);
            this.btnBuscarAbono.TabIndex = 1;
            this.btnBuscarAbono.UseVisualStyleBackColor = true;
            this.btnBuscarAbono.Click += new System.EventHandler(this.btnBuscarAbono_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(415, 79);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.Value = null;
            // 
            // cmbParcela
            // 
            this.cmbParcela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParcela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.Location = new System.Drawing.Point(81, 79);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.Size = new System.Drawing.Size(223, 21);
            this.cmbParcela.TabIndex = 3;
            this.cmbParcela.CargarContenido += new System.EventHandler(this.cmbParcela_CargarContenido);
            this.cmbParcela.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbParcela_CrearNuevo);
            // 
            // EditAbonado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(544, 152);
            this.Controls.Add(this.cmbParcela);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmbAbono);
            this.Controls.Add(this.btnBuscarAbono);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTipoAbono);
            this.Controls.Add(this.lblFinca);
            this.Name = "EditAbonado";
            this.Text = "Abonados";
            this.Controls.SetChildIndex(this.lblFinca, 0);
            this.Controls.SetChildIndex(this.lblTipoAbono, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.lblKg, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.btnBuscarAbono, 0);
            this.Controls.SetChildIndex(this.cmbAbono, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.cmbParcela, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTipoAbono;
        private System.Windows.Forms.Label lblFinca;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAbono;
        private System.Windows.Forms.Button btnBuscarAbono;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private GEXVOC.Core.Controles.ctlCombo cmbParcela;
    }
}
