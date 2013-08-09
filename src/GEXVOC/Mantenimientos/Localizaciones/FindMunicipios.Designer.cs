namespace GEXVOC.UI
{
    partial class FindMunicipios
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
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbProvincia);
            this.pnlBusqueda.Controls.Add(this.lblProvincia);
            this.pnlBusqueda.Controls.Add(this.txtCodigo);
            this.pnlBusqueda.Controls.Add(this.lblCodigo);
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 85);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 122);
            this.panel1.Size = new System.Drawing.Size(610, 300);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(78, 47);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(204, 21);
            this.cmbProvincia.TabIndex = 25;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblProvincia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProvincia.Location = new System.Drawing.Point(18, 55);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 28;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(78, 22);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(61, 20);
            this.txtCodigo.TabIndex = 23;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCodigo.Location = new System.Drawing.Point(18, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Código:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(367, 47);
            this.txtDescripcion.MaxLength = 80;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 20);
            this.txtDescripcion.TabIndex = 24;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(306, 50);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(55, 13);
            this.lblDescripcion.TabIndex = 26;
            this.lblDescripcion.Text = "Municipio:";
            // 
            // FindMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 300);
            this.Name = "FindMunicipios";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 85);
            this.Text = "Municipios";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}
