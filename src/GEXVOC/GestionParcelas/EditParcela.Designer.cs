namespace GEXVOC.UI
{
    partial class EditParcela
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.cmbTitular = new System.Windows.Forms.ComboBox();
            this.lblPoligono = new System.Windows.Forms.Label();
            this.txtPoligono = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 81);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(36, 57);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 5;
            this.lblTitular.Text = "Titular";
            // 
            // cmbTitular
            // 
            this.cmbTitular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTitular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTitular.FormattingEnabled = true;
            this.cmbTitular.Location = new System.Drawing.Point(99, 54);
            this.cmbTitular.Name = "cmbTitular";
            this.cmbTitular.Size = new System.Drawing.Size(220, 21);
            this.cmbTitular.TabIndex = 0;
            // 
            // lblPoligono
            // 
            this.lblPoligono.AutoSize = true;
            this.lblPoligono.Location = new System.Drawing.Point(36, 110);
            this.lblPoligono.Name = "lblPoligono";
            this.lblPoligono.Size = new System.Drawing.Size(50, 13);
            this.lblPoligono.TabIndex = 7;
            this.lblPoligono.Text = "Polígono";
            // 
            // txtPoligono
            // 
            this.txtPoligono.Location = new System.Drawing.Point(99, 107);
            this.txtPoligono.MaxLength = 255;
            this.txtPoligono.Name = "txtPoligono";
            this.txtPoligono.Size = new System.Drawing.Size(236, 20);
            this.txtPoligono.TabIndex = 2;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(36, 136);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(53, 13);
            this.lblExtension.TabIndex = 9;
            this.lblExtension.Text = "Extensión";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(99, 133);
            this.txtExtension.MaxLength = 20;
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(89, 20);
            this.txtExtension.TabIndex = 3;
            // 
            // EditParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(442, 242);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.lblPoligono);
            this.Controls.Add(this.txtPoligono);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.cmbTitular);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "EditParcela";
            this.Text = "Parcela";
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.cmbTitular, 0);
            this.Controls.SetChildIndex(this.lblTitular, 0);
            this.Controls.SetChildIndex(this.txtPoligono, 0);
            this.Controls.SetChildIndex(this.lblPoligono, 0);
            this.Controls.SetChildIndex(this.txtExtension, 0);
            this.Controls.SetChildIndex(this.lblExtension, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.ComboBox cmbTitular;
        private System.Windows.Forms.Label lblPoligono;
        private System.Windows.Forms.TextBox txtPoligono;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.TextBox txtExtension;
    }
}
