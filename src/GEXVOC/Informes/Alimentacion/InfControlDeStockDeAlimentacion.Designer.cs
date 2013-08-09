namespace GEXVOC.Informes
{
    partial class InfControlDeStockDeAlimentacion
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
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.pnlMacho = new System.Windows.Forms.Panel();
            this.lblMacho = new System.Windows.Forms.Label();
            this.cmbMacho = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarMacho = new System.Windows.Forms.Button();
            this.lblFechafin = new System.Windows.Forms.Label();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlProducto.SuspendLayout();
            this.pnlMacho.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFamilia.Enabled = false;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(114, 5);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(270, 21);
            this.cmbFamilia.TabIndex = 12;
            this.cmbFamilia.SelectedValueChanged += new System.EventHandler(this.cmbFamilia_SelectedValueChanged);
            this.cmbFamilia.TextUpdate += new System.EventHandler(this.cmbFamilia_TextUpdate);
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilia.Location = new System.Drawing.Point(17, 8);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(42, 13);
            this.lblFamilia.TabIndex = 15;
            this.lblFamilia.Text = "Familia:";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoProducto.Enabled = false;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(442, 5);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(202, 21);
            this.cmbTipoProducto.TabIndex = 10;
            this.cmbTipoProducto.Visible = false;
            this.cmbTipoProducto.SelectedValueChanged += new System.EventHandler(this.cmbTipoProducto_SelectedValueChanged);
            this.cmbTipoProducto.TextUpdate += new System.EventHandler(this.cmbTipoProducto_TextUpdate);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Enabled = false;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(405, 8);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(31, 13);
            this.lblTipoProducto.TabIndex = 11;
            this.lblTipoProducto.Text = "Tipo:";
            this.lblTipoProducto.Visible = false;
            // 
            // pnlProducto
            // 
            this.pnlProducto.Controls.Add(this.cmbProducto);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Location = new System.Drawing.Point(15, 32);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(407, 28);
            this.pnlProducto.TabIndex = 14;
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(99, 5);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(270, 21);
            this.cmbProducto.TabIndex = 0;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(2, 8);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto:";
            // 
            // pnlMacho
            // 
            this.pnlMacho.Controls.Add(this.lblMacho);
            this.pnlMacho.Controls.Add(this.cmbMacho);
            this.pnlMacho.Controls.Add(this.btnBuscarMacho);
            this.pnlMacho.Enabled = false;
            this.pnlMacho.Location = new System.Drawing.Point(15, 32);
            this.pnlMacho.Name = "pnlMacho";
            this.pnlMacho.Size = new System.Drawing.Size(407, 28);
            this.pnlMacho.TabIndex = 13;
            this.pnlMacho.Visible = false;
            // 
            // lblMacho
            // 
            this.lblMacho.AutoSize = true;
            this.lblMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMacho.Location = new System.Drawing.Point(2, 8);
            this.lblMacho.Name = "lblMacho";
            this.lblMacho.Size = new System.Drawing.Size(43, 13);
            this.lblMacho.TabIndex = 3;
            this.lblMacho.Text = "Macho:";
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
            this.cmbMacho.Location = new System.Drawing.Point(99, 5);
            this.cmbMacho.Name = "cmbMacho";
            this.cmbMacho.PermitirEliminar = true;
            this.cmbMacho.PermitirLimpiar = true;
            this.cmbMacho.ReadOnly = false;
            this.cmbMacho.Size = new System.Drawing.Size(270, 21);
            this.cmbMacho.TabIndex = 7;
            this.cmbMacho.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbMacho.TipoDatos = null;
            // 
            // btnBuscarMacho
            // 
            this.btnBuscarMacho.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarMacho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarMacho.Location = new System.Drawing.Point(375, 5);
            this.btnBuscarMacho.Name = "btnBuscarMacho";
            this.btnBuscarMacho.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarMacho.TabIndex = 0;
            this.btnBuscarMacho.UseVisualStyleBackColor = true;
            this.btnBuscarMacho.Click += new System.EventHandler(this.btnBuscarMacho_Click);
            // 
            // lblFechafin
            // 
            this.lblFechafin.AutoSize = true;
            this.lblFechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechafin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechafin.Location = new System.Drawing.Point(230, 72);
            this.lblFechafin.Name = "lblFechafin";
            this.lblFechafin.Size = new System.Drawing.Size(60, 13);
            this.lblFechafin.TabIndex = 156;
            this.lblFechafin.Text = "Fecha (fin):";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(296, 69);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 154;
            this.txtFechaFin.Value = null;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaInicio.Location = new System.Drawing.Point(17, 72);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(73, 13);
            this.lblFechaInicio.TabIndex = 155;
            this.lblFechaInicio.Text = "Fecha (inicio):";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(114, 69);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 153;
            this.txtFechaInicio.Value = null;
            // 
            // InfControlDeStockDeAlimentacion
            // 
            this.Controls.Add(this.lblFechafin);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.pnlMacho);
            this.Name = "InfControlDeStockDeAlimentacion";
            this.Size = new System.Drawing.Size(684, 97);
            this.pnlProducto.ResumeLayout(false);
            this.pnlProducto.PerformLayout();
            this.pnlMacho.ResumeLayout(false);
            this.pnlMacho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Panel pnlMacho;
        private System.Windows.Forms.Label lblMacho;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbMacho;
        private System.Windows.Forms.Button btnBuscarMacho;
        private System.Windows.Forms.Label lblFechafin;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
    }
}
