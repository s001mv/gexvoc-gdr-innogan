namespace GEXVOC.UI
{
    partial class EditSincronizacionCelo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbInyeccion = new System.Windows.Forms.RadioButton();
            this.rdbEsponja = new System.Windows.Forms.RadioButton();
            this.pnlInjeccion = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlEsponja = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            this.cmbPersonal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.cmbHembra = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarHembra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaInyeccion = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaColocacion = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaRetirada = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaPrevision = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlInjeccion.SuspendLayout();
            this.pnlEsponja.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFechaPrevision);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnBuscarPersonal);
            this.groupBox2.Controls.Add(this.cmbPersonal);
            this.groupBox2.Controls.Add(this.lblPersonal);
            this.groupBox2.Controls.Add(this.cmbHembra);
            this.groupBox2.Controls.Add(this.btnBuscarHembra);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 199);
            this.groupBox2.TabIndex = 165;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbInyeccion);
            this.groupBox1.Controls.Add(this.rdbEsponja);
            this.groupBox1.Controls.Add(this.pnlEsponja);
            this.groupBox1.Controls.Add(this.pnlInjeccion);
            this.ErrorProvider.SetIconAlignment(this.groupBox1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.groupBox1.Location = new System.Drawing.Point(25, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Tratamiento";
            // 
            // rdbInyeccion
            // 
            this.rdbInyeccion.AutoSize = true;
            this.rdbInyeccion.Location = new System.Drawing.Point(19, 44);
            this.rdbInyeccion.Name = "rdbInyeccion";
            this.rdbInyeccion.Size = new System.Drawing.Size(117, 17);
            this.rdbInyeccion.TabIndex = 1;
            this.rdbInyeccion.Text = "Inyección hormonal";
            this.rdbInyeccion.UseVisualStyleBackColor = true;
            this.rdbInyeccion.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // rdbEsponja
            // 
            this.rdbEsponja.AutoSize = true;
            this.rdbEsponja.Location = new System.Drawing.Point(19, 21);
            this.rdbEsponja.Name = "rdbEsponja";
            this.rdbEsponja.Size = new System.Drawing.Size(63, 17);
            this.rdbEsponja.TabIndex = 0;
            this.rdbEsponja.Text = "Esponja";
            this.rdbEsponja.UseVisualStyleBackColor = true;
            this.rdbEsponja.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // pnlInjeccion
            // 
            this.pnlInjeccion.Controls.Add(this.txtFechaInyeccion);
            this.pnlInjeccion.Controls.Add(this.label7);
            this.pnlInjeccion.Location = new System.Drawing.Point(154, 14);
            this.pnlInjeccion.Name = "pnlInjeccion";
            this.pnlInjeccion.Size = new System.Drawing.Size(263, 54);
            this.pnlInjeccion.TabIndex = 2;
            this.pnlInjeccion.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 160;
            this.label7.Text = "Fecha Inyección:";
            // 
            // pnlEsponja
            // 
            this.pnlEsponja.Controls.Add(this.txtFechaRetirada);
            this.pnlEsponja.Controls.Add(this.txtFechaColocacion);
            this.pnlEsponja.Controls.Add(this.label5);
            this.pnlEsponja.Controls.Add(this.label6);
            this.pnlEsponja.Location = new System.Drawing.Point(154, 14);
            this.pnlEsponja.Name = "pnlEsponja";
            this.pnlEsponja.Size = new System.Drawing.Size(263, 54);
            this.pnlEsponja.TabIndex = 167;
            this.pnlEsponja.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 156;
            this.label5.Text = "Fecha Colocación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 158;
            this.label6.Text = "Fecha Retirada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(21, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 162;
            this.label8.Text = "Fecha Previsión:";
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarPersonal.Location = new System.Drawing.Point(287, 44);
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
            this.cmbPersonal.Location = new System.Drawing.Point(113, 44);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.PermitirEliminar = true;
            this.cmbPersonal.PermitirLimpiar = true;
            this.cmbPersonal.ReadOnly = false;
            this.cmbPersonal.Size = new System.Drawing.Size(168, 21);
            this.cmbPersonal.TabIndex = 2;
            this.cmbPersonal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbPersonal.TipoDatos = null;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPersonal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPersonal.Location = new System.Drawing.Point(21, 47);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(60, 13);
            this.lblPersonal.TabIndex = 154;
            this.lblPersonal.Text = "Personal:";
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
            this.cmbHembra.Location = new System.Drawing.Point(113, 19);
            this.cmbHembra.Name = "cmbHembra";
            this.cmbHembra.PermitirEliminar = true;
            this.cmbHembra.PermitirLimpiar = true;
            this.cmbHembra.ReadOnly = false;
            this.cmbHembra.Size = new System.Drawing.Size(168, 21);
            this.cmbHembra.TabIndex = 0;
            this.cmbHembra.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbHembra.TipoDatos = null;
            this.cmbHembra.ValueMember = "Id";
            // 
            // btnBuscarHembra
            // 
            this.btnBuscarHembra.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarHembra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarHembra.Location = new System.Drawing.Point(287, 19);
            this.btnBuscarHembra.Name = "btnBuscarHembra";
            this.btnBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarHembra.TabIndex = 1;
            this.btnBuscarHembra.UseVisualStyleBackColor = true;
            this.btnBuscarHembra.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(21, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 153;
            this.label4.Text = "Hembra:";
            // 
            // txtFechaInyeccion
            // 
            this.txtFechaInyeccion.HidePromptOnLeave = true;
            this.txtFechaInyeccion.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFechaInyeccion.Location = new System.Drawing.Point(129, 4);
            this.txtFechaInyeccion.Mask = "00/00/0099";
            this.txtFechaInyeccion.Name = "txtFechaInyeccion";
            this.txtFechaInyeccion.Size = new System.Drawing.Size(67, 20);
            this.txtFechaInyeccion.TabIndex = 161;
            this.txtFechaInyeccion.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaColocacion
            // 
            this.txtFechaColocacion.HidePromptOnLeave = true;
            this.txtFechaColocacion.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFechaColocacion.Location = new System.Drawing.Point(129, 5);
            this.txtFechaColocacion.Mask = "00/00/0099";
            this.txtFechaColocacion.Name = "txtFechaColocacion";
            this.txtFechaColocacion.Size = new System.Drawing.Size(67, 20);
            this.txtFechaColocacion.TabIndex = 159;
            this.txtFechaColocacion.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaRetirada
            // 
            this.txtFechaRetirada.HidePromptOnLeave = true;
            this.txtFechaRetirada.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFechaRetirada.Location = new System.Drawing.Point(129, 31);
            this.txtFechaRetirada.Mask = "00/00/0099";
            this.txtFechaRetirada.Name = "txtFechaRetirada";
            this.txtFechaRetirada.Size = new System.Drawing.Size(67, 20);
            this.txtFechaRetirada.TabIndex = 160;
            this.txtFechaRetirada.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaPrevision
            // 
            this.txtFechaPrevision.HidePromptOnLeave = true;
            this.txtFechaPrevision.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtFechaPrevision.Location = new System.Drawing.Point(113, 163);
            this.txtFechaPrevision.Mask = "00/00/0099";
            this.txtFechaPrevision.Name = "txtFechaPrevision";
            this.txtFechaPrevision.Size = new System.Drawing.Size(67, 20);
            this.txtFechaPrevision.TabIndex = 5;
            this.txtFechaPrevision.ValidatingType = typeof(System.DateTime);
            // 
            // EditSincronizacionCelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(509, 278);
            this.Controls.Add(this.groupBox2);
            this.Name = "EditSincronizacionCelo";
            this.Text = "Sincronizacion Celo";
            this.Load += new System.EventHandler(this.EditSincronizacionCelo_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlInjeccion.ResumeLayout(false);
            this.pnlInjeccion.PerformLayout();
            this.pnlEsponja.ResumeLayout(false);
            this.pnlEsponja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarPersonal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbPersonal;
        private System.Windows.Forms.Label lblPersonal;
        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbHembra;
        private System.Windows.Forms.Button btnBuscarHembra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlInjeccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbInyeccion;
        private System.Windows.Forms.RadioButton rdbEsponja;
        private System.Windows.Forms.Panel pnlEsponja;
        private System.Windows.Forms.MaskedTextBox txtFechaPrevision;
        private System.Windows.Forms.MaskedTextBox txtFechaRetirada;
        private System.Windows.Forms.MaskedTextBox txtFechaColocacion;
        private System.Windows.Forms.MaskedTextBox txtFechaInyeccion;
    }
}
