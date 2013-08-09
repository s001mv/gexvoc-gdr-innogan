namespace GEXVOC.Informes
{
    partial class InfConsumos
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
            this.cmbRacion = new System.Windows.Forms.ComboBox();
            this.lblRacion = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblFFin = new System.Windows.Forms.Label();
            this.lblFInicio = new System.Windows.Forms.Label();
            this.txtFInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFFin = new GEXVOC.Core.Controles.ctlFecha();
            this.chkIC = new System.Windows.Forms.CheckBox();
            this.chkProduccionLeche = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRacion
            // 
            this.cmbRacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRacion.FormattingEnabled = true;
            this.cmbRacion.Location = new System.Drawing.Point(453, 7);
            this.cmbRacion.Name = "cmbRacion";
            this.cmbRacion.Size = new System.Drawing.Size(221, 21);
            this.cmbRacion.TabIndex = 4;
            // 
            // lblRacion
            // 
            this.lblRacion.AutoSize = true;
            this.lblRacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRacion.Location = new System.Drawing.Point(403, 11);
            this.lblRacion.Name = "lblRacion";
            this.lblRacion.Size = new System.Drawing.Size(44, 13);
            this.lblRacion.TabIndex = 147;
            this.lblRacion.Text = "Ración:";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(24, 10);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(41, 13);
            this.lblAnimal.TabIndex = 146;
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
            this.cmbAnimal.Location = new System.Drawing.Point(103, 7);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(212, 21);
            this.cmbAnimal.TabIndex = 2;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(325, 7);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 3;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click_1);
            // 
            // lblFFin
            // 
            this.lblFFin.AutoSize = true;
            this.lblFFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFFin.Location = new System.Drawing.Point(203, 48);
            this.lblFFin.Name = "lblFFin";
            this.lblFFin.Size = new System.Drawing.Size(15, 13);
            this.lblFFin.TabIndex = 154;
            this.lblFFin.Text = "al";
            // 
            // lblFInicio
            // 
            this.lblFInicio.AutoSize = true;
            this.lblFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFInicio.Location = new System.Drawing.Point(24, 48);
            this.lblFInicio.Name = "lblFInicio";
            this.lblFInicio.Size = new System.Drawing.Size(60, 13);
            this.lblFInicio.TabIndex = 153;
            this.lblFInicio.Text = "Periodo del";
            // 
            // txtFInicio
            // 
            this.txtFInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFInicio.Location = new System.Drawing.Point(103, 44);
            this.txtFInicio.Name = "txtFInicio";
            this.txtFInicio.ReadOnly = false;
            this.txtFInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFInicio.TabIndex = 5;
            this.txtFInicio.Value = null;
            // 
            // txtFFin
            // 
            this.txtFFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFFin.Location = new System.Drawing.Point(227, 44);
            this.txtFFin.Name = "txtFFin";
            this.txtFFin.ReadOnly = false;
            this.txtFFin.Size = new System.Drawing.Size(88, 20);
            this.txtFFin.TabIndex = 6;
            this.txtFFin.Value = null;
            // 
            // chkIC
            // 
            this.chkIC.AutoSize = true;
            this.chkIC.Checked = true;
            this.chkIC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIC.Location = new System.Drawing.Point(170, 15);
            this.chkIC.Name = "chkIC";
            this.chkIC.Size = new System.Drawing.Size(39, 17);
            this.chkIC.TabIndex = 155;
            this.chkIC.Text = "I.C";
            this.chkIC.UseVisualStyleBackColor = true;
            // 
            // chkProduccionLeche
            // 
            this.chkProduccionLeche.AutoSize = true;
            this.chkProduccionLeche.Checked = true;
            this.chkProduccionLeche.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProduccionLeche.Location = new System.Drawing.Point(47, 15);
            this.chkProduccionLeche.Name = "chkProduccionLeche";
            this.chkProduccionLeche.Size = new System.Drawing.Size(113, 17);
            this.chkProduccionLeche.TabIndex = 156;
            this.chkProduccionLeche.Text = "Producción Leche";
            this.chkProduccionLeche.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkProduccionLeche);
            this.groupBox1.Controls.Add(this.chkIC);
            this.groupBox1.Location = new System.Drawing.Point(406, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 34);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostar";
            // 
            // InfConsumos
            // 
            this.Controls.Add(this.txtFFin);
            this.Controls.Add(this.txtFInicio);
            this.Controls.Add(this.lblFFin);
            this.Controls.Add(this.lblFInicio);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.cmbRacion);
            this.Controls.Add(this.lblRacion);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.groupBox1);
            this.Name = "InfConsumos";
            this.Size = new System.Drawing.Size(684, 70);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRacion;
        private System.Windows.Forms.Label lblRacion;
        private System.Windows.Forms.Label lblAnimal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblFFin;
        private System.Windows.Forms.Label lblFInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFFin;
        private System.Windows.Forms.CheckBox chkIC;
        private System.Windows.Forms.CheckBox chkProduccionLeche;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
