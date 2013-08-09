namespace GEXVOC.UI
{
    partial class EditMedicamento
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
            this.lblDiasCarne = new System.Windows.Forms.Label();
            this.txtSupresionCarne = new System.Windows.Forms.TextBox();
            this.lblSupresionCarne = new System.Windows.Forms.Label();
            this.lblDiasLeche = new System.Windows.Forms.Label();
            this.txtSupresionLeche = new System.Windows.Forms.TextBox();
            this.lblSupresionLeche = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiasCarne
            // 
            this.lblDiasCarne.AutoSize = true;
            this.lblDiasCarne.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiasCarne.Location = new System.Drawing.Point(201, 96);
            this.lblDiasCarne.Name = "lblDiasCarne";
            this.lblDiasCarne.Size = new System.Drawing.Size(28, 13);
            this.lblDiasCarne.TabIndex = 24;
            this.lblDiasCarne.Text = "días";
            // 
            // txtSupresionCarne
            // 
            this.txtSupresionCarne.Location = new System.Drawing.Point(129, 93);
            this.txtSupresionCarne.Name = "txtSupresionCarne";
            this.txtSupresionCarne.Size = new System.Drawing.Size(66, 20);
            this.txtSupresionCarne.TabIndex = 23;
            // 
            // lblSupresionCarne
            // 
            this.lblSupresionCarne.AutoSize = true;
            this.lblSupresionCarne.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSupresionCarne.Location = new System.Drawing.Point(22, 96);
            this.lblSupresionCarne.Name = "lblSupresionCarne";
            this.lblSupresionCarne.Size = new System.Drawing.Size(102, 13);
            this.lblSupresionCarne.TabIndex = 22;
            this.lblSupresionCarne.Text = "Supresión de carne:";
            // 
            // lblDiasLeche
            // 
            this.lblDiasLeche.AutoSize = true;
            this.lblDiasLeche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiasLeche.Location = new System.Drawing.Point(201, 70);
            this.lblDiasLeche.Name = "lblDiasLeche";
            this.lblDiasLeche.Size = new System.Drawing.Size(28, 13);
            this.lblDiasLeche.TabIndex = 21;
            this.lblDiasLeche.Text = "días";
            // 
            // txtSupresionLeche
            // 
            this.txtSupresionLeche.Location = new System.Drawing.Point(129, 67);
            this.txtSupresionLeche.Name = "txtSupresionLeche";
            this.txtSupresionLeche.Size = new System.Drawing.Size(66, 20);
            this.txtSupresionLeche.TabIndex = 20;
            // 
            // lblSupresionLeche
            // 
            this.lblSupresionLeche.AutoSize = true;
            this.lblSupresionLeche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSupresionLeche.Location = new System.Drawing.Point(22, 70);
            this.lblSupresionLeche.Name = "lblSupresionLeche";
            this.lblSupresionLeche.Size = new System.Drawing.Size(101, 13);
            this.lblSupresionLeche.TabIndex = 19;
            this.lblSupresionLeche.Text = "Supresión de leche:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(129, 41);
            this.txtDescripcion.MaxLength = 255;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(355, 20);
            this.txtDescripcion.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 44);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(54, 13);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Nombre:";
            // 
            // EditMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(524, 171);
            this.Controls.Add(this.lblDiasCarne);
            this.Controls.Add(this.txtSupresionCarne);
            this.Controls.Add(this.lblSupresionCarne);
            this.Controls.Add(this.lblDiasLeche);
            this.Controls.Add(this.txtSupresionLeche);
            this.Controls.Add(this.lblSupresionLeche);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "EditMedicamento";
            this.Text = "Medicamento";
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblSupresionLeche, 0);
            this.Controls.SetChildIndex(this.txtSupresionLeche, 0);
            this.Controls.SetChildIndex(this.lblDiasLeche, 0);
            this.Controls.SetChildIndex(this.lblSupresionCarne, 0);
            this.Controls.SetChildIndex(this.txtSupresionCarne, 0);
            this.Controls.SetChildIndex(this.lblDiasCarne, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiasCarne;
        private System.Windows.Forms.TextBox txtSupresionCarne;
        private System.Windows.Forms.Label lblSupresionCarne;
        private System.Windows.Forms.Label lblDiasLeche;
        private System.Windows.Forms.TextBox txtSupresionLeche;
        private System.Windows.Forms.Label lblSupresionLeche;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}
