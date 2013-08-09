namespace GEXVOC.UI
{
    partial class EditInseminacion
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
            this.grpInseminacion = new System.Windows.Forms.GroupBox();
            this.cmbMacho = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cmbPersonal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.pnlEmbrion = new System.Windows.Forms.Panel();
            this.cmbEmbrion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarEmbrion = new System.Windows.Forms.Button();
            this.lblEmbrion = new System.Windows.Forms.Label();
            this.pnlArtificial = new System.Windows.Forms.Panel();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.lblDosis = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.lblVaca = new System.Windows.Forms.Label();
            this.lblToro = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grpInseminacion.SuspendLayout();
            this.pnlEmbrion.SuspendLayout();
            this.pnlArtificial.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInseminacion
            // 
            this.grpInseminacion.Controls.Add(this.cmbMacho);
            this.grpInseminacion.Controls.Add(this.txtFecha);
            this.grpInseminacion.Controls.Add(this.cmbPersonal);
            this.grpInseminacion.Controls.Add(this.cmbHembra);
            this.grpInseminacion.Controls.Add(this.btnBuscarPersonal);
            this.grpInseminacion.Controls.Add(this.btnBuscarHembra);
            this.grpInseminacion.Controls.Add(this.pnlEmbrion);
            this.grpInseminacion.Controls.Add(this.pnlArtificial);
            this.grpInseminacion.Controls.Add(this.lblPersonal);
            this.grpInseminacion.Controls.Add(this.lblVaca);
            this.grpInseminacion.Controls.Add(this.lblToro);
            this.grpInseminacion.Controls.Add(this.lblFecha);
            this.grpInseminacion.Controls.Add(this.lblTipo);
            this.grpInseminacion.Controls.Add(this.cmbTipo);
            this.grpInseminacion.Location = new System.Drawing.Point(12, 38);
            this.grpInseminacion.Name = "grpInseminacion";
            this.grpInseminacion.Size = new System.Drawing.Size(623, 155);
            this.grpInseminacion.TabIndex = 0;
            this.grpInseminacion.TabStop = false;
            this.grpInseminacion.Text = "Datos de la inseminación";
            // 
            // cmbMacho
            // 
            this.cmbMacho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMacho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMacho.FormattingEnabled = true;
            this.cmbMacho.Location = new System.Drawing.Point(372, 88);
            this.cmbMacho.Name = "cmbMacho";
            this.cmbMacho.Size = new System.Drawing.Size(232, 21);
            this.cmbMacho.TabIndex = 4;
            // 
            // txtFecha
            // 
            this.txtFecha.HidePromptOnLeave = true;
            this.txtFecha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFecha.Location = new System.Drawing.Point(372, 114);
            this.txtFecha.Mask = "00/00/0099";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPersonal.btnBusqueda = this.btnBuscarPersonal;
            this.cmbPersonal.ClaseActiva = null;
            this.cmbPersonal.ControlVisible = true;
            this.cmbPersonal.DisplayMember = "Nombre";
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.IdClaseActiva = 0;
            this.cmbPersonal.Location = new System.Drawing.Point(100, 112);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.PermitirEliminar = true;
            this.cmbPersonal.PermitirLimpiar = true;
            this.cmbPersonal.ReadOnly = false;
            this.cmbPersonal.Size = new System.Drawing.Size(168, 21);
            this.cmbPersonal.TabIndex = 5;
            this.cmbPersonal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPersonal.TipoDatos = null;
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPersonal.Location = new System.Drawing.Point(278, 112);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPersonal.TabIndex = 6;
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // cmbHembra
            // 
            this.cmbHembra.BackColor = System.Drawing.SystemColors.Control;
            this.cmbHembra.btnBusqueda = this.btnBuscarHembra;
            this.cmbHembra.ClaseActiva = null;
            this.cmbHembra.ControlVisible = true;
            this.cmbHembra.DisplayMember = "Nombre";
            this.cmbHembra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbHembra.FormattingEnabled = true;
            this.cmbHembra.IdClaseActiva = 0;
            this.cmbHembra.Location = new System.Drawing.Point(100, 87);
            this.cmbHembra.Name = "cmbHembra";
            this.cmbHembra.PermitirEliminar = true;
            this.cmbHembra.PermitirLimpiar = true;
            this.cmbHembra.ReadOnly = false;
            this.cmbHembra.Size = new System.Drawing.Size(168, 21);
            this.cmbHembra.TabIndex = 2;
            this.cmbHembra.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbHembra.TipoDatos = null;
            // 
            // btnBuscarHembra
            // 
            this.btnBuscarHembra.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarHembra.Location = new System.Drawing.Point(278, 87);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 3;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.btnBuscarHembra_Click);
            // 
            // pnlEmbrion
            // 
            this.pnlEmbrion.Controls.Add(this.cmbEmbrion);
            this.pnlEmbrion.Controls.Add(this.btnBuscarEmbrion);
            this.pnlEmbrion.Controls.Add(this.lblEmbrion);
            this.pnlEmbrion.Enabled = false;
            this.pnlEmbrion.Location = new System.Drawing.Point(14, 55);
            this.pnlEmbrion.Name = "pnlEmbrion";
            this.pnlEmbrion.Size = new System.Drawing.Size(288, 26);
            this.pnlEmbrion.TabIndex = 1;
            // 
            // cmbEmbrion
            // 
            this.cmbEmbrion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEmbrion.btnBusqueda = this.btnBuscarEmbrion;
            this.cmbEmbrion.ClaseActiva = null;
            this.cmbEmbrion.ControlVisible = true;
            this.cmbEmbrion.DisplayMember = "Nombre";
            this.cmbEmbrion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbEmbrion.FormattingEnabled = true;
            this.cmbEmbrion.IdClaseActiva = 0;
            this.cmbEmbrion.Location = new System.Drawing.Point(86, 2);
            this.cmbEmbrion.Name = "cmbEmbrion";
            this.cmbEmbrion.PermitirEliminar = true;
            this.cmbEmbrion.PermitirLimpiar = true;
            this.cmbEmbrion.ReadOnly = false;
            this.cmbEmbrion.Size = new System.Drawing.Size(168, 21);
            this.cmbEmbrion.TabIndex = 0;
            this.cmbEmbrion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbEmbrion.TipoDatos = null;
            // 
            // btnBuscarEmbrion
            // 
            this.btnBuscarEmbrion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarEmbrion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarEmbrion.Location = new System.Drawing.Point(264, 3);
            this.btnBuscarEmbrion.Name = "btnBuscarEmbrion";
            this.btnBuscarEmbrion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarEmbrion.TabIndex = 1;
            this.btnBuscarEmbrion.UseVisualStyleBackColor = true;
            this.btnBuscarEmbrion.Click += new System.EventHandler(this.btnBuscarEmbrion_Click);
            // 
            // lblEmbrion
            // 
            this.lblEmbrion.AutoSize = true;
            this.lblEmbrion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEmbrion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmbrion.Location = new System.Drawing.Point(-1, 6);
            this.lblEmbrion.Name = "lblEmbrion";
            this.lblEmbrion.Size = new System.Drawing.Size(48, 13);
            this.lblEmbrion.TabIndex = 132;
            this.lblEmbrion.Text = "Embrion:";
            // 
            // pnlArtificial
            // 
            this.pnlArtificial.Controls.Add(this.txtDosis);
            this.pnlArtificial.Controls.Add(this.lblDosis);
            this.pnlArtificial.Enabled = false;
            this.pnlArtificial.Location = new System.Drawing.Point(303, 54);
            this.pnlArtificial.Name = "pnlArtificial";
            this.pnlArtificial.Size = new System.Drawing.Size(186, 26);
            this.pnlArtificial.TabIndex = 2;
            // 
            // txtDosis
            // 
            this.txtDosis.Location = new System.Drawing.Point(69, 3);
            this.txtDosis.MaxLength = 35;
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(48, 20);
            this.txtDosis.TabIndex = 0;
            // 
            // lblDosis
            // 
            this.lblDosis.AutoSize = true;
            this.lblDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDosis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDosis.Location = new System.Drawing.Point(5, 6);
            this.lblDosis.Name = "lblDosis";
            this.lblDosis.Size = new System.Drawing.Size(58, 13);
            this.lblDosis.TabIndex = 132;
            this.lblDosis.Text = "Nº dosis:";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPersonal.Location = new System.Drawing.Point(13, 117);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(60, 13);
            this.lblPersonal.TabIndex = 136;
            this.lblPersonal.Text = "Personal:";
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaca.Location = new System.Drawing.Point(13, 91);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(54, 13);
            this.lblVaca.TabIndex = 126;
            this.lblVaca.Text = "Hembra:";
            // 
            // lblToro
            // 
            this.lblToro.AutoSize = true;
            this.lblToro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblToro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblToro.Location = new System.Drawing.Point(307, 90);
            this.lblToro.Name = "lblToro";
            this.lblToro.Size = new System.Drawing.Size(49, 13);
            this.lblToro.TabIndex = 127;
            this.lblToro.Text = "Macho:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(308, 116);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 129;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(13, 31);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 13);
            this.lblTipo.TabIndex = 128;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(100, 28);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(193, 21);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // EditInseminacion
            // 
            this.AccionDespuesInsertar = GEXVOC.UI.GenericEdit.AccionesDespuesInsertar.Preguntar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(647, 230);
            this.Controls.Add(this.grpInseminacion);
            this.Name = "EditInseminacion";
            this.Text = "Inseminación";
            this.Controls.SetChildIndex(this.grpInseminacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grpInseminacion.ResumeLayout(false);
            this.grpInseminacion.PerformLayout();
            this.pnlEmbrion.ResumeLayout(false);
            this.pnlEmbrion.PerformLayout();
            this.pnlArtificial.ResumeLayout(false);
            this.pnlArtificial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInseminacion;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.Panel pnlEmbrion;
        private System.Windows.Forms.Button btnBuscarEmbrion;
        private System.Windows.Forms.Label lblEmbrion;
        private System.Windows.Forms.Panel pnlArtificial;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.Label lblDosis;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Label lblVaca;
        private System.Windows.Forms.Label lblToro;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbEmbrion;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbPersonal;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbMacho;
    }
}
