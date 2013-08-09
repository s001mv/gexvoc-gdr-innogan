namespace GEXVOC.UI
{
    partial class Partos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partos));
            this.dgPartos = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.LTipo = new System.Windows.Forms.Label();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.LHembra = new System.Windows.Forms.Label();
            this.TbTipo = new System.Windows.Forms.TextBox();
            this.Tbhembra = new System.Windows.Forms.TextBox();
            this.PbBuscarHembra = new System.Windows.Forms.PictureBox();
            this.LDificultad = new System.Windows.Forms.Label();
            this.CbDificultad = new System.Windows.Forms.ComboBox();
            this.TbDificultad = new System.Windows.Forms.TextBox();
            this.LVivos = new System.Windows.Forms.Label();
            this.TbVivos = new System.Windows.Forms.TextBox();
            this.LMuertos = new System.Windows.Forms.Label();
            this.TbMuertos = new System.Windows.Forms.TextBox();
            this.LfechaDesde = new System.Windows.Forms.Label();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.TbDesde = new System.Windows.Forms.TextBox();
            this.TbHasta = new System.Windows.Forms.TextBox();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.Lfechaasta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbAnadir = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Size = new System.Drawing.Size(227, 20);
            // 
            // dgPartos
            // 
            this.dgPartos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgPartos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgPartos.Location = new System.Drawing.Point(0, 262);
            this.dgPartos.Name = "dgPartos";
            this.dgPartos.Size = new System.Drawing.Size(227, 100);
            this.dgPartos.TabIndex = 2;
            this.dgPartos.TableStyles.Add(this.dataGridTableStyle1);
            this.dgPartos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgPartos_MouseUp);
            this.dgPartos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgPartos_MouseDown);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.MappingName = "Parto";
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
            this.dataGridTextBoxColumn2.HeaderText = "Hembra";
            this.dataGridTextBoxColumn2.MappingName = "Nombre";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridTextBoxColumn3.MappingName = "DescripcionTipoParto";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Facilidad";
            this.dataGridTextBoxColumn4.MappingName = "Descripcion";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Vivos";
            this.dataGridTextBoxColumn5.MappingName = "Vivos";
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Muertos";
            this.dataGridTextBoxColumn6.MappingName = "Muertos";
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(4, 8);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(38, 19);
            this.LTipo.Text = "Tipo";
            // 
            // CBTipo
            // 
            this.CBTipo.Location = new System.Drawing.Point(77, 6);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(142, 22);
            this.CBTipo.TabIndex = 4;
            this.CBTipo.SelectedValueChanged += new System.EventHandler(this.CBTipo_SelectedValueChanged);
            // 
            // LHembra
            // 
            this.LHembra.Location = new System.Drawing.Point(4, 31);
            this.LHembra.Name = "LHembra";
            this.LHembra.Size = new System.Drawing.Size(51, 21);
            this.LHembra.Text = "Hembra";
            // 
            // TbTipo
            // 
            this.TbTipo.Location = new System.Drawing.Point(77, 6);
            this.TbTipo.Name = "TbTipo";
            this.TbTipo.Size = new System.Drawing.Size(129, 21);
            this.TbTipo.TabIndex = 9;
            // 
            // Tbhembra
            // 
            this.Tbhembra.Location = new System.Drawing.Point(77, 31);
            this.Tbhembra.Name = "Tbhembra";
            this.Tbhembra.Size = new System.Drawing.Size(116, 21);
            this.Tbhembra.TabIndex = 10;
            // 
            // PbBuscarHembra
            // 
            this.PbBuscarHembra.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscarHembra.Image")));
            this.PbBuscarHembra.Location = new System.Drawing.Point(199, 31);
            this.PbBuscarHembra.Name = "PbBuscarHembra";
            this.PbBuscarHembra.Size = new System.Drawing.Size(20, 21);
            this.PbBuscarHembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscarHembra.Click += new System.EventHandler(this.PbBuscarHembra_Click);
            // 
            // LDificultad
            // 
            this.LDificultad.Location = new System.Drawing.Point(4, 65);
            this.LDificultad.Name = "LDificultad";
            this.LDificultad.Size = new System.Drawing.Size(57, 20);
            this.LDificultad.Text = "Dificultad";
            // 
            // CbDificultad
            // 
            this.CbDificultad.Location = new System.Drawing.Point(77, 64);
            this.CbDificultad.Name = "CbDificultad";
            this.CbDificultad.Size = new System.Drawing.Size(142, 22);
            this.CbDificultad.TabIndex = 13;
            this.CbDificultad.SelectedValueChanged += new System.EventHandler(this.CbDificultad_SelectedValueChanged);
            // 
            // TbDificultad
            // 
            this.TbDificultad.Location = new System.Drawing.Point(77, 64);
            this.TbDificultad.Name = "TbDificultad";
            this.TbDificultad.Size = new System.Drawing.Size(126, 21);
            this.TbDificultad.TabIndex = 14;
            // 
            // LVivos
            // 
            this.LVivos.Location = new System.Drawing.Point(3, 90);
            this.LVivos.Name = "LVivos";
            this.LVivos.Size = new System.Drawing.Size(38, 19);
            this.LVivos.Text = "Vivos";
            // 
            // TbVivos
            // 
            this.TbVivos.Location = new System.Drawing.Point(51, 88);
            this.TbVivos.Name = "TbVivos";
            this.TbVivos.Size = new System.Drawing.Size(38, 21);
            this.TbVivos.TabIndex = 16;
            this.TbVivos.TextChanged += new System.EventHandler(this.TbVivos_TextChanged);
            // 
            // LMuertos
            // 
            this.LMuertos.Location = new System.Drawing.Point(106, 88);
            this.LMuertos.Name = "LMuertos";
            this.LMuertos.Size = new System.Drawing.Size(53, 21);
            this.LMuertos.Text = "Muertos";
            // 
            // TbMuertos
            // 
            this.TbMuertos.Location = new System.Drawing.Point(165, 88);
            this.TbMuertos.Name = "TbMuertos";
            this.TbMuertos.Size = new System.Drawing.Size(38, 21);
            this.TbMuertos.TabIndex = 18;
            this.TbMuertos.TextChanged += new System.EventHandler(this.TbMuertos_TextChanged);
            // 
            // LfechaDesde
            // 
            this.LfechaDesde.Location = new System.Drawing.Point(3, 120);
            this.LfechaDesde.Name = "LfechaDesde";
            this.LfechaDesde.Size = new System.Drawing.Size(86, 20);
            this.LfechaDesde.Text = "Fecha (desde)";
            // 
            // dtpdesde
            // 
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(106, 120);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(91, 22);
            this.dtpdesde.TabIndex = 26;
            this.dtpdesde.ValueChanged += new System.EventHandler(this.dtpdesde_ValueChanged);
            // 
            // TbDesde
            // 
            this.TbDesde.Location = new System.Drawing.Point(106, 120);
            this.TbDesde.Name = "TbDesde";
            this.TbDesde.Size = new System.Drawing.Size(80, 21);
            this.TbDesde.TabIndex = 27;
            // 
            // TbHasta
            // 
            this.TbHasta.Location = new System.Drawing.Point(106, 148);
            this.TbHasta.Name = "TbHasta";
            this.TbHasta.Size = new System.Drawing.Size(80, 21);
            this.TbHasta.TabIndex = 30;
            // 
            // dtphasta
            // 
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(106, 148);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(91, 22);
            this.dtphasta.TabIndex = 29;
            this.dtphasta.ValueChanged += new System.EventHandler(this.dtphasta_ValueChanged);
            // 
            // Lfechaasta
            // 
            this.Lfechaasta.Location = new System.Drawing.Point(8, 148);
            this.Lfechaasta.Name = "Lfechaasta";
            this.Lfechaasta.Size = new System.Drawing.Size(86, 20);
            this.Lfechaasta.Text = "Fecha (hasta)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbAnadir
            // 
            this.pbAnadir.Image = ((System.Drawing.Image)(resources.GetObject("pbAnadir.Image")));
            this.pbAnadir.Location = new System.Drawing.Point(197, 173);
            this.pbAnadir.Name = "pbAnadir";
            this.pbAnadir.Size = new System.Drawing.Size(21, 16);
            this.pbAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnadir.Click += new System.EventHandler(this.pbAnadir_Click);
            // 
            // Partos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pbAnadir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbHasta);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.Lfechaasta);
            this.Controls.Add(this.TbDesde);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.LfechaDesde);
            this.Controls.Add(this.TbVivos);
            this.Controls.Add(this.TbMuertos);
            this.Controls.Add(this.LVivos);
            this.Controls.Add(this.PbBuscarHembra);
            this.Controls.Add(this.LMuertos);
            this.Controls.Add(this.TbDificultad);
            this.Controls.Add(this.CbDificultad);
            this.Controls.Add(this.LDificultad);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.dgPartos);
            this.Controls.Add(this.Tbhembra);
            this.Controls.Add(this.LHembra);
            this.Controls.Add(this.TbTipo);
            this.Controls.Add(this.CBTipo);
            this.Name = "Partos";
            this.Text = "Partos";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Partos_Closing);
            this.Controls.SetChildIndex(this.CBTipo, 0);
            this.Controls.SetChildIndex(this.TbTipo, 0);
            this.Controls.SetChildIndex(this.LHembra, 0);
            this.Controls.SetChildIndex(this.Tbhembra, 0);
            this.Controls.SetChildIndex(this.dgPartos, 0);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.LDificultad, 0);
            this.Controls.SetChildIndex(this.CbDificultad, 0);
            this.Controls.SetChildIndex(this.TbDificultad, 0);
            this.Controls.SetChildIndex(this.LMuertos, 0);
            this.Controls.SetChildIndex(this.PbBuscarHembra, 0);
            this.Controls.SetChildIndex(this.LVivos, 0);
            this.Controls.SetChildIndex(this.TbMuertos, 0);
            this.Controls.SetChildIndex(this.TbVivos, 0);
            this.Controls.SetChildIndex(this.LfechaDesde, 0);
            this.Controls.SetChildIndex(this.dtpdesde, 0);
            this.Controls.SetChildIndex(this.TbDesde, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.Lfechaasta, 0);
            this.Controls.SetChildIndex(this.dtphasta, 0);
            this.Controls.SetChildIndex(this.TbHasta, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pbAnadir, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dgPartos;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Label LHembra;
        private System.Windows.Forms.TextBox TbTipo;
        private System.Windows.Forms.TextBox Tbhembra;
        private System.Windows.Forms.PictureBox PbBuscarHembra;
        private System.Windows.Forms.Label LDificultad;
        private System.Windows.Forms.ComboBox CbDificultad;
        private System.Windows.Forms.TextBox TbDificultad;
        private System.Windows.Forms.Label LVivos;
        private System.Windows.Forms.TextBox TbVivos;
        private System.Windows.Forms.Label LMuertos;
        private System.Windows.Forms.TextBox TbMuertos;
        private System.Windows.Forms.Label LfechaDesde;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.TextBox TbDesde;
        private System.Windows.Forms.TextBox TbHasta;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Label Lfechaasta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.PictureBox pbAnadir;
    }
}
