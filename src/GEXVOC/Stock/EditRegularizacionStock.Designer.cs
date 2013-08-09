namespace GEXVOC.UI
{
    partial class EditRegularizacionStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRegularizacionStock));
            this.lstStock = new System.Windows.Forms.ListView();
            this.DescTipoProducto = new System.Windows.Forms.ColumnHeader();
            this.Producto = new System.Windows.Forms.ColumnHeader();
            this.Precio = new System.Windows.Forms.ColumnHeader();
            this.Cantidad = new System.Windows.Forms.ColumnHeader();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lstStock
            // 
            this.lstStock.CheckBoxes = true;
            this.lstStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DescTipoProducto,
            this.Producto,
            this.Precio,
            this.Cantidad});
            this.lstStock.FullRowSelect = true;
            this.lstStock.Location = new System.Drawing.Point(12, 81);
            this.lstStock.MultiSelect = false;
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(746, 451);
            this.lstStock.TabIndex = 2;
            this.lstStock.UseCompatibleStateImageBehavior = false;
            this.lstStock.View = System.Windows.Forms.View.Details;
            // 
            // DescTipoProducto
            // 
            this.DescTipoProducto.Text = "Tipo";
            this.DescTipoProducto.Width = 190;
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.Width = 392;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cantidad.Width = 78;
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.ForeColor = System.Drawing.Color.Firebrick;
            this.lblIndicaciones.Location = new System.Drawing.Point(84, 33);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(529, 39);
            this.lblIndicaciones.TabIndex = 3;
            this.lblIndicaciones.Text = resources.GetString("lblIndicaciones.Text");
            // 
            // btnRecargar
            // 
            this.btnRecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargar.Image")));
            this.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargar.Location = new System.Drawing.Point(659, 33);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(99, 39);
            this.btnRecargar.TabIndex = 1;
            this.btnRecargar.Text = "Recargar   ";
            this.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // EditRegularizacionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(776, 557);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.lstStock);
            this.Name = "EditRegularizacionStock";
            this.Text = "Regularización de Stock";
            this.Controls.SetChildIndex(this.lstStock, 0);
            this.Controls.SetChildIndex(this.lblIndicaciones, 0);
            this.Controls.SetChildIndex(this.btnRecargar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstStock;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader DescTipoProducto;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.Button btnRecargar;
    }
}
