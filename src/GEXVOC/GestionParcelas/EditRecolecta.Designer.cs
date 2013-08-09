namespace GEXVOC.UI
{
    partial class EditRecolecta
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
            this.lblParcela = new System.Windows.Forms.Label();
            this.cmbParcela = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarParcela = new System.Windows.Forms.Button();
            this.lblForraje = new System.Windows.Forms.Label();
            this.cmbForraje = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarForraje = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.Location = new System.Drawing.Point(12, 46);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(54, 13);
            this.lblParcela.TabIndex = 2;
            this.lblParcela.Text = "Parcela:";
            // 
            // cmbParcela
            // 
            this.cmbParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbParcela.btnBusqueda = this.btnBuscarParcela;
            this.cmbParcela.ClaseActiva = null;
            this.cmbParcela.ControlVisible = true;
            this.cmbParcela.DisplayMember = "Nombre";
            this.cmbParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.IdClaseActiva = 0;
            this.cmbParcela.Location = new System.Drawing.Point(72, 43);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.PermitirEliminar = true;
            this.cmbParcela.PermitirLimpiar = true;
            this.cmbParcela.ReadOnly = false;
            this.cmbParcela.Size = new System.Drawing.Size(168, 21);
            this.cmbParcela.TabIndex = 0;
            this.cmbParcela.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbParcela.TipoDatos = null;
            this.cmbParcela.CrearNuevo += new System.EventHandler(this.cmbParcela_CrearNuevo);
            // 
            // btnBuscarParcela
            // 
            this.btnBuscarParcela.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarParcela.Location = new System.Drawing.Point(243, 43);
            this.btnBuscarParcela.Name = "btnBuscarParcela";
            this.btnBuscarParcela.Size = new System.Drawing.Size(21, 20);
            this.btnBuscarParcela.TabIndex = 1;
            this.btnBuscarParcela.UseVisualStyleBackColor = true;
            this.btnBuscarParcela.Click += new System.EventHandler(this.btnBuscarParcela_Click);
            // 
            // lblForraje
            // 
            this.lblForraje.AutoSize = true;
            this.lblForraje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForraje.Location = new System.Drawing.Point(15, 80);
            this.lblForraje.Name = "lblForraje";
            this.lblForraje.Size = new System.Drawing.Size(55, 13);
            this.lblForraje.TabIndex = 57;
            this.lblForraje.Text = "Alimento";
            // 
            // cmbForraje
            // 
            this.cmbForraje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbForraje.btnBusqueda = this.btnBuscarForraje;
            this.cmbForraje.ClaseActiva = null;
            this.cmbForraje.ControlVisible = true;
            this.cmbForraje.DisplayMember = "Descripcion";
            this.cmbForraje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbForraje.FormattingEnabled = true;
            this.cmbForraje.IdClaseActiva = 0;
            this.cmbForraje.Location = new System.Drawing.Point(72, 77);
            this.cmbForraje.Name = "cmbForraje";
            this.cmbForraje.PermitirEliminar = true;
            this.cmbForraje.PermitirLimpiar = true;
            this.cmbForraje.ReadOnly = false;
            this.cmbForraje.Size = new System.Drawing.Size(168, 21);
            this.cmbForraje.TabIndex = 3;
            this.cmbForraje.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbForraje.TipoDatos = null;
            this.cmbForraje.CrearNuevo += new System.EventHandler(this.cmbForraje_CrearNuevo);
            // 
            // btnBuscarForraje
            // 
            this.btnBuscarForraje.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarForraje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarForraje.Location = new System.Drawing.Point(243, 77);
            this.btnBuscarForraje.Name = "btnBuscarForraje";
            this.btnBuscarForraje.Size = new System.Drawing.Size(21, 20);
            this.btnBuscarForraje.TabIndex = 4;
            this.btnBuscarForraje.UseVisualStyleBackColor = true;
            this.btnBuscarForraje.Click += new System.EventHandler(this.btnBuscarForraje_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(322, 45);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 60;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(390, 45);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(512, 45);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(42, 13);
            this.lblUnidades.TabIndex = 62;
            this.lblUnidades.Text = "Kgs/ha";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(325, 84);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 63;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(390, 80);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.Value = null;
            // 
            // EditRecolecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(576, 155);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbForraje);
            this.Controls.Add(this.btnBuscarForraje);
            this.Controls.Add(this.lblForraje);
            this.Controls.Add(this.cmbParcela);
            this.Controls.Add(this.btnBuscarParcela);
            this.Controls.Add(this.lblParcela);
            this.Name = "EditRecolecta";
            this.Text = "Recolecta";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditRecolecta_PropiedadAControl);
            this.Controls.SetChildIndex(this.lblParcela, 0);
            this.Controls.SetChildIndex(this.btnBuscarParcela, 0);
            this.Controls.SetChildIndex(this.cmbParcela, 0);
            this.Controls.SetChildIndex(this.lblForraje, 0);
            this.Controls.SetChildIndex(this.btnBuscarForraje, 0);
            this.Controls.SetChildIndex(this.cmbForraje, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.lblUnidades, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbParcela;
        private System.Windows.Forms.Button btnBuscarParcela;
        private System.Windows.Forms.Label lblForraje;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbForraje;
        private System.Windows.Forms.Button btnBuscarForraje;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblFecha;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
