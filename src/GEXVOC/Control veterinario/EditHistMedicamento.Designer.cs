namespace GEXVOC.UI
{
    partial class EditHistMedicamento
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
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.btnBuscarMedicamento = new System.Windows.Forms.Button();
            this.cmbMedicamento = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.btnBuscarEnfermedad = new System.Windows.Forms.Button();
            this.cmbEnfermedad = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(130, 48);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(81, 21);
            this.cmbEspecie.TabIndex = 145;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEspecie.Location = new System.Drawing.Point(31, 51);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 146;
            this.lblEspecie.Text = "Especie:";
            // 
            // btnBuscarMedicamento
            // 
            this.btnBuscarMedicamento.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarMedicamento.Location = new System.Drawing.Point(304, 123);
            this.btnBuscarMedicamento.Name = "btnBuscarMedicamento";
            this.btnBuscarMedicamento.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarMedicamento.TabIndex = 148;
            this.btnBuscarMedicamento.UseVisualStyleBackColor = true;
            this.btnBuscarMedicamento.Click += new System.EventHandler(this.btnBuscarMedicamento_Click);
            // 
            // cmbMedicamento
            // 
            this.cmbMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbMedicamento.btnBusqueda = this.btnBuscarMedicamento;
            this.cmbMedicamento.ClaseActiva = null;
            this.cmbMedicamento.ControlVisible = true;
            this.cmbMedicamento.DisplayMember = "Descripcion";
            this.cmbMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMedicamento.FormattingEnabled = true;
            this.cmbMedicamento.IdClaseActiva = 0;
            this.cmbMedicamento.Location = new System.Drawing.Point(130, 123);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.PermitirEliminar = true;
            this.cmbMedicamento.PermitirLimpiar = true;
            this.cmbMedicamento.ReadOnly = false;
            this.cmbMedicamento.Size = new System.Drawing.Size(168, 21);
            this.cmbMedicamento.TabIndex = 147;
            this.cmbMedicamento.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbMedicamento.TipoDatos = null;
            this.cmbMedicamento.CrearNuevo += new System.EventHandler(this.cmbMedicamento_CrearNuevo);
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMedicamento.Location = new System.Drawing.Point(31, 127);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(74, 13);
            this.lblMedicamento.TabIndex = 149;
            this.lblMedicamento.Text = "Medicamento:";
            // 
            // btnBuscarEnfermedad
            // 
            this.btnBuscarEnfermedad.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarEnfermedad.Location = new System.Drawing.Point(304, 85);
            this.btnBuscarEnfermedad.Name = "btnBuscarEnfermedad";
            this.btnBuscarEnfermedad.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarEnfermedad.TabIndex = 152;
            this.btnBuscarEnfermedad.UseVisualStyleBackColor = true;
            this.btnBuscarEnfermedad.Click += new System.EventHandler(this.btnBuscarEnfermedad_Click);
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbEnfermedad.btnBusqueda = this.btnBuscarEnfermedad;
            this.cmbEnfermedad.ClaseActiva = null;
            this.cmbEnfermedad.ControlVisible = true;
            this.cmbEnfermedad.DisplayMember = "Descripcion";
            this.cmbEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbEnfermedad.FormattingEnabled = true;
            this.cmbEnfermedad.IdClaseActiva = 0;
            this.cmbEnfermedad.Location = new System.Drawing.Point(130, 86);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.PermitirEliminar = true;
            this.cmbEnfermedad.PermitirLimpiar = true;
            this.cmbEnfermedad.ReadOnly = false;
            this.cmbEnfermedad.Size = new System.Drawing.Size(168, 21);
            this.cmbEnfermedad.TabIndex = 151;
            this.cmbEnfermedad.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbEnfermedad.TipoDatos = null;
            this.cmbEnfermedad.CrearNuevo += new System.EventHandler(this.cmbEnfermedad_CrearNuevo);
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEnfermedad.Location = new System.Drawing.Point(31, 89);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(67, 13);
            this.lblEnfermedad.TabIndex = 150;
            this.lblEnfermedad.Text = "Enfermedad:";
            // 
            // EditHistMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 208);
            this.Controls.Add(this.btnBuscarEnfermedad);
            this.Controls.Add(this.cmbEnfermedad);
            this.Controls.Add(this.lblEnfermedad);
            this.Controls.Add(this.btnBuscarMedicamento);
            this.Controls.Add(this.cmbMedicamento);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.lblEspecie);
            this.Name = "EditHistMedicamento";
            this.Text = "Relación Enfermedad - Medicamento (por Especie)";
            this.Controls.SetChildIndex(this.lblEspecie, 0);
            this.Controls.SetChildIndex(this.cmbEspecie, 0);
            this.Controls.SetChildIndex(this.lblMedicamento, 0);
            this.Controls.SetChildIndex(this.cmbMedicamento, 0);
            this.Controls.SetChildIndex(this.btnBuscarMedicamento, 0);
            this.Controls.SetChildIndex(this.lblEnfermedad, 0);
            this.Controls.SetChildIndex(this.cmbEnfermedad, 0);
            this.Controls.SetChildIndex(this.btnBuscarEnfermedad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Button btnBuscarMedicamento;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbMedicamento;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.Button btnBuscarEnfermedad;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbEnfermedad;
        private System.Windows.Forms.Label lblEnfermedad;
    }
}
