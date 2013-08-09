namespace GEXVOC.UI
{
    partial class FindFamilia
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
            this.cmbTipoProducto = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblExplotacion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.lblDescripcion);
            this.pnlBusqueda.Controls.Add(this.txtDescripcion);
            this.pnlBusqueda.Controls.Add(this.cmbTipoProducto);
            this.pnlBusqueda.Controls.Add(this.lblExplotacion);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 89);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 126);
            this.panel1.Size = new System.Drawing.Size(610, 292);
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTipoProducto.btnBusqueda = null;
            this.cmbTipoProducto.ClaseActiva = null;
            this.cmbTipoProducto.ControlVisible = true;
            this.cmbTipoProducto.DisplayMember = "Descripcion";
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(454, 19);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.PermitirEliminar = true;
            this.cmbTipoProducto.PermitirLimpiar = true;
            this.cmbTipoProducto.ReadOnly = false;
            this.cmbTipoProducto.Size = new System.Drawing.Size(156, 21);
            this.cmbTipoProducto.TabIndex = 139;
            this.cmbTipoProducto.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbTipoProducto.Visible = false;
            // 
            // lblExplotacion
            // 
            this.lblExplotacion.AutoSize = true;
            this.lblExplotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblExplotacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExplotacion.Location = new System.Drawing.Point(408, 22);
            this.lblExplotacion.Name = "lblExplotacion";
            this.lblExplotacion.Size = new System.Drawing.Size(36, 13);
            this.lblExplotacion.TabIndex = 140;
            this.lblExplotacion.Text = "Tipo:";
            this.lblExplotacion.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 41);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 142;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 38);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(324, 20);
            this.txtDescripcion.TabIndex = 141;
            // 
            // FindFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 292);
            this.Name = "FindFamilia";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 89);
            this.Text = "Familias";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbTipoProducto;
        private System.Windows.Forms.Label lblExplotacion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}
