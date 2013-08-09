namespace GEXVOC.UI
{
    partial class EditPartos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPartos));
            this.grpParto = new System.Windows.Forms.GroupBox();
            this.txtMuertos = new System.Windows.Forms.TextBox();
            this.lblMuertos = new System.Windows.Forms.Label();
            this.txtVivos = new System.Windows.Forms.TextBox();
            this.lblVivos = new System.Windows.Forms.Label();
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFacilidad = new System.Windows.Forms.Label();
            this.cmbfacilidad = new System.Windows.Forms.ComboBox();
            this.lblHembra = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpInseminaciones = new System.Windows.Forms.TabPage();
            this.tspInseminaciones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevaInseminacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarInseminacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarInseminacion = new System.Windows.Forms.ToolStripButton();
            this.dtgInseminaciones = new System.Windows.Forms.DataGridView();
            this.FechaInseminacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoInseminacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearAnimal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grpParto.SuspendLayout();
            this.tbcContenido.SuspendLayout();
            this.tbpInseminaciones.SuspendLayout();
            this.tspInseminaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInseminaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpParto
            // 
            this.grpParto.Controls.Add(this.txtFecha);
            this.grpParto.Controls.Add(this.txtMuertos);
            this.grpParto.Controls.Add(this.lblMuertos);
            this.grpParto.Controls.Add(this.txtVivos);
            this.grpParto.Controls.Add(this.lblVivos);
            this.grpParto.Controls.Add(this.cmbHembra);
            this.grpParto.Controls.Add(this.btnBuscarAnimal);
            this.grpParto.Controls.Add(this.cmbTipo);
            this.grpParto.Controls.Add(this.lblTipo);
            this.grpParto.Controls.Add(this.lblFecha);
            this.grpParto.Controls.Add(this.lblFacilidad);
            this.grpParto.Controls.Add(this.cmbfacilidad);
            this.grpParto.Controls.Add(this.lblHembra);
            this.grpParto.Location = new System.Drawing.Point(12, 28);
            this.grpParto.Name = "grpParto";
            this.grpParto.Size = new System.Drawing.Size(432, 181);
            this.grpParto.TabIndex = 0;
            this.grpParto.TabStop = false;
            this.grpParto.Text = "Datos del parto";
            // 
            // txtMuertos
            // 
            this.txtMuertos.Location = new System.Drawing.Point(112, 155);
            this.txtMuertos.Name = "txtMuertos";
            this.txtMuertos.Size = new System.Drawing.Size(100, 20);
            this.txtMuertos.TabIndex = 6;
            // 
            // lblMuertos
            // 
            this.lblMuertos.AutoSize = true;
            this.lblMuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuertos.Location = new System.Drawing.Point(44, 158);
            this.lblMuertos.Name = "lblMuertos";
            this.lblMuertos.Size = new System.Drawing.Size(48, 13);
            this.lblMuertos.TabIndex = 127;
            this.lblMuertos.Text = "Muertos:";
            // 
            // txtVivos
            // 
            this.txtVivos.Location = new System.Drawing.Point(112, 129);
            this.txtVivos.Name = "txtVivos";
            this.txtVivos.Size = new System.Drawing.Size(100, 20);
            this.txtVivos.TabIndex = 5;
            // 
            // lblVivos
            // 
            this.lblVivos.AutoSize = true;
            this.lblVivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVivos.Location = new System.Drawing.Point(44, 132);
            this.lblVivos.Name = "lblVivos";
            this.lblVivos.Size = new System.Drawing.Size(36, 13);
            this.lblVivos.TabIndex = 125;
            this.lblVivos.Text = "Vivos:";
            // 
            // cmbHembra
            // 
            this.cmbHembra.BackColor = System.Drawing.SystemColors.Control;
            this.cmbHembra.btnBusqueda = this.btnBuscarAnimal;
            this.cmbHembra.ClaseActiva = null;
            this.cmbHembra.ControlVisible = true;
            this.cmbHembra.DisplayMember = "Nombre";
            this.cmbHembra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbHembra.FormattingEnabled = true;
            this.cmbHembra.IdClaseActiva = 0;
            this.cmbHembra.Location = new System.Drawing.Point(112, 25);
            this.cmbHembra.Name = "cmbHembra";
            this.cmbHembra.PermitirEliminar = true;
            this.cmbHembra.PermitirLimpiar = true;
            this.cmbHembra.ReadOnly = false;
            this.cmbHembra.Size = new System.Drawing.Size(168, 21);
            this.cmbHembra.TabIndex = 0;
            this.cmbHembra.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbHembra.TipoDatos = null;
            this.cmbHembra.ValueMember = "Id";
            this.cmbHembra.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbHembra_ClaseActivaChanged);
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(286, 25);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarVaca_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(112, 74);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(286, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(44, 78);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 13);
            this.lblTipo.TabIndex = 119;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(44, 52);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 124;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblFacilidad
            // 
            this.lblFacilidad.AutoSize = true;
            this.lblFacilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFacilidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFacilidad.Location = new System.Drawing.Point(44, 104);
            this.lblFacilidad.Name = "lblFacilidad";
            this.lblFacilidad.Size = new System.Drawing.Size(62, 13);
            this.lblFacilidad.TabIndex = 120;
            this.lblFacilidad.Text = "Facilidad:";
            // 
            // cmbfacilidad
            // 
            this.cmbfacilidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbfacilidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbfacilidad.FormattingEnabled = true;
            this.cmbfacilidad.Location = new System.Drawing.Point(112, 101);
            this.cmbfacilidad.Name = "cmbfacilidad";
            this.cmbfacilidad.Size = new System.Drawing.Size(286, 21);
            this.cmbfacilidad.TabIndex = 4;
            // 
            // lblHembra
            // 
            this.lblHembra.AutoSize = true;
            this.lblHembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHembra.Location = new System.Drawing.Point(44, 29);
            this.lblHembra.Name = "lblHembra";
            this.lblHembra.Size = new System.Drawing.Size(54, 13);
            this.lblHembra.TabIndex = 123;
            this.lblHembra.Text = "Hembra:";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpInseminaciones);
            this.tbcContenido.Location = new System.Drawing.Point(12, 215);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(610, 296);
            this.tbcContenido.TabIndex = 127;
            // 
            // tbpInseminaciones
            // 
            this.tbpInseminaciones.Controls.Add(this.tspInseminaciones);
            this.tbpInseminaciones.Controls.Add(this.dtgInseminaciones);
            this.tbpInseminaciones.Location = new System.Drawing.Point(4, 22);
            this.tbpInseminaciones.Name = "tbpInseminaciones";
            this.tbpInseminaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInseminaciones.Size = new System.Drawing.Size(602, 270);
            this.tbpInseminaciones.TabIndex = 0;
            this.tbpInseminaciones.Text = "Inseminaciones";
            this.tbpInseminaciones.UseVisualStyleBackColor = true;
            // 
            // tspInseminaciones
            // 
            this.tspInseminaciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tspInseminaciones.Enabled = false;
            this.tspInseminaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevaInseminacion,
            this.toolStripSeparator4,
            this.tsbModificarInseminacion,
            this.toolStripSeparator2,
            this.tsbEliminarInseminacion});
            this.tspInseminaciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspInseminaciones.Location = new System.Drawing.Point(282, 180);
            this.tspInseminaciones.Name = "tspInseminaciones";
            this.tspInseminaciones.Size = new System.Drawing.Size(268, 23);
            this.tspInseminaciones.TabIndex = 30;
            this.tspInseminaciones.Text = "toolStrip1";
            this.tspInseminaciones.Visible = false;
            // 
            // tsbNuevaInseminacion
            // 
            this.tsbNuevaInseminacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevaInseminacion.AutoSize = false;
            this.tsbNuevaInseminacion.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevaInseminacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevaInseminacion.Name = "tsbNuevaInseminacion";
            this.tsbNuevaInseminacion.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevaInseminacion.Text = " Nuevo ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarInseminacion
            // 
            this.tsbModificarInseminacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarInseminacion.AutoSize = false;
            this.tsbModificarInseminacion.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarInseminacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarInseminacion.Name = "tsbModificarInseminacion";
            this.tsbModificarInseminacion.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarInseminacion.Text = " Modificar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarInseminacion
            // 
            this.tsbEliminarInseminacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarInseminacion.AutoSize = false;
            this.tsbEliminarInseminacion.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarInseminacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarInseminacion.Name = "tsbEliminarInseminacion";
            this.tsbEliminarInseminacion.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarInseminacion.Text = " Eliminar ";
            // 
            // dtgInseminaciones
            // 
            this.dtgInseminaciones.AllowUserToAddRows = false;
            this.dtgInseminaciones.AllowUserToDeleteRows = false;
            this.dtgInseminaciones.AllowUserToOrderColumns = true;
            this.dtgInseminaciones.AllowUserToResizeRows = false;
            this.dtgInseminaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgInseminaciones.BackgroundColor = System.Drawing.Color.White;
            this.dtgInseminaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgInseminaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInseminaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaInseminacion,
            this.TipoInseminacion,
            this.Toro});
            this.dtgInseminaciones.Location = new System.Drawing.Point(6, 5);
            this.dtgInseminaciones.Name = "dtgInseminaciones";
            this.dtgInseminaciones.ReadOnly = true;
            this.dtgInseminaciones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgInseminaciones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgInseminaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInseminaciones.ShowCellErrors = false;
            this.dtgInseminaciones.ShowCellToolTips = false;
            this.dtgInseminaciones.ShowEditingIcon = false;
            this.dtgInseminaciones.ShowRowErrors = false;
            this.dtgInseminaciones.Size = new System.Drawing.Size(590, 229);
            this.dtgInseminaciones.TabIndex = 15;
            // 
            // FechaInseminacion
            // 
            this.FechaInseminacion.DataPropertyName = "Fecha";
            this.FechaInseminacion.HeaderText = "Fecha";
            this.FechaInseminacion.Name = "FechaInseminacion";
            this.FechaInseminacion.ReadOnly = true;
            this.FechaInseminacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FechaInseminacion.Width = 62;
            // 
            // TipoInseminacion
            // 
            this.TipoInseminacion.DataPropertyName = "DescTipo";
            this.TipoInseminacion.HeaderText = "Tipo";
            this.TipoInseminacion.Name = "TipoInseminacion";
            this.TipoInseminacion.ReadOnly = true;
            this.TipoInseminacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TipoInseminacion.Width = 53;
            // 
            // Toro
            // 
            this.Toro.DataPropertyName = "DescMacho";
            this.Toro.HeaderText = "Macho";
            this.Toro.Name = "Toro";
            this.Toro.ReadOnly = true;
            this.Toro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Toro.Width = 65;
            // 
            // btnCrearAnimal
            // 
            this.btnCrearAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAnimal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCrearAnimal.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearAnimal.Image")));
            this.btnCrearAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearAnimal.Location = new System.Drawing.Point(8, 67);
            this.btnCrearAnimal.Name = "btnCrearAnimal";
            this.btnCrearAnimal.Size = new System.Drawing.Size(155, 51);
            this.btnCrearAnimal.TabIndex = 0;
            this.btnCrearAnimal.Text = "Crear Animal  ";
            this.btnCrearAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCrearAnimal, "Lanza el formulario de animales en modo inserción, traspasando los datos que se p" +
                    "ueden extraer del parto.");
            this.btnCrearAnimal.UseVisualStyleBackColor = true;
            this.btnCrearAnimal.Click += new System.EventHandler(this.btnCrearAnimal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearAnimal);
            this.groupBox1.Location = new System.Drawing.Point(449, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones con Partos.";
            // 
            // txtFecha
            // 
            this.txtFecha.HidePromptOnLeave = true;
            this.txtFecha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFecha.Location = new System.Drawing.Point(112, 49);
            this.txtFecha.Mask = "00/00/0099";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // EditPartos
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpParto);
            this.Controls.Add(this.tbcContenido);
            this.Name = "EditPartos";
            this.Text = "Partos";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditPartos_PropiedadAControl);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            this.Controls.SetChildIndex(this.grpParto, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grpParto.ResumeLayout(false);
            this.grpParto.PerformLayout();
            this.tbcContenido.ResumeLayout(false);
            this.tbpInseminaciones.ResumeLayout(false);
            this.tbpInseminaciones.PerformLayout();
            this.tspInseminaciones.ResumeLayout(false);
            this.tspInseminaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInseminaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpParto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFacilidad;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.ComboBox cmbfacilidad;
        private System.Windows.Forms.Label lblHembra;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpInseminaciones;
        private System.Windows.Forms.DataGridView dtgInseminaciones;
        private System.Windows.Forms.ToolStrip tspInseminaciones;
        private System.Windows.Forms.ToolStripButton tsbNuevaInseminacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarInseminacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarInseminacion;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInseminacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoInseminacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toro;
        private System.Windows.Forms.TextBox txtMuertos;
        private System.Windows.Forms.Label lblMuertos;
        private System.Windows.Forms.TextBox txtVivos;
        private System.Windows.Forms.Label lblVivos;
        private System.Windows.Forms.Button btnCrearAnimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}
