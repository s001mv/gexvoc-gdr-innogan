namespace GEXVOC
{
    partial class Acerca
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
            this.lnkWeb = new System.Windows.Forms.LinkLabel();
            this.txtCompañia = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkWeb
            // 
            this.lnkWeb.AutoSize = true;
            this.lnkWeb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkWeb.Location = new System.Drawing.Point(178, 67);
            this.lnkWeb.Name = "lnkWeb";
            this.lnkWeb.Size = new System.Drawing.Size(122, 13);
            this.lnkWeb.TabIndex = 42;
            this.lnkWeb.TabStop = true;
            this.lnkWeb.Text = "http://www.coremain.es";
            this.lnkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWeb_LinkClicked);
            // 
            // txtCompañia
            // 
            this.txtCompañia.AutoSize = true;
            this.txtCompañia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCompañia.Location = new System.Drawing.Point(178, 49);
            this.txtCompañia.Name = "txtCompañia";
            this.txtCompañia.Size = new System.Drawing.Size(81, 13);
            this.txtCompañia.TabIndex = 41;
            this.txtCompañia.Text = "Coremain S.L.U";
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVersion.Location = new System.Drawing.Point(178, 31);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(48, 13);
            this.txtVersion.TabIndex = 40;
            this.txtVersion.Text = "Versión: ";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AutoSize = true;
            this.txtNombreProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNombreProducto.Location = new System.Drawing.Point(178, 13);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(146, 13);
            this.txtNombreProducto.TabIndex = 39;
            this.txtNombreProducto.Text = "GEXVOC - Gestión Ganadera";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(181, 85);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(321, 46);
            this.txtDescripcion.TabIndex = 38;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.Text = "Todos los derechos reservados para el GDR Litoral de la Janda";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(427, 355);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 37;
            this.okButton.Text = "&Aceptar";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(232, 31);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 43;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::GEXVOC.Properties.Resources.Lateral_gexvoc_1;
            this.logoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoPictureBox.Location = new System.Drawing.Point(-2, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(164, 387);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPictureBox.TabIndex = 36;
            this.logoPictureBox.TabStop = false;
            // 
            // Acerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 387);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lnkWeb);
            this.Controls.Add(this.txtCompañia);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acerca";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de...";
            this.Load += new System.EventHandler(this.Acerca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkWeb;
        private System.Windows.Forms.Label txtCompañia;
        private System.Windows.Forms.Label txtVersion;
        private System.Windows.Forms.Label txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label lblVersion;
    }
}