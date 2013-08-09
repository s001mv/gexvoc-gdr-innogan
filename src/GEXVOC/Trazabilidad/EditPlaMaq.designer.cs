namespace GEXVOC.UI
{
    partial class EditPlaMaq
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaquina = new System.Windows.Forms.Label();
            this.cmbMaquina = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquina.Location = new System.Drawing.Point(49, 75);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(59, 13);
            this.lblMaquina.TabIndex = 8;
            this.lblMaquina.Text = "Máquina:";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(125, 72);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(235, 21);
            this.cmbMaquina.TabIndex = 10;
            this.cmbMaquina.CargarContenido += new System.EventHandler(this.cmbMaquina_CargarContenido);
            this.cmbMaquina.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbMaquina_CrearNuevo);
            // 
            // EditPlaMaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(421, 169);
            this.Controls.Add(this.cmbMaquina);
            this.Controls.Add(this.lblMaquina);
            this.Name = "EditPlaMaq";
            this.Text = "Asignación de maquinaria";
            this.Controls.SetChildIndex(this.lblMaquina, 0);
            this.Controls.SetChildIndex(this.cmbMaquina, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaquina;
        private GEXVOC.Core.Controles.ctlCombo cmbMaquina;

    }
}
