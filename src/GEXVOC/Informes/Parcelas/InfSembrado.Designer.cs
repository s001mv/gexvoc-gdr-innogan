namespace GEXVOC.Informes
{
    partial class InfSembrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfAbonado));
            this.cmbParcela = new System.Windows.Forms.ComboBox();
            this.lblFinca = new System.Windows.Forms.Label();
            this.lblFFin = new System.Windows.Forms.Label();
            this.lblFInicio = new System.Windows.Forms.Label();
            this.txtFInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFFin = new GEXVOC.Core.Controles.ctlFecha();
            this.SuspendLayout();
            // 
            // cmbParcela
            // 
            this.cmbParcela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParcela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.Location = new System.Drawing.Point(86, 35);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.Size = new System.Drawing.Size(223, 21);
            this.cmbParcela.TabIndex = 0;
            // 
            // lblFinca
            // 
            this.lblFinca.AutoSize = true;
            this.lblFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFinca.Location = new System.Drawing.Point(17, 39);
            this.lblFinca.Name = "lblFinca";
            this.lblFinca.Size = new System.Drawing.Size(46, 13);
            this.lblFinca.TabIndex = 138;
            this.lblFinca.Text = "Parcela:";
            // 
            // lblFFin
            // 
            this.lblFFin.AutoSize = true;
            this.lblFFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFFin.Location = new System.Drawing.Point(531, 35);
            this.lblFFin.Name = "lblFFin";
            this.lblFFin.Size = new System.Drawing.Size(15, 13);
            this.lblFFin.TabIndex = 136;
            this.lblFFin.Text = "al";
            // 
            // lblFInicio
            // 
            this.lblFInicio.AutoSize = true;
            this.lblFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFInicio.Location = new System.Drawing.Point(350, 35);
            this.lblFInicio.Name = "lblFInicio";
            this.lblFInicio.Size = new System.Drawing.Size(60, 13);
            this.lblFInicio.TabIndex = 135;
            this.lblFInicio.Text = "Periodo del";
            // 
            // txtFInicio
            // 
            this.txtFInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFInicio.Location = new System.Drawing.Point(427, 32);
            this.txtFInicio.Name = "txtFInicio";
            this.txtFInicio.ReadOnly = false;
            this.txtFInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFInicio.TabIndex = 1;
            this.txtFInicio.Value = null;
            // 
            // txtFFin
            // 
            this.txtFFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFFin.Location = new System.Drawing.Point(552, 32);
            this.txtFFin.Name = "txtFFin";
            this.txtFFin.ReadOnly = false;
            this.txtFFin.Size = new System.Drawing.Size(88, 20);
            this.txtFFin.TabIndex = 2;
            this.txtFFin.Value = null;
            // 
            // InfAbonado
            // 
            this.Controls.Add(this.txtFFin);
            this.Controls.Add(this.txtFInicio);
            this.Controls.Add(this.cmbParcela);
            this.Controls.Add(this.lblFinca);
            this.Controls.Add(this.lblFFin);
            this.Controls.Add(this.lblFInicio);
            this.DescripcionInforme = resources.GetString("$this.DescripcionInforme");
            this.Name = "InfAbonado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParcela;
        private System.Windows.Forms.Label lblFinca;
        private System.Windows.Forms.Label lblFFin;
        private System.Windows.Forms.Label lblFInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFFin;
    }
}
