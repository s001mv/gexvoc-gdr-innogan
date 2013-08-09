namespace GEXVOC.UI
{
    partial class EditModulo
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbPrincipal = new System.Windows.Forms.ComboBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(111, 105);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(281, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(23, 108);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 66;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // cmbPrincipal
            // 
            this.cmbPrincipal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPrincipal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrincipal.FormattingEnabled = true;
            this.cmbPrincipal.Location = new System.Drawing.Point(111, 69);
            this.cmbPrincipal.Name = "cmbPrincipal";
            this.cmbPrincipal.Size = new System.Drawing.Size(281, 21);
            this.cmbPrincipal.TabIndex = 0;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(23, 72);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(50, 13);
            this.lblPrincipal.TabIndex = 64;
            this.lblPrincipal.Text = "Principal:";
            // 
            // EditModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(452, 199);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cmbPrincipal);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "EditModulo";
            this.Text = "Edición de Módulo";
            this.Controls.SetChildIndex(this.lblPrincipal, 0);
            this.Controls.SetChildIndex(this.cmbPrincipal, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbPrincipal;
        private System.Windows.Forms.Label lblPrincipal;
    }
}
