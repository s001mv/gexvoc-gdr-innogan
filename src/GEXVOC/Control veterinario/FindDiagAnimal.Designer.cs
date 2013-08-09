namespace GEXVOC.UI
{
    partial class FindDiagAnimal
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
            this.lblFecInicio2 = new System.Windows.Forms.Label();
            this.lblFecInicio = new System.Windows.Forms.Label();
            this.lblVaca = new System.Windows.Forms.Label();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.btnBuscarEnfermedad = new System.Windows.Forms.Button();
            this.cmbEnfermedad = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.txtFecIniMenor = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFecIniMayor = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecIniMayor);
            this.pnlBusqueda.Controls.Add(this.txtFecIniMenor);
            this.pnlBusqueda.Controls.Add(this.btnBuscarEnfermedad);
            this.pnlBusqueda.Controls.Add(this.cmbEnfermedad);
            this.pnlBusqueda.Controls.Add(this.lblEnfermedad);
            this.pnlBusqueda.Controls.Add(this.btnBuscarAnimal);
            this.pnlBusqueda.Controls.Add(this.cmbAnimal);
            this.pnlBusqueda.Controls.Add(this.lblFecInicio2);
            this.pnlBusqueda.Controls.Add(this.lblFecInicio);
            this.pnlBusqueda.Controls.Add(this.lblVaca);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 113);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Size = new System.Drawing.Size(610, 273);
            // 
            // lblFecInicio2
            // 
            this.lblFecInicio2.AutoSize = true;
            this.lblFecInicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecInicio2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio2.Location = new System.Drawing.Point(272, 79);
            this.lblFecInicio2.Name = "lblFecInicio2";
            this.lblFecInicio2.Size = new System.Drawing.Size(36, 13);
            this.lblFecInicio2.TabIndex = 119;
            this.lblFecInicio2.Text = "hasta:";
            // 
            // lblFecInicio
            // 
            this.lblFecInicio.AutoSize = true;
            this.lblFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio.Location = new System.Drawing.Point(38, 79);
            this.lblFecInicio.Name = "lblFecInicio";
            this.lblFecInicio.Size = new System.Drawing.Size(116, 13);
            this.lblFecInicio.TabIndex = 118;
            this.lblFecInicio.Text = "F. Diagnóstico (desde):";
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaca.Location = new System.Drawing.Point(38, 27);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(41, 13);
            this.lblVaca.TabIndex = 117;
            this.lblVaca.Text = "Animal:";
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
            this.cmbAnimal.Location = new System.Drawing.Point(160, 23);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(205, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(381, 23);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // btnBuscarEnfermedad
            // 
            this.btnBuscarEnfermedad.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarEnfermedad.Location = new System.Drawing.Point(381, 50);
            this.btnBuscarEnfermedad.Name = "btnBuscarEnfermedad";
            this.btnBuscarEnfermedad.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarEnfermedad.TabIndex = 3;
            this.btnBuscarEnfermedad.UseVisualStyleBackColor = true;
            this.btnBuscarEnfermedad.Click += new System.EventHandler(this.btnBuscarEnfermedad_Click);
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
            this.cmbEnfermedad.IdClaseActiva = 0;
            this.cmbEnfermedad.Location = new System.Drawing.Point(160, 50);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.PermitirEliminar = true;
            this.cmbEnfermedad.PermitirLimpiar = true;
            this.cmbEnfermedad.ReadOnly = false;
            this.cmbEnfermedad.Size = new System.Drawing.Size(205, 21);
            this.cmbEnfermedad.TabIndex = 2;
            this.cmbEnfermedad.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbEnfermedad.TipoDatos = null;
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEnfermedad.Location = new System.Drawing.Point(38, 53);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(67, 13);
            this.lblEnfermedad.TabIndex = 146;
            this.lblEnfermedad.Text = "Enfermedad:";
            // 
            // txtFecIniMenor
            // 
            this.txtFecIniMenor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecIniMenor.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecIniMenor.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecIniMenor.Location = new System.Drawing.Point(160, 79);
            this.txtFecIniMenor.Name = "txtFecIniMenor";
            this.txtFecIniMenor.ReadOnly = false;
            this.txtFecIniMenor.Size = new System.Drawing.Size(88, 20);
            this.txtFecIniMenor.TabIndex = 4;
            this.txtFecIniMenor.Value = null;
            // 
            // txtFecIniMayor
            // 
            this.txtFecIniMayor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecIniMayor.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecIniMayor.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecIniMayor.Location = new System.Drawing.Point(314, 77);
            this.txtFecIniMayor.Name = "txtFecIniMayor";
            this.txtFecIniMayor.ReadOnly = false;
            this.txtFecIniMayor.Size = new System.Drawing.Size(88, 20);
            this.txtFecIniMayor.TabIndex = 5;
            this.txtFecIniMayor.Value = null;
            // 
            // FindDiagAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 273);
            this.Name = "FindDiagAnimal";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 113);
            this.Text = "Diagnósticos";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecInicio2;
        private System.Windows.Forms.Label lblFecInicio;
        private System.Windows.Forms.Label lblVaca;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Button btnBuscarEnfermedad;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbEnfermedad;
        private System.Windows.Forms.Label lblEnfermedad;
        private GEXVOC.Core.Controles.ctlFecha txtFecIniMayor;
        private GEXVOC.Core.Controles.ctlFecha txtFecIniMenor;
    }
}
