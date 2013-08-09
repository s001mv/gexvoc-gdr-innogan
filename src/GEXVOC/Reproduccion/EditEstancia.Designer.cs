namespace GEXVOC.UI
{
    partial class EditEstancia
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
            this.cmbMacho = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblMacho = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.cmbCubricion = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnLanzarCubricion = new System.Windows.Forms.Button();
            this.lblCubricion = new System.Windows.Forms.Label();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMacho
            // 
            this.cmbMacho.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMacho.btnBusqueda = this.btnBuscarAnimal;
            this.cmbMacho.ClaseActiva = null;
            this.cmbMacho.ControlVisible = true;
            this.cmbMacho.DisplayMember = "Nombre";
            this.cmbMacho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbMacho.FormattingEnabled = true;
            this.cmbMacho.IdClaseActiva = 0;
            this.cmbMacho.Location = new System.Drawing.Point(105, 72);
            this.cmbMacho.Name = "cmbMacho";
            this.cmbMacho.PermitirEliminar = true;
            this.cmbMacho.PermitirLimpiar = true;
            this.cmbMacho.ReadOnly = false;
            this.cmbMacho.Size = new System.Drawing.Size(252, 21);
            this.cmbMacho.TabIndex = 2;
            this.cmbMacho.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbMacho.TipoDatos = null;
            this.cmbMacho.ValueMember = "Id";
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(363, 72);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 3;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaIni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaIni.Location = new System.Drawing.Point(22, 104);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(81, 13);
            this.lblFechaIni.TabIndex = 134;
            this.lblFechaIni.Text = "Fecha Inicio:";
            // 
            // lblMacho
            // 
            this.lblMacho.AutoSize = true;
            this.lblMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMacho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMacho.Location = new System.Drawing.Point(22, 76);
            this.lblMacho.Name = "lblMacho";
            this.lblMacho.Size = new System.Drawing.Size(49, 13);
            this.lblMacho.TabIndex = 133;
            this.lblMacho.Text = "Macho:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaFin.Location = new System.Drawing.Point(227, 102);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 139;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // cmbCubricion
            // 
            this.cmbCubricion.BackColor = System.Drawing.SystemColors.Control;
            this.cmbCubricion.btnBusqueda = this.btnLanzarCubricion;
            this.cmbCubricion.ClaseActiva = null;
            this.cmbCubricion.ControlVisible = true;
            this.cmbCubricion.DisplayMember = "FechaInicio";
            this.cmbCubricion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbCubricion.FormattingEnabled = true;
            this.cmbCubricion.IdClaseActiva = 0;
            this.cmbCubricion.Location = new System.Drawing.Point(105, 45);
            this.cmbCubricion.Name = "cmbCubricion";
            this.cmbCubricion.PermitirEliminar = true;
            this.cmbCubricion.PermitirLimpiar = true;
            this.cmbCubricion.ReadOnly = false;
            this.cmbCubricion.Size = new System.Drawing.Size(252, 21);
            this.cmbCubricion.TabIndex = 0;
            this.cmbCubricion.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbCubricion.TipoDatos = null;
            this.cmbCubricion.ValueMember = "Id";
            // 
            // btnLanzarCubricion
            // 
            this.btnLanzarCubricion.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnLanzarCubricion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLanzarCubricion.Location = new System.Drawing.Point(363, 45);
            this.btnLanzarCubricion.Name = "btnLanzarCubricion";
            this.btnLanzarCubricion.Size = new System.Drawing.Size(21, 21);
            this.btnLanzarCubricion.TabIndex = 1;
            this.btnLanzarCubricion.UseVisualStyleBackColor = true;
            // 
            // lblCubricion
            // 
            this.lblCubricion.AutoSize = true;
            this.lblCubricion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCubricion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCubricion.Location = new System.Drawing.Point(22, 49);
            this.lblCubricion.Name = "lblCubricion";
            this.lblCubricion.Size = new System.Drawing.Size(64, 13);
            this.lblCubricion.TabIndex = 142;
            this.lblCubricion.Text = "Cubrición:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(105, 104);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 4;
            this.txtFechaInicio.Value = null;
            //this.txtFechaInicio.ValueChanged += new System.EventHandler<GEXVOC.Core.Controles.ctlFechaEventArgs>(this.txtFechaInicio_ValueChanged);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(296, 102);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 5;
            this.txtFechaFin.Value = null;
            // 
            // EditEstancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(433, 171);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.cmbCubricion);
            this.Controls.Add(this.btnLanzarCubricion);
            this.Controls.Add(this.lblCubricion);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.cmbMacho);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.lblMacho);
            this.Name = "EditEstancia";
            this.Text = "Estancia";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditEstancia_PropiedadAControl);
            this.Controls.SetChildIndex(this.lblMacho, 0);
            this.Controls.SetChildIndex(this.lblFechaIni, 0);
            this.Controls.SetChildIndex(this.btnBuscarAnimal, 0);
            this.Controls.SetChildIndex(this.cmbMacho, 0);
            this.Controls.SetChildIndex(this.lblFechaFin, 0);
            this.Controls.SetChildIndex(this.lblCubricion, 0);
            this.Controls.SetChildIndex(this.btnLanzarCubricion, 0);
            this.Controls.SetChildIndex(this.cmbCubricion, 0);
            this.Controls.SetChildIndex(this.txtFechaInicio, 0);
            this.Controls.SetChildIndex(this.txtFechaFin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbMacho;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblMacho;
        private System.Windows.Forms.Label lblFechaFin;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbCubricion;
        private System.Windows.Forms.Button btnLanzarCubricion;
        private System.Windows.Forms.Label lblCubricion;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
    }
}
