namespace GEXVOC.UI
{
    partial class Intro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblBarra = new System.Windows.Forms.Label();
            this.pbBarra = new System.Windows.Forms.ProgressBar();
            this.MenuPrincipal = new System.Windows.Forms.MainMenu();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(24, 13);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(195, 211);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lblBarra
            // 
            this.lblBarra.Location = new System.Drawing.Point(4, 199);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(233, 25);
            this.lblBarra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbBarra
            // 
            this.pbBarra.Enabled = false;
            this.pbBarra.Location = new System.Drawing.Point(24, 233);
            this.pbBarra.Name = "pbBarra";
            this.pbBarra.Size = new System.Drawing.Size(195, 22);
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.pbBarra);
            this.Menu = this.MenuPrincipal;
            this.Name = "Intro";
            this.Text = "GEXVOC CE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.ProgressBar pbBarra;
        private System.Windows.Forms.MainMenu MenuPrincipal;
    }
}