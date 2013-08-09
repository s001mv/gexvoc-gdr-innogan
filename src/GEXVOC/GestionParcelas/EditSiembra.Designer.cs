namespace GEXVOC.UI
{
    partial class EditSiembra
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
            this.lblSemilla = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbParcela = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarParcela = new System.Windows.Forms.Button();
            this.cmbSemilla = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarSemilla = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.Location = new System.Drawing.Point(43, 44);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(54, 13);
            this.lblParcela.TabIndex = 2;
            this.lblParcela.Text = "Parcela:";
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.Location = new System.Drawing.Point(43, 79);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(51, 13);
            this.lblSemilla.TabIndex = 3;
            this.lblSemilla.Text = "Semilla:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(337, 49);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(508, 49);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(42, 13);
            this.lblUnidades.TabIndex = 5;
            this.lblUnidades.Text = "Kgs/ha";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(337, 79);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
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
            this.cmbParcela.Location = new System.Drawing.Point(97, 41);
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
            this.btnBuscarParcela.Location = new System.Drawing.Point(268, 41);
            this.btnBuscarParcela.Name = "btnBuscarParcela";
            this.btnBuscarParcela.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarParcela.TabIndex = 1;
            this.btnBuscarParcela.UseVisualStyleBackColor = true;
            this.btnBuscarParcela.Click += new System.EventHandler(this.btnBuscarParcela_Click);
            // 
            // cmbSemilla
            // 
            this.cmbSemilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbSemilla.btnBusqueda = this.btnBuscarSemilla;
            this.cmbSemilla.ClaseActiva = null;
            this.cmbSemilla.ControlVisible = true;
            this.cmbSemilla.DisplayMember = "Descripcion";
            this.cmbSemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbSemilla.FormattingEnabled = true;
            this.cmbSemilla.IdClaseActiva = 0;
            this.cmbSemilla.Location = new System.Drawing.Point(97, 76);
            this.cmbSemilla.Name = "cmbSemilla";
            this.cmbSemilla.PermitirEliminar = true;
            this.cmbSemilla.PermitirLimpiar = true;
            this.cmbSemilla.ReadOnly = false;
            this.cmbSemilla.Size = new System.Drawing.Size(168, 21);
            this.cmbSemilla.TabIndex = 3;
            this.cmbSemilla.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbSemilla.TipoDatos = null;
            
            this.cmbSemilla.CrearNuevo += new System.EventHandler(this.cmbSemilla_CrearNuevo);
            // 
            // btnBuscarSemilla
            // 
            this.btnBuscarSemilla.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarSemilla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarSemilla.Location = new System.Drawing.Point(268, 76);
            this.btnBuscarSemilla.Name = "btnBuscarSemilla";
            this.btnBuscarSemilla.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarSemilla.TabIndex = 4;
            this.btnBuscarSemilla.UseVisualStyleBackColor = true;
            this.btnBuscarSemilla.Click += new System.EventHandler(this.btnBuscarSemilla_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(402, 46);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(402, 76);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.Value = null;
            // 
            // EditSiembra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 146);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbSemilla);
            this.Controls.Add(this.btnBuscarSemilla);
            this.Controls.Add(this.cmbParcela);
            this.Controls.Add(this.btnBuscarParcela);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblUnidades);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblSemilla);
            this.Name = "EditSiembra";
            this.Text = "Sembrado de Parcela";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditSiembra_PropiedadAControl);
            this.Controls.SetChildIndex(this.lblSemilla, 0);
            this.Controls.SetChildIndex(this.lblParcela, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.lblUnidades, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.btnBuscarParcela, 0);
            this.Controls.SetChildIndex(this.cmbParcela, 0);
            this.Controls.SetChildIndex(this.btnBuscarSemilla, 0);
            this.Controls.SetChildIndex(this.cmbSemilla, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblFecha;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbParcela;
        private System.Windows.Forms.Button btnBuscarParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbSemilla;
        private System.Windows.Forms.Button btnBuscarSemilla;
        private System.Windows.Forms.TextBox txtCantidad;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
