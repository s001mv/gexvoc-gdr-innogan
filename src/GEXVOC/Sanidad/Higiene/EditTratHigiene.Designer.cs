namespace GEXVOC.UI
{
    partial class EditTratHigiene
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
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpProHig = new System.Windows.Forms.TabPage();
            this.tspMunicipios = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoProHig = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarProHig = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarProHig = new System.Windows.Forms.ToolStripButton();
            this.dtgProHig = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbPlanHigiene = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpProHig.SuspendLayout();
            this.tspMunicipios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProHig)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(226, 77);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 72;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(16, 77);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 71;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.AcceptsReturn = true;
            this.txtDetalle.Location = new System.Drawing.Point(116, 104);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(493, 108);
            this.txtDetalle.TabIndex = 3;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(16, 104);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblDetalle.TabIndex = 70;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(16, 49);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(85, 13);
            this.lblPlan.TabIndex = 66;
            this.lblPlan.Text = "Plan de Higiene:";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpProHig);
            this.tbcContenido.Location = new System.Drawing.Point(12, 218);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(610, 296);
            this.tbcContenido.TabIndex = 4;
            // 
            // tbpProHig
            // 
            this.tbpProHig.Controls.Add(this.tspMunicipios);
            this.tbpProHig.Controls.Add(this.dtgProHig);
            this.tbpProHig.Location = new System.Drawing.Point(4, 22);
            this.tbpProHig.Name = "tbpProHig";
            this.tbpProHig.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProHig.Size = new System.Drawing.Size(602, 270);
            this.tbpProHig.TabIndex = 0;
            this.tbpProHig.Text = "Productos empleados";
            this.tbpProHig.UseVisualStyleBackColor = true;
            // 
            // tspMunicipios
            // 
            this.tspMunicipios.Dock = System.Windows.Forms.DockStyle.None;
            this.tspMunicipios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoProHig,
            this.toolStripSeparator4,
            this.tsbModificarProHig,
            this.toolStripSeparator2,
            this.tsbEliminarProHig});
            this.tspMunicipios.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspMunicipios.Location = new System.Drawing.Point(329, 237);
            this.tspMunicipios.Name = "tspMunicipios";
            this.tspMunicipios.Size = new System.Drawing.Size(268, 23);
            this.tspMunicipios.TabIndex = 30;
            this.tspMunicipios.Text = "toolStrip1";
            // 
            // tsbNuevoProHig
            // 
            this.tsbNuevoProHig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoProHig.AutoSize = false;
            this.tsbNuevoProHig.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoProHig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoProHig.Name = "tsbNuevoProHig";
            this.tsbNuevoProHig.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoProHig.Text = " Nuevo ";
            this.tsbNuevoProHig.Click += new System.EventHandler(this.tsbNuevoProHig_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarProHig
            // 
            this.tsbModificarProHig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarProHig.AutoSize = false;
            this.tsbModificarProHig.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarProHig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarProHig.Name = "tsbModificarProHig";
            this.tsbModificarProHig.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarProHig.Text = " Modificar";
            this.tsbModificarProHig.Click += new System.EventHandler(this.tsbModificarProHig_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarProHig
            // 
            this.tsbEliminarProHig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarProHig.AutoSize = false;
            this.tsbEliminarProHig.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarProHig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarProHig.Name = "tsbEliminarProHig";
            this.tsbEliminarProHig.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarProHig.Text = " Eliminar ";
            this.tsbEliminarProHig.Click += new System.EventHandler(this.tsbEliminarProHig_Click);
            // 
            // dtgProHig
            // 
            this.dtgProHig.AllowUserToAddRows = false;
            this.dtgProHig.AllowUserToDeleteRows = false;
            this.dtgProHig.AllowUserToOrderColumns = true;
            this.dtgProHig.AllowUserToResizeRows = false;
            this.dtgProHig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProHig.BackgroundColor = System.Drawing.Color.White;
            this.dtgProHig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgProHig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProHig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.DescFamilia,
            this.Cantidad});
            this.dtgProHig.Location = new System.Drawing.Point(6, 5);
            this.dtgProHig.Name = "dtgProHig";
            this.dtgProHig.ReadOnly = true;
            this.dtgProHig.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgProHig.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProHig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProHig.ShowCellErrors = false;
            this.dtgProHig.ShowCellToolTips = false;
            this.dtgProHig.ShowEditingIcon = false;
            this.dtgProHig.ShowRowErrors = false;
            this.dtgProHig.Size = new System.Drawing.Size(590, 229);
            this.dtgProHig.TabIndex = 15;
            this.dtgProHig.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProHig_CellDoubleClick);
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
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(116, 74);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 1;
            this.txtFechaInicio.Value = null;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(289, 74);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 2;
            this.txtFechaFin.Value = null;
            // 
            // cmbPlanHigiene
            // 
            this.cmbPlanHigiene.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPlanHigiene.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlanHigiene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbPlanHigiene.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbPlanHigiene.FormattingEnabled = true;
            this.cmbPlanHigiene.Location = new System.Drawing.Point(116, 46);
            this.cmbPlanHigiene.Name = "cmbPlanHigiene";
            this.cmbPlanHigiene.Size = new System.Drawing.Size(368, 21);
            this.cmbPlanHigiene.TabIndex = 0;
            this.cmbPlanHigiene.CargarContenido += new System.EventHandler(this.cmbPlanHigiene_CargarContenido);
            this.cmbPlanHigiene.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbPlanHigiene_CrearNuevo);
            // 
            // EditTratHigiene
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 538);
            this.Controls.Add(this.cmbPlanHigiene);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.tbcContenido);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblPlan);
            this.Name = "EditTratHigiene";
            this.Text = "Tratamiento Higiene";
            this.Controls.SetChildIndex(this.lblPlan, 0);
            this.Controls.SetChildIndex(this.lblDetalle, 0);
            this.Controls.SetChildIndex(this.txtDetalle, 0);
            this.Controls.SetChildIndex(this.lblFechaInicio, 0);
            this.Controls.SetChildIndex(this.lblFechaFin, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            this.Controls.SetChildIndex(this.txtFechaInicio, 0);
            this.Controls.SetChildIndex(this.txtFechaFin, 0);
            this.Controls.SetChildIndex(this.cmbPlanHigiene, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpProHig.ResumeLayout(false);
            this.tbpProHig.PerformLayout();
            this.tspMunicipios.ResumeLayout(false);
            this.tspMunicipios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProHig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpProHig;
        private System.Windows.Forms.ToolStrip tspMunicipios;
        private System.Windows.Forms.ToolStripButton tsbNuevoProHig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarProHig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarProHig;
        private System.Windows.Forms.DataGridView dtgProHig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
        private GEXVOC.Core.Controles.ctlCombo cmbPlanHigiene;
    }
}
