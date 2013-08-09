namespace GEXVOC.UI
{
    partial class FindCombinacion
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
            this.cmbMarcador1 = new System.Windows.Forms.ComboBox();
            this.lblMarcador2 = new System.Windows.Forms.Label();
            this.cmbMarcador2 = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtGrupo);
            this.pnlBusqueda.Controls.Add(this.lblGrupo);
            this.pnlBusqueda.Controls.Add(this.cmbMarcador2);
            this.pnlBusqueda.Controls.Add(this.lblMarcador2);
            this.pnlBusqueda.Controls.Add(this.cmbMarcador1);
            this.pnlBusqueda.Controls.Add(this.lblMarcador1);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 93);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 130);
            this.panel1.Size = new System.Drawing.Size(610, 288);
            // 
            // lblMarcador1
            // 
            this.lblMarcador1.AutoSize = true;
            this.lblMarcador1.Location = new System.Drawing.Point(29, 33);
            this.lblMarcador1.Name = "lblMarcador1";
            this.lblMarcador1.Size = new System.Drawing.Size(61, 13);
            this.lblMarcador1.TabIndex = 0;
            this.lblMarcador1.Text = "Marcador1:";
            // 
            // cmbMarcador1
            // 
            this.cmbMarcador1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMarcador1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarcador1.FormattingEnabled = true;
            this.cmbMarcador1.Location = new System.Drawing.Point(96, 28);
            this.cmbMarcador1.Name = "cmbMarcador1";
            this.cmbMarcador1.Size = new System.Drawing.Size(158, 21);
            this.cmbMarcador1.TabIndex = 1;
            // 
            // lblMarcador2
            // 
            this.lblMarcador2.AutoSize = true;
            this.lblMarcador2.Location = new System.Drawing.Point(302, 31);
            this.lblMarcador2.Name = "lblMarcador2";
            this.lblMarcador2.Size = new System.Drawing.Size(61, 13);
            this.lblMarcador2.TabIndex = 2;
            this.lblMarcador2.Text = "Marcador2:";
            // 
            // cmbMarcador2
            // 
            this.cmbMarcador2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMarcador2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarcador2.FormattingEnabled = true;
            this.cmbMarcador2.Location = new System.Drawing.Point(379, 28);
            this.cmbMarcador2.Name = "cmbMarcador2";
            this.cmbMarcador2.Size = new System.Drawing.Size(148, 21);
            this.cmbMarcador2.TabIndex = 2;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(32, 58);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 4;
            this.lblGrupo.Text = "Grupo:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(96, 55);
            this.txtGrupo.MaxLength = 5;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(55, 20);
            this.txtGrupo.TabIndex = 3;
            // 
            // FindCombinacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 288);
            this.Name = "FindCombinacion";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 93);
            this.Text = "Combinaciones de Marcadores";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcador1;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cmbMarcador2;
        private System.Windows.Forms.Label lblMarcador2;
        private System.Windows.Forms.ComboBox cmbMarcador1;
    }
}
