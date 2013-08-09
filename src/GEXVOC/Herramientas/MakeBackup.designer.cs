namespace GEXVOC.UI
{
    partial class MakeBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeBackup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkPath = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPathTitle = new System.Windows.Forms.Label();
            this.lvFilesB = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chCreado = new System.Windows.Forms.ColumnHeader();
            this.chSize = new System.Windows.Forms.ColumnHeader();
            this.chFullName = new System.Windows.Forms.ColumnHeader();
            this.LargeImages = new System.Windows.Forms.ImageList(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.cmsLista = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsVista = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.cmsLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkPath);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.lblListTitle);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblPathTitle);
            this.groupBox1.Controls.Add(this.lvFilesB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de copia de seguridad.";
            // 
            // lnkPath
            // 
            this.lnkPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPath.Location = new System.Drawing.Point(6, 352);
            this.lnkPath.Name = "lnkPath";
            this.lnkPath.Size = new System.Drawing.Size(587, 15);
            this.lnkPath.TabIndex = 32;
            this.lnkPath.TabStop = true;
            this.lnkPath.Text = "C:\\Backups";
            this.lnkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPath_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(509, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "&Eliminar copia";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.Location = new System.Drawing.Point(509, 61);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(84, 23);
            this.btnBackup.TabIndex = 29;
            this.btnBackup.Text = "&Iniciar copia";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(1, 16);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(171, 13);
            this.lblListTitle.TabIndex = 28;
            this.lblListTitle.Text = "Copias de seguridade encontradas";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(509, 32);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(84, 23);
            this.btnRestore.TabIndex = 27;
            this.btnRestore.Text = "&Restaurar";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(509, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "&Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPathTitle
            // 
            this.lblPathTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPathTitle.AutoSize = true;
            this.lblPathTitle.Location = new System.Drawing.Point(1, 339);
            this.lblPathTitle.Name = "lblPathTitle";
            this.lblPathTitle.Size = new System.Drawing.Size(269, 13);
            this.lblPathTitle.TabIndex = 24;
            this.lblPathTitle.Text = "Carpeta de almacenamento de las copias de seguridad:";
            // 
            // lvFilesB
            // 
            this.lvFilesB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFilesB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chCreado,
            this.chSize,
            this.chFullName});
            this.lvFilesB.FullRowSelect = true;
            this.lvFilesB.HideSelection = false;
            this.lvFilesB.LargeImageList = this.LargeImages;
            this.lvFilesB.Location = new System.Drawing.Point(4, 32);
            this.lvFilesB.Name = "lvFilesB";
            this.lvFilesB.ShowItemToolTips = true;
            this.lvFilesB.Size = new System.Drawing.Size(499, 304);
            this.lvFilesB.SmallImageList = this.Images;
            this.lvFilesB.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvFilesB.StateImageList = this.Images;
            this.lvFilesB.TabIndex = 23;
            this.lvFilesB.TileSize = new System.Drawing.Size(100, 100);
            this.lvFilesB.UseCompatibleStateImageBehavior = false;
            this.lvFilesB.View = System.Windows.Forms.View.Details;
            this.lvFilesB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvFilesB_MouseDown);
            // 
            // chName
            // 
            this.chName.Text = "Nombre";
            this.chName.Width = 195;
            // 
            // chCreado
            // 
            this.chCreado.Text = "Fecha Creación";
            this.chCreado.Width = 120;
            // 
            // chSize
            // 
            this.chSize.Text = "Tamaño";
            this.chSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chSize.Width = 80;
            // 
            // chFullName
            // 
            this.chFullName.Text = "Ruta completa";
            this.chFullName.Width = 607;
            // 
            // LargeImages
            // 
            this.LargeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeImages.ImageStream")));
            this.LargeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeImages.Images.SetKeyName(0, "BigDB.bmp");
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "db.ico");
            // 
            // cmsLista
            // 
            this.cmsLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsVista,
            this.cmsSeparator1,
            this.cmsRestore,
            this.cmsDelete});
            this.cmsLista.Name = "cmsLista";
            this.cmsLista.Size = new System.Drawing.Size(186, 76);
            this.cmsLista.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsLista_ItemClicked);
            // 
            // cmsVista
            // 
            this.cmsVista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsLargeIcon,
            this.cmsSmallIcon,
            this.cmsTile,
            this.cmsList,
            this.cmsDetails});
            this.cmsVista.Name = "cmsVista";
            this.cmsVista.Size = new System.Drawing.Size(185, 22);
            this.cmsVista.Tag = "VISTA";
            this.cmsVista.Text = "Vista";
            // 
            // cmsLargeIcon
            // 
            this.cmsLargeIcon.Name = "cmsLargeIcon";
            this.cmsLargeIcon.Size = new System.Drawing.Size(167, 22);
            this.cmsLargeIcon.Tag = "LARGEICON";
            this.cmsLargeIcon.Text = "Iconos grandes";
            this.cmsLargeIcon.Click += new System.EventHandler(this.cmsLargeIcon_Click);
            // 
            // cmsSmallIcon
            // 
            this.cmsSmallIcon.Name = "cmsSmallIcon";
            this.cmsSmallIcon.Size = new System.Drawing.Size(167, 22);
            this.cmsSmallIcon.Tag = "SMALLICON";
            this.cmsSmallIcon.Text = "Iconos pequeños";
            this.cmsSmallIcon.Click += new System.EventHandler(this.cmsSmallIcon_Click);
            // 
            // cmsTile
            // 
            this.cmsTile.Name = "cmsTile";
            this.cmsTile.Size = new System.Drawing.Size(167, 22);
            this.cmsTile.Tag = "TILE";
            this.cmsTile.Text = "Mosaico";
            this.cmsTile.Click += new System.EventHandler(this.cmsTile_Click);
            // 
            // cmsList
            // 
            this.cmsList.Name = "cmsList";
            this.cmsList.Size = new System.Drawing.Size(167, 22);
            this.cmsList.Tag = "LIST";
            this.cmsList.Text = "Lista";
            this.cmsList.Click += new System.EventHandler(this.cmsList_Click);
            // 
            // cmsDetails
            // 
            this.cmsDetails.Name = "cmsDetails";
            this.cmsDetails.Size = new System.Drawing.Size(167, 22);
            this.cmsDetails.Tag = "DETAILS";
            this.cmsDetails.Text = "Detalles";
            this.cmsDetails.Click += new System.EventHandler(this.cmsDetails_Click);
            // 
            // cmsSeparator1
            // 
            this.cmsSeparator1.Name = "cmsSeparator1";
            this.cmsSeparator1.Size = new System.Drawing.Size(182, 6);
            this.cmsSeparator1.Tag = "SPACE";
            // 
            // cmsRestore
            // 
            this.cmsRestore.Name = "cmsRestore";
            this.cmsRestore.Size = new System.Drawing.Size(185, 22);
            this.cmsRestore.Tag = "RESTORE";
            this.cmsRestore.Text = "Restaurar esta copia";
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(185, 22);
            this.cmsDelete.Tag = "DELETE";
            this.cmsDelete.Text = "Eliminar esta copia";
            // 
            // MakeBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 403);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeBackup";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de copias de seguridad";
            this.Load += new System.EventHandler(this.MakeBackup_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MakeBackup_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPathTitle;
        private System.Windows.Forms.ListView lvFilesB;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.LinkLabel lnkPath;
        private System.Windows.Forms.ContextMenuStrip cmsLista;
        private System.Windows.Forms.ToolStripMenuItem cmsVista;
        private System.Windows.Forms.ToolStripMenuItem cmsLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem cmsSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem cmsTile;
        private System.Windows.Forms.ToolStripMenuItem cmsList;
        private System.Windows.Forms.ToolStripMenuItem cmsDetails;
        private System.Windows.Forms.ToolStripSeparator cmsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsRestore;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCreado;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chFullName;
        private System.Windows.Forms.ImageList LargeImages;
    }
}