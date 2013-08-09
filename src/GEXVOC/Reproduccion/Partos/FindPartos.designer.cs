namespace GEXVOC.UI
{
    partial class FindPartos
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
            this.lblFecInicio2 = new System.Windows.Forms.Label();
            this.lblFecInicio = new System.Windows.Forms.Label();
            this.lblVaca = new System.Windows.Forms.Label();
            this.cmbDificultad = new System.Windows.Forms.ComboBox();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVivos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMuertos = new System.Windows.Forms.TextBox();
            this.txtFecIniMayor = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFecIniMenor = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecIniMenor);
            this.pnlBusqueda.Controls.Add(this.txtFecIniMayor);
            this.pnlBusqueda.Controls.Add(this.txtMuertos);
            this.pnlBusqueda.Controls.Add(this.label2);
            this.pnlBusqueda.Controls.Add(this.txtVivos);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.btnBuscarHembra);
            this.pnlBusqueda.Controls.Add(this.cmbHembra);
            this.pnlBusqueda.Controls.Add(this.lblFecInicio2);
            this.pnlBusqueda.Controls.Add(this.lblFecInicio);
            this.pnlBusqueda.Controls.Add(this.lblVaca);
            this.pnlBusqueda.Controls.Add(this.cmbDificultad);
            this.pnlBusqueda.Controls.Add(this.lblDificultad);
            this.pnlBusqueda.Controls.Add(this.cmbTipo);
            this.pnlBusqueda.Controls.Add(this.lblTipo);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 124);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 161);
            this.panel1.Size = new System.Drawing.Size(610, 257);
            // 
            // lblFecInicio2
            // 
            this.lblFecInicio2.AutoSize = true;
            this.lblFecInicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecInicio2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio2.Location = new System.Drawing.Point(336, 94);
            this.lblFecInicio2.Name = "lblFecInicio2";
            this.lblFecInicio2.Size = new System.Drawing.Size(36, 13);
            this.lblFecInicio2.TabIndex = 129;
            this.lblFecInicio2.Text = "hasta:";
            // 
            // lblFecInicio
            // 
            this.lblFecInicio.AutoSize = true;
            this.lblFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio.Location = new System.Drawing.Point(21, 94);
            this.lblFecInicio.Name = "lblFecInicio";
            this.lblFecInicio.Size = new System.Drawing.Size(85, 13);
            this.lblFecInicio.TabIndex = 128;
            this.lblFecInicio.Text = "F. Parto (desde):";
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaca.Location = new System.Drawing.Point(21, 63);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(47, 13);
            this.lblVaca.TabIndex = 126;
            this.lblVaca.Text = "Hembra:";
            // 
            // cmbDificultad
            // 
            this.cmbDificultad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDificultad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDificultad.FormattingEnabled = true;
            this.cmbDificultad.Location = new System.Drawing.Point(396, 28);
            this.cmbDificultad.Name = "cmbDificultad";
            this.cmbDificultad.Size = new System.Drawing.Size(193, 21);
            this.cmbDificultad.TabIndex = 1;
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDificultad.Location = new System.Drawing.Point(336, 32);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(54, 13);
            this.lblDificultad.TabIndex = 123;
            this.lblDificultad.Text = "Dificultad:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(112, 28);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(193, 21);
            this.cmbTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(21, 32);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 122;
            this.lblTipo.Text = "Tipo:";
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
            this.cmbHembra.Location = new System.Drawing.Point(112, 60);
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
            this.btnBuscarHembra.Location = new System.Drawing.Point(284, 60);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 3;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.btnBuscarHembra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Vivos:";
            // 
            // txtVivos
            // 
            this.txtVivos.Location = new System.Drawing.Point(396, 60);
            this.txtVivos.Name = "txtVivos";
            this.txtVivos.Size = new System.Drawing.Size(45, 20);
            this.txtVivos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Muertos:";
            // 
            // txtMuertos
            // 
            this.txtMuertos.Location = new System.Drawing.Point(537, 60);
            this.txtMuertos.Name = "txtMuertos";
            this.txtMuertos.Size = new System.Drawing.Size(52, 20);
            this.txtMuertos.TabIndex = 4;
            // 
            // txtFecIniMayor
            // 
            this.txtFecIniMayor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecIniMayor.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecIniMayor.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecIniMayor.Location = new System.Drawing.Point(112, 91);
            this.txtFecIniMayor.Name = "txtFecIniMayor";
            this.txtFecIniMayor.ReadOnly = false;
            this.txtFecIniMayor.Size = new System.Drawing.Size(88, 20);
            this.txtFecIniMayor.TabIndex = 5;
            this.txtFecIniMayor.Value = null;
            // 
            // txtFecIniMenor
            // 
            this.txtFecIniMenor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecIniMenor.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecIniMenor.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecIniMenor.Location = new System.Drawing.Point(396, 94);
            this.txtFecIniMenor.Name = "txtFecIniMenor";
            this.txtFecIniMenor.ReadOnly = false;
            this.txtFecIniMenor.Size = new System.Drawing.Size(88, 20);
            this.txtFecIniMenor.TabIndex = 6;
            this.txtFecIniMenor.Value = null;
            // 
            // FindPartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 257);
            this.Name = "FindPartos";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 124);
            this.Text = "Partos";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecInicio2;
        private System.Windows.Forms.Label lblFecInicio;
        private System.Windows.Forms.Label lblVaca;
        private System.Windows.Forms.ComboBox cmbDificultad;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.TextBox txtMuertos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVivos;
        private System.Windows.Forms.Label label1;
        private GEXVOC.Core.Controles.ctlFecha txtFecIniMenor;
        private GEXVOC.Core.Controles.ctlFecha txtFecIniMayor;
    }
}
