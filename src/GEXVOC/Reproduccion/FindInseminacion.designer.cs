namespace GEXVOC.UI
{
    partial class FindInseminacion
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnBuscarMacho = new System.Windows.Forms.Button();
            this.lblToro = new System.Windows.Forms.Label();
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.lblVaca = new System.Windows.Forms.Label();
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.cmbMacho = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecha);
            this.pnlBusqueda.Controls.Add(this.cmbMacho);
            this.pnlBusqueda.Controls.Add(this.cmbHembra);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.cmbTipo);
            this.pnlBusqueda.Controls.Add(this.lblTipo);
            this.pnlBusqueda.Controls.Add(this.btnBuscarMacho);
            this.pnlBusqueda.Controls.Add(this.lblToro);
            this.pnlBusqueda.Controls.Add(this.btnBuscarHembra);
            this.pnlBusqueda.Controls.Add(this.lblVaca);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 117);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 154);
            this.panel1.Size = new System.Drawing.Size(610, 264);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(28, 81);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 144;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(85, 25);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(193, 21);
            this.cmbTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(28, 28);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 143;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnBuscarMacho
            // 
            this.btnBuscarMacho.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarMacho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarMacho.Location = new System.Drawing.Point(553, 50);
            this.btnBuscarMacho.Name = "btnBuscarMacho";
            this.btnBuscarMacho.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarMacho.TabIndex = 4;
            this.btnBuscarMacho.UseVisualStyleBackColor = true;
            this.btnBuscarMacho.Click += new System.EventHandler(this.btnBuscarMacho_Click);
            // 
            // lblToro
            // 
            this.lblToro.AutoSize = true;
            this.lblToro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblToro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblToro.Location = new System.Drawing.Point(324, 55);
            this.lblToro.Name = "lblToro";
            this.lblToro.Size = new System.Drawing.Size(43, 13);
            this.lblToro.TabIndex = 142;
            this.lblToro.Text = "Macho:";
            // 
            // btnBuscarHembra
            // 
            this.btnBuscarHembra.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarHembra.Location = new System.Drawing.Point(257, 51);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 2;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.btnBuscarHembra_Click);
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaca.Location = new System.Drawing.Point(28, 55);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(47, 13);
            this.lblVaca.TabIndex = 141;
            this.lblVaca.Text = "Hembra:";
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
            this.cmbHembra.Location = new System.Drawing.Point(85, 50);
            this.cmbHembra.Name = "cmbHembra";
            this.cmbHembra.PermitirEliminar = true;
            this.cmbHembra.PermitirLimpiar = true;
            this.cmbHembra.ReadOnly = false;
            this.cmbHembra.Size = new System.Drawing.Size(168, 21);
            this.cmbHembra.TabIndex = 1;
            this.cmbHembra.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbHembra.TipoDatos = null;
            // 
            // cmbMacho
            // 
            this.cmbMacho.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMacho.btnBusqueda = this.btnBuscarMacho;
            this.cmbMacho.ClaseActiva = null;
            this.cmbMacho.ControlVisible = true;
            this.cmbMacho.DisplayMember = "Nombre";
            this.cmbMacho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMacho.FormattingEnabled = true;
            this.cmbMacho.IdClaseActiva = 0;
            this.cmbMacho.Location = new System.Drawing.Point(381, 50);
            this.cmbMacho.Name = "cmbMacho";
            this.cmbMacho.PermitirEliminar = true;
            this.cmbMacho.PermitirLimpiar = true;
            this.cmbMacho.ReadOnly = false;
            this.cmbMacho.Size = new System.Drawing.Size(168, 21);
            this.cmbMacho.TabIndex = 3;
            this.cmbMacho.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbMacho.TipoDatos = null;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(85, 77);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.Value = null;
            // 
            // FindInseminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 264);
            this.Name = "FindInseminacion";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 117);
            this.Text = "Inseminaciones";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnBuscarMacho;
        private System.Windows.Forms.Label lblToro;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.Label lblVaca;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbMacho;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
