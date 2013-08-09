namespace GEXVOC.UI
{
    partial class FindRacion
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
            this.lblKg = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.lblKg);
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Controls.Add(this.txtPeso);
            this.pnlBusqueda.Controls.Add(this.lblPeso);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 80);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Size = new System.Drawing.Size(610, 305);
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKg.Location = new System.Drawing.Point(472, 32);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(25, 13);
            this.lblKg.TabIndex = 10;
            this.lblKg.Text = "Kgs";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(96, 29);
            this.txtDescripcion.MaxLength = 60;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(185, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(11, 32);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(382, 29);
            this.txtPeso.MaxLength = 60;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(84, 20);
            this.txtPeso.TabIndex = 8;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPeso.Location = new System.Drawing.Point(337, 32);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 9;
            this.lblPeso.Text = "Peso:";
            // 
            // FindRacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 305);
            this.Name = "FindRacion";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 80);
            this.Text = "Raciones";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
    }
}