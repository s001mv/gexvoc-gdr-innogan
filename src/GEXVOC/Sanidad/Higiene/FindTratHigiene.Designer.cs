namespace GEXVOC.UI
{
    partial class FindTratHigiene
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
            this.lblPlan = new System.Windows.Forms.Label();
            this.cmbPlanHigiene = new System.Windows.Forms.ComboBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFechaFin);
            this.pnlBusqueda.Controls.Add(this.txtFechaInicio);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Controls.Add(this.txtDetalle);
            this.pnlBusqueda.Controls.Add(this.lblDetalle);
            this.pnlBusqueda.Controls.Add(this.cmbPlanHigiene);
            this.pnlBusqueda.Controls.Add(this.lblPlan);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 130);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Size = new System.Drawing.Size(610, 251);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(54, 33);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(82, 13);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Plan de Higiene";
            // 
            // cmbPlanHigiene
            // 
            this.cmbPlanHigiene.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPlanHigiene.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlanHigiene.FormattingEnabled = true;
            this.cmbPlanHigiene.Location = new System.Drawing.Point(155, 30);
            this.cmbPlanHigiene.Name = "cmbPlanHigiene";
            this.cmbPlanHigiene.Size = new System.Drawing.Size(167, 21);
            this.cmbPlanHigiene.TabIndex = 0;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(54, 56);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 7;
            this.lblDetalle.Text = "Detalle";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(155, 56);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(400, 20);
            this.txtDetalle.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(54, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(68, 13);
            this.lblFecha.TabIndex = 62;
            this.lblFecha.Text = "Fecha Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Fecha Fin:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(155, 82);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 2;
            this.txtFechaInicio.Value = null;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(319, 82);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 3;
            this.txtFechaFin.Value = null;
            // 
            // FindTratHigiene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 251);
            this.Name = "FindTratHigiene";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 130);
            this.Text = "Tratamientos de Higiene";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.ComboBox cmbPlanHigiene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
    }
}
