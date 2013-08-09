namespace GEXVOC.UI
{
    partial class EditVenta
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
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.chkCobrado = new System.Windows.Forms.CheckBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.cmbProducto = new GEXVOC.Core.Controles.ctlCombo();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbCliente = new GEXVOC.Core.Controles.ctlCombo();
            this.cmbFamilia = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(196, 98);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(20, 13);
            this.lblUnidad.TabIndex = 180;
            this.lblUnidad.Text = "Kg";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(116, 95);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(75, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilia.Location = new System.Drawing.Point(361, 38);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(42, 13);
            this.lblFamilia.TabIndex = 184;
            this.lblFamilia.Text = "Familia:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(19, 98);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 177;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(593, 65);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.Value = null;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(116, 35);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(202, 21);
            this.cmbTipoProducto.TabIndex = 0;
            this.cmbTipoProducto.SelectedValueChanged += new System.EventHandler(this.cmbTipoProducto_SelectedValueChanged);
            this.cmbTipoProducto.TextUpdate += new System.EventHandler(this.cmbTipoProducto_TextUpdate);
            // 
            // chkCobrado
            // 
            this.chkCobrado.AutoSize = true;
            this.chkCobrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCobrado.Location = new System.Drawing.Point(612, 204);
            this.chkCobrado.Name = "chkCobrado";
            this.chkCobrado.Size = new System.Drawing.Size(73, 17);
            this.chkCobrado.TabIndex = 8;
            this.chkCobrado.Text = "Cobrado";
            this.chkCobrado.UseVisualStyleBackColor = true;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(19, 38);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(84, 13);
            this.lblTipoProducto.TabIndex = 172;
            this.lblTipoProducto.Text = "Tipo de Ingreso:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCliente.Location = new System.Drawing.Point(19, 128);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 189;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSimbolo.Location = new System.Drawing.Point(427, 98);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(13, 13);
            this.lblSimbolo.TabIndex = 188;
            this.lblSimbolo.Text = "€";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(116, 152);
            this.txtConcepto.MaxLength = 255;
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(565, 46);
            this.txtConcepto.TabIndex = 7;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConcepto.Location = new System.Drawing.Point(19, 155);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(56, 13);
            this.lblConcepto.TabIndex = 187;
            this.lblConcepto.Text = "Concepto:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(329, 95);
            this.txtImporte.MaxLength = 20;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(95, 20);
            this.txtImporte.TabIndex = 5;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblImporte.Location = new System.Drawing.Point(246, 98);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(72, 13);
            this.lblImporte.TabIndex = 186;
            this.lblImporte.Text = "Importe Total:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(536, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 185;
            this.lblFecha.Text = "Fecha:";
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.cmbProducto);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Location = new System.Drawing.Point(17, 59);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(407, 28);
            this.pnlProducto.TabIndex = 2;
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(99, 3);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(270, 21);
            this.cmbProducto.TabIndex = 0;
            this.cmbProducto.CargarContenido += new System.EventHandler(this.cmbProducto_CargarContenido);
            this.cmbProducto.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbProducto_CrearNuevo);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(2, 8);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(62, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(115, 125);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(271, 21);
            this.cmbCliente.TabIndex = 6;
            this.cmbCliente.CargarContenido += new System.EventHandler(this.cmbCliente_CargarContenido);
            this.cmbCliente.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbCliente_CrearNuevo);
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbFamilia.Enabled = false;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(425, 35);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(256, 21);
            this.cmbFamilia.TabIndex = 1;
            this.cmbFamilia.CargarContenido += new System.EventHandler(this.cmbFamilia_CargarContenido);
            this.cmbFamilia.SelectedValueChanged += new System.EventHandler(this.cmbFamilia_SelectedValueChanged);
            this.cmbFamilia.TextUpdate += new System.EventHandler(this.cmbFamilia_TextUpdate);
            this.cmbFamilia.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbFamilia_CrearNuevo);
            // 
            // EditVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(703, 254);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.chkCobrado);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pnlProducto);
            this.Name = "EditVenta";
            this.Text = "Venta";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditVenta_PropiedadAControl);
            this.Controls.SetChildIndex(this.pnlProducto, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblImporte, 0);
            this.Controls.SetChildIndex(this.txtImporte, 0);
            this.Controls.SetChildIndex(this.lblConcepto, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.lblSimbolo, 0);
            this.Controls.SetChildIndex(this.lblCliente, 0);
            this.Controls.SetChildIndex(this.lblTipoProducto, 0);
            this.Controls.SetChildIndex(this.chkCobrado, 0);
            this.Controls.SetChildIndex(this.cmbTipoProducto, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.lblFamilia, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.lblUnidad, 0);
            this.Controls.SetChildIndex(this.cmbCliente, 0);
            this.Controls.SetChildIndex(this.cmbFamilia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Label lblCantidad;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.CheckBox chkCobrado;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Label lblProducto;
        private GEXVOC.Core.Controles.ctlCombo cmbCliente;
        private GEXVOC.Core.Controles.ctlCombo cmbProducto;
        private GEXVOC.Core.Controles.ctlCombo cmbFamilia;
    }
}
