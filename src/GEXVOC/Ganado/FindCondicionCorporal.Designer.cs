namespace GEXVOC.UI
{
    partial class FindCondicionCorporal
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblhembra = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecha);
            this.pnlBusqueda.Controls.Add(this.lblTipo);
            this.pnlBusqueda.Controls.Add(this.cmbTipo);
            this.pnlBusqueda.Controls.Add(this.btnBuscarTipo);
            this.pnlBusqueda.Controls.Add(this.cmbAnimal);
            this.pnlBusqueda.Controls.Add(this.btnBuscarAnimal);
            this.pnlBusqueda.Controls.Add(this.lblhembra);
            this.pnlBusqueda.Controls.Add(this.lblFecha);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 122);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 159);
            this.panel1.Size = new System.Drawing.Size(610, 259);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(18, 59);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 145;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTipo.btnBusqueda = this.btnBuscarTipo;
            this.cmbTipo.ClaseActiva = null;
            this.cmbTipo.ControlVisible = true;
            this.cmbTipo.DisplayMember = "Descripcion";
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.IdClaseActiva = 0;
            this.cmbTipo.Location = new System.Drawing.Point(77, 55);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.PermitirEliminar = true;
            this.cmbTipo.PermitirLimpiar = true;
            this.cmbTipo.ReadOnly = false;
            this.cmbTipo.Size = new System.Drawing.Size(212, 21);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbTipo.TipoDatos = null;
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarTipo.Location = new System.Drawing.Point(299, 55);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarTipo.TabIndex = 3;
            this.btnBuscarTipo.UseVisualStyleBackColor = true;
            this.btnBuscarTipo.Click += new System.EventHandler(this.btnBuscarTipo_Click);
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
            this.cmbAnimal.Location = new System.Drawing.Point(77, 28);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(212, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(299, 28);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblhembra
            // 
            this.lblhembra.AutoSize = true;
            this.lblhembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblhembra.Location = new System.Drawing.Point(18, 32);
            this.lblhembra.Name = "lblhembra";
            this.lblhembra.Size = new System.Drawing.Size(41, 13);
            this.lblhembra.TabIndex = 144;
            this.lblhembra.Text = "Animal:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecha.Location = new System.Drawing.Point(18, 84);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 143;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Location = new System.Drawing.Point(77, 82);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = false;
            this.txtFecha.Size = new System.Drawing.Size(88, 20);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.Value = null;
            // 
            // FindCondicionCorporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 259);
            this.Name = "FindCondicionCorporal";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 122);
            this.Text = "Condiciones Corporales";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbTipo;
        private System.Windows.Forms.Button btnBuscarTipo;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblhembra;
        private System.Windows.Forms.Label lblFecha;
        private GEXVOC.Core.Controles.ctlFecha txtFecha;
    }
}
