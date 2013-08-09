namespace GEXVOC.UI
{
    partial class SelectorAnimales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectorAnimales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dtgAnimalesSeleccionados = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLote = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnbuscarLote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInvertirSeleccion = new System.Windows.Forms.Button();
            this.btnQuitarSeleccion = new System.Windows.Forms.Button();
            this.btnSeleccionarTodo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCubricion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarCubricion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMostrarBajas = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTatuaje = new System.Windows.Forms.TextBox();
            this.lblTatuaje = new System.Windows.Forms.Label();
            this.txtDIB = new System.Windows.Forms.TextBox();
            this.lblDIB = new System.Windows.Forms.Label();
            this.txtCrotal = new System.Windows.Forms.TextBox();
            this.lblCrotal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimalesSeleccionados)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtTatuaje);
            this.pnlBusqueda.Controls.Add(this.lblTatuaje);
            this.pnlBusqueda.Controls.Add(this.txtDIB);
            this.pnlBusqueda.Controls.Add(this.lblDIB);
            this.pnlBusqueda.Controls.Add(this.txtCrotal);
            this.pnlBusqueda.Controls.Add(this.lblCrotal);
            this.pnlBusqueda.Controls.Add(this.lblNombre);
            this.pnlBusqueda.Controls.Add(this.txtNombre);
            this.pnlBusqueda.Controls.Add(this.cmbEspecie);
            this.pnlBusqueda.Controls.Add(this.lblEspecie);
            this.pnlBusqueda.Controls.Add(this.cmbSexo);
            this.pnlBusqueda.Controls.Add(this.lblSexo);
            this.pnlBusqueda.Controls.Add(this.cmbRaza);
            this.pnlBusqueda.Controls.Add(this.lblRaza);
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 28);
            this.pnlBusqueda.Size = new System.Drawing.Size(493, 123);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 219);
            this.panel1.Size = new System.Drawing.Size(431, 348);
            // 
            // cmbSexo
            // 
            this.cmbSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(315, 37);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(94, 21);
            this.cmbSexo.TabIndex = 3;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSexo.Location = new System.Drawing.Point(272, 40);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 91;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbRaza
            // 
            this.cmbRaza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRaza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(238, 91);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(237, 21);
            this.cmbRaza.TabIndex = 6;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRaza.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRaza.Location = new System.Drawing.Point(197, 95);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(35, 13);
            this.lblRaza.TabIndex = 88;
            this.lblRaza.Text = "Raza:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(72, 92);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(112, 21);
            this.cmbEspecie.TabIndex = 5;
            this.cmbEspecie.SelectedIndexChanged += new System.EventHandler(this.cmbEspecie_SelectedIndexChanged);
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEspecie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEspecie.Location = new System.Drawing.Point(20, 95);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 93;
            this.lblEspecie.Text = "Especie:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(535, 489);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(197, 79);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "CONFIRMAR SELECCIÓN    ";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dtgAnimalesSeleccionados
            // 
            this.dtgAnimalesSeleccionados.AllowUserToAddRows = false;
            this.dtgAnimalesSeleccionados.AllowUserToDeleteRows = false;
            this.dtgAnimalesSeleccionados.AllowUserToOrderColumns = true;
            this.dtgAnimalesSeleccionados.AllowUserToResizeRows = false;
            this.dtgAnimalesSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAnimalesSeleccionados.BackgroundColor = System.Drawing.Color.White;
            this.dtgAnimalesSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAnimalesSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAnimalesSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAnimalesSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Nombre});
            this.dtgAnimalesSeleccionados.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAnimalesSeleccionados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgAnimalesSeleccionados.Location = new System.Drawing.Point(6, 19);
            this.dtgAnimalesSeleccionados.Name = "dtgAnimalesSeleccionados";
            this.dtgAnimalesSeleccionados.ReadOnly = true;
            this.dtgAnimalesSeleccionados.RowHeadersWidth = 20;
            this.dtgAnimalesSeleccionados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgAnimalesSeleccionados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgAnimalesSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAnimalesSeleccionados.ShowCellErrors = false;
            this.dtgAnimalesSeleccionados.ShowCellToolTips = false;
            this.dtgAnimalesSeleccionados.ShowEditingIcon = false;
            this.dtgAnimalesSeleccionados.ShowRowErrors = false;
            this.dtgAnimalesSeleccionados.Size = new System.Drawing.Size(297, 289);
            this.dtgAnimalesSeleccionados.TabIndex = 7;
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Identificador";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnbuscarLote);
            this.groupBox1.Location = new System.Drawing.Point(511, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar Lote";
            // 
            // cmbLote
            // 
            this.cmbLote.BackColor = System.Drawing.SystemColors.Control;
            this.cmbLote.btnBusqueda = this.btnbuscarLote;
            this.cmbLote.ClaseActiva = null;
            this.cmbLote.ControlVisible = true;
            this.cmbLote.DisplayMember = "Descripcion";
            this.cmbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.IdClaseActiva = 0;
            this.cmbLote.Location = new System.Drawing.Point(70, 13);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.PermitirEliminar = true;
            this.cmbLote.PermitirLimpiar = true;
            this.cmbLote.ReadOnly = false;
            this.cmbLote.Size = new System.Drawing.Size(155, 21);
            this.cmbLote.TabIndex = 0;
            this.cmbLote.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbLote.TipoDatos = null;
            this.cmbLote.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbLote_ClaseActivaChanged);
            // 
            // btnbuscarLote
            // 
            this.btnbuscarLote.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnbuscarLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnbuscarLote.Location = new System.Drawing.Point(231, 13);
            this.btnbuscarLote.Name = "btnbuscarLote";
            this.btnbuscarLote.Size = new System.Drawing.Size(21, 21);
            this.btnbuscarLote.TabIndex = 1;
            this.btnbuscarLote.UseVisualStyleBackColor = true;
            this.btnbuscarLote.Click += new System.EventHandler(this.btnbuscarLote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Lote:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgAnimalesSeleccionados);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(463, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 314);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animales en la Selección";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInvertirSeleccion);
            this.groupBox3.Controls.Add(this.btnQuitarSeleccion);
            this.groupBox3.Controls.Add(this.btnSeleccionarTodo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 405);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados de la última búsqueda:";
            // 
            // btnInvertirSeleccion
            // 
            this.btnInvertirSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvertirSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnInvertirSeleccion.Image")));
            this.btnInvertirSeleccion.Location = new System.Drawing.Point(401, 11);
            this.btnInvertirSeleccion.Name = "btnInvertirSeleccion";
            this.btnInvertirSeleccion.Size = new System.Drawing.Size(36, 33);
            this.btnInvertirSeleccion.TabIndex = 2;
            this.btnInvertirSeleccion.TabStop = false;
            this.toolTip1.SetToolTip(this.btnInvertirSeleccion, "Invierte la selección actual de los elementos que se encuentran en la lista.");
            this.btnInvertirSeleccion.UseVisualStyleBackColor = true;
            this.btnInvertirSeleccion.Click += new System.EventHandler(this.btnInvertirSeleccion_Click);
            // 
            // btnQuitarSeleccion
            // 
            this.btnQuitarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitarSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarSeleccion.Image")));
            this.btnQuitarSeleccion.Location = new System.Drawing.Point(363, 11);
            this.btnQuitarSeleccion.Name = "btnQuitarSeleccion";
            this.btnQuitarSeleccion.Size = new System.Drawing.Size(36, 33);
            this.btnQuitarSeleccion.TabIndex = 1;
            this.btnQuitarSeleccion.TabStop = false;
            this.toolTip1.SetToolTip(this.btnQuitarSeleccion, "Marca como NO seleccionados todos los elementos que se encuentran en la lista.");
            this.btnQuitarSeleccion.UseVisualStyleBackColor = true;
            this.btnQuitarSeleccion.Click += new System.EventHandler(this.btnQuitarSeleccion_Click);
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarTodo.Image")));
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(325, 11);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(36, 33);
            this.btnSeleccionarTodo.TabIndex = 0;
            this.btnSeleccionarTodo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSeleccionarTodo, "Marca como seleccionados todos los elementos que se encuentran en la lista.");
            this.btnSeleccionarTodo.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCubricion);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnBuscarCubricion);
            this.groupBox4.Location = new System.Drawing.Point(511, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 40);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cargar Cubrición";
            // 
            // cmbCubricion
            // 
            this.cmbCubricion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbCubricion.btnBusqueda = this.btnBuscarCubricion;
            this.cmbCubricion.ClaseActiva = null;
            this.cmbCubricion.ControlVisible = true;
            this.cmbCubricion.DisplayMember = "FechaInicio";
            this.cmbCubricion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbCubricion.FormattingEnabled = true;
            this.cmbCubricion.IdClaseActiva = 0;
            this.cmbCubricion.Location = new System.Drawing.Point(70, 14);
            this.cmbCubricion.Name = "cmbCubricion";
            this.cmbCubricion.PermitirEliminar = true;
            this.cmbCubricion.PermitirLimpiar = true;
            this.cmbCubricion.ReadOnly = false;
            this.cmbCubricion.Size = new System.Drawing.Size(155, 21);
            this.cmbCubricion.TabIndex = 0;
            this.cmbCubricion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbCubricion.TipoDatos = null;
            this.cmbCubricion.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbCubricion_ClaseActivaChanged);
            // 
            // btnBuscarCubricion
            // 
            this.btnBuscarCubricion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarCubricion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarCubricion.Location = new System.Drawing.Point(231, 14);
            this.btnBuscarCubricion.Name = "btnBuscarCubricion";
            this.btnBuscarCubricion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarCubricion.TabIndex = 1;
            this.btnBuscarCubricion.UseVisualStyleBackColor = true;
            this.btnBuscarCubricion.Click += new System.EventHandler(this.btnBuscarCubricion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Cubrición:";
            // 
            // chkMostrarBajas
            // 
            this.chkMostrarBajas.AutoSize = true;
            this.chkMostrarBajas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMostrarBajas.Location = new System.Drawing.Point(19, 19);
            this.chkMostrarBajas.Name = "chkMostrarBajas";
            this.chkMostrarBajas.Size = new System.Drawing.Size(90, 17);
            this.chkMostrarBajas.TabIndex = 98;
            this.chkMostrarBajas.Text = "Mostrar Bajas";
            this.chkMostrarBajas.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkMostrarBajas);
            this.groupBox5.Location = new System.Drawing.Point(511, 108);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 43);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // txtTatuaje
            // 
            this.txtTatuaje.Location = new System.Drawing.Point(73, 38);
            this.txtTatuaje.MaxLength = 7;
            this.txtTatuaje.Name = "txtTatuaje";
            this.txtTatuaje.Size = new System.Drawing.Size(126, 20);
            this.txtTatuaje.TabIndex = 2;
            // 
            // lblTatuaje
            // 
            this.lblTatuaje.AutoSize = true;
            this.lblTatuaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTatuaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTatuaje.Location = new System.Drawing.Point(19, 41);
            this.lblTatuaje.Name = "lblTatuaje";
            this.lblTatuaje.Size = new System.Drawing.Size(43, 13);
            this.lblTatuaje.TabIndex = 164;
            this.lblTatuaje.Text = "Tatuaje";
            // 
            // txtDIB
            // 
            this.txtDIB.Location = new System.Drawing.Point(73, 14);
            this.txtDIB.MaxLength = 14;
            this.txtDIB.Name = "txtDIB";
            this.txtDIB.Size = new System.Drawing.Size(164, 20);
            this.txtDIB.TabIndex = 0;
            // 
            // lblDIB
            // 
            this.lblDIB.AutoSize = true;
            this.lblDIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDIB.Location = new System.Drawing.Point(20, 17);
            this.lblDIB.Name = "lblDIB";
            this.lblDIB.Size = new System.Drawing.Size(25, 13);
            this.lblDIB.TabIndex = 163;
            this.lblDIB.Text = "DIB";
            // 
            // txtCrotal
            // 
            this.txtCrotal.Location = new System.Drawing.Point(315, 13);
            this.txtCrotal.MaxLength = 4;
            this.txtCrotal.Name = "txtCrotal";
            this.txtCrotal.Size = new System.Drawing.Size(94, 20);
            this.txtCrotal.TabIndex = 1;
            // 
            // lblCrotal
            // 
            this.lblCrotal.AutoSize = true;
            this.lblCrotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCrotal.Location = new System.Drawing.Point(272, 17);
            this.lblCrotal.Name = "lblCrotal";
            this.lblCrotal.Size = new System.Drawing.Size(37, 13);
            this.lblCrotal.TabIndex = 162;
            this.lblCrotal.Text = "Crotal:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(19, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 161;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 65);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(403, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // SelectorAnimales
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(777, 604);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.dtgResultadoTamano = new System.Drawing.Size(431, 348);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "SelectorAnimales";
            this.pnlBusquedaPosicion = new System.Drawing.Point(12, 28);
            this.pnlBusquedaTamano = new System.Drawing.Size(493, 123);
            this.Text = "Selector de Animales";
            this.Load += new System.EventHandler(this.SelectorAnimales_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnConfirmar, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimalesSeleccionados)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Button btnConfirmar;
        protected System.Windows.Forms.DataGridView dtgAnimalesSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLote;
        private System.Windows.Forms.Button btnbuscarLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuitarSeleccion;
        private System.Windows.Forms.Button btnSeleccionarTodo;
        private System.Windows.Forms.Button btnInvertirSeleccion;
        private System.Windows.Forms.GroupBox groupBox4;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbCubricion;
        private System.Windows.Forms.Button btnBuscarCubricion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMostrarBajas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTatuaje;
        private System.Windows.Forms.Label lblTatuaje;
        private System.Windows.Forms.TextBox txtDIB;
        private System.Windows.Forms.Label lblDIB;
        private System.Windows.Forms.TextBox txtCrotal;
        private System.Windows.Forms.Label lblCrotal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}
