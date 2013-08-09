namespace GEXVOC.UI
{
    partial class FindTipoSemilla
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
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbFamilia);
            this.pnlBusqueda.Controls.Add(this.lblFamilia);
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 113);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(137, 60);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 63);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Variedad de semilla:";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(137, 33);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(185, 21);
            this.cmbFamilia.TabIndex = 0;
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFamilia.Location = new System.Drawing.Point(30, 33);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(42, 13);
            this.lblFamilia.TabIndex = 23;
            this.lblFamilia.Text = "Familia:";
            // 
            // FindTipoSemilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoPosicion = new System.Drawing.Point(12, 160);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 240);
            this.Name = "FindTipoSemilla";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 113);
            this.Text = "Variedades de Semillas";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label lblFamilia;
    }
}
