namespace GEXVOC.UI
{
    partial class Pesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesos));
            this.LAnimal = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LMomento = new System.Windows.Forms.Label();
            this.LPeso = new System.Windows.Forms.Label();
            this.tbHembra = new System.Windows.Forms.TextBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.TbPeso = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.pbBuscarHembra = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbAnadir = new System.Windows.Forms.PictureBox();
            this.CbMomento = new System.Windows.Forms.ComboBox();
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
            this.LAnimal.Location = new System.Drawing.Point(5, 1);
            this.LAnimal.Name = "LAnimal";
            this.LAnimal.Size = new System.Drawing.Size(61, 21);
            this.LAnimal.Text = "Animal";
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(5, 33);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(59, 21);
            this.LFecha.Text = "Fecha";
            // 
            // LMomento
            // 
            this.LMomento.Location = new System.Drawing.Point(3, 64);
            this.LMomento.Name = "LMomento";
            this.LMomento.Size = new System.Drawing.Size(61, 21);
            this.LMomento.Text = "Momento";
            // 
            // LPeso
            // 
            this.LPeso.Location = new System.Drawing.Point(3, 96);
            this.LPeso.Name = "LPeso";
            this.LPeso.Size = new System.Drawing.Size(61, 21);
            this.LPeso.Text = "Peso";
            // 
            // tbHembra
            // 
            this.tbHembra.Location = new System.Drawing.Point(70, 1);
            this.tbHembra.Name = "tbHembra";
            this.tbHembra.Size = new System.Drawing.Size(123, 21);
            this.tbHembra.TabIndex = 9;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(70, 33);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(115, 22);
            this.dtfecha.TabIndex = 10;
            // 
            // TbPeso
            // 
            this.TbPeso.Location = new System.Drawing.Point(70, 96);
            this.TbPeso.Name = "TbPeso";
            this.TbPeso.Size = new System.Drawing.Size(35, 21);
            this.TbPeso.TabIndex = 11;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(12, 148);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(225, 98);
            this.dataGrid1.TabIndex = 12;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.MappingName = "Peso";
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
            this.dataGridTextBoxColumn2.HeaderText = "Peso";
            this.dataGridTextBoxColumn2.MappingName = "Peso";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Animal";
            this.dataGridTextBoxColumn3.MappingName = "Nombre";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Momento";
            this.dataGridTextBoxColumn4.MappingName = "Momento";
            // 
            // pbBuscarHembra
            // 
            this.pbBuscarHembra.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarHembra.Image")));
            this.pbBuscarHembra.Location = new System.Drawing.Point(197, 1);
            this.pbBuscarHembra.Name = "pbBuscarHembra";
            this.pbBuscarHembra.Size = new System.Drawing.Size(22, 21);
            this.pbBuscarHembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarHembra.Click += new System.EventHandler(this.pbBuscarHembra_Click);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(98, 123);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(27, 25);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // pbAnadir
            // 
            this.pbAnadir.Image = ((System.Drawing.Image)(resources.GetObject("pbAnadir.Image")));
            this.pbAnadir.Location = new System.Drawing.Point(210, 123);
            this.pbAnadir.Name = "pbAnadir";
            this.pbAnadir.Size = new System.Drawing.Size(27, 25);
            this.pbAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnadir.Click += new System.EventHandler(this.pbAnadir_Click);
            // 
            // CbMomento
            // 
            this.CbMomento.Location = new System.Drawing.Point(69, 65);
            this.CbMomento.Name = "CbMomento";
            this.CbMomento.Size = new System.Drawing.Size(123, 22);
            this.CbMomento.TabIndex = 17;
            // 
            // Pesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.CbMomento);
            this.Controls.Add(this.pbAnadir);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.pbBuscarHembra);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.TbPeso);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.tbHembra);
            this.Controls.Add(this.LPeso);
            this.Controls.Add(this.LMomento);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LAnimal);
            this.Name = "Pesos";
            this.Text = "Pesos";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pesos_Closing);
            this.Controls.SetChildIndex(this.LAnimal, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.LMomento, 0);
            this.Controls.SetChildIndex(this.LPeso, 0);
            this.Controls.SetChildIndex(this.tbHembra, 0);
            this.Controls.SetChildIndex(this.dtfecha, 0);
            this.Controls.SetChildIndex(this.TbPeso, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.pbBuscarHembra, 0);
            this.Controls.SetChildIndex(this.pbBuscar, 0);
            this.Controls.SetChildIndex(this.pbAnadir, 0);
            this.Controls.SetChildIndex(this.CbMomento, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LAnimal;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LMomento;
        private System.Windows.Forms.Label LPeso;
        private System.Windows.Forms.TextBox tbHembra;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.TextBox TbPeso;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.PictureBox pbBuscarHembra;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.PictureBox pbAnadir;
        private System.Windows.Forms.ComboBox CbMomento;
    }
}
