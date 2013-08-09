namespace GEXVOC.UI
{
    partial class EditControlesMuestras
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.grpDesplazamiento = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.cmbStatusOrdeno = new System.Windows.Forms.ComboBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtNoche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManhana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatusOrdeno = new System.Windows.Forms.Label();
            this.lblStatusControl = new System.Windows.Forms.Label();
            this.cmbStatusControl = new System.Windows.Forms.ComboBox();
            this.grpActividad = new System.Windows.Forms.GroupBox();
            this.rdbAnalisis = new System.Windows.Forms.RadioButton();
            this.rdbControlesAnalisis = new System.Windows.Forms.RadioButton();
            this.rdbControles = new System.Windows.Forms.RadioButton();
            this.grpAnalisis = new System.Windows.Forms.GroupBox();
            this.cmbLaboratorio = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.pnlAnalisis = new System.Windows.Forms.Panel();
            this.txtLinealPto = new System.Windows.Forms.TextBox();
            this.lblLinealPto = new System.Windows.Forms.Label();
            this.txtExtractoSeco = new System.Windows.Forms.TextBox();
            this.lblExtractoSeco = new System.Windows.Forms.Label();
            this.txtLactosa = new System.Windows.Forms.TextBox();
            this.lblLactosa = new System.Windows.Forms.Label();
            this.txtProteina = new System.Windows.Forms.TextBox();
            this.lblProteina = new System.Windows.Forms.Label();
            this.txtUrea = new System.Windows.Forms.TextBox();
            this.lblUrea = new System.Windows.Forms.Label();
            this.txtGrasa = new System.Windows.Forms.TextBox();
            this.lblGrasa = new System.Windows.Forms.Label();
            this.txtRctoCelular = new System.Windows.Forms.TextBox();
            this.lblRctoCelular = new System.Windows.Forms.Label();
            this.txtFechaAnalisis = new System.Windows.Forms.TextBox();
            this.lblFechaAnalisis = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.btnBuscarLaboratorio = new System.Windows.Forms.Button();
            this.dtgControlesMuestras = new System.Windows.Forms.DataGridView();
            this.IdVaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomVaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecheManhana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecheTarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecheNoche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RctoCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proteina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lactosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtractoSeco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinealPto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filtros = new System.Windows.Forms.GroupBox();
            this.cmbExplotacion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.txtFechaControles = new System.Windows.Forms.TextBox();
            this.lblFechaControles = new System.Windows.Forms.Label();
            this.btnBuscarExplotacion = new System.Windows.Forms.Button();
            this.lblExplotacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.grpDesplazamiento.SuspendLayout();
            this.grpControles.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.grpActividad.SuspendLayout();
            this.grpAnalisis.SuspendLayout();
            this.pnlAnalisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControlesMuestras)).BeginInit();
            this.Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.grpDesplazamiento);
            this.pnlDatos.Controls.Add(this.grpControles);
            this.pnlDatos.Controls.Add(this.grpActividad);
            this.pnlDatos.Controls.Add(this.grpAnalisis);
            this.pnlDatos.Location = new System.Drawing.Point(10, 314);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(616, 277);
            this.pnlDatos.TabIndex = 10;
            // 
            // grpDesplazamiento
            // 
            this.grpDesplazamiento.Controls.Add(this.btnSiguiente);
            this.grpDesplazamiento.Controls.Add(this.btnAnterior);
            this.grpDesplazamiento.Location = new System.Drawing.Point(311, 3);
            this.grpDesplazamiento.Name = "grpDesplazamiento";
            this.grpDesplazamiento.Size = new System.Drawing.Size(301, 58);
            this.grpDesplazamiento.TabIndex = 6;
            this.grpDesplazamiento.TabStop = false;
            this.grpDesplazamiento.Text = "Desplazamiento por registros";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Image = global::GEXVOC.Properties.Resources.siguiente;
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSiguiente.Location = new System.Drawing.Point(209, 20);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(77, 23);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Image = global::GEXVOC.Properties.Resources.anterior;
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnterior.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnterior.Location = new System.Drawing.Point(126, 20);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(77, 23);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.cmbStatusOrdeno);
            this.grpControles.Controls.Add(this.pnlControl);
            this.grpControles.Controls.Add(this.lblStatusOrdeno);
            this.grpControles.Controls.Add(this.lblStatusControl);
            this.grpControles.Controls.Add(this.cmbStatusControl);
            this.grpControles.Location = new System.Drawing.Point(3, 64);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(303, 208);
            this.grpControles.TabIndex = 4;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Control";
            // 
            // cmbStatusOrdeno
            // 
            this.cmbStatusOrdeno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusOrdeno.FormattingEnabled = true;
            this.cmbStatusOrdeno.Location = new System.Drawing.Point(111, 18);
            this.cmbStatusOrdeno.Name = "cmbStatusOrdeno";
            this.cmbStatusOrdeno.Size = new System.Drawing.Size(175, 21);
            this.cmbStatusOrdeno.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtNoche);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.txtTarde);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.txtManhana);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Location = new System.Drawing.Point(6, 87);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(162, 90);
            this.pnlControl.TabIndex = 4;
            // 
            // txtNoche
            // 
            this.txtNoche.Location = new System.Drawing.Point(103, 61);
            this.txtNoche.MaxLength = 20;
            this.txtNoche.Name = "txtNoche";
            this.txtNoche.Size = new System.Drawing.Size(49, 20);
            this.txtNoche.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Leche Noche:";
            // 
            // txtTarde
            // 
            this.txtTarde.Location = new System.Drawing.Point(103, 35);
            this.txtTarde.MaxLength = 20;
            this.txtTarde.Name = "txtTarde";
            this.txtTarde.Size = new System.Drawing.Size(49, 20);
            this.txtTarde.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leche Tarde:";
            // 
            // txtManhana
            // 
            this.txtManhana.Location = new System.Drawing.Point(103, 9);
            this.txtManhana.MaxLength = 20;
            this.txtManhana.Name = "txtManhana";
            this.txtManhana.Size = new System.Drawing.Size(49, 20);
            this.txtManhana.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leche Mañana:";
            // 
            // lblStatusOrdeno
            // 
            this.lblStatusOrdeno.AutoSize = true;
            this.lblStatusOrdeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblStatusOrdeno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatusOrdeno.Location = new System.Drawing.Point(12, 21);
            this.lblStatusOrdeno.Name = "lblStatusOrdeno";
            this.lblStatusOrdeno.Size = new System.Drawing.Size(79, 13);
            this.lblStatusOrdeno.TabIndex = 0;
            this.lblStatusOrdeno.Text = "Estado ordeño:";
            // 
            // lblStatusControl
            // 
            this.lblStatusControl.AutoSize = true;
            this.lblStatusControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatusControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatusControl.Location = new System.Drawing.Point(12, 48);
            this.lblStatusControl.Name = "lblStatusControl";
            this.lblStatusControl.Size = new System.Drawing.Size(93, 13);
            this.lblStatusControl.TabIndex = 2;
            this.lblStatusControl.Text = "Estado control:";
            // 
            // cmbStatusControl
            // 
            this.cmbStatusControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusControl.FormattingEnabled = true;
            this.cmbStatusControl.Location = new System.Drawing.Point(111, 45);
            this.cmbStatusControl.Name = "cmbStatusControl";
            this.cmbStatusControl.Size = new System.Drawing.Size(175, 21);
            this.cmbStatusControl.TabIndex = 3;
            // 
            // grpActividad
            // 
            this.grpActividad.Controls.Add(this.rdbAnalisis);
            this.grpActividad.Controls.Add(this.rdbControlesAnalisis);
            this.grpActividad.Controls.Add(this.rdbControles);
            this.grpActividad.Location = new System.Drawing.Point(3, 3);
            this.grpActividad.Name = "grpActividad";
            this.grpActividad.Size = new System.Drawing.Size(303, 58);
            this.grpActividad.TabIndex = 3;
            this.grpActividad.TabStop = false;
            this.grpActividad.Text = "Tarea";
            // 
            // rdbAnalisis
            // 
            this.rdbAnalisis.AutoSize = true;
            this.rdbAnalisis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbAnalisis.Location = new System.Drawing.Point(98, 20);
            this.rdbAnalisis.Name = "rdbAnalisis";
            this.rdbAnalisis.Size = new System.Drawing.Size(60, 17);
            this.rdbAnalisis.TabIndex = 6;
            this.rdbAnalisis.Text = "Análisis";
            this.rdbAnalisis.UseVisualStyleBackColor = true;
            this.rdbAnalisis.CheckedChanged += new System.EventHandler(this.rdbAnalisis_CheckedChanged);
            // 
            // rdbControlesAnalisis
            // 
            this.rdbControlesAnalisis.AutoSize = true;
            this.rdbControlesAnalisis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbControlesAnalisis.Location = new System.Drawing.Point(164, 20);
            this.rdbControlesAnalisis.Name = "rdbControlesAnalisis";
            this.rdbControlesAnalisis.Size = new System.Drawing.Size(114, 17);
            this.rdbControlesAnalisis.TabIndex = 7;
            this.rdbControlesAnalisis.Text = "Controles y análisis";
            this.rdbControlesAnalisis.UseVisualStyleBackColor = true;
            this.rdbControlesAnalisis.CheckedChanged += new System.EventHandler(this.rdbControlesAnalisis_CheckedChanged);
            // 
            // rdbControles
            // 
            this.rdbControles.AutoSize = true;
            this.rdbControles.Checked = true;
            this.rdbControles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbControles.Location = new System.Drawing.Point(23, 20);
            this.rdbControles.Name = "rdbControles";
            this.rdbControles.Size = new System.Drawing.Size(69, 17);
            this.rdbControles.TabIndex = 5;
            this.rdbControles.TabStop = true;
            this.rdbControles.Text = "Controles";
            this.rdbControles.UseVisualStyleBackColor = true;
            this.rdbControles.CheckedChanged += new System.EventHandler(this.rdbControles_CheckedChanged);
            // 
            // grpAnalisis
            // 
            this.grpAnalisis.Controls.Add(this.cmbLaboratorio);
            this.grpAnalisis.Controls.Add(this.pnlAnalisis);
            this.grpAnalisis.Controls.Add(this.txtFechaAnalisis);
            this.grpAnalisis.Controls.Add(this.lblFechaAnalisis);
            this.grpAnalisis.Controls.Add(this.lblLaboratorio);
            this.grpAnalisis.Controls.Add(this.btnBuscarLaboratorio);
            this.grpAnalisis.Enabled = false;
            this.grpAnalisis.Location = new System.Drawing.Point(311, 64);
            this.grpAnalisis.Name = "grpAnalisis";
            this.grpAnalisis.Size = new System.Drawing.Size(301, 208);
            this.grpAnalisis.TabIndex = 5;
            this.grpAnalisis.TabStop = false;
            this.grpAnalisis.Text = "Análisis";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.BackColor = System.Drawing.SystemColors.Control;
            this.cmbLaboratorio.btnBusqueda = this.btnBuscarLaboratorio;
            this.cmbLaboratorio.ClaseActiva = null;
            this.cmbLaboratorio.DisplayMember = "Nombre";
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(91, 17);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.PermitirEliminar = true;
            this.cmbLaboratorio.ReadOnly = false;
            this.cmbLaboratorio.Size = new System.Drawing.Size(168, 21);
            this.cmbLaboratorio.TabIndex = 55;
            this.cmbLaboratorio.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            // 
            // pnlAnalisis
            // 
            this.pnlAnalisis.Controls.Add(this.txtLinealPto);
            this.pnlAnalisis.Controls.Add(this.lblLinealPto);
            this.pnlAnalisis.Controls.Add(this.txtExtractoSeco);
            this.pnlAnalisis.Controls.Add(this.lblExtractoSeco);
            this.pnlAnalisis.Controls.Add(this.txtLactosa);
            this.pnlAnalisis.Controls.Add(this.lblLactosa);
            this.pnlAnalisis.Controls.Add(this.txtProteina);
            this.pnlAnalisis.Controls.Add(this.lblProteina);
            this.pnlAnalisis.Controls.Add(this.txtUrea);
            this.pnlAnalisis.Controls.Add(this.lblUrea);
            this.pnlAnalisis.Controls.Add(this.txtGrasa);
            this.pnlAnalisis.Controls.Add(this.lblGrasa);
            this.pnlAnalisis.Controls.Add(this.txtRctoCelular);
            this.pnlAnalisis.Controls.Add(this.lblRctoCelular);
            this.pnlAnalisis.Location = new System.Drawing.Point(6, 87);
            this.pnlAnalisis.Name = "pnlAnalisis";
            this.pnlAnalisis.Size = new System.Drawing.Size(289, 114);
            this.pnlAnalisis.TabIndex = 5;
            // 
            // txtLinealPto
            // 
            this.txtLinealPto.Location = new System.Drawing.Point(233, 61);
            this.txtLinealPto.Name = "txtLinealPto";
            this.txtLinealPto.Size = new System.Drawing.Size(47, 20);
            this.txtLinealPto.TabIndex = 13;
            // 
            // lblLinealPto
            // 
            this.lblLinealPto.AutoSize = true;
            this.lblLinealPto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLinealPto.Location = new System.Drawing.Point(155, 64);
            this.lblLinealPto.Name = "lblLinealPto";
            this.lblLinealPto.Size = new System.Drawing.Size(56, 13);
            this.lblLinealPto.TabIndex = 12;
            this.lblLinealPto.Text = "Lineal pto:";
            // 
            // txtExtractoSeco
            // 
            this.txtExtractoSeco.Location = new System.Drawing.Point(233, 35);
            this.txtExtractoSeco.Name = "txtExtractoSeco";
            this.txtExtractoSeco.Size = new System.Drawing.Size(47, 20);
            this.txtExtractoSeco.TabIndex = 11;
            // 
            // lblExtractoSeco
            // 
            this.lblExtractoSeco.AutoSize = true;
            this.lblExtractoSeco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExtractoSeco.Location = new System.Drawing.Point(155, 38);
            this.lblExtractoSeco.Name = "lblExtractoSeco";
            this.lblExtractoSeco.Size = new System.Drawing.Size(75, 13);
            this.lblExtractoSeco.TabIndex = 10;
            this.lblExtractoSeco.Text = "Extracto seco:";
            // 
            // txtLactosa
            // 
            this.txtLactosa.Location = new System.Drawing.Point(233, 9);
            this.txtLactosa.Name = "txtLactosa";
            this.txtLactosa.Size = new System.Drawing.Size(47, 20);
            this.txtLactosa.TabIndex = 9;
            // 
            // lblLactosa
            // 
            this.lblLactosa.AutoSize = true;
            this.lblLactosa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLactosa.Location = new System.Drawing.Point(155, 12);
            this.lblLactosa.Name = "lblLactosa";
            this.lblLactosa.Size = new System.Drawing.Size(48, 13);
            this.lblLactosa.TabIndex = 8;
            this.lblLactosa.Text = "Lactosa:";
            // 
            // txtProteina
            // 
            this.txtProteina.Location = new System.Drawing.Point(101, 87);
            this.txtProteina.Name = "txtProteina";
            this.txtProteina.Size = new System.Drawing.Size(47, 20);
            this.txtProteina.TabIndex = 7;
            // 
            // lblProteina
            // 
            this.lblProteina.AutoSize = true;
            this.lblProteina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProteina.Location = new System.Drawing.Point(6, 90);
            this.lblProteina.Name = "lblProteina";
            this.lblProteina.Size = new System.Drawing.Size(49, 13);
            this.lblProteina.TabIndex = 6;
            this.lblProteina.Text = "Proteina:";
            // 
            // txtUrea
            // 
            this.txtUrea.Location = new System.Drawing.Point(101, 61);
            this.txtUrea.Name = "txtUrea";
            this.txtUrea.Size = new System.Drawing.Size(47, 20);
            this.txtUrea.TabIndex = 5;
            // 
            // lblUrea
            // 
            this.lblUrea.AutoSize = true;
            this.lblUrea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUrea.Location = new System.Drawing.Point(6, 64);
            this.lblUrea.Name = "lblUrea";
            this.lblUrea.Size = new System.Drawing.Size(33, 13);
            this.lblUrea.TabIndex = 4;
            this.lblUrea.Text = "Urea:";
            // 
            // txtGrasa
            // 
            this.txtGrasa.Location = new System.Drawing.Point(101, 35);
            this.txtGrasa.Name = "txtGrasa";
            this.txtGrasa.Size = new System.Drawing.Size(47, 20);
            this.txtGrasa.TabIndex = 3;
            // 
            // lblGrasa
            // 
            this.lblGrasa.AutoSize = true;
            this.lblGrasa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGrasa.Location = new System.Drawing.Point(6, 38);
            this.lblGrasa.Name = "lblGrasa";
            this.lblGrasa.Size = new System.Drawing.Size(38, 13);
            this.lblGrasa.TabIndex = 2;
            this.lblGrasa.Text = "Grasa:";
            // 
            // txtRctoCelular
            // 
            this.txtRctoCelular.Location = new System.Drawing.Point(101, 9);
            this.txtRctoCelular.Name = "txtRctoCelular";
            this.txtRctoCelular.Size = new System.Drawing.Size(47, 20);
            this.txtRctoCelular.TabIndex = 1;
            // 
            // lblRctoCelular
            // 
            this.lblRctoCelular.AutoSize = true;
            this.lblRctoCelular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRctoCelular.Location = new System.Drawing.Point(6, 12);
            this.lblRctoCelular.Name = "lblRctoCelular";
            this.lblRctoCelular.Size = new System.Drawing.Size(70, 13);
            this.lblRctoCelular.TabIndex = 0;
            this.lblRctoCelular.Text = "Rcto. celular:";
            // 
            // txtFechaAnalisis
            // 
            this.txtFechaAnalisis.Location = new System.Drawing.Point(107, 45);
            this.txtFechaAnalisis.MaxLength = 10;
            this.txtFechaAnalisis.Name = "txtFechaAnalisis";
            this.txtFechaAnalisis.Size = new System.Drawing.Size(79, 20);
            this.txtFechaAnalisis.TabIndex = 4;
            // 
            // lblFechaAnalisis
            // 
            this.lblFechaAnalisis.AutoSize = true;
            this.lblFechaAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaAnalisis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaAnalisis.Location = new System.Drawing.Point(12, 48);
            this.lblFechaAnalisis.Name = "lblFechaAnalisis";
            this.lblFechaAnalisis.Size = new System.Drawing.Size(46, 13);
            this.lblFechaAnalisis.TabIndex = 3;
            this.lblFechaAnalisis.Text = "Fecha:";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLaboratorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLaboratorio.Location = new System.Drawing.Point(12, 22);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(75, 13);
            this.lblLaboratorio.TabIndex = 0;
            this.lblLaboratorio.Text = "Laboratorio:";
            // 
            // btnBuscarLaboratorio
            // 
            this.btnBuscarLaboratorio.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarLaboratorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarLaboratorio.Location = new System.Drawing.Point(265, 17);
            this.btnBuscarLaboratorio.Name = "btnBuscarLaboratorio";
            this.btnBuscarLaboratorio.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarLaboratorio.TabIndex = 2;
            this.btnBuscarLaboratorio.UseVisualStyleBackColor = true;
            // 
            // dtgControlesMuestras
            // 
            this.dtgControlesMuestras.AllowUserToAddRows = false;
            this.dtgControlesMuestras.AllowUserToDeleteRows = false;
            this.dtgControlesMuestras.AllowUserToOrderColumns = true;
            this.dtgControlesMuestras.AllowUserToResizeRows = false;
            this.dtgControlesMuestras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgControlesMuestras.BackgroundColor = System.Drawing.Color.White;
            this.dtgControlesMuestras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgControlesMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgControlesMuestras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVaca,
            this.IdControl,
            this.IdMuestra,
            this.Crotal,
            this.NomVaca,
            this.NControl,
            this.LecheManhana,
            this.LecheTarde,
            this.LecheNoche,
            this.RctoCelular,
            this.Grasa,
            this.Urea,
            this.Proteina,
            this.Lactosa,
            this.ExtractoSeco,
            this.LinealPto});
            this.dtgControlesMuestras.Enabled = false;
            this.dtgControlesMuestras.Location = new System.Drawing.Point(12, 97);
            this.dtgControlesMuestras.MultiSelect = false;
            this.dtgControlesMuestras.Name = "dtgControlesMuestras";
            this.dtgControlesMuestras.ReadOnly = true;
            this.dtgControlesMuestras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgControlesMuestras.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgControlesMuestras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgControlesMuestras.ShowCellErrors = false;
            this.dtgControlesMuestras.ShowCellToolTips = false;
            this.dtgControlesMuestras.ShowEditingIcon = false;
            this.dtgControlesMuestras.ShowRowErrors = false;
            this.dtgControlesMuestras.Size = new System.Drawing.Size(610, 210);
            this.dtgControlesMuestras.StandardTab = true;
            this.dtgControlesMuestras.TabIndex = 8;
            // 
            // IdVaca
            // 
            this.IdVaca.HeaderText = "IdVaca";
            this.IdVaca.Name = "IdVaca";
            this.IdVaca.ReadOnly = true;
            this.IdVaca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdVaca.Visible = false;
            this.IdVaca.Width = 47;
            // 
            // IdControl
            // 
            this.IdControl.HeaderText = "IdControl";
            this.IdControl.Name = "IdControl";
            this.IdControl.ReadOnly = true;
            this.IdControl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdControl.Visible = false;
            this.IdControl.Width = 55;
            // 
            // IdMuestra
            // 
            this.IdMuestra.HeaderText = "IdMuestra";
            this.IdMuestra.Name = "IdMuestra";
            this.IdMuestra.ReadOnly = true;
            this.IdMuestra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdMuestra.Visible = false;
            this.IdMuestra.Width = 60;
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
            this.NomVaca.HeaderText = "Hembra";
            this.NomVaca.Name = "NomVaca";
            this.NomVaca.ReadOnly = true;
            this.NomVaca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NomVaca.Width = 69;
            // 
            // NControl
            // 
            this.NControl.HeaderText = "NºControl";
            this.NControl.Name = "NControl";
            this.NControl.ReadOnly = true;
            this.NControl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NControl.Width = 77;
            // 
            // LecheManhana
            // 
            this.LecheManhana.HeaderText = "Mañana";
            this.LecheManhana.Name = "LecheManhana";
            this.LecheManhana.ReadOnly = true;
            this.LecheManhana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LecheManhana.Width = 52;
            // 
            // LecheTarde
            // 
            this.LecheTarde.HeaderText = "Tarde";
            this.LecheTarde.Name = "LecheTarde";
            this.LecheTarde.ReadOnly = true;
            this.LecheTarde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LecheTarde.Width = 41;
            // 
            // LecheNoche
            // 
            this.LecheNoche.HeaderText = "Noche";
            this.LecheNoche.Name = "LecheNoche";
            this.LecheNoche.ReadOnly = true;
            this.LecheNoche.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LecheNoche.Width = 45;
            // 
            // RctoCelular
            // 
            this.RctoCelular.HeaderText = "R.Celular";
            this.RctoCelular.Name = "RctoCelular";
            this.RctoCelular.ReadOnly = true;
            this.RctoCelular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RctoCelular.Width = 56;
            // 
            // Grasa
            // 
            this.Grasa.HeaderText = "Grasa";
            this.Grasa.Name = "Grasa";
            this.Grasa.ReadOnly = true;
            this.Grasa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Grasa.Width = 41;
            // 
            // Urea
            // 
            this.Urea.HeaderText = "Urea";
            this.Urea.Name = "Urea";
            this.Urea.ReadOnly = true;
            this.Urea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Urea.Width = 36;
            // 
            // Proteina
            // 
            this.Proteina.HeaderText = "Proteina";
            this.Proteina.Name = "Proteina";
            this.Proteina.ReadOnly = true;
            this.Proteina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Proteina.Width = 52;
            // 
            // Lactosa
            // 
            this.Lactosa.HeaderText = "Lactosa";
            this.Lactosa.Name = "Lactosa";
            this.Lactosa.ReadOnly = true;
            this.Lactosa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lactosa.Width = 51;
            // 
            // ExtractoSeco
            // 
            this.ExtractoSeco.HeaderText = "E.Seco";
            this.ExtractoSeco.Name = "ExtractoSeco";
            this.ExtractoSeco.ReadOnly = true;
            this.ExtractoSeco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExtractoSeco.Width = 48;
            // 
            // LinealPto
            // 
            this.LinealPto.HeaderText = "LinealPto";
            this.LinealPto.Name = "LinealPto";
            this.LinealPto.ReadOnly = true;
            this.LinealPto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LinealPto.Width = 57;
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.cmbExplotacion);
            this.Filtros.Controls.Add(this.txtFechaControles);
            this.Filtros.Controls.Add(this.lblFechaControles);
            this.Filtros.Controls.Add(this.btnBuscarExplotacion);
            this.Filtros.Controls.Add(this.lblExplotacion);
            this.Filtros.Location = new System.Drawing.Point(12, 34);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(610, 55);
            this.Filtros.TabIndex = 11;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Búsqueda";
            // 
            // cmbExplotacion
            // 
            this.cmbExplotacion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbExplotacion.btnBusqueda = this.btnBuscarExplotacion;
            this.cmbExplotacion.ClaseActiva = null;
            this.cmbExplotacion.DisplayMember = "Nombre";
            this.cmbExplotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbExplotacion.FormattingEnabled = true;
            this.cmbExplotacion.Location = new System.Drawing.Point(91, 18);
            this.cmbExplotacion.Name = "cmbExplotacion";
            this.cmbExplotacion.PermitirEliminar = true;
            this.cmbExplotacion.ReadOnly = false;
            this.cmbExplotacion.Size = new System.Drawing.Size(168, 21);
            this.cmbExplotacion.TabIndex = 122;
            this.cmbExplotacion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            // 
            // txtFechaControles
            // 
            this.txtFechaControles.Location = new System.Drawing.Point(416, 18);
            this.txtFechaControles.MaxLength = 10;
            this.txtFechaControles.Name = "txtFechaControles";
            this.txtFechaControles.Size = new System.Drawing.Size(79, 20);
            this.txtFechaControles.TabIndex = 3;
            // 
            // lblFechaControles
            // 
            this.lblFechaControles.AutoSize = true;
            this.lblFechaControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaControles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaControles.Location = new System.Drawing.Point(321, 22);
            this.lblFechaControles.Name = "lblFechaControles";
            this.lblFechaControles.Size = new System.Drawing.Size(89, 13);
            this.lblFechaControles.TabIndex = 121;
            this.lblFechaControles.Text = "Fecha control:";
            // 
            // btnBuscarExplotacion
            // 
            this.btnBuscarExplotacion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarExplotacion.Location = new System.Drawing.Point(265, 18);
            this.btnBuscarExplotacion.Name = "btnBuscarExplotacion";
            this.btnBuscarExplotacion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarExplotacion.TabIndex = 2;
            this.btnBuscarExplotacion.UseVisualStyleBackColor = true;
            this.btnBuscarExplotacion.Click += new System.EventHandler(this.btnBuscarExplotacion_Click);
            // 
            // lblExplotacion
            // 
            this.lblExplotacion.AutoSize = true;
            this.lblExplotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExplotacion.Location = new System.Drawing.Point(12, 22);
            this.lblExplotacion.Name = "lblExplotacion";
            this.lblExplotacion.Size = new System.Drawing.Size(77, 13);
            this.lblExplotacion.TabIndex = 46;
            this.lblExplotacion.Text = "Explotación:";
            // 
            // EditControlesMuestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BotonBuscarVisible = true;
            this.ClientSize = new System.Drawing.Size(634, 619);
            this.Controls.Add(this.Filtros);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.dtgControlesMuestras);
            this.Name = "EditControlesMuestras";
            this.Text = "Controles y Analisis";
            this.Controls.SetChildIndex(this.dtgControlesMuestras, 0);
            this.Controls.SetChildIndex(this.pnlDatos, 0);
            this.Controls.SetChildIndex(this.Filtros, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.grpDesplazamiento.ResumeLayout(false);
            this.grpControles.ResumeLayout(false);
            this.grpControles.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.grpActividad.ResumeLayout(false);
            this.grpActividad.PerformLayout();
            this.grpAnalisis.ResumeLayout(false);
            this.grpAnalisis.PerformLayout();
            this.pnlAnalisis.ResumeLayout(false);
            this.pnlAnalisis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControlesMuestras)).EndInit();
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.GroupBox grpDesplazamiento;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.ComboBox cmbStatusOrdeno;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TextBox txtNoche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTarde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManhana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusOrdeno;
        private System.Windows.Forms.Label lblStatusControl;
        private System.Windows.Forms.ComboBox cmbStatusControl;
        private System.Windows.Forms.GroupBox grpActividad;
        private System.Windows.Forms.RadioButton rdbAnalisis;
        private System.Windows.Forms.RadioButton rdbControlesAnalisis;
        private System.Windows.Forms.RadioButton rdbControles;
        private System.Windows.Forms.GroupBox grpAnalisis;
        private System.Windows.Forms.Panel pnlAnalisis;
        private System.Windows.Forms.TextBox txtLinealPto;
        private System.Windows.Forms.Label lblLinealPto;
        private System.Windows.Forms.TextBox txtExtractoSeco;
        private System.Windows.Forms.Label lblExtractoSeco;
        private System.Windows.Forms.TextBox txtLactosa;
        private System.Windows.Forms.Label lblLactosa;
        private System.Windows.Forms.TextBox txtProteina;
        private System.Windows.Forms.Label lblProteina;
        private System.Windows.Forms.TextBox txtUrea;
        private System.Windows.Forms.Label lblUrea;
        private System.Windows.Forms.TextBox txtGrasa;
        private System.Windows.Forms.Label lblGrasa;
        private System.Windows.Forms.TextBox txtRctoCelular;
        private System.Windows.Forms.Label lblRctoCelular;
        private System.Windows.Forms.TextBox txtFechaAnalisis;
        private System.Windows.Forms.Label lblFechaAnalisis;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Button btnBuscarLaboratorio;
        private System.Windows.Forms.DataGridView dtgControlesMuestras;
        private System.Windows.Forms.GroupBox Filtros;
        private System.Windows.Forms.TextBox txtFechaControles;
        private System.Windows.Forms.Label lblFechaControles;
        private System.Windows.Forms.Button btnBuscarExplotacion;
        private System.Windows.Forms.Label lblExplotacion;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbExplotacion;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomVaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecheManhana;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecheTarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecheNoche;
        private System.Windows.Forms.DataGridViewTextBoxColumn RctoCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proteina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lactosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtractoSeco;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinealPto;
        
    }
}
