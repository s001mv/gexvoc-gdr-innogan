namespace GEXVOC
{
    partial class ctlNotificador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlNotificador));
            this.tmrDuracion = new System.Windows.Forms.Timer(this.components);
            this.tmrAnimacion = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxBloquear = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imlBoqueo = new System.Windows.Forms.ImageList(this.components);
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBloquear)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDuracion
            // 
            this.tmrDuracion.Interval = 5000;
            this.tmrDuracion.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrAnimacion
            // 
            this.tmrAnimacion.Interval = 30;
            this.tmrAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblLink);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(56, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 51);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.Todos_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Todos_MouseClick);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(2, 21);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(48, 48);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogo.TabIndex = 3;
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.Todos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mensaje Mostrado a las: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Brown;
            this.lblTiempo.Location = new System.Drawing.Point(131, -1);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(150, 16);
            this.lblTiempo.TabIndex = 6;
            this.lblTiempo.Text = "{}";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 2);
            this.label2.TabIndex = 2;
            // 
            // pbxBloquear
            // 
            this.pbxBloquear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxBloquear.Location = new System.Drawing.Point(332, 0);
            this.pbxBloquear.Name = "pbxBloquear";
            this.pbxBloquear.Size = new System.Drawing.Size(18, 15);
            this.pbxBloquear.TabIndex = 2;
            this.pbxBloquear.TabStop = false;
            this.pbxBloquear.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.lblTiempo);
            this.panel2.Controls.Add(this.pbxBloquear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 16);
            this.panel2.TabIndex = 7;
            // 
            // imlBoqueo
            // 
            this.imlBoqueo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBoqueo.ImageStream")));
            this.imlBoqueo.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBoqueo.Images.SetKeyName(0, "1.png");
            this.imlBoqueo.Images.SetKeyName(1, "2.png");
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(3, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(0, 13);
            this.lblLink.TabIndex = 2;
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // ctlNotificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(350, 74);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ctlNotificador";
            this.Opacity = 0.85;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Todos_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBloquear)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrDuracion;
        public System.Windows.Forms.Timer tmrAnimacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxBloquear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imlBoqueo;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}