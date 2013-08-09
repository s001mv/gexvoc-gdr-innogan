namespace GEXVOC.UI
{
    partial class FindExplotaciones
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
            this.cmbCJuridica = new System.Windows.Forms.ComboBox();
            this.lblJuridica = new System.Windows.Forms.Label();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtCEA = new System.Windows.Forms.TextBox();
            this.lblCea = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SubBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnTitulares = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEspecies = new System.Windows.Forms.ToolStripButton();
            this.btnAnimales = new System.Windows.Forms.ToolStripButton();
            this.btnContactos = new System.Windows.Forms.ToolStripButton();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SubBarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbCJuridica);
            this.pnlBusqueda.Controls.Add(this.lblJuridica);
            this.pnlBusqueda.Controls.Add(this.cmbMunicipio);
            this.pnlBusqueda.Controls.Add(this.lblMunicipio);
            this.pnlBusqueda.Controls.Add(this.cmbProvincia);
            this.pnlBusqueda.Controls.Add(this.lblProvincia);
            this.pnlBusqueda.Controls.Add(this.txtCEA);
            this.pnlBusqueda.Controls.Add(this.lblCea);
            this.pnlBusqueda.Controls.Add(this.txtDireccion);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.txtNombre);
            this.pnlBusqueda.Controls.Add(this.lblNombre);
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 55);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 154);
            // 
            // cmbCJuridica
            // 
            this.cmbCJuridica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCJuridica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCJuridica.FormattingEnabled = true;
            this.cmbCJuridica.Location = new System.Drawing.Point(79, 105);
            this.cmbCJuridica.Name = "cmbCJuridica";
            this.cmbCJuridica.Size = new System.Drawing.Size(213, 21);
            this.cmbCJuridica.TabIndex = 42;
            // 
            // lblJuridica
            // 
            this.lblJuridica.AutoSize = true;
            this.lblJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblJuridica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblJuridica.Location = new System.Drawing.Point(15, 108);
            this.lblJuridica.Name = "lblJuridica";
            this.lblJuridica.Size = new System.Drawing.Size(58, 13);
            this.lblJuridica.TabIndex = 48;
            this.lblJuridica.Text = "C.Jurídica:";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(367, 76);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(214, 21);
            this.cmbMunicipio.TabIndex = 41;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMunicipio.Location = new System.Drawing.Point(306, 79);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 47;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvincia.DisplayMember = "Descripcion";
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(79, 78);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(213, 21);
            this.cmbProvincia.TabIndex = 40;
            this.cmbProvincia.ValueMember = "Id";
            this.cmbProvincia.SelectedValueChanged += new System.EventHandler(this.cmbProvincia_SelectedValueChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProvincia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProvincia.Location = new System.Drawing.Point(15, 81);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 46;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtCEA
            // 
            this.txtCEA.Location = new System.Drawing.Point(79, 26);
            this.txtCEA.MaxLength = 14;
            this.txtCEA.Name = "txtCEA";
            this.txtCEA.Size = new System.Drawing.Size(187, 20);
            this.txtCEA.TabIndex = 37;
            // 
            // lblCea
            // 
            this.lblCea.AutoSize = true;
            this.lblCea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCea.Location = new System.Drawing.Point(15, 29);
            this.lblCea.Name = "lblCea";
            this.lblCea.Size = new System.Drawing.Size(31, 13);
            this.lblCea.TabIndex = 45;
            this.lblCea.Text = "CEA:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(367, 50);
            this.txtDireccion.MaxLength = 150;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(229, 20);
            this.txtDireccion.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(306, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 52);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 38;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(15, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "Nombre:";
            // 
            // SubBarraHerramientas
            // 
            this.SubBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTitulares,
            this.toolStripSeparator2,
            this.btnEspecies,
            this.btnAnimales,
            this.btnContactos});
            this.SubBarraHerramientas.Location = new System.Drawing.Point(0, 25);
            this.SubBarraHerramientas.Name = "SubBarraHerramientas";
            this.SubBarraHerramientas.Size = new System.Drawing.Size(634, 25);
            this.SubBarraHerramientas.TabIndex = 7;
            // 
            // btnTitulares
            // 
            this.btnTitulares.Image = global::GEXVOC.Properties.Resources.info;
            this.btnTitulares.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTitulares.Name = "btnTitulares";
            this.btnTitulares.Size = new System.Drawing.Size(68, 22);
            this.btnTitulares.Text = "Titulares";
            this.btnTitulares.ToolTipText = "Ver Titulares";
            this.btnTitulares.Click += new System.EventHandler(this.botones_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEspecies
            // 
            this.btnEspecies.Image = global::GEXVOC.Properties.Resources.info;
            this.btnEspecies.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEspecies.Name = "btnEspecies";
            this.btnEspecies.Size = new System.Drawing.Size(68, 22);
            this.btnEspecies.Text = "Especies";
            this.btnEspecies.ToolTipText = "Ver Especies de la explotación";
            this.btnEspecies.Click += new System.EventHandler(this.botones_Click);
            // 
            // btnAnimales
            // 
            this.btnAnimales.Image = global::GEXVOC.Properties.Resources.info;
            this.btnAnimales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(69, 22);
            this.btnAnimales.Text = "Animales";
            this.btnAnimales.Click += new System.EventHandler(this.botones_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.Image = global::GEXVOC.Properties.Resources.info;
            this.btnContactos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(76, 22);
            this.btnContactos.Text = "Contactos";
            this.btnContactos.Click += new System.EventHandler(this.botones_Click);
            // 
            // FindExplotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.SubBarraHerramientas);
            this.Name = "FindExplotaciones";
            this.pnlBusquedaPosicion = new System.Drawing.Point(12, 55);
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 154);
            this.Text = "Explotaciones";
            this.TextoEliminar = "Va a proceder a borrar la Explotación seleccionada\r¿Desea continuar y borrar los " +
                "registros?";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.SubBarraHerramientas, 0);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.SubBarraHerramientas.ResumeLayout(false);
            this.SubBarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCJuridica;
        private System.Windows.Forms.Label lblJuridica;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtCEA;
        private System.Windows.Forms.Label lblCea;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStrip SubBarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnTitulares;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEspecies;
        private System.Windows.Forms.ToolStripButton btnAnimales;
        private System.Windows.Forms.ToolStripButton btnContactos;
    }
}
