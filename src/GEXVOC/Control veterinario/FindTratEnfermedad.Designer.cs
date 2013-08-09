namespace GEXVOC.UI
{
    partial class FindTratEnfermedad
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
            this.pnlBusqueda.Controls.Add(this.btnBuscarAnimal);
            this.pnlBusqueda.Controls.Add(this.cmbAnimal);
            this.pnlBusqueda.Controls.Add(this.lblFecInicio2);
            this.pnlBusqueda.Controls.Add(this.lblFecInicio);
            this.pnlBusqueda.Controls.Add(this.lblVaca);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 90);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Size = new System.Drawing.Size(610, 294);
            // 
            // lblFecInicio2
            // 
            this.lblFecInicio2.AutoSize = true;
            this.lblFecInicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecInicio2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio2.Location = new System.Drawing.Point(291, 57);
            this.lblFecInicio2.Name = "lblFecInicio2";
            this.lblFecInicio2.Size = new System.Drawing.Size(36, 13);
            this.lblFecInicio2.TabIndex = 120;
            this.lblFecInicio2.Text = "hasta:";
            // 
            // lblFecInicio
            // 
            this.lblFecInicio.AutoSize = true;
            this.lblFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio.Location = new System.Drawing.Point(57, 57);
            this.lblFecInicio.Name = "lblFecInicio";
            this.lblFecInicio.Size = new System.Drawing.Size(116, 13);
            this.lblFecInicio.TabIndex = 119;
            this.lblFecInicio.Text = "F. Tratamiento (desde):";
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaca.Location = new System.Drawing.Point(57, 31);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(41, 13);
            this.lblVaca.TabIndex = 116;
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
            this.cmbAnimal.Location = new System.Drawing.Point(179, 27);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(215, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(400, 27);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // txtFecIniMenor
            // 
            this.txtFecIniMenor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecIniMenor.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecIniMenor.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecIniMenor.Location = new System.Drawing.Point(179, 57);
            this.txtFecIniMenor.Name = "txtFecIniMenor";
            this.txtFecIniMenor.ReadOnly = false;
            this.txtFecIniMenor.Size = new System.Drawing.Size(88, 20);
            this.txtFecIniMenor.TabIndex = 2;
            this.txtFecIniMenor.Value = null;
            // 
            // txtFecIniMayor
            // 
            this.txtFecIniMayor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecIniMayor.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecIniMayor.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecIniMayor.Location = new System.Drawing.Point(333, 54);
            this.txtFecIniMayor.Name = "txtFecIniMayor";
            this.txtFecIniMayor.ReadOnly = false;
            this.txtFecIniMayor.Size = new System.Drawing.Size(88, 20);
            this.txtFecIniMayor.TabIndex = 3;
            this.txtFecIniMayor.Value = null;
            // 
            // FindTratEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 294);
            this.Name = "FindTratEnfermedad";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 90);
            this.Text = "Tratamientos";
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
        private GEXVOC.Core.Controles.ctlFecha txtFecIniMayor;
        private GEXVOC.Core.Controles.ctlFecha txtFecIniMenor;
    }
}
