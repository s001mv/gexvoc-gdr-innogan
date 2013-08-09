namespace GEXVOC.UI
{
    partial class InsertarInseminacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarInseminacion));
            this.LTipo = new System.Windows.Forms.Label();
            this.Cbtipo = new System.Windows.Forms.ComboBox();
            this.LEmbrion = new System.Windows.Forms.Label();
            this.Ldosis = new System.Windows.Forms.Label();
            this.TbDosis = new System.Windows.Forms.TextBox();
            this.LHembra = new System.Windows.Forms.Label();
            this.LMacho = new System.Windows.Forms.Label();
            this.CbMachos = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.LFecha = new System.Windows.Forms.Label();
            this.PictureBoxBuscarHembra = new System.Windows.Forms.PictureBox();
            this.TbHembra = new System.Windows.Forms.TextBox();
            this.LInseminador = new System.Windows.Forms.Label();
            this.CbInseminador = new System.Windows.Forms.ComboBox();
            this.TbEmbrion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(3, 0);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(51, 22);
            this.LTipo.Text = "Tipo";
            // 
            // Cbtipo
            // 
            this.Cbtipo.Location = new System.Drawing.Point(90, 0);
            this.Cbtipo.Name = "Cbtipo";
            this.Cbtipo.Size = new System.Drawing.Size(129, 22);
            this.Cbtipo.TabIndex = 3;
            this.Cbtipo.SelectedValueChanged += new System.EventHandler(this.Cbtipo_SelectedValueChanged);
            // 
            // LEmbrion
            // 
            this.LEmbrion.Location = new System.Drawing.Point(3, 30);
            this.LEmbrion.Name = "LEmbrion";
            this.LEmbrion.Size = new System.Drawing.Size(51, 22);
            this.LEmbrion.Text = "Embrion";
            // 
            // Ldosis
            // 
            this.Ldosis.Location = new System.Drawing.Point(3, 60);
            this.Ldosis.Name = "Ldosis";
            this.Ldosis.Size = new System.Drawing.Size(56, 22);
            this.Ldosis.Text = "Dosis";
            // 
            // TbDosis
            // 
            this.TbDosis.Location = new System.Drawing.Point(90, 60);
            this.TbDosis.Name = "TbDosis";
            this.TbDosis.Size = new System.Drawing.Size(28, 21);
            this.TbDosis.TabIndex = 7;
            // 
            // LHembra
            // 
            this.LHembra.Location = new System.Drawing.Point(3, 90);
            this.LHembra.Name = "LHembra";
            this.LHembra.Size = new System.Drawing.Size(66, 22);
            this.LHembra.Text = "Hembra";
            // 
            // LMacho
            // 
            this.LMacho.Location = new System.Drawing.Point(3, 120);
            this.LMacho.Name = "LMacho";
            this.LMacho.Size = new System.Drawing.Size(69, 22);
            this.LMacho.Text = "Macho";
            // 
            // CbMachos
            // 
            this.CbMachos.Location = new System.Drawing.Point(90, 120);
            this.CbMachos.Name = "CbMachos";
            this.CbMachos.Size = new System.Drawing.Size(117, 22);
            this.CbMachos.TabIndex = 11;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(90, 180);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(90, 22);
            this.dtFecha.TabIndex = 23;
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(3, 180);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(66, 20);
            this.LFecha.Text = "Fecha";
            // 
            // PictureBoxBuscarHembra
            // 
            this.PictureBoxBuscarHembra.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxBuscarHembra.Image")));
            this.PictureBoxBuscarHembra.Location = new System.Drawing.Point(213, 90);
            this.PictureBoxBuscarHembra.Name = "PictureBoxBuscarHembra";
            this.PictureBoxBuscarHembra.Size = new System.Drawing.Size(21, 21);
            this.PictureBoxBuscarHembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBuscarHembra.Click += new System.EventHandler(this.PictureBoxBuscarHembra_Click);
            // 
            // TbHembra
            // 
            this.TbHembra.Location = new System.Drawing.Point(90, 90);
            this.TbHembra.Name = "TbHembra";
            this.TbHembra.ReadOnly = true;
            this.TbHembra.Size = new System.Drawing.Size(117, 21);
            this.TbHembra.TabIndex = 30;
            // 
            // LInseminador
            // 
            this.LInseminador.Location = new System.Drawing.Point(3, 150);
            this.LInseminador.Name = "LInseminador";
            this.LInseminador.Size = new System.Drawing.Size(81, 22);
            this.LInseminador.Text = "Inseminador";
            // 
            // CbInseminador
            // 
            this.CbInseminador.Location = new System.Drawing.Point(90, 150);
            this.CbInseminador.Name = "CbInseminador";
            this.CbInseminador.Size = new System.Drawing.Size(117, 22);
            this.CbInseminador.TabIndex = 39;
            // 
            // TbEmbrion
            // 
            this.TbEmbrion.Location = new System.Drawing.Point(90, 30);
            this.TbEmbrion.Name = "TbEmbrion";
            this.TbEmbrion.ReadOnly = true;
            this.TbEmbrion.Size = new System.Drawing.Size(117, 21);
            this.TbEmbrion.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InsertarInseminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbEmbrion);
            this.Controls.Add(this.TbHembra);
            this.Controls.Add(this.CbInseminador);
            this.Controls.Add(this.PictureBoxBuscarHembra);
            this.Controls.Add(this.LInseminador);
            this.Controls.Add(this.LMacho);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.Ldosis);
            this.Controls.Add(this.LHembra);
            this.Controls.Add(this.CbMachos);
            this.Controls.Add(this.LEmbrion);
            this.Controls.Add(this.TbDosis);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.Cbtipo);
            this.Name = "InsertarInseminacion";
            this.Text = "Insertar Inseminacion";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarInseminacion_Closing);
            this.Controls.SetChildIndex(this.Cbtipo, 0);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.TbDosis, 0);
            this.Controls.SetChildIndex(this.LEmbrion, 0);
            this.Controls.SetChildIndex(this.CbMachos, 0);
            this.Controls.SetChildIndex(this.LHembra, 0);
            this.Controls.SetChildIndex(this.Ldosis, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.LMacho, 0);
            this.Controls.SetChildIndex(this.LInseminador, 0);
            this.Controls.SetChildIndex(this.PictureBoxBuscarHembra, 0);
            this.Controls.SetChildIndex(this.CbInseminador, 0);
            this.Controls.SetChildIndex(this.TbHembra, 0);
            this.Controls.SetChildIndex(this.TbEmbrion, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.ComboBox Cbtipo;
        private System.Windows.Forms.Label LEmbrion;
        private System.Windows.Forms.Label Ldosis;
        private System.Windows.Forms.TextBox TbDosis;
        private System.Windows.Forms.Label LHembra;
        private System.Windows.Forms.Label LMacho;
        private System.Windows.Forms.ComboBox CbMachos;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.PictureBox PictureBoxBuscarHembra;
        private System.Windows.Forms.TextBox TbHembra;
        private System.Windows.Forms.Label LInseminador;
        private System.Windows.Forms.ComboBox CbInseminador;
        private System.Windows.Forms.TextBox TbEmbrion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
