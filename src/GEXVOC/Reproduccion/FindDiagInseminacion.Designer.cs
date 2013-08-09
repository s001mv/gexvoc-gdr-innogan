namespace GEXVOC.UI
{
    partial class FindDiagInseminacion
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
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblTipoDiagnostico = new System.Windows.Forms.Label();
            this.cmbTipoDiagnostico = new System.Windows.Forms.ComboBox();
            this.lblFechaDiagnostico = new System.Windows.Forms.Label();
            this.txtFechaDiagnostico = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFechaDiagnostico);
            this.pnlBusqueda.Controls.Add(this.cmbAnimal);
            this.pnlBusqueda.Controls.Add(this.btnBuscarAnimal);
            this.pnlBusqueda.Controls.Add(this.lblAnimal);
            this.pnlBusqueda.Controls.Add(this.lblTipoDiagnostico);
            this.pnlBusqueda.Controls.Add(this.cmbTipoDiagnostico);
            this.pnlBusqueda.Controls.Add(this.lblFechaDiagnostico);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 109);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 146);
            this.panel1.Size = new System.Drawing.Size(610, 272);
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAnimal.btnBusqueda = this.btnBuscarAnimal;
            this.cmbAnimal.ClaseActiva = null;
            this.cmbAnimal.ControlVisible = true;
            this.cmbAnimal.DisplayMember = "Fecha";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.IdClaseActiva = 0;
            this.cmbAnimal.Location = new System.Drawing.Point(112, 18);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(217, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(335, 18);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(46, 22);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(47, 13);
            this.lblAnimal.TabIndex = 139;
            this.lblAnimal.Text = "Hembra:";
            // 
            // lblTipoDiagnostico
            // 
            this.lblTipoDiagnostico.AutoSize = true;
            this.lblTipoDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipoDiagnostico.Location = new System.Drawing.Point(46, 48);
            this.lblTipoDiagnostico.Name = "lblTipoDiagnostico";
            this.lblTipoDiagnostico.Size = new System.Drawing.Size(31, 13);
            this.lblTipoDiagnostico.TabIndex = 137;
            this.lblTipoDiagnostico.Text = "Tipo:";
            // 
            // cmbTipoDiagnostico
            // 
            this.cmbTipoDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoDiagnostico.FormattingEnabled = true;
            this.cmbTipoDiagnostico.Location = new System.Drawing.Point(112, 45);
            this.cmbTipoDiagnostico.Name = "cmbTipoDiagnostico";
            this.cmbTipoDiagnostico.Size = new System.Drawing.Size(244, 21);
            this.cmbTipoDiagnostico.TabIndex = 2;
            // 
            // lblFechaDiagnostico
            // 
            this.lblFechaDiagnostico.AutoSize = true;
            this.lblFechaDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaDiagnostico.Location = new System.Drawing.Point(46, 74);
            this.lblFechaDiagnostico.Name = "lblFechaDiagnostico";
            this.lblFechaDiagnostico.Size = new System.Drawing.Size(40, 13);
            this.lblFechaDiagnostico.TabIndex = 138;
            this.lblFechaDiagnostico.Text = "Fecha:";
            // 
            // txtFechaDiagnostico
            // 
            this.txtFechaDiagnostico.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaDiagnostico.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaDiagnostico.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaDiagnostico.Location = new System.Drawing.Point(112, 72);
            this.txtFechaDiagnostico.Name = "txtFechaDiagnostico";
            this.txtFechaDiagnostico.ReadOnly = false;
            this.txtFechaDiagnostico.Size = new System.Drawing.Size(88, 20);
            this.txtFechaDiagnostico.TabIndex = 3;
            this.txtFechaDiagnostico.Value = null;
            // 
            // FindDiagInseminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 272);
            this.Name = "FindDiagInseminacion";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 109);
            this.Text = "Diagnósticos de Gestación";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblTipoDiagnostico;
        private System.Windows.Forms.ComboBox cmbTipoDiagnostico;
        private System.Windows.Forms.Label lblFechaDiagnostico;
        private GEXVOC.Core.Controles.ctlFecha txtFechaDiagnostico;
    }
}
