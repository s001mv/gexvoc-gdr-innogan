namespace GEXVOC.UI
{
    partial class EditProducto
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblDiasCarne = new System.Windows.Forms.Label();
            this.txtSupresionCarne = new System.Windows.Forms.TextBox();
            this.lblSupresionCarne = new System.Windows.Forms.Label();
            this.lblDiasLeche = new System.Windows.Forms.Label();
            this.txtSupresionLeche = new System.Windows.Forms.TextBox();
            this.lblSupresionLeche = new System.Windows.Forms.Label();
            this.pnlMedicamento = new System.Windows.Forms.Panel();
            this.cmbFamilia = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlMedicamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(13, 70);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(74, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 70);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(324, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(13, 45);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(39, 13);
            this.lblFamilia.TabIndex = 10;
            this.lblFamilia.Text = "Familia";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(335, 31);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 13);
            this.lblTipo.TabIndex = 135;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Visible = false;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTipoProducto.btnBusqueda = null;
            this.cmbTipoProducto.ClaseActiva = null;
            this.cmbTipoProducto.ControlVisible = true;
            this.cmbTipoProducto.DisplayMember = "Descripcion";
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.IdClaseActiva = 0;
            this.cmbTipoProducto.Location = new System.Drawing.Point(377, 28);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.PermitirEliminar = true;
            this.cmbTipoProducto.PermitirLimpiar = true;
            this.cmbTipoProducto.ReadOnly = false;
            this.cmbTipoProducto.Size = new System.Drawing.Size(148, 21);
            this.cmbTipoProducto.TabIndex = 0;
            this.cmbTipoProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbTipoProducto.TipoDatos = null;
            this.cmbTipoProducto.Visible = false;
            this.cmbTipoProducto.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbTipoProducto_ClaseActivaChanged);
            // 
            // lblDiasCarne
            // 
            this.lblDiasCarne.AutoSize = true;
            this.lblDiasCarne.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiasCarne.Location = new System.Drawing.Point(440, 9);
            this.lblDiasCarne.Name = "lblDiasCarne";
            this.lblDiasCarne.Size = new System.Drawing.Size(28, 13);
            this.lblDiasCarne.TabIndex = 141;
            this.lblDiasCarne.Text = "días";
            // 
            // txtSupresionCarne
            // 
            this.txtSupresionCarne.Location = new System.Drawing.Point(369, 6);
            this.txtSupresionCarne.MaxLength = 20;
            this.txtSupresionCarne.Name = "txtSupresionCarne";
            this.txtSupresionCarne.Size = new System.Drawing.Size(66, 20);
            this.txtSupresionCarne.TabIndex = 1;
            // 
            // lblSupresionCarne
            // 
            this.lblSupresionCarne.AutoSize = true;
            this.lblSupresionCarne.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSupresionCarne.Location = new System.Drawing.Point(255, 9);
            this.lblSupresionCarne.Name = "lblSupresionCarne";
            this.lblSupresionCarne.Size = new System.Drawing.Size(102, 13);
            this.lblSupresionCarne.TabIndex = 139;
            this.lblSupresionCarne.Text = "Supresión de carne:";
            // 
            // lblDiasLeche
            // 
            this.lblDiasLeche.AutoSize = true;
            this.lblDiasLeche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiasLeche.Location = new System.Drawing.Point(180, 9);
            this.lblDiasLeche.Name = "lblDiasLeche";
            this.lblDiasLeche.Size = new System.Drawing.Size(28, 13);
            this.lblDiasLeche.TabIndex = 138;
            this.lblDiasLeche.Text = "días";
            // 
            // txtSupresionLeche
            // 
            this.txtSupresionLeche.Location = new System.Drawing.Point(111, 6);
            this.txtSupresionLeche.MaxLength = 20;
            this.txtSupresionLeche.Name = "txtSupresionLeche";
            this.txtSupresionLeche.Size = new System.Drawing.Size(66, 20);
            this.txtSupresionLeche.TabIndex = 0;
            this.txtSupresionLeche.TextChanged += new System.EventHandler(this.txtSupresionLeche_TextChanged);
            // 
            // lblSupresionLeche
            // 
            this.lblSupresionLeche.AutoSize = true;
            this.lblSupresionLeche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSupresionLeche.Location = new System.Drawing.Point(-3, 9);
            this.lblSupresionLeche.Name = "lblSupresionLeche";
            this.lblSupresionLeche.Size = new System.Drawing.Size(101, 13);
            this.lblSupresionLeche.TabIndex = 136;
            this.lblSupresionLeche.Text = "Supresión de leche:";
            // 
            // pnlMedicamento
            // 
            this.pnlMedicamento.Controls.Add(this.lblDiasCarne);
            this.pnlMedicamento.Controls.Add(this.txtSupresionCarne);
            this.pnlMedicamento.Controls.Add(this.lblSupresionCarne);
            this.pnlMedicamento.Controls.Add(this.lblDiasLeche);
            this.pnlMedicamento.Controls.Add(this.txtSupresionLeche);
            this.pnlMedicamento.Controls.Add(this.lblSupresionLeche);
            this.pnlMedicamento.Location = new System.Drawing.Point(12, 94);
            this.pnlMedicamento.Name = "pnlMedicamento";
            this.pnlMedicamento.Size = new System.Drawing.Size(481, 39);
            this.pnlMedicamento.TabIndex = 3;
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(123, 45);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(248, 21);
            this.cmbFamilia.TabIndex = 1;
            this.cmbFamilia.CargarContenido += new System.EventHandler(this.cmbFamilia_CargarContenido);
            this.cmbFamilia.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbFamilia_CrearNuevo);
            // 
            // EditProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(525, 160);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.pnlMedicamento);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "EditProducto";
            this.Text = "Producto";
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.lblFamilia, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.cmbTipoProducto, 0);
            this.Controls.SetChildIndex(this.pnlMedicamento, 0);
            this.Controls.SetChildIndex(this.cmbFamilia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlMedicamento.ResumeLayout(false);
            this.pnlMedicamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFamilia;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbTipoProducto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDiasCarne;
        private System.Windows.Forms.TextBox txtSupresionCarne;
        private System.Windows.Forms.Label lblSupresionCarne;
        private System.Windows.Forms.Label lblDiasLeche;
        private System.Windows.Forms.TextBox txtSupresionLeche;
        private System.Windows.Forms.Label lblSupresionLeche;
        private System.Windows.Forms.Panel pnlMedicamento;
        private GEXVOC.Core.Controles.ctlCombo cmbFamilia;
    }
}
