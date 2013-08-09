namespace GEXVOC.UI
{
    partial class EditDestete
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
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblVaca = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(90, 73);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 132;
            this.txtFecha.Value = null;
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAnimal.btnBusqueda = this.btnBuscarAnimal;
            this.cmbAnimal.ClaseActiva = null;
            this.cmbAnimal.ControlVisible = true;
            this.cmbAnimal.DisplayMember = "Nombre";
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.IdClaseActiva = 0;
            this.cmbAnimal.Location = new System.Drawing.Point(90, 46);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(212, 21);
            this.cmbAnimal.TabIndex = 130;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(312, 46);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 131;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaca.Location = new System.Drawing.Point(31, 50);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(48, 13);
            this.lblVaca.TabIndex = 134;
            this.lblVaca.Text = "Animal:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(31, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 133;
            this.lblFecha.Text = "Fecha:";
            // 
            // EditDestete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(372, 141);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.lblVaca);
            this.Controls.Add(this.lblFecha);
            this.Name = "EditDestete";
            this.Text = "Destete múltiple";
            this.Controls.SetChildIndex(this.lblFecha, 0);
            this.Controls.SetChildIndex(this.lblVaca, 0);
            this.Controls.SetChildIndex(this.btnBuscarAnimal, 0);
            this.Controls.SetChildIndex(this.cmbAnimal, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlFecha txtFecha;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblVaca;
        private System.Windows.Forms.Label lblFecha;
    }
}
