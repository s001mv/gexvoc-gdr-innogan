namespace GEXVOC.UI
{
    partial class EditCompra
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pnlMacho = new System.Windows.Forms.Panel();
            this.lblMacho = new System.Windows.Forms.Label();
            this.cmbMacho = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarMacho = new System.Windows.Forms.Button();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.cmbProducto = new GEXVOC.Core.Controles.ctlCombo();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblClasificacionCompra = new System.Windows.Forms.Label();
            this.chkPagado = new System.Windows.Forms.CheckBox();
            this.cmbClasificacionCompra = new System.Windows.Forms.ComboBox();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbFamilia = new GEXVOC.Core.Controles.ctlCombo();
            this.cmbProveedor = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlMacho.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(204, 102);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(20, 13);
            this.lblUnidad.TabIndex = 6;
            this.lblUnidad.Text = "Kg";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(124, 99);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(75, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(27, 102);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // pnlMacho
            // 
            this.pnlMacho.Controls.Add(this.lblMacho);
            this.pnlMacho.Controls.Add(this.cmbMacho);
            this.pnlMacho.Controls.Add(this.btnBuscarMacho);
            this.pnlMacho.Enabled = false;
            this.pnlMacho.Location = new System.Drawing.Point(25, 63);
            this.pnlMacho.Name = "pnlMacho";
            this.pnlMacho.Size = new System.Drawing.Size(407, 28);
            this.pnlMacho.TabIndex = 2;
            this.pnlMacho.Visible = false;
            // 
            // lblMacho
            // 
            this.lblMacho.AutoSize = true;
            this.lblMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacho.Location = new System.Drawing.Point(2, 8);
            this.lblMacho.Name = "lblMacho";
            this.lblMacho.Size = new System.Drawing.Size(49, 13);
            this.lblMacho.TabIndex = 3;
            this.lblMacho.Text = "Macho:";
            // 
            // cmbMacho
            // 
            this.cmbMacho.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMacho.btnBusqueda = this.btnBuscarMacho;
            this.cmbMacho.ClaseActiva = null;
            this.cmbMacho.ControlVisible = true;
            this.cmbMacho.DisplayMember = "Nombre";
            this.cmbMacho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMacho.FormattingEnabled = true;
            this.cmbMacho.IdClaseActiva = 0;
            this.cmbMacho.Location = new System.Drawing.Point(99, 5);
            this.cmbMacho.Name = "cmbMacho";
            this.cmbMacho.PermitirEliminar = true;
            this.cmbMacho.PermitirLimpiar = true;
            this.cmbMacho.ReadOnly = false;
            this.cmbMacho.Size = new System.Drawing.Size(270, 21);
            this.cmbMacho.TabIndex = 7;
            this.cmbMacho.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbMacho.TipoDatos = null;
            // 
            // btnBuscarMacho
            // 
            this.btnBuscarMacho.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarMacho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarMacho.Location = new System.Drawing.Point(375, 5);
            this.btnBuscarMacho.Name = "btnBuscarMacho";
            this.btnBuscarMacho.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarMacho.TabIndex = 0;
            this.btnBuscarMacho.UseVisualStyleBackColor = true;
            this.btnBuscarMacho.Click += new System.EventHandler(this.btnBuscarMacho_Click);
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.cmbProducto);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Location = new System.Drawing.Point(25, 63);
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
            this.cmbProducto.Location = new System.Drawing.Point(99, 4);
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
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilia.Location = new System.Drawing.Point(369, 42);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(42, 13);
            this.lblFamilia.TabIndex = 9;
            this.lblFamilia.Text = "Familia:";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(27, 42);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(84, 13);
            this.lblTipoProducto.TabIndex = 1;
            this.lblTipoProducto.Text = "Tipo de compra:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProveedor.Location = new System.Drawing.Point(27, 132);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 170;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSimbolo.Location = new System.Drawing.Point(435, 102);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(13, 13);
            this.lblSimbolo.TabIndex = 169;
            this.lblSimbolo.Text = "€";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(124, 156);
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
            this.lblConcepto.Location = new System.Drawing.Point(27, 159);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(56, 13);
            this.lblConcepto.TabIndex = 165;
            this.lblConcepto.Text = "Concepto:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(337, 99);
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
            this.lblImporte.Location = new System.Drawing.Point(254, 102);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(72, 13);
            this.lblImporte.TabIndex = 164;
            this.lblImporte.Text = "Importe Total:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(544, 74);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 163;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblClasificacionCompra
            // 
            this.lblClasificacionCompra.AutoSize = true;
            this.lblClasificacionCompra.Enabled = false;
            this.lblClasificacionCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacionCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClasificacionCompra.Location = new System.Drawing.Point(20, 7);
            this.lblClasificacionCompra.Name = "lblClasificacionCompra";
            this.lblClasificacionCompra.Size = new System.Drawing.Size(69, 13);
            this.lblClasificacionCompra.TabIndex = 161;
            this.lblClasificacionCompra.Text = "Clasificación:";
            this.lblClasificacionCompra.Visible = false;
            // 
            // chkPagado
            // 
            this.chkPagado.AutoSize = true;
            this.chkPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPagado.Location = new System.Drawing.Point(620, 208);
            this.chkPagado.Name = "chkPagado";
            this.chkPagado.Size = new System.Drawing.Size(69, 17);
            this.chkPagado.TabIndex = 8;
            this.chkPagado.Text = "Pagado";
            this.chkPagado.UseVisualStyleBackColor = true;
            // 
            // cmbClasificacionCompra
            // 
            this.cmbClasificacionCompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClasificacionCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClasificacionCompra.Enabled = false;
            this.cmbClasificacionCompra.FormattingEnabled = true;
            this.cmbClasificacionCompra.Location = new System.Drawing.Point(88, 4);
            this.cmbClasificacionCompra.Name = "cmbClasificacionCompra";
            this.cmbClasificacionCompra.Size = new System.Drawing.Size(197, 21);
            this.cmbClasificacionCompra.TabIndex = 7;
            this.cmbClasificacionCompra.Visible = false;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(124, 39);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(202, 21);
            this.cmbTipoProducto.TabIndex = 0;
            //this.cmbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProducto_SelectedIndexChanged);
            this.cmbTipoProducto.SelectedValueChanged += new System.EventHandler(this.cmbTipoProducto_SelectedValueChanged);
            this.cmbTipoProducto.TextUpdate += new System.EventHandler(this.cmbTipoProducto_TextUpdate);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(601, 69);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.Value = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbClasificacionCompra);
            this.panel1.Controls.Add(this.lblClasificacionCompra);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(246, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 49);
            this.panel1.TabIndex = 171;
            this.panel1.Visible = false;
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbFamilia.Enabled = false;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(433, 39);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(256, 21);
            this.cmbFamilia.TabIndex = 1;
            this.cmbFamilia.CargarContenido += new System.EventHandler(this.cmbFamilia_CargarContenido);
            this.cmbFamilia.SelectedValueChanged += new System.EventHandler(this.cmbFamilia_SelectedValueChanged);
            this.cmbFamilia.TextUpdate += new System.EventHandler(this.cmbFamilia_TextUpdate);
            this.cmbFamilia.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbFamilia_CrearNuevo);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(124, 129);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(270, 21);
            this.cmbProveedor.TabIndex = 6;
            this.cmbProveedor.CargarContenido += new System.EventHandler(this.cmbProveedor_CargarContenido);
            this.cmbProveedor.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbProveedor_CrearNuevo);
            // 
            // EditCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(716, 257);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.chkPagado);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblSimbolo);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.pnlMacho);
            this.Controls.Add(this.panel1);
            this.Name = "EditCompra";
            this.Text = "Compra";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditCompra_PropiedadAControl);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlMacho, 0);
            this.Controls.SetChildIndex(this.pnlProducto, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblImporte, 0);
            this.Controls.SetChildIndex(this.txtImporte, 0);
            this.Controls.SetChildIndex(this.lblConcepto, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.lblSimbolo, 0);
            this.Controls.SetChildIndex(this.lblProveedor, 0);
            this.Controls.SetChildIndex(this.lblTipoProducto, 0);
            this.Controls.SetChildIndex(this.chkPagado, 0);
            this.Controls.SetChildIndex(this.cmbTipoProducto, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.lblFamilia, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.lblUnidad, 0);
            this.Controls.SetChildIndex(this.cmbFamilia, 0);
            this.Controls.SetChildIndex(this.cmbProveedor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlMacho.ResumeLayout(false);
            this.pnlMacho.PerformLayout();
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblSimbolo;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblClasificacionCompra;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckBox chkPagado;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbMacho;
        private System.Windows.Forms.Button btnBuscarMacho;
        private System.Windows.Forms.ComboBox cmbClasificacionCompra;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Panel pnlMacho;
        private System.Windows.Forms.Label lblMacho;
        private System.Windows.Forms.Panel panel1;
        private GEXVOC.Core.Controles.ctlCombo cmbProducto;
        private GEXVOC.Core.Controles.ctlCombo cmbFamilia;
        private GEXVOC.Core.Controles.ctlCombo cmbProveedor;
    }
}
