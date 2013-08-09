namespace GEXVOC.UI
{
    partial class InsertarDiagnosticoEnfermedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarDiagnosticoEnfermedad));
            this.LAnimal = new System.Windows.Forms.Label();
            this.LEnfermedad = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LDiagnostico = new System.Windows.Forms.Label();
            this.LPersonal = new System.Windows.Forms.Label();
            this.TbAnimal = new System.Windows.Forms.TextBox();
            this.TbEnfermedad = new System.Windows.Forms.TextBox();
            this.DtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.PbBuscaAnimal = new System.Windows.Forms.PictureBox();
            this.PbEnfermedad = new System.Windows.Forms.PictureBox();
            this.PBPersonal = new System.Windows.Forms.PictureBox();
            this.CbInseminador = new System.Windows.Forms.ComboBox();
            this.TBPersonal = new System.Windows.Forms.TextBox();
            this.tbdiagnostico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // LAnimal
            // 
            this.LAnimal.Location = new System.Drawing.Point(5, 9);
            this.LAnimal.Name = "LAnimal";
            this.LAnimal.Size = new System.Drawing.Size(62, 22);
            this.LAnimal.Text = "Animal";
            // 
            // LEnfermedad
            // 
            this.LEnfermedad.Location = new System.Drawing.Point(5, 46);
            this.LEnfermedad.Name = "LEnfermedad";
            this.LEnfermedad.Size = new System.Drawing.Size(81, 22);
            this.LEnfermedad.Text = "Enfermedad";
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(5, 88);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(62, 22);
            this.LFecha.Text = "Fecha";
            // 
            // LDiagnostico
            // 
            this.LDiagnostico.Location = new System.Drawing.Point(5, 161);
            this.LDiagnostico.Name = "LDiagnostico";
            this.LDiagnostico.Size = new System.Drawing.Size(86, 22);
            this.LDiagnostico.Text = "Diagnostico";
            // 
            // LPersonal
            // 
            this.LPersonal.Location = new System.Drawing.Point(5, 128);
            this.LPersonal.Name = "LPersonal";
            this.LPersonal.Size = new System.Drawing.Size(62, 22);
            this.LPersonal.Text = "Personal";
            // 
            // TbAnimal
            // 
            this.TbAnimal.Location = new System.Drawing.Point(92, 9);
            this.TbAnimal.Name = "TbAnimal";
            this.TbAnimal.ReadOnly = true;
            this.TbAnimal.Size = new System.Drawing.Size(109, 21);
            this.TbAnimal.TabIndex = 7;
            // 
            // TbEnfermedad
            // 
            this.TbEnfermedad.Location = new System.Drawing.Point(92, 46);
            this.TbEnfermedad.Name = "TbEnfermedad";
            this.TbEnfermedad.ReadOnly = true;
            this.TbEnfermedad.Size = new System.Drawing.Size(109, 21);
            this.TbEnfermedad.TabIndex = 8;
            // 
            // DtFecha1
            // 
            this.DtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFecha1.Location = new System.Drawing.Point(92, 88);
            this.DtFecha1.Name = "DtFecha1";
            this.DtFecha1.Size = new System.Drawing.Size(108, 22);
            this.DtFecha1.TabIndex = 10;
            // 
            // PbBuscaAnimal
            // 
            this.PbBuscaAnimal.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscaAnimal.Image")));
            this.PbBuscaAnimal.Location = new System.Drawing.Point(206, 10);
            this.PbBuscaAnimal.Name = "PbBuscaAnimal";
            this.PbBuscaAnimal.Size = new System.Drawing.Size(22, 19);
            this.PbBuscaAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscaAnimal.Click += new System.EventHandler(this.PbBuscaAnimal_Click);
            // 
            // PbEnfermedad
            // 
            this.PbEnfermedad.Image = ((System.Drawing.Image)(resources.GetObject("PbEnfermedad.Image")));
            this.PbEnfermedad.Location = new System.Drawing.Point(206, 46);
            this.PbEnfermedad.Name = "PbEnfermedad";
            this.PbEnfermedad.Size = new System.Drawing.Size(22, 19);
            this.PbEnfermedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbEnfermedad.Click += new System.EventHandler(this.PbEnfermedad_Click);
            // 
            // PBPersonal
            // 
            this.PBPersonal.Image = ((System.Drawing.Image)(resources.GetObject("PBPersonal.Image")));
            this.PBPersonal.Location = new System.Drawing.Point(206, 130);
            this.PBPersonal.Name = "PBPersonal";
            this.PBPersonal.Size = new System.Drawing.Size(22, 19);
            this.PBPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPersonal.Click += new System.EventHandler(this.PBPersonal_Click);
            // 
            // CbInseminador
            // 
            this.CbInseminador.Location = new System.Drawing.Point(92, 128);
            this.CbInseminador.Name = "CbInseminador";
            this.CbInseminador.Size = new System.Drawing.Size(106, 22);
            this.CbInseminador.TabIndex = 16;
            this.CbInseminador.SelectedIndexChanged += new System.EventHandler(this.CbInseminador_SelectedIndexChanged);
            // 
            // TBPersonal
            // 
            this.TBPersonal.Location = new System.Drawing.Point(92, 128);
            this.TBPersonal.Name = "TBPersonal";
            this.TBPersonal.Size = new System.Drawing.Size(93, 21);
            this.TBPersonal.TabIndex = 17;
            // 
            // tbdiagnostico
            // 
            this.tbdiagnostico.Location = new System.Drawing.Point(8, 182);
            this.tbdiagnostico.Name = "tbdiagnostico";
            this.tbdiagnostico.Size = new System.Drawing.Size(210, 21);
            this.tbdiagnostico.TabIndex = 26;
            // 
            // InsertarDiagnosticoEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tbdiagnostico);
            this.Controls.Add(this.TBPersonal);
            this.Controls.Add(this.CbInseminador);
            this.Controls.Add(this.PBPersonal);
            this.Controls.Add(this.PbEnfermedad);
            this.Controls.Add(this.PbBuscaAnimal);
            this.Controls.Add(this.DtFecha1);
            this.Controls.Add(this.TbEnfermedad);
            this.Controls.Add(this.TbAnimal);
            this.Controls.Add(this.LPersonal);
            this.Controls.Add(this.LDiagnostico);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LEnfermedad);
            this.Controls.Add(this.LAnimal);
            this.Name = "InsertarDiagnosticoEnfermedad";
            this.Text = "Insertar Diagnostico";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarDiagnosticoEnfermedad_Closing);
            this.Controls.SetChildIndex(this.LAnimal, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LEnfermedad, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.LDiagnostico, 0);
            this.Controls.SetChildIndex(this.LPersonal, 0);
            this.Controls.SetChildIndex(this.TbAnimal, 0);
            this.Controls.SetChildIndex(this.TbEnfermedad, 0);
            this.Controls.SetChildIndex(this.DtFecha1, 0);
            this.Controls.SetChildIndex(this.PbBuscaAnimal, 0);
            this.Controls.SetChildIndex(this.PbEnfermedad, 0);
            this.Controls.SetChildIndex(this.PBPersonal, 0);
            this.Controls.SetChildIndex(this.CbInseminador, 0);
            this.Controls.SetChildIndex(this.TBPersonal, 0);
            this.Controls.SetChildIndex(this.tbdiagnostico, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LAnimal;
        private System.Windows.Forms.Label LEnfermedad;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LDiagnostico;
        private System.Windows.Forms.Label LPersonal;
        private System.Windows.Forms.TextBox TbAnimal;
        private System.Windows.Forms.TextBox TbEnfermedad;
        private System.Windows.Forms.DateTimePicker DtFecha1;
        private System.Windows.Forms.PictureBox PbBuscaAnimal;
        private System.Windows.Forms.PictureBox PbEnfermedad;
        private System.Windows.Forms.PictureBox PBPersonal;
        private System.Windows.Forms.ComboBox CbInseminador;
        private System.Windows.Forms.TextBox TBPersonal;
        private System.Windows.Forms.TextBox tbdiagnostico;
    }
}
