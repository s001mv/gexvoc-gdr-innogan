namespace GEXVOC.UI
{
    partial class EditTipoAnalisis
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
            this.lblTipoAnalisis = new System.Windows.Forms.Label();
            this.txtTipoAnalisis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoAnalisis
            // 
            this.lblTipoAnalisis.AutoSize = true;
            this.lblTipoAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnalisis.Location = new System.Drawing.Point(33, 81);
            this.lblTipoAnalisis.Name = "lblTipoAnalisis";
            this.lblTipoAnalisis.Size = new System.Drawing.Size(101, 13);
            this.lblTipoAnalisis.TabIndex = 2;
            this.lblTipoAnalisis.Text = "Tipo de Análisis:";
            // 
            // txtTipoAnalisis
            // 
            this.txtTipoAnalisis.Location = new System.Drawing.Point(140, 78);
            this.txtTipoAnalisis.MaxLength = 100;
            this.txtTipoAnalisis.Name = "txtTipoAnalisis";
            this.txtTipoAnalisis.Size = new System.Drawing.Size(163, 20);
            this.txtTipoAnalisis.TabIndex = 3;
            // 
            // EditTipoAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 175);
            this.Controls.Add(this.lblTipoAnalisis);
            this.Controls.Add(this.txtTipoAnalisis);
            this.Name = "EditTipoAnalisis";
            this.Text = "Tipo de Análisis";
            this.Controls.SetChildIndex(this.txtTipoAnalisis, 0);
            this.Controls.SetChildIndex(this.lblTipoAnalisis, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoAnalisis;
        private System.Windows.Forms.TextBox txtTipoAnalisis;
    }
}
