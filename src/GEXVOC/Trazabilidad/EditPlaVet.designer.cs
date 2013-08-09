namespace GEXVOC.UI
{
    partial class EditPlaVet
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
            this.cmbTipoPersonal = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoPersonal
            // 
            this.cmbTipoPersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoPersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoPersonal.FormattingEnabled = true;
            this.cmbTipoPersonal.Location = new System.Drawing.Point(161, 56);
            this.cmbTipoPersonal.Name = "cmbTipoPersonal";
            this.cmbTipoPersonal.Size = new System.Drawing.Size(202, 21);
            this.cmbTipoPersonal.TabIndex = 4;
            this.cmbTipoPersonal.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPersonal_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(49, 59);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(106, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de personal:";
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPersonal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Location = new System.Drawing.Point(161, 83);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(202, 21);
            this.cmbPersonal.TabIndex = 9;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(49, 86);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(66, 13);
            this.lblProducto.TabIndex = 8;
            this.lblProducto.Text = "Empleado:";
            // 
            // EditPlaVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(421, 206);
            this.Controls.Add(this.cmbPersonal);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbTipoPersonal);
            this.Controls.Add(this.lblTipo);
            this.Name = "EditPlaVet";
            this.Text = "Asignación de personal";
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.cmbTipoPersonal, 0);
            this.Controls.SetChildIndex(this.lblProducto, 0);
            this.Controls.SetChildIndex(this.cmbPersonal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoPersonal;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.Label lblProducto;

    }
}
