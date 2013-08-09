namespace GEXVOC.UI
{
    partial class EditProHig
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
            this.cmbTratamiento = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarTratamiento = new System.Windows.Forms.Button();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnBuscarMedicamento = new System.Windows.Forms.Button();
            this.cmbProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTratamiento
            // 
            this.cmbTratamiento.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTratamiento.btnBusqueda = this.btnBuscarTratamiento;
            this.cmbTratamiento.ClaseActiva = null;
            this.cmbTratamiento.ControlVisible = true;
            this.cmbTratamiento.DisplayMember = "DescTratHigiene";
            this.cmbTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTratamiento.FormattingEnabled = true;
            this.cmbTratamiento.IdClaseActiva = 0;
            this.cmbTratamiento.Location = new System.Drawing.Point(137, 44);
            this.cmbTratamiento.Name = "cmbTratamiento";
            this.cmbTratamiento.PermitirEliminar = true;
            this.cmbTratamiento.PermitirLimpiar = true;
            this.cmbTratamiento.ReadOnly = false;
            this.cmbTratamiento.Size = new System.Drawing.Size(248, 21);
            this.cmbTratamiento.TabIndex = 0;
            this.cmbTratamiento.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbTratamiento.TipoDatos = null;
            // 
            // btnBuscarTratamiento
            // 
            this.btnBuscarTratamiento.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarTratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarTratamiento.Location = new System.Drawing.Point(391, 44);
            this.btnBuscarTratamiento.Name = "btnBuscarTratamiento";
            this.btnBuscarTratamiento.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarTratamiento.TabIndex = 1;
            this.btnBuscarTratamiento.UseVisualStyleBackColor = true;
            this.btnBuscarTratamiento.Click += new System.EventHandler(this.btnBuscarTratamiento_Click);
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.Location = new System.Drawing.Point(38, 47);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(66, 13);
            this.lblTratamiento.TabIndex = 71;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(137, 98);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(38, 101);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 73;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnBuscarMedicamento
            // 
            this.btnBuscarMedicamento.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarMedicamento.Location = new System.Drawing.Point(391, 70);
            this.btnBuscarMedicamento.Name = "btnBuscarMedicamento";
            this.btnBuscarMedicamento.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarMedicamento.TabIndex = 3;
            this.btnBuscarMedicamento.UseVisualStyleBackColor = true;
            this.btnBuscarMedicamento.Click += new System.EventHandler(this.btnBuscarMedicamento_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbProducto.btnBusqueda = this.btnBuscarMedicamento;
            this.cmbProducto.ClaseActiva = null;
            this.cmbProducto.ControlVisible = true;
            this.cmbProducto.DisplayMember = "DescAmpliada";
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IdClaseActiva = 0;
            this.cmbProducto.Location = new System.Drawing.Point(137, 71);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.PermitirEliminar = true;
            this.cmbProducto.PermitirLimpiar = true;
            this.cmbProducto.ReadOnly = false;
            this.cmbProducto.Size = new System.Drawing.Size(248, 21);
            this.cmbProducto.TabIndex = 2;
            this.cmbProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbProducto.TipoDatos = null;
            this.cmbProducto.CrearNuevo += new System.EventHandler(this.cmbProducto_CrearNuevo);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(38, 74);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 151;
            this.lblProducto.Text = "Producto:";
            // 
            // EditProHig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(481, 160);
            this.Controls.Add(this.btnBuscarMedicamento);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbTratamiento);
            this.Controls.Add(this.btnBuscarTratamiento);
            this.Controls.Add(this.lblTratamiento);
            this.Name = "EditProHig";
            this.Text = "Asociar Producto a Tratamiento de Higiene";
            this.Controls.SetChildIndex(this.lblTratamiento, 0);
            this.Controls.SetChildIndex(this.btnBuscarTratamiento, 0);
            this.Controls.SetChildIndex(this.cmbTratamiento, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.lblProducto, 0);
            this.Controls.SetChildIndex(this.cmbProducto, 0);
            this.Controls.SetChildIndex(this.btnBuscarMedicamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbTratamiento;
        private System.Windows.Forms.Button btnBuscarTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnBuscarMedicamento;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbProducto;
        private System.Windows.Forms.Label lblProducto;
    }
}
