namespace GEXVOC.UI
{
    partial class Secados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secados));
            this.LHembra = new System.Windows.Forms.Label();
            this.lTipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbhembra = new System.Windows.Forms.TextBox();
            this.CbTipoSecado = new System.Windows.Forms.ComboBox();
            this.CbMotivo = new System.Windows.Forms.ComboBox();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.dgSecados = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.PbFiltrar = new System.Windows.Forms.PictureBox();
            this.PbAnadir = new System.Windows.Forms.PictureBox();
            this.PbBuscarHembra = new System.Windows.Forms.PictureBox();
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
            // LHembra
            // 
            this.LHembra.Location = new System.Drawing.Point(3, 0);
            this.LHembra.Name = "LHembra";
            this.LHembra.Size = new System.Drawing.Size(73, 19);
            this.LHembra.Text = "Hembra";
            // 
            // lTipo
            // 
            this.lTipo.Location = new System.Drawing.Point(3, 28);
            this.lTipo.Name = "lTipo";
            this.lTipo.Size = new System.Drawing.Size(73, 19);
            this.lTipo.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.Text = "Fecha desde";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.Text = "fecha hasta";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.Text = "Motivo";
            // 
            // tbhembra
            // 
            this.tbhembra.Location = new System.Drawing.Point(80, 0);
            this.tbhembra.Name = "tbhembra";
            this.tbhembra.Size = new System.Drawing.Size(138, 21);
            this.tbhembra.TabIndex = 7;
            // 
            // CbTipoSecado
            // 
            this.CbTipoSecado.Location = new System.Drawing.Point(80, 25);
            this.CbTipoSecado.Name = "CbTipoSecado";
            this.CbTipoSecado.Size = new System.Drawing.Size(139, 22);
            this.CbTipoSecado.TabIndex = 8;
            // 
            // CbMotivo
            // 
            this.CbMotivo.Location = new System.Drawing.Point(80, 109);
            this.CbMotivo.Name = "CbMotivo";
            this.CbMotivo.Size = new System.Drawing.Size(134, 22);
            this.CbMotivo.TabIndex = 9;
            // 
            // dtpdesde
            // 
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(80, 53);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(96, 22);
            this.dtpdesde.TabIndex = 10;
            this.dtpdesde.ValueChanged += new System.EventHandler(this.dtpdesde_ValueChanged);
            // 
            // dtphasta
            // 
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(80, 81);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(94, 22);
            this.dtphasta.TabIndex = 11;
            this.dtphasta.ValueChanged += new System.EventHandler(this.dtphasta_ValueChanged);
            // 
            // dgSecados
            // 
            this.dgSecados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgSecados.Location = new System.Drawing.Point(4, 162);
            this.dgSecados.Name = "dgSecados";
            this.dgSecados.Size = new System.Drawing.Size(226, 79);
            this.dgSecados.TabIndex = 12;
            this.dgSecados.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.MappingName = "Secado";
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
            this.dataGridTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridTextBoxColumn3.MappingName = "Descripcion1";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Motivo";
            this.dataGridTextBoxColumn4.MappingName = "Descripcion";
            // 
            // PbFiltrar
            // 
            this.PbFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("PbFiltrar.Image")));
            this.PbFiltrar.Location = new System.Drawing.Point(98, 140);
            this.PbFiltrar.Name = "PbFiltrar";
            this.PbFiltrar.Size = new System.Drawing.Size(25, 22);
            this.PbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFiltrar.Click += new System.EventHandler(this.PbFiltrar_Click);
            // 
            // PbAnadir
            // 
            this.PbAnadir.Image = ((System.Drawing.Image)(resources.GetObject("PbAnadir.Image")));
            this.PbAnadir.Location = new System.Drawing.Point(189, 140);
            this.PbAnadir.Name = "PbAnadir";
            this.PbAnadir.Size = new System.Drawing.Size(25, 22);
            this.PbAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnadir.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PbBuscarHembra
            // 
            this.PbBuscarHembra.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscarHembra.Image")));
            this.PbBuscarHembra.Location = new System.Drawing.Point(217, 0);
            this.PbBuscarHembra.Name = "PbBuscarHembra";
            this.PbBuscarHembra.Size = new System.Drawing.Size(23, 21);
            this.PbBuscarHembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscarHembra.Click += new System.EventHandler(this.PbBuscarHembra_Click);
            // 
            // TbDesde
            // 
            this.TbDesde.Location = new System.Drawing.Point(81, 56);
            this.TbDesde.Name = "TbDesde";
            this.TbDesde.Size = new System.Drawing.Size(81, 21);
            this.TbDesde.TabIndex = 18;
            // 
            // TbHasta
            // 
            this.TbHasta.Location = new System.Drawing.Point(80, 81);
            this.TbHasta.Name = "TbHasta";
            this.TbHasta.Size = new System.Drawing.Size(81, 21);
            this.TbHasta.TabIndex = 19;
            // 
            // Secados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TbHasta);
            this.Controls.Add(this.TbDesde);
            this.Controls.Add(this.PbBuscarHembra);
            this.Controls.Add(this.PbAnadir);
            this.Controls.Add(this.PbFiltrar);
            this.Controls.Add(this.dgSecados);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.CbMotivo);
            this.Controls.Add(this.CbTipoSecado);
            this.Controls.Add(this.tbhembra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lTipo);
            this.Controls.Add(this.LHembra);
            this.Name = "Secados";
            this.Text = "Secados";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Secados_Closing);
            this.Controls.SetChildIndex(this.LHembra, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.lTipo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbhembra, 0);
            this.Controls.SetChildIndex(this.CbTipoSecado, 0);
            this.Controls.SetChildIndex(this.CbMotivo, 0);
            this.Controls.SetChildIndex(this.dtpdesde, 0);
            this.Controls.SetChildIndex(this.dtphasta, 0);
            this.Controls.SetChildIndex(this.dgSecados, 0);
            this.Controls.SetChildIndex(this.PbFiltrar, 0);
            this.Controls.SetChildIndex(this.PbAnadir, 0);
            this.Controls.SetChildIndex(this.PbBuscarHembra, 0);
            this.Controls.SetChildIndex(this.TbDesde, 0);
            this.Controls.SetChildIndex(this.TbHasta, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LHembra;
        private System.Windows.Forms.Label lTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbhembra;
        private System.Windows.Forms.ComboBox CbTipoSecado;
        private System.Windows.Forms.ComboBox CbMotivo;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.DataGrid dgSecados;
        private System.Windows.Forms.PictureBox PbFiltrar;
        private System.Windows.Forms.PictureBox PbAnadir;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.PictureBox PbBuscarHembra;
        private System.Windows.Forms.TextBox TbDesde;
        private System.Windows.Forms.TextBox TbHasta;
    }
}
