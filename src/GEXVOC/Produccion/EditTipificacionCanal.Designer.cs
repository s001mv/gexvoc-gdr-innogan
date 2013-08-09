namespace GEXVOC.UI
{
    partial class EditTipificacionCanal
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
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblConformacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbConformacion = new GEXVOC.Core.Controles.ctlCombo();
            this.cmbCategoria = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(21, 53);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(48, 13);
            this.lblAnimal.TabIndex = 2;
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
            this.cmbAnimal.Location = new System.Drawing.Point(98, 50);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(168, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(270, 49);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblConformacion
            // 
            this.lblConformacion.AutoSize = true;
            this.lblConformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConformacion.Location = new System.Drawing.Point(327, 53);
            this.lblConformacion.Name = "lblConformacion";
            this.lblConformacion.Size = new System.Drawing.Size(88, 13);
            this.lblConformacion.TabIndex = 57;
            this.lblConformacion.Text = "Conformación:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(21, 86);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblCategoria.TabIndex = 59;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(327, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(421, 84);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.Value = null;
            // 
            // cmbConformacion
            // 
            this.cmbConformacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbConformacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbConformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbConformacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbConformacion.FormattingEnabled = true;
            this.cmbConformacion.Location = new System.Drawing.Point(421, 50);
            this.cmbConformacion.Name = "cmbConformacion";
            this.cmbConformacion.Size = new System.Drawing.Size(157, 21);
            this.cmbConformacion.TabIndex = 2;
            this.cmbConformacion.CargarContenido += new System.EventHandler(this.cmbConformacion_CargarContenido);
            this.cmbConformacion.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbConformacion_CrearNuevo);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(98, 83);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(193, 21);
            this.cmbCategoria.TabIndex = 3;
            this.cmbCategoria.CargarContenido += new System.EventHandler(this.cmbCategoria_CargarContenido);
            this.cmbCategoria.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbCategoria_CrearNuevo);
            // 
            // EditTipificacionCanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 168);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbConformacion);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblConformacion);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Name = "EditTipificacionCanal";
            this.Text = "Tipificación de la canal";
            this.PropiedadAControl += new System.EventHandler<GEXVOC.UI.PropiedadBindEventArgs>(this.EditTipificacionCanal_PropiedadAControl);
            this.Controls.SetChildIndex(this.lblAnimal, 0);
            this.Controls.SetChildIndex(this.btnBuscarAnimal, 0);
            this.Controls.SetChildIndex(this.cmbAnimal, 0);
            this.Controls.SetChildIndex(this.lblConformacion, 0);
            this.Controls.SetChildIndex(this.lblCategoria, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.cmbConformacion, 0);
            this.Controls.SetChildIndex(this.cmbCategoria, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblConformacion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFecha;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private GEXVOC.Core.Controles.ctlCombo cmbConformacion;
        private GEXVOC.Core.Controles.ctlCombo cmbCategoria;
    }
}
