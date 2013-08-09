namespace GEXVOC.UI
{
    partial class EditControlLeche
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
            this.txtNoche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManhana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatusControl = new System.Windows.Forms.Label();
            this.lblStatusOrdeno = new System.Windows.Forms.Label();
            this.lblFecInicio = new System.Windows.Forms.Label();
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecControl = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbStatusOrdeno = new GEXVOC.Core.Controles.ctlCombo();
            this.cmbStatusControl = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoche
            // 
            this.txtNoche.Location = new System.Drawing.Point(469, 129);
            this.txtNoche.MaxLength = 20;
            this.txtNoche.Name = "txtNoche";
            this.txtNoche.Size = new System.Drawing.Size(49, 20);
            this.txtNoche.TabIndex = 7;
            this.txtNoche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(381, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Leche Noche:";
            // 
            // txtTarde
            // 
            this.txtTarde.Location = new System.Drawing.Point(469, 103);
            this.txtTarde.MaxLength = 20;
            this.txtTarde.Name = "txtTarde";
            this.txtTarde.Size = new System.Drawing.Size(49, 20);
            this.txtTarde.TabIndex = 6;
            this.txtTarde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(381, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Leche Tarde:";
            // 
            // txtManhana
            // 
            this.txtManhana.Location = new System.Drawing.Point(469, 77);
            this.txtManhana.MaxLength = 20;
            this.txtManhana.Name = "txtManhana";
            this.txtManhana.Size = new System.Drawing.Size(49, 20);
            this.txtManhana.TabIndex = 5;
            this.txtManhana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(381, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Leche Mañana:";
            // 
            // lblStatusControl
            // 
            this.lblStatusControl.AutoSize = true;
            this.lblStatusControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatusControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatusControl.Location = new System.Drawing.Point(9, 106);
            this.lblStatusControl.Name = "lblStatusControl";
            this.lblStatusControl.Size = new System.Drawing.Size(93, 13);
            this.lblStatusControl.TabIndex = 111;
            this.lblStatusControl.Text = "Estado control:";
            // 
            // lblStatusOrdeno
            // 
            this.lblStatusOrdeno.AutoSize = true;
            this.lblStatusOrdeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblStatusOrdeno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatusOrdeno.Location = new System.Drawing.Point(9, 79);
            this.lblStatusOrdeno.Name = "lblStatusOrdeno";
            this.lblStatusOrdeno.Size = new System.Drawing.Size(79, 13);
            this.lblStatusOrdeno.TabIndex = 110;
            this.lblStatusOrdeno.Text = "Estado ordeño:";
            // 
            // lblFecInicio
            // 
            this.lblFecInicio.AutoSize = true;
            this.lblFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio.Location = new System.Drawing.Point(10, 133);
            this.lblFecInicio.Name = "lblFecInicio";
            this.lblFecInicio.Size = new System.Drawing.Size(46, 13);
            this.lblFecInicio.TabIndex = 109;
            this.lblFecInicio.Text = "Fecha:";
            // 
            // cmbHembra
            // 
            this.cmbHembra.BackColor = System.Drawing.SystemColors.Control;
            this.cmbHembra.btnBusqueda = this.btnBuscarHembra;
            this.cmbHembra.ClaseActiva = null;
            this.cmbHembra.ControlVisible = true;
            this.cmbHembra.DisplayMember = "Nombre";
            this.cmbHembra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbHembra.FormattingEnabled = true;
            this.cmbHembra.IdClaseActiva = 0;
            this.cmbHembra.Location = new System.Drawing.Point(108, 49);
            this.cmbHembra.Name = "cmbHembra";
            this.cmbHembra.PermitirEliminar = true;
            this.cmbHembra.PermitirLimpiar = true;
            this.cmbHembra.ReadOnly = false;
            this.cmbHembra.Size = new System.Drawing.Size(168, 21);
            this.cmbHembra.TabIndex = 0;
            this.cmbHembra.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbHembra.TipoDatos = null;
            // 
            // btnBuscarHembra
            // 
            this.btnBuscarHembra.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarHembra.Location = new System.Drawing.Point(286, 49);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 1;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.btnBuscarHembra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "Hembra:";
            // 
            // txtFecControl
            // 
            this.txtFecControl.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecControl.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecControl.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecControl.Location = new System.Drawing.Point(108, 132);
            this.txtFecControl.Name = "txtFecControl";
            this.txtFecControl.ReadOnly = false;
            this.txtFecControl.Size = new System.Drawing.Size(88, 20);
            this.txtFecControl.TabIndex = 4;
            this.txtFecControl.Value = null;
            // 
            // cmbStatusOrdeno
            // 
            this.cmbStatusOrdeno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusOrdeno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatusOrdeno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbStatusOrdeno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbStatusOrdeno.FormattingEnabled = true;
            this.cmbStatusOrdeno.Location = new System.Drawing.Point(108, 76);
            this.cmbStatusOrdeno.Name = "cmbStatusOrdeno";
            this.cmbStatusOrdeno.Size = new System.Drawing.Size(254, 21);
            this.cmbStatusOrdeno.TabIndex = 2;
            this.cmbStatusOrdeno.CargarContenido += new System.EventHandler(this.cmbStatusOrdeno_CargarContenido);
            this.cmbStatusOrdeno.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbStatusOrdeno_CrearNuevo);
            // 
            // cmbStatusControl
            // 
            this.cmbStatusControl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusControl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatusControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbStatusControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbStatusControl.FormattingEnabled = true;
            this.cmbStatusControl.Location = new System.Drawing.Point(108, 103);
            this.cmbStatusControl.Name = "cmbStatusControl";
            this.cmbStatusControl.Size = new System.Drawing.Size(254, 21);
            this.cmbStatusControl.TabIndex = 3;
            this.cmbStatusControl.CargarContenido += new System.EventHandler(this.cmbStatusControl_CargarContenido);
            this.cmbStatusControl.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbStatusControl_CrearNuevo);
            // 
            // EditControlLeche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(536, 195);
            this.Controls.Add(this.cmbStatusControl);
            this.Controls.Add(this.cmbStatusOrdeno);
            this.Controls.Add(this.txtFecControl);
            this.Controls.Add(this.cmbHembra);
            this.Controls.Add(this.btnBuscarHembra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManhana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatusControl);
            this.Controls.Add(this.lblStatusOrdeno);
            this.Controls.Add(this.lblFecInicio);
            this.Name = "EditControlLeche";
            this.Text = "Control Leche";
            this.Controls.SetChildIndex(this.lblFecInicio, 0);
            this.Controls.SetChildIndex(this.lblStatusOrdeno, 0);
            this.Controls.SetChildIndex(this.lblStatusControl, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtManhana, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTarde, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNoche, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnBuscarHembra, 0);
            this.Controls.SetChildIndex(this.cmbHembra, 0);
            this.Controls.SetChildIndex(this.txtFecControl, 0);
            this.Controls.SetChildIndex(this.cmbStatusOrdeno, 0);
            this.Controls.SetChildIndex(this.cmbStatusControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTarde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManhana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusControl;
        private System.Windows.Forms.Label lblStatusOrdeno;
        private System.Windows.Forms.Label lblFecInicio;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.Label label4;
        private GEXVOC.Core.Controles.ctlFecha txtFecControl;
        private GEXVOC.Core.Controles.ctlCombo cmbStatusOrdeno;
        private GEXVOC.Core.Controles.ctlCombo cmbStatusControl;
    }
}
