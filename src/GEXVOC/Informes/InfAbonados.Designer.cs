namespace GEXVOC.UI
{
    partial class InfAbonados
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
            this.lblFFin = new System.Windows.Forms.Label();
            this.txtFFin = new System.Windows.Forms.TextBox();
            this.txtFInicio = new System.Windows.Forms.TextBox();
            this.lblFInicio = new System.Windows.Forms.Label();
            this.cmbParcela = new System.Windows.Forms.ComboBox();
            this.lblFinca = new System.Windows.Forms.Label();
            this.Filtros.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // rptVisor
            // 
            this.rptVisor.EnableToolTips = false;
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.cmbParcela);
            this.Filtros.Controls.Add(this.lblFinca);
            this.Filtros.Controls.Add(this.lblFFin);
            this.Filtros.Controls.Add(this.txtFFin);
            this.Filtros.Controls.Add(this.txtFInicio);
            this.Filtros.Controls.Add(this.lblFInicio);
            // 
            // lblFFin
            // 
            this.lblFFin.AutoSize = true;
            this.lblFFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFFin.Location = new System.Drawing.Point(573, 44);
            this.lblFFin.Name = "lblFFin";
            this.lblFFin.Size = new System.Drawing.Size(15, 13);
            this.lblFFin.TabIndex = 120;
            this.lblFFin.Text = "al";
            // 
            // txtFFin
            // 
            this.txtFFin.Location = new System.Drawing.Point(598, 40);
            this.txtFFin.MaxLength = 10;
            this.txtFFin.Name = "txtFFin";
            this.txtFFin.Size = new System.Drawing.Size(97, 20);
            this.txtFFin.TabIndex = 118;
            // 
            // txtFInicio
            // 
            this.txtFInicio.Location = new System.Drawing.Point(466, 40);
            this.txtFInicio.MaxLength = 10;
            this.txtFInicio.Name = "txtFInicio";
            this.txtFInicio.Size = new System.Drawing.Size(97, 20);
            this.txtFInicio.TabIndex = 117;
            // 
            // lblFInicio
            // 
            this.lblFInicio.AutoSize = true;
            this.lblFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFInicio.Location = new System.Drawing.Point(383, 44);
            this.lblFInicio.Name = "lblFInicio";
            this.lblFInicio.Size = new System.Drawing.Size(60, 13);
            this.lblFInicio.TabIndex = 119;
            this.lblFInicio.Text = "Periodo del";
            // 
            // cmbParcela
            // 
            this.cmbParcela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbParcela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.Location = new System.Drawing.Point(87, 36);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.Size = new System.Drawing.Size(223, 21);
            this.cmbParcela.TabIndex = 131;
            // 
            // lblFinca
            // 
            this.lblFinca.AutoSize = true;
            this.lblFinca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFinca.Location = new System.Drawing.Point(19, 37);
            this.lblFinca.Name = "lblFinca";
            this.lblFinca.Size = new System.Drawing.Size(46, 13);
            this.lblFinca.TabIndex = 132;
            this.lblFinca.Text = "Parcela:";
            // 
            // InfAbonados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Name = "InfAbonados";
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFFin;
        private System.Windows.Forms.TextBox txtFFin;
        private System.Windows.Forms.TextBox txtFInicio;
        private System.Windows.Forms.Label lblFInicio;
        private System.Windows.Forms.ComboBox cmbParcela;
        private System.Windows.Forms.Label lblFinca;
    }
}
