namespace GEXVOC.Informes
{
    partial class InfRecuento
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.txtFFin = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFFin = new System.Windows.Forms.Label();
            this.lblFInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cmbAnimal.Location = new System.Drawing.Point(115, 22);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(307, 21);
            this.cmbAnimal.TabIndex = 133;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(428, 21);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 134;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(42, 25);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(67, 13);
            this.lblAnimal.TabIndex = 135;
            this.lblAnimal.Text = "Animal/es:";
            // 
            // txtFFin
            // 
            this.txtFFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFFin.Location = new System.Drawing.Point(240, 49);
            this.txtFFin.Name = "txtFFin";
            this.txtFFin.ReadOnly = false;
            this.txtFFin.Size = new System.Drawing.Size(88, 20);
            this.txtFFin.TabIndex = 152;
            this.txtFFin.Value = null;
            // 
            // txtFInicio
            // 
            this.txtFInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFInicio.Location = new System.Drawing.Point(115, 49);
            this.txtFInicio.Name = "txtFInicio";
            this.txtFInicio.ReadOnly = false;
            this.txtFInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFInicio.TabIndex = 151;
            this.txtFInicio.Value = null;
            // 
            // lblFFin
            // 
            this.lblFFin.AutoSize = true;
            this.lblFFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFFin.Location = new System.Drawing.Point(213, 52);
            this.lblFFin.Name = "lblFFin";
            this.lblFFin.Size = new System.Drawing.Size(17, 13);
            this.lblFFin.TabIndex = 154;
            this.lblFFin.Text = "al";
            // 
            // lblFInicio
            // 
            this.lblFInicio.AutoSize = true;
            this.lblFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFInicio.Location = new System.Drawing.Point(42, 52);
            this.lblFInicio.Name = "lblFInicio";
            this.lblFInicio.Size = new System.Drawing.Size(71, 13);
            this.lblFInicio.TabIndex = 153;
            this.lblFInicio.Text = "Periodo del";
            // 
            // InfRecuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFFin);
            this.Controls.Add(this.txtFInicio);
            this.Controls.Add(this.lblFFin);
            this.Controls.Add(this.lblFInicio);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Name = "InfRecuento";
            this.Size = new System.Drawing.Size(684, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private GEXVOC.Core.Controles.ctlFecha txtFFin;
        private GEXVOC.Core.Controles.ctlFecha txtFInicio;
        private System.Windows.Forms.Label lblFFin;
        private System.Windows.Forms.Label lblFInicio;
    }
}
