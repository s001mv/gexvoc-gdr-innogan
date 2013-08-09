namespace GEXVOC.UI
{
    partial class FindGasto
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNaturaleza = new System.Windows.Forms.ComboBox();
            this.txtFechaHasta = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaDesde = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFechaHasta);
            this.pnlBusqueda.Controls.Add(this.txtFechaDesde);
            this.pnlBusqueda.Controls.Add(this.lblFechaHasta);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.cmbNaturaleza);
            this.pnlBusqueda.Controls.Add(this.label2);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 90);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Size = new System.Drawing.Size(610, 295);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Naturaleza del gasto:";
            // 
            // cmbNaturaleza
            // 
            this.cmbNaturaleza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNaturaleza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNaturaleza.FormattingEnabled = true;
            this.cmbNaturaleza.Location = new System.Drawing.Point(161, 22);
            this.cmbNaturaleza.Name = "cmbNaturaleza";
            this.cmbNaturaleza.Size = new System.Drawing.Size(241, 21);
            this.cmbNaturaleza.TabIndex = 0;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaHasta.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaHasta.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaHasta.Location = new System.Drawing.Point(314, 49);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.ReadOnly = false;
            this.txtFechaHasta.Size = new System.Drawing.Size(88, 20);
            this.txtFechaHasta.TabIndex = 2;
            this.txtFechaHasta.Value = null;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaDesde.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaDesde.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaDesde.Location = new System.Drawing.Point(161, 49);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.ReadOnly = false;
            this.txtFechaDesde.Size = new System.Drawing.Size(88, 20);
            this.txtFechaDesde.TabIndex = 1;
            this.txtFechaDesde.Value = null;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(270, 49);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaHasta.TabIndex = 139;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(44, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 13);
            this.lblFecha.TabIndex = 138;
            this.lblFecha.Text = "Fecha (desde):";
            // 
            // FindGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 295);
            this.Name = "FindGasto";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 90);
            this.Text = "Gastos";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNaturaleza;
        private GEXVOC.Core.Controles.ctlFecha txtFechaHasta;
        private GEXVOC.Core.Controles.ctlFecha txtFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFecha;

    }
}
