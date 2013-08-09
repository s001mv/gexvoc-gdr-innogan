namespace GEXVOC.UI
{
    partial class EditFamilia
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbTipoProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpContenido = new System.Windows.Forms.TabPage();
            this.tspProductos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarProducto = new System.Windows.Forms.ToolStripButton();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.gvtDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpContenido.SuspendLayout();
            this.tspProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 54);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(110, 54);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(350, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTipoProducto.btnBusqueda = null;
            this.cmbTipoProducto.ClaseActiva = null;
            this.cmbTipoProducto.ControlVisible = true;
            this.cmbTipoProducto.DisplayMember = "Descripcion";
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.IdClaseActiva = 0;
            this.cmbTipoProducto.Location = new System.Drawing.Point(299, 28);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.PermitirEliminar = true;
            this.cmbTipoProducto.PermitirLimpiar = true;
            this.cmbTipoProducto.ReadOnly = false;
            this.cmbTipoProducto.Size = new System.Drawing.Size(148, 21);
            this.cmbTipoProducto.TabIndex = 136;
            this.cmbTipoProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbTipoProducto.TipoDatos = null;
            this.cmbTipoProducto.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(257, 31);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 13);
            this.lblTipo.TabIndex = 137;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Visible = false;
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpContenido);
            this.tbcContenido.Location = new System.Drawing.Point(12, 92);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(472, 290);
            this.tbcContenido.TabIndex = 138;
            // 
            // tbpContenido
            // 
            this.tbpContenido.Controls.Add(this.tspProductos);
            this.tbpContenido.Controls.Add(this.dtgProductos);
            this.tbpContenido.Location = new System.Drawing.Point(4, 22);
            this.tbpContenido.Name = "tbpContenido";
            this.tbpContenido.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContenido.Size = new System.Drawing.Size(464, 264);
            this.tbpContenido.TabIndex = 0;
            this.tbpContenido.Text = "Productos";
            this.tbpContenido.UseVisualStyleBackColor = true;
            // 
            // tspProductos
            // 
            this.tspProductos.Dock = System.Windows.Forms.DockStyle.None;
            this.tspProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoProducto,
            this.toolStripSeparator4,
            this.tsbModificarProducto,
            this.toolStripSeparator2,
            this.tsbEliminarProducto});
            this.tspProductos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspProductos.Location = new System.Drawing.Point(175, 237);
            this.tspProductos.Name = "tspProductos";
            this.tspProductos.Size = new System.Drawing.Size(268, 23);
            this.tspProductos.TabIndex = 30;
            this.tspProductos.Text = "toolStrip1";
            // 
            // tsbNuevoProducto
            // 
            this.tsbNuevoProducto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoProducto.AutoSize = false;
            this.tsbNuevoProducto.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoProducto.Name = "tsbNuevoProducto";
            this.tsbNuevoProducto.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoProducto.Text = " Nuevo ";
            this.tsbNuevoProducto.Click += new System.EventHandler(this.tsbNuevoProducto_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarProducto
            // 
            this.tsbModificarProducto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarProducto.AutoSize = false;
            this.tsbModificarProducto.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarProducto.Name = "tsbModificarProducto";
            this.tsbModificarProducto.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarProducto.Text = " Modificar";
            this.tsbModificarProducto.Click += new System.EventHandler(this.tsbModificarProducto_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarProducto
            // 
            this.tsbEliminarProducto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarProducto.AutoSize = false;
            this.tsbEliminarProducto.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarProducto.Name = "tsbEliminarProducto";
            this.tsbEliminarProducto.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarProducto.Text = " Eliminar ";
            this.tsbEliminarProducto.Click += new System.EventHandler(this.tsbEliminarProducto_Click);
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToDeleteRows = false;
            this.dtgProductos.AllowUserToOrderColumns = true;
            this.dtgProductos.AllowUserToResizeRows = false;
            this.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProductos.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvtDescripcion});
            this.dtgProductos.Location = new System.Drawing.Point(6, 5);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            this.dtgProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.ShowCellErrors = false;
            this.dtgProductos.ShowCellToolTips = false;
            this.dtgProductos.ShowEditingIcon = false;
            this.dtgProductos.ShowRowErrors = false;
            this.dtgProductos.Size = new System.Drawing.Size(438, 229);
            this.dtgProductos.TabIndex = 15;
            this.dtgProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellDoubleClick);
            // 
            // gvtDescripcion
            // 
            this.gvtDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvtDescripcion.DataPropertyName = "Descripcion";
            this.gvtDescripcion.HeaderText = "Descripción";
            this.gvtDescripcion.Name = "gvtDescripcion";
            this.gvtDescripcion.ReadOnly = true;
            // 
            // EditFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(496, 408);
            this.Controls.Add(this.tbcContenido);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "EditFamilia";
            this.Text = "Familia";
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.cmbTipoProducto, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpContenido.ResumeLayout(false);
            this.tbpContenido.PerformLayout();
            this.tspProductos.ResumeLayout(false);
            this.tspProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbTipoProducto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpContenido;
        private System.Windows.Forms.ToolStrip tspProductos;
        private System.Windows.Forms.ToolStripButton tsbNuevoProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarProducto;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvtDescripcion;
    }
}
