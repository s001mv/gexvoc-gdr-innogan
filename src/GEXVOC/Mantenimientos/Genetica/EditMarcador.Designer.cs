namespace GEXVOC.UI
{
    partial class EditMarcador
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
            this.txtMarcador = new System.Windows.Forms.TextBox();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.cmbTipoAnalisis = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoAnalisis
            // 
            this.lblTipoAnalisis.AutoSize = true;
            this.lblTipoAnalisis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAnalisis.Location = new System.Drawing.Point(24, 70);
            this.lblTipoAnalisis.Name = "lblTipoAnalisis";
            this.lblTipoAnalisis.Size = new System.Drawing.Size(97, 13);
            this.lblTipoAnalisis.TabIndex = 2;
            this.lblTipoAnalisis.Text = "Tipo de Análisis";
            // 
            // txtMarcador
            // 
            this.txtMarcador.Location = new System.Drawing.Point(127, 112);
            this.txtMarcador.MaxLength = 50;
            this.txtMarcador.Name = "txtMarcador";
            this.txtMarcador.Size = new System.Drawing.Size(189, 20);
            this.txtMarcador.TabIndex = 3;
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.Location = new System.Drawing.Point(24, 115);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(64, 13);
            this.lblMarcador.TabIndex = 4;
            this.lblMarcador.Text = "Marcador:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(342, 70);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(56, 13);
            this.lblEspecie.TabIndex = 6;
            this.lblEspecie.Text = "Especie:";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(411, 67);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(139, 21);
            this.cmbEspecie.TabIndex = 2;
            // 
            // cmbTipoAnalisis
            // 
            this.cmbTipoAnalisis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoAnalisis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoAnalisis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbTipoAnalisis.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbTipoAnalisis.FormattingEnabled = true;
            this.cmbTipoAnalisis.Location = new System.Drawing.Point(127, 67);
            this.cmbTipoAnalisis.Name = "cmbTipoAnalisis";
            this.cmbTipoAnalisis.Size = new System.Drawing.Size(189, 21);
            this.cmbTipoAnalisis.TabIndex = 1;
            this.cmbTipoAnalisis.CargarContenido += new System.EventHandler(this.cmbTipoAnalisis_CargarContenido);
            this.cmbTipoAnalisis.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbTipoAnalisis_CrearNuevo);
            // 
            // EditMarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 184);
            this.Controls.Add(this.cmbTipoAnalisis);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblTipoAnalisis);
            this.Controls.Add(this.lblMarcador);
            this.Controls.Add(this.txtMarcador);
            this.Name = "EditMarcador";
            this.Text = "Marcador";
            this.Controls.SetChildIndex(this.txtMarcador, 0);
            this.Controls.SetChildIndex(this.lblMarcador, 0);
            this.Controls.SetChildIndex(this.lblTipoAnalisis, 0);
            this.Controls.SetChildIndex(this.lblEspecie, 0);
            this.Controls.SetChildIndex(this.cmbEspecie, 0);
            this.Controls.SetChildIndex(this.cmbTipoAnalisis, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoAnalisis;
        private System.Windows.Forms.TextBox txtMarcador;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private GEXVOC.Core.Controles.ctlCombo cmbTipoAnalisis;
    }
}
