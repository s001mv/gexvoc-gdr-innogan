namespace GEXVOC.UI
{
    partial class Inseminaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inseminaciones));
            this.DgInseminaciones = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Ltipo = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.Lfecha = new System.Windows.Forms.Label();
            this.Dtfecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Añadir = new System.Windows.Forms.PictureBox();
            this.LHembra = new System.Windows.Forms.Label();
            this.cBHembra = new System.Windows.Forms.ComboBox();
            this.LMacho = new System.Windows.Forms.Label();
            this.cbMachos = new System.Windows.Forms.ComboBox();
            this.TbMacho = new System.Windows.Forms.TextBox();
            this.TbHembra = new System.Windows.Forms.TextBox();
            this.TbTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 250);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // DgInseminaciones
            // 
            this.DgInseminaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DgInseminaciones.Location = new System.Drawing.Point(3, 141);
            this.DgInseminaciones.Name = "DgInseminaciones";
            this.DgInseminaciones.Size = new System.Drawing.Size(234, 103);
            this.DgInseminaciones.TabIndex = 2;
            this.DgInseminaciones.TableStyles.Add(this.dataGridTableStyle1);
            this.DgInseminaciones.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DgInseminaciones_MouseUp);
            this.DgInseminaciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgInseminaciones_MouseDown);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.MappingName = "Inseminacion";
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
            this.dataGridTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridTextBoxColumn2.MappingName = "Descripcion";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Hembra";
            this.dataGridTextBoxColumn3.MappingName = "Hembra";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Macho";
            this.dataGridTextBoxColumn4.MappingName = "Macho";
            // 
            // Ltipo
            // 
            this.Ltipo.Location = new System.Drawing.Point(3, 0);
            this.Ltipo.Name = "Ltipo";
            this.Ltipo.Size = new System.Drawing.Size(40, 22);
            this.Ltipo.Text = "Tipo";
            // 
            // CbTipo
            // 
            this.CbTipo.Location = new System.Drawing.Point(64, 0);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(153, 22);
            this.CbTipo.TabIndex = 4;
            this.CbTipo.SelectedValueChanged += new System.EventHandler(this.CbTipo_SelectedValueChanged);
            // 
            // Lfecha
            // 
            this.Lfecha.Location = new System.Drawing.Point(3, 28);
            this.Lfecha.Name = "Lfecha";
            this.Lfecha.Size = new System.Drawing.Size(37, 20);
            this.Lfecha.Text = "Fecha";
            // 
            // Dtfecha
            // 
            this.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfecha.Location = new System.Drawing.Point(64, 28);
            this.Dtfecha.Name = "Dtfecha";
            this.Dtfecha.Size = new System.Drawing.Size(84, 22);
            this.Dtfecha.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Añadir
            // 
            this.Añadir.Image = ((System.Drawing.Image)(resources.GetObject("Añadir.Image")));
            this.Añadir.Location = new System.Drawing.Point(31, 110);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(22, 25);
            this.Añadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // LHembra
            // 
            this.LHembra.Location = new System.Drawing.Point(3, 57);
            this.LHembra.Name = "LHembra";
            this.LHembra.Size = new System.Drawing.Size(57, 22);
            this.LHembra.Text = "Hembra";
            // 
            // cBHembra
            // 
            this.cBHembra.Location = new System.Drawing.Point(64, 57);
            this.cBHembra.Name = "cBHembra";
            this.cBHembra.Size = new System.Drawing.Size(155, 22);
            this.cBHembra.TabIndex = 11;
            this.cBHembra.SelectedValueChanged += new System.EventHandler(this.cBHembra_SelectedValueChanged);
            // 
            // LMacho
            // 
            this.LMacho.Location = new System.Drawing.Point(2, 87);
            this.LMacho.Name = "LMacho";
            this.LMacho.Size = new System.Drawing.Size(56, 20);
            this.LMacho.Text = "Macho";
            // 
            // cbMachos
            // 
            this.cbMachos.Items.Add("");
            this.cbMachos.Location = new System.Drawing.Point(64, 85);
            this.cbMachos.Name = "cbMachos";
            this.cbMachos.Size = new System.Drawing.Size(155, 22);
            this.cbMachos.TabIndex = 18;
            this.cbMachos.SelectedValueChanged += new System.EventHandler(this.cbMachos_SelectedValueChanged);
            // 
            // TbMacho
            // 
            this.TbMacho.Location = new System.Drawing.Point(63, 86);
            this.TbMacho.Name = "TbMacho";
            this.TbMacho.Size = new System.Drawing.Size(143, 21);
            this.TbMacho.TabIndex = 25;
            // 
            // TbHembra
            // 
            this.TbHembra.Location = new System.Drawing.Point(63, 57);
            this.TbHembra.Name = "TbHembra";
            this.TbHembra.Size = new System.Drawing.Size(143, 21);
            this.TbHembra.TabIndex = 26;
            // 
            // TbTipo
            // 
            this.TbTipo.Location = new System.Drawing.Point(63, 0);
            this.TbTipo.Name = "TbTipo";
            this.TbTipo.Size = new System.Drawing.Size(143, 21);
            this.TbTipo.TabIndex = 27;
            // 
            // Inseminaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 270);
            this.Controls.Add(this.TbTipo);
            this.Controls.Add(this.TbMacho);
            this.Controls.Add(this.TbHembra);
            this.Controls.Add(this.cBHembra);
            this.Controls.Add(this.cbMachos);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.Dtfecha);
            this.Controls.Add(this.LMacho);
            this.Controls.Add(this.Lfecha);
            this.Controls.Add(this.DgInseminaciones);
            this.Controls.Add(this.Ltipo);
            this.Controls.Add(this.LHembra);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inseminaciones";
            this.Text = "Inseminaciones";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Inseminaciones_Closing);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.Añadir, 0);
            this.Controls.SetChildIndex(this.LHembra, 0);
            this.Controls.SetChildIndex(this.Ltipo, 0);
            this.Controls.SetChildIndex(this.DgInseminaciones, 0);
            this.Controls.SetChildIndex(this.Lfecha, 0);
            this.Controls.SetChildIndex(this.LMacho, 0);
            this.Controls.SetChildIndex(this.Dtfecha, 0);
            this.Controls.SetChildIndex(this.CbTipo, 0);
            this.Controls.SetChildIndex(this.cbMachos, 0);
            this.Controls.SetChildIndex(this.cBHembra, 0);
            this.Controls.SetChildIndex(this.TbHembra, 0);
            this.Controls.SetChildIndex(this.TbMacho, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.TbTipo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid DgInseminaciones;
        private System.Windows.Forms.Label Ltipo;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.Label Lfecha;
        private System.Windows.Forms.DateTimePicker Dtfecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.PictureBox Añadir;
        private System.Windows.Forms.Label LHembra;
        private System.Windows.Forms.ComboBox cBHembra;
        private System.Windows.Forms.Label LMacho;
        private System.Windows.Forms.ComboBox cbMachos;
        private System.Windows.Forms.TextBox TbMacho;
        private System.Windows.Forms.TextBox TbHembra;
        private System.Windows.Forms.TextBox TbTipo;
    }
}
