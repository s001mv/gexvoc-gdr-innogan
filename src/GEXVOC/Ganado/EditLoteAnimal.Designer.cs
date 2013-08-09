namespace GEXVOC.UI
{
    partial class EditLoteAnimal
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
            this.cmbExplotacion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarExplotacion = new System.Windows.Forms.Button();
            this.lblExplotacion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpContenido = new System.Windows.Forms.TabPage();
            this.tspProductos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoContenido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarContenido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarContenido = new System.Windows.Forms.ToolStripButton();
            this.dtgContenido = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCubriciones = new System.Windows.Forms.TabPage();
            this.tspCubriciones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevaCubricion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarCubricion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarCubricion = new System.Windows.Forms.ToolStripButton();
            this.dtgCubriciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpLotes = new System.Windows.Forms.TabPage();
            this.tspLotes = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoLote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarLote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarLote = new System.Windows.Forms.ToolStripButton();
            this.dtgLotes = new System.Windows.Forms.DataGridView();
            this.dtgLotes_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLotes_FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLotes_FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecBaja = new System.Windows.Forms.Label();
            this.lblFecAlta = new System.Windows.Forms.Label();
            this.chkParidera = new System.Windows.Forms.CheckBox();
            this.lblTipoLote = new System.Windows.Forms.Label();
            this.txtFechaAlta = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaBaja = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbTipoLote = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpContenido.SuspendLayout();
            this.tspProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenido)).BeginInit();
            this.tbpCubriciones.SuspendLayout();
            this.tspCubriciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCubriciones)).BeginInit();
            this.tbpLotes.SuspendLayout();
            this.tspLotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbExplotacion
            // 
            this.cmbExplotacion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbExplotacion.btnBusqueda = this.btnBuscarExplotacion;
            this.cmbExplotacion.ClaseActiva = null;
            this.cmbExplotacion.ControlVisible = true;
            this.cmbExplotacion.DisplayMember = "Nombre";
            this.cmbExplotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbExplotacion.FormattingEnabled = true;
            this.cmbExplotacion.IdClaseActiva = 0;
            this.cmbExplotacion.Location = new System.Drawing.Point(122, 43);
            this.cmbExplotacion.Name = "cmbExplotacion";
            this.cmbExplotacion.PermitirEliminar = true;
            this.cmbExplotacion.PermitirLimpiar = true;
            this.cmbExplotacion.ReadOnly = false;
            this.cmbExplotacion.Size = new System.Drawing.Size(358, 21);
            this.cmbExplotacion.TabIndex = 0;
            this.cmbExplotacion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbExplotacion.TipoDatos = null;
            // 
            // btnBuscarExplotacion
            // 
            this.btnBuscarExplotacion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarExplotacion.Location = new System.Drawing.Point(486, 43);
            this.btnBuscarExplotacion.Name = "btnBuscarExplotacion";
            this.btnBuscarExplotacion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarExplotacion.TabIndex = 1;
            this.btnBuscarExplotacion.UseVisualStyleBackColor = true;
            this.btnBuscarExplotacion.Click += new System.EventHandler(this.btnBuscarExplotacion_Click);
            // 
            // lblExplotacion
            // 
            this.lblExplotacion.AutoSize = true;
            this.lblExplotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExplotacion.Location = new System.Drawing.Point(18, 47);
            this.lblExplotacion.Name = "lblExplotacion";
            this.lblExplotacion.Size = new System.Drawing.Size(77, 13);
            this.lblExplotacion.TabIndex = 135;
            this.lblExplotacion.Text = "Explotacion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 97);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(385, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 137;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpContenido);
            this.tbcContenido.Controls.Add(this.tbpCubriciones);
            this.tbcContenido.Controls.Add(this.tbpLotes);
            this.tbcContenido.Location = new System.Drawing.Point(20, 161);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(493, 290);
            this.tbcContenido.TabIndex = 7;
            // 
            // tbpContenido
            // 
            this.tbpContenido.Controls.Add(this.tspProductos);
            this.tbpContenido.Controls.Add(this.dtgContenido);
            this.tbpContenido.Location = new System.Drawing.Point(4, 22);
            this.tbpContenido.Name = "tbpContenido";
            this.tbpContenido.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContenido.Size = new System.Drawing.Size(485, 264);
            this.tbpContenido.TabIndex = 0;
            this.tbpContenido.Text = "Animales";
            this.tbpContenido.UseVisualStyleBackColor = true;
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
            this.tspProductos.Location = new System.Drawing.Point(210, 237);
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
            this.Fecha,
            this.Sexo,
            this.Identificador,
            this.Nombre});
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
            this.dtgContenido.Size = new System.Drawing.Size(473, 229);
            this.dtgContenido.TabIndex = 15;
            this.dtgContenido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContenido_CellDoubleClick);
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaInicio";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sexo.DataPropertyName = "DescAnimalSexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 40;
            // 
            // Identificador
            // 
            this.Identificador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Identificador.DataPropertyName = "DescAnimalIdentificador";
            this.Identificador.HeaderText = "Indentificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "DescAnimalNombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // tbpCubriciones
            // 
            this.tbpCubriciones.Controls.Add(this.tspCubriciones);
            this.tbpCubriciones.Controls.Add(this.dtgCubriciones);
            this.tbpCubriciones.Location = new System.Drawing.Point(4, 22);
            this.tbpCubriciones.Name = "tbpCubriciones";
            this.tbpCubriciones.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCubriciones.Size = new System.Drawing.Size(485, 264);
            this.tbpCubriciones.TabIndex = 1;
            this.tbpCubriciones.Text = "Cubriciones";
            this.tbpCubriciones.UseVisualStyleBackColor = true;
            // 
            // tspCubriciones
            // 
            this.tspCubriciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tspCubriciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevaCubricion,
            this.toolStripSeparator1,
            this.tsbModificarCubricion,
            this.toolStripSeparator3,
            this.tsbEliminarCubricion});
            this.tspCubriciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspCubriciones.Location = new System.Drawing.Point(210, 238);
            this.tspCubriciones.Name = "tspCubriciones";
            this.tspCubriciones.Size = new System.Drawing.Size(268, 23);
            this.tspCubriciones.TabIndex = 31;
            this.tspCubriciones.Text = "toolStrip1";
            // 
            // tsbNuevaCubricion
            // 
            this.tsbNuevaCubricion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevaCubricion.AutoSize = false;
            this.tsbNuevaCubricion.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevaCubricion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevaCubricion.Name = "tsbNuevaCubricion";
            this.tsbNuevaCubricion.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevaCubricion.Text = " Nuevo ";
            this.tsbNuevaCubricion.Click += new System.EventHandler(this.tsbNuevaCubricion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarCubricion
            // 
            this.tsbModificarCubricion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarCubricion.AutoSize = false;
            this.tsbModificarCubricion.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarCubricion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarCubricion.Name = "tsbModificarCubricion";
            this.tsbModificarCubricion.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarCubricion.Text = " Modificar";
            this.tsbModificarCubricion.Click += new System.EventHandler(this.tsbModificarCubricion_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarCubricion
            // 
            this.tsbEliminarCubricion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarCubricion.AutoSize = false;
            this.tsbEliminarCubricion.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarCubricion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarCubricion.Name = "tsbEliminarCubricion";
            this.tsbEliminarCubricion.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarCubricion.Text = " Eliminar ";
            this.tsbEliminarCubricion.Click += new System.EventHandler(this.tsbEliminarCubricion_Click);
            // 
            // dtgCubriciones
            // 
            this.dtgCubriciones.AllowUserToAddRows = false;
            this.dtgCubriciones.AllowUserToDeleteRows = false;
            this.dtgCubriciones.AllowUserToOrderColumns = true;
            this.dtgCubriciones.AllowUserToResizeRows = false;
            this.dtgCubriciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgCubriciones.BackgroundColor = System.Drawing.Color.White;
            this.dtgCubriciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCubriciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCubriciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FechaFin});
            this.dtgCubriciones.Location = new System.Drawing.Point(6, 5);
            this.dtgCubriciones.Name = "dtgCubriciones";
            this.dtgCubriciones.ReadOnly = true;
            this.dtgCubriciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgCubriciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgCubriciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCubriciones.ShowCellErrors = false;
            this.dtgCubriciones.ShowCellToolTips = false;
            this.dtgCubriciones.ShowEditingIcon = false;
            this.dtgCubriciones.ShowRowErrors = false;
            this.dtgCubriciones.Size = new System.Drawing.Size(473, 229);
            this.dtgCubriciones.TabIndex = 16;
            this.dtgCubriciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCubriciones_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FechaInicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha Inicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 79;
            // 
            // tbpLotes
            // 
            this.tbpLotes.Controls.Add(this.tspLotes);
            this.tbpLotes.Controls.Add(this.dtgLotes);
            this.tbpLotes.Location = new System.Drawing.Point(4, 22);
            this.tbpLotes.Name = "tbpLotes";
            this.tbpLotes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLotes.Size = new System.Drawing.Size(485, 264);
            this.tbpLotes.TabIndex = 2;
            this.tbpLotes.Text = "Lotes";
            this.tbpLotes.UseVisualStyleBackColor = true;
            // 
            // tspLotes
            // 
            this.tspLotes.Dock = System.Windows.Forms.DockStyle.None;
            this.tspLotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoLote,
            this.toolStripSeparator5,
            this.tsbModificarLote,
            this.toolStripSeparator6,
            this.tsbEliminarLote});
            this.tspLotes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspLotes.Location = new System.Drawing.Point(210, 237);
            this.tspLotes.Name = "tspLotes";
            this.tspLotes.Size = new System.Drawing.Size(268, 23);
            this.tspLotes.TabIndex = 33;
            // 
            // tsbNuevoLote
            // 
            this.tsbNuevoLote.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoLote.AutoSize = false;
            this.tsbNuevoLote.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoLote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoLote.Name = "tsbNuevoLote";
            this.tsbNuevoLote.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoLote.Text = " Nuevo ";
            this.tsbNuevoLote.Click += new System.EventHandler(this.tsbNuevoLote_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarLote
            // 
            this.tsbModificarLote.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarLote.AutoSize = false;
            this.tsbModificarLote.Enabled = false;
            this.tsbModificarLote.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarLote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarLote.Name = "tsbModificarLote";
            this.tsbModificarLote.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarLote.Text = " Modificar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarLote
            // 
            this.tsbEliminarLote.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarLote.AutoSize = false;
            this.tsbEliminarLote.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarLote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarLote.Name = "tsbEliminarLote";
            this.tsbEliminarLote.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarLote.Text = " Eliminar ";
            this.tsbEliminarLote.Click += new System.EventHandler(this.tsbEliminarLote_Click);
            // 
            // dtgLotes
            // 
            this.dtgLotes.AllowUserToAddRows = false;
            this.dtgLotes.AllowUserToDeleteRows = false;
            this.dtgLotes.AllowUserToOrderColumns = true;
            this.dtgLotes.AllowUserToResizeRows = false;
            this.dtgLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgLotes.BackgroundColor = System.Drawing.Color.White;
            this.dtgLotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgLotes_Descripcion,
            this.dtgLotes_FechaInicio,
            this.dtgLotes_FechaFin});
            this.dtgLotes.Location = new System.Drawing.Point(6, 4);
            this.dtgLotes.Name = "dtgLotes";
            this.dtgLotes.ReadOnly = true;
            this.dtgLotes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgLotes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLotes.ShowCellErrors = false;
            this.dtgLotes.ShowCellToolTips = false;
            this.dtgLotes.ShowEditingIcon = false;
            this.dtgLotes.ShowRowErrors = false;
            this.dtgLotes.Size = new System.Drawing.Size(473, 229);
            this.dtgLotes.TabIndex = 32;
            // 
            // dtgLotes_Descripcion
            // 
            this.dtgLotes_Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgLotes_Descripcion.DataPropertyName = "Descripcion";
            this.dtgLotes_Descripcion.HeaderText = "Descripción";
            this.dtgLotes_Descripcion.Name = "dtgLotes_Descripcion";
            this.dtgLotes_Descripcion.ReadOnly = true;
            // 
            // dtgLotes_FechaInicio
            // 
            this.dtgLotes_FechaInicio.DataPropertyName = "FechaAlta";
            this.dtgLotes_FechaInicio.HeaderText = "Fecha Alta";
            this.dtgLotes_FechaInicio.Name = "dtgLotes_FechaInicio";
            this.dtgLotes_FechaInicio.ReadOnly = true;
            this.dtgLotes_FechaInicio.Width = 83;
            // 
            // dtgLotes_FechaFin
            // 
            this.dtgLotes_FechaFin.DataPropertyName = "FechaBaja";
            this.dtgLotes_FechaFin.HeaderText = "Fecha Baja";
            this.dtgLotes_FechaFin.Name = "dtgLotes_FechaFin";
            this.dtgLotes_FechaFin.ReadOnly = true;
            this.dtgLotes_FechaFin.Width = 86;
            // 
            // lblFecBaja
            // 
            this.lblFecBaja.AutoSize = true;
            this.lblFecBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecBaja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecBaja.Location = new System.Drawing.Point(224, 126);
            this.lblFecBaja.Name = "lblFecBaja";
            this.lblFecBaja.Size = new System.Drawing.Size(64, 13);
            this.lblFecBaja.TabIndex = 161;
            this.lblFecBaja.Text = "Fecha Baja:";
            // 
            // lblFecAlta
            // 
            this.lblFecAlta.AutoSize = true;
            this.lblFecAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecAlta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecAlta.Location = new System.Drawing.Point(18, 126);
            this.lblFecAlta.Name = "lblFecAlta";
            this.lblFecAlta.Size = new System.Drawing.Size(72, 13);
            this.lblFecAlta.TabIndex = 160;
            this.lblFecAlta.Text = "Fecha Alta:";
            // 
            // chkParidera
            // 
            this.chkParidera.AutoSize = true;
            this.chkParidera.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkParidera.Enabled = false;
            this.chkParidera.Location = new System.Drawing.Point(442, 126);
            this.chkParidera.Name = "chkParidera";
            this.chkParidera.Size = new System.Drawing.Size(65, 17);
            this.chkParidera.TabIndex = 6;
            this.chkParidera.Text = "Paridera";
            this.chkParidera.UseVisualStyleBackColor = true;
            this.chkParidera.Visible = false;
            this.chkParidera.CheckedChanged += new System.EventHandler(this.chkParidera_CheckedChanged);
            // 
            // lblTipoLote
            // 
            this.lblTipoLote.AutoSize = true;
            this.lblTipoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipoLote.Location = new System.Drawing.Point(18, 73);
            this.lblTipoLote.Name = "lblTipoLote";
            this.lblTipoLote.Size = new System.Drawing.Size(65, 13);
            this.lblTipoLote.TabIndex = 164;
            this.lblTipoLote.Text = "Tipo Lote:";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaAlta.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaAlta.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaAlta.Location = new System.Drawing.Point(122, 126);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.ReadOnly = false;
            this.txtFechaAlta.Size = new System.Drawing.Size(88, 20);
            this.txtFechaAlta.TabIndex = 4;
            this.txtFechaAlta.Value = null;
            // 
            // txtFechaBaja
            // 
            this.txtFechaBaja.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaBaja.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaBaja.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaBaja.Location = new System.Drawing.Point(294, 126);
            this.txtFechaBaja.Name = "txtFechaBaja";
            this.txtFechaBaja.ReadOnly = false;
            this.txtFechaBaja.Size = new System.Drawing.Size(88, 20);
            this.txtFechaBaja.TabIndex = 5;
            this.txtFechaBaja.Value = null;
            // 
            // cmbTipoLote
            // 
            this.cmbTipoLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbTipoLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbTipoLote.FormattingEnabled = true;
            this.cmbTipoLote.Location = new System.Drawing.Point(122, 70);
            this.cmbTipoLote.Name = "cmbTipoLote";
            this.cmbTipoLote.Size = new System.Drawing.Size(260, 21);
            this.cmbTipoLote.TabIndex = 2;
            this.cmbTipoLote.CargarContenido += new System.EventHandler(this.cmbTipoLote_CargarContenido);
            this.cmbTipoLote.SelectedValueChanged += new System.EventHandler(this.cmbTipoLote_SelectedValueChanged);
            this.cmbTipoLote.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbTipoLote_CrearNuevo);
            // 
            // EditLoteAnimal
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(530, 477);
            this.Controls.Add(this.cmbTipoLote);
            this.Controls.Add(this.txtFechaBaja);
            this.Controls.Add(this.txtFechaAlta);
            this.Controls.Add(this.lblTipoLote);
            this.Controls.Add(this.lblFecBaja);
            this.Controls.Add(this.lblFecAlta);
            this.Controls.Add(this.tbcContenido);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cmbExplotacion);
            this.Controls.Add(this.btnBuscarExplotacion);
            this.Controls.Add(this.lblExplotacion);
            this.Controls.Add(this.chkParidera);
            this.Name = "EditLoteAnimal";
            this.TabControlPrincipal = this.tbcContenido;
            this.Text = "Lote Animal";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditLoteAnimal_PropiedadAControl);
            this.Load += new System.EventHandler(this.EditLoteAnimal_Load);
            this.ModoCambiado += new System.EventHandler<GEXVOC.UI.ModoEventArgs>(this.EditLoteAnimal_ModoCambiado);
            this.Controls.SetChildIndex(this.chkParidera, 0);
            this.Controls.SetChildIndex(this.lblExplotacion, 0);
            this.Controls.SetChildIndex(this.btnBuscarExplotacion, 0);
            this.Controls.SetChildIndex(this.cmbExplotacion, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            this.Controls.SetChildIndex(this.lblFecAlta, 0);
            this.Controls.SetChildIndex(this.lblFecBaja, 0);
            this.Controls.SetChildIndex(this.lblTipoLote, 0);
            this.Controls.SetChildIndex(this.txtFechaAlta, 0);
            this.Controls.SetChildIndex(this.txtFechaBaja, 0);
            this.Controls.SetChildIndex(this.cmbTipoLote, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpContenido.ResumeLayout(false);
            this.tbpContenido.PerformLayout();
            this.tspProductos.ResumeLayout(false);
            this.tspProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContenido)).EndInit();
            this.tbpCubriciones.ResumeLayout(false);
            this.tbpCubriciones.PerformLayout();
            this.tspCubriciones.ResumeLayout(false);
            this.tspCubriciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCubriciones)).EndInit();
            this.tbpLotes.ResumeLayout(false);
            this.tbpLotes.PerformLayout();
            this.tspLotes.ResumeLayout(false);
            this.tspLotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbExplotacion;
        private System.Windows.Forms.Button btnBuscarExplotacion;
        private System.Windows.Forms.Label lblExplotacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpContenido;
        private System.Windows.Forms.ToolStrip tspProductos;
        private System.Windows.Forms.ToolStripButton tsbNuevoContenido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarContenido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarContenido;
        private System.Windows.Forms.DataGridView dtgContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label lblFecBaja;
        private System.Windows.Forms.Label lblFecAlta;
        private System.Windows.Forms.TabPage tbpCubriciones;
        private System.Windows.Forms.ToolStrip tspCubriciones;
        private System.Windows.Forms.ToolStripButton tsbNuevaCubricion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbModificarCubricion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbEliminarCubricion;
        private System.Windows.Forms.DataGridView dtgCubriciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.CheckBox chkParidera;
        private System.Windows.Forms.TabPage tbpLotes;
        private System.Windows.Forms.ToolStrip tspLotes;
        private System.Windows.Forms.ToolStripButton tsbNuevoLote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbModificarLote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbEliminarLote;
        private System.Windows.Forms.DataGridView dtgLotes;
        private System.Windows.Forms.Label lblTipoLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgLotes_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgLotes_FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgLotes_FechaFin;
        private GEXVOC.Core.Controles.ctlFecha txtFechaAlta;
        private GEXVOC.Core.Controles.ctlFecha txtFechaBaja;
        private GEXVOC.Core.Controles.ctlCombo cmbTipoLote;
    }
}
