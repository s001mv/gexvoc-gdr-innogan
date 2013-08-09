namespace GEXVOC.UI
{
    partial class EditGasto
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
            this.lblNaturaleza = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblParcela = new System.Windows.Forms.Label();
            this.cmbParcela = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnParcela = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnBuscarTratamiento = new System.Windows.Forms.Button();
            this.cmbTratamiento = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbReceta = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblReceta = new System.Windows.Forms.Label();
            this.pnlReceta = new System.Windows.Forms.Panel();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbNaturaleza = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlReceta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaturaleza
            // 
            this.lblNaturaleza.AutoSize = true;
            this.lblNaturaleza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaturaleza.Location = new System.Drawing.Point(26, 44);
            this.lblNaturaleza.Name = "lblNaturaleza";
            this.lblNaturaleza.Size = new System.Drawing.Size(128, 13);
            this.lblNaturaleza.TabIndex = 57;
            this.lblNaturaleza.Text = "Naturaleza del gasto:";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(25, 97);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(41, 13);
            this.lblAnimal.TabIndex = 59;
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
            this.cmbAnimal.Location = new System.Drawing.Point(104, 95);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(168, 21);
            this.cmbAnimal.TabIndex = 3;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(278, 96);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 4;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(327, 100);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(46, 13);
            this.lblParcela.TabIndex = 62;
            this.lblParcela.Text = "Parcela:";
            // 
            // cmbParcela
            // 
            this.cmbParcela.BackColor = System.Drawing.SystemColors.Control;
            this.cmbParcela.btnBusqueda = this.btnParcela;
            this.cmbParcela.ClaseActiva = null;
            this.cmbParcela.ControlVisible = true;
            this.cmbParcela.DisplayMember = "Nombre";
            this.cmbParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbParcela.FormattingEnabled = true;
            this.cmbParcela.IdClaseActiva = 0;
            this.cmbParcela.Location = new System.Drawing.Point(457, 95);
            this.cmbParcela.Name = "cmbParcela";
            this.cmbParcela.PermitirEliminar = true;
            this.cmbParcela.PermitirLimpiar = true;
            this.cmbParcela.ReadOnly = false;
            this.cmbParcela.Size = new System.Drawing.Size(224, 21);
            this.cmbParcela.TabIndex = 5;
            this.cmbParcela.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbParcela.TipoDatos = null;
            // 
            // btnParcela
            // 
            this.btnParcela.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnParcela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnParcela.Location = new System.Drawing.Point(687, 94);
            this.btnParcela.Name = "btnParcela";
            this.btnParcela.Size = new System.Drawing.Size(21, 21);
            this.btnParcela.TabIndex = 6;
            this.btnParcela.UseVisualStyleBackColor = true;
            this.btnParcela.Click += new System.EventHandler(this.btnParcela_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(25, 157);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblDetalle.TabIndex = 65;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(455, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 66;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(26, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 13);
            this.lblTotal.TabIndex = 68;
            this.lblTotal.Text = "Importe Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(160, 67);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(84, 20);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(104, 154);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(604, 81);
            this.txtDetalle.TabIndex = 10;
            // 
            // btnBuscarTratamiento
            // 
            this.btnBuscarTratamiento.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarTratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarTratamiento.Location = new System.Drawing.Point(278, 122);
            this.btnBuscarTratamiento.Name = "btnBuscarTratamiento";
            this.btnBuscarTratamiento.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarTratamiento.TabIndex = 8;
            this.btnBuscarTratamiento.UseVisualStyleBackColor = true;
            this.btnBuscarTratamiento.Click += new System.EventHandler(this.btnBuscarTratamiento_Click);
            // 
            // cmbTratamiento
            // 
            this.cmbTratamiento.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTratamiento.btnBusqueda = this.btnBuscarTratamiento;
            this.cmbTratamiento.ClaseActiva = null;
            this.cmbTratamiento.ControlVisible = true;
            this.cmbTratamiento.DisplayMember = "Descripcion";
            this.cmbTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTratamiento.FormattingEnabled = true;
            this.cmbTratamiento.IdClaseActiva = 0;
            this.cmbTratamiento.Location = new System.Drawing.Point(104, 122);
            this.cmbTratamiento.Name = "cmbTratamiento";
            this.cmbTratamiento.PermitirEliminar = true;
            this.cmbTratamiento.PermitirLimpiar = true;
            this.cmbTratamiento.ReadOnly = false;
            this.cmbTratamiento.Size = new System.Drawing.Size(168, 21);
            this.cmbTratamiento.TabIndex = 7;
            this.cmbTratamiento.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbTratamiento.TipoDatos = null;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTratamiento.Location = new System.Drawing.Point(25, 125);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(66, 13);
            this.lblTratamiento.TabIndex = 129;
            this.lblTratamiento.Text = "Tratamiento:";
            // 
            // button1
            // 
            this.button1.Image = global::GEXVOC.Properties.Resources.buscar;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(372, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbReceta
            // 
            this.cmbReceta.BackColor = System.Drawing.SystemColors.Control;
            this.cmbReceta.btnBusqueda = this.button1;
            this.cmbReceta.ClaseActiva = null;
            this.cmbReceta.ControlVisible = true;
            this.cmbReceta.DisplayMember = "DescIdentificacion";
            this.cmbReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbReceta.FormattingEnabled = true;
            this.cmbReceta.IdClaseActiva = 0;
            this.cmbReceta.Location = new System.Drawing.Point(143, 1);
            this.cmbReceta.Name = "cmbReceta";
            this.cmbReceta.PermitirEliminar = true;
            this.cmbReceta.PermitirLimpiar = true;
            this.cmbReceta.ReadOnly = false;
            this.cmbReceta.Size = new System.Drawing.Size(223, 21);
            this.cmbReceta.TabIndex = 0;
            this.cmbReceta.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbReceta.TipoDatos = null;
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblReceta.Location = new System.Drawing.Point(12, 5);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(45, 13);
            this.lblReceta.TabIndex = 132;
            this.lblReceta.Text = "Receta:";
            // 
            // pnlReceta
            // 
            this.pnlReceta.Controls.Add(this.button1);
            this.pnlReceta.Controls.Add(this.cmbReceta);
            this.pnlReceta.Controls.Add(this.lblReceta);
            this.pnlReceta.Enabled = false;
            this.pnlReceta.Location = new System.Drawing.Point(315, 121);
            this.pnlReceta.Name = "pnlReceta";
            this.pnlReceta.Size = new System.Drawing.Size(421, 22);
            this.pnlReceta.TabIndex = 9;
            this.pnlReceta.Visible = false;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(511, 40);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.Value = null;
            // 
            // cmbNaturaleza
            // 
            this.cmbNaturaleza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNaturaleza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNaturaleza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbNaturaleza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbNaturaleza.FormattingEnabled = true;
            this.cmbNaturaleza.Location = new System.Drawing.Point(160, 41);
            this.cmbNaturaleza.Name = "cmbNaturaleza";
            this.cmbNaturaleza.Size = new System.Drawing.Size(267, 21);
            this.cmbNaturaleza.TabIndex = 0;
            this.cmbNaturaleza.CargarContenido += new System.EventHandler(this.cmbNaturaleza_CargarContenido);
            this.cmbNaturaleza.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbNaturaleza_CrearNuevo);
            // 
            // EditGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(733, 274);
            this.Controls.Add(this.cmbNaturaleza);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.pnlReceta);
            this.Controls.Add(this.btnBuscarTratamiento);
            this.Controls.Add(this.cmbTratamiento);
            this.Controls.Add(this.lblTratamiento);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.cmbParcela);
            this.Controls.Add(this.btnParcela);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lblNaturaleza);
            this.Name = "EditGasto";
            this.Text = "Gasto";
            this.Controls.SetChildIndex(this.lblNaturaleza, 0);
            this.Controls.SetChildIndex(this.lblAnimal, 0);
            this.Controls.SetChildIndex(this.btnBuscarAnimal, 0);
            this.Controls.SetChildIndex(this.cmbAnimal, 0);
            this.Controls.SetChildIndex(this.lblParcela, 0);
            this.Controls.SetChildIndex(this.btnParcela, 0);
            this.Controls.SetChildIndex(this.cmbParcela, 0);
            this.Controls.SetChildIndex(this.lblDetalle, 0);
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.txtDetalle, 0);
            this.Controls.SetChildIndex(this.lblTratamiento, 0);
            this.Controls.SetChildIndex(this.cmbTratamiento, 0);
            this.Controls.SetChildIndex(this.btnBuscarTratamiento, 0);
            this.Controls.SetChildIndex(this.pnlReceta, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.cmbNaturaleza, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlReceta.ResumeLayout(false);
            this.pnlReceta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaturaleza;
        private System.Windows.Forms.Label lblAnimal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblParcela;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbParcela;
        private System.Windows.Forms.Button btnParcela;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnBuscarTratamiento;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.Button button1;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbReceta;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.Panel pnlReceta;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private GEXVOC.Core.Controles.ctlCombo cmbNaturaleza;

    }
}
