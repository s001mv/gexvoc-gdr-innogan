namespace GEXVOC.UI
{
    partial class EditReceta
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
            this.btnBuscarTratamiento = new System.Windows.Forms.Button();
            this.cmbTratamiento = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.btnBuscarMedicamento = new System.Windows.Forms.Button();
            this.cmbMedicamento = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.lblDosis = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbMedicamentosSugeridos = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarTratamiento
            // 
            this.btnBuscarTratamiento.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarTratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarTratamiento.Location = new System.Drawing.Point(292, 47);
            this.btnBuscarTratamiento.Name = "btnBuscarTratamiento";
            this.btnBuscarTratamiento.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarTratamiento.TabIndex = 1;
            this.btnBuscarTratamiento.UseVisualStyleBackColor = true;
            // 
            // cmbTratamiento
            // 
            this.cmbTratamiento.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTratamiento.btnBusqueda = this.btnBuscarTratamiento;
            this.cmbTratamiento.ClaseActiva = null;
            this.cmbTratamiento.ControlVisible = true;
            this.cmbTratamiento.DisplayMember = "Descripcion";
            this.cmbTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTratamiento.FormattingEnabled = true;
            this.cmbTratamiento.IdClaseActiva = 0;
            this.cmbTratamiento.Location = new System.Drawing.Point(118, 47);
            this.cmbTratamiento.Name = "cmbTratamiento";
            this.cmbTratamiento.PermitirEliminar = true;
            this.cmbTratamiento.PermitirLimpiar = true;
            this.cmbTratamiento.ReadOnly = false;
            this.cmbTratamiento.Size = new System.Drawing.Size(168, 21);
            this.cmbTratamiento.TabIndex = 0;
            this.cmbTratamiento.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbTratamiento.TipoDatos = null;
            this.cmbTratamiento.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbTratamiento_ClaseActivaChanged);
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTratamiento.Location = new System.Drawing.Point(31, 51);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(66, 13);
            this.lblTratamiento.TabIndex = 126;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // btnBuscarMedicamento
            // 
            this.btnBuscarMedicamento.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarMedicamento.Location = new System.Drawing.Point(392, 74);
            this.btnBuscarMedicamento.Name = "btnBuscarMedicamento";
            this.btnBuscarMedicamento.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarMedicamento.TabIndex = 3;
            this.btnBuscarMedicamento.UseVisualStyleBackColor = true;
            this.btnBuscarMedicamento.Click += new System.EventHandler(this.btnBuscarMedicamento_Click);
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMedicamento.btnBusqueda = this.btnBuscarMedicamento;
            this.cmbMedicamento.ClaseActiva = null;
            this.cmbMedicamento.ControlVisible = true;
            this.cmbMedicamento.DisplayMember = "Descripcion";
            this.cmbMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.IdClaseActiva = 0;
            this.cmbMedicamento.Location = new System.Drawing.Point(118, 74);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.PermitirEliminar = true;
            this.cmbMedicamento.PermitirLimpiar = true;
            this.cmbMedicamento.ReadOnly = false;
            this.cmbMedicamento.Size = new System.Drawing.Size(268, 21);
            this.cmbMedicamento.TabIndex = 2;
            this.cmbMedicamento.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbMedicamento.TipoDatos = null;
            this.cmbMedicamento.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbMedicamento_ClaseActivaChanged);
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMedicamento.Location = new System.Drawing.Point(31, 78);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(74, 13);
            this.lblMedicamento.TabIndex = 129;
            this.lblMedicamento.Text = "Medicamento:";
            // 
            // txtDosis
            // 
            this.txtDosis.Location = new System.Drawing.Point(118, 156);
            this.txtDosis.MaxLength = 150;
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(359, 20);
            this.txtDosis.TabIndex = 7;
            // 
            // lblDosis
            // 
            this.lblDosis.AutoSize = true;
            this.lblDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDosis.Location = new System.Drawing.Point(31, 159);
            this.lblDosis.Name = "lblDosis";
            this.lblDosis.Size = new System.Drawing.Size(36, 13);
            this.lblDosis.TabIndex = 131;
            this.lblDosis.Text = "Dosis:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDuracion.Location = new System.Drawing.Point(31, 107);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(53, 13);
            this.lblDuracion.TabIndex = 133;
            this.lblDuracion.Text = "Duración:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(118, 104);
            this.txtDuracion.MaxLength = 10;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(88, 20);
            this.txtDuracion.TabIndex = 4;
            this.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(31, 133);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 135;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblImporte.Location = new System.Drawing.Point(323, 107);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 137;
            this.lblImporte.Text = "Importe:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(392, 104);
            this.txtImporte.MaxLength = 10;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(85, 20);
            this.txtImporte.TabIndex = 5;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(118, 130);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.Value = null;
            // 
            // cmbMedicamentosSugeridos
            // 
            this.cmbMedicamentosSugeridos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMedicamentosSugeridos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedicamentosSugeridos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbMedicamentosSugeridos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbMedicamentosSugeridos.FormattingEnabled = true;
            this.cmbMedicamentosSugeridos.Location = new System.Drawing.Point(118, 74);
            this.cmbMedicamentosSugeridos.Name = "cmbMedicamentosSugeridos";
            this.cmbMedicamentosSugeridos.Size = new System.Drawing.Size(268, 21);
            this.cmbMedicamentosSugeridos.TabIndex = 2;
            this.cmbMedicamentosSugeridos.CargarContenido += new System.EventHandler(this.cmbMedicamentosSugeridos_CargarContenido);
            this.cmbMedicamentosSugeridos.Validated += new System.EventHandler(this.cmbMedicamentosSugeridos_Validated);
            this.cmbMedicamentosSugeridos.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbMedicamentosSugeridos_CrearNuevo);
            // 
            // EditReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(556, 228);
            this.Controls.Add(this.cmbMedicamentosSugeridos);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblDosis);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.btnBuscarMedicamento);
            this.Controls.Add(this.cmbMedicamento);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.btnBuscarTratamiento);
            this.Controls.Add(this.cmbTratamiento);
            this.Controls.Add(this.lblTratamiento);
            this.Name = "EditReceta";
            this.Text = "Receta";
            this.Controls.SetChildIndex(this.lblTratamiento, 0);
            this.Controls.SetChildIndex(this.cmbTratamiento, 0);
            this.Controls.SetChildIndex(this.btnBuscarTratamiento, 0);
            this.Controls.SetChildIndex(this.lblMedicamento, 0);
            this.Controls.SetChildIndex(this.cmbMedicamento, 0);
            this.Controls.SetChildIndex(this.btnBuscarMedicamento, 0);
            this.Controls.SetChildIndex(this.txtDosis, 0);
            this.Controls.SetChildIndex(this.lblDosis, 0);
            this.Controls.SetChildIndex(this.txtDuracion, 0);
            this.Controls.SetChildIndex(this.lblDuracion, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.txtImporte, 0);
            this.Controls.SetChildIndex(this.lblImporte, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.cmbMedicamentosSugeridos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarTratamiento;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.Button btnBuscarMedicamento;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbMedicamento;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.Label lblDosis;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private GEXVOC.Core.Controles.ctlCombo cmbMedicamentosSugeridos;
    }
}
