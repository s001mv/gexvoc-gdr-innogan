namespace GEXVOC.Informes
{
    partial class InfLibroExplotacion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbExplotacion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarExplotacion = new System.Windows.Forms.Button();
            this.lblExplotacion = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.cmbExplotacion.Location = new System.Drawing.Point(125, 21);
            this.cmbExplotacion.Name = "cmbExplotacion";
            this.cmbExplotacion.PermitirEliminar = true;
            this.cmbExplotacion.PermitirLimpiar = true;
            this.cmbExplotacion.ReadOnly = false;
            this.cmbExplotacion.Size = new System.Drawing.Size(307, 21);
            this.cmbExplotacion.TabIndex = 133;
            this.cmbExplotacion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbExplotacion.ClaseActivaChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs>(this.cmbExplotacion_ClaseActivaChanged);
            // 
            // btnBuscarExplotacion
            // 
            this.btnBuscarExplotacion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarExplotacion.Location = new System.Drawing.Point(438, 21);
            this.btnBuscarExplotacion.Name = "btnBuscarExplotacion";
            this.btnBuscarExplotacion.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarExplotacion.TabIndex = 134;
            this.btnBuscarExplotacion.UseVisualStyleBackColor = true;
            this.btnBuscarExplotacion.Click += new System.EventHandler(this.btnBuscarExplotacion_Click);
            // 
            // lblExplotacion
            // 
            this.lblExplotacion.AutoSize = true;
            this.lblExplotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExplotacion.Location = new System.Drawing.Point(42, 25);
            this.lblExplotacion.Name = "lblExplotacion";
            this.lblExplotacion.Size = new System.Drawing.Size(77, 13);
            this.lblExplotacion.TabIndex = 135;
            this.lblExplotacion.Text = "Explotacion:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(561, 22);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(81, 21);
            this.cmbEspecie.TabIndex = 145;
           // this.cmbEspecie.SelectedIndexChanged += new System.EventHandler(this.cmbEspecie_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(479, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Especie:";
            // 
            // InfLibroExplotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbExplotacion);
            this.Controls.Add(this.btnBuscarExplotacion);
            this.Controls.Add(this.lblExplotacion);
            this.Name = "InfLibroExplotacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbExplotacion;
        private System.Windows.Forms.Button btnBuscarExplotacion;
        private System.Windows.Forms.Label lblExplotacion;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label label5;
    }
}
