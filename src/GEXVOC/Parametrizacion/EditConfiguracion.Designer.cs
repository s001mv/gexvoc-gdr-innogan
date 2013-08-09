namespace GEXVOC.UI
{
    partial class EditConfiguracion
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
            this.pnlLactacion = new System.Windows.Forms.GroupBox();
            this.cmbLactacion = new System.Windows.Forms.ComboBox();
            this.lblLactacion = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabEspecies = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlLactacion.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLactacion
            // 
            this.pnlLactacion.Controls.Add(this.cmbLactacion);
            this.pnlLactacion.Controls.Add(this.lblLactacion);
            this.pnlLactacion.Location = new System.Drawing.Point(9, 78);
            this.pnlLactacion.Name = "pnlLactacion";
            this.pnlLactacion.Size = new System.Drawing.Size(519, 60);
            this.pnlLactacion.TabIndex = 5;
            this.pnlLactacion.TabStop = false;
            this.pnlLactacion.Text = "Lactación";
            // 
            // cmbLactacion
            // 
            this.cmbLactacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLactacion.FormattingEnabled = true;
            this.cmbLactacion.Items.AddRange(new object[] {
            "Parto",
            "Primer control"});
            this.cmbLactacion.Location = new System.Drawing.Point(301, 22);
            this.cmbLactacion.Name = "cmbLactacion";
            this.cmbLactacion.Size = new System.Drawing.Size(156, 21);
            this.cmbLactacion.TabIndex = 1;
            // 
            // lblLactacion
            // 
            this.lblLactacion.AutoSize = true;
            this.lblLactacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLactacion.Location = new System.Drawing.Point(30, 25);
            this.lblLactacion.Name = "lblLactacion";
            this.lblLactacion.Size = new System.Drawing.Size(223, 13);
            this.lblLactacion.TabIndex = 0;
            this.lblLactacion.Text = "La lactación se abrirá a partir de la fecha de...";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 25);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(540, 42);
            this.pnlTitulo.TabIndex = 59;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(329, 13);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "Desde esta pantalla puede adaptar la aplicación a sus necesidades:";
            // 
            // tabEspecies
            // 
            this.tabEspecies.Location = new System.Drawing.Point(9, 144);
            this.tabEspecies.Name = "tabEspecies";
            this.tabEspecies.SelectedIndex = 0;
            this.tabEspecies.Size = new System.Drawing.Size(519, 371);
            this.tabEspecies.TabIndex = 60;
            // 
            // EditConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(540, 540);
            this.Controls.Add(this.tabEspecies);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlLactacion);
            this.Name = "EditConfiguracion";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.EditConfiguracion_Load);
            this.Controls.SetChildIndex(this.pnlLactacion, 0);
            this.Controls.SetChildIndex(this.pnlTitulo, 0);
            this.Controls.SetChildIndex(this.tabEspecies, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlLactacion.ResumeLayout(false);
            this.pnlLactacion.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlLactacion;
        private System.Windows.Forms.ComboBox cmbLactacion;
        private System.Windows.Forms.Label lblLactacion;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabEspecies;
    }
}
