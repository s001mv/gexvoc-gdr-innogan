namespace GEXVOC.UI
{
    partial class InsertarTratamientoEnfermedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarTratamientoEnfermedad));
            this.LDiagnostico = new System.Windows.Forms.Label();
            this.LPersonal = new System.Windows.Forms.Label();
            this.LSupresionLeche = new System.Windows.Forms.Label();
            this.LHasta1 = new System.Windows.Forms.Label();
            this.LSupresionCarnet = new System.Windows.Forms.Label();
            this.LFEcha = new System.Windows.Forms.Label();
            this.LDetalle = new System.Windows.Forms.Label();
            this.LHasta2 = new System.Windows.Forms.Label();
            this.LDuracion = new System.Windows.Forms.Label();
            this.TbDiagnostico = new System.Windows.Forms.TextBox();
            this.TbSupreLeche = new System.Windows.Forms.TextBox();
            this.TbSupreCarne = new System.Windows.Forms.TextBox();
            this.TbDuracion = new System.Windows.Forms.TextBox();
            this.TbDetalle = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PbBuscaDiagnostico = new System.Windows.Forms.PictureBox();
            this.CbPersonal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // LDiagnostico
            // 
            this.LDiagnostico.Location = new System.Drawing.Point(2, 7);
            this.LDiagnostico.Name = "LDiagnostico";
            this.LDiagnostico.Size = new System.Drawing.Size(81, 22);
            this.LDiagnostico.Text = "Diagnostico";
            // 
            // LPersonal
            // 
            this.LPersonal.Location = new System.Drawing.Point(3, 34);
            this.LPersonal.Name = "LPersonal";
            this.LPersonal.Size = new System.Drawing.Size(81, 22);
            this.LPersonal.Text = "Personal";
            // 
            // LSupresionLeche
            // 
            this.LSupresionLeche.Location = new System.Drawing.Point(3, 71);
            this.LSupresionLeche.Name = "LSupresionLeche";
            this.LSupresionLeche.Size = new System.Drawing.Size(65, 32);
            this.LSupresionLeche.Text = "Supresion (leche)";
            // 
            // LHasta1
            // 
            this.LHasta1.Location = new System.Drawing.Point(147, 71);
            this.LHasta1.Name = "LHasta1";
            this.LHasta1.Size = new System.Drawing.Size(54, 22);
            this.LHasta1.Text = "Hasta";
            // 
            // LSupresionCarnet
            // 
            this.LSupresionCarnet.Location = new System.Drawing.Point(3, 113);
            this.LSupresionCarnet.Name = "LSupresionCarnet";
            this.LSupresionCarnet.Size = new System.Drawing.Size(65, 34);
            this.LSupresionCarnet.Text = "Supresion (Carne)";
            // 
            // LFEcha
            // 
            this.LFEcha.Location = new System.Drawing.Point(3, 150);
            this.LFEcha.Name = "LFEcha";
            this.LFEcha.Size = new System.Drawing.Size(65, 22);
            this.LFEcha.Text = "Fecha";
            // 
            // LDetalle
            // 
            this.LDetalle.Location = new System.Drawing.Point(3, 205);
            this.LDetalle.Name = "LDetalle";
            this.LDetalle.Size = new System.Drawing.Size(81, 22);
            this.LDetalle.Text = "Detalle";
            // 
            // LHasta2
            // 
            this.LHasta2.Location = new System.Drawing.Point(147, 114);
            this.LHasta2.Name = "LHasta2";
            this.LHasta2.Size = new System.Drawing.Size(54, 22);
            this.LHasta2.Text = "Hasta";
            // 
            // LDuracion
            // 
            this.LDuracion.Location = new System.Drawing.Point(3, 177);
            this.LDuracion.Name = "LDuracion";
            this.LDuracion.Size = new System.Drawing.Size(66, 22);
            this.LDuracion.Text = "Duracion";
            // 
            // TbDiagnostico
            // 
            this.TbDiagnostico.Location = new System.Drawing.Point(80, 7);
            this.TbDiagnostico.Name = "TbDiagnostico";
            this.TbDiagnostico.ReadOnly = true;
            this.TbDiagnostico.Size = new System.Drawing.Size(121, 21);
            this.TbDiagnostico.TabIndex = 19;
            // 
            // TbSupreLeche
            // 
            this.TbSupreLeche.Location = new System.Drawing.Point(80, 71);
            this.TbSupreLeche.Name = "TbSupreLeche";
            this.TbSupreLeche.Size = new System.Drawing.Size(58, 21);
            this.TbSupreLeche.TabIndex = 21;
            // 
            // TbSupreCarne
            // 
            this.TbSupreCarne.Location = new System.Drawing.Point(74, 115);
            this.TbSupreCarne.Name = "TbSupreCarne";
            this.TbSupreCarne.Size = new System.Drawing.Size(58, 21);
            this.TbSupreCarne.TabIndex = 22;
            // 
            // TbDuracion
            // 
            this.TbDuracion.Location = new System.Drawing.Point(74, 178);
            this.TbDuracion.Name = "TbDuracion";
            this.TbDuracion.Size = new System.Drawing.Size(58, 21);
            this.TbDuracion.TabIndex = 23;
            // 
            // TbDetalle
            // 
            this.TbDetalle.Location = new System.Drawing.Point(74, 205);
            this.TbDetalle.Name = "TbDetalle";
            this.TbDetalle.Size = new System.Drawing.Size(145, 21);
            this.TbDetalle.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // PbBuscaDiagnostico
            // 
            this.PbBuscaDiagnostico.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscaDiagnostico.Image")));
            this.PbBuscaDiagnostico.Location = new System.Drawing.Point(207, 3);
            this.PbBuscaDiagnostico.Name = "PbBuscaDiagnostico";
            this.PbBuscaDiagnostico.Size = new System.Drawing.Size(20, 24);
            this.PbBuscaDiagnostico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscaDiagnostico.Click += new System.EventHandler(this.PbBuscaDiagnostico_Click);
            // 
            // CbPersonal
            // 
            this.CbPersonal.Location = new System.Drawing.Point(80, 32);
            this.CbPersonal.Name = "CbPersonal";
            this.CbPersonal.Size = new System.Drawing.Size(145, 22);
            this.CbPersonal.TabIndex = 35;
            // 
            // InsertarTratamientoEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.CbPersonal);
            this.Controls.Add(this.PbBuscaDiagnostico);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TbDetalle);
            this.Controls.Add(this.TbDuracion);
            this.Controls.Add(this.TbSupreCarne);
            this.Controls.Add(this.TbSupreLeche);
            this.Controls.Add(this.TbDiagnostico);
            this.Controls.Add(this.LDuracion);
            this.Controls.Add(this.LHasta2);
            this.Controls.Add(this.LDetalle);
            this.Controls.Add(this.LFEcha);
            this.Controls.Add(this.LSupresionCarnet);
            this.Controls.Add(this.LHasta1);
            this.Controls.Add(this.LSupresionLeche);
            this.Controls.Add(this.LPersonal);
            this.Controls.Add(this.LDiagnostico);
            this.Name = "InsertarTratamientoEnfermedad";
            this.Text = "Insertar Tratamiento";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarTratamientoEnfermedad_Closing);
            this.Controls.SetChildIndex(this.LDiagnostico, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LPersonal, 0);
            this.Controls.SetChildIndex(this.LSupresionLeche, 0);
            this.Controls.SetChildIndex(this.LHasta1, 0);
            this.Controls.SetChildIndex(this.LSupresionCarnet, 0);
            this.Controls.SetChildIndex(this.LFEcha, 0);
            this.Controls.SetChildIndex(this.LDetalle, 0);
            this.Controls.SetChildIndex(this.LHasta2, 0);
            this.Controls.SetChildIndex(this.LDuracion, 0);
            this.Controls.SetChildIndex(this.TbDiagnostico, 0);
            this.Controls.SetChildIndex(this.TbSupreLeche, 0);
            this.Controls.SetChildIndex(this.TbSupreCarne, 0);
            this.Controls.SetChildIndex(this.TbDuracion, 0);
            this.Controls.SetChildIndex(this.TbDetalle, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.PbBuscaDiagnostico, 0);
            this.Controls.SetChildIndex(this.CbPersonal, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LDiagnostico;
        private System.Windows.Forms.Label LPersonal;
        private System.Windows.Forms.Label LSupresionLeche;
        private System.Windows.Forms.Label LHasta1;
        private System.Windows.Forms.Label LSupresionCarnet;
        private System.Windows.Forms.Label LFEcha;
        private System.Windows.Forms.Label LDetalle;
        private System.Windows.Forms.Label LHasta2;
        private System.Windows.Forms.Label LDuracion;
        private System.Windows.Forms.TextBox TbDiagnostico;
        private System.Windows.Forms.TextBox TbSupreLeche;
        private System.Windows.Forms.TextBox TbSupreCarne;
        private System.Windows.Forms.TextBox TbDuracion;
        private System.Windows.Forms.TextBox TbDetalle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox PbBuscaDiagnostico;
        private System.Windows.Forms.ComboBox CbPersonal;
    }
}
