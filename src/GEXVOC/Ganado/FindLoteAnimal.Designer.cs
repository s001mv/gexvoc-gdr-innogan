namespace GEXVOC.UI
{
    partial class FindLoteAnimal
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SubBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnAnimales = new System.Windows.Forms.ToolStripButton();
            this.btnCubriciones = new System.Windows.Forms.ToolStripButton();
            this.cmbTipoLote = new System.Windows.Forms.ComboBox();
            this.lblTipoLote = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SubBarraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.cmbTipoLote);
            this.pnlBusqueda.Controls.Add(this.lblTipoLote);
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Location = new System.Drawing.Point(12, 53);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 99);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 158);
            this.panel1.Size = new System.Drawing.Size(610, 260);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(118, 28);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(307, 20);
            this.txtDescripcion.TabIndex = 141;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescripcion.Location = new System.Drawing.Point(32, 31);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 142;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // SubBarraHerramientas
            // 
            this.SubBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAnimales,
            this.btnCubriciones});
            this.SubBarraHerramientas.Location = new System.Drawing.Point(0, 25);
            this.SubBarraHerramientas.Name = "SubBarraHerramientas";
            this.SubBarraHerramientas.Size = new System.Drawing.Size(634, 25);
            this.SubBarraHerramientas.TabIndex = 163;
            // 
            // btnAnimales
            // 
            this.btnAnimales.Image = global::GEXVOC.Properties.Resources.info;
            this.btnAnimales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(69, 22);
            this.btnAnimales.Text = "Animales";
            this.btnAnimales.ToolTipText = "Ver Animales";
            this.btnAnimales.Click += new System.EventHandler(this.botones_Click);
            // 
            // btnCubriciones
            // 
            this.btnCubriciones.Image = global::GEXVOC.Properties.Resources.info;
            this.btnCubriciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCubriciones.Name = "btnCubriciones";
            this.btnCubriciones.Size = new System.Drawing.Size(82, 22);
            this.btnCubriciones.Text = "Cubriciones";
            this.btnCubriciones.ToolTipText = "Ver Cubriciones";
            this.btnCubriciones.Click += new System.EventHandler(this.botones_Click);
            // 
            // cmbTipoLote
            // 
            this.cmbTipoLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoLote.FormattingEnabled = true;
            this.cmbTipoLote.Location = new System.Drawing.Point(118, 54);
            this.cmbTipoLote.Name = "cmbTipoLote";
            this.cmbTipoLote.Size = new System.Drawing.Size(239, 21);
            this.cmbTipoLote.TabIndex = 165;
            // 
            // lblTipoLote
            // 
            this.lblTipoLote.AutoSize = true;
            this.lblTipoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipoLote.Location = new System.Drawing.Point(32, 57);
            this.lblTipoLote.Name = "lblTipoLote";
            this.lblTipoLote.Size = new System.Drawing.Size(55, 13);
            this.lblTipoLote.TabIndex = 166;
            this.lblTipoLote.Text = "Tipo Lote:";
            // 
            // FindLoteAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.SubBarraHerramientas);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 260);
            this.Name = "FindLoteAnimal";
            this.pnlBusquedaPosicion = new System.Drawing.Point(12, 53);
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 99);
            this.Text = "Lotes Animales";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.SubBarraHerramientas, 0);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.SubBarraHerramientas.ResumeLayout(false);
            this.SubBarraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ToolStrip SubBarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnAnimales;
        private System.Windows.Forms.ToolStripButton btnCubriciones;
        private System.Windows.Forms.ComboBox cmbTipoLote;
        private System.Windows.Forms.Label lblTipoLote;
    }
}
