namespace GEXVOC.UI
{
    partial class Sincronizar
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
            this.BDescargar = new System.Windows.Forms.Button();
            this.QueTabla = new System.Windows.Forms.Label();
            this.Subir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // BDescargar
            // 
            this.BDescargar.Location = new System.Drawing.Point(36, 62);
            this.BDescargar.Name = "BDescargar";
            this.BDescargar.Size = new System.Drawing.Size(76, 21);
            this.BDescargar.TabIndex = 2;
            this.BDescargar.Text = "Descargar";
            this.BDescargar.Click += new System.EventHandler(this.BDescargar_Click);
            // 
            // QueTabla
            // 
            this.QueTabla.Location = new System.Drawing.Point(57, 212);
            this.QueTabla.Name = "QueTabla";
            this.QueTabla.Size = new System.Drawing.Size(70, 18);
            // 
            // Subir
            // 
            this.Subir.Location = new System.Drawing.Point(118, 67);
            this.Subir.Name = "Subir";
            this.Subir.Size = new System.Drawing.Size(60, 15);
            this.Subir.TabIndex = 3;
            this.Subir.Text = "Subir ";
            this.Subir.Click += new System.EventHandler(this.Subir_Click);
            // 
            // Sincronizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Subir);
            this.Controls.Add(this.QueTabla);
            this.Controls.Add(this.BDescargar);
            this.Name = "Sincronizar";
            this.Text = "Sincronizar";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Sincronizar_Closing);
            this.Controls.SetChildIndex(this.BDescargar, 0);
            this.Controls.SetChildIndex(this.QueTabla, 0);
            this.Controls.SetChildIndex(this.Subir, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BDescargar;
        private System.Windows.Forms.Label QueTabla;
        private System.Windows.Forms.Button Subir;
    }
}
