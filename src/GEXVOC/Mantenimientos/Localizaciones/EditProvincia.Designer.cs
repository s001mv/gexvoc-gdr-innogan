namespace GEXVOC.UI
{
    partial class EditProvincia
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpMunicipios = new System.Windows.Forms.TabPage();
            this.tspMunicipios = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoMunicipio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarMunicipio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarMunicipio = new System.Windows.Forms.ToolStripButton();
            this.dtgMunicipio = new System.Windows.Forms.DataGridView();
            this.dgcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpMunicipios.SuspendLayout();
            this.tspMunicipios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMunicipio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 39);
            this.txtCodigo.MaxLength = 2;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(61, 20);
            this.txtCodigo.TabIndex = 12;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodigo.Location = new System.Drawing.Point(11, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(250, 39);
            this.txtDescripcion.MaxLength = 80;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(166, 42);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpMunicipios);
            this.tbcContenido.Location = new System.Drawing.Point(12, 76);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(610, 296);
            this.tbcContenido.TabIndex = 16;
            // 
            // tbpMunicipios
            // 
            this.tbpMunicipios.Controls.Add(this.tspMunicipios);
            this.tbpMunicipios.Controls.Add(this.dtgMunicipio);
            this.tbpMunicipios.Location = new System.Drawing.Point(4, 22);
            this.tbpMunicipios.Name = "tbpMunicipios";
            this.tbpMunicipios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMunicipios.Size = new System.Drawing.Size(602, 270);
            this.tbpMunicipios.TabIndex = 0;
            this.tbpMunicipios.Text = "Municipios";
            this.tbpMunicipios.UseVisualStyleBackColor = true;
            // 
            // tspMunicipios
            // 
            this.tspMunicipios.Dock = System.Windows.Forms.DockStyle.None;
            this.tspMunicipios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoMunicipio,
            this.toolStripSeparator4,
            this.tsbModificarMunicipio,
            this.toolStripSeparator2,
            this.tsbEliminarMunicipio});
            this.tspMunicipios.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tspMunicipios.Location = new System.Drawing.Point(329, 237);
            this.tspMunicipios.Name = "tspMunicipios";
            this.tspMunicipios.Size = new System.Drawing.Size(268, 23);
            this.tspMunicipios.TabIndex = 30;
            this.tspMunicipios.Text = "toolStrip1";
            // 
            // tsbNuevoMunicipio
            // 
            this.tsbNuevoMunicipio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNuevoMunicipio.AutoSize = false;
            this.tsbNuevoMunicipio.Image = global::GEXVOC.Properties.Resources.nuevo;
            this.tsbNuevoMunicipio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoMunicipio.Name = "tsbNuevoMunicipio";
            this.tsbNuevoMunicipio.Size = new System.Drawing.Size(85, 20);
            this.tsbNuevoMunicipio.Text = " Nuevo ";
            this.tsbNuevoMunicipio.Click += new System.EventHandler(this.tsbNuevoMunicipio_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbModificarMunicipio
            // 
            this.tsbModificarMunicipio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificarMunicipio.AutoSize = false;
            this.tsbModificarMunicipio.Image = global::GEXVOC.Properties.Resources.modificar;
            this.tsbModificarMunicipio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarMunicipio.Name = "tsbModificarMunicipio";
            this.tsbModificarMunicipio.Size = new System.Drawing.Size(85, 20);
            this.tsbModificarMunicipio.Text = " Modificar";
            this.tsbModificarMunicipio.Click += new System.EventHandler(this.tsbModificarMunicipio_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbEliminarMunicipio
            // 
            this.tsbEliminarMunicipio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminarMunicipio.AutoSize = false;
            this.tsbEliminarMunicipio.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarMunicipio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarMunicipio.Name = "tsbEliminarMunicipio";
            this.tsbEliminarMunicipio.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarMunicipio.Text = " Eliminar ";
            this.tsbEliminarMunicipio.Click += new System.EventHandler(this.tsbEliminarMunicipio_Click);
            // 
            // dtgMunicipio
            // 
            this.dtgMunicipio.AllowUserToAddRows = false;
            this.dtgMunicipio.AllowUserToDeleteRows = false;
            this.dtgMunicipio.AllowUserToOrderColumns = true;
            this.dtgMunicipio.AllowUserToResizeRows = false;
            this.dtgMunicipio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgMunicipio.BackgroundColor = System.Drawing.Color.White;
            this.dtgMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgMunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMunicipio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcCodigo,
            this.dgcDescripcion});
            this.dtgMunicipio.Location = new System.Drawing.Point(6, 5);
            this.dtgMunicipio.Name = "dtgMunicipio";
            this.dtgMunicipio.ReadOnly = true;
            this.dtgMunicipio.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgMunicipio.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgMunicipio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMunicipio.ShowCellErrors = false;
            this.dtgMunicipio.ShowCellToolTips = false;
            this.dtgMunicipio.ShowEditingIcon = false;
            this.dtgMunicipio.ShowRowErrors = false;
            this.dtgMunicipio.Size = new System.Drawing.Size(590, 229);
            this.dtgMunicipio.TabIndex = 15;
            this.dtgMunicipio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMunicipio_CellDoubleClick);
            // 
            // dgcCodigo
            // 
            this.dgcCodigo.DataPropertyName = "Codigo";
            this.dgcCodigo.HeaderText = "Código";
            this.dgcCodigo.Name = "dgcCodigo";
            this.dgcCodigo.ReadOnly = true;
            this.dgcCodigo.Width = 65;
            // 
            // dgcDescripcion
            // 
            this.dgcDescripcion.DataPropertyName = "Descripcion";
            this.dgcDescripcion.HeaderText = "Descripción";
            this.dgcDescripcion.Name = "dgcDescripcion";
            this.dgcDescripcion.ReadOnly = true;
            this.dgcDescripcion.Width = 88;
            // 
            // EditProvincia
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(639, 399);
            this.Controls.Add(this.tbcContenido);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "EditProvincia";
            this.Text = "Provincia";
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpMunicipios.ResumeLayout(false);
            this.tbpMunicipios.PerformLayout();
            this.tspMunicipios.ResumeLayout(false);
            this.tspMunicipios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMunicipio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpMunicipios;
        private System.Windows.Forms.ToolStrip tspMunicipios;
        private System.Windows.Forms.ToolStripButton tsbNuevoMunicipio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbModificarMunicipio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminarMunicipio;
        private System.Windows.Forms.DataGridView dtgMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescripcion;
    }
}
