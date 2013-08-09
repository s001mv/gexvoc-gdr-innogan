namespace GEXVOC.UI
{
    partial class EditAnalisis
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
            this.lblTipoAnalisis = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarLaboratorio = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.lblFiliaciónCompatible = new System.Windows.Forms.Label();
            this.chkFiliacion = new System.Windows.Forms.CheckBox();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbTipoAnalisis = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoAnalisis
            // 
            this.lblTipoAnalisis.AutoSize = true;
            this.lblTipoAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnalisis.Location = new System.Drawing.Point(20, 69);
            this.lblTipoAnalisis.Name = "lblTipoAnalisis";
            this.lblTipoAnalisis.Size = new System.Drawing.Size(101, 13);
            this.lblTipoAnalisis.TabIndex = 2;
            this.lblTipoAnalisis.Text = "Tipo de Análisis:";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(20, 100);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(48, 13);
            this.lblAnimal.TabIndex = 4;
            this.lblAnimal.Text = "Animal:";
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAnimal.btnBusqueda = this.btnBuscarAnimal;
            this.cmbAnimal.ClaseActiva = null;
            this.cmbAnimal.ControlVisible = true;
            this.cmbAnimal.DisplayMember = "Nombre";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.IdClaseActiva = 0;
            this.cmbAnimal.Location = new System.Drawing.Point(127, 97);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(168, 21);
            this.cmbAnimal.TabIndex = 2;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(301, 97);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 3;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.Location = new System.Drawing.Point(20, 133);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(75, 13);
            this.lblLaboratorio.TabIndex = 57;
            this.lblLaboratorio.Text = "Laboratorio:";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbLaboratorio.btnBusqueda = this.btnBuscarLaboratorio;
            this.cmbLaboratorio.ClaseActiva = null;
            this.cmbLaboratorio.ControlVisible = true;
            this.cmbLaboratorio.DisplayMember = "Nombre";
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.IdClaseActiva = 0;
            this.cmbLaboratorio.Location = new System.Drawing.Point(127, 130);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.PermitirEliminar = true;
            this.cmbLaboratorio.PermitirLimpiar = true;
            this.cmbLaboratorio.ReadOnly = false;
            this.cmbLaboratorio.Size = new System.Drawing.Size(168, 21);
            this.cmbLaboratorio.TabIndex = 5;
            this.cmbLaboratorio.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbLaboratorio.TipoDatos = null;
            this.cmbLaboratorio.CrearNuevo += new System.EventHandler(this.cmbLaboratorio_CrearNuevo);
            // 
            // btnBuscarLaboratorio
            // 
            this.btnBuscarLaboratorio.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarLaboratorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarLaboratorio.Location = new System.Drawing.Point(301, 130);
            this.btnBuscarLaboratorio.Name = "btnBuscarLaboratorio";
            this.btnBuscarLaboratorio.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarLaboratorio.TabIndex = 6;
            this.btnBuscarLaboratorio.UseVisualStyleBackColor = true;
            this.btnBuscarLaboratorio.Click += new System.EventHandler(this.btnBuscarLaboratorio_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(357, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 60;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(357, 101);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(49, 13);
            this.lblRegistro.TabIndex = 62;
            this.lblRegistro.Text = "Registro:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(441, 97);
            this.txtRegistro.MaxLength = 5;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(72, 20);
            this.txtRegistro.TabIndex = 4;
            // 
            // lblFiliaciónCompatible
            // 
            this.lblFiliaciónCompatible.AutoSize = true;
            this.lblFiliaciónCompatible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliaciónCompatible.Location = new System.Drawing.Point(357, 134);
            this.lblFiliaciónCompatible.Name = "lblFiliaciónCompatible";
            this.lblFiliaciónCompatible.Size = new System.Drawing.Size(103, 13);
            this.lblFiliaciónCompatible.TabIndex = 64;
            this.lblFiliaciónCompatible.Text = "Filiación Compatible:";
            // 
            // chkFiliacion
            // 
            this.chkFiliacion.AutoSize = true;
            this.chkFiliacion.Location = new System.Drawing.Point(498, 134);
            this.chkFiliacion.Name = "chkFiliacion";
            this.chkFiliacion.Size = new System.Drawing.Size(15, 14);
            this.chkFiliacion.TabIndex = 7;
            this.chkFiliacion.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(425, 66);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.Value = null;
            // 
            // cmbTipoAnalisis
            // 
            this.cmbTipoAnalisis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoAnalisis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoAnalisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbTipoAnalisis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbTipoAnalisis.FormattingEnabled = true;
            this.cmbTipoAnalisis.Location = new System.Drawing.Point(127, 65);
            this.cmbTipoAnalisis.Name = "cmbTipoAnalisis";
            this.cmbTipoAnalisis.Size = new System.Drawing.Size(195, 21);
            this.cmbTipoAnalisis.TabIndex = 0;
            this.cmbTipoAnalisis.CargarContenido += new System.EventHandler(this.cmbTipoAnalisis_CargarContenido);
            this.cmbTipoAnalisis.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbTipoAnalisis_CrearNuevo);
            // 
            // EditAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(591, 210);
            this.Controls.Add(this.cmbTipoAnalisis);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.chkFiliacion);
            this.Controls.Add(this.lblFiliaciónCompatible);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbLaboratorio);
            this.Controls.Add(this.btnBuscarLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lblTipoAnalisis);
            this.Name = "EditAnalisis";
            this.Text = "Análisis";
            this.Controls.SetChildIndex(this.lblTipoAnalisis, 0);
            this.Controls.SetChildIndex(this.lblAnimal, 0);
            this.Controls.SetChildIndex(this.btnBuscarAnimal, 0);
            this.Controls.SetChildIndex(this.cmbAnimal, 0);
            this.Controls.SetChildIndex(this.lblLaboratorio, 0);
            this.Controls.SetChildIndex(this.btnBuscarLaboratorio, 0);
            this.Controls.SetChildIndex(this.cmbLaboratorio, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblRegistro, 0);
            this.Controls.SetChildIndex(this.txtRegistro, 0);
            this.Controls.SetChildIndex(this.lblFiliaciónCompatible, 0);
            this.Controls.SetChildIndex(this.chkFiliacion, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.cmbTipoAnalisis, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoAnalisis;
        private System.Windows.Forms.Label lblAnimal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblLaboratorio;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbLaboratorio;
        private System.Windows.Forms.Button btnBuscarLaboratorio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label lblFiliaciónCompatible;
        private System.Windows.Forms.CheckBox chkFiliacion;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private GEXVOC.Core.Controles.ctlCombo cmbTipoAnalisis;
    }
}
