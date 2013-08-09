namespace GEXVOC.UI
{
    partial class Tratamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tratamientos));
            this.LAnimal = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.PbBuscaAnimal = new System.Windows.Forms.PictureBox();
            this.PbFiltra = new System.Windows.Forms.PictureBox();
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
            this.LAnimal.Location = new System.Drawing.Point(3, 1);
            this.LAnimal.Name = "LAnimal";
            this.LAnimal.Size = new System.Drawing.Size(53, 20);
            this.LAnimal.Text = "Animal";
            // 
            // LDesde
            // 
            this.LDesde.Location = new System.Drawing.Point(3, 31);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(122, 20);
            this.LDesde.Text = "F.Tratamiento desde";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(85, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.Text = "hasta";
            // 
            // dtpdesde
            // 
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(143, 29);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(85, 22);
            this.dtpdesde.TabIndex = 7;
            this.dtpdesde.ValueChanged += new System.EventHandler(this.dtpdesde_ValueChanged);
            // 
            // dtphasta
            // 
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(142, 57);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(85, 22);
            this.dtphasta.TabIndex = 8;
            this.dtphasta.ValueChanged += new System.EventHandler(this.dtphasta_ValueChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(8, 116);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(219, 118);
            this.dataGrid1.TabIndex = 12;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.MappingName = "TratEnfermedad";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridTextBoxColumn1.MappingName = "FechaTratamiento";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Animal";
            this.dataGridTextBoxColumn5.MappingName = "NombreAnimal";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Detalle";
            this.dataGridTextBoxColumn2.MappingName = "DetalleTratamiento";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Duracion";
            this.dataGridTextBoxColumn3.MappingName = "DuracionTratamiento";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Personal";
            this.dataGridTextBoxColumn4.MappingName = "NombreCompleto";
            // 
            // tbAnimal
            // 
            this.tbAnimal.Location = new System.Drawing.Point(62, 1);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(136, 21);
            this.tbAnimal.TabIndex = 16;
            // 
            // PbBuscaAnimal
            // 
            this.PbBuscaAnimal.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscaAnimal.Image")));
            this.PbBuscaAnimal.Location = new System.Drawing.Point(208, 1);
            this.PbBuscaAnimal.Name = "PbBuscaAnimal";
            this.PbBuscaAnimal.Size = new System.Drawing.Size(20, 21);
            this.PbBuscaAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscaAnimal.Click += new System.EventHandler(this.PbBuscaAnimal_Click);
            // 
            // PbFiltra
            // 
            this.PbFiltra.Image = ((System.Drawing.Image)(resources.GetObject("PbFiltra.Image")));
            this.PbFiltra.Location = new System.Drawing.Point(105, 82);
            this.PbFiltra.Name = "PbFiltra";
            this.PbFiltra.Size = new System.Drawing.Size(29, 28);
            this.PbFiltra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFiltra.Click += new System.EventHandler(this.PbFiltra_Click);
            // 
            // PbAnadir
            // 
            this.PbAnadir.Image = ((System.Drawing.Image)(resources.GetObject("PbAnadir.Image")));
            this.PbAnadir.Location = new System.Drawing.Point(190, 82);
            this.PbAnadir.Name = "PbAnadir";
            this.PbAnadir.Size = new System.Drawing.Size(29, 28);
            this.PbAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnadir.Click += new System.EventHandler(this.PbAnadir_Click);
            // 
            // TbDesde
            // 
            this.TbDesde.Location = new System.Drawing.Point(142, 29);
            this.TbDesde.Name = "TbDesde";
            this.TbDesde.Size = new System.Drawing.Size(77, 21);
            this.TbDesde.TabIndex = 20;
            // 
            // TbHasta
            // 
            this.TbHasta.Location = new System.Drawing.Point(142, 57);
            this.TbHasta.Name = "TbHasta";
            this.TbHasta.Size = new System.Drawing.Size(77, 21);
            this.TbHasta.TabIndex = 21;
            // 
            // Tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TbHasta);
            this.Controls.Add(this.TbDesde);
            this.Controls.Add(this.PbAnadir);
            this.Controls.Add(this.PbFiltra);
            this.Controls.Add(this.PbBuscaAnimal);
            this.Controls.Add(this.tbAnimal);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.LAnimal);
            this.Name = "Tratamientos";
            this.Text = "Tratamientos";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Tratamientos_Closing);
            this.Controls.SetChildIndex(this.LAnimal, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LDesde, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtpdesde, 0);
            this.Controls.SetChildIndex(this.dtphasta, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.tbAnimal, 0);
            this.Controls.SetChildIndex(this.PbBuscaAnimal, 0);
            this.Controls.SetChildIndex(this.PbFiltra, 0);
            this.Controls.SetChildIndex(this.PbAnadir, 0);
            this.Controls.SetChildIndex(this.TbDesde, 0);
            this.Controls.SetChildIndex(this.TbHasta, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LAnimal;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.TextBox tbAnimal;
        private System.Windows.Forms.PictureBox PbBuscaAnimal;
        private System.Windows.Forms.PictureBox PbFiltra;
        private System.Windows.Forms.PictureBox PbAnadir;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.TextBox TbDesde;
        private System.Windows.Forms.TextBox TbHasta;
    }
}
