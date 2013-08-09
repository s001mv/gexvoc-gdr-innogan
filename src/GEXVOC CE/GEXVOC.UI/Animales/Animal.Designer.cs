namespace GEXVOC.UI
{
    partial class Animal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animal));
            this.DgAnimales = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LCIB = new System.Windows.Forms.Label();
            this.TbCIB = new System.Windows.Forms.TextBox();
            this.LSexo = new System.Windows.Forms.Label();
            this.CbSexo = new System.Windows.Forms.ComboBox();
            this.LCrotal = new System.Windows.Forms.Label();
            this.TbCrotal = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LFNAC = new System.Windows.Forms.Label();
            this.DtFNac = new System.Windows.Forms.DateTimePicker();
            this.LTatuaje = new System.Windows.Forms.Label();
            this.TbTatuaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbEspecie = new System.Windows.Forms.ComboBox();
            this.CbRaza = new System.Windows.Forms.ComboBox();
            this.LRaza = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.PictureBox();
            this.Borrar = new System.Windows.Forms.PictureBox();
            this.TbEspecie = new System.Windows.Forms.TextBox();
            this.TbRaza = new System.Windows.Forms.TextBox();
            this.TbFechaNac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Size = new System.Drawing.Size(227, 20);
            // 
            // DgAnimales
            // 
            this.DgAnimales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DgAnimales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgAnimales.Location = new System.Drawing.Point(0, 262);
            this.DgAnimales.Name = "DgAnimales";
            this.DgAnimales.Size = new System.Drawing.Size(227, 89);
            this.DgAnimales.TabIndex = 2;
            this.DgAnimales.TableStyles.Add(this.dataGridTableStyle1);
            this.DgAnimales.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DgAnimales_MouseUp);
            this.DgAnimales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgAnimales_MouseDown);
            this.DgAnimales.Click += new System.EventHandler(this.DgAnimales_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle1.MappingName = "Animal";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridTextBoxColumn1.MappingName = "Nombre";
            this.dataGridTextBoxColumn1.Width = 100;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "DIB/CIB";
            this.dataGridTextBoxColumn2.MappingName = "DIB";
            this.dataGridTextBoxColumn2.Width = 100;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Crotal";
            this.dataGridTextBoxColumn3.MappingName = "Crotal";
            this.dataGridTextBoxColumn3.Width = 30;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Tatuaje";
            this.dataGridTextBoxColumn4.MappingName = "Tatuaje";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Sexo";
            this.dataGridTextBoxColumn5.MappingName = "Sexo";
            this.dataGridTextBoxColumn5.Width = 13;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "F.Nac";
            this.dataGridTextBoxColumn6.MappingName = "FechaNacimiento";
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Especie";
            this.dataGridTextBoxColumn7.MappingName = "Especie";
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "Raza";
            this.dataGridTextBoxColumn8.MappingName = "Raza";
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.MappingName = "Id";
            this.dataGridTextBoxColumn9.Width = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // LCIB
            // 
            this.LCIB.Location = new System.Drawing.Point(0, 0);
            this.LCIB.Name = "LCIB";
            this.LCIB.Size = new System.Drawing.Size(26, 21);
            this.LCIB.Text = "CIB";
            // 
            // TbCIB
            // 
            this.TbCIB.Location = new System.Drawing.Point(37, 0);
            this.TbCIB.Name = "TbCIB";
            this.TbCIB.Size = new System.Drawing.Size(101, 21);
            this.TbCIB.TabIndex = 5;
            this.TbCIB.TextChanged += new System.EventHandler(this.TbCIB_TextChanged);
            // 
            // LSexo
            // 
            this.LSexo.Location = new System.Drawing.Point(144, 0);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(36, 21);
            this.LSexo.Text = "Sexo";
            // 
            // CbSexo
            // 
            this.CbSexo.Items.Add("H");
            this.CbSexo.Items.Add("M");
            this.CbSexo.Location = new System.Drawing.Point(186, 0);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(41, 22);
            this.CbSexo.TabIndex = 8;
            // 
            // LCrotal
            // 
            this.LCrotal.Location = new System.Drawing.Point(0, 23);
            this.LCrotal.Name = "LCrotal";
            this.LCrotal.Size = new System.Drawing.Size(38, 20);
            this.LCrotal.Text = "Crotal";
            // 
            // TbCrotal
            // 
            this.TbCrotal.Location = new System.Drawing.Point(37, 23);
            this.TbCrotal.Name = "TbCrotal";
            this.TbCrotal.Size = new System.Drawing.Size(48, 21);
            this.TbCrotal.TabIndex = 13;
            this.TbCrotal.TextChanged += new System.EventHandler(this.TbCrotal_TextChanged);
            // 
            // LNombre
            // 
            this.LNombre.Location = new System.Drawing.Point(2, 74);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(58, 21);
            this.LNombre.Text = "Nombre";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(62, 74);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(160, 21);
            this.TbNombre.TabIndex = 19;
            this.TbNombre.TextChanged += new System.EventHandler(this.TbNombre_TextChanged);
            // 
            // LFNAC
            // 
            this.LFNAC.Location = new System.Drawing.Point(3, 47);
            this.LFNAC.Name = "LFNAC";
            this.LFNAC.Size = new System.Drawing.Size(37, 22);
            this.LFNAC.Text = "F.Nac";
            // 
            // DtFNac
            // 
            this.DtFNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFNac.Location = new System.Drawing.Point(57, 47);
            this.DtFNac.Name = "DtFNac";
            this.DtFNac.Size = new System.Drawing.Size(93, 22);
            this.DtFNac.TabIndex = 25;
            this.DtFNac.Value = new System.DateTime(2008, 6, 13, 0, 0, 0, 0);
            this.DtFNac.ValueChanged += new System.EventHandler(this.DtFNac_ValueChanged);
            // 
            // LTatuaje
            // 
            this.LTatuaje.Location = new System.Drawing.Point(91, 24);
            this.LTatuaje.Name = "LTatuaje";
            this.LTatuaje.Size = new System.Drawing.Size(49, 20);
            this.LTatuaje.Text = "Tatuaje";
            // 
            // TbTatuaje
            // 
            this.TbTatuaje.Location = new System.Drawing.Point(146, 23);
            this.TbTatuaje.Name = "TbTatuaje";
            this.TbTatuaje.Size = new System.Drawing.Size(73, 21);
            this.TbTatuaje.TabIndex = 27;
            this.TbTatuaje.TextChanged += new System.EventHandler(this.TbTatuaje_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.Text = "Especie";
            // 
            // CbEspecie
            // 
            this.CbEspecie.Location = new System.Drawing.Point(62, 101);
            this.CbEspecie.Name = "CbEspecie";
            this.CbEspecie.Size = new System.Drawing.Size(160, 22);
            this.CbEspecie.TabIndex = 29;
            this.CbEspecie.SelectedValueChanged += new System.EventHandler(this.CbEspecie_SelectedValueChanged);
            // 
            // CbRaza
            // 
            this.CbRaza.Location = new System.Drawing.Point(62, 127);
            this.CbRaza.Name = "CbRaza";
            this.CbRaza.Size = new System.Drawing.Size(160, 22);
            this.CbRaza.TabIndex = 30;
            this.CbRaza.SelectedValueChanged += new System.EventHandler(this.CbRaza_SelectedValueChanged);
            // 
            // LRaza
            // 
            this.LRaza.Location = new System.Drawing.Point(3, 127);
            this.LRaza.Name = "LRaza";
            this.LRaza.Size = new System.Drawing.Size(57, 21);
            this.LRaza.Text = "Raza";
            // 
            // buscar
            // 
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.Location = new System.Drawing.Point(101, 155);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(23, 22);
            this.buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.Location = new System.Drawing.Point(37, 155);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(23, 22);
            this.Borrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // TbEspecie
            // 
            this.TbEspecie.Location = new System.Drawing.Point(62, 101);
            this.TbEspecie.Name = "TbEspecie";
            this.TbEspecie.Size = new System.Drawing.Size(143, 21);
            this.TbEspecie.TabIndex = 40;
            // 
            // TbRaza
            // 
            this.TbRaza.Location = new System.Drawing.Point(62, 127);
            this.TbRaza.Name = "TbRaza";
            this.TbRaza.Size = new System.Drawing.Size(142, 21);
            this.TbRaza.TabIndex = 41;
            // 
            // TbFechaNac
            // 
            this.TbFechaNac.Location = new System.Drawing.Point(57, 47);
            this.TbFechaNac.Name = "TbFechaNac";
            this.TbFechaNac.Size = new System.Drawing.Size(81, 21);
            this.TbFechaNac.TabIndex = 42;
            // 
            // Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TbRaza);
            this.Controls.Add(this.TbFechaNac);
            this.Controls.Add(this.DtFNac);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.TbTatuaje);
            this.Controls.Add(this.TbEspecie);
            this.Controls.Add(this.LRaza);
            this.Controls.Add(this.CbRaza);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.CbEspecie);
            this.Controls.Add(this.LFNAC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCrotal);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LTatuaje);
            this.Controls.Add(this.CbSexo);
            this.Controls.Add(this.LCrotal);
            this.Controls.Add(this.LSexo);
            this.Controls.Add(this.LCIB);
            this.Controls.Add(this.TbCIB);
            this.Controls.Add(this.DgAnimales);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Animal";
            this.Text = "Animal";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Animal_Closing);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.DgAnimales, 0);
            this.Controls.SetChildIndex(this.TbCIB, 0);
            this.Controls.SetChildIndex(this.LCIB, 0);
            this.Controls.SetChildIndex(this.LSexo, 0);
            this.Controls.SetChildIndex(this.LCrotal, 0);
            this.Controls.SetChildIndex(this.CbSexo, 0);
            this.Controls.SetChildIndex(this.LTatuaje, 0);
            this.Controls.SetChildIndex(this.TbNombre, 0);
            this.Controls.SetChildIndex(this.LNombre, 0);
            this.Controls.SetChildIndex(this.TbCrotal, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.LFNAC, 0);
            this.Controls.SetChildIndex(this.CbEspecie, 0);
            this.Controls.SetChildIndex(this.buscar, 0);
            this.Controls.SetChildIndex(this.CbRaza, 0);
            this.Controls.SetChildIndex(this.LRaza, 0);
            this.Controls.SetChildIndex(this.TbEspecie, 0);
            this.Controls.SetChildIndex(this.TbTatuaje, 0);
            this.Controls.SetChildIndex(this.Borrar, 0);
            this.Controls.SetChildIndex(this.DtFNac, 0);
            this.Controls.SetChildIndex(this.TbFechaNac, 0);
            this.Controls.SetChildIndex(this.TbRaza, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid DgAnimales;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LCIB;
        private System.Windows.Forms.TextBox TbCIB;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.ComboBox CbSexo;
        private System.Windows.Forms.Label LCrotal;
        private System.Windows.Forms.TextBox TbCrotal;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LFNAC;
        private System.Windows.Forms.DateTimePicker DtFNac;
        private System.Windows.Forms.Label LTatuaje;
        private System.Windows.Forms.TextBox TbTatuaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbEspecie;
        private System.Windows.Forms.ComboBox CbRaza;
        private System.Windows.Forms.Label LRaza;
        private System.Windows.Forms.PictureBox buscar;
        private System.Windows.Forms.PictureBox Borrar;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private System.Windows.Forms.TextBox TbEspecie;
        private System.Windows.Forms.TextBox TbRaza;
        private System.Windows.Forms.TextBox TbFechaNac;
    }
}
