namespace GEXVOC.UI
{
    partial class DiagnosticoGestacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosticoGestacion));
            this.LHembra = new System.Windows.Forms.Label();
            this.TbHembra = new System.Windows.Forms.TextBox();
            this.PbBuscar = new System.Windows.Forms.PictureBox();
            this.LTipo = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.LfEcha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.TbFecha = new System.Windows.Forms.TextBox();
            this.TbTipo = new System.Windows.Forms.TextBox();
            this.dgDiagnostico = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.PbAnadir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // LHembra
            // 
            this.LHembra.Location = new System.Drawing.Point(6, 14);
            this.LHembra.Name = "LHembra";
            this.LHembra.Size = new System.Drawing.Size(61, 18);
            this.LHembra.Text = "Hembra";
            // 
            // TbHembra
            // 
            this.TbHembra.Location = new System.Drawing.Point(79, 13);
            this.TbHembra.Name = "TbHembra";
            this.TbHembra.Size = new System.Drawing.Size(123, 21);
            this.TbHembra.TabIndex = 3;
            // 
            // PbBuscar
            // 
            this.PbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscar.Image")));
            this.PbBuscar.Location = new System.Drawing.Point(208, 14);
            this.PbBuscar.Name = "PbBuscar";
            this.PbBuscar.Size = new System.Drawing.Size(21, 17);
            this.PbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscar.Click += new System.EventHandler(this.PbBuscar_Click);
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(7, 39);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(59, 17);
            this.LTipo.Text = "Tipo";
            // 
            // CbTipo
            // 
            this.CbTipo.Location = new System.Drawing.Point(79, 38);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(123, 22);
            this.CbTipo.TabIndex = 6;
            this.CbTipo.SelectedValueChanged += new System.EventHandler(this.CbTipo_SelectedValueChanged);
            // 
            // LfEcha
            // 
            this.LfEcha.Location = new System.Drawing.Point(5, 66);
            this.LfEcha.Name = "LfEcha";
            this.LfEcha.Size = new System.Drawing.Size(61, 21);
            this.LfEcha.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(78, 66);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(123, 22);
            this.dtFecha.TabIndex = 9;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TbFecha
            // 
            this.TbFecha.Location = new System.Drawing.Point(77, 67);
            this.TbFecha.Name = "TbFecha";
            this.TbFecha.Size = new System.Drawing.Size(104, 21);
            this.TbFecha.TabIndex = 15;
            // 
            // TbTipo
            // 
            this.TbTipo.Location = new System.Drawing.Point(80, 38);
            this.TbTipo.Name = "TbTipo";
            this.TbTipo.Size = new System.Drawing.Size(107, 21);
            this.TbTipo.TabIndex = 20;
            // 
            // dgDiagnostico
            // 
            this.dgDiagnostico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgDiagnostico.Location = new System.Drawing.Point(5, 116);
            this.dgDiagnostico.Name = "dgDiagnostico";
            this.dgDiagnostico.Size = new System.Drawing.Size(229, 129);
            this.dgDiagnostico.TabIndex = 25;
            this.dgDiagnostico.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.MappingName = "DiagInseminacion";
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
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridTextBoxColumn4.MappingName = "Descripcion";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Resultado";
            this.dataGridTextBoxColumn3.MappingName = "Resultado";
            // 
            // PbAnadir
            // 
            this.PbAnadir.Image = ((System.Drawing.Image)(resources.GetObject("PbAnadir.Image")));
            this.PbAnadir.Location = new System.Drawing.Point(192, 94);
            this.PbAnadir.Name = "PbAnadir";
            this.PbAnadir.Size = new System.Drawing.Size(26, 22);
            this.PbAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnadir.Click += new System.EventHandler(this.PbAnadir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DiagnosticoGestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PbAnadir);
            this.Controls.Add(this.TbFecha);
            this.Controls.Add(this.dgDiagnostico);
            this.Controls.Add(this.TbTipo);
            this.Controls.Add(this.LfEcha);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.PbBuscar);
            this.Controls.Add(this.TbHembra);
            this.Controls.Add(this.LHembra);
            this.Name = "DiagnosticoGestacion";
            this.Text = "Diagnostico de gestacion";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.DiagnosticoGestacion_Closing);
            this.Controls.SetChildIndex(this.LHembra, 0);
            this.Controls.SetChildIndex(this.TbHembra, 0);
            this.Controls.SetChildIndex(this.PbBuscar, 0);
            this.Controls.SetChildIndex(this.CbTipo, 0);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.LfEcha, 0);
            this.Controls.SetChildIndex(this.TbTipo, 0);
            this.Controls.SetChildIndex(this.dgDiagnostico, 0);
            this.Controls.SetChildIndex(this.TbFecha, 0);
            this.Controls.SetChildIndex(this.PbAnadir, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LHembra;
        private System.Windows.Forms.TextBox TbHembra;
        private System.Windows.Forms.PictureBox PbBuscar;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.Label LfEcha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox TbFecha;
        private System.Windows.Forms.TextBox TbTipo;
        private System.Windows.Forms.DataGrid dgDiagnostico;
        private System.Windows.Forms.PictureBox PbAnadir;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
