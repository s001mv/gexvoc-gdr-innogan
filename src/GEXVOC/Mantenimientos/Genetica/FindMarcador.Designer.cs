namespace GEXVOC.UI
{
    partial class FindMarcador
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoAnalisis = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.txtMarcador = new System.Windows.Forms.TextBox();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtMarcador);
            this.pnlBusqueda.Controls.Add(this.lblMarcador);
            this.pnlBusqueda.Controls.Add(this.cmbEspecie);
            this.pnlBusqueda.Controls.Add(this.lblEspecie);
            this.pnlBusqueda.Controls.Add(this.cmbTipoAnalisis);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 101);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 138);
            this.panel1.Size = new System.Drawing.Size(610, 280);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Análisis:";
            // 
            // cmbTipoAnalisis
            // 
            this.cmbTipoAnalisis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoAnalisis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoAnalisis.FormattingEnabled = true;
            this.cmbTipoAnalisis.Location = new System.Drawing.Point(159, 27);
            this.cmbTipoAnalisis.Name = "cmbTipoAnalisis";
            this.cmbTipoAnalisis.Size = new System.Drawing.Size(173, 21);
            this.cmbTipoAnalisis.TabIndex = 1;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(378, 30);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Especie:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(451, 27);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecie.TabIndex = 2;
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Location = new System.Drawing.Point(64, 67);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(55, 13);
            this.lblMarcador.TabIndex = 4;
            this.lblMarcador.Text = "Marcador:";
            // 
            // txtMarcador
            // 
            this.txtMarcador.Location = new System.Drawing.Point(159, 64);
            this.txtMarcador.MaxLength = 50;
            this.txtMarcador.Name = "txtMarcador";
            this.txtMarcador.Size = new System.Drawing.Size(173, 20);
            this.txtMarcador.TabIndex = 3;
            // 
            // FindMarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 280);
            this.Name = "FindMarcador";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 101);
            this.Text = "Marcadores";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarcador;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ComboBox cmbTipoAnalisis;
    }
}
