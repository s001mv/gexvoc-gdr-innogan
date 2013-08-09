namespace GEXVOC.UI
{
    partial class EditDiagInseminacion
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
            this.lblTipoDiagnostico = new System.Windows.Forms.Label();
            this.cmbTipoDiagnostico = new System.Windows.Forms.ComboBox();
            this.chkResultado = new System.Windows.Forms.CheckBox();
            this.lblFechaDiagnostico = new System.Windows.Forms.Label();
            this.txtDiasGestacion = new System.Windows.Forms.TextBox();
            this.cmbInseminacion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarInseminacion = new System.Windows.Forms.Button();
            this.lblInseminacion = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtFechaDiagnostico = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDiagnostico
            // 
            this.lblTipoDiagnostico.AutoSize = true;
            this.lblTipoDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipoDiagnostico.Location = new System.Drawing.Point(26, 87);
            this.lblTipoDiagnostico.Name = "lblTipoDiagnostico";
            this.lblTipoDiagnostico.Size = new System.Drawing.Size(36, 13);
            this.lblTipoDiagnostico.TabIndex = 119;
            this.lblTipoDiagnostico.Text = "Tipo:";
            // 
            // cmbTipoDiagnostico
            // 
            this.cmbTipoDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDiagnostico.FormattingEnabled = true;
            this.cmbTipoDiagnostico.Location = new System.Drawing.Point(122, 84);
            this.cmbTipoDiagnostico.Name = "cmbTipoDiagnostico";
            this.cmbTipoDiagnostico.Size = new System.Drawing.Size(239, 21);
            this.cmbTipoDiagnostico.TabIndex = 2;
            // 
            // chkResultado
            // 
            this.chkResultado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkResultado.Location = new System.Drawing.Point(345, 112);
            this.chkResultado.Name = "chkResultado";
            this.chkResultado.Size = new System.Drawing.Size(16, 24);
            this.chkResultado.TabIndex = 4;
            this.chkResultado.UseVisualStyleBackColor = true;
            // 
            // lblFechaDiagnostico
            // 
            this.lblFechaDiagnostico.AutoSize = true;
            this.lblFechaDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaDiagnostico.Location = new System.Drawing.Point(26, 112);
            this.lblFechaDiagnostico.Name = "lblFechaDiagnostico";
            this.lblFechaDiagnostico.Size = new System.Drawing.Size(46, 13);
            this.lblFechaDiagnostico.TabIndex = 121;
            this.lblFechaDiagnostico.Text = "Fecha:";
            // 
            // txtDiasGestacion
            // 
            this.txtDiasGestacion.Location = new System.Drawing.Point(224, 140);
            this.txtDiasGestacion.MaxLength = 10;
            this.txtDiasGestacion.Name = "txtDiasGestacion";
            this.txtDiasGestacion.Size = new System.Drawing.Size(77, 20);
            this.txtDiasGestacion.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDiasGestacion, "Días de Gestación");
            // 
            // cmbInseminacion
            // 
            this.cmbInseminacion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbInseminacion.btnBusqueda = this.btnBuscarInseminacion;
            this.cmbInseminacion.ClaseActiva = null;
            this.cmbInseminacion.ControlVisible = true;
            this.cmbInseminacion.DisplayMember = "Fecha";
            this.cmbInseminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbInseminacion.FormattingEnabled = true;
            this.cmbInseminacion.IdClaseActiva = 0;
            this.cmbInseminacion.Location = new System.Drawing.Point(122, 57);
            this.cmbInseminacion.Name = "cmbInseminacion";
            this.cmbInseminacion.PermitirEliminar = true;
            this.cmbInseminacion.PermitirLimpiar = true;
            this.cmbInseminacion.ReadOnly = false;
            this.cmbInseminacion.Size = new System.Drawing.Size(168, 21);
            this.cmbInseminacion.TabIndex = 0;
            this.cmbInseminacion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbInseminacion.TipoDatos = null;
            // 
            // btnBuscarInseminacion
            // 
            this.btnBuscarInseminacion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarInseminacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarInseminacion.Location = new System.Drawing.Point(304, 57);
            this.btnBuscarInseminacion.Name = "btnBuscarInseminacion";
            this.btnBuscarInseminacion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarInseminacion.TabIndex = 1;
            this.btnBuscarInseminacion.UseVisualStyleBackColor = true;
            // 
            // lblInseminacion
            // 
            this.lblInseminacion.AutoSize = true;
            this.lblInseminacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInseminacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInseminacion.Location = new System.Drawing.Point(26, 61);
            this.lblInseminacion.Name = "lblInseminacion";
            this.lblInseminacion.Size = new System.Drawing.Size(85, 13);
            this.lblInseminacion.TabIndex = 129;
            this.lblInseminacion.Text = "Inseminación:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDias.Location = new System.Drawing.Point(26, 143);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(183, 13);
            this.lblDias.TabIndex = 130;
            this.lblDias.Text = "Días (estimados) en gestación:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(281, 117);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 131;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtFechaDiagnostico
            // 
            this.txtFechaDiagnostico.HidePromptOnLeave = true;
            this.txtFechaDiagnostico.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFechaDiagnostico.Location = new System.Drawing.Point(122, 114);
            this.txtFechaDiagnostico.Mask = "00/00/0099";
            this.txtFechaDiagnostico.Name = "txtFechaDiagnostico";
            this.txtFechaDiagnostico.Size = new System.Drawing.Size(67, 20);
            this.txtFechaDiagnostico.TabIndex = 3;
            this.txtFechaDiagnostico.ValidatingType = typeof(System.DateTime);
            // 
            // EditDiagInseminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(439, 220);
            this.Controls.Add(this.txtFechaDiagnostico);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.cmbInseminacion);
            this.Controls.Add(this.btnBuscarInseminacion);
            this.Controls.Add(this.lblInseminacion);
            this.Controls.Add(this.txtDiasGestacion);
            this.Controls.Add(this.lblTipoDiagnostico);
            this.Controls.Add(this.cmbTipoDiagnostico);
            this.Controls.Add(this.lblFechaDiagnostico);
            this.Controls.Add(this.chkResultado);
            this.Name = "EditDiagInseminacion";
            this.Text = "Diagnóstico Inseminación";
            this.Controls.SetChildIndex(this.chkResultado, 0);
            this.Controls.SetChildIndex(this.lblFechaDiagnostico, 0);
            this.Controls.SetChildIndex(this.cmbTipoDiagnostico, 0);
            this.Controls.SetChildIndex(this.lblTipoDiagnostico, 0);
            this.Controls.SetChildIndex(this.txtDiasGestacion, 0);
            this.Controls.SetChildIndex(this.lblInseminacion, 0);
            this.Controls.SetChildIndex(this.btnBuscarInseminacion, 0);
            this.Controls.SetChildIndex(this.cmbInseminacion, 0);
            this.Controls.SetChildIndex(this.lblDias, 0);
            this.Controls.SetChildIndex(this.lblResultado, 0);
            this.Controls.SetChildIndex(this.txtFechaDiagnostico, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDiagnostico;
        private System.Windows.Forms.ComboBox cmbTipoDiagnostico;
        private System.Windows.Forms.CheckBox chkResultado;
        private System.Windows.Forms.Label lblFechaDiagnostico;
        private System.Windows.Forms.TextBox txtDiasGestacion;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbInseminacion;
        private System.Windows.Forms.Button btnBuscarInseminacion;
        private System.Windows.Forms.Label lblInseminacion;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.MaskedTextBox txtFechaDiagnostico;
    }
}
