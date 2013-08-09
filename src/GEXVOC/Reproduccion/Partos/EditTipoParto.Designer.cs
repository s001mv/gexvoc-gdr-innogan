namespace GEXVOC.UI
{
    partial class EditTipoParto
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
            this.txtCrias = new System.Windows.Forms.TextBox();
            this.lblCrias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(105, 60);
            this.txtDescripcion.MaxLength = 35;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(184, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 63);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Tipo de parto:";
            // 
            // txtCrias
            // 
            this.txtCrias.Location = new System.Drawing.Point(105, 86);
            this.txtCrias.MaxLength = 35;
            this.txtCrias.Name = "txtCrias";
            this.txtCrias.Size = new System.Drawing.Size(64, 20);
            this.txtCrias.TabIndex = 5;
            // 
            // lblCrias
            // 
            this.lblCrias.AutoSize = true;
            this.lblCrias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCrias.Location = new System.Drawing.Point(12, 89);
            this.lblCrias.Name = "lblCrias";
            this.lblCrias.Size = new System.Drawing.Size(33, 13);
            this.lblCrias.TabIndex = 6;
            this.lblCrias.Text = "Crias:";
            // 
            // EditTipoParto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(334, 159);
            this.Controls.Add(this.txtCrias);
            this.Controls.Add(this.lblCrias);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "EditTipoParto";
            this.Text = "Tipo de Parto";
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblCrias, 0);
            this.Controls.SetChildIndex(this.txtCrias, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCrias;
        private System.Windows.Forms.Label lblCrias;
    }
}
