namespace GEXVOC.UI
{
    partial class FindHistMedicamento
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
            this.btnBuscarEnfermedad = new System.Windows.Forms.Button();
            this.cmbEnfermedad = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.btnBuscarMedicamento = new System.Windows.Forms.Button();
            this.cmbMedicamento = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.btnBuscarEnfermedad);
            this.pnlBusqueda.Controls.Add(this.cmbEnfermedad);
            this.pnlBusqueda.Controls.Add(this.lblEnfermedad);
            this.pnlBusqueda.Controls.Add(this.btnBuscarMedicamento);
            this.pnlBusqueda.Controls.Add(this.cmbMedicamento);
            this.pnlBusqueda.Controls.Add(this.lblMedicamento);
            this.pnlBusqueda.Controls.Add(this.cmbEspecie);
            this.pnlBusqueda.Controls.Add(this.label5);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 140);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 177);
            this.panel1.Size = new System.Drawing.Size(610, 241);
            // 
            // btnBuscarEnfermedad
            // 
            this.btnBuscarEnfermedad.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarEnfermedad.Location = new System.Drawing.Point(293, 67);
            this.btnBuscarEnfermedad.Name = "btnBuscarEnfermedad";
            this.btnBuscarEnfermedad.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarEnfermedad.TabIndex = 160;
            this.btnBuscarEnfermedad.UseVisualStyleBackColor = true;
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEnfermedad.btnBusqueda = this.btnBuscarEnfermedad;
            this.cmbEnfermedad.ClaseActiva = null;
            this.cmbEnfermedad.ControlVisible = true;
            this.cmbEnfermedad.DisplayMember = "Descripcion";
            this.cmbEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbEnfermedad.FormattingEnabled = true;
            this.cmbEnfermedad.Location = new System.Drawing.Point(119, 68);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.PermitirEliminar = true;
            this.cmbEnfermedad.PermitirLimpiar = true;
            this.cmbEnfermedad.ReadOnly = false;
            this.cmbEnfermedad.Size = new System.Drawing.Size(168, 21);
            this.cmbEnfermedad.TabIndex = 159;
            this.cmbEnfermedad.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEnfermedad.Location = new System.Drawing.Point(20, 71);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(67, 13);
            this.lblEnfermedad.TabIndex = 158;
            this.lblEnfermedad.Text = "Enfermedad:";
            // 
            // btnBuscarMedicamento
            // 
            this.btnBuscarMedicamento.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarMedicamento.Location = new System.Drawing.Point(293, 105);
            this.btnBuscarMedicamento.Name = "btnBuscarMedicamento";
            this.btnBuscarMedicamento.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarMedicamento.TabIndex = 156;
            this.btnBuscarMedicamento.UseVisualStyleBackColor = true;
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
            this.cmbMedicamento.Location = new System.Drawing.Point(119, 105);
            this.cmbMedicamento.Name = "cmbMedicamento";
            this.cmbMedicamento.PermitirEliminar = true;
            this.cmbMedicamento.PermitirLimpiar = true;
            this.cmbMedicamento.ReadOnly = false;
            this.cmbMedicamento.Size = new System.Drawing.Size(168, 21);
            this.cmbMedicamento.TabIndex = 155;
            this.cmbMedicamento.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMedicamento.Location = new System.Drawing.Point(20, 109);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(74, 13);
            this.lblMedicamento.TabIndex = 157;
            this.lblMedicamento.Text = "Medicamento:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(119, 30);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(81, 21);
            this.cmbEspecie.TabIndex = 153;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(20, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 154;
            this.label5.Text = "Especie:";
            // 
            // FindHistMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 241);
            this.Name = "FindHistMedicamento";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 140);
            this.Text = "Relación Enfermedades-Medicamentos";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarEnfermedad;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbEnfermedad;
        private System.Windows.Forms.Label lblEnfermedad;
        private System.Windows.Forms.Button btnBuscarMedicamento;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbMedicamento;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label label5;
    }
}
