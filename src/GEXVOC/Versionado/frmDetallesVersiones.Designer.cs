namespace GEXVOC.UI
{
    partial class frmDetallesVersiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallesVersiones));
            this.Contenedor = new GEXVOC.Core.Controles.Asistente.InfoContainer();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.Controls.Add(this.txtDetalles);
            this.Contenedor.Controls.Add(this.btnSalir);
            this.Contenedor.Image = ((System.Drawing.Image)(resources.GetObject("Contenedor.Image")));
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.PageTitle = "Detalles de las Versiones";
            this.Contenedor.Size = new System.Drawing.Size(583, 389);
            this.Contenedor.TabIndex = 2;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(168, 57);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.ReadOnly = true;
            this.txtDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalles.Size = new System.Drawing.Size(412, 300);
            this.txtDetalles.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(506, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmDetallesVersiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 387);
            this.ControlBox = false;
            this.Controls.Add(this.Contenedor);
            this.Name = "frmDetallesVersiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de las Versiones";
            this.Load += new System.EventHandler(this.frmDetallesVersiones_Load);
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GEXVOC.Core.Controles.Asistente.InfoContainer Contenedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDetalles;
    }
}