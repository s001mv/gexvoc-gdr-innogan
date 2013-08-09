namespace GEXVOC.Informes
{
    partial class InfProlificidad
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
            this.lblFechafin = new System.Windows.Forms.Label();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.grpFiltroPrincipal = new System.Windows.Forms.GroupBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.cmbLote = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnbuscarLote = new System.Windows.Forms.Button();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtAnimal = new System.Windows.Forms.RadioButton();
            this.rbtLote = new System.Windows.Forms.RadioButton();
            this.rbtEspecie = new System.Windows.Forms.RadioButton();
            this.grpFiltroPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechafin
            // 
            this.lblFechafin.AutoSize = true;
            this.lblFechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechafin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechafin.Location = new System.Drawing.Point(308, 63);
            this.lblFechafin.Name = "lblFechafin";
            this.lblFechafin.Size = new System.Drawing.Size(60, 13);
            this.lblFechafin.TabIndex = 192;
            this.lblFechafin.Text = "Fecha (fin):";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(374, 60);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 189;
            this.txtFechaFin.Value = null;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaInicio.Location = new System.Drawing.Point(89, 63);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(73, 13);
            this.lblFechaInicio.TabIndex = 191;
            this.lblFechaInicio.Text = "Fecha (inicio):";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(168, 60);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 188;
            this.txtFechaInicio.Value = null;
            // 
            // grpFiltroPrincipal
            // 
            this.grpFiltroPrincipal.Controls.Add(this.cmbEspecie);
            this.grpFiltroPrincipal.Controls.Add(this.cmbLote);
            this.grpFiltroPrincipal.Controls.Add(this.cmbAnimal);
            this.grpFiltroPrincipal.Controls.Add(this.btnBuscarAnimal);
            this.grpFiltroPrincipal.Controls.Add(this.btnbuscarLote);
            this.grpFiltroPrincipal.Controls.Add(this.lblAnimal);
            this.grpFiltroPrincipal.Controls.Add(this.label2);
            this.grpFiltroPrincipal.Controls.Add(this.label5);
            this.grpFiltroPrincipal.Controls.Add(this.rbtAnimal);
            this.grpFiltroPrincipal.Controls.Add(this.rbtLote);
            this.grpFiltroPrincipal.Controls.Add(this.rbtEspecie);
            this.grpFiltroPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpFiltroPrincipal.Location = new System.Drawing.Point(3, 1);
            this.grpFiltroPrincipal.Name = "grpFiltroPrincipal";
            this.grpFiltroPrincipal.Size = new System.Drawing.Size(678, 45);
            this.grpFiltroPrincipal.TabIndex = 196;
            this.grpFiltroPrincipal.TabStop = false;
            this.grpFiltroPrincipal.Text = "Filtro principal:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(591, 17);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(81, 21);
            this.cmbEspecie.TabIndex = 187;
            // 
            // cmbLote
            // 
            this.cmbLote.BackColor = System.Drawing.SystemColors.Control;
            this.cmbLote.btnBusqueda = this.btnbuscarLote;
            this.cmbLote.ClaseActiva = null;
            this.cmbLote.ControlVisible = true;
            this.cmbLote.DisplayMember = "Descripcion";
            this.cmbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.IdClaseActiva = 0;
            this.cmbLote.Location = new System.Drawing.Point(325, 17);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.PermitirEliminar = true;
            this.cmbLote.PermitirLimpiar = true;
            this.cmbLote.ReadOnly = false;
            this.cmbLote.Size = new System.Drawing.Size(172, 21);
            this.cmbLote.TabIndex = 185;
            this.cmbLote.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbLote.TipoDatos = null;
            // 
            // btnbuscarLote
            // 
            this.btnbuscarLote.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnbuscarLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnbuscarLote.Location = new System.Drawing.Point(499, 17);
            this.btnbuscarLote.Name = "btnbuscarLote";
            this.btnbuscarLote.Size = new System.Drawing.Size(21, 21);
            this.btnbuscarLote.TabIndex = 186;
            this.btnbuscarLote.UseVisualStyleBackColor = true;
            this.btnbuscarLote.Click += new System.EventHandler(this.btnbuscarLote_Click);
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAnimal.btnBusqueda = this.btnBuscarAnimal;
            this.cmbAnimal.ClaseActiva = null;
            this.cmbAnimal.ControlVisible = true;
            this.cmbAnimal.DisplayMember = "Nombre";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.IdClaseActiva = 0;
            this.cmbAnimal.Location = new System.Drawing.Point(89, 17);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(149, 21);
            this.cmbAnimal.TabIndex = 191;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(241, 17);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 192;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(3, 50);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(57, 13);
            this.lblAnimal.TabIndex = 193;
            this.lblAnimal.Text = "Animal/es:";
            this.lblAnimal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(279, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 189;
            this.label2.Text = "Lote:";
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(529, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 190;
            this.label5.Text = "Especie:";
            this.label5.Visible = false;
            // 
            // rbtAnimal
            // 
            this.rbtAnimal.AutoSize = true;
            this.rbtAnimal.Location = new System.Drawing.Point(21, 17);
            this.rbtAnimal.Name = "rbtAnimal";
            this.rbtAnimal.Size = new System.Drawing.Size(70, 17);
            this.rbtAnimal.TabIndex = 194;
            this.rbtAnimal.Text = "Animales:";
            this.rbtAnimal.UseVisualStyleBackColor = true;
            this.rbtAnimal.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // rbtLote
            // 
            this.rbtLote.AutoSize = true;
            this.rbtLote.Location = new System.Drawing.Point(277, 17);
            this.rbtLote.Name = "rbtLote";
            this.rbtLote.Size = new System.Drawing.Size(49, 17);
            this.rbtLote.TabIndex = 195;
            this.rbtLote.Text = "Lote:";
            this.rbtLote.UseVisualStyleBackColor = true;
            this.rbtLote.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // rbtEspecie
            // 
            this.rbtEspecie.AutoSize = true;
            this.rbtEspecie.Location = new System.Drawing.Point(529, 17);
            this.rbtEspecie.Name = "rbtEspecie";
            this.rbtEspecie.Size = new System.Drawing.Size(66, 17);
            this.rbtEspecie.TabIndex = 196;
            this.rbtEspecie.Text = "Especie:";
            this.rbtEspecie.UseVisualStyleBackColor = true;
            this.rbtEspecie.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // InfProlificidad
            // 
            this.Controls.Add(this.grpFiltroPrincipal);
            this.Controls.Add(this.lblFechafin);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtFechaInicio);
            this.Name = "InfProlificidad";
            this.grpFiltroPrincipal.ResumeLayout(false);
            this.grpFiltroPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechafin;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
        private System.Windows.Forms.GroupBox grpFiltroPrincipal;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLote;
        private System.Windows.Forms.Button btnbuscarLote;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtAnimal;
        private System.Windows.Forms.RadioButton rbtLote;
        private System.Windows.Forms.RadioButton rbtEspecie;
    }
}
