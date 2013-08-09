namespace GEXVOC.UI
{
    partial class EditAlimento
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 89);
            this.txtDescripcion.MaxLength = 255;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(240, 20);
            this.txtDescripcion.TabIndex = 117;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(29, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(54, 13);
            this.lblDescripcion.TabIndex = 118;
            this.lblDescripcion.Text = "Nombre:";
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(104, 62);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(240, 21);
            this.cmbFamilia.TabIndex = 115;
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFamilia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFamilia.Location = new System.Drawing.Point(29, 66);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(50, 13);
            this.lblFamilia.TabIndex = 116;
            this.lblFamilia.Text = "Familia:";
            // 
            // EditAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 193);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cmbFamilia);
            this.Controls.Add(this.lblFamilia);
            this.Name = "EditAlimento";
            this.Text = "Alimento";
            this.Controls.SetChildIndex(this.lblFamilia, 0);
            this.Controls.SetChildIndex(this.cmbFamilia, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label lblFamilia;
    }
}