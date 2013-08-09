namespace GEXVOC.Core.Controles
{
    partial class ctlFecha
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFecha.Location = new System.Drawing.Point(0, 0);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(66, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(22, 20);
            this.dtp.TabIndex = 7;
            this.dtp.TabStop = false;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            this.dtp.DropDown += new System.EventHandler(this.dtp_DropDown);
            this.dtp.CloseUp += new System.EventHandler(this.dtp_CloseUp);
            // 
            // ctlFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtFecha);
            this.Name = "ctlFecha";
            this.Size = new System.Drawing.Size(88, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}
