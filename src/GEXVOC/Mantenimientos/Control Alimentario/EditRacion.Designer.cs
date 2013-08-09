namespace GEXVOC.UI
{
    partial class EditRacion
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
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpComposicion = new System.Windows.Forms.TabPage();
            this.tspComposicion = new System.Windows.Forms.ToolStrip();
            this.tsbNuevaComposicion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarComposicion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarComposicion = new System.Windows.Forms.ToolStripButton();
            this.dtgComposicion = new System.Windows.Forms.DataGridView();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRacion = new System.Windows.Forms.GroupBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpComposicion.SuspendLayout();
            this.tspComposicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgComposicion)).BeginInit();
            this.grpRacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpComposicion);
            this.tbcContenido.Location = new System.Drawing.Point(14, 119);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(610, 296);
            this.tbcContenido.TabIndex = 1;
            // 
            // tbpComposicion
            // 
            this.tbpComposicion.Controls.Add(this.tspComposicion);
            this.tbpComposicion.Controls.Add(this.dtgComposicion);
            this.tbpComposicion.Location = new System.Drawing.Point(4, 22);
            this.tbpComposicion.Name = "tbpComposicion";
            this.tbpComposicion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComposicion.Size = new System.Drawing.Size(602, 270);
            this.tbpComposicion.TabIndex = 0;
            this.tbpComposicion.Text = "Composición";
            this.tbpComposicion.UseVisualStyleBackColor = true;
            // 
            // tspComposicion
            // 
            this.tspComposicion.Dock = System.Windows.Forms.DockStyle.None;
            this.tspComposicion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevaComposicion,
            this.toolStripSeparator4,
            this.tsbModificarComposicion,
            this.toolStripSeparator2,
            this.tsbEliminarComposicion});
            this.tspComposicion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspComposicion.Location = new System.Drawing.Point(329, 237);
            this.tspComposicion.Name = "tspComposicion";
            this.tspComposicion.Size = new System.Drawing.Size(268, 23);
            this.tspComposicion.TabIndex = 30;
            this.tspComposicion.Text = "toolStrip1";
            // 
            // tsbNuevaComposicion
            // 
            this.tsbNuevaComposicion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevaComposicion.AutoSize = false;
            this.tsbNuevaComposicion.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevaComposicion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevaComposicion.Name = "tsbNuevaComposicion";
            this.tsbNuevaComposicion.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevaComposicion.Text = " Nuevo ";
            this.tsbNuevaComposicion.Click += new System.EventHandler(this.tsbNuevaComposicion_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarComposicion
            // 
            this.tsbModificarComposicion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarComposicion.AutoSize = false;
            this.tsbModificarComposicion.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarComposicion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarComposicion.Name = "tsbModificarComposicion";
            this.tsbModificarComposicion.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarComposicion.Text = " Modificar";
            this.tsbModificarComposicion.Click += new System.EventHandler(this.tsbModificarComposicion_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarComposicion
            // 
            this.tsbEliminarComposicion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarComposicion.AutoSize = false;
            this.tsbEliminarComposicion.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarComposicion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarComposicion.Name = "tsbEliminarComposicion";
            this.tsbEliminarComposicion.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarComposicion.Text = " Eliminar ";
            this.tsbEliminarComposicion.Click += new System.EventHandler(this.tsbEliminarComposicion_Click);
            // 
            // dtgComposicion
            // 
            this.dtgComposicion.AllowUserToAddRows = false;
            this.dtgComposicion.AllowUserToDeleteRows = false;
            this.dtgComposicion.AllowUserToOrderColumns = true;
            this.dtgComposicion.AllowUserToResizeRows = false;
            this.dtgComposicion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgComposicion.BackgroundColor = System.Drawing.Color.White;
            this.dtgComposicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgComposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgComposicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Familia,
            this.Alimento,
            this.Porcentaje});
            this.dtgComposicion.Location = new System.Drawing.Point(6, 5);
            this.dtgComposicion.Name = "dtgComposicion";
            this.dtgComposicion.ReadOnly = true;
            this.dtgComposicion.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgComposicion.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgComposicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgComposicion.ShowCellErrors = false;
            this.dtgComposicion.ShowCellToolTips = false;
            this.dtgComposicion.ShowEditingIcon = false;
            this.dtgComposicion.ShowRowErrors = false;
            this.dtgComposicion.Size = new System.Drawing.Size(590, 229);
            this.dtgComposicion.TabIndex = 15;
            this.dtgComposicion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgComposicion_CellDoubleClick);
            // 
            // Familia
            // 
            this.Familia.DataPropertyName = "DescFamilia";
            this.Familia.HeaderText = "Familia";
            this.Familia.Name = "Familia";
            this.Familia.ReadOnly = true;
            this.Familia.Width = 64;
            // 
            // Alimento
            // 
            this.Alimento.DataPropertyName = "DescAlimento";
            this.Alimento.HeaderText = "Alimento";
            this.Alimento.Name = "Alimento";
            this.Alimento.ReadOnly = true;
            this.Alimento.Width = 72;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            this.Porcentaje.Width = 83;
            // 
            // grpRacion
            // 
            this.grpRacion.Controls.Add(this.lblKg);
            this.grpRacion.Controls.Add(this.txtDescripcion);
            this.grpRacion.Controls.Add(this.lblDescripcion);
            this.grpRacion.Controls.Add(this.txtPeso);
            this.grpRacion.Controls.Add(this.lblPeso);
            this.grpRacion.Location = new System.Drawing.Point(14, 32);
            this.grpRacion.Name = "grpRacion";
            this.grpRacion.Size = new System.Drawing.Size(610, 75);
            this.grpRacion.TabIndex = 0;
            this.grpRacion.TabStop = false;
            this.grpRacion.Text = "Datos de la ración";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKg.Location = new System.Drawing.Point(486, 31);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(25, 13);
            this.lblKg.TabIndex = 5;
            this.lblKg.Text = "Kgs";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(110, 28);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(185, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 31);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(396, 28);
            this.txtPeso.MaxLength = 60;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(84, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPeso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPeso.Location = new System.Drawing.Point(351, 31);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso:";
            // 
            // EditRacion
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 448);
            this.Controls.Add(this.grpRacion);
            this.Controls.Add(this.tbcContenido);
            this.Name = "EditRacion";
            this.Text = "Ración";
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            this.Controls.SetChildIndex(this.grpRacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpComposicion.ResumeLayout(false);
            this.tbpComposicion.PerformLayout();
            this.tspComposicion.ResumeLayout(false);
            this.tspComposicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgComposicion)).EndInit();
            this.grpRacion.ResumeLayout(false);
            this.grpRacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpComposicion;
        private System.Windows.Forms.DataGridView dtgComposicion;
        private System.Windows.Forms.GroupBox grpRacion;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ToolStrip tspComposicion;
        private System.Windows.Forms.ToolStripButton tsbNuevaComposicion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarComposicion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarComposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;

    }
}