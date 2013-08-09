namespace GEXVOC.UI
{
    partial class Asistente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistente));
            this.wzdAsistente = new GEXVOC.Core.Controles.Asistente.Wizard();
            this.Explotacion = new GEXVOC.Core.Controles.Asistente.WizardPage();
            this.cmbMunicipio = new GEXVOC.Core.Controles.ctlCombo();
            this.cmbProvincia = new GEXVOC.Core.Controles.ctlCombo();
            this.cmbCJuridica = new GEXVOC.Core.Controles.ctlCombo();
            this.lblCLechero = new System.Windows.Forms.Label();
            this.txtCLechero = new System.Windows.Forms.TextBox();
            this.txtFecBaja = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFecAlta = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFecBaja = new System.Windows.Forms.Label();
            this.lblFecAlta = new System.Windows.Forms.Label();
            this.lblExplotacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtCea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblCea = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblJuridica = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.hdrExplotacion = new GEXVOC.Core.Controles.Asistente.Header();
            this.Introduccion = new GEXVOC.Core.Controles.Asistente.WizardPage();
            this.Intro = new GEXVOC.Core.Controles.Asistente.InfoPage();
            this.Cierre = new GEXVOC.Core.Controles.Asistente.WizardPage();
            this.Fin = new GEXVOC.Core.Controles.Asistente.InfoPage();
            this.Titulares = new GEXVOC.Core.Controles.Asistente.WizardPage();
            this.dtgTitulares = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspTitulares = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoTitular = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmTitularNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTitularExistente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificarTitular = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEliminarTitular = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmEliminarRelacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminarTitular = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulares = new System.Windows.Forms.Label();
            this.hdrTitulares = new GEXVOC.Core.Controles.Asistente.Header();
            this.Modulos = new GEXVOC.Core.Controles.Asistente.WizardPage();
            this.trvModulos = new System.Windows.Forms.TreeView();
            this.lblModulos = new System.Windows.Forms.Label();
            this.hdrModulos = new GEXVOC.Core.Controles.Asistente.Header();
            this.Especies = new GEXVOC.Core.Controles.Asistente.WizardPage();
            this.trvEspecies = new System.Windows.Forms.TreeView();
            this.lblEspecies = new System.Windows.Forms.Label();
            this.hdrEspecies = new GEXVOC.Core.Controles.Asistente.Header();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.wzdAsistente.SuspendLayout();
            this.Explotacion.SuspendLayout();
            this.Introduccion.SuspendLayout();
            this.Cierre.SuspendLayout();
            this.Titulares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTitulares)).BeginInit();
            this.tspTitulares.SuspendLayout();
            this.Modulos.SuspendLayout();
            this.Especies.SuspendLayout();
            this.SuspendLayout();
            // 
            // wzdAsistente
            // 
            this.wzdAsistente.Controls.Add(this.Cierre);
            this.wzdAsistente.Controls.Add(this.Titulares);
            this.wzdAsistente.Controls.Add(this.Modulos);
            this.wzdAsistente.Controls.Add(this.Especies);
            this.wzdAsistente.Controls.Add(this.Explotacion);
            this.wzdAsistente.Controls.Add(this.Introduccion);
            this.wzdAsistente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wzdAsistente.Location = new System.Drawing.Point(0, 0);
            this.wzdAsistente.Name = "wzdAsistente";
            this.wzdAsistente.Pages.AddRange(new GEXVOC.Core.Controles.Asistente.WizardPage[] {
            this.Introduccion,
            this.Explotacion,
            this.Especies,
            this.Modulos,
            this.Titulares,
            this.Cierre});
            this.wzdAsistente.Size = new System.Drawing.Size(634, 444);
            this.wzdAsistente.TabIndex = 0;
            // 
            // Explotacion
            // 
            this.Explotacion.Controls.Add(this.cmbMunicipio);
            this.Explotacion.Controls.Add(this.cmbProvincia);
            this.Explotacion.Controls.Add(this.cmbCJuridica);
            this.Explotacion.Controls.Add(this.lblCLechero);
            this.Explotacion.Controls.Add(this.txtCLechero);
            this.Explotacion.Controls.Add(this.txtFecBaja);
            this.Explotacion.Controls.Add(this.txtFecAlta);
            this.Explotacion.Controls.Add(this.lblFecBaja);
            this.Explotacion.Controls.Add(this.lblFecAlta);
            this.Explotacion.Controls.Add(this.lblExplotacion);
            this.Explotacion.Controls.Add(this.label2);
            this.Explotacion.Controls.Add(this.txtSigla);
            this.Explotacion.Controls.Add(this.txtCea);
            this.Explotacion.Controls.Add(this.label1);
            this.Explotacion.Controls.Add(this.lblMunicipio);
            this.Explotacion.Controls.Add(this.lblCea);
            this.Explotacion.Controls.Add(this.lblNombre);
            this.Explotacion.Controls.Add(this.lblJuridica);
            this.Explotacion.Controls.Add(this.lblProvincia);
            this.Explotacion.Controls.Add(this.txtNombre);
            this.Explotacion.Controls.Add(this.txtDireccion);
            this.Explotacion.Controls.Add(this.hdrExplotacion);
            this.Explotacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Explotacion.IsFinishPage = false;
            this.Explotacion.Location = new System.Drawing.Point(0, 0);
            this.Explotacion.Name = "Explotacion";
            this.Explotacion.Size = new System.Drawing.Size(634, 396);
            this.Explotacion.TabIndex = 0;
            this.Explotacion.CloseFromNext += new GEXVOC.Core.Controles.Asistente.PageEventHandler(this.Explotacion_CloseFromNext);
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(381, 216);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(208, 21);
            this.cmbMunicipio.TabIndex = 6;
            this.cmbMunicipio.CargarContenido += new System.EventHandler(this.cmbMunicipio_CargarContenido);
            this.cmbMunicipio.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbMunicipio_CrearNuevo);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(103, 216);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(190, 21);
            this.cmbProvincia.TabIndex = 5;
            this.cmbProvincia.CargarContenido += new System.EventHandler(this.cmbProvincia_CargarContenido);
            this.cmbProvincia.SelectedValueChanged += new System.EventHandler(this.cmbProvincia_SelectedValueChanged);
            this.cmbProvincia.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbProvincia_CrearNuevo);
            // 
            // cmbCJuridica
            // 
            this.cmbCJuridica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCJuridica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCJuridica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbCJuridica.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbCJuridica.FormattingEnabled = true;
            this.cmbCJuridica.Location = new System.Drawing.Point(381, 135);
            this.cmbCJuridica.Name = "cmbCJuridica";
            this.cmbCJuridica.Size = new System.Drawing.Size(208, 21);
            this.cmbCJuridica.TabIndex = 1;
            this.cmbCJuridica.CargarContenido += new System.EventHandler(this.cmbCJuridica_CargarContenido);
            this.cmbCJuridica.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbCJuridica_CrearNuevo);
            // 
            // lblCLechero
            // 
            this.lblCLechero.AutoSize = true;
            this.lblCLechero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCLechero.Location = new System.Drawing.Point(35, 278);
            this.lblCLechero.Name = "lblCLechero";
            this.lblCLechero.Size = new System.Drawing.Size(63, 13);
            this.lblCLechero.TabIndex = 79;
            this.lblCLechero.Text = "C. Lechero:";
            // 
            // txtCLechero
            // 
            this.txtCLechero.Location = new System.Drawing.Point(103, 275);
            this.txtCLechero.MaxLength = 7;
            this.txtCLechero.Name = "txtCLechero";
            this.txtCLechero.Size = new System.Drawing.Size(86, 21);
            this.txtCLechero.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtCLechero, "Código de control lechero ");
            // 
            // txtFecBaja
            // 
            this.txtFecBaja.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecBaja.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecBaja.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecBaja.Location = new System.Drawing.Point(381, 243);
            this.txtFecBaja.Name = "txtFecBaja";
            this.txtFecBaja.ReadOnly = false;
            this.txtFecBaja.Size = new System.Drawing.Size(88, 21);
            this.txtFecBaja.TabIndex = 8;
            this.txtFecBaja.Value = null;
            // 
            // txtFecAlta
            // 
            this.txtFecAlta.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecAlta.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecAlta.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecAlta.Location = new System.Drawing.Point(103, 246);
            this.txtFecAlta.Name = "txtFecAlta";
            this.txtFecAlta.ReadOnly = false;
            this.txtFecAlta.Size = new System.Drawing.Size(88, 21);
            this.txtFecAlta.TabIndex = 7;
            this.txtFecAlta.Value = null;
            // 
            // lblFecBaja
            // 
            this.lblFecBaja.AutoSize = true;
            this.lblFecBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecBaja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecBaja.Location = new System.Drawing.Point(306, 246);
            this.lblFecBaja.Name = "lblFecBaja";
            this.lblFecBaja.Size = new System.Drawing.Size(43, 13);
            this.lblFecBaja.TabIndex = 77;
            this.lblFecBaja.Text = "F. Baja:";
            // 
            // lblFecAlta
            // 
            this.lblFecAlta.AutoSize = true;
            this.lblFecAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecAlta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecAlta.Location = new System.Drawing.Point(33, 246);
            this.lblFecAlta.Name = "lblFecAlta";
            this.lblFecAlta.Size = new System.Drawing.Size(48, 13);
            this.lblFecAlta.TabIndex = 76;
            this.lblFecAlta.Text = "F. Alta:";
            // 
            // lblExplotacion
            // 
            this.lblExplotacion.AutoSize = true;
            this.lblExplotacion.Location = new System.Drawing.Point(33, 88);
            this.lblExplotacion.Name = "lblExplotacion";
            this.lblExplotacion.Size = new System.Drawing.Size(181, 13);
            this.lblExplotacion.TabIndex = 73;
            this.lblExplotacion.Text = "Registre los datos de la explotación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(306, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Siglas:";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(381, 162);
            this.txtSigla.MaxLength = 7;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(86, 21);
            this.txtSigla.TabIndex = 3;
            // 
            // txtCea
            // 
            this.txtCea.Location = new System.Drawing.Point(103, 135);
            this.txtCea.MaxLength = 14;
            this.txtCea.Name = "txtCea";
            this.txtCea.Size = new System.Drawing.Size(113, 21);
            this.txtCea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(33, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Dirección:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMunicipio.Location = new System.Drawing.Point(306, 219);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(65, 13);
            this.lblMunicipio.TabIndex = 68;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // lblCea
            // 
            this.lblCea.AutoSize = true;
            this.lblCea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCea.Location = new System.Drawing.Point(33, 138);
            this.lblCea.Name = "lblCea";
            this.lblCea.Size = new System.Drawing.Size(35, 13);
            this.lblCea.TabIndex = 66;
            this.lblCea.Text = "CEA:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(33, 165);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 64;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblJuridica
            // 
            this.lblJuridica.AutoSize = true;
            this.lblJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblJuridica.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblJuridica.Location = new System.Drawing.Point(306, 137);
            this.lblJuridica.Name = "lblJuridica";
            this.lblJuridica.Size = new System.Drawing.Size(69, 13);
            this.lblJuridica.TabIndex = 69;
            this.lblJuridica.Text = "C.Jurídica:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProvincia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProvincia.Location = new System.Drawing.Point(33, 219);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(64, 13);
            this.lblProvincia.TabIndex = 67;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 162);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 21);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(103, 189);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(486, 21);
            this.txtDireccion.TabIndex = 4;
            // 
            // hdrExplotacion
            // 
            this.hdrExplotacion.BackColor = System.Drawing.SystemColors.Control;
            this.hdrExplotacion.CausesValidation = false;
            this.hdrExplotacion.Description = "Registre los datos de la explotación.";
            this.hdrExplotacion.Image = ((System.Drawing.Image)(resources.GetObject("hdrExplotacion.Image")));
            this.hdrExplotacion.Location = new System.Drawing.Point(3, 3);
            this.hdrExplotacion.Name = "hdrExplotacion";
            this.hdrExplotacion.Size = new System.Drawing.Size(628, 64);
            this.hdrExplotacion.TabIndex = 0;
            this.hdrExplotacion.Title = "Datos de la explotación.";
            // 
            // Introduccion
            // 
            this.Introduccion.Controls.Add(this.Intro);
            this.Introduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Introduccion.IsFinishPage = false;
            this.Introduccion.Location = new System.Drawing.Point(0, 0);
            this.Introduccion.Name = "Introduccion";
            this.Introduccion.Size = new System.Drawing.Size(634, 396);
            this.Introduccion.TabIndex = 1;
            // 
            // Intro
            // 
            this.Intro.BackColor = System.Drawing.Color.White;
            this.Intro.Image = ((System.Drawing.Image)(resources.GetObject("Intro.Image")));
            this.Intro.Location = new System.Drawing.Point(3, 3);
            this.Intro.Name = "Intro";
            this.Intro.PageText = "Este asistente le ayudará  a registrar explotaciones en el sistema.";
            this.Intro.PageTitle = "Asistente de registro de explotaciones";
            this.Intro.Size = new System.Drawing.Size(628, 390);
            this.Intro.TabIndex = 0;
            // 
            // Cierre
            // 
            this.Cierre.Controls.Add(this.Fin);
            this.Cierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cierre.IsFinishPage = true;
            this.Cierre.Location = new System.Drawing.Point(0, 0);
            this.Cierre.Name = "Cierre";
            this.Cierre.Size = new System.Drawing.Size(634, 396);
            this.Cierre.TabIndex = 6;
            // 
            // Fin
            // 
            this.Fin.BackColor = System.Drawing.Color.White;
            this.Fin.Image = ((System.Drawing.Image)(resources.GetObject("Fin.Image")));
            this.Fin.Location = new System.Drawing.Point(3, 3);
            this.Fin.Name = "Fin";
            this.Fin.PageText = "Finalizó el asistente para editar explotaciones.";
            this.Fin.PageTitle = "Finalización del asistente para la edición de explotaciones.";
            this.Fin.Size = new System.Drawing.Size(628, 388);
            this.Fin.TabIndex = 0;
            // 
            // Titulares
            // 
            this.Titulares.Controls.Add(this.dtgTitulares);
            this.Titulares.Controls.Add(this.tspTitulares);
            this.Titulares.Controls.Add(this.lblTitulares);
            this.Titulares.Controls.Add(this.hdrTitulares);
            this.Titulares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Titulares.IsFinishPage = false;
            this.Titulares.Location = new System.Drawing.Point(0, 0);
            this.Titulares.Name = "Titulares";
            this.Titulares.Size = new System.Drawing.Size(634, 396);
            this.Titulares.TabIndex = 5;
            this.Titulares.ShowFromBack += new System.EventHandler(this.Titulares_ShowFromBack);
            this.Titulares.ShowFromNext += new System.EventHandler(this.Titulares_ShowFromNext);
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
            this.dtgTitulares.Location = new System.Drawing.Point(36, 135);
            this.dtgTitulares.Name = "dtgTitulares";
            this.dtgTitulares.ReadOnly = true;
            this.dtgTitulares.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgTitulares.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgTitulares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTitulares.ShowCellErrors = false;
            this.dtgTitulares.ShowCellToolTips = false;
            this.dtgTitulares.ShowEditingIcon = false;
            this.dtgTitulares.ShowRowErrors = false;
            this.dtgTitulares.Size = new System.Drawing.Size(567, 217);
            this.dtgTitulares.TabIndex = 12;
            this.dtgTitulares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTitulares_CellDoubleClick);
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
            this.DNI.Width = 50;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Direccion.Width = 75;
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
            this.tspTitulares.Location = new System.Drawing.Point(335, 355);
            this.tspTitulares.Name = "tspTitulares";
            this.tspTitulares.Size = new System.Drawing.Size(268, 23);
            this.tspTitulares.TabIndex = 13;
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
            this.tsbNuevoTitular.ButtonClick += new System.EventHandler(this.tsbNuevoTitular_ButtonClick);
            // 
            // tsmTitularNuevo
            // 
            this.tsmTitularNuevo.Name = "tsmTitularNuevo";
            this.tsmTitularNuevo.Size = new System.Drawing.Size(163, 22);
            this.tsmTitularNuevo.Text = "Titular nuevo";
            this.tsmTitularNuevo.ToolTipText = "Añade un titular nuevo y lo asigna a la explotación";
            this.tsmTitularNuevo.Click += new System.EventHandler(this.tsmTitularNuevo_Click);
            // 
            // tsmTitularExistente
            // 
            this.tsmTitularExistente.Name = "tsmTitularExistente";
            this.tsmTitularExistente.Size = new System.Drawing.Size(163, 22);
            this.tsmTitularExistente.Text = "Titular existente";
            this.tsmTitularExistente.ToolTipText = "Asigna a la explotación un Titular existente.";
            this.tsmTitularExistente.Click += new System.EventHandler(this.tsmTitularExistente_Click);
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
            this.tsbModificarTitular.Click += new System.EventHandler(this.tsbModificarTitular_Click);
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
            this.tsmEliminarRelacion,
            this.tsmEliminarTitular});
            this.tsbEliminarTitular.Image = global::GEXVOC.Properties.Resources.cancelar;
            this.tsbEliminarTitular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarTitular.Name = "tsbEliminarTitular";
            this.tsbEliminarTitular.Size = new System.Drawing.Size(85, 20);
            this.tsbEliminarTitular.Text = " Eliminar ";
            this.tsbEliminarTitular.ButtonClick += new System.EventHandler(this.tsbEliminarTitular_ButtonClick);
            // 
            // tsmEliminarRelacion
            // 
            this.tsmEliminarRelacion.Name = "tsmEliminarRelacion";
            this.tsmEliminarRelacion.Size = new System.Drawing.Size(225, 22);
            this.tsmEliminarRelacion.Text = "Relación (Titular-Explotación)";
            this.tsmEliminarRelacion.ToolTipText = "Elimina la relación entre el titular seleccionado y la Explotación cargada. (No e" +
                "limina el titular de la Base de datos)";
            this.tsmEliminarRelacion.Click += new System.EventHandler(this.tsmEliminarRelacion_Click);
            // 
            // tsmEliminarTitular
            // 
            this.tsmEliminarTitular.Name = "tsmEliminarTitular";
            this.tsmEliminarTitular.Size = new System.Drawing.Size(225, 22);
            this.tsmEliminarTitular.Text = "Eliminar Titular";
            this.tsmEliminarTitular.ToolTipText = "Borra el titular de la base de datos";
            this.tsmEliminarTitular.Click += new System.EventHandler(this.tsmEliminarTitular_Click);
            // 
            // lblTitulares
            // 
            this.lblTitulares.AutoSize = true;
            this.lblTitulares.Location = new System.Drawing.Point(33, 88);
            this.lblTitulares.Name = "lblTitulares";
            this.lblTitulares.Size = new System.Drawing.Size(207, 13);
            this.lblTitulares.TabIndex = 1;
            this.lblTitulares.Text = "Especifique los titulares de la explotación:";
            // 
            // hdrTitulares
            // 
            this.hdrTitulares.BackColor = System.Drawing.SystemColors.Control;
            this.hdrTitulares.CausesValidation = false;
            this.hdrTitulares.Description = "Especifique los titulares de la explotación.";
            this.hdrTitulares.Image = ((System.Drawing.Image)(resources.GetObject("hdrTitulares.Image")));
            this.hdrTitulares.Location = new System.Drawing.Point(3, 3);
            this.hdrTitulares.Name = "hdrTitulares";
            this.hdrTitulares.Size = new System.Drawing.Size(628, 64);
            this.hdrTitulares.TabIndex = 0;
            this.hdrTitulares.Title = "Titulares";
            // 
            // Modulos
            // 
            this.Modulos.Controls.Add(this.trvModulos);
            this.Modulos.Controls.Add(this.lblModulos);
            this.Modulos.Controls.Add(this.hdrModulos);
            this.Modulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modulos.IsFinishPage = false;
            this.Modulos.Location = new System.Drawing.Point(0, 0);
            this.Modulos.Name = "Modulos";
            this.Modulos.Size = new System.Drawing.Size(634, 396);
            this.Modulos.TabIndex = 4;
            this.Modulos.CloseFromNext += new GEXVOC.Core.Controles.Asistente.PageEventHandler(this.Modulos_CloseFromNext);
            // 
            // trvModulos
            // 
            this.trvModulos.CheckBoxes = true;
            this.trvModulos.Location = new System.Drawing.Point(77, 124);
            this.trvModulos.Name = "trvModulos";
            this.trvModulos.ShowLines = false;
            this.trvModulos.Size = new System.Drawing.Size(377, 251);
            this.trvModulos.TabIndex = 11;
            // 
            // lblModulos
            // 
            this.lblModulos.AutoSize = true;
            this.lblModulos.Location = new System.Drawing.Point(33, 88);
            this.lblModulos.Name = "lblModulos";
            this.lblModulos.Size = new System.Drawing.Size(203, 13);
            this.lblModulos.TabIndex = 1;
            this.lblModulos.Text = "Seleccione los módulos de la explotación:";
            // 
            // hdrModulos
            // 
            this.hdrModulos.BackColor = System.Drawing.SystemColors.Control;
            this.hdrModulos.CausesValidation = false;
            this.hdrModulos.Description = "Seleccione los módulos de la explotación.";
            this.hdrModulos.Image = ((System.Drawing.Image)(resources.GetObject("hdrModulos.Image")));
            this.hdrModulos.Location = new System.Drawing.Point(3, 3);
            this.hdrModulos.Name = "hdrModulos";
            this.hdrModulos.Size = new System.Drawing.Size(628, 64);
            this.hdrModulos.TabIndex = 0;
            this.hdrModulos.Title = "Módulos";
            // 
            // Especies
            // 
            this.Especies.Controls.Add(this.trvEspecies);
            this.Especies.Controls.Add(this.lblEspecies);
            this.Especies.Controls.Add(this.hdrEspecies);
            this.Especies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Especies.IsFinishPage = false;
            this.Especies.Location = new System.Drawing.Point(0, 0);
            this.Especies.Name = "Especies";
            this.Especies.Size = new System.Drawing.Size(634, 396);
            this.Especies.TabIndex = 3;
            this.Especies.CloseFromNext += new GEXVOC.Core.Controles.Asistente.PageEventHandler(this.Especies_CloseFromNext);
            // 
            // trvEspecies
            // 
            this.trvEspecies.CheckBoxes = true;
            this.trvEspecies.Location = new System.Drawing.Point(77, 124);
            this.trvEspecies.Name = "trvEspecies";
            this.trvEspecies.ShowLines = false;
            this.trvEspecies.Size = new System.Drawing.Size(377, 251);
            this.trvEspecies.TabIndex = 10;
            // 
            // lblEspecies
            // 
            this.lblEspecies.AutoSize = true;
            this.lblEspecies.Location = new System.Drawing.Point(33, 88);
            this.lblEspecies.Name = "lblEspecies";
            this.lblEspecies.Size = new System.Drawing.Size(205, 13);
            this.lblEspecies.TabIndex = 2;
            this.lblEspecies.Text = "Seleccione las especies de la explotación:";
            // 
            // hdrEspecies
            // 
            this.hdrEspecies.BackColor = System.Drawing.SystemColors.Control;
            this.hdrEspecies.CausesValidation = false;
            this.hdrEspecies.Description = "Seleccione las especies de la explotación.";
            this.hdrEspecies.Image = ((System.Drawing.Image)(resources.GetObject("hdrEspecies.Image")));
            this.hdrEspecies.Location = new System.Drawing.Point(3, 3);
            this.hdrEspecies.Name = "hdrEspecies";
            this.hdrEspecies.Size = new System.Drawing.Size(628, 64);
            this.hdrEspecies.TabIndex = 0;
            this.hdrEspecies.Title = "Especies";
            // 
            // Asistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 440);
            this.ControlBox = false;
            this.Controls.Add(this.wzdAsistente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Asistente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asistente para crear/editar explotaciones";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.wzdAsistente.ResumeLayout(false);
            this.Explotacion.ResumeLayout(false);
            this.Explotacion.PerformLayout();
            this.Introduccion.ResumeLayout(false);
            this.Cierre.ResumeLayout(false);
            this.Titulares.ResumeLayout(false);
            this.Titulares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTitulares)).EndInit();
            this.tspTitulares.ResumeLayout(false);
            this.tspTitulares.PerformLayout();
            this.Modulos.ResumeLayout(false);
            this.Modulos.PerformLayout();
            this.Especies.ResumeLayout(false);
            this.Especies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GEXVOC.Core.Controles.Asistente.Wizard wzdAsistente;
        private GEXVOC.Core.Controles.Asistente.WizardPage Introduccion;
        private GEXVOC.Core.Controles.Asistente.InfoPage Intro;
        private GEXVOC.Core.Controles.Asistente.WizardPage Explotacion;
        private GEXVOC.Core.Controles.Asistente.WizardPage Especies;
        private GEXVOC.Core.Controles.Asistente.WizardPage Modulos;
        private GEXVOC.Core.Controles.Asistente.WizardPage Titulares;
        private GEXVOC.Core.Controles.Asistente.Header hdrExplotacion;
        private GEXVOC.Core.Controles.Asistente.Header hdrTitulares;
        private GEXVOC.Core.Controles.Asistente.Header hdrModulos;
        private GEXVOC.Core.Controles.Asistente.Header hdrEspecies;
        private GEXVOC.Core.Controles.Asistente.WizardPage Cierre;
        private GEXVOC.Core.Controles.Asistente.InfoPage Fin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtCea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblCea;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblJuridica;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblExplotacion;
        private System.Windows.Forms.Label lblEspecies;
        private System.Windows.Forms.Label lblTitulares;
        private System.Windows.Forms.Label lblModulos;
        private System.Windows.Forms.DataGridView dtgTitulares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.ToolStrip tspTitulares;
        private System.Windows.Forms.ToolStripSplitButton tsbNuevoTitular;
        private System.Windows.Forms.ToolStripMenuItem tsmTitularNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmTitularExistente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbModificarTitular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton tsbEliminarTitular;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarRelacion;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminarTitular;
        private System.Windows.Forms.TreeView trvModulos;
        private System.Windows.Forms.TreeView trvEspecies;
        private System.Windows.Forms.Label lblFecBaja;
        private System.Windows.Forms.Label lblFecAlta;
        private GEXVOC.Core.Controles.ctlFecha txtFecBaja;
        private GEXVOC.Core.Controles.ctlFecha txtFecAlta;
        private System.Windows.Forms.Label lblCLechero;
        private System.Windows.Forms.TextBox txtCLechero;
        private GEXVOC.Core.Controles.ctlCombo cmbCJuridica;
        private GEXVOC.Core.Controles.ctlCombo cmbProvincia;
        private GEXVOC.Core.Controles.ctlCombo cmbMunicipio;
       
    }
}