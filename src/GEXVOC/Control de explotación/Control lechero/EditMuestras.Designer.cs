namespace GEXVOC.UI
{
    partial class EditMuestras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAnalisis = new System.Windows.Forms.GroupBox();
            this.cmbLaboratorio = new GEXVOC.Core.Controles.ctlCombo();
            this.txtFechaAnalisis = new GEXVOC.Core.Controles.ctlFecha();
            this.tspMuestras = new System.Windows.Forms.ToolStrip();
            this.tsbEliminarMuestra = new System.Windows.Forms.ToolStripButton();
            this.dtgMuestras = new System.Windows.Forms.DataGridView();
            this.IdAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLaboratorio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FechaAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RctoCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proteina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lactosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtractoSeco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtrSecoMagro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtrQuesero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinealPto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Germenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PtoCrioscopico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ionhibidores = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblFechaAnalisis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaControl = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.grpAnalisis.SuspendLayout();
            this.tspMuestras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuestras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAnalisis
            // 
            this.grpAnalisis.Controls.Add(this.cmbLaboratorio);
            this.grpAnalisis.Controls.Add(this.txtFechaAnalisis);
            this.grpAnalisis.Controls.Add(this.tspMuestras);
            this.grpAnalisis.Controls.Add(this.dtgMuestras);
            this.grpAnalisis.Controls.Add(this.lblLaboratorio);
            this.grpAnalisis.Controls.Add(this.lblFechaAnalisis);
            this.grpAnalisis.Location = new System.Drawing.Point(12, 114);
            this.grpAnalisis.Name = "grpAnalisis";
            this.grpAnalisis.Size = new System.Drawing.Size(760, 405);
            this.grpAnalisis.TabIndex = 1;
            this.grpAnalisis.TabStop = false;
            this.grpAnalisis.Text = "Analisis";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLaboratorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbLaboratorio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(109, 25);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(222, 21);
            this.cmbLaboratorio.TabIndex = 2;
            this.cmbLaboratorio.CargarContenido += new System.EventHandler(this.cmbLaboratorio_CargarContenido);
            this.cmbLaboratorio.SelectedValueChanged += new System.EventHandler(this.cmbLaboratorio_SelectedValueChanged);
            this.cmbLaboratorio.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbLaboratorio_CrearNuevo);
            // 
            // txtFechaAnalisis
            // 
            this.txtFechaAnalisis.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaAnalisis.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaAnalisis.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaAnalisis.Location = new System.Drawing.Point(519, 25);
            this.txtFechaAnalisis.Name = "txtFechaAnalisis";
            this.txtFechaAnalisis.ReadOnly = false;
            this.txtFechaAnalisis.Size = new System.Drawing.Size(88, 20);
            this.txtFechaAnalisis.TabIndex = 3;
            this.txtFechaAnalisis.Value = null;
            this.txtFechaAnalisis.ValueChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlFechaEventArgs>(this.txtFechaAnalisis_ValueChanged);
            // 
            // tspMuestras
            // 
            this.tspMuestras.AutoSize = false;
            this.tspMuestras.Dock = System.Windows.Forms.DockStyle.None;
            this.tspMuestras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEliminarMuestra});
            this.tspMuestras.Location = new System.Drawing.Point(639, 372);
            this.tspMuestras.Name = "tspMuestras";
            this.tspMuestras.Size = new System.Drawing.Size(115, 25);
            this.tspMuestras.TabIndex = 5;
            // 
            // tsbEliminarMuestra
            // 
            this.tsbEliminarMuestra.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarMuestra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarMuestra.Name = "tsbEliminarMuestra";
            this.tsbEliminarMuestra.Size = new System.Drawing.Size(101, 22);
            this.tsbEliminarMuestra.Text = "Eliminar Análisis";
            this.tsbEliminarMuestra.Click += new System.EventHandler(this.tsbEliminarMuestra_Click);
            // 
            // dtgMuestras
            // 
            this.dtgMuestras.AllowUserToAddRows = false;
            this.dtgMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMuestras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAnimal,
            this.IdMuestra,
            this.IdControl,
            this.NombreAnimal,
            this.Identificador,
            this.IdLaboratorio,
            this.FechaAnalisis,
            this.RctoCelular,
            this.Grasa,
            this.Urea,
            this.Proteina,
            this.Lactosa,
            this.ExtractoSeco,
            this.ExtrSecoMagro,
            this.ExtrQuesero,
            this.LinealPto,
            this.Germenes,
            this.PtoCrioscopico,
            this.Ionhibidores});
            this.dtgMuestras.Location = new System.Drawing.Point(9, 61);
            this.dtgMuestras.Name = "dtgMuestras";
            this.dtgMuestras.Size = new System.Drawing.Size(745, 308);
            this.dtgMuestras.TabIndex = 4;
            this.dtgMuestras.SelectionChanged += new System.EventHandler(this.dtgMuestras_SelectionChanged);
            // 
            // IdAnimal
            // 
            this.IdAnimal.HeaderText = "IdAnimal";
            this.IdAnimal.MaxInputLength = 20;
            this.IdAnimal.Name = "IdAnimal";
            this.IdAnimal.Visible = false;
            // 
            // IdMuestra
            // 
            this.IdMuestra.HeaderText = "IdMuestra";
            this.IdMuestra.MaxInputLength = 20;
            this.IdMuestra.Name = "IdMuestra";
            this.IdMuestra.Visible = false;
            // 
            // IdControl
            // 
            this.IdControl.HeaderText = "IdControl";
            this.IdControl.MaxInputLength = 20;
            this.IdControl.Name = "IdControl";
            this.IdControl.Visible = false;
            // 
            // NombreAnimal
            // 
            this.NombreAnimal.HeaderText = "Animal";
            this.NombreAnimal.MaxInputLength = 35;
            this.NombreAnimal.Name = "NombreAnimal";
            this.NombreAnimal.Width = 90;
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.MaxInputLength = 35;
            this.Identificador.Name = "Identificador";
            // 
            // IdLaboratorio
            // 
            this.IdLaboratorio.HeaderText = "Laboratorio";
            this.IdLaboratorio.Name = "IdLaboratorio";
            this.IdLaboratorio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdLaboratorio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FechaAnalisis
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaAnalisis.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaAnalisis.HeaderText = "Fecha";
            this.FechaAnalisis.Name = "FechaAnalisis";
            this.FechaAnalisis.Width = 80;
            // 
            // RctoCelular
            // 
            this.RctoCelular.HeaderText = "Rcto.Celular";
            this.RctoCelular.MaxInputLength = 20;
            this.RctoCelular.Name = "RctoCelular";
            this.RctoCelular.Width = 65;
            // 
            // Grasa
            // 
            this.Grasa.HeaderText = "Grasa";
            this.Grasa.MaxInputLength = 20;
            this.Grasa.Name = "Grasa";
            this.Grasa.Width = 50;
            // 
            // Urea
            // 
            this.Urea.HeaderText = "Urea";
            this.Urea.MaxInputLength = 20;
            this.Urea.Name = "Urea";
            this.Urea.Width = 50;
            // 
            // Proteina
            // 
            this.Proteina.HeaderText = "Proteina";
            this.Proteina.MaxInputLength = 20;
            this.Proteina.Name = "Proteina";
            this.Proteina.Width = 50;
            // 
            // Lactosa
            // 
            this.Lactosa.HeaderText = "Lactosa";
            this.Lactosa.MaxInputLength = 20;
            this.Lactosa.Name = "Lactosa";
            this.Lactosa.Width = 50;
            // 
            // ExtractoSeco
            // 
            this.ExtractoSeco.HeaderText = "Extr.Seco";
            this.ExtractoSeco.MaxInputLength = 20;
            this.ExtractoSeco.Name = "ExtractoSeco";
            this.ExtractoSeco.Width = 65;
            // 
            // ExtrSecoMagro
            // 
            this.ExtrSecoMagro.HeaderText = "Extr.Seco Magro";
            this.ExtrSecoMagro.MaxInputLength = 20;
            this.ExtrSecoMagro.Name = "ExtrSecoMagro";
            this.ExtrSecoMagro.Width = 65;
            // 
            // ExtrQuesero
            // 
            this.ExtrQuesero.HeaderText = "Extr.Quesero";
            this.ExtrQuesero.MaxInputLength = 20;
            this.ExtrQuesero.Name = "ExtrQuesero";
            this.ExtrQuesero.Width = 65;
            // 
            // LinealPto
            // 
            this.LinealPto.HeaderText = "Lineal Pto";
            this.LinealPto.MaxInputLength = 20;
            this.LinealPto.Name = "LinealPto";
            this.LinealPto.Width = 60;
            // 
            // Germenes
            // 
            this.Germenes.HeaderText = "Germenes";
            this.Germenes.MaxInputLength = 20;
            this.Germenes.Name = "Germenes";
            this.Germenes.Width = 50;
            // 
            // PtoCrioscopico
            // 
            this.PtoCrioscopico.HeaderText = "Pto.Crioscópico";
            this.PtoCrioscopico.MaxInputLength = 20;
            this.PtoCrioscopico.Name = "PtoCrioscopico";
            this.PtoCrioscopico.Width = 65;
            // 
            // Ionhibidores
            // 
            this.Ionhibidores.HeaderText = "Ionhibidores";
            this.Ionhibidores.Name = "Ionhibidores";
            this.Ionhibidores.Width = 50;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLaboratorio.Location = new System.Drawing.Point(6, 29);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(63, 13);
            this.lblLaboratorio.TabIndex = 7;
            this.lblLaboratorio.Text = "Laboratorio:";
            // 
            // lblFechaAnalisis
            // 
            this.lblFechaAnalisis.AutoSize = true;
            this.lblFechaAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAnalisis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaAnalisis.Location = new System.Drawing.Point(411, 25);
            this.lblFechaAnalisis.Name = "lblFechaAnalisis";
            this.lblFechaAnalisis.Size = new System.Drawing.Size(78, 13);
            this.lblFechaAnalisis.TabIndex = 8;
            this.lblFechaAnalisis.Text = "Fecha Análisis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Fecha Control:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(411, 27);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(56, 13);
            this.lblEspecie.TabIndex = 65;
            this.lblEspecie.Text = "Especie:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(519, 24);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecie.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaControl);
            this.groupBox1.Controls.Add(this.cmbEspecie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblEspecie);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda:";
            // 
            // txtFechaControl
            // 
            this.txtFechaControl.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaControl.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaControl.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaControl.Location = new System.Drawing.Point(109, 24);
            this.txtFechaControl.Name = "txtFechaControl";
            this.txtFechaControl.ReadOnly = false;
            this.txtFechaControl.Size = new System.Drawing.Size(88, 20);
            this.txtFechaControl.TabIndex = 0;
            this.txtFechaControl.Value = null;
            this.txtFechaControl.ValueChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlFechaEventArgs>(this.txtFechaControl_ValueChanged);
            // 
            // EditMuestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BotonBuscarVisible = true;
            this.BotonLimpiarVisible = true;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAnalisis);
            this.Name = "EditMuestras";
            this.Text = "Análisis";
            this.Controls.SetChildIndex(this.grpAnalisis, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.grpAnalisis.ResumeLayout(false);
            this.grpAnalisis.PerformLayout();
            this.tspMuestras.ResumeLayout(false);
            this.tspMuestras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMuestras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAnalisis;
        private System.Windows.Forms.Label lblFechaAnalisis;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgMuestras;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.ToolStrip tspMuestras;
        private System.Windows.Forms.ToolStripButton tsbEliminarMuestra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn RctoCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proteina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lactosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtractoSeco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtrSecoMagro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtrQuesero;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinealPto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Germenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PtoCrioscopico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ionhibidores;
        private GEXVOC.Core.Controles.ctlFecha txtFechaAnalisis;
        private GEXVOC.Core.Controles.ctlFecha txtFechaControl;
        private GEXVOC.Core.Controles.ctlCombo cmbLaboratorio;
    }
}
