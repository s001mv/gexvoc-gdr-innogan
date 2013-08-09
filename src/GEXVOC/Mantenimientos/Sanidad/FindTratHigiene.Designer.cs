namespace GEXVOC.UI
{
    partial class FindTratHigiene
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
            this.cmbProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbPrograma = new System.Windows.Forms.ComboBox();
            this.lblprograma = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecha);
            this.pnlBusqueda.Controls.Add(this.cmbProducto);
            this.pnlBusqueda.Controls.Add(this.btnBuscarProducto);
            this.pnlBusqueda.Controls.Add(this.lblProducto);
            this.pnlBusqueda.Controls.Add(this.cmbPrograma);
            this.pnlBusqueda.Controls.Add(this.lblprograma);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 124);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 161);
            this.panel1.Size = new System.Drawing.Size(610, 257);
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.SystemColors.Control;
            this.cmbProducto.btnBusqueda = this.btnBuscarProducto;
            this.cmbProducto.ClaseActiva = null;
            this.cmbProducto.ControlVisible = true;
            this.cmbProducto.DisplayMember = "Descripcion";
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IdClaseActiva = 0;
            this.cmbProducto.Location = new System.Drawing.Point(156, 26);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.PermitirEliminar = true;
            this.cmbProducto.PermitirLimpiar = true;
            this.cmbProducto.ReadOnly = false;
            this.cmbProducto.Size = new System.Drawing.Size(255, 21);
            this.cmbProducto.TabIndex = 0;
            this.cmbProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbProducto.TipoDatos = null;
            this.cmbProducto.ValueMember = "Id";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProducto.Location = new System.Drawing.Point(417, 25);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProducto.Location = new System.Drawing.Point(85, 29);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 145;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbPrograma
            // 
            this.cmbPrograma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPrograma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrograma.FormattingEnabled = true;
            this.cmbPrograma.Location = new System.Drawing.Point(156, 53);
            this.cmbPrograma.Name = "cmbPrograma";
            this.cmbPrograma.Size = new System.Drawing.Size(226, 21);
            this.cmbPrograma.TabIndex = 2;
            // 
            // lblprograma
            // 
            this.lblprograma.AutoSize = true;
            this.lblprograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprograma.Location = new System.Drawing.Point(85, 56);
            this.lblprograma.Name = "lblprograma";
            this.lblprograma.Size = new System.Drawing.Size(55, 13);
            this.lblprograma.TabIndex = 144;
            this.lblprograma.Text = "Programa:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(85, 83);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 143;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.HidePromptOnLeave = true;
            this.txtFecha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFecha.Location = new System.Drawing.Point(156, 80);
            this.txtFecha.Mask = "00/00/0099";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // FindTratHigiene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 257);
            this.Name = "FindTratHigiene";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 124);
            this.Text = "Tratamientos Higiene";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbPrograma;
        private System.Windows.Forms.Label lblprograma;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}
