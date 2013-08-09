namespace GEXVOC.UI
{
    partial class EditCombinacion
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
            this.lblMarcador1 = new System.Windows.Forms.Label();
            this.lblMarcador2 = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblRiesgo = new System.Windows.Forms.Label();
            this.txtRiesgo = new System.Windows.Forms.TextBox();
            this.cmbMarcador1 = new GEXVOC.Core.Controles.ctlCombo();
            this.cmbMarcador2 = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcador1
            // 
            this.lblMarcador1.AutoSize = true;
            this.lblMarcador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador1.Location = new System.Drawing.Point(41, 59);
            this.lblMarcador1.Name = "lblMarcador1";
            this.lblMarcador1.Size = new System.Drawing.Size(71, 13);
            this.lblMarcador1.TabIndex = 2;
            this.lblMarcador1.Text = "Marcador1:";
            // 
            // lblMarcador2
            // 
            this.lblMarcador2.AutoSize = true;
            this.lblMarcador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador2.Location = new System.Drawing.Point(284, 59);
            this.lblMarcador2.Name = "lblMarcador2";
            this.lblMarcador2.Size = new System.Drawing.Size(71, 13);
            this.lblMarcador2.TabIndex = 4;
            this.lblMarcador2.Text = "Marcador2:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(294, 96);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 6;
            this.lblGrupo.Text = "Grupo:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(361, 89);
            this.txtGrupo.MaxLength = 5;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(66, 20);
            this.txtGrupo.TabIndex = 3;
            // 
            // lblRiesgo
            // 
            this.lblRiesgo.AutoSize = true;
            this.lblRiesgo.Location = new System.Drawing.Point(41, 92);
            this.lblRiesgo.Name = "lblRiesgo";
            this.lblRiesgo.Size = new System.Drawing.Size(43, 13);
            this.lblRiesgo.TabIndex = 8;
            this.lblRiesgo.Text = "Riesgo:";
            // 
            // txtRiesgo
            // 
            this.txtRiesgo.Location = new System.Drawing.Point(118, 89);
            this.txtRiesgo.MaxLength = 35;
            this.txtRiesgo.Name = "txtRiesgo";
            this.txtRiesgo.Size = new System.Drawing.Size(151, 20);
            this.txtRiesgo.TabIndex = 2;
            // 
            // cmbMarcador1
            // 
            this.cmbMarcador1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMarcador1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarcador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbMarcador1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbMarcador1.FormattingEnabled = true;
            this.cmbMarcador1.Location = new System.Drawing.Point(118, 56);
            this.cmbMarcador1.Name = "cmbMarcador1";
            this.cmbMarcador1.Size = new System.Drawing.Size(151, 21);
            this.cmbMarcador1.TabIndex = 0;
            this.cmbMarcador1.CargarContenido += new System.EventHandler(this.cmbMarcador1_CargarContenido);
            this.cmbMarcador1.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbMarcador1_CrearNuevo);
            // 
            // cmbMarcador2
            // 
            this.cmbMarcador2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMarcador2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarcador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbMarcador2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbMarcador2.FormattingEnabled = true;
            this.cmbMarcador2.Location = new System.Drawing.Point(361, 56);
            this.cmbMarcador2.Name = "cmbMarcador2";
            this.cmbMarcador2.Size = new System.Drawing.Size(151, 21);
            this.cmbMarcador2.TabIndex = 1;
            this.cmbMarcador2.CargarContenido += new System.EventHandler(this.cmbMarcador2_CargarContenido);
            this.cmbMarcador2.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbMarcador2_CrearNuevo);
            // 
            // EditCombinacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 194);
            this.Controls.Add(this.cmbMarcador2);
            this.Controls.Add(this.cmbMarcador1);
            this.Controls.Add(this.lblMarcador1);
            this.Controls.Add(this.txtRiesgo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblRiesgo);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.lblMarcador2);
            this.Name = "EditCombinacion";
            this.Text = "Combinación de Marcadores";
            this.Controls.SetChildIndex(this.lblMarcador2, 0);
            this.Controls.SetChildIndex(this.txtGrupo, 0);
            this.Controls.SetChildIndex(this.lblRiesgo, 0);
            this.Controls.SetChildIndex(this.lblGrupo, 0);
            this.Controls.SetChildIndex(this.txtRiesgo, 0);
            this.Controls.SetChildIndex(this.lblMarcador1, 0);
            this.Controls.SetChildIndex(this.cmbMarcador1, 0);
            this.Controls.SetChildIndex(this.cmbMarcador2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcador1;
        private System.Windows.Forms.Label lblMarcador2;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblRiesgo;
        private System.Windows.Forms.TextBox txtRiesgo;
        private GEXVOC.Core.Controles.ctlCombo cmbMarcador1;
        private GEXVOC.Core.Controles.ctlCombo cmbMarcador2;
    }
}
