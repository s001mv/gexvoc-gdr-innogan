namespace GEXVOC.UI
{
    partial class EditDiagAnimal
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
            this.grpDiagnostico = new System.Windows.Forms.GroupBox();
            this.txtFecDiagnostico = new GEXVOC.Core.Controles.ctlFecha();
            this.btnBuscarEnfermedad = new System.Windows.Forms.Button();
            this.cmbEnfermedad = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.cmbPersonal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblFecDiagnostico = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpTratamientos = new System.Windows.Forms.TabPage();
            this.tspTratamientos = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevoTratamiento = new System.Windows.Forms.ToolStripButton();
            this.tsbModificarTratamiento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarTratamiento = new System.Windows.Forms.ToolStripButton();
            this.dtgTratamientos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupresionLeche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupresionCarne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grpDiagnostico.SuspendLayout();
            this.tbcContenido.SuspendLayout();
            this.tbpTratamientos.SuspendLayout();
            this.tspTratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDiagnostico
            // 
            this.grpDiagnostico.Controls.Add(this.txtFecDiagnostico);
            this.grpDiagnostico.Controls.Add(this.btnBuscarEnfermedad);
            this.grpDiagnostico.Controls.Add(this.cmbEnfermedad);
            this.grpDiagnostico.Controls.Add(this.btnBuscarPersonal);
            this.grpDiagnostico.Controls.Add(this.btnBuscarAnimal);
            this.grpDiagnostico.Controls.Add(this.cmbPersonal);
            this.grpDiagnostico.Controls.Add(this.cmbAnimal);
            this.grpDiagnostico.Controls.Add(this.lblEnfermedad);
            this.grpDiagnostico.Controls.Add(this.lblPersonal);
            this.grpDiagnostico.Controls.Add(this.txtDiagnostico);
            this.grpDiagnostico.Controls.Add(this.lblDiagnostico);
            this.grpDiagnostico.Controls.Add(this.lblFecDiagnostico);
            this.grpDiagnostico.Controls.Add(this.lblAnimal);
            this.grpDiagnostico.Location = new System.Drawing.Point(12, 28);
            this.grpDiagnostico.Name = "grpDiagnostico";
            this.grpDiagnostico.Size = new System.Drawing.Size(610, 182);
            this.grpDiagnostico.TabIndex = 0;
            this.grpDiagnostico.TabStop = false;
            this.grpDiagnostico.Text = "Datos del diagnóstico";
            // 
            // txtFecDiagnostico
            // 
            this.txtFecDiagnostico.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecDiagnostico.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecDiagnostico.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecDiagnostico.Location = new System.Drawing.Point(116, 87);
            this.txtFecDiagnostico.Name = "txtFecDiagnostico";
            this.txtFecDiagnostico.ReadOnly = false;
            this.txtFecDiagnostico.Size = new System.Drawing.Size(88, 20);
            this.txtFecDiagnostico.TabIndex = 6;
            this.txtFecDiagnostico.Value = null;
            // 
            // btnBuscarEnfermedad
            // 
            this.btnBuscarEnfermedad.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarEnfermedad.Location = new System.Drawing.Point(290, 59);
            this.btnBuscarEnfermedad.Name = "btnBuscarEnfermedad";
            this.btnBuscarEnfermedad.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarEnfermedad.TabIndex = 5;
            this.btnBuscarEnfermedad.UseVisualStyleBackColor = true;
            this.btnBuscarEnfermedad.Click += new System.EventHandler(this.btnBuscarEnfermedad_Click);
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbEnfermedad.btnBusqueda = this.btnBuscarEnfermedad;
            this.cmbEnfermedad.ClaseActiva = null;
            this.cmbEnfermedad.ControlVisible = true;
            this.cmbEnfermedad.DisplayMember = "Descripcion";
            this.cmbEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbEnfermedad.FormattingEnabled = true;
            this.cmbEnfermedad.IdClaseActiva = 0;
            this.cmbEnfermedad.Location = new System.Drawing.Point(116, 60);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.PermitirEliminar = true;
            this.cmbEnfermedad.PermitirLimpiar = true;
            this.cmbEnfermedad.ReadOnly = false;
            this.cmbEnfermedad.Size = new System.Drawing.Size(168, 21);
            this.cmbEnfermedad.TabIndex = 4;
            this.cmbEnfermedad.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbEnfermedad.TipoDatos = null;
            this.cmbEnfermedad.CrearNuevo += new System.EventHandler(this.cmbEnfermedad_CrearNuevo);
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPersonal.Location = new System.Drawing.Point(565, 33);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPersonal.TabIndex = 3;
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(290, 33);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
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
            this.cmbPersonal.Location = new System.Drawing.Point(399, 33);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.PermitirEliminar = true;
            this.cmbPersonal.PermitirLimpiar = true;
            this.cmbPersonal.ReadOnly = false;
            this.cmbPersonal.Size = new System.Drawing.Size(160, 21);
            this.cmbPersonal.TabIndex = 2;
            this.cmbPersonal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPersonal.TipoDatos = null;
            this.cmbPersonal.CrearNuevo += new System.EventHandler(this.cmbPersonal_CrearNuevo);
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAnimal.btnBusqueda = this.btnBuscarAnimal;
            this.cmbAnimal.ClaseActiva = null;
            this.cmbAnimal.ControlVisible = true;
            this.cmbAnimal.DisplayMember = "Nombre";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.IdClaseActiva = 0;
            this.cmbAnimal.Location = new System.Drawing.Point(116, 32);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(168, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEnfermedad.Location = new System.Drawing.Point(17, 63);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(67, 13);
            this.lblEnfermedad.TabIndex = 143;
            this.lblEnfermedad.Text = "Enfermedad:";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPersonal.Location = new System.Drawing.Point(333, 36);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(51, 13);
            this.lblPersonal.TabIndex = 139;
            this.lblPersonal.Text = "Personal:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.AcceptsReturn = true;
            this.txtDiagnostico.Location = new System.Drawing.Point(116, 112);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(470, 64);
            this.txtDiagnostico.TabIndex = 7;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiagnostico.Location = new System.Drawing.Point(17, 115);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.lblDiagnostico.TabIndex = 126;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // lblFecDiagnostico
            // 
            this.lblFecDiagnostico.AutoSize = true;
            this.lblFecDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecDiagnostico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecDiagnostico.Location = new System.Drawing.Point(17, 89);
            this.lblFecDiagnostico.Name = "lblFecDiagnostico";
            this.lblFecDiagnostico.Size = new System.Drawing.Size(78, 13);
            this.lblFecDiagnostico.TabIndex = 124;
            this.lblFecDiagnostico.Text = "F. Diagnóstico:";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(17, 36);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(41, 13);
            this.lblAnimal.TabIndex = 123;
            this.lblAnimal.Text = "Animal:";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpTratamientos);
            this.tbcContenido.Location = new System.Drawing.Point(12, 214);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(610, 296);
            this.tbcContenido.TabIndex = 127;
            // 
            // tbpTratamientos
            // 
            this.tbpTratamientos.Controls.Add(this.tspTratamientos);
            this.tbpTratamientos.Controls.Add(this.dtgTratamientos);
            this.tbpTratamientos.Location = new System.Drawing.Point(4, 22);
            this.tbpTratamientos.Name = "tbpTratamientos";
            this.tbpTratamientos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTratamientos.Size = new System.Drawing.Size(602, 270);
            this.tbpTratamientos.TabIndex = 0;
            this.tbpTratamientos.Text = "Tratamientos";
            this.tbpTratamientos.UseVisualStyleBackColor = true;
            // 
            // tspTratamientos
            // 
            this.tspTratamientos.Dock = System.Windows.Forms.DockStyle.None;
            this.tspTratamientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.tsbNuevoTratamiento,
            this.tsbModificarTratamiento,
            this.toolStripSeparator1,
            this.tsbEliminarTratamiento});
            this.tspTratamientos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspTratamientos.Location = new System.Drawing.Point(377, 244);
            this.tspTratamientos.Name = "tspTratamientos";
            this.tspTratamientos.Size = new System.Drawing.Size(219, 23);
            this.tspTratamientos.TabIndex = 29;
            this.tspTratamientos.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbNuevoTratamiento
            // 
            this.tsbNuevoTratamiento.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoTratamiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoTratamiento.Name = "tsbNuevoTratamiento";
            this.tsbNuevoTratamiento.Size = new System.Drawing.Size(58, 20);
            this.tsbNuevoTratamiento.Text = "Nuevo";
            this.tsbNuevoTratamiento.Click += new System.EventHandler(this.tsbNuevoTratamiento_Click);
            // 
            // tsbModificarTratamiento
            // 
            this.tsbModificarTratamiento.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarTratamiento.AutoSize = false;
            this.tsbModificarTratamiento.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarTratamiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarTratamiento.Name = "tsbModificarTratamiento";
            this.tsbModificarTratamiento.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarTratamiento.Text = " Modificar";
            this.tsbModificarTratamiento.Click += new System.EventHandler(this.tsbModificarTratamiento_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarTratamiento
            // 
            this.tsbEliminarTratamiento.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarTratamiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarTratamiento.Name = "tsbEliminarTratamiento";
            this.tsbEliminarTratamiento.Size = new System.Drawing.Size(63, 20);
            this.tsbEliminarTratamiento.Text = "Eliminar";
            this.tsbEliminarTratamiento.Click += new System.EventHandler(this.tsbEliminarTratamiento_Click);
            // 
            // dtgTratamientos
            // 
            this.dtgTratamientos.AllowUserToAddRows = false;
            this.dtgTratamientos.AllowUserToDeleteRows = false;
            this.dtgTratamientos.AllowUserToOrderColumns = true;
            this.dtgTratamientos.AllowUserToResizeRows = false;
            this.dtgTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTratamientos.BackgroundColor = System.Drawing.Color.White;
            this.dtgTratamientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgTratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Detalle,
            this.Duracion,
            this.SupresionLeche,
            this.SupresionCarne,
            this.dgvPersonal});
            this.dtgTratamientos.Location = new System.Drawing.Point(6, 5);
            this.dtgTratamientos.Name = "dtgTratamientos";
            this.dtgTratamientos.ReadOnly = true;
            this.dtgTratamientos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgTratamientos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgTratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTratamientos.ShowCellErrors = false;
            this.dtgTratamientos.ShowCellToolTips = false;
            this.dtgTratamientos.ShowEditingIcon = false;
            this.dtgTratamientos.ShowRowErrors = false;
            this.dtgTratamientos.Size = new System.Drawing.Size(590, 229);
            this.dtgTratamientos.TabIndex = 15;
            this.dtgTratamientos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTratamientos_cellDoubleClick);
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
            // Detalle
            // 
            this.Detalle.DataPropertyName = "Detalle";
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Detalle.Width = 65;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "Duracion";
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Duracion.Width = 75;
            // 
            // SupresionLeche
            // 
            this.SupresionLeche.DataPropertyName = "DescFSupresionLeche";
            this.SupresionLeche.HeaderText = "S.Leche";
            this.SupresionLeche.Name = "SupresionLeche";
            this.SupresionLeche.ReadOnly = true;
            this.SupresionLeche.Width = 72;
            // 
            // SupresionCarne
            // 
            this.SupresionCarne.DataPropertyName = "DescFSupresionCarne";
            this.SupresionCarne.HeaderText = "S.Carne";
            this.SupresionCarne.Name = "SupresionCarne";
            this.SupresionCarne.ReadOnly = true;
            this.SupresionCarne.Width = 70;
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.DataPropertyName = "DescPersonal";
            this.dgvPersonal.HeaderText = "Personal";
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvPersonal.Width = 73;
            // 
            // EditDiagAnimal
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 535);
            this.Controls.Add(this.grpDiagnostico);
            this.Controls.Add(this.tbcContenido);
            this.Name = "EditDiagAnimal";
            this.Text = "Diagnóstico";
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            this.Controls.SetChildIndex(this.grpDiagnostico, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grpDiagnostico.ResumeLayout(false);
            this.grpDiagnostico.PerformLayout();
            this.tbcContenido.ResumeLayout(false);
            this.tbpTratamientos.ResumeLayout(false);
            this.tbpTratamientos.PerformLayout();
            this.tspTratamientos.ResumeLayout(false);
            this.tspTratamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDiagnostico;
        private System.Windows.Forms.Label lblEnfermedad;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblFecDiagnostico;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpTratamientos;
        private System.Windows.Forms.DataGridView dtgTratamientos;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbPersonal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.ToolStrip tspTratamientos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbModificarTratamiento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEliminarTratamiento;
        private System.Windows.Forms.ToolStripButton tsbNuevoTratamiento;
        private System.Windows.Forms.Button btnBuscarEnfermedad;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupresionLeche;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupresionCarne;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPersonal;
        private GEXVOC.Core.Controles.ctlFecha txtFecDiagnostico;

    }
}
