namespace GEXVOC.UI
{
    partial class EditCita
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
            this.cmbExplotacion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarExplotacion = new System.Windows.Forms.Button();
            this.lblExplotacion = new System.Windows.Forms.Label();
            this.cmbContacto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.cmbExplotacion.Location = new System.Drawing.Point(119, 40);
            this.cmbExplotacion.Name = "cmbExplotacion";
            this.cmbExplotacion.PermitirEliminar = true;
            this.cmbExplotacion.PermitirLimpiar = true;
            this.cmbExplotacion.ReadOnly = false;
            this.cmbExplotacion.Size = new System.Drawing.Size(229, 21);
            this.cmbExplotacion.TabIndex = 0;
            this.cmbExplotacion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbExplotacion.TipoDatos = null;
            // 
            // btnBuscarExplotacion
            // 
            this.btnBuscarExplotacion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarExplotacion.Location = new System.Drawing.Point(354, 40);
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
            this.lblExplotacion.Location = new System.Drawing.Point(40, 43);
            this.lblExplotacion.Name = "lblExplotacion";
            this.lblExplotacion.Size = new System.Drawing.Size(77, 13);
            this.lblExplotacion.TabIndex = 57;
            this.lblExplotacion.Text = "Explotación:";
            // 
            // cmbContacto
            // 
            this.cmbContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbContacto.btnBusqueda = this.btnBuscarContacto;
            this.cmbContacto.ClaseActiva = null;
            this.cmbContacto.ControlVisible = true;
            this.cmbContacto.DisplayMember = "Nombre";
            this.cmbContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbContacto.FormattingEnabled = true;
            this.cmbContacto.IdClaseActiva = 0;
            this.cmbContacto.Location = new System.Drawing.Point(119, 97);
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.PermitirEliminar = true;
            this.cmbContacto.PermitirLimpiar = true;
            this.cmbContacto.ReadOnly = false;
            this.cmbContacto.Size = new System.Drawing.Size(229, 21);
            this.cmbContacto.TabIndex = 4;
            this.cmbContacto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbContacto.TipoDatos = null;
            this.cmbContacto.CrearNuevo += new System.EventHandler(this.cmbContacto_CrearNuevo);
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarContacto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarContacto.Location = new System.Drawing.Point(354, 97);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarContacto.TabIndex = 5;
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(40, 101);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(53, 13);
            this.lblContacto.TabIndex = 60;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(40, 127);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 63;
            this.lblLugar.Text = "Lugar:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(119, 124);
            this.txtLugar.MaxLength = 100;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(388, 20);
            this.txtLugar.TabIndex = 6;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(40, 157);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(37, 13);
            this.lblTema.TabIndex = 65;
            this.lblTema.Text = "Tema:";
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(119, 150);
            this.txtTema.MaxLength = 255;
            this.txtTema.Multiline = true;
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(388, 89);
            this.txtTema.TabIndex = 7;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHora.Location = new System.Drawing.Point(254, 71);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 141;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(40, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 140;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtHora
            // 
            this.txtHora.HidePromptOnLeave = true;
            this.txtHora.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtHora.Location = new System.Drawing.Point(295, 67);
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
            this.txtFecha.Location = new System.Drawing.Point(119, 67);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.Value = null;
            // 
            // EditCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(550, 281);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.cmbContacto);
            this.Controls.Add(this.btnBuscarContacto);
            this.Controls.Add(this.lblExplotacion);
            this.Controls.Add(this.cmbExplotacion);
            this.Controls.Add(this.btnBuscarExplotacion);
            this.Name = "EditCita";
            this.Text = "Cita";
            this.Controls.SetChildIndex(this.btnBuscarExplotacion, 0);
            this.Controls.SetChildIndex(this.cmbExplotacion, 0);
            this.Controls.SetChildIndex(this.lblExplotacion, 0);
            this.Controls.SetChildIndex(this.btnBuscarContacto, 0);
            this.Controls.SetChildIndex(this.cmbContacto, 0);
            this.Controls.SetChildIndex(this.lblContacto, 0);
            this.Controls.SetChildIndex(this.lblLugar, 0);
            this.Controls.SetChildIndex(this.txtLugar, 0);
            this.Controls.SetChildIndex(this.lblTema, 0);
            this.Controls.SetChildIndex(this.txtTema, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblHora, 0);
            this.Controls.SetChildIndex(this.txtHora, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbExplotacion;
        private System.Windows.Forms.Button btnBuscarExplotacion;
        private System.Windows.Forms.Label lblExplotacion;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbContacto;
        private System.Windows.Forms.Button btnBuscarContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
