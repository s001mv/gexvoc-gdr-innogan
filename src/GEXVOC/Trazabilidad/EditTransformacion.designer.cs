namespace GEXVOC.UI
{
    partial class EditTransformacion
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
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(163, 56);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(202, 21);
            this.cmbTipoProducto.TabIndex = 4;
            this.cmbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoProducto_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(49, 59);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(108, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(163, 83);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(202, 21);
            this.cmbProducto.TabIndex = 9;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(49, 86);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(62, 13);
            this.lblProducto.TabIndex = 8;
            this.lblProducto.Text = "Producto:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(285, 113);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(20, 13);
            this.lblUnidad.TabIndex = 11;
            this.lblUnidad.Text = "Kg";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(163, 110);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(97, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(49, 113);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // EditTransformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(421, 206);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.lblTipo);
            this.Name = "EditTransformacion";
            this.Text = "Asignación de";
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.cmbTipoProducto, 0);
            this.Controls.SetChildIndex(this.lblProducto, 0);
            this.Controls.SetChildIndex(this.cmbProducto, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.lblUnidad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;

    }
}
