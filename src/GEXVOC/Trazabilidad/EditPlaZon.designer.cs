namespace GEXVOC.UI
{
    partial class EditPlaZon
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
            this.lblZona = new System.Windows.Forms.Label();
            this.cmbZona = new GEXVOC.Core.Controles.ctlCombo();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(48, 76);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(40, 13);
            this.lblZona.TabIndex = 8;
            this.lblZona.Text = "Zona:";
            // 
            // cmbZona
            // 
            this.cmbZona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbZona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(254)))), ((int)(((byte)(228)))));
            this.cmbZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(118, 73);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(243, 21);
            this.cmbZona.TabIndex = 10;
            this.cmbZona.CargarContenido += new System.EventHandler(this.cmbZona_CargarContenido);
            this.cmbZona.CrearNuevo += new System.EventHandler<GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs>(this.cmbZona_CrearNuevo);
            // 
            // EditPlaZon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(421, 163);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.lblZona);
            this.Name = "EditPlaZon";
            this.Text = "Asignación de zona";
            this.Controls.SetChildIndex(this.lblZona, 0);
            this.Controls.SetChildIndex(this.cmbZona, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZona;
        private GEXVOC.Core.Controles.ctlCombo cmbZona;

    }
}
