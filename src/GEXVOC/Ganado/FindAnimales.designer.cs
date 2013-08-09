namespace GEXVOC.UI
{
    partial class FindAnimales
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
            this.lblFecNacimiento = new System.Windows.Forms.Label();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.SubBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnLGenealogico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCelos = new System.Windows.Forms.ToolStripButton();
            this.btnInseminaciones = new System.Windows.Forms.ToolStripButton();
            this.btnPartos = new System.Windows.Forms.ToolStripButton();
            this.btnLactacion = new System.Windows.Forms.ToolStripButton();
            this.btnControles = new System.Windows.Forms.ToolStripButton();
            this.btnSecados = new System.Windows.Forms.ToolStripButton();
            this.btnPesos = new System.Windows.Forms.ToolStripButton();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTatuaje = new System.Windows.Forms.TextBox();
            this.lblTatuaje = new System.Windows.Forms.Label();
            this.txtDIB = new System.Windows.Forms.TextBox();
            this.lblDIB = new System.Windows.Forms.Label();
            this.txtCrotal = new System.Windows.Forms.TextBox();
            this.lblCrotal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBaja = new System.Windows.Forms.Panel();
            this.txtBajaFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.lblBajaDetalle = new System.Windows.Forms.Label();
            this.txtBajaDetalle = new System.Windows.Forms.TextBox();
            this.lblBajaFecha = new System.Windows.Forms.Label();
            this.cmbBajaTipo = new System.Windows.Forms.ComboBox();
            this.lblBajaTipo = new System.Windows.Forms.Label();
            this.pnlAlta = new System.Windows.Forms.Panel();
            this.txtAltaFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbAltaTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltaDetalle = new System.Windows.Forms.TextBox();
            this.lblFecAlta = new System.Windows.Forms.Label();
            this.rbtMostrarAltas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtMostrarBajas = new System.Windows.Forms.RadioButton();
            this.txtFecNacimiento = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SubBarraHerramientas.SuspendLayout();
            this.pnlBaja.SuspendLayout();
            this.pnlAlta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecNacimiento);
            this.pnlBusqueda.Controls.Add(this.cmEstado);
            this.pnlBusqueda.Controls.Add(this.label4);
            this.pnlBusqueda.Controls.Add(this.txtTatuaje);
            this.pnlBusqueda.Controls.Add(this.lblTatuaje);
            this.pnlBusqueda.Controls.Add(this.txtDIB);
            this.pnlBusqueda.Controls.Add(this.lblDIB);
            this.pnlBusqueda.Controls.Add(this.txtCrotal);
            this.pnlBusqueda.Controls.Add(this.lblCrotal);
            this.pnlBusqueda.Controls.Add(this.lblNombre);
            this.pnlBusqueda.Controls.Add(this.txtNombre);
            this.pnlBusqueda.Controls.Add(this.cmbEspecie);
            this.pnlBusqueda.Controls.Add(this.label5);
            this.pnlBusqueda.Controls.Add(this.cmbSexo);
            this.pnlBusqueda.Controls.Add(this.lblSexo);
            this.pnlBusqueda.Controls.Add(this.lblFecNacimiento);
            this.pnlBusqueda.Controls.Add(this.cmbRaza);
            this.pnlBusqueda.Controls.Add(this.lblRaza);
            this.pnlBusqueda.Controls.Add(this.groupBox1);
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 60);
            this.pnlBusqueda.Size = new System.Drawing.Size(769, 174);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 240);
            this.panel1.Size = new System.Drawing.Size(769, 292);
            // 
            // lblFecNacimiento
            // 
            this.lblFecNacimiento.AutoSize = true;
            this.lblFecNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecNacimiento.Location = new System.Drawing.Point(558, 77);
            this.lblFecNacimiento.Name = "lblFecNacimiento";
            this.lblFecNacimiento.Size = new System.Drawing.Size(87, 13);
            this.lblFecNacimiento.TabIndex = 70;
            this.lblFecNacimiento.Text = "Fec. Nacimiento:";
            // 
            // cmbRaza
            // 
            this.cmbRaza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRaza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(252, 74);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(296, 21);
            this.cmbRaza.TabIndex = 7;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRaza.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRaza.Location = new System.Drawing.Point(211, 77);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(35, 13);
            this.lblRaza.TabIndex = 69;
            this.lblRaza.Text = "Raza:";
            // 
            // SubBarraHerramientas
            // 
            this.SubBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLGenealogico,
            this.toolStripSeparator2,
            this.btnCelos,
            this.btnInseminaciones,
            this.btnPartos,
            this.btnLactacion,
            this.btnControles,
            this.btnSecados,
            this.btnPesos});
            this.SubBarraHerramientas.Location = new System.Drawing.Point(0, 25);
            this.SubBarraHerramientas.Name = "SubBarraHerramientas";
            this.SubBarraHerramientas.Size = new System.Drawing.Size(793, 25);
            this.SubBarraHerramientas.TabIndex = 8;
            // 
            // btnLGenealogico
            // 
            this.btnLGenealogico.Image = global::GEXVOC.Properties.Resources.info;
            this.btnLGenealogico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLGenealogico.Name = "btnLGenealogico";
            this.btnLGenealogico.Size = new System.Drawing.Size(94, 22);
            this.btnLGenealogico.Text = "L.Genealógico";
            this.btnLGenealogico.ToolTipText = "Libro Genealógico";
            this.btnLGenealogico.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCelos
            // 
            this.btnCelos.Image = global::GEXVOC.Properties.Resources.info;
            this.btnCelos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCelos.Name = "btnCelos";
            this.btnCelos.Size = new System.Drawing.Size(80, 22);
            this.btnCelos.Text = "Celos/Sinc.";
            this.btnCelos.ToolTipText = "Celos / Sincronización de Celos";
            this.btnCelos.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnInseminaciones
            // 
            this.btnInseminaciones.Image = global::GEXVOC.Properties.Resources.info;
            this.btnInseminaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInseminaciones.Name = "btnInseminaciones";
            this.btnInseminaciones.Size = new System.Drawing.Size(100, 22);
            this.btnInseminaciones.Text = "Ins./Diag Gest.";
            this.btnInseminaciones.ToolTipText = "Inseminaciones / Diagnósticos de gestación";
            this.btnInseminaciones.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnPartos
            // 
            this.btnPartos.Image = global::GEXVOC.Properties.Resources.info;
            this.btnPartos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPartos.Name = "btnPartos";
            this.btnPartos.Size = new System.Drawing.Size(100, 22);
            this.btnPartos.Text = "Partos/Abortos";
            this.btnPartos.ToolTipText = "Partos / Abortos";
            this.btnPartos.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnLactacion
            // 
            this.btnLactacion.Image = global::GEXVOC.Properties.Resources.info;
            this.btnLactacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLactacion.Name = "btnLactacion";
            this.btnLactacion.Size = new System.Drawing.Size(72, 22);
            this.btnLactacion.Text = "Lactación";
            this.btnLactacion.ToolTipText = "Lactación";
            this.btnLactacion.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnControles
            // 
            this.btnControles.Image = global::GEXVOC.Properties.Resources.info;
            this.btnControles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnControles.Name = "btnControles";
            this.btnControles.Size = new System.Drawing.Size(73, 22);
            this.btnControles.Text = "Controles";
            this.btnControles.ToolTipText = "Controles";
            this.btnControles.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnSecados
            // 
            this.btnSecados.Image = global::GEXVOC.Properties.Resources.info;
            this.btnSecados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSecados.Name = "btnSecados";
            this.btnSecados.Size = new System.Drawing.Size(67, 22);
            this.btnSecados.Text = "Secados";
            this.btnSecados.ToolTipText = "Secados";
            this.btnSecados.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // btnPesos
            // 
            this.btnPesos.Image = global::GEXVOC.Properties.Resources.info;
            this.btnPesos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesos.Name = "btnPesos";
            this.btnPesos.Size = new System.Drawing.Size(55, 22);
            this.btnPesos.Text = "Pesos";
            this.btnPesos.ToolTipText = "Pesos";
            this.btnPesos.Click += new System.EventHandler(this.btnesHorizontales_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hembra",
            "Macho"});
            this.cmbSexo.Location = new System.Drawing.Point(651, 43);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(88, 21);
            this.cmbSexo.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSexo.Location = new System.Drawing.Point(611, 51);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 79;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(66, 74);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(128, 21);
            this.cmbEspecie.TabIndex = 6;
            this.cmbEspecie.SelectedIndexChanged += new System.EventHandler(this.cmbEspecie_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Especie:";
            // 
            // txtTatuaje
            // 
            this.txtTatuaje.Location = new System.Drawing.Point(298, 48);
            this.txtTatuaje.MaxLength = 7;
            this.txtTatuaje.Name = "txtTatuaje";
            this.txtTatuaje.Size = new System.Drawing.Size(126, 20);
            this.txtTatuaje.TabIndex = 3;
            // 
            // lblTatuaje
            // 
            this.lblTatuaje.AutoSize = true;
            this.lblTatuaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTatuaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTatuaje.Location = new System.Drawing.Point(249, 51);
            this.lblTatuaje.Name = "lblTatuaje";
            this.lblTatuaje.Size = new System.Drawing.Size(43, 13);
            this.lblTatuaje.TabIndex = 156;
            this.lblTatuaje.Text = "Tatuaje";
            // 
            // txtDIB
            // 
            this.txtDIB.Location = new System.Drawing.Point(66, 48);
            this.txtDIB.MaxLength = 14;
            this.txtDIB.Name = "txtDIB";
            this.txtDIB.Size = new System.Drawing.Size(164, 20);
            this.txtDIB.TabIndex = 2;
            // 
            // lblDIB
            // 
            this.lblDIB.AutoSize = true;
            this.lblDIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDIB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDIB.Location = new System.Drawing.Point(14, 51);
            this.lblDIB.Name = "lblDIB";
            this.lblDIB.Size = new System.Drawing.Size(25, 13);
            this.lblDIB.TabIndex = 155;
            this.lblDIB.Text = "DIB";
            // 
            // txtCrotal
            // 
            this.txtCrotal.Location = new System.Drawing.Point(498, 48);
            this.txtCrotal.MaxLength = 4;
            this.txtCrotal.Name = "txtCrotal";
            this.txtCrotal.Size = new System.Drawing.Size(55, 20);
            this.txtCrotal.TabIndex = 4;
            // 
            // lblCrotal
            // 
            this.lblCrotal.AutoSize = true;
            this.lblCrotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCrotal.Location = new System.Drawing.Point(449, 51);
            this.lblCrotal.Name = "lblCrotal";
            this.lblCrotal.Size = new System.Drawing.Size(37, 13);
            this.lblCrotal.TabIndex = 154;
            this.lblCrotal.Text = "Crotal:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(13, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 152;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 21);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(337, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // cmEstado
            // 
            this.cmEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmEstado.FormattingEnabled = true;
            this.cmEstado.Location = new System.Drawing.Point(498, 18);
            this.cmEstado.Name = "cmEstado";
            this.cmEstado.Size = new System.Drawing.Size(241, 21);
            this.cmEstado.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(449, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 158;
            this.label4.Text = "Estado:";
            // 
            // pnlBaja
            // 
            this.pnlBaja.Controls.Add(this.txtBajaFecha);
            this.pnlBaja.Controls.Add(this.lblBajaDetalle);
            this.pnlBaja.Controls.Add(this.txtBajaDetalle);
            this.pnlBaja.Controls.Add(this.lblBajaFecha);
            this.pnlBaja.Controls.Add(this.cmbBajaTipo);
            this.pnlBaja.Controls.Add(this.lblBajaTipo);
            this.pnlBaja.Location = new System.Drawing.Point(120, 9);
            this.pnlBaja.Name = "pnlBaja";
            this.pnlBaja.Size = new System.Drawing.Size(576, 55);
            this.pnlBaja.TabIndex = 2;
            this.pnlBaja.Visible = false;
            // 
            // txtBajaFecha
            // 
            this.txtBajaFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtBajaFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtBajaFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtBajaFecha.Location = new System.Drawing.Point(61, 6);
            this.txtBajaFecha.Name = "txtBajaFecha";
            this.txtBajaFecha.ReadOnly = false;
            this.txtBajaFecha.Size = new System.Drawing.Size(88, 20);
            this.txtBajaFecha.TabIndex = 22;
            this.txtBajaFecha.Value = null;
            // 
            // lblBajaDetalle
            // 
            this.lblBajaDetalle.AutoSize = true;
            this.lblBajaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblBajaDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBajaDetalle.Location = new System.Drawing.Point(9, 36);
            this.lblBajaDetalle.Name = "lblBajaDetalle";
            this.lblBajaDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblBajaDetalle.TabIndex = 20;
            this.lblBajaDetalle.Text = "Detalle:";
            // 
            // txtBajaDetalle
            // 
            this.txtBajaDetalle.Location = new System.Drawing.Point(62, 33);
            this.txtBajaDetalle.MaxLength = 150;
            this.txtBajaDetalle.Name = "txtBajaDetalle";
            this.txtBajaDetalle.Size = new System.Drawing.Size(483, 20);
            this.txtBajaDetalle.TabIndex = 24;
            // 
            // lblBajaFecha
            // 
            this.lblBajaFecha.AutoSize = true;
            this.lblBajaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblBajaFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBajaFecha.Location = new System.Drawing.Point(9, 11);
            this.lblBajaFecha.Name = "lblBajaFecha";
            this.lblBajaFecha.Size = new System.Drawing.Size(43, 13);
            this.lblBajaFecha.TabIndex = 1;
            this.lblBajaFecha.Text = "F. Baja:";
            // 
            // cmbBajaTipo
            // 
            this.cmbBajaTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBajaTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBajaTipo.FormattingEnabled = true;
            this.cmbBajaTipo.Location = new System.Drawing.Point(234, 8);
            this.cmbBajaTipo.Name = "cmbBajaTipo";
            this.cmbBajaTipo.Size = new System.Drawing.Size(311, 21);
            this.cmbBajaTipo.TabIndex = 23;
            // 
            // lblBajaTipo
            // 
            this.lblBajaTipo.AutoSize = true;
            this.lblBajaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblBajaTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBajaTipo.Location = new System.Drawing.Point(175, 11);
            this.lblBajaTipo.Name = "lblBajaTipo";
            this.lblBajaTipo.Size = new System.Drawing.Size(44, 13);
            this.lblBajaTipo.TabIndex = 3;
            this.lblBajaTipo.Text = "T. Baja:";
            // 
            // pnlAlta
            // 
            this.pnlAlta.Controls.Add(this.txtAltaFecha);
            this.pnlAlta.Controls.Add(this.cmbAltaTipo);
            this.pnlAlta.Controls.Add(this.label2);
            this.pnlAlta.Controls.Add(this.label1);
            this.pnlAlta.Controls.Add(this.txtAltaDetalle);
            this.pnlAlta.Controls.Add(this.lblFecAlta);
            this.pnlAlta.Location = new System.Drawing.Point(120, 9);
            this.pnlAlta.Name = "pnlAlta";
            this.pnlAlta.Size = new System.Drawing.Size(576, 55);
            this.pnlAlta.TabIndex = 159;
            // 
            // txtAltaFecha
            // 
            this.txtAltaFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtAltaFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtAltaFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtAltaFecha.Location = new System.Drawing.Point(63, 4);
            this.txtAltaFecha.Name = "txtAltaFecha";
            this.txtAltaFecha.ReadOnly = false;
            this.txtAltaFecha.Size = new System.Drawing.Size(88, 20);
            this.txtAltaFecha.TabIndex = 22;
            this.txtAltaFecha.Value = null;
            // 
            // cmbAltaTipo
            // 
            this.cmbAltaTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAltaTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAltaTipo.FormattingEnabled = true;
            this.cmbAltaTipo.Location = new System.Drawing.Point(234, 3);
            this.cmbAltaTipo.Name = "cmbAltaTipo";
            this.cmbAltaTipo.Size = new System.Drawing.Size(311, 21);
            this.cmbAltaTipo.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(175, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "T. Alta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Detalle:";
            // 
            // txtAltaDetalle
            // 
            this.txtAltaDetalle.Location = new System.Drawing.Point(63, 30);
            this.txtAltaDetalle.MaxLength = 150;
            this.txtAltaDetalle.Name = "txtAltaDetalle";
            this.txtAltaDetalle.Size = new System.Drawing.Size(483, 20);
            this.txtAltaDetalle.TabIndex = 61;
            // 
            // lblFecAlta
            // 
            this.lblFecAlta.AutoSize = true;
            this.lblFecAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecAlta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecAlta.Location = new System.Drawing.Point(8, 11);
            this.lblFecAlta.Name = "lblFecAlta";
            this.lblFecAlta.Size = new System.Drawing.Size(40, 13);
            this.lblFecAlta.TabIndex = 63;
            this.lblFecAlta.Text = "F. Alta:";
            // 
            // rbtMostrarAltas
            // 
            this.rbtMostrarAltas.AutoSize = true;
            this.rbtMostrarAltas.Checked = true;
            this.rbtMostrarAltas.Location = new System.Drawing.Point(35, 20);
            this.rbtMostrarAltas.Name = "rbtMostrarAltas";
            this.rbtMostrarAltas.Size = new System.Drawing.Size(48, 17);
            this.rbtMostrarAltas.TabIndex = 0;
            this.rbtMostrarAltas.TabStop = true;
            this.rbtMostrarAltas.Text = "Altas";
            this.rbtMostrarAltas.UseVisualStyleBackColor = true;
            this.rbtMostrarAltas.CheckedChanged += new System.EventHandler(this.rbtMostrarAltas_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtMostrarBajas);
            this.groupBox1.Controls.Add(this.rbtMostrarAltas);
            this.groupBox1.Controls.Add(this.pnlBaja);
            this.groupBox1.Controls.Add(this.pnlAlta);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 67);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar";
            // 
            // rbtMostrarBajas
            // 
            this.rbtMostrarBajas.AutoSize = true;
            this.rbtMostrarBajas.Location = new System.Drawing.Point(35, 43);
            this.rbtMostrarBajas.Name = "rbtMostrarBajas";
            this.rbtMostrarBajas.Size = new System.Drawing.Size(51, 17);
            this.rbtMostrarBajas.TabIndex = 1;
            this.rbtMostrarBajas.Text = "Bajas";
            this.rbtMostrarBajas.UseVisualStyleBackColor = true;
            this.rbtMostrarBajas.CheckedChanged += new System.EventHandler(this.rbtMostrarBajas_CheckedChanged);
            // 
            // txtFecNacimiento
            // 
            this.txtFecNacimiento.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecNacimiento.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecNacimiento.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecNacimiento.Location = new System.Drawing.Point(651, 70);
            this.txtFecNacimiento.Name = "txtFecNacimiento";
            this.txtFecNacimiento.ReadOnly = false;
            this.txtFecNacimiento.Size = new System.Drawing.Size(88, 20);
            this.txtFecNacimiento.TabIndex = 8;
            this.txtFecNacimiento.Value = null;
            // 
            // FindAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(793, 557);
            this.Controls.Add(this.SubBarraHerramientas);
            this.dtgResultadoTamano = new System.Drawing.Size(769, 272);
            this.Name = "FindAnimales";
            this.pnlBusquedaPosicion = new System.Drawing.Point(12, 60);
            this.pnlBusquedaTamano = new System.Drawing.Size(769, 174);
            this.Text = "Animales";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.SubBarraHerramientas, 0);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.SubBarraHerramientas.ResumeLayout(false);
            this.SubBarraHerramientas.PerformLayout();
            this.pnlBaja.ResumeLayout(false);
            this.pnlBaja.PerformLayout();
            this.pnlAlta.ResumeLayout(false);
            this.pnlAlta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecNacimiento;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.ToolStrip SubBarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnLGenealogico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCelos;
        private System.Windows.Forms.ToolStripButton btnInseminaciones;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ToolStripButton btnLactacion;
        private System.Windows.Forms.ToolStripButton btnPartos;
        private System.Windows.Forms.ToolStripButton btnControles;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton btnPesos;
        private System.Windows.Forms.TextBox txtTatuaje;
        private System.Windows.Forms.Label lblTatuaje;
        private System.Windows.Forms.TextBox txtDIB;
        private System.Windows.Forms.Label lblDIB;
        private System.Windows.Forms.TextBox txtCrotal;
        private System.Windows.Forms.Label lblCrotal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlBaja;
        private System.Windows.Forms.Label lblBajaDetalle;
        private System.Windows.Forms.TextBox txtBajaDetalle;
        private System.Windows.Forms.Label lblBajaFecha;
        private System.Windows.Forms.ComboBox cmbBajaTipo;
        private System.Windows.Forms.Label lblBajaTipo;
        private System.Windows.Forms.Panel pnlAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltaDetalle;
        private System.Windows.Forms.Label lblFecAlta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtMostrarBajas;
        private System.Windows.Forms.RadioButton rbtMostrarAltas;
        private System.Windows.Forms.ComboBox cmbAltaTipo;
        private System.Windows.Forms.Label label2;
        private GEXVOC.Core.Controles.ctlFecha txtFecNacimiento;
        private GEXVOC.Core.Controles.ctlFecha txtBajaFecha;
        private GEXVOC.Core.Controles.ctlFecha txtAltaFecha;
        private System.Windows.Forms.ToolStripButton btnSecados;
    }
}
