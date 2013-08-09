﻿namespace GEXVOC.UI
{
    partial class FindCompra
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.txtFechaDesde = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaHasta = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.cmbProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbPagada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbPagada);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.btnBuscarProducto);
            this.pnlBusqueda.Controls.Add(this.cmbProducto);
            this.pnlBusqueda.Controls.Add(this.lblProducto);
            this.pnlBusqueda.Controls.Add(this.txtCantidad);
            this.pnlBusqueda.Controls.Add(this.lblCantidad);
            this.pnlBusqueda.Controls.Add(this.txtImporte);
            this.pnlBusqueda.Controls.Add(this.lblImporte);
            this.pnlBusqueda.Controls.Add(this.cmbProveedor);
            this.pnlBusqueda.Controls.Add(this.lblProveedor);
            this.pnlBusqueda.Controls.Add(this.txtConcepto);
            this.pnlBusqueda.Controls.Add(this.lblConcepto);
            this.pnlBusqueda.Controls.Add(this.txtFechaHasta);
            this.pnlBusqueda.Controls.Add(this.txtFechaDesde);
            this.pnlBusqueda.Controls.Add(this.lblFechaHasta);
            this.pnlBusqueda.Controls.Add(this.cmbTipoProducto);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.lblTipo);
            this.pnlBusqueda.Size = new System.Drawing.Size(671, 133);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 170);
            this.panel1.Size = new System.Drawing.Size(671, 248);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(340, 79);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 13);
            this.lblFecha.TabIndex = 131;
            this.lblFecha.Text = "Fecha (desde):";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(9, 23);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(85, 13);
            this.lblTipo.TabIndex = 129;
            this.lblTipo.Text = "Tipo de Compra:";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(94, 20);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(275, 21);
            this.cmbTipoProducto.TabIndex = 0;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(526, 78);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaHasta.TabIndex = 135;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaDesde.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaDesde.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaDesde.Location = new System.Drawing.Point(424, 74);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.ReadOnly = false;
            this.txtFechaDesde.Size = new System.Drawing.Size(88, 20);
            this.txtFechaDesde.TabIndex = 7;
            this.txtFechaDesde.Value = null;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaHasta.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaHasta.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaHasta.Location = new System.Drawing.Point(570, 73);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.ReadOnly = false;
            this.txtFechaHasta.Size = new System.Drawing.Size(88, 20);
            this.txtFechaHasta.TabIndex = 8;
            this.txtFechaHasta.Value = null;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(93, 73);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(228, 21);
            this.cmbProveedor.TabIndex = 6;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProveedor.Location = new System.Drawing.Point(9, 78);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 174;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(93, 102);
            this.txtConcepto.MaxLength = 255;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(565, 20);
            this.txtConcepto.TabIndex = 9;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConcepto.Location = new System.Drawing.Point(9, 105);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(56, 13);
            this.lblConcepto.TabIndex = 173;
            this.lblConcepto.Text = "Concepto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(445, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(390, 22);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 176;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(590, 19);
            this.txtImporte.MaxLength = 20;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(68, 20);
            this.txtImporte.TabIndex = 2;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblImporte.Location = new System.Drawing.Point(539, 22);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 179;
            this.lblImporte.Text = "Importe:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProducto.Location = new System.Drawing.Point(348, 47);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarProducto.TabIndex = 4;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.SystemColors.Control;
            this.cmbProducto.btnBusqueda = this.btnBuscarProducto;
            this.cmbProducto.ClaseActiva = null;
            this.cmbProducto.ControlVisible = true;
            this.cmbProducto.DisplayMember = "DescAmpliada";
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IdClaseActiva = 0;
            this.cmbProducto.Location = new System.Drawing.Point(93, 47);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.PermitirEliminar = true;
            this.cmbProducto.PermitirLimpiar = true;
            this.cmbProducto.ReadOnly = false;
            this.cmbProducto.Size = new System.Drawing.Size(248, 21);
            this.cmbProducto.TabIndex = 3;
            this.cmbProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbProducto.TipoDatos = null;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(9, 50);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 182;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbPagada
            // 
            this.cmbPagada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPagada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPagada.FormattingEnabled = true;
            this.cmbPagada.Location = new System.Drawing.Point(445, 45);
            this.cmbPagada.Name = "cmbPagada";
            this.cmbPagada.Size = new System.Drawing.Size(67, 21);
            this.cmbPagada.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(392, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 184;
            this.label1.Text = "Pagado:";
            // 
            // FindCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(688, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(671, 248);
            this.Name = "FindCompra";
            this.pnlBusquedaTamano = new System.Drawing.Size(671, 133);
            this.Text = "Compras";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label lblFechaHasta;
        private GEXVOC.Core.Controles.ctlFecha txtFechaHasta;
        private GEXVOC.Core.Controles.ctlFecha txtFechaDesde;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Button btnBuscarProducto;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbPagada;
        private System.Windows.Forms.Label label1;
    }
}