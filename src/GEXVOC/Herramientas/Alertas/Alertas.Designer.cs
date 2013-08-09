namespace GEXVOC.UI
{
    partial class Alertas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcContenido = new System.Windows.Forms.TabControl();
            this.tbpEnfermas = new System.Windows.Forms.TabPage();
            this.lblEnfermas = new System.Windows.Forms.Label();
            this.dtgEnfermas = new System.Windows.Forms.DataGridView();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supresión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpSecadas = new System.Windows.Forms.TabPage();
            this.lblSecadas = new System.Windows.Forms.Label();
            this.dtgSecadas = new System.Windows.Forms.DataGridView();
            this.CI2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpParidas = new System.Windows.Forms.TabPage();
            this.lblParidas = new System.Windows.Forms.Label();
            this.dtgParidas = new System.Windows.Forms.DataGridView();
            this.CI3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpDiagnosticos = new System.Windows.Forms.TabPage();
            this.lblDiagnosticos = new System.Windows.Forms.Label();
            this.dtgDiagnosticos = new System.Windows.Forms.DataGridView();
            this.CI4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.tbcContenido.SuspendLayout();
            this.tbpEnfermas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEnfermas)).BeginInit();
            this.tbpSecadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSecadas)).BeginInit();
            this.tbpParidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParidas)).BeginInit();
            this.tbpDiagnosticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiagnosticos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcContenido
            // 
            this.tbcContenido.Controls.Add(this.tbpEnfermas);
            this.tbcContenido.Controls.Add(this.tbpSecadas);
            this.tbcContenido.Controls.Add(this.tbpParidas);
            this.tbcContenido.Controls.Add(this.tbpDiagnosticos);
            this.tbcContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbcContenido.Location = new System.Drawing.Point(12, 33);
            this.tbcContenido.Name = "tbcContenido";
            this.tbcContenido.SelectedIndex = 0;
            this.tbcContenido.Size = new System.Drawing.Size(610, 383);
            this.tbcContenido.TabIndex = 128;
            // 
            // tbpEnfermas
            // 
            this.tbpEnfermas.Controls.Add(this.lblEnfermas);
            this.tbpEnfermas.Controls.Add(this.dtgEnfermas);
            this.tbpEnfermas.Location = new System.Drawing.Point(4, 22);
            this.tbpEnfermas.Name = "tbpEnfermas";
            this.tbpEnfermas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEnfermas.Size = new System.Drawing.Size(602, 357);
            this.tbpEnfermas.TabIndex = 0;
            this.tbpEnfermas.Text = "Vacas enfermas";
            this.tbpEnfermas.UseVisualStyleBackColor = true;
            // 
            // lblEnfermas
            // 
            this.lblEnfermas.AutoSize = true;
            this.lblEnfermas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEnfermas.Location = new System.Drawing.Point(15, 22);
            this.lblEnfermas.Name = "lblEnfermas";
            this.lblEnfermas.Size = new System.Drawing.Size(425, 13);
            this.lblEnfermas.TabIndex = 16;
            this.lblEnfermas.Text = "Vacas (enfermas o con tratamiento) que se encuentran en supresión de leche y/o ca" +
                "rne:";
            // 
            // dtgEnfermas
            // 
            this.dtgEnfermas.AllowUserToAddRows = false;
            this.dtgEnfermas.AllowUserToDeleteRows = false;
            this.dtgEnfermas.AllowUserToOrderColumns = true;
            this.dtgEnfermas.AllowUserToResizeRows = false;
            this.dtgEnfermas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgEnfermas.BackgroundColor = System.Drawing.Color.White;
            this.dtgEnfermas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgEnfermas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI,
            this.Enfermedad,
            this.Supresión,
            this.Fecha});
            this.dtgEnfermas.Location = new System.Drawing.Point(3, 60);
            this.dtgEnfermas.Name = "dtgEnfermas";
            this.dtgEnfermas.ReadOnly = true;
            this.dtgEnfermas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgEnfermas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgEnfermas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEnfermas.ShowCellErrors = false;
            this.dtgEnfermas.ShowCellToolTips = false;
            this.dtgEnfermas.ShowEditingIcon = false;
            this.dtgEnfermas.ShowRowErrors = false;
            this.dtgEnfermas.Size = new System.Drawing.Size(593, 294);
            this.dtgEnfermas.TabIndex = 15;
            this.dtgEnfermas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEnfermas_CellDoubleClick);
            // 
            // CI
            // 
            this.CI.DataPropertyName = "CI";
            this.CI.HeaderText = "C.I.";
            this.CI.Name = "CI";
            this.CI.ReadOnly = true;
            this.CI.Width = 48;
            // 
            // Enfermedad
            // 
            this.Enfermedad.DataPropertyName = "Enfermedad";
            this.Enfermedad.HeaderText = "Enfermedad";
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.ReadOnly = true;
            this.Enfermedad.Width = 89;
            // 
            // Supresión
            // 
            this.Supresión.DataPropertyName = "Supresion";
            this.Supresión.HeaderText = "Supresión";
            this.Supresión.Name = "Supresión";
            this.Supresión.ReadOnly = true;
            this.Supresión.Width = 79;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaFinSupresion";
            this.Fecha.HeaderText = "Finalización de supresión";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // tbpSecadas
            // 
            this.tbpSecadas.Controls.Add(this.lblSecadas);
            this.tbpSecadas.Controls.Add(this.dtgSecadas);
            this.tbpSecadas.Location = new System.Drawing.Point(4, 22);
            this.tbpSecadas.Name = "tbpSecadas";
            this.tbpSecadas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSecadas.Size = new System.Drawing.Size(602, 357);
            this.tbpSecadas.TabIndex = 4;
            this.tbpSecadas.Text = "Vacas próximas a secado";
            this.tbpSecadas.UseVisualStyleBackColor = true;
            // 
            // lblSecadas
            // 
            this.lblSecadas.AutoSize = true;
            this.lblSecadas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSecadas.Location = new System.Drawing.Point(15, 22);
            this.lblSecadas.Name = "lblSecadas";
            this.lblSecadas.Size = new System.Drawing.Size(153, 13);
            this.lblSecadas.TabIndex = 16;
            this.lblSecadas.Text = "Vacas próximas a ser secadas:";
            // 
            // dtgSecadas
            // 
            this.dtgSecadas.AllowUserToAddRows = false;
            this.dtgSecadas.AllowUserToDeleteRows = false;
            this.dtgSecadas.AllowUserToOrderColumns = true;
            this.dtgSecadas.AllowUserToResizeRows = false;
            this.dtgSecadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgSecadas.BackgroundColor = System.Drawing.Color.White;
            this.dtgSecadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgSecadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI2,
            this.Fecha2,
            this.Dias});
            this.dtgSecadas.Location = new System.Drawing.Point(3, 60);
            this.dtgSecadas.Name = "dtgSecadas";
            this.dtgSecadas.ReadOnly = true;
            this.dtgSecadas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgSecadas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgSecadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSecadas.ShowCellErrors = false;
            this.dtgSecadas.ShowCellToolTips = false;
            this.dtgSecadas.ShowEditingIcon = false;
            this.dtgSecadas.ShowRowErrors = false;
            this.dtgSecadas.Size = new System.Drawing.Size(593, 294);
            this.dtgSecadas.TabIndex = 15;
            // 
            // CI2
            // 
            this.CI2.DataPropertyName = "CI";
            this.CI2.HeaderText = "C.I.";
            this.CI2.Name = "CI2";
            this.CI2.ReadOnly = true;
            this.CI2.Width = 48;
            // 
            // Fecha2
            // 
            this.Fecha2.DataPropertyName = "FechaParto";
            this.Fecha2.HeaderText = "F.Parto";
            this.Fecha2.Name = "Fecha2";
            this.Fecha2.ReadOnly = true;
            this.Fecha2.Width = 66;
            // 
            // Dias
            // 
            this.Dias.DataPropertyName = "Dias";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Dias.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dias.HeaderText = "Días hasta secado";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            this.Dias.Width = 122;
            // 
            // tbpParidas
            // 
            this.tbpParidas.Controls.Add(this.lblParidas);
            this.tbpParidas.Controls.Add(this.dtgParidas);
            this.tbpParidas.Location = new System.Drawing.Point(4, 22);
            this.tbpParidas.Name = "tbpParidas";
            this.tbpParidas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpParidas.Size = new System.Drawing.Size(602, 357);
            this.tbpParidas.TabIndex = 5;
            this.tbpParidas.Text = "Vacas próximas a parto";
            this.tbpParidas.UseVisualStyleBackColor = true;
            // 
            // lblParidas
            // 
            this.lblParidas.AutoSize = true;
            this.lblParidas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblParidas.Location = new System.Drawing.Point(15, 22);
            this.lblParidas.Name = "lblParidas";
            this.lblParidas.Size = new System.Drawing.Size(205, 13);
            this.lblParidas.TabIndex = 16;
            this.lblParidas.Text = "Vacas próximas a fecha prevista de parto:";
            // 
            // dtgParidas
            // 
            this.dtgParidas.AllowUserToAddRows = false;
            this.dtgParidas.AllowUserToDeleteRows = false;
            this.dtgParidas.AllowUserToOrderColumns = true;
            this.dtgParidas.AllowUserToResizeRows = false;
            this.dtgParidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgParidas.BackgroundColor = System.Drawing.Color.White;
            this.dtgParidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgParidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI3,
            this.Fecha3,
            this.Dias2});
            this.dtgParidas.Location = new System.Drawing.Point(3, 60);
            this.dtgParidas.Name = "dtgParidas";
            this.dtgParidas.ReadOnly = true;
            this.dtgParidas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgParidas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgParidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgParidas.ShowCellErrors = false;
            this.dtgParidas.ShowCellToolTips = false;
            this.dtgParidas.ShowEditingIcon = false;
            this.dtgParidas.ShowRowErrors = false;
            this.dtgParidas.Size = new System.Drawing.Size(593, 294);
            this.dtgParidas.TabIndex = 15;
            // 
            // CI3
            // 
            this.CI3.DataPropertyName = "CI";
            this.CI3.HeaderText = "C.I.";
            this.CI3.Name = "CI3";
            this.CI3.ReadOnly = true;
            this.CI3.Width = 48;
            // 
            // Fecha3
            // 
            this.Fecha3.DataPropertyName = "FechaInseminacion";
            this.Fecha3.HeaderText = "F.Inseminación";
            this.Fecha3.Name = "Fecha3";
            this.Fecha3.ReadOnly = true;
            this.Fecha3.Width = 103;
            // 
            // Dias2
            // 
            this.Dias2.DataPropertyName = "Dias";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Dias2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dias2.HeaderText = "Dias desde Inseminación";
            this.Dias2.Name = "Dias2";
            this.Dias2.ReadOnly = true;
            this.Dias2.Width = 150;
            // 
            // tbpDiagnosticos
            // 
            this.tbpDiagnosticos.Controls.Add(this.lblDiagnosticos);
            this.tbpDiagnosticos.Controls.Add(this.dtgDiagnosticos);
            this.tbpDiagnosticos.Location = new System.Drawing.Point(4, 22);
            this.tbpDiagnosticos.Name = "tbpDiagnosticos";
            this.tbpDiagnosticos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDiagnosticos.Size = new System.Drawing.Size(602, 357);
            this.tbpDiagnosticos.TabIndex = 6;
            this.tbpDiagnosticos.Text = "Inseminaciones pendientes de diagnóstico";
            this.tbpDiagnosticos.UseVisualStyleBackColor = true;
            // 
            // lblDiagnosticos
            // 
            this.lblDiagnosticos.AutoSize = true;
            this.lblDiagnosticos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDiagnosticos.Location = new System.Drawing.Point(15, 22);
            this.lblDiagnosticos.Name = "lblDiagnosticos";
            this.lblDiagnosticos.Size = new System.Drawing.Size(210, 13);
            this.lblDiagnosticos.TabIndex = 16;
            this.lblDiagnosticos.Text = "Inseminaciones pendientes de diagnóstico:";
            // 
            // dtgDiagnosticos
            // 
            this.dtgDiagnosticos.AllowUserToAddRows = false;
            this.dtgDiagnosticos.AllowUserToDeleteRows = false;
            this.dtgDiagnosticos.AllowUserToOrderColumns = true;
            this.dtgDiagnosticos.AllowUserToResizeRows = false;
            this.dtgDiagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDiagnosticos.BackgroundColor = System.Drawing.Color.White;
            this.dtgDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgDiagnosticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CI4,
            this.Fecha4,
            this.Dias3});
            this.dtgDiagnosticos.Location = new System.Drawing.Point(3, 60);
            this.dtgDiagnosticos.Name = "dtgDiagnosticos";
            this.dtgDiagnosticos.ReadOnly = true;
            this.dtgDiagnosticos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgDiagnosticos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDiagnosticos.ShowCellErrors = false;
            this.dtgDiagnosticos.ShowCellToolTips = false;
            this.dtgDiagnosticos.ShowEditingIcon = false;
            this.dtgDiagnosticos.ShowRowErrors = false;
            this.dtgDiagnosticos.Size = new System.Drawing.Size(593, 294);
            this.dtgDiagnosticos.TabIndex = 15;
            // 
            // CI4
            // 
            this.CI4.DataPropertyName = "CI";
            this.CI4.HeaderText = "C.I.";
            this.CI4.Name = "CI4";
            this.CI4.ReadOnly = true;
            this.CI4.Width = 48;
            // 
            // Fecha4
            // 
            this.Fecha4.DataPropertyName = "FechaInseminacion";
            this.Fecha4.HeaderText = "F.Inseminación";
            this.Fecha4.Name = "Fecha4";
            this.Fecha4.ReadOnly = true;
            this.Fecha4.Width = 103;
            // 
            // Dias3
            // 
            this.Dias3.DataPropertyName = "Dias";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Dias3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dias3.HeaderText = "Dias desde Inseminación";
            this.Dias3.Name = "Dias3";
            this.Dias3.ReadOnly = true;
            this.Dias3.Width = 150;
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.tbcContenido);
            this.Name = "Alertas";
            this.Text = "INFORMACIÓN DE ALERTAS";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlBusqueda, 0);
            this.Controls.SetChildIndex(this.tbcContenido, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.tbcContenido.ResumeLayout(false);
            this.tbpEnfermas.ResumeLayout(false);
            this.tbpEnfermas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEnfermas)).EndInit();
            this.tbpSecadas.ResumeLayout(false);
            this.tbpSecadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSecadas)).EndInit();
            this.tbpParidas.ResumeLayout(false);
            this.tbpParidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParidas)).EndInit();
            this.tbpDiagnosticos.ResumeLayout(false);
            this.tbpDiagnosticos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiagnosticos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcContenido;
        private System.Windows.Forms.TabPage tbpEnfermas;
        private System.Windows.Forms.Label lblEnfermas;
        private System.Windows.Forms.DataGridView dtgEnfermas;
        private System.Windows.Forms.TabPage tbpSecadas;
        private System.Windows.Forms.Label lblSecadas;
        private System.Windows.Forms.DataGridView dtgSecadas;
        private System.Windows.Forms.TabPage tbpParidas;
        private System.Windows.Forms.Label lblParidas;
        private System.Windows.Forms.DataGridView dtgParidas;
        private System.Windows.Forms.TabPage tbpDiagnosticos;
        private System.Windows.Forms.Label lblDiagnosticos;
        private System.Windows.Forms.DataGridView dtgDiagnosticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supresión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias3;
    }
}
