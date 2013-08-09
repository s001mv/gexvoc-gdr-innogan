namespace GEXVOC.Informes
{
    partial class InfHistorialEnfermedades
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
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.lblVaca = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFechafin = new System.Windows.Forms.Label();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.cmbPersonal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.btnBuscarEnfermedad = new System.Windows.Forms.Button();
            this.cmbEnfermedad = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.cmbHembra.Location = new System.Drawing.Point(98, 5);
            this.cmbHembra.Name = "cmbHembra";
            this.cmbHembra.PermitirEliminar = true;
            this.cmbHembra.PermitirLimpiar = true;
            this.cmbHembra.ReadOnly = false;
            this.cmbHembra.Size = new System.Drawing.Size(239, 21);
            this.cmbHembra.TabIndex = 0;
            this.cmbHembra.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbHembra.TipoDatos = null;
            // 
            // btnBuscarHembra
            // 
            this.btnBuscarHembra.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarHembra.Location = new System.Drawing.Point(343, 5);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 1;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.btnBuscarHembra_Click);
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaca.Location = new System.Drawing.Point(18, 8);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(52, 13);
            this.lblVaca.TabIndex = 129;
            this.lblVaca.Text = "Animales:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 25);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(73, 13);
            this.lblFechaInicio.TabIndex = 150;
            this.lblFechaInicio.Text = "Fecha (inicio):";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(85, 22);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 0;
            this.txtFechaInicio.Value = null;
            // 
            // lblFechafin
            // 
            this.lblFechafin.AutoSize = true;
            this.lblFechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechafin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechafin.Location = new System.Drawing.Point(197, 25);
            this.lblFechafin.Name = "lblFechafin";
            this.lblFechafin.Size = new System.Drawing.Size(60, 13);
            this.lblFechafin.TabIndex = 152;
            this.lblFechafin.Text = "Fecha (fin):";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(263, 22);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 1;
            this.txtFechaFin.Value = null;
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPersonal.Location = new System.Drawing.Point(642, 12);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPersonal.TabIndex = 3;
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPersonal.btnBusqueda = this.btnBuscarPersonal;
            this.cmbPersonal.ClaseActiva = null;
            this.cmbPersonal.ControlVisible = true;
            this.cmbPersonal.DisplayMember = "NombreCompleto";
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.IdClaseActiva = 0;
            this.cmbPersonal.Location = new System.Drawing.Point(451, 12);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.PermitirEliminar = true;
            this.cmbPersonal.PermitirLimpiar = true;
            this.cmbPersonal.ReadOnly = false;
            this.cmbPersonal.Size = new System.Drawing.Size(185, 21);
            this.cmbPersonal.TabIndex = 2;
            this.cmbPersonal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPersonal.TipoDatos = null;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPersonal.Location = new System.Drawing.Point(384, 16);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(51, 13);
            this.lblPersonal.TabIndex = 155;
            this.lblPersonal.Text = "Personal:";
            // 
            // btnBuscarEnfermedad
            // 
            this.btnBuscarEnfermedad.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarEnfermedad.Location = new System.Drawing.Point(642, 33);
            this.btnBuscarEnfermedad.Name = "btnBuscarEnfermedad";
            this.btnBuscarEnfermedad.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarEnfermedad.TabIndex = 5;
            this.btnBuscarEnfermedad.UseVisualStyleBackColor = true;
            this.btnBuscarEnfermedad.Click += new System.EventHandler(this.btnBuscarEnfermedad_Click);
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEnfermedad.btnBusqueda = this.btnBuscarEnfermedad;
            this.cmbEnfermedad.ClaseActiva = null;
            this.cmbEnfermedad.ControlVisible = true;
            this.cmbEnfermedad.DisplayMember = "Descripcion";
            this.cmbEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbEnfermedad.FormattingEnabled = true;
            this.cmbEnfermedad.IdClaseActiva = 0;
            this.cmbEnfermedad.Location = new System.Drawing.Point(451, 34);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.PermitirEliminar = true;
            this.cmbEnfermedad.PermitirLimpiar = true;
            this.cmbEnfermedad.ReadOnly = false;
            this.cmbEnfermedad.Size = new System.Drawing.Size(185, 21);
            this.cmbEnfermedad.TabIndex = 4;
            this.cmbEnfermedad.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbEnfermedad.TipoDatos = null;
            this.cmbEnfermedad.SelectedIndexChanged += new System.EventHandler(this.cmbEnfermedad_SelectedIndexChanged);
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEnfermedad.Location = new System.Drawing.Point(384, 38);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(67, 13);
            this.lblEnfermedad.TabIndex = 158;
            this.lblEnfermedad.Text = "Enfermedad:";
            this.lblEnfermedad.Click += new System.EventHandler(this.lblEnfermedad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarEnfermedad);
            this.groupBox1.Controls.Add(this.lblFechafin);
            this.groupBox1.Controls.Add(this.cmbEnfermedad);
            this.groupBox1.Controls.Add(this.txtFechaFin);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.lblEnfermedad);
            this.groupBox1.Controls.Add(this.txtFechaInicio);
            this.groupBox1.Controls.Add(this.btnBuscarPersonal);
            this.groupBox1.Controls.Add(this.cmbPersonal);
            this.groupBox1.Controls.Add(this.lblPersonal);
            this.groupBox1.Location = new System.Drawing.Point(8, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Diagnóstico";
            // 
            // InfHistorialEnfermedades
            // 
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbHembra);
            this.Controls.Add(this.btnBuscarHembra);
            this.Controls.Add(this.lblVaca);
            this.Name = "InfHistorialEnfermedades";
            this.Size = new System.Drawing.Size(684, 93);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.Label lblVaca;
        private System.Windows.Forms.Label lblFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
        private System.Windows.Forms.Label lblFechafin;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbPersonal;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Button btnBuscarEnfermedad;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbEnfermedad;
        private System.Windows.Forms.Label lblEnfermedad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
