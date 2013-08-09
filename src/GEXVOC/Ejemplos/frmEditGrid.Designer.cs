namespace GEXVOC.Ejemplos
{
    partial class frmEditGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpTitulares = new System.Windows.Forms.TabPage();
            this.tspTitulares = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoTitular = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmTitularNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTitularExistente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarTitular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarTitular = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmEliminarTitular = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarRelacion = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgTitulares = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpAnimales = new System.Windows.Forms.TabPage();
            this.tspAnimales = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoAnimal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarAnimal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarAnimal = new System.Windows.Forms.ToolStripButton();
            this.dtgAnimales = new System.Windows.Forms.DataGridView();
            this.IdVaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomVaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Historico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpTitulares.SuspendLayout();
            this.tspTitulares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTitulares)).BeginInit();
            this.tbpAnimales.SuspendLayout();
            this.tspAnimales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 88);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpTitulares);
            this.tbcContenido.Controls.Add(this.tbpAnimales);
            this.tbcContenido.Location = new System.Drawing.Point(12, 143);
            this.tbcContenido.Multiline = true;
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(610, 279);
            this.tbcContenido.TabIndex = 63;
            // 
            // tbpTitulares
            // 
            this.tbpTitulares.Controls.Add(this.tspTitulares);
            this.tbpTitulares.Controls.Add(this.dtgTitulares);
            this.tbpTitulares.Location = new System.Drawing.Point(4, 22);
            this.tbpTitulares.Name = "tbpTitulares";
            this.tbpTitulares.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTitulares.Size = new System.Drawing.Size(602, 253);
            this.tbpTitulares.TabIndex = 1;
            this.tbpTitulares.Text = "Titulares";
            this.tbpTitulares.UseVisualStyleBackColor = true;
            // 
            // tspTitulares
            // 
            this.tspTitulares.Dock = System.Windows.Forms.DockStyle.None;
            this.tspTitulares.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoTitular,
            this.toolStripSeparator3,
            this.tsbModificarTitular,
            this.toolStripSeparator1,
            this.tsbEliminarTitular});
            this.tspTitulares.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspTitulares.Location = new System.Drawing.Point(327, 226);
            this.tspTitulares.Name = "tspTitulares";
            this.tspTitulares.Size = new System.Drawing.Size(268, 23);
            this.tspTitulares.TabIndex = 28;
            this.tspTitulares.Text = "toolStrip1";
            // 
            // tsbNuevoTitular
            // 
            this.tsbNuevoTitular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoTitular.AutoSize = false;
            this.tsbNuevoTitular.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTitularNuevo,
            this.tsmTitularExistente});
            this.tsbNuevoTitular.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoTitular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoTitular.Name = "tsbNuevoTitular";
            this.tsbNuevoTitular.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoTitular.Text = " Nuevo ";
            // 
            // tsmTitularNuevo
            // 
            this.tsmTitularNuevo.Name = "tsmTitularNuevo";
            this.tsmTitularNuevo.Size = new System.Drawing.Size(163, 22);
            this.tsmTitularNuevo.Text = "Titular nuevo";
            this.tsmTitularNuevo.ToolTipText = "Añade un titular nuevo y lo asigna a la explotación";
            // 
            // tsmTitularExistente
            // 
            this.tsmTitularExistente.Name = "tsmTitularExistente";
            this.tsmTitularExistente.Size = new System.Drawing.Size(163, 22);
            this.tsmTitularExistente.Text = "Titular existente";
            this.tsmTitularExistente.ToolTipText = "Asigna a la explotación un Titular existente.";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarTitular
            // 
            this.tsbModificarTitular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarTitular.AutoSize = false;
            this.tsbModificarTitular.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarTitular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarTitular.Name = "tsbModificarTitular";
            this.tsbModificarTitular.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarTitular.Text = " Modificar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarTitular
            // 
            this.tsbEliminarTitular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarTitular.AutoSize = false;
            this.tsbEliminarTitular.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminarTitular,
            this.tsmEliminarRelacion});
            this.tsbEliminarTitular.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarTitular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarTitular.Name = "tsbEliminarTitular";
            this.tsbEliminarTitular.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarTitular.Text = " Eliminar ";
            // 
            // tsmEliminarTitular
            // 
            this.tsmEliminarTitular.Name = "tsmEliminarTitular";
            this.tsmEliminarTitular.Size = new System.Drawing.Size(125, 22);
            this.tsmEliminarTitular.Text = "Titular";
            this.tsmEliminarTitular.ToolTipText = "Borra el titular de la base de datos";
            // 
            // tsmEliminarRelacion
            // 
            this.tsmEliminarRelacion.Name = "tsmEliminarRelacion";
            this.tsmEliminarRelacion.Size = new System.Drawing.Size(125, 22);
            this.tsmEliminarRelacion.Text = "Relación";
            this.tsmEliminarRelacion.ToolTipText = "Elimina la relación entre el titular seleccionado y la Explotación cargada. (No e" +
                "limina el titular de la Base de datos)";
            // 
            // dtgTitulares
            // 
            this.dtgTitulares.AllowUserToAddRows = false;
            this.dtgTitulares.AllowUserToDeleteRows = false;
            this.dtgTitulares.AllowUserToOrderColumns = true;
            this.dtgTitulares.AllowUserToResizeRows = false;
            this.dtgTitulares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTitulares.BackgroundColor = System.Drawing.Color.White;
            this.dtgTitulares.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgTitulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTitulares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.DNI,
            this.Direccion,
            this.Telefono,
            this.FechaAlta});
            this.dtgTitulares.Location = new System.Drawing.Point(6, 6);
            this.dtgTitulares.Name = "dtgTitulares";
            this.dtgTitulares.ReadOnly = true;
            this.dtgTitulares.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgTitulares.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgTitulares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTitulares.ShowCellErrors = false;
            this.dtgTitulares.ShowCellToolTips = false;
            this.dtgTitulares.ShowEditingIcon = false;
            this.dtgTitulares.ShowRowErrors = false;
            this.dtgTitulares.Size = new System.Drawing.Size(590, 217);
            this.dtgTitulares.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre.Width = 69;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Apellidos.Width = 74;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DNI.Width = 51;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Direccion.Width = 77;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Telefono.Width = 74;
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataPropertyName = "FechaAlta";
            this.FechaAlta.HeaderText = "Fecha Alta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            this.FechaAlta.Width = 83;
            // 
            // tbpAnimales
            // 
            this.tbpAnimales.Controls.Add(this.tspAnimales);
            this.tbpAnimales.Controls.Add(this.dtgAnimales);
            this.tbpAnimales.Location = new System.Drawing.Point(4, 22);
            this.tbpAnimales.Name = "tbpAnimales";
            this.tbpAnimales.Size = new System.Drawing.Size(602, 253);
            this.tbpAnimales.TabIndex = 2;
            this.tbpAnimales.Text = "Animales";
            this.tbpAnimales.UseVisualStyleBackColor = true;
            // 
            // tspAnimales
            // 
            this.tspAnimales.Dock = System.Windows.Forms.DockStyle.None;
            this.tspAnimales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoAnimal,
            this.toolStripSeparator4,
            this.tsbModificarAnimal,
            this.toolStripSeparator2,
            this.tsbEliminarAnimal});
            this.tspAnimales.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspAnimales.Location = new System.Drawing.Point(327, 226);
            this.tspAnimales.Name = "tspAnimales";
            this.tspAnimales.Size = new System.Drawing.Size(268, 23);
            this.tspAnimales.TabIndex = 29;
            this.tspAnimales.Text = "toolStrip1";
            // 
            // tsbNuevoAnimal
            // 
            this.tsbNuevoAnimal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoAnimal.AutoSize = false;
            this.tsbNuevoAnimal.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoAnimal.Name = "tsbNuevoAnimal";
            this.tsbNuevoAnimal.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoAnimal.Text = " Nuevo ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarAnimal
            // 
            this.tsbModificarAnimal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarAnimal.AutoSize = false;
            this.tsbModificarAnimal.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarAnimal.Name = "tsbModificarAnimal";
            this.tsbModificarAnimal.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarAnimal.Text = " Modificar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarAnimal
            // 
            this.tsbEliminarAnimal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarAnimal.AutoSize = false;
            this.tsbEliminarAnimal.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarAnimal.Name = "tsbEliminarAnimal";
            this.tsbEliminarAnimal.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarAnimal.Text = " Eliminar ";
            // 
            // dtgAnimales
            // 
            this.dtgAnimales.AllowUserToAddRows = false;
            this.dtgAnimales.AllowUserToDeleteRows = false;
            this.dtgAnimales.AllowUserToOrderColumns = true;
            this.dtgAnimales.AllowUserToResizeRows = false;
            this.dtgAnimales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgAnimales.BackgroundColor = System.Drawing.Color.White;
            this.dtgAnimales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVaca,
            this.Crotal,
            this.NomVaca,
            this.DIB,
            this.Raza,
            this.Historico});
            this.dtgAnimales.Location = new System.Drawing.Point(6, 6);
            this.dtgAnimales.Name = "dtgAnimales";
            this.dtgAnimales.ReadOnly = true;
            this.dtgAnimales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgAnimales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgAnimales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAnimales.ShowCellErrors = false;
            this.dtgAnimales.ShowCellToolTips = false;
            this.dtgAnimales.ShowEditingIcon = false;
            this.dtgAnimales.ShowRowErrors = false;
            this.dtgAnimales.Size = new System.Drawing.Size(590, 217);
            this.dtgAnimales.TabIndex = 20;
            // 
            // IdVaca
            // 
            this.IdVaca.HeaderText = "IdVaca";
            this.IdVaca.Name = "IdVaca";
            this.IdVaca.ReadOnly = true;
            this.IdVaca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdVaca.Visible = false;
            // 
            // Crotal
            // 
            this.Crotal.HeaderText = "Crotal";
            this.Crotal.Name = "Crotal";
            this.Crotal.ReadOnly = true;
            this.Crotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Crotal.Width = 59;
            // 
            // NomVaca
            // 
            this.NomVaca.HeaderText = "Nombre";
            this.NomVaca.Name = "NomVaca";
            this.NomVaca.ReadOnly = true;
            this.NomVaca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NomVaca.Width = 69;
            // 
            // DIB
            // 
            this.DIB.HeaderText = "DIB";
            this.DIB.Name = "DIB";
            this.DIB.ReadOnly = true;
            this.DIB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DIB.Width = 50;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            this.Raza.Width = 57;
            // 
            // Historico
            // 
            this.Historico.HeaderText = "Historico";
            this.Historico.Name = "Historico";
            this.Historico.ReadOnly = true;
            this.Historico.Width = 54;
            // 
            // frmEditGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.tbcContenido);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditGrid";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpTitulares.ResumeLayout(false);
            this.tbpTitulares.PerformLayout();
            this.tspTitulares.ResumeLayout(false);
            this.tspTitulares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTitulares)).EndInit();
            this.tbpAnimales.ResumeLayout(false);
            this.tbpAnimales.PerformLayout();
            this.tspAnimales.ResumeLayout(false);
            this.tspAnimales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAnimales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpTitulares;
        private System.Windows.Forms.ToolStrip tspTitulares;
        private System.Windows.Forms.ToolStripSplitButton tsbNuevoTitular;
        private System.Windows.Forms.ToolStripMenuItem tsmTitularNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmTitularExistente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbModificarTitular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton tsbEliminarTitular;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarTitular;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarRelacion;
        private System.Windows.Forms.DataGridView dtgTitulares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.TabPage tbpAnimales;
        private System.Windows.Forms.ToolStrip tspAnimales;
        private System.Windows.Forms.ToolStripButton tsbNuevoAnimal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarAnimal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarAnimal;
        private System.Windows.Forms.DataGridView dtgAnimales;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomVaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Historico;

    }
}
