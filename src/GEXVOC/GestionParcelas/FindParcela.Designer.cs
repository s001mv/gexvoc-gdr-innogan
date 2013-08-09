namespace GEXVOC.UI
{
    partial class FindParcela
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
            this.cmbTitular = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreParcela = new System.Windows.Forms.TextBox();
            this.txtPoligono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtPoligono);
            this.pnlBusqueda.Controls.Add(this.label3);
            this.pnlBusqueda.Controls.Add(this.txtNombreParcela);
            this.pnlBusqueda.Controls.Add(this.label2);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.cmbTitular);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 122);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 159);
            this.panel1.Size = new System.Drawing.Size(610, 259);
            // 
            // cmbTitular
            // 
            this.cmbTitular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTitular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTitular.FormattingEnabled = true;
            this.cmbTitular.Location = new System.Drawing.Point(138, 29);
            this.cmbTitular.Name = "cmbTitular";
            this.cmbTitular.Size = new System.Drawing.Size(253, 21);
            this.cmbTitular.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Parcela";
            // 
            // txtNombreParcela
            // 
            this.txtNombreParcela.Location = new System.Drawing.Point(138, 57);
            this.txtNombreParcela.Name = "txtNombreParcela";
            this.txtNombreParcela.Size = new System.Drawing.Size(205, 20);
            this.txtNombreParcela.TabIndex = 1;
            // 
            // txtPoligono
            // 
            this.txtPoligono.Location = new System.Drawing.Point(138, 83);
            this.txtPoligono.Name = "txtPoligono";
            this.txtPoligono.Size = new System.Drawing.Size(205, 20);
            this.txtPoligono.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Polígono";
            // 
            // FindParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(636, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 259);
            this.Name = "FindParcela";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 122);
            this.Text = "Parcelas";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreParcela;
        private System.Windows.Forms.TextBox txtPoligono;
        private System.Windows.Forms.Label label3;
    }
}
