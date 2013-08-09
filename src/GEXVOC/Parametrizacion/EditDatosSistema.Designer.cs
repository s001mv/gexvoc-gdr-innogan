namespace GEXVOC.UI
{
    partial class EditDatosSistema
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
            this.lstGrupos = new System.Windows.Forms.ListView();
            this.colDescripcion = new System.Windows.Forms.ColumnHeader();
            this.colObj = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGrupos
            // 
            this.lstGrupos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescripcion,
            this.colObj});
            this.lstGrupos.FullRowSelect = true;
            this.lstGrupos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstGrupos.Location = new System.Drawing.Point(12, 28);
            this.lstGrupos.Name = "lstGrupos";
            this.lstGrupos.Size = new System.Drawing.Size(624, 598);
            this.lstGrupos.TabIndex = 18;
            this.lstGrupos.UseCompatibleStateImageBehavior = false;
            this.lstGrupos.View = System.Windows.Forms.View.Details;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Text = "Descripción";
            this.colDescripcion.Width = 327;
            // 
            // colObj
            // 
            this.colObj.Text = "Objeto";
            this.colObj.Width = 264;
            // 
            // EditDatosSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(648, 651);
            this.Controls.Add(this.lstGrupos);
            this.Name = "EditDatosSistema";
            this.Text = "Datos Sistema";
            this.Load += new System.EventHandler(this.EditDatosSistema_Load);
            this.Controls.SetChildIndex(this.lstGrupos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstGrupos;
        private System.Windows.Forms.ColumnHeader colDescripcion;
        private System.Windows.Forms.ColumnHeader colObj;
    }
}
