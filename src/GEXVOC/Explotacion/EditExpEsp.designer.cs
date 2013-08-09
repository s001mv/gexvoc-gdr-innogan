namespace GEXVOC.UI
{
    partial class EditExpEsp
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
            this.cmbExplotacion = new System.Windows.Forms.ComboBox();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbExplotacion
            // 
            this.cmbExplotacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbExplotacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbExplotacion.FormattingEnabled = true;
            this.cmbExplotacion.Location = new System.Drawing.Point(104, 59);
            this.cmbExplotacion.Name = "cmbExplotacion";
            this.cmbExplotacion.Size = new System.Drawing.Size(247, 21);
            this.cmbExplotacion.TabIndex = 2;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(104, 100);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(247, 21);
            this.cmbEspecie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Explotación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Especie";
            // 
            // EditExpEsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(421, 206);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.cmbExplotacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditExpEsp";
            this.Text = "Asignación de Especies";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbExplotacion, 0);
            this.Controls.SetChildIndex(this.cmbEspecie, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbExplotacion;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
