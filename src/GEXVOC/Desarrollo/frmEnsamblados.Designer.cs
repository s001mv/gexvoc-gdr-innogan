namespace GEXVOC.UI
{
    partial class EditEnsamblados
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
            this.trvMenus = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // trvMenus
            // 
            this.trvMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trvMenus.CheckBoxes = true;
            this.trvMenus.FullRowSelect = true;
            this.trvMenus.Location = new System.Drawing.Point(14, 50);
            this.trvMenus.Name = "trvMenus";
            this.trvMenus.Size = new System.Drawing.Size(585, 373);
            this.trvMenus.TabIndex = 3;
            // 
            // EditEnsamblados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(613, 468);
            this.Controls.Add(this.trvMenus);
            this.Name = "EditEnsamblados";
            this.Text = "Ensamblados";
            this.Load += new System.EventHandler(this.EditEnsamblados_Load);
            this.Controls.SetChildIndex(this.trvMenus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvMenus;
    }
}
