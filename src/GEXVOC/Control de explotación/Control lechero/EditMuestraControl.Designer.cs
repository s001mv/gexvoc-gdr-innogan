namespace GEXVOC.UI
{
    partial class EditMuestraControl
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
            this.dtgControles = new System.Windows.Forms.DataGridView();
            this.idAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdStatusControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrdeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtManana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNoche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFechaControl = new System.Windows.Forms.Label();
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.tsbControles = new System.Windows.Forms.ToolStrip();
            this.tsbEliminarControl = new System.Windows.Forms.ToolStripButton();
            this.lblEstadoOrdeno = new System.Windows.Forms.Label();
            this.lblStatusControl = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.txtFechaControl = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbStatusControl = new GEXVOC.Core.Controles.ctlCombo();
            this.cmbStatusOrdeno = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControles)).BeginInit();
            this.grpControles.SuspendLayout();
            this.tsbControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgControles
            // 
            this.dtgControles.AllowUserToAddRows = false;
            this.dtgControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgControles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnimal,
            this.idControl,
            this.IdStatusControl,
            this.IdOrdeno,
            this.NombreAnimal,
            this.Identificador,
            this.NControl,
            this.txtManana,
            this.txtTarde,
            this.txtNoche});
            this.dtgControles.Location = new System.Drawing.Point(5, 19);
            this.dtgControles.Name = "dtgControles";
            this.dtgControles.Size = new System.Drawing.Size(625, 308);
            this.dtgControles.TabIndex = 0;
            this.dtgControles.SelectionChanged += new System.EventHandler(this.dtgControles_SelectionChanged);
            // 
            // idAnimal
            // 
            this.idAnimal.HeaderText = "idAnimal";
            this.idAnimal.MaxInputLength = 30;
            this.idAnimal.Name = "idAnimal";
            this.idAnimal.ReadOnly = true;
            this.idAnimal.Visible = false;
            // 
            // idControl
            // 
            this.idControl.HeaderText = "idControl";
            this.idControl.MaxInputLength = 30;
            this.idControl.Name = "idControl";
            this.idControl.Visible = false;
            // 
            // IdStatusControl
            // 
            this.IdStatusControl.HeaderText = "IdStatusControl";
            this.IdStatusControl.MaxInputLength = 30;
            this.IdStatusControl.Name = "IdStatusControl";
            this.IdStatusControl.Visible = false;
            // 
            // IdOrdeno
            // 
            this.IdOrdeno.HeaderText = "IdOrdeno";
            this.IdOrdeno.MaxInputLength = 30;
            this.IdOrdeno.Name = "IdOrdeno";
            this.IdOrdeno.Visible = false;
            // 
            // NombreAnimal
            // 
            this.NombreAnimal.HeaderText = "Animal";
            this.NombreAnimal.MaxInputLength = 35;
            this.NombreAnimal.Name = "NombreAnimal";
            this.NombreAnimal.ReadOnly = true;
            this.NombreAnimal.Width = 75;
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.MaxInputLength = 35;
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // NControl
            // 
            this.NControl.HeaderText = "NºControl";
            this.NControl.MaxInputLength = 35;
            this.NControl.Name = "NControl";
            this.NControl.ReadOnly = true;
            this.NControl.Width = 60;
            // 
            // txtManana
            // 
            this.txtManana.HeaderText = "Mañana";
            this.txtManana.MaxInputLength = 20;
            this.txtManana.Name = "txtManana";
            this.txtManana.Width = 50;
            // 
            // txtTarde
            // 
            this.txtTarde.HeaderText = "Tarde";
            this.txtTarde.MaxInputLength = 20;
            this.txtTarde.Name = "txtTarde";
            this.txtTarde.Width = 50;
            // 
            // txtNoche
            // 
            this.txtNoche.HeaderText = "Noche";
            this.txtNoche.MaxInputLength = 20;
            this.txtNoche.Name = "txtNoche";
            this.txtNoche.Width = 50;
            // 
            // lblFechaControl
            // 
            this.lblFechaControl.AutoSize = true;
            this.lblFechaControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaControl.Location = new System.Drawing.Point(14, 43);
            this.lblFechaControl.Name = "lblFechaControl";
            this.lblFechaControl.Size = new System.Drawing.Size(89, 13);
            this.lblFechaControl.TabIndex = 58;
            this.lblFechaControl.Text = "Fecha control:";
            // 
            // grpControles
            // 
            this.grpControles.AutoSize = true;
            this.grpControles.Controls.Add(this.tsbControles);
            this.grpControles.Controls.Add(this.dtgControles);
            this.grpControles.Location = new System.Drawing.Point(12, 95);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(636, 370);
            this.grpControles.TabIndex = 4;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Controles";
            // 
            // tsbControles
            // 
            this.tsbControles.AutoSize = false;
            this.tsbControles.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbControles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEliminarControl});
            this.tsbControles.Location = new System.Drawing.Point(510, 329);
            this.tsbControles.Name = "tsbControles";
            this.tsbControles.Size = new System.Drawing.Size(120, 25);
            this.tsbControles.TabIndex = 1;
            // 
            // tsbEliminarControl
            // 
            this.tsbEliminarControl.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarControl.Name = "tsbEliminarControl";
            this.tsbEliminarControl.Size = new System.Drawing.Size(101, 22);
            this.tsbEliminarControl.Text = "Eliminar Control";
            this.tsbEliminarControl.Click += new System.EventHandler(this.tsbEliminarControl_Click);
            // 
            // lblEstadoOrdeno
            // 
            this.lblEstadoOrdeno.AutoSize = true;
            this.lblEstadoOrdeno.Location = new System.Drawing.Point(339, 71);
            this.lblEstadoOrdeno.Name = "lblEstadoOrdeno";
            this.lblEstadoOrdeno.Size = new System.Drawing.Size(81, 13);
            this.lblEstadoOrdeno.TabIndex = 61;
            this.lblEstadoOrdeno.Text = "Estado Ordeño:";
            // 
            // lblStatusControl
            // 
            this.lblStatusControl.AutoSize = true;
            this.lblStatusControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusControl.Location = new System.Drawing.Point(13, 71);
            this.lblStatusControl.Name = "lblStatusControl";
            this.lblStatusControl.Size = new System.Drawing.Size(94, 13);
            this.lblStatusControl.TabIndex = 63;
            this.lblStatusControl.Text = "Estado Control:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(213, 43);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(56, 13);
            this.lblEspecie.TabIndex = 64;
            this.lblEspecie.Text = "Especie:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(275, 40);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecie.TabIndex = 1;
            // 
            // txtFechaControl
            // 
            this.txtFechaControl.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaControl.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaControl.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaControl.Location = new System.Drawing.Point(108, 42);
            this.txtFechaControl.Name = "txtFechaControl";
            this.txtFechaControl.ReadOnly = false;
            this.txtFechaControl.Size = new System.Drawing.Size(88, 20);
            this.txtFechaControl.TabIndex = 0;
            this.txtFechaControl.Value = null;
            // 
            // cmbStatusControl
            // 
            this.cmbStatusControl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusControl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatusControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbStatusControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbStatusControl.FormattingEnabled = true;
            this.cmbStatusControl.Location = new System.Drawing.Point(108, 68);
            this.cmbStatusControl.Name = "cmbStatusControl";
            this.cmbStatusControl.Size = new System.Drawing.Size(225, 21);
            this.cmbStatusControl.TabIndex = 2;
            this.cmbStatusControl.CargarContenido += new System.EventHandler(this.cmbStatusControl_CargarContenido);
            this.cmbStatusControl.SelectedValueChanged += new System.EventHandler(this.cmbStatusControl_SelectedValueChanged);
            this.cmbStatusControl.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbStatusControl_CrearNuevo);
            // 
            // cmbStatusOrdeno
            // 
            this.cmbStatusOrdeno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusOrdeno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatusOrdeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbStatusOrdeno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbStatusOrdeno.FormattingEnabled = true;
            this.cmbStatusOrdeno.Location = new System.Drawing.Point(419, 68);
            this.cmbStatusOrdeno.Name = "cmbStatusOrdeno";
            this.cmbStatusOrdeno.Size = new System.Drawing.Size(225, 21);
            this.cmbStatusOrdeno.TabIndex = 3;
            this.cmbStatusOrdeno.CargarContenido += new System.EventHandler(this.cmbStatusOrdeno_CargarContenido);
            this.cmbStatusOrdeno.SelectedValueChanged += new System.EventHandler(this.cmbStatusOrdeno_SelectedValueChanged);
            this.cmbStatusOrdeno.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbStatusOrdeno_CrearNuevo);
            // 
            // EditMuestraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BotonBuscarVisible = true;
            this.BotonLimpiarVisible = true;
            this.ClientSize = new System.Drawing.Size(656, 496);
            this.Controls.Add(this.cmbStatusOrdeno);
            this.Controls.Add(this.cmbStatusControl);
            this.Controls.Add(this.txtFechaControl);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblStatusControl);
            this.Controls.Add(this.lblEstadoOrdeno);
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.lblFechaControl);
            this.Name = "EditMuestraControl";
            this.Text = "Controles";
            this.Controls.SetChildIndex(this.lblFechaControl, 0);
            this.Controls.SetChildIndex(this.grpControles, 0);
            this.Controls.SetChildIndex(this.lblEstadoOrdeno, 0);
            this.Controls.SetChildIndex(this.lblStatusControl, 0);
            this.Controls.SetChildIndex(this.lblEspecie, 0);
            this.Controls.SetChildIndex(this.cmbEspecie, 0);
            this.Controls.SetChildIndex(this.txtFechaControl, 0);
            this.Controls.SetChildIndex(this.cmbStatusControl, 0);
            this.Controls.SetChildIndex(this.cmbStatusOrdeno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControles)).EndInit();
            this.grpControles.ResumeLayout(false);
            this.tsbControles.ResumeLayout(false);
            this.tsbControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgControles;
        private System.Windows.Forms.Label lblFechaControl;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Label lblEstadoOrdeno;
        private System.Windows.Forms.Label lblStatusControl;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.ToolStrip tsbControles;
        private System.Windows.Forms.ToolStripButton tsbEliminarControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStatusControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrdeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtManana;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNoche;
        private GEXVOC.Core.Controles.ctlFecha txtFechaControl;
        private GEXVOC.Core.Controles.ctlCombo cmbStatusControl;
        private GEXVOC.Core.Controles.ctlCombo cmbStatusOrdeno;

    }
}
