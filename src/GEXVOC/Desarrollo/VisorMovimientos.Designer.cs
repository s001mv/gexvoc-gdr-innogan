namespace GEXVOC.UI
{
    partial class VisorMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorMovimientos));
            this.dtgMovimientos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Macho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMovimientos
            // 
            this.dtgMovimientos.AllowUserToAddRows = false;
            this.dtgMovimientos.AllowUserToDeleteRows = false;
            this.dtgMovimientos.AllowUserToOrderColumns = true;
            this.dtgMovimientos.AllowUserToResizeRows = false;
            this.dtgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.dtgMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Origen,
            this.Producto,
            this.Macho,
            this.Cantidad,
            this.Precio});
            this.dtgMovimientos.Location = new System.Drawing.Point(12, 73);
            this.dtgMovimientos.Name = "dtgMovimientos";
            this.dtgMovimientos.ReadOnly = true;
            this.dtgMovimientos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgMovimientos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMovimientos.ShowCellErrors = false;
            this.dtgMovimientos.ShowCellToolTips = false;
            this.dtgMovimientos.ShowEditingIcon = false;
            this.dtgMovimientos.ShowRowErrors = false;
            this.dtgMovimientos.Size = new System.Drawing.Size(711, 475);
            this.dtgMovimientos.TabIndex = 16;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 63;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.DataPropertyName = "DescProducto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Macho
            // 
            this.Macho.DataPropertyName = "DescMacho";
            this.Macho.HeaderText = "Macho";
            this.Macho.Name = "Macho";
            this.Macho.ReadOnly = true;
            this.Macho.Width = 65;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 62;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargar.Image")));
            this.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargar.Location = new System.Drawing.Point(624, 28);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(99, 39);
            this.btnRecargar.TabIndex = 17;
            this.btnRecargar.Text = "Recargar   ";
            this.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.ForeColor = System.Drawing.Color.Firebrick;
            this.lblIndicaciones.Location = new System.Drawing.Point(63, 37);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(501, 26);
            this.lblIndicaciones.TabIndex = 18;
            this.lblIndicaciones.Text = "Aquí se representa de manera sencilla todos los movimientos que han sido  registr" +
                "ados en la explotación.\r\nLos movimientos se representan de manera decreciente a " +
                "como han sido registrados.\r\n";
            // 
            // VisorMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(735, 586);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.dtgMovimientos);
            this.Name = "VisorMovimientos";
            this.Text = "Visor de Movimientos";
            this.Load += new System.EventHandler(this.VisorMovimientos_Load);
            this.Controls.SetChildIndex(this.dtgMovimientos, 0);
            this.Controls.SetChildIndex(this.btnRecargar, 0);
            this.Controls.SetChildIndex(this.lblIndicaciones, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Macho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Label lblIndicaciones;
    }
}
