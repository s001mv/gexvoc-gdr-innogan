namespace GEXVOC.UI
{
    partial class CondicionCorporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CondicionCorporal));
            this.LAnimal = new System.Windows.Forms.Label();
            this.Ltipo = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.dgCondicionesCorporal = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.TbNombreVaca = new System.Windows.Forms.TextBox();
            this.PbBuscarHembra = new System.Windows.Forms.PictureBox();
            this.LEspecie = new System.Windows.Forms.Label();
            this.CbEspecie = new System.Windows.Forms.ComboBox();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PbBuscar = new System.Windows.Forms.PictureBox();
            this.PbAandir = new System.Windows.Forms.PictureBox();
            this.TbTipo = new System.Windows.Forms.TextBox();
            this.cbTipo2 = new System.Windows.Forms.ComboBox();
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
            this.LAnimal.Location = new System.Drawing.Point(2, 8);
            this.LAnimal.Name = "LAnimal";
            this.LAnimal.Size = new System.Drawing.Size(72, 18);
            this.LAnimal.Text = "Animal";
            // 
            // Ltipo
            // 
            this.Ltipo.Location = new System.Drawing.Point(2, 59);
            this.Ltipo.Name = "Ltipo";
            this.Ltipo.Size = new System.Drawing.Size(72, 18);
            this.Ltipo.Text = "Tipo";
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(3, 86);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(72, 18);
            this.LFecha.Text = "Fecha";
            // 
            // dgCondicionesCorporal
            // 
            this.dgCondicionesCorporal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgCondicionesCorporal.Location = new System.Drawing.Point(3, 107);
            this.dgCondicionesCorporal.Name = "dgCondicionesCorporal";
            this.dgCondicionesCorporal.Size = new System.Drawing.Size(234, 135);
            this.dgCondicionesCorporal.TabIndex = 7;
            this.dgCondicionesCorporal.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.MappingName = "CondicionCorporal";
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
            this.dataGridTextBoxColumn2.HeaderText = "Animal";
            this.dataGridTextBoxColumn2.MappingName = "Nombre";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Codigo Tipo";
            this.dataGridTextBoxColumn3.MappingName = "Codigo";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridTextBoxColumn4.MappingName = "Descripcion";
            // 
            // TbNombreVaca
            // 
            this.TbNombreVaca.Location = new System.Drawing.Point(82, 7);
            this.TbNombreVaca.Name = "TbNombreVaca";
            this.TbNombreVaca.Size = new System.Drawing.Size(128, 21);
            this.TbNombreVaca.TabIndex = 11;
            // 
            // PbBuscarHembra
            // 
            this.PbBuscarHembra.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscarHembra.Image")));
            this.PbBuscarHembra.Location = new System.Drawing.Point(218, 8);
            this.PbBuscarHembra.Name = "PbBuscarHembra";
            this.PbBuscarHembra.Size = new System.Drawing.Size(18, 19);
            this.PbBuscarHembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscarHembra.Click += new System.EventHandler(this.PbBuscarHembra_Click);
            // 
            // LEspecie
            // 
            this.LEspecie.Location = new System.Drawing.Point(3, 31);
            this.LEspecie.Name = "LEspecie";
            this.LEspecie.Size = new System.Drawing.Size(72, 18);
            this.LEspecie.Text = "Especie";
            // 
            // CbEspecie
            // 
            this.CbEspecie.Location = new System.Drawing.Point(85, 30);
            this.CbEspecie.Name = "CbEspecie";
            this.CbEspecie.Size = new System.Drawing.Size(124, 22);
            this.CbEspecie.TabIndex = 17;
            this.CbEspecie.SelectedValueChanged += new System.EventHandler(this.CbEspecie_SelectedValueChanged);
            // 
            // CbTipo
            // 
            this.CbTipo.Location = new System.Drawing.Point(86, 55);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(124, 22);
            this.CbTipo.TabIndex = 18;
            this.CbTipo.SelectedValueChanged += new System.EventHandler(this.CbTipo_SelectedValueChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(85, 85);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(89, 22);
            this.dtFecha.TabIndex = 24;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 21);
            this.textBox1.TabIndex = 25;
            // 
            // PbBuscar
            // 
            this.PbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscar.Image")));
            this.PbBuscar.Location = new System.Drawing.Point(180, 85);
            this.PbBuscar.Name = "PbBuscar";
            this.PbBuscar.Size = new System.Drawing.Size(29, 21);
            this.PbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscar.Click += new System.EventHandler(this.PbBuscar_Click);
            // 
            // PbAandir
            // 
            this.PbAandir.Image = ((System.Drawing.Image)(resources.GetObject("PbAandir.Image")));
            this.PbAandir.Location = new System.Drawing.Point(215, 85);
            this.PbAandir.Name = "PbAandir";
            this.PbAandir.Size = new System.Drawing.Size(22, 22);
            this.PbAandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAandir.Click += new System.EventHandler(this.PbAandir_Click);
            // 
            // TbTipo
            // 
            this.TbTipo.Location = new System.Drawing.Point(86, 55);
            this.TbTipo.Name = "TbTipo";
            this.TbTipo.Size = new System.Drawing.Size(108, 21);
            this.TbTipo.TabIndex = 31;
            // 
            // cbTipo2
            // 
            this.cbTipo2.Location = new System.Drawing.Point(47, 55);
            this.cbTipo2.Name = "cbTipo2";
            this.cbTipo2.Size = new System.Drawing.Size(85, 22);
            this.cbTipo2.TabIndex = 39;
            // 
            // CondicionCorporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.cbTipo2);
            this.Controls.Add(this.TbTipo);
            this.Controls.Add(this.PbAandir);
            this.Controls.Add(this.PbBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.CbEspecie);
            this.Controls.Add(this.LEspecie);
            this.Controls.Add(this.PbBuscarHembra);
            this.Controls.Add(this.TbNombreVaca);
            this.Controls.Add(this.dgCondicionesCorporal);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.Ltipo);
            this.Controls.Add(this.LAnimal);
            this.Name = "CondicionCorporal";
            this.Text = "Condicion Corporal";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.CondicionCorporal_Closing);
            this.Controls.SetChildIndex(this.LAnimal, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.Ltipo, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.dgCondicionesCorporal, 0);
            this.Controls.SetChildIndex(this.TbNombreVaca, 0);
            this.Controls.SetChildIndex(this.PbBuscarHembra, 0);
            this.Controls.SetChildIndex(this.LEspecie, 0);
            this.Controls.SetChildIndex(this.CbEspecie, 0);
            this.Controls.SetChildIndex(this.CbTipo, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.PbBuscar, 0);
            this.Controls.SetChildIndex(this.PbAandir, 0);
            this.Controls.SetChildIndex(this.TbTipo, 0);
            this.Controls.SetChildIndex(this.cbTipo2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LAnimal;
        private System.Windows.Forms.Label Ltipo;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.DataGrid dgCondicionesCorporal;
        private System.Windows.Forms.TextBox TbNombreVaca;
        private System.Windows.Forms.PictureBox PbBuscarHembra;
        private System.Windows.Forms.Label LEspecie;
        private System.Windows.Forms.ComboBox CbEspecie;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox PbBuscar;
        private System.Windows.Forms.PictureBox PbAandir;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.TextBox TbTipo;
        private System.Windows.Forms.ComboBox cbTipo2;
    }
}
