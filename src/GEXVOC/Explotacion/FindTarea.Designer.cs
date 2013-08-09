namespace GEXVOC.UI
{
    partial class FindTarea
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
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.txtFechaInicial = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaFinal = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFechaFinal);
            this.pnlBusqueda.Controls.Add(this.txtFechaInicial);
            this.pnlBusqueda.Controls.Add(this.lblFechaFinal);
            this.pnlBusqueda.Controls.Add(this.lblFechaInicial);
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 95);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 132);
            this.panel1.Size = new System.Drawing.Size(610, 286);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 26);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(283, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(63, 29);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(38, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Tarea:";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaInicial.Location = new System.Drawing.Point(63, 55);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblFechaInicial.TabIndex = 136;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaFinal.Location = new System.Drawing.Point(271, 55);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(65, 13);
            this.lblFechaFinal.TabIndex = 138;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // txtFechaInicial
            // 
            this.txtFechaInicial.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicial.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicial.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicial.Location = new System.Drawing.Point(147, 55);
            this.txtFechaInicial.Name = "txtFechaInicial";
            this.txtFechaInicial.ReadOnly = false;
            this.txtFechaInicial.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicial.TabIndex = 1;
            this.txtFechaInicial.Value = null;
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFinal.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFinal.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFinal.Location = new System.Drawing.Point(342, 55);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.ReadOnly = false;
            this.txtFechaFinal.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFinal.TabIndex = 2;
            this.txtFechaFinal.Value = null;
            // 
            // FindTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 286);
            this.Name = "FindTarea";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 95);
            this.Text = "Tareas";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicial;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFinal;
    }
}
