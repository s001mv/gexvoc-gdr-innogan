namespace GEXVOC.UI
{
    partial class EditCubricion
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
            this.cmbLote = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnbuscarLote = new System.Windows.Forms.Button();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpContenido = new System.Windows.Forms.TabPage();
            this.dtgContenido = new System.Windows.Forms.DataGridView();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspProductos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoContenido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarContenido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarContenido = new System.Windows.Forms.ToolStripButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtFechaIni = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbTipo = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenido)).BeginInit();
            this.tspProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLote
            // 
            this.cmbLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbLote.btnBusqueda = this.btnbuscarLote;
            this.cmbLote.ClaseActiva = null;
            this.cmbLote.ControlVisible = true;
            this.cmbLote.DisplayMember = "Descripcion";
            this.cmbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.IdClaseActiva = 0;
            this.cmbLote.Location = new System.Drawing.Point(109, 35);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.PermitirEliminar = true;
            this.cmbLote.PermitirLimpiar = true;
            this.cmbLote.ReadOnly = false;
            this.cmbLote.Size = new System.Drawing.Size(196, 21);
            this.cmbLote.TabIndex = 0;
            this.cmbLote.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbLote.TipoDatos = null;
            this.cmbLote.CrearNuevo += new System.EventHandler(this.cmbLote_CrearNuevo);
            // 
            // btnbuscarLote
            // 
            this.btnbuscarLote.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnbuscarLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnbuscarLote.Location = new System.Drawing.Point(311, 35);
            this.btnbuscarLote.Name = "btnbuscarLote";
            this.btnbuscarLote.Size = new System.Drawing.Size(21, 21);
            this.btnbuscarLote.TabIndex = 1;
            this.btnbuscarLote.UseVisualStyleBackColor = true;
            this.btnbuscarLote.Click += new System.EventHandler(this.btnbuscarLote_Click);
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLote.Location = new System.Drawing.Point(17, 39);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 99;
            this.lblLote.Text = "Lote:";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaIni.Location = new System.Drawing.Point(17, 94);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(70, 13);
            this.lblFechaIni.TabIndex = 131;
            this.lblFechaIni.Text = "Fecha Inicial:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaFin.Location = new System.Drawing.Point(225, 94);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(65, 13);
            this.lblFechaFin.TabIndex = 133;
            this.lblFechaFin.Text = "Fecha Final:";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpContenido);
            this.tbcContenido.Location = new System.Drawing.Point(12, 126);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(472, 290);
            this.tbcContenido.TabIndex = 5;
            // 
            // tbpContenido
            // 
            this.tbpContenido.Controls.Add(this.dtgContenido);
            this.tbpContenido.Controls.Add(this.tspProductos);
            this.tbpContenido.Location = new System.Drawing.Point(4, 22);
            this.tbpContenido.Name = "tbpContenido";
            this.tbpContenido.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContenido.Size = new System.Drawing.Size(464, 264);
            this.tbpContenido.TabIndex = 0;
            this.tbpContenido.Text = "Estancias / Machos ";
            this.tbpContenido.UseVisualStyleBackColor = true;
            // 
            // dtgContenido
            // 
            this.dtgContenido.AllowUserToAddRows = false;
            this.dtgContenido.AllowUserToDeleteRows = false;
            this.dtgContenido.AllowUserToOrderColumns = true;
            this.dtgContenido.AllowUserToResizeRows = false;
            this.dtgContenido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgContenido.BackgroundColor = System.Drawing.Color.White;
            this.dtgContenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContenido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaInicio,
            this.FechaFin,
            this.Descripcion});
            this.dtgContenido.Location = new System.Drawing.Point(6, 5);
            this.dtgContenido.Name = "dtgContenido";
            this.dtgContenido.ReadOnly = true;
            this.dtgContenido.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgContenido.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgContenido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContenido.ShowCellErrors = false;
            this.dtgContenido.ShowCellToolTips = false;
            this.dtgContenido.ShowEditingIcon = false;
            this.dtgContenido.ShowRowErrors = false;
            this.dtgContenido.Size = new System.Drawing.Size(438, 229);
            this.dtgContenido.TabIndex = 0;
            this.dtgContenido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenido_CellDoubleClick);
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 90;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 79;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "DescMacho";
            this.Descripcion.HeaderText = "Macho";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // tspProductos
            // 
            this.tspProductos.Dock = System.Windows.Forms.DockStyle.None;
            this.tspProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoContenido,
            this.toolStripSeparator4,
            this.tsbModificarContenido,
            this.toolStripSeparator2,
            this.tsbEliminarContenido});
            this.tspProductos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspProductos.Location = new System.Drawing.Point(175, 237);
            this.tspProductos.Name = "tspProductos";
            this.tspProductos.Size = new System.Drawing.Size(268, 23);
            this.tspProductos.TabIndex = 30;
            this.tspProductos.Text = "toolStrip1";
            // 
            // tsbNuevoContenido
            // 
            this.tsbNuevoContenido.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoContenido.AutoSize = false;
            this.tsbNuevoContenido.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoContenido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoContenido.Name = "tsbNuevoContenido";
            this.tsbNuevoContenido.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoContenido.Text = " Nuevo ";
            this.tsbNuevoContenido.Click += new System.EventHandler(this.tsbNuevoContenido_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarContenido
            // 
            this.tsbModificarContenido.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarContenido.AutoSize = false;
            this.tsbModificarContenido.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarContenido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarContenido.Name = "tsbModificarContenido";
            this.tsbModificarContenido.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarContenido.Text = " Modificar";
            this.tsbModificarContenido.Click += new System.EventHandler(this.tsbModificarContenido_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarContenido
            // 
            this.tsbEliminarContenido.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarContenido.AutoSize = false;
            this.tsbEliminarContenido.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarContenido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarContenido.Name = "tsbEliminarContenido";
            this.tsbEliminarContenido.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarContenido.Text = " Eliminar ";
            this.tsbEliminarContenido.Click += new System.EventHandler(this.tsbEliminarContenido_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(17, 65);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 141;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtFechaIni
            // 
            this.txtFechaIni.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaIni.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaIni.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaIni.Location = new System.Drawing.Point(109, 91);
            this.txtFechaIni.Name = "txtFechaIni";
            this.txtFechaIni.ReadOnly = false;
            this.txtFechaIni.Size = new System.Drawing.Size(88, 20);
            this.txtFechaIni.TabIndex = 3;
            this.txtFechaIni.Value = null;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(311, 94);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 4;
            this.txtFechaFin.Value = null;
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(109, 62);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(223, 21);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.CargarContenido += new System.EventHandler(this.cmbTipo_CargarContenido);
            this.cmbTipo.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbTipo_CrearNuevo);
            // 
            // EditCubricion
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(496, 442);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaIni);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.tbcContenido);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.cmbLote);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.btnbuscarLote);
            this.Name = "EditCubricion";
            this.Text = "Cubrición";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditCubricion_PropiedadAControl);
            this.Controls.SetChildIndex(this.btnbuscarLote, 0);
            this.Controls.SetChildIndex(this.lblLote, 0);
            this.Controls.SetChildIndex(this.cmbLote, 0);
            this.Controls.SetChildIndex(this.lblFechaIni, 0);
            this.Controls.SetChildIndex(this.lblFechaFin, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.txtFechaIni, 0);
            this.Controls.SetChildIndex(this.txtFechaFin, 0);
            this.Controls.SetChildIndex(this.cmbTipo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpContenido.ResumeLayout(false);
            this.tbpContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenido)).EndInit();
            this.tspProductos.ResumeLayout(false);
            this.tspProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLote;
        private System.Windows.Forms.Button btnbuscarLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpContenido;
        private System.Windows.Forms.ToolStrip tspProductos;
        private System.Windows.Forms.ToolStripButton tsbNuevoContenido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarContenido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarContenido;
        private System.Windows.Forms.DataGridView dtgContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label lblTipo;
        private GEXVOC.Core.Controles.ctlFecha txtFechaIni;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
        private GEXVOC.Core.Controles.ctlCombo cmbTipo;
    }
}
