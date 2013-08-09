namespace GEXVOC.UI
{
    partial class EditTratHigiene
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
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbPrograma = new System.Windows.Forms.ComboBox();
            this.lblprograma = new System.Windows.Forms.Label();
            this.cmbProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbExplotacion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarExplotacion = new System.Windows.Forms.Button();
            this.lblExplotacion = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(96, 164);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(445, 85);
            this.txtDetalle.TabIndex = 6;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDetalle.Location = new System.Drawing.Point(24, 167);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblDetalle.TabIndex = 14;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(24, 141);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 63;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbPrograma
            // 
            this.cmbPrograma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPrograma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPrograma.FormattingEnabled = true;
            this.cmbPrograma.Location = new System.Drawing.Point(96, 111);
            this.cmbPrograma.Name = "cmbPrograma";
            this.cmbPrograma.Size = new System.Drawing.Size(226, 21);
            this.cmbPrograma.TabIndex = 4;
            // 
            // lblprograma
            // 
            this.lblprograma.AutoSize = true;
            this.lblprograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprograma.Location = new System.Drawing.Point(24, 114);
            this.lblprograma.Name = "lblprograma";
            this.lblprograma.Size = new System.Drawing.Size(55, 13);
            this.lblprograma.TabIndex = 135;
            this.lblprograma.Text = "Programa:";
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
            this.cmbProducto.Location = new System.Drawing.Point(96, 84);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.PermitirEliminar = true;
            this.cmbProducto.PermitirLimpiar = true;
            this.cmbProducto.ReadOnly = false;
            this.cmbProducto.Size = new System.Drawing.Size(255, 21);
            this.cmbProducto.TabIndex = 2;
            this.cmbProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbProducto.TipoDatos = null;
            this.cmbProducto.ValueMember = "Id";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarProducto.Location = new System.Drawing.Point(357, 83);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProducto.Location = new System.Drawing.Point(24, 87);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 138;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbExplotacion
            // 
            this.cmbExplotacion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbExplotacion.btnBusqueda = this.btnBuscarExplotacion;
            this.cmbExplotacion.ClaseActiva = null;
            this.cmbExplotacion.ControlVisible = true;
            this.cmbExplotacion.DisplayMember = "Nombre";
            this.cmbExplotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbExplotacion.Enabled = false;
            this.cmbExplotacion.FormattingEnabled = true;
            this.cmbExplotacion.IdClaseActiva = 0;
            this.cmbExplotacion.Location = new System.Drawing.Point(96, 57);
            this.cmbExplotacion.Name = "cmbExplotacion";
            this.cmbExplotacion.PermitirEliminar = true;
            this.cmbExplotacion.PermitirLimpiar = true;
            this.cmbExplotacion.ReadOnly = false;
            this.cmbExplotacion.Size = new System.Drawing.Size(255, 21);
            this.cmbExplotacion.TabIndex = 0;
            this.cmbExplotacion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbExplotacion.TipoDatos = null;
            this.cmbExplotacion.ValueMember = "Id";
            // 
            // btnBuscarExplotacion
            // 
            this.btnBuscarExplotacion.Enabled = false;
            this.btnBuscarExplotacion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarExplotacion.Location = new System.Drawing.Point(357, 56);
            this.btnBuscarExplotacion.Name = "btnBuscarExplotacion";
            this.btnBuscarExplotacion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarExplotacion.TabIndex = 1;
            this.btnBuscarExplotacion.UseVisualStyleBackColor = true;
            this.btnBuscarExplotacion.Click += new System.EventHandler(this.btnBuscarExplotacion_Click);
            // 
            // lblExplotacion
            // 
            this.lblExplotacion.AutoSize = true;
            this.lblExplotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExplotacion.Location = new System.Drawing.Point(24, 60);
            this.lblExplotacion.Name = "lblExplotacion";
            this.lblExplotacion.Size = new System.Drawing.Size(65, 13);
            this.lblExplotacion.TabIndex = 141;
            this.lblExplotacion.Text = "Explotación:";
            // 
            // txtFecha
            // 
            this.txtFecha.HidePromptOnLeave = true;
            this.txtFecha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFecha.Location = new System.Drawing.Point(96, 138);
            this.txtFecha.Mask = "00/00/0099";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // EditTratHigiene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(560, 316);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmbExplotacion);
            this.Controls.Add(this.btnBuscarExplotacion);
            this.Controls.Add(this.lblExplotacion);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbPrograma);
            this.Controls.Add(this.lblprograma);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Name = "EditTratHigiene";
            this.Text = "Tratamientos Higiene";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditTratHigiene_PropiedadAControl);
            this.Controls.SetChildIndex(this.lblDetalle, 0);
            this.Controls.SetChildIndex(this.txtDetalle, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblprograma, 0);
            this.Controls.SetChildIndex(this.cmbPrograma, 0);
            this.Controls.SetChildIndex(this.lblProducto, 0);
            this.Controls.SetChildIndex(this.btnBuscarProducto, 0);
            this.Controls.SetChildIndex(this.cmbProducto, 0);
            this.Controls.SetChildIndex(this.lblExplotacion, 0);
            this.Controls.SetChildIndex(this.btnBuscarExplotacion, 0);
            this.Controls.SetChildIndex(this.cmbExplotacion, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbPrograma;
        private System.Windows.Forms.Label lblprograma;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblProducto;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbExplotacion;
        private System.Windows.Forms.Button btnBuscarExplotacion;
        private System.Windows.Forms.Label lblExplotacion;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}
