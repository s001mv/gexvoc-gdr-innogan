namespace GEXVOC.UI
{
    partial class infArbolInformes
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Control de stock de alimentación", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Consumo y Producción", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Alimentación", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Informe de animales", 1, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Libro de explotación ganadera", 1, 1);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Explotación", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Enfermedades", 1, 1);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Producción C.Lechero", 1, 1);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Producción lechera", 1, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Recuento de células somáticas", 1, 1);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Recuento de células somáticas gráfico", 1, 1);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Producción", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Gastos e ingresos", 1, 1);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Gestión financiera", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Sembrados", 1, 1);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Abonados", 1, 1);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Tratamientos", 1, 1);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Cortes de Hierba", 1, 1);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Gestión de fincas", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infArbolInformes));
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
            this.rptVisor.Size = new System.Drawing.Size(699, 473);
            // 
            // Filtros
            // 
            this.Filtros.AutoSize = false;
            this.Filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Filtros.Location = new System.Drawing.Point(281, 52);
            this.Filtros.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Filtros.Size = new System.Drawing.Size(699, 112);
            this.Filtros.Text = "Filtro:";
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
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Nodo4";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Control de stock de alimentación";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Nodo0";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Consumo y Producción";
            treeNode3.Name = "Alimentacion";
            treeNode3.Text = "Alimentación";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Nodo1";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Informe de animales";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Nodo2";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Libro de explotación ganadera";
            treeNode6.Name = "Explotacion";
            treeNode6.Text = "Explotación";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Nodo4";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Enfermedades";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Nodo5";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "Producción C.Lechero";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "Nodo6";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Producción lechera";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "Nodo7";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "Recuento de células somáticas";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "Nodo8";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "Recuento de células somáticas gráfico";
            treeNode12.Name = "Nodo3";
            treeNode12.Text = "Producción";
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "Nodo10";
            treeNode13.SelectedImageIndex = 1;
            treeNode13.Text = "Gastos e ingresos";
            treeNode14.Name = "Nodo9";
            treeNode14.Text = "Gestión financiera";
            treeNode15.ImageIndex = 1;
            treeNode15.Name = "Nodo2";
            treeNode15.SelectedImageIndex = 1;
            treeNode15.Text = "Sembrados";
            treeNode16.ImageIndex = 1;
            treeNode16.Name = "Nodo1";
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "Abonados";
            treeNode17.ImageIndex = 1;
            treeNode17.Name = "Nodo4";
            treeNode17.SelectedImageIndex = 1;
            treeNode17.Text = "Tratamientos";
            treeNode18.ImageIndex = 1;
            treeNode18.Name = "Nodo5";
            treeNode18.SelectedImageIndex = 1;
            treeNode18.Text = "Cortes de Hierba";
            treeNode19.Name = "Nodo0";
            treeNode19.Text = "Gestión de fincas";
            this.trvInformes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode12,
            treeNode14,
            treeNode19});
            this.trvInformes.SelectedImageIndex = 0;
            this.trvInformes.Size = new System.Drawing.Size(273, 615);
            this.trvInformes.TabIndex = 0;
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
            // infArbolInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 646);
            this.Controls.Add(this.trvInformes);
            this.Controls.Add(this.grpTituloInforme);
            this.Name = "infArbolInformes";
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.infArbolInformes_Load);
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

        private System.Windows.Forms.TreeView trvInformes;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblInformeLanzar;
        private System.Windows.Forms.GroupBox grpTituloInforme;
    }
}