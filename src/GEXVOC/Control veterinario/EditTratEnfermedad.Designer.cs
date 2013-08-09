namespace GEXVOC.UI
{
    partial class EditTratEnfermedad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpTratamiento = new System.Windows.Forms.GroupBox();
            this.txtFecTratamiento = new GEXVOC.Core.Controles.ctlFecha();
            this.txtSupresionCarne = new System.Windows.Forms.TextBox();
            this.txtSupresionLeche = new System.Windows.Forms.TextBox();
            this.lblSupresionCarne = new System.Windows.Forms.Label();
            this.lblSupresionLeche = new System.Windows.Forms.Label();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.cmbPersonal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarDiagnostico = new System.Windows.Forms.Button();
            this.cmbDiagnostico = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblHastaCarne = new System.Windows.Forms.Label();
            this.lblHastaLeche = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.lblFecTratamiento = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpReceta = new System.Windows.Forms.TabPage();
            this.dtgReceta = new System.Windows.Forms.DataGridView();
            this.FechaReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspReceta = new System.Windows.Forms.ToolStrip();
            this.tsbNuevaReceta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarReceta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarReceta = new System.Windows.Forms.ToolStripButton();
            this.tbpGastos = new System.Windows.Forms.TabPage();
            this.tspGastos = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevoGasto = new System.Windows.Forms.ToolStripButton();
            this.tsbModificarGasto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarGasto = new System.Windows.Forms.ToolStripButton();
            this.dtgGastos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grpTratamiento.SuspendLayout();
            this.tbcContenido.SuspendLayout();
            this.tbpReceta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReceta)).BeginInit();
            this.tspReceta.SuspendLayout();
            this.tbpGastos.SuspendLayout();
            this.tspGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTratamiento
            // 
            this.grpTratamiento.Controls.Add(this.txtFecTratamiento);
            this.grpTratamiento.Controls.Add(this.txtSupresionCarne);
            this.grpTratamiento.Controls.Add(this.txtSupresionLeche);
            this.grpTratamiento.Controls.Add(this.lblSupresionCarne);
            this.grpTratamiento.Controls.Add(this.lblSupresionLeche);
            this.grpTratamiento.Controls.Add(this.btnBuscarPersonal);
            this.grpTratamiento.Controls.Add(this.cmbPersonal);
            this.grpTratamiento.Controls.Add(this.btnBuscarDiagnostico);
            this.grpTratamiento.Controls.Add(this.cmbDiagnostico);
            this.grpTratamiento.Controls.Add(this.lblHastaCarne);
            this.grpTratamiento.Controls.Add(this.lblHastaLeche);
            this.grpTratamiento.Controls.Add(this.txtDuracion);
            this.grpTratamiento.Controls.Add(this.lblDuracion);
            this.grpTratamiento.Controls.Add(this.txtDetalle);
            this.grpTratamiento.Controls.Add(this.lblDetalle);
            this.grpTratamiento.Controls.Add(this.lblPersonal);
            this.grpTratamiento.Controls.Add(this.lblFecTratamiento);
            this.grpTratamiento.Controls.Add(this.lblDiagnostico);
            this.grpTratamiento.Location = new System.Drawing.Point(8, 28);
            this.grpTratamiento.Name = "grpTratamiento";
            this.grpTratamiento.Size = new System.Drawing.Size(623, 151);
            this.grpTratamiento.TabIndex = 126;
            this.grpTratamiento.TabStop = false;
            this.grpTratamiento.Text = "Datos del tratamiento";
            // 
            // txtFecTratamiento
            // 
            this.txtFecTratamiento.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecTratamiento.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecTratamiento.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecTratamiento.Location = new System.Drawing.Point(112, 87);
            this.txtFecTratamiento.Name = "txtFecTratamiento";
            this.txtFecTratamiento.ReadOnly = false;
            this.txtFecTratamiento.Size = new System.Drawing.Size(88, 20);
            this.txtFecTratamiento.TabIndex = 6;
            this.txtFecTratamiento.Value = null;
            this.txtFecTratamiento.ValueChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlFechaEventArgs>(this.txtFecTratamiento_ValueChanged);
            // 
            // txtSupresionCarne
            // 
            this.txtSupresionCarne.Location = new System.Drawing.Point(420, 57);
            this.txtSupresionCarne.Name = "txtSupresionCarne";
            this.txtSupresionCarne.Size = new System.Drawing.Size(53, 20);
            this.txtSupresionCarne.TabIndex = 5;
            this.txtSupresionCarne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSupresionCarne.TextChanged += new System.EventHandler(this.txtSupresionCarne_TextChanged);
            // 
            // txtSupresionLeche
            // 
            this.txtSupresionLeche.Location = new System.Drawing.Point(112, 57);
            this.txtSupresionLeche.Name = "txtSupresionLeche";
            this.txtSupresionLeche.Size = new System.Drawing.Size(63, 20);
            this.txtSupresionLeche.TabIndex = 4;
            this.txtSupresionLeche.TextChanged += new System.EventHandler(this.txtSupresionLeche_TextChanged);
            // 
            // lblSupresionCarne
            // 
            this.lblSupresionCarne.AutoSize = true;
            this.lblSupresionCarne.Location = new System.Drawing.Point(323, 60);
            this.lblSupresionCarne.Name = "lblSupresionCarne";
            this.lblSupresionCarne.Size = new System.Drawing.Size(93, 13);
            this.lblSupresionCarne.TabIndex = 5;
            this.lblSupresionCarne.Text = "Supresión (carne):";
            // 
            // lblSupresionLeche
            // 
            this.lblSupresionLeche.AutoSize = true;
            this.lblSupresionLeche.Location = new System.Drawing.Point(17, 60);
            this.lblSupresionLeche.Name = "lblSupresionLeche";
            this.lblSupresionLeche.Size = new System.Drawing.Size(92, 13);
            this.lblSupresionLeche.TabIndex = 158;
            this.lblSupresionLeche.Text = "Supresión (leche):";
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPersonal.Location = new System.Drawing.Point(580, 26);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPersonal.TabIndex = 3;
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbPersonal.btnBusqueda = this.btnBuscarPersonal;
            this.cmbPersonal.ClaseActiva = null;
            this.cmbPersonal.ControlVisible = true;
            this.cmbPersonal.DisplayMember = "NombreCompleto";
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.IdClaseActiva = 0;
            this.cmbPersonal.Location = new System.Drawing.Point(389, 26);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.PermitirEliminar = true;
            this.cmbPersonal.PermitirLimpiar = true;
            this.cmbPersonal.ReadOnly = false;
            this.cmbPersonal.Size = new System.Drawing.Size(185, 21);
            this.cmbPersonal.TabIndex = 2;
            this.cmbPersonal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPersonal.TipoDatos = null;
            this.cmbPersonal.CrearNuevo += new System.EventHandler(this.cmbPersonal_CrearNuevo);
            // 
            // btnBuscarDiagnostico
            // 
            this.btnBuscarDiagnostico.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarDiagnostico.Location = new System.Drawing.Point(286, 25);
            this.btnBuscarDiagnostico.Name = "btnBuscarDiagnostico";
            this.btnBuscarDiagnostico.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarDiagnostico.TabIndex = 1;
            this.btnBuscarDiagnostico.UseVisualStyleBackColor = true;
            this.btnBuscarDiagnostico.Click += new System.EventHandler(this.btnBuscarDiagnostico_Click);
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDiagnostico.btnBusqueda = this.btnBuscarDiagnostico;
            this.cmbDiagnostico.ClaseActiva = null;
            this.cmbDiagnostico.ControlVisible = true;
            this.cmbDiagnostico.DisplayMember = "DescDiagnostico";
            this.cmbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbDiagnostico.FormattingEnabled = true;
            this.cmbDiagnostico.IdClaseActiva = 0;
            this.cmbDiagnostico.Location = new System.Drawing.Point(112, 25);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.PermitirEliminar = true;
            this.cmbDiagnostico.PermitirLimpiar = true;
            this.cmbDiagnostico.ReadOnly = false;
            this.cmbDiagnostico.Size = new System.Drawing.Size(168, 21);
            this.cmbDiagnostico.TabIndex = 0;
            this.cmbDiagnostico.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbDiagnostico.TipoDatos = null;
            // 
            // lblHastaCarne
            // 
            this.lblHastaCarne.AutoSize = true;
            this.lblHastaCarne.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHastaCarne.Location = new System.Drawing.Point(479, 60);
            this.lblHastaCarne.Name = "lblHastaCarne";
            this.lblHastaCarne.Size = new System.Drawing.Size(36, 13);
            this.lblHastaCarne.TabIndex = 151;
            this.lblHastaCarne.Text = "hasta:";
            // 
            // lblHastaLeche
            // 
            this.lblHastaLeche.AutoSize = true;
            this.lblHastaLeche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHastaLeche.Location = new System.Drawing.Point(194, 60);
            this.lblHastaLeche.Name = "lblHastaLeche";
            this.lblHastaLeche.Size = new System.Drawing.Size(36, 13);
            this.lblHastaLeche.TabIndex = 6;
            this.lblHastaLeche.Text = "hasta:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(286, 86);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(63, 20);
            this.txtDuracion.TabIndex = 7;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDuracion.Location = new System.Drawing.Point(227, 90);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(53, 13);
            this.lblDuracion.TabIndex = 144;
            this.lblDuracion.Text = "Duración:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(112, 113);
            this.txtDetalle.MaxLength = 150;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(489, 20);
            this.txtDetalle.TabIndex = 8;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDetalle.Location = new System.Drawing.Point(17, 116);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblDetalle.TabIndex = 140;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPersonal.Location = new System.Drawing.Point(323, 29);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(51, 13);
            this.lblPersonal.TabIndex = 139;
            this.lblPersonal.Text = "Personal:";
            // 
            // lblFecTratamiento
            // 
            this.lblFecTratamiento.AutoSize = true;
            this.lblFecTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecTratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecTratamiento.Location = new System.Drawing.Point(17, 90);
            this.lblFecTratamiento.Name = "lblFecTratamiento";
            this.lblFecTratamiento.Size = new System.Drawing.Size(78, 13);
            this.lblFecTratamiento.TabIndex = 124;
            this.lblFecTratamiento.Text = "F. Tratamiento:";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiagnostico.Location = new System.Drawing.Point(17, 29);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.lblDiagnostico.TabIndex = 123;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpReceta);
            this.tbcContenido.Controls.Add(this.tbpGastos);
            this.tbcContenido.Location = new System.Drawing.Point(8, 185);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(623, 302);
            this.tbcContenido.TabIndex = 128;
            // 
            // tbpReceta
            // 
            this.tbpReceta.Controls.Add(this.dtgReceta);
            this.tbpReceta.Controls.Add(this.tspReceta);
            this.tbpReceta.Location = new System.Drawing.Point(4, 22);
            this.tbpReceta.Name = "tbpReceta";
            this.tbpReceta.Size = new System.Drawing.Size(615, 276);
            this.tbpReceta.TabIndex = 1;
            this.tbpReceta.Text = "Receta";
            this.tbpReceta.UseVisualStyleBackColor = true;
            // 
            // dtgReceta
            // 
            this.dtgReceta.AllowUserToAddRows = false;
            this.dtgReceta.AllowUserToDeleteRows = false;
            this.dtgReceta.AllowUserToOrderColumns = true;
            this.dtgReceta.AllowUserToResizeRows = false;
            this.dtgReceta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgReceta.BackgroundColor = System.Drawing.Color.White;
            this.dtgReceta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaReceta,
            this.DescMedicamento,
            this.ImporteReceta,
            this.Duracion,
            this.Dosis});
            this.dtgReceta.Location = new System.Drawing.Point(7, 3);
            this.dtgReceta.Name = "dtgReceta";
            this.dtgReceta.ReadOnly = true;
            this.dtgReceta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgReceta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgReceta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReceta.ShowCellErrors = false;
            this.dtgReceta.ShowCellToolTips = false;
            this.dtgReceta.ShowEditingIcon = false;
            this.dtgReceta.ShowRowErrors = false;
            this.dtgReceta.Size = new System.Drawing.Size(590, 229);
            this.dtgReceta.TabIndex = 16;
            this.dtgReceta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReceta_CellDoubleClick);
            // 
            // FechaReceta
            // 
            this.FechaReceta.DataPropertyName = "Fecha";
            this.FechaReceta.HeaderText = "Fecha";
            this.FechaReceta.Name = "FechaReceta";
            this.FechaReceta.ReadOnly = true;
            this.FechaReceta.Width = 62;
            // 
            // DescMedicamento
            // 
            this.DescMedicamento.DataPropertyName = "DescMedicamento";
            this.DescMedicamento.HeaderText = "Medicamento";
            this.DescMedicamento.Name = "DescMedicamento";
            this.DescMedicamento.ReadOnly = true;
            this.DescMedicamento.Width = 96;
            // 
            // ImporteReceta
            // 
            this.ImporteReceta.DataPropertyName = "Importe";
            this.ImporteReceta.HeaderText = "Importe";
            this.ImporteReceta.Name = "ImporteReceta";
            this.ImporteReceta.ReadOnly = true;
            this.ImporteReceta.Width = 67;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "Duracion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Duracion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Width = 75;
            // 
            // Dosis
            // 
            this.Dosis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dosis.DataPropertyName = "Dosis";
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            // 
            // tspReceta
            // 
            this.tspReceta.Dock = System.Windows.Forms.DockStyle.None;
            this.tspReceta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevaReceta,
            this.toolStripSeparator19,
            this.tsbModificarReceta,
            this.toolStripSeparator20,
            this.tsbEliminarReceta});
            this.tspReceta.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspReceta.Location = new System.Drawing.Point(329, 235);
            this.tspReceta.Name = "tspReceta";
            this.tspReceta.Size = new System.Drawing.Size(268, 23);
            this.tspReceta.TabIndex = 31;
            this.tspReceta.Text = "toolStrip1";
            // 
            // tsbNuevaReceta
            // 
            this.tsbNuevaReceta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevaReceta.AutoSize = false;
            this.tsbNuevaReceta.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevaReceta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevaReceta.Name = "tsbNuevaReceta";
            this.tsbNuevaReceta.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevaReceta.Text = " Nuevo ";
            this.tsbNuevaReceta.Click += new System.EventHandler(this.tsbNuevaReceta_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarReceta
            // 
            this.tsbModificarReceta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarReceta.AutoSize = false;
            this.tsbModificarReceta.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarReceta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarReceta.Name = "tsbModificarReceta";
            this.tsbModificarReceta.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarReceta.Text = " Modificar";
            this.tsbModificarReceta.Click += new System.EventHandler(this.tsbModificarReceta_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarReceta
            // 
            this.tsbEliminarReceta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarReceta.AutoSize = false;
            this.tsbEliminarReceta.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarReceta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarReceta.Name = "tsbEliminarReceta";
            this.tsbEliminarReceta.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarReceta.Text = " Eliminar ";
            this.tsbEliminarReceta.Click += new System.EventHandler(this.tsbEliminarReceta_Click);
            // 
            // tbpGastos
            // 
            this.tbpGastos.Controls.Add(this.tspGastos);
            this.tbpGastos.Controls.Add(this.dtgGastos);
            this.tbpGastos.Location = new System.Drawing.Point(4, 22);
            this.tbpGastos.Name = "tbpGastos";
            this.tbpGastos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGastos.Size = new System.Drawing.Size(615, 276);
            this.tbpGastos.TabIndex = 0;
            this.tbpGastos.Text = "Gastos";
            this.tbpGastos.UseVisualStyleBackColor = true;
            // 
            // tspGastos
            // 
            this.tspGastos.Dock = System.Windows.Forms.DockStyle.None;
            this.tspGastos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsbNuevoGasto,
            this.tsbModificarGasto,
            this.toolStripSeparator1,
            this.tsbEliminarGasto});
            this.tspGastos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspGastos.Location = new System.Drawing.Point(377, 244);
            this.tspGastos.Name = "tspGastos";
            this.tspGastos.Size = new System.Drawing.Size(219, 23);
            this.tspGastos.TabIndex = 29;
            this.tspGastos.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbNuevoGasto
            // 
            this.tsbNuevoGasto.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoGasto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoGasto.Name = "tsbNuevoGasto";
            this.tsbNuevoGasto.Size = new System.Drawing.Size(58, 20);
            this.tsbNuevoGasto.Text = "Nuevo";
            this.tsbNuevoGasto.Click += new System.EventHandler(this.tsbNuevoGasto_Click);
            // 
            // tsbModificarGasto
            // 
            this.tsbModificarGasto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarGasto.AutoSize = false;
            this.tsbModificarGasto.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarGasto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarGasto.Name = "tsbModificarGasto";
            this.tsbModificarGasto.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarGasto.Text = " Modificar";
            this.tsbModificarGasto.Click += new System.EventHandler(this.tsbModificarGasto_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarGasto
            // 
            this.tsbEliminarGasto.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarGasto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarGasto.Name = "tsbEliminarGasto";
            this.tsbEliminarGasto.Size = new System.Drawing.Size(63, 20);
            this.tsbEliminarGasto.Text = "Eliminar";
            this.tsbEliminarGasto.Click += new System.EventHandler(this.tsbEliminarGasto_Click);
            // 
            // dtgGastos
            // 
            this.dtgGastos.AllowUserToAddRows = false;
            this.dtgGastos.AllowUserToDeleteRows = false;
            this.dtgGastos.AllowUserToOrderColumns = true;
            this.dtgGastos.AllowUserToResizeRows = false;
            this.dtgGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgGastos.BackgroundColor = System.Drawing.Color.White;
            this.dtgGastos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Importe,
            this.Detalle});
            this.dtgGastos.Location = new System.Drawing.Point(6, 5);
            this.dtgGastos.Name = "dtgGastos";
            this.dtgGastos.ReadOnly = true;
            this.dtgGastos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgGastos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGastos.ShowCellErrors = false;
            this.dtgGastos.ShowCellToolTips = false;
            this.dtgGastos.ShowEditingIcon = false;
            this.dtgGastos.ShowRowErrors = false;
            this.dtgGastos.Size = new System.Drawing.Size(590, 229);
            this.dtgGastos.TabIndex = 15;
            this.dtgGastos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGastos_CellDoubleClick);
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Fecha.Width = 62;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Importe.Width = 67;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detalle.DataPropertyName = "Detalle";
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // EditTratEnfermedad
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(643, 514);
            this.Controls.Add(this.tbcContenido);
            this.Controls.Add(this.grpTratamiento);
            this.Name = "EditTratEnfermedad";
            this.Text = "Tratamiento";
            this.Controls.SetChildIndex(this.grpTratamiento, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grpTratamiento.ResumeLayout(false);
            this.grpTratamiento.PerformLayout();
            this.tbcContenido.ResumeLayout(false);
            this.tbpReceta.ResumeLayout(false);
            this.tbpReceta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReceta)).EndInit();
            this.tspReceta.ResumeLayout(false);
            this.tspReceta.PerformLayout();
            this.tbpGastos.ResumeLayout(false);
            this.tbpGastos.PerformLayout();
            this.tspGastos.ResumeLayout(false);
            this.tspGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTratamiento;
        private System.Windows.Forms.Label lblHastaCarne;
        private System.Windows.Forms.Label lblHastaLeche;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Label lblFecTratamiento;
        private System.Windows.Forms.Label lblDiagnostico;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbDiagnostico;
        private System.Windows.Forms.Button btnBuscarDiagnostico;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbPersonal;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpGastos;
        private System.Windows.Forms.ToolStrip tspGastos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbNuevoGasto;
        private System.Windows.Forms.ToolStripButton tsbModificarGasto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEliminarGasto;
        private System.Windows.Forms.DataGridView dtgGastos;
        private System.Windows.Forms.Label lblSupresionCarne;
        private System.Windows.Forms.Label lblSupresionLeche;
        private System.Windows.Forms.TextBox txtSupresionCarne;
        private System.Windows.Forms.TextBox txtSupresionLeche;
        private System.Windows.Forms.TabPage tbpReceta;
        private System.Windows.Forms.DataGridView dtgReceta;
        private System.Windows.Forms.ToolStrip tspReceta;
        private System.Windows.Forms.ToolStripButton tsbNuevaReceta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripButton tsbModificarReceta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripButton tsbEliminarReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private GEXVOC.Core.Controles.ctlFecha txtFecTratamiento;

    }
}
