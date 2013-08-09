namespace GEXVOC.UI
{
    partial class FindCategoria
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
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtDetalle);
            this.pnlBusqueda.Controls.Add(this.lblDetalle);
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 100);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Size = new System.Drawing.Size(610, 281);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(132, 52);
            this.txtDetalle.MaxLength = 255;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(338, 20);
            this.txtDetalle.TabIndex = 10;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDetalle.Location = new System.Drawing.Point(59, 55);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblDetalle.TabIndex = 12;
            this.lblDetalle.Text = "Detalle:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(132, 26);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(338, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(59, 29);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(57, 13);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Categoría:";
            // 
            // FindCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 281);
            this.Name = "FindCategoria";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 100);
            this.Text = "Categorías";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}
