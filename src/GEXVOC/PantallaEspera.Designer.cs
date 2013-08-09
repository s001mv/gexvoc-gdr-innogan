namespace GEXVOC.UI
{
    partial class PantallaEspera
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaEspera));
            this.pgbProceso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcesados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbProceso
            // 
            this.pgbProceso.Location = new System.Drawing.Point(57, 80);
            this.pgbProceso.Maximum = 5;
            this.pgbProceso.Name = "pgbProceso";
            this.pgbProceso.Size = new System.Drawing.Size(262, 23);
            this.pgbProceso.Step = 1;
            this.pgbProceso.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "La aplicación se encuentra procesando la información.\r\nPor favor espere.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcesados
            // 
            this.lblProcesados.AutoSize = true;
            this.lblProcesados.Location = new System.Drawing.Point(118, 117);
            this.lblProcesados.Name = "lblProcesados";
            this.lblProcesados.Size = new System.Drawing.Size(93, 13);
            this.lblProcesados.TabIndex = 2;
            this.lblProcesados.Text = "Procesado n de m";
            this.lblProcesados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProcesados.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 160);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProcesados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbProceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaEspera";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Procesando... (Por favor espere)";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProcesados;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ProgressBar pgbProceso;

    }
}