namespace GEXVOC.Informes
{
    partial class InfFichaAnimal
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
            this.cmbAnimal = new GEXVOC.Core.Controles.ctlBuscarObjeto();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblFechafin = new System.Windows.Forms.Label();
            this.txtFechaFin = new GEXVOC.Core.Controles.ctlFecha();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtFechaInicio = new GEXVOC.Core.Controles.ctlFecha();
            this.chkMostrarControles = new System.Windows.Forms.CheckBox();
            this.grpElementosMostrar = new System.Windows.Forms.GroupBox();
            this.chkCapacidadMaternal = new System.Windows.Forms.CheckBox();
            this.chkIC = new System.Windows.Forms.CheckBox();
            this.chkGMD = new System.Windows.Forms.CheckBox();
            this.chkInformacionCanal = new System.Windows.Forms.CheckBox();
            this.chkHistorialEnfermedades = new System.Windows.Forms.CheckBox();
            this.chkCondicionesCorporales = new System.Windows.Forms.CheckBox();
            this.chkPesos = new System.Windows.Forms.CheckBox();
            this.chkSecados = new System.Windows.Forms.CheckBox();
            this.chkLactaciones = new System.Windows.Forms.CheckBox();
            this.chkAbortos = new System.Windows.Forms.CheckBox();
            this.chkPartos = new System.Windows.Forms.CheckBox();
            this.chkDiagGestacion = new System.Windows.Forms.CheckBox();
            this.chkInseminaciones = new System.Windows.Forms.CheckBox();
            this.chkSincCelos = new System.Windows.Forms.CheckBox();
            this.chkCelos = new System.Windows.Forms.CheckBox();
            this.chkGenealogia = new System.Windows.Forms.CheckBox();
            this.grpElementosMostrar.SuspendLayout();
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
            this.cmbAnimal.Location = new System.Drawing.Point(92, 26);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.PermitirEliminar = true;
            this.cmbAnimal.PermitirLimpiar = true;
            this.cmbAnimal.ReadOnly = false;
            this.cmbAnimal.Size = new System.Drawing.Size(239, 21);
            this.cmbAnimal.TabIndex = 0;
            this.cmbAnimal.TeclaBusqueda = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cmbAnimal.TipoDatos = null;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.Image = global::GEXVOC.Properties.Resources.buscar;
            this.btnBuscarAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(336, 26);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(21, 21);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.UseVisualStyleBackColor = true;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAnimal.Location = new System.Drawing.Point(12, 29);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(48, 13);
            this.lblAnimal.TabIndex = 144;
            this.lblAnimal.Text = "Animal:";
            // 
            // lblFechafin
            // 
            this.lblFechafin.AutoSize = true;
            this.lblFechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechafin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechafin.Location = new System.Drawing.Point(203, 56);
            this.lblFechafin.Name = "lblFechafin";
            this.lblFechafin.Size = new System.Drawing.Size(60, 13);
            this.lblFechafin.TabIndex = 156;
            this.lblFechafin.Text = "Fecha (fin):";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaFin.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaFin.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaFin.Location = new System.Drawing.Point(269, 53);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = false;
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 3;
            this.txtFechaFin.Value = null;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 56);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(73, 13);
            this.lblFechaInicio.TabIndex = 155;
            this.lblFechaInicio.Text = "Fecha (inicio):";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaInicio.FechaMaxima = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaInicio.FechaMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechaInicio.Location = new System.Drawing.Point(91, 53);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = false;
            this.txtFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.txtFechaInicio.TabIndex = 2;
            this.txtFechaInicio.Value = null;
            // 
            // chkMostrarControles
            // 
            this.chkMostrarControles.AutoSize = true;
            this.chkMostrarControles.Checked = true;
            this.chkMostrarControles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMostrarControles.Location = new System.Drawing.Point(140, 51);
            this.chkMostrarControles.Name = "chkMostrarControles";
            this.chkMostrarControles.Size = new System.Drawing.Size(70, 17);
            this.chkMostrarControles.TabIndex = 8;
            this.chkMostrarControles.Text = "Controles";
            this.chkMostrarControles.UseVisualStyleBackColor = true;
            // 
            // grpElementosMostrar
            // 
            this.grpElementosMostrar.Controls.Add(this.chkCapacidadMaternal);
            this.grpElementosMostrar.Controls.Add(this.chkIC);
            this.grpElementosMostrar.Controls.Add(this.chkGMD);
            this.grpElementosMostrar.Controls.Add(this.chkInformacionCanal);
            this.grpElementosMostrar.Controls.Add(this.chkHistorialEnfermedades);
            this.grpElementosMostrar.Controls.Add(this.chkCondicionesCorporales);
            this.grpElementosMostrar.Controls.Add(this.chkPesos);
            this.grpElementosMostrar.Controls.Add(this.chkSecados);
            this.grpElementosMostrar.Controls.Add(this.chkLactaciones);
            this.grpElementosMostrar.Controls.Add(this.chkAbortos);
            this.grpElementosMostrar.Controls.Add(this.chkPartos);
            this.grpElementosMostrar.Controls.Add(this.chkDiagGestacion);
            this.grpElementosMostrar.Controls.Add(this.chkInseminaciones);
            this.grpElementosMostrar.Controls.Add(this.chkSincCelos);
            this.grpElementosMostrar.Controls.Add(this.chkCelos);
            this.grpElementosMostrar.Controls.Add(this.chkGenealogia);
            this.grpElementosMostrar.Controls.Add(this.chkMostrarControles);
            this.grpElementosMostrar.Location = new System.Drawing.Point(378, 3);
            this.grpElementosMostrar.Name = "grpElementosMostrar";
            this.grpElementosMostrar.Size = new System.Drawing.Size(302, 120);
            this.grpElementosMostrar.TabIndex = 4;
            this.grpElementosMostrar.TabStop = false;
            this.grpElementosMostrar.Text = "Elementos a Visualizar";
            // 
            // chkCapacidadMaternal
            // 
            this.chkCapacidadMaternal.AutoSize = true;
            this.chkCapacidadMaternal.Checked = true;
            this.chkCapacidadMaternal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCapacidadMaternal.Location = new System.Drawing.Point(220, 51);
            this.chkCapacidadMaternal.Name = "chkCapacidadMaternal";
            this.chkCapacidadMaternal.Size = new System.Drawing.Size(80, 17);
            this.chkCapacidadMaternal.TabIndex = 14;
            this.chkCapacidadMaternal.Text = "C. Maternal";
            this.chkCapacidadMaternal.UseVisualStyleBackColor = true;
            // 
            // chkIC
            // 
            this.chkIC.AutoSize = true;
            this.chkIC.Checked = true;
            this.chkIC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIC.Location = new System.Drawing.Point(220, 85);
            this.chkIC.Name = "chkIC";
            this.chkIC.Size = new System.Drawing.Size(39, 17);
            this.chkIC.TabIndex = 16;
            this.chkIC.Text = "I.C";
            this.chkIC.UseVisualStyleBackColor = true;
            // 
            // chkGMD
            // 
            this.chkGMD.AutoSize = true;
            this.chkGMD.Checked = true;
            this.chkGMD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGMD.Location = new System.Drawing.Point(220, 68);
            this.chkGMD.Name = "chkGMD";
            this.chkGMD.Size = new System.Drawing.Size(57, 17);
            this.chkGMD.TabIndex = 15;
            this.chkGMD.Text = "G.M.D";
            this.chkGMD.UseVisualStyleBackColor = true;
            // 
            // chkInformacionCanal
            // 
            this.chkInformacionCanal.AutoSize = true;
            this.chkInformacionCanal.Checked = true;
            this.chkInformacionCanal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInformacionCanal.Location = new System.Drawing.Point(220, 34);
            this.chkInformacionCanal.Name = "chkInformacionCanal";
            this.chkInformacionCanal.Size = new System.Drawing.Size(77, 17);
            this.chkInformacionCanal.TabIndex = 13;
            this.chkInformacionCanal.Text = "Info. Canal";
            this.chkInformacionCanal.UseVisualStyleBackColor = true;
            // 
            // chkHistorialEnfermedades
            // 
            this.chkHistorialEnfermedades.AutoSize = true;
            this.chkHistorialEnfermedades.Checked = true;
            this.chkHistorialEnfermedades.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHistorialEnfermedades.Location = new System.Drawing.Point(221, 17);
            this.chkHistorialEnfermedades.Name = "chkHistorialEnfermedades";
            this.chkHistorialEnfermedades.Size = new System.Drawing.Size(76, 17);
            this.chkHistorialEnfermedades.TabIndex = 12;
            this.chkHistorialEnfermedades.Text = "H. Enferm.";
            this.chkHistorialEnfermedades.UseVisualStyleBackColor = true;
            // 
            // chkCondicionesCorporales
            // 
            this.chkCondicionesCorporales.AutoSize = true;
            this.chkCondicionesCorporales.Checked = true;
            this.chkCondicionesCorporales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCondicionesCorporales.Location = new System.Drawing.Point(117, 102);
            this.chkCondicionesCorporales.Name = "chkCondicionesCorporales";
            this.chkCondicionesCorporales.Size = new System.Drawing.Size(107, 17);
            this.chkCondicionesCorporales.TabIndex = 11;
            this.chkCondicionesCorporales.Text = "Cond. Corporales";
            this.chkCondicionesCorporales.UseVisualStyleBackColor = true;
            // 
            // chkPesos
            // 
            this.chkPesos.AutoSize = true;
            this.chkPesos.Checked = true;
            this.chkPesos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPesos.Location = new System.Drawing.Point(117, 85);
            this.chkPesos.Name = "chkPesos";
            this.chkPesos.Size = new System.Drawing.Size(55, 17);
            this.chkPesos.TabIndex = 10;
            this.chkPesos.Text = "Pesos";
            this.chkPesos.UseVisualStyleBackColor = true;
            // 
            // chkSecados
            // 
            this.chkSecados.AutoSize = true;
            this.chkSecados.Checked = true;
            this.chkSecados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSecados.Location = new System.Drawing.Point(117, 68);
            this.chkSecados.Name = "chkSecados";
            this.chkSecados.Size = new System.Drawing.Size(68, 17);
            this.chkSecados.TabIndex = 9;
            this.chkSecados.Text = "Secados";
            this.chkSecados.UseVisualStyleBackColor = true;
            // 
            // chkLactaciones
            // 
            this.chkLactaciones.AutoSize = true;
            this.chkLactaciones.Checked = true;
            this.chkLactaciones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLactaciones.Location = new System.Drawing.Point(117, 34);
            this.chkLactaciones.Name = "chkLactaciones";
            this.chkLactaciones.Size = new System.Drawing.Size(84, 17);
            this.chkLactaciones.TabIndex = 7;
            this.chkLactaciones.Text = "Lactaciones";
            this.chkLactaciones.UseVisualStyleBackColor = true;
            // 
            // chkAbortos
            // 
            this.chkAbortos.AutoSize = true;
            this.chkAbortos.Checked = true;
            this.chkAbortos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAbortos.Location = new System.Drawing.Point(117, 17);
            this.chkAbortos.Name = "chkAbortos";
            this.chkAbortos.Size = new System.Drawing.Size(62, 17);
            this.chkAbortos.TabIndex = 6;
            this.chkAbortos.Text = "Abortos";
            this.chkAbortos.UseVisualStyleBackColor = true;
            // 
            // chkPartos
            // 
            this.chkPartos.AutoSize = true;
            this.chkPartos.Checked = true;
            this.chkPartos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPartos.Location = new System.Drawing.Point(9, 102);
            this.chkPartos.Name = "chkPartos";
            this.chkPartos.Size = new System.Drawing.Size(56, 17);
            this.chkPartos.TabIndex = 5;
            this.chkPartos.Text = "Partos";
            this.chkPartos.UseVisualStyleBackColor = true;
            // 
            // chkDiagGestacion
            // 
            this.chkDiagGestacion.AutoSize = true;
            this.chkDiagGestacion.Checked = true;
            this.chkDiagGestacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiagGestacion.Location = new System.Drawing.Point(9, 85);
            this.chkDiagGestacion.Name = "chkDiagGestacion";
            this.chkDiagGestacion.Size = new System.Drawing.Size(102, 17);
            this.chkDiagGestacion.TabIndex = 4;
            this.chkDiagGestacion.Text = "Diag. Gestación";
            this.chkDiagGestacion.UseVisualStyleBackColor = true;
            // 
            // chkInseminaciones
            // 
            this.chkInseminaciones.AutoSize = true;
            this.chkInseminaciones.Checked = true;
            this.chkInseminaciones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInseminaciones.Location = new System.Drawing.Point(9, 68);
            this.chkInseminaciones.Name = "chkInseminaciones";
            this.chkInseminaciones.Size = new System.Drawing.Size(99, 17);
            this.chkInseminaciones.TabIndex = 3;
            this.chkInseminaciones.Text = "Inseminaciones";
            this.chkInseminaciones.UseVisualStyleBackColor = true;
            // 
            // chkSincCelos
            // 
            this.chkSincCelos.AutoSize = true;
            this.chkSincCelos.Checked = true;
            this.chkSincCelos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSincCelos.Location = new System.Drawing.Point(9, 51);
            this.chkSincCelos.Name = "chkSincCelos";
            this.chkSincCelos.Size = new System.Drawing.Size(79, 17);
            this.chkSincCelos.TabIndex = 2;
            this.chkSincCelos.Text = "Sinc. Celos";
            this.chkSincCelos.UseVisualStyleBackColor = true;
            // 
            // chkCelos
            // 
            this.chkCelos.AutoSize = true;
            this.chkCelos.Checked = true;
            this.chkCelos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCelos.Location = new System.Drawing.Point(9, 34);
            this.chkCelos.Name = "chkCelos";
            this.chkCelos.Size = new System.Drawing.Size(52, 17);
            this.chkCelos.TabIndex = 1;
            this.chkCelos.Text = "Celos";
            this.chkCelos.UseVisualStyleBackColor = true;
            // 
            // chkGenealogia
            // 
            this.chkGenealogia.AutoSize = true;
            this.chkGenealogia.Checked = true;
            this.chkGenealogia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenealogia.Location = new System.Drawing.Point(9, 17);
            this.chkGenealogia.Name = "chkGenealogia";
            this.chkGenealogia.Size = new System.Drawing.Size(82, 17);
            this.chkGenealogia.TabIndex = 0;
            this.chkGenealogia.Text = "Genealogía";
            this.chkGenealogia.UseVisualStyleBackColor = true;
            // 
            // InfFichaAnimal
            // 
            this.Controls.Add(this.grpElementosMostrar);
            this.Controls.Add(this.lblFechafin);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnBuscarAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Name = "InfFichaAnimal";
            this.Size = new System.Drawing.Size(684, 127);
            this.grpElementosMostrar.ResumeLayout(false);
            this.grpElementosMostrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GEXVOC.Core.Controles.ctlBuscarObjeto cmbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblFechafin;
        private GEXVOC.Core.Controles.ctlFecha txtFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private GEXVOC.Core.Controles.ctlFecha txtFechaInicio;
        private System.Windows.Forms.CheckBox chkMostrarControles;
        private System.Windows.Forms.GroupBox grpElementosMostrar;
        private System.Windows.Forms.CheckBox chkGenealogia;
        private System.Windows.Forms.CheckBox chkLactaciones;
        private System.Windows.Forms.CheckBox chkAbortos;
        private System.Windows.Forms.CheckBox chkPartos;
        private System.Windows.Forms.CheckBox chkDiagGestacion;
        private System.Windows.Forms.CheckBox chkInseminaciones;
        private System.Windows.Forms.CheckBox chkSincCelos;
        private System.Windows.Forms.CheckBox chkCelos;
        private System.Windows.Forms.CheckBox chkIC;
        private System.Windows.Forms.CheckBox chkGMD;
        private System.Windows.Forms.CheckBox chkInformacionCanal;
        private System.Windows.Forms.CheckBox chkHistorialEnfermedades;
        private System.Windows.Forms.CheckBox chkCondicionesCorporales;
        private System.Windows.Forms.CheckBox chkPesos;
        private System.Windows.Forms.CheckBox chkSecados;
        private System.Windows.Forms.CheckBox chkCapacidadMaternal;
    }
}
