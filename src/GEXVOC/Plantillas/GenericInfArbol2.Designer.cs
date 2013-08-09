namespace GEXVOC.UI
{
    partial class GenericInfArbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenericInfArbol));
            this.trvInformes = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblInformeLanzar = new System.Windows.Forms.Label();
            this.grpTituloInforme = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grpTituloInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptVisor
            // 
            this.rptVisor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.rptVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptVisor.Size = new System.Drawing.Size(699, 473);
            // 
            // Filtros
            // 
            this.Filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Filtros.Location = new System.Drawing.Point(281, 52);
            this.Filtros.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Filtros.Size = new System.Drawing.Size(699, 112);
            this.Filtros.Text = "Filtro:";
            this.Filtros.SizeChanged += new System.EventHandler(this.Filtros_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(281, 170);
            this.panel1.Size = new System.Drawing.Size(699, 473);
            // 
            // trvInformes
            // 
            this.trvInformes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.trvInformes.FullRowSelect = true;
            this.trvInformes.HideSelection = false;
            this.trvInformes.ImageIndex = 0;
            this.trvInformes.ImageList = this.imageList1;
            this.trvInformes.Location = new System.Drawing.Point(2, 28);
            this.trvInformes.Name = "trvInformes";
            this.trvInformes.SelectedImageIndex = 0;
            this.trvInformes.Size = new System.Drawing.Size(273, 615);
            this.trvInformes.TabIndex = 0;
            this.trvInformes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvInformes_AfterSelect);
            //this.trvInformes.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvInformes_BeforeSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_table.png");
            this.imageList1.Images.SetKeyName(1, "kmplot.png");
            // 
            // lblInformeLanzar
            // 
            this.lblInformeLanzar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformeLanzar.AutoSize = true;
            this.lblInformeLanzar.BackColor = System.Drawing.Color.Transparent;
            this.lblInformeLanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeLanzar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInformeLanzar.Location = new System.Drawing.Point(56, 8);
            this.lblInformeLanzar.Name = "lblInformeLanzar";
            this.lblInformeLanzar.Size = new System.Drawing.Size(49, 13);
            this.lblInformeLanzar.TabIndex = 0;
            this.lblInformeLanzar.Text = "Informe";
            this.lblInformeLanzar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTituloInforme
            // 
            this.grpTituloInforme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTituloInforme.BackColor = System.Drawing.SystemColors.Control;
            this.grpTituloInforme.Controls.Add(this.lblInformeLanzar);
            this.grpTituloInforme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpTituloInforme.Location = new System.Drawing.Point(281, 28);
            this.grpTituloInforme.Name = "grpTituloInforme";
            this.grpTituloInforme.Size = new System.Drawing.Size(699, 24);
            this.grpTituloInforme.TabIndex = 138;
            this.grpTituloInforme.TabStop = false;
            this.grpTituloInforme.Text = "Informe:";
            // 
            // GenericInfArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 646);
            this.Controls.Add(this.trvInformes);
            this.Controls.Add(this.grpTituloInforme);
            this.MinimumSize = new System.Drawing.Size(1000, 680);
            this.Name = "GenericInfArbol";
            this.Text = "Informes";
            this.Controls.SetChildIndex(this.grpTituloInforme, 0);
            this.Controls.SetChildIndex(this.trvInformes, 0);
            this.Controls.SetChildIndex(this.Filtros, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grpTituloInforme.ResumeLayout(false);
            this.grpTituloInforme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblInformeLanzar;
        private System.Windows.Forms.GroupBox grpTituloInforme;
        public System.Windows.Forms.TreeView trvInformes;
       /// protected System.Windows.Forms.ToolTip toolTip1;
    }
}