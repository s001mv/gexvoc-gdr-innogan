namespace GEXVOC.Informes
{
    partial class InfAnimalesMuertos
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
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechafin = new System.Windows.Forms.Label();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbLote = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnbuscarLote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(549, 20);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(81, 21);
            this.cmbEspecie.TabIndex = 178;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(485, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 184;
            this.label5.Text = "Especie:";
            // 
            // lblFechafin
            // 
            this.lblFechafin.AutoSize = true;
            this.lblFechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechafin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechafin.Location = new System.Drawing.Point(255, 54);
            this.lblFechafin.Name = "lblFechafin";
            this.lblFechafin.Size = new System.Drawing.Size(60, 13);
            this.lblFechafin.TabIndex = 183;
            this.lblFechafin.Text = "Fecha (fin):";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(321, 51);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 180;
            this.txtFechaFin.Value = null;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaInicio.Location = new System.Drawing.Point(64, 54);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(73, 13);
            this.lblFechaInicio.TabIndex = 182;
            this.lblFechaInicio.Text = "Fecha (inicio):";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(143, 51);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 179;
            this.txtFechaInicio.Value = null;
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
            this.cmbLote.Location = new System.Drawing.Point(143, 20);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.PermitirEliminar = true;
            this.cmbLote.PermitirLimpiar = true;
            this.cmbLote.ReadOnly = false;
            this.cmbLote.Size = new System.Drawing.Size(266, 21);
            this.cmbLote.TabIndex = 176;
            this.cmbLote.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbLote.TipoDatos = null;
            // 
            // btnbuscarLote
            // 
            this.btnbuscarLote.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnbuscarLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnbuscarLote.Location = new System.Drawing.Point(416, 20);
            this.btnbuscarLote.Name = "btnbuscarLote";
            this.btnbuscarLote.Size = new System.Drawing.Size(21, 21);
            this.btnbuscarLote.TabIndex = 177;
            this.btnbuscarLote.UseVisualStyleBackColor = true;
            this.btnbuscarLote.Click += new System.EventHandler(this.btnbuscarLote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(64, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 181;
            this.label2.Text = "Lote:";
            // 
            // InfAnimalesMuertos
            // 
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechafin);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.cmbLote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscarLote);
            this.Name = "InfAnimalesMuertos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechafin;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLote;
        private System.Windows.Forms.Button btnbuscarLote;
        private System.Windows.Forms.Label label2;
    }
}
