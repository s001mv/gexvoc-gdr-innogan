namespace GEXVOC.UI
{
    partial class EditTratProfilaxis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblPrograma = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpProPro = new System.Windows.Forms.TabPage();
            this.tspProPro = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoProPro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarProPro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarProPro = new System.Windows.Forms.ToolStripButton();
            this.dtgProPro = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpAnimales = new System.Windows.Forms.TabPage();
            this.tspAniPro = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoAniPro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarAnimal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarAniPro = new System.Windows.Forms.ToolStripButton();
            this.dtgAniPro = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbPrograma = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpProPro.SuspendLayout();
            this.tspProPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProPro)).BeginInit();
            this.tbpAnimales.SuspendLayout();
            this.tspAniPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAniPro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(26, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 74;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.AcceptsTab = true;
            this.txtDetalle.Location = new System.Drawing.Point(97, 94);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(516, 83);
            this.txtDetalle.TabIndex = 2;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(26, 94);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 73;
            this.lblDetalle.Text = "Detalle";
            // 
            // lblPrograma
            // 
            this.lblPrograma.AutoSize = true;
            this.lblPrograma.Location = new System.Drawing.Point(26, 43);
            this.lblPrograma.Name = "lblPrograma";
            this.lblPrograma.Size = new System.Drawing.Size(55, 13);
            this.lblPrograma.TabIndex = 72;
            this.lblPrograma.Text = "Programa:";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpProPro);
            this.tbcContenido.Controls.Add(this.tbpAnimales);
            this.tbcContenido.Location = new System.Drawing.Point(12, 194);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(610, 296);
            this.tbcContenido.TabIndex = 75;
            // 
            // tbpProPro
            // 
            this.tbpProPro.Controls.Add(this.tspProPro);
            this.tbpProPro.Controls.Add(this.dtgProPro);
            this.tbpProPro.Location = new System.Drawing.Point(4, 22);
            this.tbpProPro.Name = "tbpProPro";
            this.tbpProPro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProPro.Size = new System.Drawing.Size(602, 270);
            this.tbpProPro.TabIndex = 0;
            this.tbpProPro.Text = "Productos empleados";
            this.tbpProPro.UseVisualStyleBackColor = true;
            // 
            // tspProPro
            // 
            this.tspProPro.Dock = System.Windows.Forms.DockStyle.None;
            this.tspProPro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoProPro,
            this.toolStripSeparator4,
            this.tsbModificarProPro,
            this.toolStripSeparator2,
            this.tsbEliminarProPro});
            this.tspProPro.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspProPro.Location = new System.Drawing.Point(329, 240);
            this.tspProPro.Name = "tspProPro";
            this.tspProPro.Size = new System.Drawing.Size(268, 23);
            this.tspProPro.TabIndex = 30;
            this.tspProPro.Text = "toolStrip1";
            // 
            // tsbNuevoProPro
            // 
            this.tsbNuevoProPro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoProPro.AutoSize = false;
            this.tsbNuevoProPro.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoProPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoProPro.Name = "tsbNuevoProPro";
            this.tsbNuevoProPro.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoProPro.Text = " Nuevo ";
            this.tsbNuevoProPro.Click += new System.EventHandler(this.tsbNuevoProPro_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarProPro
            // 
            this.tsbModificarProPro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarProPro.AutoSize = false;
            this.tsbModificarProPro.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarProPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarProPro.Name = "tsbModificarProPro";
            this.tsbModificarProPro.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarProPro.Text = " Modificar";
            this.tsbModificarProPro.Click += new System.EventHandler(this.tsbModificarProPro_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarProPro
            // 
            this.tsbEliminarProPro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarProPro.AutoSize = false;
            this.tsbEliminarProPro.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarProPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarProPro.Name = "tsbEliminarProPro";
            this.tsbEliminarProPro.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarProPro.Text = " Eliminar ";
            this.tsbEliminarProPro.Click += new System.EventHandler(this.tsbEliminarProPro_Click);
            // 
            // dtgProPro
            // 
            this.dtgProPro.AllowUserToAddRows = false;
            this.dtgProPro.AllowUserToDeleteRows = false;
            this.dtgProPro.AllowUserToOrderColumns = true;
            this.dtgProPro.AllowUserToResizeRows = false;
            this.dtgProPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProPro.BackgroundColor = System.Drawing.Color.White;
            this.dtgProPro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgProPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.DescFamilia,
            this.Cantidad});
            this.dtgProPro.Location = new System.Drawing.Point(6, 8);
            this.dtgProPro.Name = "dtgProPro";
            this.dtgProPro.ReadOnly = true;
            this.dtgProPro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgProPro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProPro.ShowCellErrors = false;
            this.dtgProPro.ShowCellToolTips = false;
            this.dtgProPro.ShowEditingIcon = false;
            this.dtgProPro.ShowRowErrors = false;
            this.dtgProPro.Size = new System.Drawing.Size(590, 229);
            this.dtgProPro.TabIndex = 0;
            this.dtgProPro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProPro_CellDoubleClick);
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.DataPropertyName = "DescProducto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // DescFamilia
            // 
            this.DescFamilia.DataPropertyName = "DescFamilia";
            this.DescFamilia.HeaderText = "Familia";
            this.DescFamilia.Name = "DescFamilia";
            this.DescFamilia.ReadOnly = true;
            this.DescFamilia.Width = 64;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // tbpAnimales
            // 
            this.tbpAnimales.Controls.Add(this.tspAniPro);
            this.tbpAnimales.Controls.Add(this.dtgAniPro);
            this.tbpAnimales.Location = new System.Drawing.Point(4, 22);
            this.tbpAnimales.Name = "tbpAnimales";
            this.tbpAnimales.Size = new System.Drawing.Size(602, 270);
            this.tbpAnimales.TabIndex = 1;
            this.tbpAnimales.Text = "Animales Tratados";
            this.tbpAnimales.UseVisualStyleBackColor = true;
            // 
            // tspAniPro
            // 
            this.tspAniPro.Dock = System.Windows.Forms.DockStyle.None;
            this.tspAniPro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoAniPro,
            this.toolStripSeparator1,
            this.tsbModificarAnimal,
            this.toolStripSeparator3,
            this.tsbEliminarAniPro});
            this.tspAniPro.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspAniPro.Location = new System.Drawing.Point(329, 240);
            this.tspAniPro.Name = "tspAniPro";
            this.tspAniPro.Size = new System.Drawing.Size(268, 23);
            this.tspAniPro.TabIndex = 32;
            // 
            // tsbNuevoAniPro
            // 
            this.tsbNuevoAniPro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoAniPro.AutoSize = false;
            this.tsbNuevoAniPro.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoAniPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoAniPro.Name = "tsbNuevoAniPro";
            this.tsbNuevoAniPro.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoAniPro.Text = " Nuevo ";
            this.tsbNuevoAniPro.Click += new System.EventHandler(this.tsbNuevoAniPro_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarAnimal
            // 
            this.tsbModificarAnimal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarAnimal.AutoSize = false;
            this.tsbModificarAnimal.Enabled = false;
            this.tsbModificarAnimal.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarAnimal.Name = "tsbModificarAnimal";
            this.tsbModificarAnimal.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarAnimal.Text = " Modificar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarAniPro
            // 
            this.tsbEliminarAniPro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarAniPro.AutoSize = false;
            this.tsbEliminarAniPro.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarAniPro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarAniPro.Name = "tsbEliminarAniPro";
            this.tsbEliminarAniPro.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarAniPro.Text = " Eliminar ";
            this.tsbEliminarAniPro.Click += new System.EventHandler(this.tsbEliminarAniPro_Click);
            // 
            // dtgAniPro
            // 
            this.dtgAniPro.AllowUserToAddRows = false;
            this.dtgAniPro.AllowUserToDeleteRows = false;
            this.dtgAniPro.AllowUserToOrderColumns = true;
            this.dtgAniPro.AllowUserToResizeRows = false;
            this.dtgAniPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgAniPro.BackgroundColor = System.Drawing.Color.White;
            this.dtgAniPro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgAniPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAniPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dtgAniPro.Location = new System.Drawing.Point(6, 8);
            this.dtgAniPro.Name = "dtgAniPro";
            this.dtgAniPro.ReadOnly = true;
            this.dtgAniPro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgAniPro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgAniPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAniPro.ShowCellErrors = false;
            this.dtgAniPro.ShowCellToolTips = false;
            this.dtgAniPro.ShowEditingIcon = false;
            this.dtgAniPro.ShowRowErrors = false;
            this.dtgAniPro.Size = new System.Drawing.Size(590, 229);
            this.dtgAniPro.TabIndex = 31;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "DescAnimal";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(97, 68);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.Value = null;
            // 
            // cmbPrograma
            // 
            this.cmbPrograma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPrograma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbPrograma.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbPrograma.FormattingEnabled = true;
            this.cmbPrograma.Location = new System.Drawing.Point(97, 40);
            this.cmbPrograma.Name = "cmbPrograma";
            this.cmbPrograma.Size = new System.Drawing.Size(331, 21);
            this.cmbPrograma.TabIndex = 0;
            this.cmbPrograma.CargarContenido += new System.EventHandler(this.cmbPrograma_CargarContenido);
            this.cmbPrograma.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbPrograma_CrearNuevo);
            // 
            // EditTratProfilaxis
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 520);
            this.Controls.Add(this.cmbPrograma);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.tbcContenido);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblPrograma);
            this.Name = "EditTratProfilaxis";
            this.Text = "Tratamiento de Profilaxis";
            this.Controls.SetChildIndex(this.lblPrograma, 0);
            this.Controls.SetChildIndex(this.lblDetalle, 0);
            this.Controls.SetChildIndex(this.txtDetalle, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.cmbPrograma, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpProPro.ResumeLayout(false);
            this.tbpProPro.PerformLayout();
            this.tspProPro.ResumeLayout(false);
            this.tspProPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProPro)).EndInit();
            this.tbpAnimales.ResumeLayout(false);
            this.tbpAnimales.PerformLayout();
            this.tspAniPro.ResumeLayout(false);
            this.tspAniPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAniPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblPrograma;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpProPro;
        private System.Windows.Forms.ToolStrip tspProPro;
        private System.Windows.Forms.ToolStripButton tsbNuevoProPro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarProPro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarProPro;
        private System.Windows.Forms.DataGridView dtgProPro;
        private System.Windows.Forms.TabPage tbpAnimales;
        private System.Windows.Forms.ToolStrip tspAniPro;
        private System.Windows.Forms.ToolStripButton tsbNuevoAniPro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbModificarAnimal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbEliminarAniPro;
        private System.Windows.Forms.DataGridView dtgAniPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private GEXVOC.Core.Controles.ctlCombo cmbPrograma;
    }
}
