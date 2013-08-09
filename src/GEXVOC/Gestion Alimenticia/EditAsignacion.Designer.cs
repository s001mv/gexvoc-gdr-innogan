namespace GEXVOC.UI
{
    partial class EditAsignacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbAsignaciones = new System.Windows.Forms.GroupBox();
            this.cmbRacion = new GEXVOC.Core.Controles.ctlCombo();
            this.lblDiasRacion = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblRacion = new System.Windows.Forms.Label();
            this.tsbAsignaciones = new System.Windows.Forms.ToolStrip();
            this.tsbEliminarAsignacion = new System.Windows.Forms.ToolStripButton();
            this.dtgAsignaciones = new System.Windows.Forms.DataGridView();
            this.idAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRacionGrid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtFechaAsignacion = new GEXVOC.Core.Controles.ctlFecha();
            this.lblselección = new System.Windows.Forms.Label();
            this.cmbSeleccionAnimales = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimales = new System.Windows.Forms.Button();
            this.cmbLote = new System.Windows.Forms.ComboBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblFechaAsignacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grbAsignaciones.SuspendLayout();
            this.tsbAsignaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsignaciones)).BeginInit();
            this.grbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAsignaciones
            // 
            this.grbAsignaciones.Controls.Add(this.cmbRacion);
            this.grbAsignaciones.Controls.Add(this.lblDiasRacion);
            this.grbAsignaciones.Controls.Add(this.txtDias);
            this.grbAsignaciones.Controls.Add(this.lblDias);
            this.grbAsignaciones.Controls.Add(this.lblEtiqueta);
            this.grbAsignaciones.Controls.Add(this.txtPorcentaje);
            this.grbAsignaciones.Controls.Add(this.lblPorcentaje);
            this.grbAsignaciones.Controls.Add(this.lblRacion);
            this.grbAsignaciones.Controls.Add(this.tsbAsignaciones);
            this.grbAsignaciones.Controls.Add(this.dtgAsignaciones);
            this.grbAsignaciones.Location = new System.Drawing.Point(12, 125);
            this.grbAsignaciones.Name = "grbAsignaciones";
            this.grbAsignaciones.Size = new System.Drawing.Size(678, 418);
            this.grbAsignaciones.TabIndex = 1;
            this.grbAsignaciones.TabStop = false;
            this.grbAsignaciones.Text = "Asignaciones";
            // 
            // cmbRacion
            // 
            this.cmbRacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbRacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbRacion.FormattingEnabled = true;
            this.cmbRacion.Location = new System.Drawing.Point(59, 22);
            this.cmbRacion.Name = "cmbRacion";
            this.cmbRacion.Size = new System.Drawing.Size(176, 21);
            this.cmbRacion.TabIndex = 0;
            this.cmbRacion.CargarContenido += new System.EventHandler(this.cmbRacion_CargarContenido);
            this.cmbRacion.SelectedValueChanged += new System.EventHandler(this.cmbRacion_SelectedValueChanged);
            this.cmbRacion.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbRacion_CrearNuevo);
            // 
            // lblDiasRacion
            // 
            this.lblDiasRacion.AutoSize = true;
            this.lblDiasRacion.Location = new System.Drawing.Point(602, 25);
            this.lblDiasRacion.Name = "lblDiasRacion";
            this.lblDiasRacion.Size = new System.Drawing.Size(28, 13);
            this.lblDiasRacion.TabIndex = 65;
            this.lblDiasRacion.Text = "días";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(556, 22);
            this.txtDias.MaxLength = 10;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(40, 20);
            this.txtDias.TabIndex = 2;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(460, 25);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(90, 13);
            this.lblDias.TabIndex = 64;
            this.lblDias.Text = "Duración Ración:";
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(422, 25);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(15, 13);
            this.lblEtiqueta.TabIndex = 63;
            this.lblEtiqueta.Text = "%";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(360, 22);
            this.txtPorcentaje.MaxLength = 3;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(55, 20);
            this.txtPorcentaje.TabIndex = 1;
            this.txtPorcentaje.TextChanged += new System.EventHandler(this.txtPorcentaje_TextChanged);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(251, 25);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(113, 13);
            this.lblPorcentaje.TabIndex = 61;
            this.lblPorcentaje.Text = "Porcentaje por Animal:";
            // 
            // lblRacion
            // 
            this.lblRacion.AutoSize = true;
            this.lblRacion.Location = new System.Drawing.Point(9, 25);
            this.lblRacion.Name = "lblRacion";
            this.lblRacion.Size = new System.Drawing.Size(44, 13);
            this.lblRacion.TabIndex = 59;
            this.lblRacion.Text = "Ración:";
            // 
            // tsbAsignaciones
            // 
            this.tsbAsignaciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbAsignaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEliminarAsignacion});
            this.tsbAsignaciones.Location = new System.Drawing.Point(530, 390);
            this.tsbAsignaciones.Name = "tsbAsignaciones";
            this.tsbAsignaciones.Size = new System.Drawing.Size(129, 25);
            this.tsbAsignaciones.TabIndex = 58;
            this.tsbAsignaciones.Text = "toolStrip1";
            // 
            // tsbEliminarAsignacion
            // 
            this.tsbEliminarAsignacion.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarAsignacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarAsignacion.Name = "tsbEliminarAsignacion";
            this.tsbEliminarAsignacion.Size = new System.Drawing.Size(117, 22);
            this.tsbEliminarAsignacion.Text = "Eliminar Asignación";
            this.tsbEliminarAsignacion.Click += new System.EventHandler(this.tsbEliminarAsignacion_Click);
            // 
            // dtgAsignaciones
            // 
            this.dtgAsignaciones.AllowUserToAddRows = false;
            this.dtgAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnimal,
            this.idAsignacion,
            this.Identificacion,
            this.NombreAnimal,
            this.estadoAnimal,
            this.cmbRacionGrid,
            this.Porcentaje,
            this.FechaInicio,
            this.Dias});
            this.dtgAsignaciones.Location = new System.Drawing.Point(9, 53);
            this.dtgAsignaciones.Name = "dtgAsignaciones";
            this.dtgAsignaciones.Size = new System.Drawing.Size(650, 334);
            this.dtgAsignaciones.TabIndex = 8;
            this.dtgAsignaciones.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgAsignaciones_RowsAdded);
            this.dtgAsignaciones.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgAsignaciones_RowHeaderMouseDoubleClick);
            // 
            // idAnimal
            // 
            this.idAnimal.HeaderText = "idAnimal";
            this.idAnimal.Name = "idAnimal";
            this.idAnimal.Visible = false;
            // 
            // idAsignacion
            // 
            this.idAsignacion.HeaderText = "idAsignacion";
            this.idAsignacion.Name = "idAsignacion";
            this.idAsignacion.Visible = false;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.MaxInputLength = 30;
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // NombreAnimal
            // 
            this.NombreAnimal.HeaderText = "Animal";
            this.NombreAnimal.MaxInputLength = 35;
            this.NombreAnimal.Name = "NombreAnimal";
            this.NombreAnimal.ReadOnly = true;
            this.NombreAnimal.Width = 75;
            // 
            // estadoAnimal
            // 
            this.estadoAnimal.HeaderText = "Estado";
            this.estadoAnimal.MaxInputLength = 30;
            this.estadoAnimal.Name = "estadoAnimal";
            this.estadoAnimal.ReadOnly = true;
            this.estadoAnimal.Width = 110;
            // 
            // cmbRacionGrid
            // 
            this.cmbRacionGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRacionGrid.HeaderText = "Ración";
            this.cmbRacionGrid.MaxDropDownItems = 50;
            this.cmbRacionGrid.Name = "cmbRacionGrid";
            this.cmbRacionGrid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.MaxInputLength = 3;
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Width = 75;
            // 
            // FechaInicio
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaInicio.HeaderText = "F. Inicio";
            this.FechaInicio.MaxInputLength = 10;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 75;
            // 
            // Dias
            // 
            dataGridViewCellStyle4.NullValue = null;
            this.Dias.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dias.HeaderText = "Dias";
            this.Dias.MaxInputLength = 10;
            this.Dias.Name = "Dias";
            this.Dias.Width = 50;
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.txtFechaAsignacion);
            this.grbBusqueda.Controls.Add(this.lblselección);
            this.grbBusqueda.Controls.Add(this.cmbSeleccionAnimales);
            this.grbBusqueda.Controls.Add(this.btnBuscarAnimales);
            this.grbBusqueda.Controls.Add(this.cmbLote);
            this.grbBusqueda.Controls.Add(this.lblLote);
            this.grbBusqueda.Controls.Add(this.lblFechaAsignacion);
            this.grbBusqueda.Location = new System.Drawing.Point(12, 39);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(678, 80);
            this.grbBusqueda.TabIndex = 0;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Busqueda";
            // 
            // txtFechaAsignacion
            // 
            this.txtFechaAsignacion.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaAsignacion.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaAsignacion.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaAsignacion.Location = new System.Drawing.Point(132, 20);
            this.txtFechaAsignacion.Name = "txtFechaAsignacion";
            this.txtFechaAsignacion.ReadOnly = false;
            this.txtFechaAsignacion.Size = new System.Drawing.Size(88, 20);
            this.txtFechaAsignacion.TabIndex = 0;
            this.txtFechaAsignacion.Value = null;
            // 
            // lblselección
            // 
            this.lblselección.AutoSize = true;
            this.lblselección.Location = new System.Drawing.Point(9, 54);
            this.lblselección.Name = "lblselección";
            this.lblselección.Size = new System.Drawing.Size(117, 13);
            this.lblselección.TabIndex = 57;
            this.lblselección.Text = "Selección de Animales:";
            // 
            // cmbSeleccionAnimales
            // 
            this.cmbSeleccionAnimales.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSeleccionAnimales.btnBusqueda = this.btnBuscarAnimales;
            this.cmbSeleccionAnimales.ClaseActiva = null;
            this.cmbSeleccionAnimales.ControlVisible = true;
            this.cmbSeleccionAnimales.DisplayMember = "Nombre";
            this.cmbSeleccionAnimales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbSeleccionAnimales.FormattingEnabled = true;
            this.cmbSeleccionAnimales.IdClaseActiva = 0;
            this.cmbSeleccionAnimales.Location = new System.Drawing.Point(132, 51);
            this.cmbSeleccionAnimales.Name = "cmbSeleccionAnimales";
            this.cmbSeleccionAnimales.PermitirEliminar = true;
            this.cmbSeleccionAnimales.PermitirLimpiar = true;
            this.cmbSeleccionAnimales.ReadOnly = false;
            this.cmbSeleccionAnimales.Size = new System.Drawing.Size(168, 21);
            this.cmbSeleccionAnimales.TabIndex = 2;
            this.cmbSeleccionAnimales.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbSeleccionAnimales.TipoDatos = null;
            this.cmbSeleccionAnimales.TextChanged += new System.EventHandler(this.cmbSeleccionAnimales_TextChanged);
            // 
            // btnBuscarAnimales
            // 
            this.btnBuscarAnimales.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimales.Location = new System.Drawing.Point(306, 50);
            this.btnBuscarAnimales.Name = "btnBuscarAnimales";
            this.btnBuscarAnimales.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimales.TabIndex = 3;
            this.btnBuscarAnimales.UseVisualStyleBackColor = true;
            this.btnBuscarAnimales.Click += new System.EventHandler(this.btnBuscarAnimales_Click);
            // 
            // cmbLote
            // 
            this.cmbLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.Location = new System.Drawing.Point(443, 17);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.Size = new System.Drawing.Size(153, 21);
            this.cmbLote.TabIndex = 1;
            this.cmbLote.SelectedValueChanged += new System.EventHandler(this.cmbLote_SelectedValueChanged);
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(346, 20);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(91, 13);
            this.lblLote.TabIndex = 6;
            this.lblLote.Text = "Lote de Animales:";
            // 
            // lblFechaAsignacion
            // 
            this.lblFechaAsignacion.AutoSize = true;
            this.lblFechaAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAsignacion.Location = new System.Drawing.Point(14, 20);
            this.lblFechaAsignacion.Name = "lblFechaAsignacion";
            this.lblFechaAsignacion.Size = new System.Drawing.Size(112, 13);
            this.lblFechaAsignacion.TabIndex = 2;
            this.lblFechaAsignacion.Text = "Fecha Asignación:";
            // 
            // EditAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BotonBuscarVisible = true;
            this.BotonLimpiarVisible = true;
            this.ClientSize = new System.Drawing.Size(702, 568);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.grbAsignaciones);
            this.Name = "EditAsignacion";
            this.Text = "Asignaciones Alimenticias";
            this.Controls.SetChildIndex(this.grbAsignaciones, 0);
            this.Controls.SetChildIndex(this.grbBusqueda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grbAsignaciones.ResumeLayout(false);
            this.grbAsignaciones.PerformLayout();
            this.tsbAsignaciones.ResumeLayout(false);
            this.tsbAsignaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsignaciones)).EndInit();
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAsignaciones;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Label lblFechaAsignacion;
        private System.Windows.Forms.DataGridView dtgAsignaciones;
        private System.Windows.Forms.ToolStrip tsbAsignaciones;
        private System.Windows.Forms.ToolStripButton tsbEliminarAsignacion;
        private System.Windows.Forms.ComboBox cmbLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblRacion;
        private System.Windows.Forms.Label lblselección;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbSeleccionAnimales;
        private System.Windows.Forms.Button btnBuscarAnimales;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoAnimal;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbRacionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.Label lblDiasRacion;
        private GEXVOC.Core.Controles.ctlFecha txtFechaAsignacion;
        private GEXVOC.Core.Controles.ctlCombo cmbRacion;
    }
}
