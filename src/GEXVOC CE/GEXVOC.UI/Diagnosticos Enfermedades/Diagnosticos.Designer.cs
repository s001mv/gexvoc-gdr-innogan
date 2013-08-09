namespace GEXVOC.UI
{
    partial class Diagnosticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosticos));
            this.LAnimal = new System.Windows.Forms.Label();
            this.LEnfermedad = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.TbAnimal = new System.Windows.Forms.TextBox();
            this.TbEnfermedad = new System.Windows.Forms.TextBox();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.PbFiltrar = new System.Windows.Forms.PictureBox();
            this.PbBuscarAnimal = new System.Windows.Forms.PictureBox();
            this.PbBuscarEnfermedad = new System.Windows.Forms.PictureBox();
            this.PbAnadir = new System.Windows.Forms.PictureBox();
            this.TbDesde = new System.Windows.Forms.TextBox();
            this.TbHasta = new System.Windows.Forms.TextBox();
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
            this.LAnimal.Location = new System.Drawing.Point(1, 1);
            this.LAnimal.Name = "LAnimal";
            this.LAnimal.Size = new System.Drawing.Size(80, 20);
            this.LAnimal.Text = "Animal";
            // 
            // LEnfermedad
            // 
            this.LEnfermedad.Location = new System.Drawing.Point(0, 31);
            this.LEnfermedad.Name = "LEnfermedad";
            this.LEnfermedad.Size = new System.Drawing.Size(80, 20);
            this.LEnfermedad.Text = "Enfermedad";
            // 
            // LDesde
            // 
            this.LDesde.Location = new System.Drawing.Point(1, 63);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(51, 20);
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.Location = new System.Drawing.Point(0, 97);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(45, 20);
            this.LHasta.Text = "Hasta";
            // 
            // TbAnimal
            // 
            this.TbAnimal.Location = new System.Drawing.Point(89, 1);
            this.TbAnimal.Name = "TbAnimal";
            this.TbAnimal.Size = new System.Drawing.Size(102, 21);
            this.TbAnimal.TabIndex = 9;
            // 
            // TbEnfermedad
            // 
            this.TbEnfermedad.Location = new System.Drawing.Point(89, 31);
            this.TbEnfermedad.Name = "TbEnfermedad";
            this.TbEnfermedad.Size = new System.Drawing.Size(102, 21);
            this.TbEnfermedad.TabIndex = 10;
            // 
            // dtpdesde
            // 
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(89, 63);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(85, 22);
            this.dtpdesde.TabIndex = 15;
            this.dtpdesde.ValueChanged += new System.EventHandler(this.dtpdesde_ValueChanged);
            // 
            // dtphasta
            // 
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(89, 97);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(85, 22);
            this.dtphasta.TabIndex = 16;
            this.dtphasta.ValueChanged += new System.EventHandler(this.dtphasta_ValueChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(12, 148);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(207, 99);
            this.dataGrid1.TabIndex = 17;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.MappingName = "DiagAnimal";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridTextBoxColumn1.MappingName = "Fecha";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridTextBoxColumn2.MappingName = "Nombre";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Diagnostico";
            this.dataGridTextBoxColumn3.MappingName = "Diagnostico";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Enfermedad";
            this.dataGridTextBoxColumn4.MappingName = "Descripcion";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Personal";
            this.dataGridTextBoxColumn5.MappingName = "NombreCompleto";
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.MappingName = "Id";
            this.dataGridTextBoxColumn6.Width = 0;
            // 
            // PbFiltrar
            // 
            this.PbFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("PbFiltrar.Image")));
            this.PbFiltrar.Location = new System.Drawing.Point(95, 123);
            this.PbFiltrar.Name = "PbFiltrar";
            this.PbFiltrar.Size = new System.Drawing.Size(26, 19);
            this.PbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFiltrar.Click += new System.EventHandler(this.PbFiltrar_Click);
            // 
            // PbBuscarAnimal
            // 
            this.PbBuscarAnimal.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscarAnimal.Image")));
            this.PbBuscarAnimal.Location = new System.Drawing.Point(193, 1);
            this.PbBuscarAnimal.Name = "PbBuscarAnimal";
            this.PbBuscarAnimal.Size = new System.Drawing.Size(26, 19);
            this.PbBuscarAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscarAnimal.Click += new System.EventHandler(this.PbBuscarAnimal_Click);
            // 
            // PbBuscarEnfermedad
            // 
            this.PbBuscarEnfermedad.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscarEnfermedad.Image")));
            this.PbBuscarEnfermedad.Location = new System.Drawing.Point(193, 31);
            this.PbBuscarEnfermedad.Name = "PbBuscarEnfermedad";
            this.PbBuscarEnfermedad.Size = new System.Drawing.Size(26, 19);
            this.PbBuscarEnfermedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscarEnfermedad.Click += new System.EventHandler(this.PbBuscarEnfermedad_Click);
            // 
            // PbAnadir
            // 
            this.PbAnadir.Image = ((System.Drawing.Image)(resources.GetObject("PbAnadir.Image")));
            this.PbAnadir.Location = new System.Drawing.Point(183, 123);
            this.PbAnadir.Name = "PbAnadir";
            this.PbAnadir.Size = new System.Drawing.Size(24, 19);
            this.PbAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnadir.Click += new System.EventHandler(this.PbAnadir_Click);
            // 
            // TbDesde
            // 
            this.TbDesde.Location = new System.Drawing.Point(89, 63);
            this.TbDesde.Name = "TbDesde";
            this.TbDesde.Size = new System.Drawing.Size(72, 21);
            this.TbDesde.TabIndex = 22;
            // 
            // TbHasta
            // 
            this.TbHasta.Location = new System.Drawing.Point(89, 98);
            this.TbHasta.Name = "TbHasta";
            this.TbHasta.Size = new System.Drawing.Size(72, 21);
            this.TbHasta.TabIndex = 23;
            // 
            // Diagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TbHasta);
            this.Controls.Add(this.TbDesde);
            this.Controls.Add(this.PbAnadir);
            this.Controls.Add(this.PbBuscarEnfermedad);
            this.Controls.Add(this.PbBuscarAnimal);
            this.Controls.Add(this.PbFiltrar);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.TbEnfermedad);
            this.Controls.Add(this.TbAnimal);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.LEnfermedad);
            this.Controls.Add(this.LAnimal);
            this.Name = "Diagnosticos";
            this.Text = "Diagnosticos";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Diagnosticos_Closing);
            this.Controls.SetChildIndex(this.LAnimal, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LEnfermedad, 0);
            this.Controls.SetChildIndex(this.LDesde, 0);
            this.Controls.SetChildIndex(this.LHasta, 0);
            this.Controls.SetChildIndex(this.TbAnimal, 0);
            this.Controls.SetChildIndex(this.TbEnfermedad, 0);
            this.Controls.SetChildIndex(this.dtpdesde, 0);
            this.Controls.SetChildIndex(this.dtphasta, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.PbFiltrar, 0);
            this.Controls.SetChildIndex(this.PbBuscarAnimal, 0);
            this.Controls.SetChildIndex(this.PbBuscarEnfermedad, 0);
            this.Controls.SetChildIndex(this.PbAnadir, 0);
            this.Controls.SetChildIndex(this.TbDesde, 0);
            this.Controls.SetChildIndex(this.TbHasta, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LAnimal;
        private System.Windows.Forms.Label LEnfermedad;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.TextBox TbAnimal;
        private System.Windows.Forms.TextBox TbEnfermedad;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.PictureBox PbFiltrar;
        private System.Windows.Forms.PictureBox PbBuscarAnimal;
        private System.Windows.Forms.PictureBox PbBuscarEnfermedad;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.PictureBox PbAnadir;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.TextBox TbDesde;
        private System.Windows.Forms.TextBox TbHasta;
    }
}
