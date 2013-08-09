namespace GEXVOC.UI
{
    partial class FindSecados
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
            this.lblFecInicio2 = new System.Windows.Forms.Label();
            this.lblFecInicio = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.lblVaca = new System.Windows.Forms.Label();
            this.cmbMotivoSecado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.txtFecIniMayor = new GEXVOC.Core.Controles.ctlFecha();
            this.txtFecIniMenor = new GEXVOC.Core.Controles.ctlFecha();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.txtFecIniMenor);
            this.pnlBusqueda.Controls.Add(this.txtFecIniMayor);
            this.pnlBusqueda.Controls.Add(this.cmbMotivoSecado);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.cmbHembra);
            this.pnlBusqueda.Controls.Add(this.btnBuscarHembra);
            this.pnlBusqueda.Controls.Add(this.lblVaca);
            this.pnlBusqueda.Controls.Add(this.lblFecInicio2);
            this.pnlBusqueda.Controls.Add(this.lblFecInicio);
            this.pnlBusqueda.Controls.Add(this.cmbTipo);
            this.pnlBusqueda.Controls.Add(this.lblTipo);
            this.pnlBusqueda.Size = new System.Drawing.Size(610, 146);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 183);
            this.panel1.Size = new System.Drawing.Size(610, 235);
            // 
            // lblFecInicio2
            // 
            this.lblFecInicio2.AutoSize = true;
            this.lblFecInicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecInicio2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio2.Location = new System.Drawing.Point(264, 80);
            this.lblFecInicio2.Name = "lblFecInicio2";
            this.lblFecInicio2.Size = new System.Drawing.Size(36, 13);
            this.lblFecInicio2.TabIndex = 122;
            this.lblFecInicio2.Text = "hasta:";
            // 
            // lblFecInicio
            // 
            this.lblFecInicio.AutoSize = true;
            this.lblFecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFecInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFecInicio.Location = new System.Drawing.Point(34, 80);
            this.lblFecInicio.Name = "lblFecInicio";
            this.lblFecInicio.Size = new System.Drawing.Size(85, 13);
            this.lblFecInicio.TabIndex = 121;
            this.lblFecInicio.Text = "F. Inicio (desde):";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(125, 51);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(270, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTipo.Location = new System.Drawing.Point(34, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 115;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnBuscarHembra
            // 
            this.btnBuscarHembra.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarHembra.Location = new System.Drawing.Point(401, 23);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 1;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.btnBuscarHembra_Click);
            // 
            // lblVaca
            // 
            this.lblVaca.AutoSize = true;
            this.lblVaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVaca.Location = new System.Drawing.Point(34, 27);
            this.lblVaca.Name = "lblVaca";
            this.lblVaca.Size = new System.Drawing.Size(47, 13);
            this.lblVaca.TabIndex = 124;
            this.lblVaca.Text = "Hembra:";
            // 
            // cmbMotivoSecado
            // 
            this.cmbMotivoSecado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMotivoSecado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMotivoSecado.FormattingEnabled = true;
            this.cmbMotivoSecado.Location = new System.Drawing.Point(125, 106);
            this.cmbMotivoSecado.Name = "cmbMotivoSecado";
            this.cmbMotivoSecado.Size = new System.Drawing.Size(270, 21);
            this.cmbMotivoSecado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(34, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "Motivo:";
            // 
            // cmbHembra
            // 
            this.cmbHembra.BackColor = System.Drawing.SystemColors.Control;
            this.cmbHembra.btnBusqueda = this.btnBuscarHembra;
            this.cmbHembra.ClaseActiva = null;
            this.cmbHembra.ControlVisible = true;
            this.cmbHembra.DisplayMember = "Nombre";
            this.cmbHembra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbHembra.FormattingEnabled = true;
            this.cmbHembra.IdClaseActiva = 0;
            this.cmbHembra.Location = new System.Drawing.Point(125, 24);
            this.cmbHembra.Name = "cmbHembra";
            this.cmbHembra.PermitirEliminar = true;
            this.cmbHembra.PermitirLimpiar = true;
            this.cmbHembra.ReadOnly = false;
            this.cmbHembra.Size = new System.Drawing.Size(270, 21);
            this.cmbHembra.TabIndex = 0;
            this.cmbHembra.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbHembra.TipoDatos = null;
            // 
            // txtFecIniMayor
            // 
            this.txtFecIniMayor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecIniMayor.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecIniMayor.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecIniMayor.Location = new System.Drawing.Point(125, 78);
            this.txtFecIniMayor.Name = "txtFecIniMayor";
            this.txtFecIniMayor.ReadOnly = false;
            this.txtFecIniMayor.Size = new System.Drawing.Size(88, 20);
            this.txtFecIniMayor.TabIndex = 3;
            this.txtFecIniMayor.Value = null;
            // 
            // txtFecIniMenor
            // 
            this.txtFecIniMenor.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecIniMenor.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecIniMenor.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecIniMenor.Location = new System.Drawing.Point(307, 78);
            this.txtFecIniMenor.Name = "txtFecIniMenor";
            this.txtFecIniMenor.ReadOnly = false;
            this.txtFecIniMenor.Size = new System.Drawing.Size(88, 20);
            this.txtFecIniMenor.TabIndex = 4;
            this.txtFecIniMenor.Value = null;
            // 
            // FindSecados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.dtgResultadoTamano = new System.Drawing.Size(610, 235);
            this.Name = "FindSecados";
            this.pnlBusquedaTamano = new System.Drawing.Size(610, 146);
            this.Text = "Secados";
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecInicio2;
        private System.Windows.Forms.Label lblFecInicio;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.Label lblVaca;
        private System.Windows.Forms.ComboBox cmbMotivoSecado;
        private System.Windows.Forms.Label label1;
        private GEXVOC.Core.Controles.ctlFecha txtFecIniMenor;
        private GEXVOC.Core.Controles.ctlFecha txtFecIniMayor;
    }
}
