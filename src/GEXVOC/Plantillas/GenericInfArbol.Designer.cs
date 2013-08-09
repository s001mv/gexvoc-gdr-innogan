namespace GEXVOC.UI
{
    partial class GenericInfArbol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenericInfArbol));
            this.trvInformes = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblInformeLanzar = new System.Windows.Forms.Label();
            this.grpTituloInforme = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grpTituloInforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptVisor
            // 
            this.rptVisor.Size = new System.Drawing.Size(735, 508);
            // 
            // Filtros
            // 
            this.Filtros.Location = new System.Drawing.Point(3, 30);
            this.Filtros.Margin = new System.Windows.Forms.Padding(0);
            this.Filtros.Padding = new System.Windows.Forms.Padding(0);
            this.Filtros.Size = new System.Drawing.Size(729, 74);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(735, 508);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvInformes);
            this.splitContainer1.Size = new System.Drawing.Size(992, 621);
            this.splitContainer1.SplitterDistance = 253;
            // 
            // splitContainer2
            // 
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpTituloInforme);
            this.splitContainer2.Size = new System.Drawing.Size(735, 621);
            this.splitContainer2.SplitterDistance = 109;
            // 
            // trvInformes
            // 
            this.trvInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvInformes.FullRowSelect = true;
            this.trvInformes.HideSelection = false;
            this.trvInformes.ImageIndex = 0;
            this.trvInformes.ImageList = this.imageList1;
            this.trvInformes.Location = new System.Drawing.Point(0, 0);
            this.trvInformes.Name = "trvInformes";
            this.trvInformes.SelectedImageIndex = 0;
            this.trvInformes.Size = new System.Drawing.Size(253, 621);
            this.trvInformes.TabIndex = 1;
            this.trvInformes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvInformes_AfterSelect);
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
            this.grpTituloInforme.BackColor = System.Drawing.SystemColors.Control;
            this.grpTituloInforme.Controls.Add(this.lblInformeLanzar);
            this.grpTituloInforme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpTituloInforme.Location = new System.Drawing.Point(3, 3);
            this.grpTituloInforme.Name = "grpTituloInforme";
            this.grpTituloInforme.Size = new System.Drawing.Size(729, 26);
            this.grpTituloInforme.TabIndex = 139;
            this.grpTituloInforme.TabStop = false;
            this.grpTituloInforme.Text = "Informe:";
            // 
            // GenericInfArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(992, 646);
            this.Name = "GenericInfArbol";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grpTituloInforme.ResumeLayout(false);
            this.grpTituloInforme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView trvInformes;
        protected System.Windows.Forms.ImageList imageList1;
        protected System.Windows.Forms.GroupBox grpTituloInforme;
        protected System.Windows.Forms.Label lblInformeLanzar;
    }
}
