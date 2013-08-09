namespace GEXVOC.UI
{
    partial class FindAnalisis
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoAnalisis = new System.Windows.Forms.ComboBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarLaboratorio = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecha);
            this.pnlBusqueda.Controls.Add(this.txtRegistro);
            this.pnlBusqueda.Controls.Add(this.lblRegistro);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.cmbLaboratorio);
            this.pnlBusqueda.Controls.Add(this.btnBuscarLaboratorio);
            this.pnlBusqueda.Controls.Add(this.lblLaboratorio);
            this.pnlBusqueda.Controls.Add(this.cmbAnimal);
            this.pnlBusqueda.Controls.Add(this.btnBuscarAnimal);
            this.pnlBusqueda.Controls.Add(this.lblAnimal);
            this.pnlBusqueda.Controls.Add(this.cmbTipoAnalisis);
            this.pnlBusqueda.Controls.Add(this.lblTipo);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 126);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 163);
            this.panel1.Size = new System.Drawing.Size(610, 255);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(37, 29);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(84, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo de Análisis:";
            // 
            // cmbTipoAnalisis
            // 
            this.cmbTipoAnalisis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoAnalisis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoAnalisis.FormattingEnabled = true;
            this.cmbTipoAnalisis.Location = new System.Drawing.Point(127, 26);
            this.cmbTipoAnalisis.Name = "cmbTipoAnalisis";
            this.cmbTipoAnalisis.Size = new System.Drawing.Size(165, 21);
            this.cmbTipoAnalisis.TabIndex = 1;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(37, 64);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(41, 13);
            this.lblAnimal.TabIndex = 2;
            this.lblAnimal.Text = "Animal:";
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
            this.cmbAnimal.Location = new System.Drawing.Point(124, 61);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(168, 21);
            this.cmbAnimal.TabIndex = 3;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(298, 61);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 4;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(37, 96);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(63, 13);
            this.lblLaboratorio.TabIndex = 57;
            this.lblLaboratorio.Text = "Laboratorio:";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.BackColor = System.Drawing.SystemColors.Control;
            this.cmbLaboratorio.btnBusqueda = this.btnBuscarLaboratorio;
            this.cmbLaboratorio.ClaseActiva = null;
            this.cmbLaboratorio.ControlVisible = true;
            this.cmbLaboratorio.DisplayMember = "Nombre";
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.IdClaseActiva = 0;
            this.cmbLaboratorio.Location = new System.Drawing.Point(124, 88);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.PermitirEliminar = true;
            this.cmbLaboratorio.PermitirLimpiar = true;
            this.cmbLaboratorio.ReadOnly = false;
            this.cmbLaboratorio.Size = new System.Drawing.Size(168, 21);
            this.cmbLaboratorio.TabIndex = 6;
            this.cmbLaboratorio.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbLaboratorio.TipoDatos = null;
            // 
            // btnBuscarLaboratorio
            // 
            this.btnBuscarLaboratorio.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarLaboratorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarLaboratorio.Location = new System.Drawing.Point(298, 87);
            this.btnBuscarLaboratorio.Name = "btnBuscarLaboratorio";
            this.btnBuscarLaboratorio.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarLaboratorio.TabIndex = 7;
            this.btnBuscarLaboratorio.UseVisualStyleBackColor = true;
            this.btnBuscarLaboratorio.Click += new System.EventHandler(this.btnBuscarLaboratorio_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(348, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 60;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(348, 64);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(49, 13);
            this.lblRegistro.TabIndex = 62;
            this.lblRegistro.Text = "Registro:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(406, 61);
            this.txtRegistro.MaxLength = 5;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(406, 26);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.Value = null;
            // 
            // FindAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 255);
            this.Name = "FindAnalisis";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 126);
            this.Text = "Análisis";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ComboBox cmbTipoAnalisis;
        private System.Windows.Forms.Label lblTipo;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label lblFecha;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLaboratorio;
        private System.Windows.Forms.Button btnBuscarLaboratorio;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
