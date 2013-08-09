namespace GEXVOC.UI
{
    partial class ExploradorProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExploradorProductos));
            this.treeProductos = new System.Windows.Forms.TreeView();
            this.cmsTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.grpLeyenda = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.cmsTree.SuspendLayout();
            this.grpLeyenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeProductos
            // 
            this.treeProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeProductos.ContextMenuStrip = this.cmsTree;
            this.treeProductos.ImageIndex = 0;
            this.treeProductos.ImageList = this.imageList1;
            this.treeProductos.Location = new System.Drawing.Point(17, 89);
            this.treeProductos.Name = "treeProductos";
            this.treeProductos.SelectedImageIndex = 0;
            this.treeProductos.Size = new System.Drawing.Size(669, 533);
            this.treeProductos.TabIndex = 0;
            this.treeProductos.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeProductos_BeforeExpand);
            this.treeProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeProductos_MouseDown);
            // 
            // cmsTree
            // 
            this.cmsTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevo,
            this.tsmModificar,
            this.tsmEliminar});
            this.cmsTree.Name = "cmsTree";
            this.cmsTree.Size = new System.Drawing.Size(129, 70);
            this.cmsTree.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTree_Opening);
            // 
            // tsmNuevo
            // 
            this.tsmNuevo.Name = "tsmNuevo";
            this.tsmNuevo.Size = new System.Drawing.Size(128, 22);
            this.tsmNuevo.Text = "Nuevo";
            this.tsmNuevo.Click += new System.EventHandler(this.tsmNuevo_Click);
            // 
            // tsmModificar
            // 
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(128, 22);
            this.tsmModificar.Text = "Modificar";
            this.tsmModificar.Click += new System.EventHandler(this.tsmModificar_Click);
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(128, 22);
            this.tsmEliminar.Text = "Eliminar";
            this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "messagebox_warning2.png");
            this.imageList1.Images.SetKeyName(1, "kdf.png");
            this.imageList1.Images.SetKeyName(2, "proxy.png");
            this.imageList1.Images.SetKeyName(3, "ksplash.png");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipos de Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpLeyenda
            // 
            this.grpLeyenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLeyenda.Controls.Add(this.label4);
            this.grpLeyenda.Controls.Add(this.label3);
            this.grpLeyenda.Controls.Add(this.label2);
            this.grpLeyenda.Controls.Add(this.label1);
            this.grpLeyenda.Location = new System.Drawing.Point(17, 12);
            this.grpLeyenda.Name = "grpLeyenda";
            this.grpLeyenda.Size = new System.Drawing.Size(669, 71);
            this.grpLeyenda.TabIndex = 2;
            this.grpLeyenda.TabStop = false;
            this.grpLeyenda.Text = "Leyenda";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.ImageIndex = 0;
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(522, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sin Elementos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImageIndex = 3;
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(390, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Productos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageIndex = 2;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(230, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Familias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExploradorProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 634);
            this.Controls.Add(this.grpLeyenda);
            this.Controls.Add(this.treeProductos);
            this.Name = "ExploradorProductos";
            this.Text = "Explorador de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.cmsTree.ResumeLayout(false);
            this.grpLeyenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeProductos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpLeyenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsTree;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
    }
}