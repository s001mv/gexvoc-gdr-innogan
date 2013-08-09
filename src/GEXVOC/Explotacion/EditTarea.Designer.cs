namespace GEXVOC.UI
{
    partial class EditTarea
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbExplotacion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarExplotacion = new System.Windows.Forms.Button();
            this.lblExplotacion = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(99, 109);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(380, 49);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(18, 112);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(44, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Tarea:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHora.Location = new System.Drawing.Point(209, 82);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 137;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(18, 82);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 136;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbExplotacion
            // 
            this.cmbExplotacion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbExplotacion.btnBusqueda = this.btnBuscarExplotacion;
            this.cmbExplotacion.ClaseActiva = null;
            this.cmbExplotacion.ControlVisible = true;
            this.cmbExplotacion.DisplayMember = "Nombre";
            this.cmbExplotacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbExplotacion.FormattingEnabled = true;
            this.cmbExplotacion.IdClaseActiva = 0;
            this.cmbExplotacion.Location = new System.Drawing.Point(99, 47);
            this.cmbExplotacion.Name = "cmbExplotacion";
            this.cmbExplotacion.PermitirEliminar = true;
            this.cmbExplotacion.PermitirLimpiar = true;
            this.cmbExplotacion.ReadOnly = false;
            this.cmbExplotacion.Size = new System.Drawing.Size(292, 21);
            this.cmbExplotacion.TabIndex = 0;
            this.cmbExplotacion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbExplotacion.TipoDatos = null;
            // 
            // btnBuscarExplotacion
            // 
            this.btnBuscarExplotacion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarExplotacion.Location = new System.Drawing.Point(397, 47);
            this.btnBuscarExplotacion.Name = "btnBuscarExplotacion";
            this.btnBuscarExplotacion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarExplotacion.TabIndex = 1;
            this.btnBuscarExplotacion.UseVisualStyleBackColor = true;
            this.btnBuscarExplotacion.Click += new System.EventHandler(this.btnBuscarExplotacion_Click);
            // 
            // lblExplotacion
            // 
            this.lblExplotacion.AutoSize = true;
            this.lblExplotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplotacion.Location = new System.Drawing.Point(18, 50);
            this.lblExplotacion.Name = "lblExplotacion";
            this.lblExplotacion.Size = new System.Drawing.Size(77, 13);
            this.lblExplotacion.TabIndex = 140;
            this.lblExplotacion.Text = "Explotación:";
            // 
            // txtHora
            // 
            this.txtHora.HidePromptOnLeave = true;
            this.txtHora.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtHora.Location = new System.Drawing.Point(248, 79);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(53, 20);
            this.txtHora.TabIndex = 3;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(99, 79);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.Value = null;
            // 
            // EditTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(502, 194);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.cmbExplotacion);
            this.Controls.Add(this.btnBuscarExplotacion);
            this.Controls.Add(this.lblExplotacion);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "EditTarea";
            this.Text = "Tarea";
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblHora, 0);
            this.Controls.SetChildIndex(this.lblExplotacion, 0);
            this.Controls.SetChildIndex(this.btnBuscarExplotacion, 0);
            this.Controls.SetChildIndex(this.cmbExplotacion, 0);
            this.Controls.SetChildIndex(this.txtHora, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbExplotacion;
        private System.Windows.Forms.Button btnBuscarExplotacion;
        private System.Windows.Forms.Label lblExplotacion;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
