namespace GEXVOC.UI
{
    partial class EditPartosMultiples
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPartosMultiples));
            this.grbAsignaciones = new System.Windows.Forms.GroupBox();
            this.dtgPartosMultiples = new System.Windows.Forms.DataGridView();
            this.Madre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoInsCub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipoPartoGrid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbFacilidadGrid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FechaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Muertos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervaloPartoAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxDescartar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDescartar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMuertos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVivos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaAsignacion = new System.Windows.Forms.Label();
            this.cmbTipoParto = new System.Windows.Forms.ComboBox();
            this.lblRacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaParto = new System.Windows.Forms.MaskedTextBox();
            this.btnExtenderFacilidadGrid = new System.Windows.Forms.Button();
            this.btnExtenderTipoPartoGrid = new System.Windows.Forms.Button();
            this.btnExtenderFechaGrid = new System.Windows.Forms.Button();
            this.lblFacilidad = new System.Windows.Forms.Label();
            this.cmbFacilidad = new System.Windows.Forms.ComboBox();
            this.cmbLote = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnbuscarLote = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstAnimalesDescartados = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Motivo = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpEstadisticas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grbAsignaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartosMultiples)).BeginInit();
            this.ctxDescartar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAsignaciones
            // 
            this.grbAsignaciones.Controls.Add(this.dtgPartosMultiples);
            this.grbAsignaciones.Location = new System.Drawing.Point(12, 112);
            this.grbAsignaciones.Name = "grbAsignaciones";
            this.grbAsignaciones.Size = new System.Drawing.Size(846, 375);
            this.grbAsignaciones.TabIndex = 3;
            this.grbAsignaciones.TabStop = false;
            this.grbAsignaciones.Text = "Partos que serán registrados";
            // 
            // dtgPartosMultiples
            // 
            this.dtgPartosMultiples.AllowUserToAddRows = false;
            this.dtgPartosMultiples.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPartosMultiples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPartosMultiples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Madre,
            this.TipoInsCub,
            this.cmbTipoPartoGrid,
            this.cmbFacilidadGrid,
            this.FechaGrid,
            this.Vivos,
            this.Muertos,
            this.IntervaloPartoAnterior});
            this.dtgPartosMultiples.ContextMenuStrip = this.ctxDescartar;
            this.dtgPartosMultiples.Location = new System.Drawing.Point(6, 19);
            this.dtgPartosMultiples.Name = "dtgPartosMultiples";
            this.dtgPartosMultiples.RowHeadersWidth = 20;
            this.dtgPartosMultiples.Size = new System.Drawing.Size(834, 350);
            this.dtgPartosMultiples.TabIndex = 8;
            this.dtgPartosMultiples.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAsignaciones_CellValueChanged);
            this.dtgPartosMultiples.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgAsignaciones_DataError);
            // 
            // Madre
            // 
            this.Madre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Madre.DataPropertyName = "DescMadre";
            this.Madre.HeaderText = "Madre";
            this.Madre.Name = "Madre";
            // 
            // TipoInsCub
            // 
            this.TipoInsCub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoInsCub.DataPropertyName = "TipoInsCub";
            this.TipoInsCub.HeaderText = "Tipo Inseminación / Cubrición";
            this.TipoInsCub.Name = "TipoInsCub";
            this.TipoInsCub.ReadOnly = true;
            // 
            // cmbTipoPartoGrid
            // 
            this.cmbTipoPartoGrid.DataPropertyName = "IdTipoParto";
            this.cmbTipoPartoGrid.HeaderText = "Tipo Parto";
            this.cmbTipoPartoGrid.Name = "cmbTipoPartoGrid";
            this.cmbTipoPartoGrid.Width = 150;
            // 
            // cmbFacilidadGrid
            // 
            this.cmbFacilidadGrid.DataPropertyName = "IdFacilidad";
            this.cmbFacilidadGrid.HeaderText = "Facilidad";
            this.cmbFacilidadGrid.Name = "cmbFacilidadGrid";
            this.cmbFacilidadGrid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbFacilidadGrid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbFacilidadGrid.Width = 150;
            // 
            // FechaGrid
            // 
            this.FechaGrid.DataPropertyName = "FechaParto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaGrid.HeaderText = "Fecha";
            this.FechaGrid.Name = "FechaGrid";
            this.FechaGrid.Width = 80;
            // 
            // Vivos
            // 
            this.Vivos.DataPropertyName = "Vivos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Vivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Vivos.HeaderText = "Vivos";
            this.Vivos.Name = "Vivos";
            this.Vivos.Width = 50;
            // 
            // Muertos
            // 
            this.Muertos.DataPropertyName = "Muertos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Muertos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Muertos.HeaderText = "Muertos";
            this.Muertos.Name = "Muertos";
            this.Muertos.Width = 50;
            // 
            // IntervaloPartoAnterior
            // 
            this.IntervaloPartoAnterior.DataPropertyName = "IntervaloPartoAnterior";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.IntervaloPartoAnterior.DefaultCellStyle = dataGridViewCellStyle4;
            this.IntervaloPartoAnterior.HeaderText = "I. U. Parto";
            this.IntervaloPartoAnterior.Name = "IntervaloPartoAnterior";
            this.IntervaloPartoAnterior.Width = 50;
            // 
            // ctxDescartar
            // 
            this.ctxDescartar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDescartar});
            this.ctxDescartar.Name = "contextMenuStrip1";
            this.ctxDescartar.Size = new System.Drawing.Size(254, 26);
            this.ctxDescartar.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmDescartar
            // 
            this.tsmDescartar.Name = "tsmDescartar";
            this.tsmDescartar.Size = new System.Drawing.Size(253, 22);
            this.tsmDescartar.Text = "Descartar (solo filas seleccionadas)";
            this.tsmDescartar.ToolTipText = resources.GetString("tsmDescartar.ToolTipText");
            this.tsmDescartar.Click += new System.EventHandler(this.tsmDescartar_Click);
            // 
            // txtMuertos
            // 
            this.txtMuertos.Location = new System.Drawing.Point(84, 46);
            this.txtMuertos.MaxLength = 3;
            this.txtMuertos.Name = "txtMuertos";
            this.txtMuertos.ReadOnly = true;
            this.txtMuertos.Size = new System.Drawing.Size(55, 20);
            this.txtMuertos.TabIndex = 70;
            this.txtMuertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Nº Muertos";
            // 
            // txtVivos
            // 
            this.txtVivos.Location = new System.Drawing.Point(84, 19);
            this.txtVivos.MaxLength = 3;
            this.txtVivos.Name = "txtVivos";
            this.txtVivos.ReadOnly = true;
            this.txtVivos.Size = new System.Drawing.Size(55, 20);
            this.txtVivos.TabIndex = 68;
            this.txtVivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Nº Vivos";
            // 
            // lblFechaAsignacion
            // 
            this.lblFechaAsignacion.AutoSize = true;
            this.lblFechaAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAsignacion.Location = new System.Drawing.Point(308, 23);
            this.lblFechaAsignacion.Name = "lblFechaAsignacion";
            this.lblFechaAsignacion.Size = new System.Drawing.Size(80, 13);
            this.lblFechaAsignacion.TabIndex = 67;
            this.lblFechaAsignacion.Text = "Fecha Parto:";
            // 
            // cmbTipoParto
            // 
            this.cmbTipoParto.FormattingEnabled = true;
            this.cmbTipoParto.Location = new System.Drawing.Point(85, 46);
            this.cmbTipoParto.Name = "cmbTipoParto";
            this.cmbTipoParto.Size = new System.Drawing.Size(178, 21);
            this.cmbTipoParto.TabIndex = 3;
            // 
            // lblRacion
            // 
            this.lblRacion.AutoSize = true;
            this.lblRacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacion.Location = new System.Drawing.Point(9, 49);
            this.lblRacion.Name = "lblRacion";
            this.lblRacion.Size = new System.Drawing.Size(70, 13);
            this.lblRacion.TabIndex = 59;
            this.lblRacion.Text = "Tipo Parto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaParto);
            this.groupBox1.Controls.Add(this.btnExtenderFacilidadGrid);
            this.groupBox1.Controls.Add(this.btnExtenderTipoPartoGrid);
            this.groupBox1.Controls.Add(this.btnExtenderFechaGrid);
            this.groupBox1.Controls.Add(this.lblFacilidad);
            this.groupBox1.Controls.Add(this.cmbFacilidad);
            this.groupBox1.Controls.Add(this.cmbLote);
            this.groupBox1.Controls.Add(this.btnbuscarLote);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblRacion);
            this.groupBox1.Controls.Add(this.cmbTipoParto);
            this.groupBox1.Controls.Add(this.lblFechaAsignacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Requerida";
            // 
            // txtFechaParto
            // 
            this.txtFechaParto.HidePromptOnLeave = true;
            this.txtFechaParto.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFechaParto.Location = new System.Drawing.Point(389, 19);
            this.txtFechaParto.Mask = "00/00/0099";
            this.txtFechaParto.Name = "txtFechaParto";
            this.txtFechaParto.Size = new System.Drawing.Size(67, 20);
            this.txtFechaParto.TabIndex = 2;
            this.txtFechaParto.ValidatingType = typeof(System.DateTime);
            // 
            // btnExtenderFacilidadGrid
            // 
            this.btnExtenderFacilidadGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnExtenderFacilidadGrid.Image")));
            this.btnExtenderFacilidadGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExtenderFacilidadGrid.Location = new System.Drawing.Point(658, 46);
            this.btnExtenderFacilidadGrid.Name = "btnExtenderFacilidadGrid";
            this.btnExtenderFacilidadGrid.Size = new System.Drawing.Size(21, 21);
            this.btnExtenderFacilidadGrid.TabIndex = 101;
            this.toolTip1.SetToolTip(this.btnExtenderFacilidadGrid, "Extiende el valor de \"FACILIDAD\"  a todos los elementos del grid.");
            this.btnExtenderFacilidadGrid.UseVisualStyleBackColor = true;
            this.btnExtenderFacilidadGrid.Click += new System.EventHandler(this.btnExtenderFacilidadGrid_Click);
            // 
            // btnExtenderTipoPartoGrid
            // 
            this.btnExtenderTipoPartoGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnExtenderTipoPartoGrid.Image")));
            this.btnExtenderTipoPartoGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExtenderTipoPartoGrid.Location = new System.Drawing.Point(269, 46);
            this.btnExtenderTipoPartoGrid.Name = "btnExtenderTipoPartoGrid";
            this.btnExtenderTipoPartoGrid.Size = new System.Drawing.Size(21, 21);
            this.btnExtenderTipoPartoGrid.TabIndex = 100;
            this.toolTip1.SetToolTip(this.btnExtenderTipoPartoGrid, "Extiende el valor \"TIPO PARTO\" a todos los elementos del grid.");
            this.btnExtenderTipoPartoGrid.UseVisualStyleBackColor = true;
            this.btnExtenderTipoPartoGrid.Click += new System.EventHandler(this.btnExtenderTipoPartoGrid_Click);
            // 
            // btnExtenderFechaGrid
            // 
            this.btnExtenderFechaGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnExtenderFechaGrid.Image")));
            this.btnExtenderFechaGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExtenderFechaGrid.Location = new System.Drawing.Point(462, 18);
            this.btnExtenderFechaGrid.Name = "btnExtenderFechaGrid";
            this.btnExtenderFechaGrid.Size = new System.Drawing.Size(21, 21);
            this.btnExtenderFechaGrid.TabIndex = 99;
            this.toolTip1.SetToolTip(this.btnExtenderFechaGrid, "Extiende el valor de la fecha del parto indicada a todos los elementos del grid.");
            this.btnExtenderFechaGrid.UseVisualStyleBackColor = true;
            this.btnExtenderFechaGrid.Click += new System.EventHandler(this.btnExtenderFechaGrid_Click);
            // 
            // lblFacilidad
            // 
            this.lblFacilidad.AutoSize = true;
            this.lblFacilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilidad.Location = new System.Drawing.Point(308, 49);
            this.lblFacilidad.Name = "lblFacilidad";
            this.lblFacilidad.Size = new System.Drawing.Size(62, 13);
            this.lblFacilidad.TabIndex = 98;
            this.lblFacilidad.Text = "Facilidad:";
            // 
            // cmbFacilidad
            // 
            this.cmbFacilidad.FormattingEnabled = true;
            this.cmbFacilidad.Location = new System.Drawing.Point(389, 46);
            this.cmbFacilidad.Name = "cmbFacilidad";
            this.cmbFacilidad.Size = new System.Drawing.Size(264, 21);
            this.cmbFacilidad.TabIndex = 4;
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
            this.cmbLote.Location = new System.Drawing.Point(85, 19);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.PermitirEliminar = true;
            this.cmbLote.PermitirLimpiar = true;
            this.cmbLote.ReadOnly = false;
            this.cmbLote.Size = new System.Drawing.Size(178, 21);
            this.cmbLote.TabIndex = 0;
            this.cmbLote.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbLote.TipoDatos = null;
            // 
            // btnbuscarLote
            // 
            this.btnbuscarLote.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnbuscarLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnbuscarLote.Location = new System.Drawing.Point(269, 19);
            this.btnbuscarLote.Name = "btnbuscarLote";
            this.btnbuscarLote.Size = new System.Drawing.Size(21, 21);
            this.btnbuscarLote.TabIndex = 1;
            this.btnbuscarLote.UseVisualStyleBackColor = true;
            this.btnbuscarLote.Click += new System.EventHandler(this.btnbuscarLote_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Lote:";
            // 
            // lstAnimalesDescartados
            // 
            this.lstAnimalesDescartados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Motivo});
            this.lstAnimalesDescartados.FullRowSelect = true;
            this.lstAnimalesDescartados.Location = new System.Drawing.Point(6, 19);
            this.lstAnimalesDescartados.MultiSelect = false;
            this.lstAnimalesDescartados.Name = "lstAnimalesDescartados";
            this.lstAnimalesDescartados.Size = new System.Drawing.Size(834, 109);
            this.lstAnimalesDescartados.TabIndex = 5;
            this.lstAnimalesDescartados.UseCompatibleStateImageBehavior = false;
            this.lstAnimalesDescartados.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 309;
            // 
            // Motivo
            // 
            this.Motivo.Text = "Motivo";
            this.Motivo.Width = 502;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAnimalesDescartados);
            this.groupBox2.Location = new System.Drawing.Point(12, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 134);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animales Descartados";
            // 
            // grpEstadisticas
            // 
            this.grpEstadisticas.Controls.Add(this.txtMuertos);
            this.grpEstadisticas.Controls.Add(this.label2);
            this.grpEstadisticas.Controls.Add(this.txtVivos);
            this.grpEstadisticas.Controls.Add(this.label1);
            this.grpEstadisticas.Location = new System.Drawing.Point(701, 28);
            this.grpEstadisticas.Name = "grpEstadisticas";
            this.grpEstadisticas.Size = new System.Drawing.Size(156, 77);
            this.grpEstadisticas.TabIndex = 7;
            this.grpEstadisticas.TabStop = false;
            this.grpEstadisticas.Text = "Estadísticas";
            // 
            // EditPartosMultiples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BotonBuscarVisible = true;
            this.BotonLimpiarVisible = true;
            this.ClientSize = new System.Drawing.Size(870, 652);
            this.Controls.Add(this.grpEstadisticas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbAsignaciones);
            this.Name = "EditPartosMultiples";
            this.Text = "Alta de Partos Multiple";
            this.Controls.SetChildIndex(this.grbAsignaciones, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.grpEstadisticas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grbAsignaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartosMultiples)).EndInit();
            this.ctxDescartar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpEstadisticas.ResumeLayout(false);
            this.grpEstadisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAsignaciones;
        private System.Windows.Forms.ComboBox cmbTipoParto;
        private System.Windows.Forms.Label lblRacion;
        private System.Windows.Forms.DataGridView dtgPartosMultiples;
        private System.Windows.Forms.Label lblFechaAsignacion;
        private System.Windows.Forms.TextBox txtVivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMuertos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLote;
        private System.Windows.Forms.Button btnbuscarLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFacilidad;
        private System.Windows.Forms.ComboBox cmbFacilidad;
        private System.Windows.Forms.ListView lstAnimalesDescartados;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Motivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpEstadisticas;
        private System.Windows.Forms.Button btnExtenderFechaGrid;
        private System.Windows.Forms.Button btnExtenderFacilidadGrid;
        private System.Windows.Forms.Button btnExtenderTipoPartoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoInsCub;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbTipoPartoGrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbFacilidadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervaloPartoAnterior;
        private System.Windows.Forms.ContextMenuStrip ctxDescartar;
        private System.Windows.Forms.ToolStripMenuItem tsmDescartar;
        private System.Windows.Forms.MaskedTextBox txtFechaParto;
    }
}
