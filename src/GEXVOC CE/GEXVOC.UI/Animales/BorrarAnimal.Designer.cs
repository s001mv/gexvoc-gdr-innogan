namespace GEXVOC.UI
{
    partial class BorrarAnimal
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
            this.LFbaja = new System.Windows.Forms.Label();
            this.dTFbaja = new System.Windows.Forms.DateTimePicker();
            this.LtipoBaja = new System.Windows.Forms.Label();
            this.CbTipoBaja = new System.Windows.Forms.ComboBox();
            this.LDetalle = new System.Windows.Forms.Label();
            this.TbDetalle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // LFbaja
            // 
            this.LFbaja.Location = new System.Drawing.Point(24, 13);
            this.LFbaja.Name = "LFbaja";
            this.LFbaja.Size = new System.Drawing.Size(66, 18);
            this.LFbaja.Text = "F.Baja";
            // 
            // dTFbaja
            // 
            this.dTFbaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTFbaja.Location = new System.Drawing.Point(105, 13);
            this.dTFbaja.Name = "dTFbaja";
            this.dTFbaja.Size = new System.Drawing.Size(70, 22);
            this.dTFbaja.TabIndex = 3;
            // 
            // LtipoBaja
            // 
            this.LtipoBaja.Location = new System.Drawing.Point(24, 45);
            this.LtipoBaja.Name = "LtipoBaja";
            this.LtipoBaja.Size = new System.Drawing.Size(60, 21);
            this.LtipoBaja.Text = "Tipo Baja";
            // 
            // CbTipoBaja
            // 
            this.CbTipoBaja.Location = new System.Drawing.Point(105, 45);
            this.CbTipoBaja.Name = "CbTipoBaja";
            this.CbTipoBaja.Size = new System.Drawing.Size(95, 22);
            this.CbTipoBaja.TabIndex = 5;
            // 
            // LDetalle
            // 
            this.LDetalle.Location = new System.Drawing.Point(24, 76);
            this.LDetalle.Name = "LDetalle";
            this.LDetalle.Size = new System.Drawing.Size(59, 21);
            this.LDetalle.Text = "Detalle";
            // 
            // TbDetalle
            // 
            this.TbDetalle.Location = new System.Drawing.Point(106, 76);
            this.TbDetalle.Name = "TbDetalle";
            this.TbDetalle.Size = new System.Drawing.Size(113, 21);
            this.TbDetalle.TabIndex = 7;
            // 
            // BorrarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TbDetalle);
            this.Controls.Add(this.LDetalle);
            this.Controls.Add(this.LtipoBaja);
            this.Controls.Add(this.CbTipoBaja);
            this.Controls.Add(this.dTFbaja);
            this.Controls.Add(this.LFbaja);
            this.Name = "BorrarAnimal";
            this.Text = "Borrar Animal";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.BorrarAnimal_Closing);
            this.Controls.SetChildIndex(this.LFbaja, 0);
            this.Controls.SetChildIndex(this.dTFbaja, 0);
            this.Controls.SetChildIndex(this.CbTipoBaja, 0);
            this.Controls.SetChildIndex(this.LtipoBaja, 0);
            this.Controls.SetChildIndex(this.LDetalle, 0);
            this.Controls.SetChildIndex(this.TbDetalle, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LFbaja;
        private System.Windows.Forms.DateTimePicker dTFbaja;
        private System.Windows.Forms.Label LtipoBaja;
        private System.Windows.Forms.ComboBox CbTipoBaja;
        private System.Windows.Forms.Label LDetalle;
        private System.Windows.Forms.TextBox TbDetalle;
    }
}
