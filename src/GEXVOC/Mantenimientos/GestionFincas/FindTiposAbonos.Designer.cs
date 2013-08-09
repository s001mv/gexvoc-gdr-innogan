namespace GEXVOC.UI
{
    partial class FindTiposAbonos
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
            this.pnlBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 86);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(99, 30);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 33);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Tipo de abono:";
            // 
            // FindTiposAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoPosicion = new System.Drawing.Point(12, 130);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 270);
            this.Name = "FindTiposAbonos";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 86);
            this.Text = "Tipos de Abonos";
            this.TextoEliminar = "Va a proceder a borrar los abonos seleccionados\r¿Desea continuar y borrar los reg" +
                "istros?";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}
