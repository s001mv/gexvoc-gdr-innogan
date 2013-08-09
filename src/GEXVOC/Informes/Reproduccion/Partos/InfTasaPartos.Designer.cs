namespace GEXVOC.Informes
{
    partial class InfTasaPartos
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
            this.txtFFin = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFFin = new System.Windows.Forms.Label();
            this.lblFInicio = new System.Windows.Forms.Label();
            this.lblEInicio = new System.Windows.Forms.Label();
            this.lblEFin = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtEInicio = new System.Windows.Forms.TextBox();
            this.txtEFin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(110, 20);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(88, 21);
            this.cmbEspecie.TabIndex = 145;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEspecie.Location = new System.Drawing.Point(33, 23);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(56, 13);
            this.lblEspecie.TabIndex = 146;
            this.lblEspecie.Text = "Especie:";
            // 
            // txtFFin
            // 
            this.txtFFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFFin.Location = new System.Drawing.Point(235, 47);
            this.txtFFin.Name = "txtFFin";
            this.txtFFin.ReadOnly = false;
            this.txtFFin.Size = new System.Drawing.Size(88, 20);
            this.txtFFin.TabIndex = 147;
            this.txtFFin.Value = null;
            // 
            // txtFInicio
            // 
            this.txtFInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFInicio.Location = new System.Drawing.Point(110, 47);
            this.txtFInicio.Name = "txtFInicio";
            this.txtFInicio.ReadOnly = false;
            this.txtFInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFInicio.TabIndex = 146;
            this.txtFInicio.Value = null;
            // 
            // lblFFin
            // 
            this.lblFFin.AutoSize = true;
            this.lblFFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFFin.Location = new System.Drawing.Point(208, 50);
            this.lblFFin.Name = "lblFFin";
            this.lblFFin.Size = new System.Drawing.Size(17, 13);
            this.lblFFin.TabIndex = 150;
            this.lblFFin.Text = "al";
            // 
            // lblFInicio
            // 
            this.lblFInicio.AutoSize = true;
            this.lblFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFInicio.Location = new System.Drawing.Point(33, 50);
            this.lblFInicio.Name = "lblFInicio";
            this.lblFInicio.Size = new System.Drawing.Size(71, 13);
            this.lblFInicio.TabIndex = 149;
            this.lblFInicio.Text = "Periodo del";
            // 
            // lblEInicio
            // 
            this.lblEInicio.AutoSize = true;
            this.lblEInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEInicio.Location = new System.Drawing.Point(365, 50);
            this.lblEInicio.Name = "lblEInicio";
            this.lblEInicio.Size = new System.Drawing.Size(59, 13);
            this.lblEInicio.TabIndex = 151;
            this.lblEInicio.Text = "Edad entre";
            // 
            // lblEFin
            // 
            this.lblEFin.AutoSize = true;
            this.lblEFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEFin.Location = new System.Drawing.Point(464, 50);
            this.lblEFin.Name = "lblEFin";
            this.lblEFin.Size = new System.Drawing.Size(12, 13);
            this.lblEFin.TabIndex = 152;
            this.lblEFin.Text = "y";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMes.Location = new System.Drawing.Point(516, 50);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(37, 13);
            this.lblMes.TabIndex = 153;
            this.lblMes.Text = "meses";
            // 
            // txtEInicio
            // 
            this.txtEInicio.Location = new System.Drawing.Point(430, 47);
            this.txtEInicio.MaxLength = 3;
            this.txtEInicio.Name = "txtEInicio";
            this.txtEInicio.Size = new System.Drawing.Size(28, 20);
            this.txtEInicio.TabIndex = 148;
            // 
            // txtEFin
            // 
            this.txtEFin.Location = new System.Drawing.Point(482, 47);
            this.txtEFin.MaxLength = 3;
            this.txtEFin.Name = "txtEFin";
            this.txtEFin.Size = new System.Drawing.Size(28, 20);
            this.txtEFin.TabIndex = 149;
            // 
            // InfTasaPartos
            // 
            this.Controls.Add(this.txtEFin);
            this.Controls.Add(this.txtEInicio);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblEFin);
            this.Controls.Add(this.lblEInicio);
            this.Controls.Add(this.txtFFin);
            this.Controls.Add(this.txtFInicio);
            this.Controls.Add(this.lblFFin);
            this.Controls.Add(this.lblFInicio);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.lblEspecie);
            this.Name = "InfTasaPartos";
            this.Size = new System.Drawing.Size(684, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private GEXVOC.Core.Controles.ctlFecha txtFFin;
        private GEXVOC.Core.Controles.ctlFecha txtFInicio;
        private System.Windows.Forms.Label lblFFin;
        private System.Windows.Forms.Label lblFInicio;
        private System.Windows.Forms.Label lblEInicio;
        private System.Windows.Forms.Label lblEFin;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtEInicio;
        private System.Windows.Forms.TextBox txtEFin;
    }
}
