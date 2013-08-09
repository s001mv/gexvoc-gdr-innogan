namespace GEXVOC.UI
{
    partial class FindSincronizacionCelo
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
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.cmbPersonal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblHembra = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaColocacion = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaRetirada = new GEXVOC.Core.Controles.ctlFecha();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaInyeccion = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFechaPrevision = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFechaPrevision);
            this.pnlBusqueda.Controls.Add(this.txtFechaInyeccion);
            this.pnlBusqueda.Controls.Add(this.txtFechaRetirada);
            this.pnlBusqueda.Controls.Add(this.txtFechaColocacion);
            this.pnlBusqueda.Controls.Add(this.label8);
            this.pnlBusqueda.Controls.Add(this.label7);
            this.pnlBusqueda.Controls.Add(this.label6);
            this.pnlBusqueda.Controls.Add(this.label5);
            this.pnlBusqueda.Controls.Add(this.lblHembra);
            this.pnlBusqueda.Controls.Add(this.btnBuscarPersonal);
            this.pnlBusqueda.Controls.Add(this.cmbPersonal);
            this.pnlBusqueda.Controls.Add(this.lblPersonal);
            this.pnlBusqueda.Controls.Add(this.cmbHembra);
            this.pnlBusqueda.Controls.Add(this.btnBuscarAnimal);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 145);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 182);
            this.panel1.Size = new System.Drawing.Size(610, 236);
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPersonal.Location = new System.Drawing.Point(367, 47);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarPersonal.TabIndex = 3;
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPersonal.btnBusqueda = this.btnBuscarPersonal;
            this.cmbPersonal.ClaseActiva = null;
            this.cmbPersonal.ControlVisible = true;
            this.cmbPersonal.DisplayMember = "Nombre";
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.IdClaseActiva = 0;
            this.cmbPersonal.Location = new System.Drawing.Point(118, 47);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.PermitirEliminar = true;
            this.cmbPersonal.PermitirLimpiar = true;
            this.cmbPersonal.ReadOnly = false;
            this.cmbPersonal.Size = new System.Drawing.Size(243, 21);
            this.cmbPersonal.TabIndex = 2;
            this.cmbPersonal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPersonal.TipoDatos = null;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPersonal.Location = new System.Drawing.Point(16, 50);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(51, 13);
            this.lblPersonal.TabIndex = 163;
            this.lblPersonal.Text = "Personal:";
            // 
            // cmbHembra
            // 
            this.cmbHembra.BackColor = System.Drawing.SystemColors.Control;
            this.cmbHembra.btnBusqueda = this.btnBuscarAnimal;
            this.cmbHembra.ClaseActiva = null;
            this.cmbHembra.ControlVisible = true;
            this.cmbHembra.DisplayMember = "Nombre";
            this.cmbHembra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbHembra.FormattingEnabled = true;
            this.cmbHembra.IdClaseActiva = 0;
            this.cmbHembra.Location = new System.Drawing.Point(118, 22);
            this.cmbHembra.Name = "cmbHembra";
            this.cmbHembra.PermitirEliminar = true;
            this.cmbHembra.PermitirLimpiar = true;
            this.cmbHembra.ReadOnly = false;
            this.cmbHembra.Size = new System.Drawing.Size(243, 21);
            this.cmbHembra.TabIndex = 0;
            this.cmbHembra.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbHembra.TipoDatos = null;
            this.cmbHembra.ValueMember = "Id";
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(367, 22);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblHembra
            // 
            this.lblHembra.AutoSize = true;
            this.lblHembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHembra.Location = new System.Drawing.Point(16, 22);
            this.lblHembra.Name = "lblHembra";
            this.lblHembra.Size = new System.Drawing.Size(47, 13);
            this.lblHembra.TabIndex = 164;
            this.lblHembra.Text = "Hembra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(222, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 172;
            this.label8.Text = "Fecha Previsión:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(222, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 168;
            this.label6.Text = "Fecha Retirada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 166;
            this.label5.Text = "Fecha Colocación:";
            // 
            // txtFechaColocacion
            // 
            this.txtFechaColocacion.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaColocacion.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaColocacion.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaColocacion.Location = new System.Drawing.Point(118, 81);
            this.txtFechaColocacion.Name = "txtFechaColocacion";
            this.txtFechaColocacion.ReadOnly = false;
            this.txtFechaColocacion.Size = new System.Drawing.Size(88, 20);
            this.txtFechaColocacion.TabIndex = 4;
            this.txtFechaColocacion.Value = null;
            // 
            // txtFechaRetirada
            // 
            this.txtFechaRetirada.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaRetirada.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaRetirada.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaRetirada.Location = new System.Drawing.Point(311, 81);
            this.txtFechaRetirada.Name = "txtFechaRetirada";
            this.txtFechaRetirada.ReadOnly = false;
            this.txtFechaRetirada.Size = new System.Drawing.Size(88, 20);
            this.txtFechaRetirada.TabIndex = 5;
            this.txtFechaRetirada.Value = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(16, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 170;
            this.label7.Text = "Fecha Inyección:";
            // 
            // txtFechaInyeccion
            // 
            this.txtFechaInyeccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInyeccion.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInyeccion.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInyeccion.Location = new System.Drawing.Point(118, 110);
            this.txtFechaInyeccion.Name = "txtFechaInyeccion";
            this.txtFechaInyeccion.ReadOnly = false;
            this.txtFechaInyeccion.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInyeccion.TabIndex = 6;
            this.txtFechaInyeccion.Value = null;
            // 
            // txtFechaPrevision
            // 
            this.txtFechaPrevision.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaPrevision.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaPrevision.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaPrevision.Location = new System.Drawing.Point(311, 110);
            this.txtFechaPrevision.Name = "txtFechaPrevision";
            this.txtFechaPrevision.ReadOnly = false;
            this.txtFechaPrevision.Size = new System.Drawing.Size(88, 20);
            this.txtFechaPrevision.TabIndex = 7;
            this.txtFechaPrevision.Value = null;
            // 
            // FindSincronizacionCelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 236);
            this.Name = "FindSincronizacionCelo";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 145);
            this.Text = "Sincronización de Celos";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPersonal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbPersonal;
        private System.Windows.Forms.Label lblPersonal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblHembra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private GEXVOC.Core.Controles.ctlFecha txtFechaRetirada;
        private GEXVOC.Core.Controles.ctlFecha txtFechaColocacion;
        private System.Windows.Forms.Label label7;
        private GEXVOC.Core.Controles.ctlFecha txtFechaPrevision;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInyeccion;
    }
}
