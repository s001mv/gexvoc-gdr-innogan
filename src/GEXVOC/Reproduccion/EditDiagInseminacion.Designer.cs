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
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtFechaDiagnostico = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDiagnostico
            // 
            this.lblTipoDiagnostico.AutoSize = true;
            this.lblTipoDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipoDiagnostico.Location = new System.Drawing.Point(26, 87);
            this.lblTipoDiagnostico.Name = "lblTipoDiagnostico";
            this.lblTipoDiagnostico.Size = new System.Drawing.Size(31, 13);
            this.lblTipoDiagnostico.TabIndex = 119;
            this.lblTipoDiagnostico.Text = "Tipo:";
            // 
            // cmbTipoDiagnostico
            // 
            this.cmbTipoDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDiagnostico.FormattingEnabled = true;
            this.cmbTipoDiagnostico.Location = new System.Drawing.Point(101, 84);
            this.cmbTipoDiagnostico.Name = "cmbTipoDiagnostico";
            this.cmbTipoDiagnostico.Size = new System.Drawing.Size(311, 21);
            this.cmbTipoDiagnostico.TabIndex = 2;
            // 
            // chkResultado
            // 
            this.chkResultado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkResultado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkResultado.Image = global::GEXVOC.Properties.Resources.Negativo;
            this.chkResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkResultado.Location = new System.Drawing.Point(101, 142);
            this.chkResultado.Name = "chkResultado";
            this.chkResultado.Size = new System.Drawing.Size(88, 33);
            this.chkResultado.TabIndex = 5;
            this.chkResultado.Text = "Negativo";
            this.chkResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkResultado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkResultado.UseVisualStyleBackColor = true;
            this.chkResultado.CheckedChanged += new System.EventHandler(this.chkResultado_CheckedChanged);
            // 
            // lblFechaDiagnostico
            // 
            this.lblFechaDiagnostico.AutoSize = true;
            this.lblFechaDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaDiagnostico.Location = new System.Drawing.Point(26, 117);
            this.lblFechaDiagnostico.Name = "lblFechaDiagnostico";
            this.lblFechaDiagnostico.Size = new System.Drawing.Size(40, 13);
            this.lblFechaDiagnostico.TabIndex = 121;
            this.lblFechaDiagnostico.Text = "Fecha:";
            // 
            // txtDiasGestacion
            // 
            this.txtDiasGestacion.Location = new System.Drawing.Point(354, 114);
            this.txtDiasGestacion.MaxLength = 10;
            this.txtDiasGestacion.Name = "txtDiasGestacion";
            this.txtDiasGestacion.Size = new System.Drawing.Size(58, 20);
            this.txtDiasGestacion.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtDiasGestacion, "Días de Gestación");
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAnimal.btnBusqueda = this.btnBuscarAnimal;
            this.cmbAnimal.ClaseActiva = null;
            this.cmbAnimal.ControlVisible = true;
            this.cmbAnimal.DisplayMember = "Nombre";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.IdClaseActiva = 0;
            this.cmbAnimal.Location = new System.Drawing.Point(101, 57);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(284, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            this.cmbAnimal.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbAnimal_ClaseActivaChanged);
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(391, 57);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(26, 61);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(47, 13);
            this.lblAnimal.TabIndex = 129;
            this.lblAnimal.Text = "Hembra:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDias.Location = new System.Drawing.Point(195, 117);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(153, 13);
            this.lblDias.TabIndex = 130;
            this.lblDias.Text = "Días (estimados) en gestación:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(26, 152);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 131;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtFechaDiagnostico
            // 
            this.txtFechaDiagnostico.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaDiagnostico.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaDiagnostico.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaDiagnostico.Location = new System.Drawing.Point(101, 114);
            this.txtFechaDiagnostico.Name = "txtFechaDiagnostico";
            this.txtFechaDiagnostico.ReadOnly = false;
            this.txtFechaDiagnostico.Size = new System.Drawing.Size(88, 20);
            this.txtFechaDiagnostico.TabIndex = 3;
            this.txtFechaDiagnostico.Value = null;
            this.txtFechaDiagnostico.ValueChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlFechaEventArgs>(this.txtFechaDiagnostico_ValueChanged);
            // 
            // EditDiagInseminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 215);
            this.Controls.Add(this.txtFechaDiagnostico);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.txtDiasGestacion);
            this.Controls.Add(this.lblTipoDiagnostico);
            this.Controls.Add(this.cmbTipoDiagnostico);
            this.Controls.Add(this.lblFechaDiagnostico);
            this.Controls.Add(this.chkResultado);
            this.Name = "EditDiagInseminacion";
            this.Text = "Diagnóstico de Gestación";
            this.Controls.SetChildIndex(this.chkResultado, 0);
            this.Controls.SetChildIndex(this.lblFechaDiagnostico, 0);
            this.Controls.SetChildIndex(this.cmbTipoDiagnostico, 0);
            this.Controls.SetChildIndex(this.lblTipoDiagnostico, 0);
            this.Controls.SetChildIndex(this.txtDiasGestacion, 0);
            this.Controls.SetChildIndex(this.lblAnimal, 0);
            this.Controls.SetChildIndex(this.btnBuscarAnimal, 0);
            this.Controls.SetChildIndex(this.cmbAnimal, 0);
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
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblResultado;
        private GEXVOC.Core.Controles.ctlFecha txtFechaDiagnostico;
    }
}
