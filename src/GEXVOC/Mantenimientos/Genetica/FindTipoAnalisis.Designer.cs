namespace GEXVOC.UI
{
    partial class FindTipoAnalisis
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
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtTipoAnalisis);
            this.pnlBusqueda.Controls.Add(this.lblTipoAnalisis);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 81);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Size = new System.Drawing.Size(610, 300);
            // 
            // lblTipoAnalisis
            // 
            this.lblTipoAnalisis.AutoSize = true;
            this.lblTipoAnalisis.Location = new System.Drawing.Point(54, 37);
            this.lblTipoAnalisis.Name = "lblTipoAnalisis";
            this.lblTipoAnalisis.Size = new System.Drawing.Size(84, 13);
            this.lblTipoAnalisis.TabIndex = 0;
            this.lblTipoAnalisis.Text = "Tipo de Análisis:";
            // 
            // txtTipoAnalisis
            // 
            this.txtTipoAnalisis.Location = new System.Drawing.Point(165, 34);
            this.txtTipoAnalisis.MaxLength = 100;
            this.txtTipoAnalisis.Name = "txtTipoAnalisis";
            this.txtTipoAnalisis.Size = new System.Drawing.Size(302, 20);
            this.txtTipoAnalisis.TabIndex = 1;
            // 
            // FindTipoAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 300);
            this.Name = "FindTipoAnalisis";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 81);
            this.Text = "Tipos de Análisis";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoAnalisis;
        private System.Windows.Forms.TextBox txtTipoAnalisis;
    }
}
