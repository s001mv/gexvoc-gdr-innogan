namespace GEXVOC.UI
{
    partial class InsertarDiagnosticoGestacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarDiagnosticoGestacion));
            this.LHembra = new System.Windows.Forms.Label();
            this.TbHembra = new System.Windows.Forms.TextBox();
            this.pbBuscarHembra = new System.Windows.Forms.PictureBox();
            this.Ltipo = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LDias = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PbNegativo = new System.Windows.Forms.PictureBox();
            this.pbPositivo = new System.Windows.Forms.PictureBox();
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
            this.LHembra.Location = new System.Drawing.Point(4, 13);
            this.LHembra.Name = "LHembra";
            this.LHembra.Size = new System.Drawing.Size(58, 21);
            this.LHembra.Text = "Hembra";
            // 
            // TbHembra
            // 
            this.TbHembra.Location = new System.Drawing.Point(74, 12);
            this.TbHembra.Name = "TbHembra";
            this.TbHembra.ReadOnly = true;
            this.TbHembra.Size = new System.Drawing.Size(134, 21);
            this.TbHembra.TabIndex = 3;
            // 
            // pbBuscarHembra
            // 
            this.pbBuscarHembra.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarHembra.Image")));
            this.pbBuscarHembra.Location = new System.Drawing.Point(214, 12);
            this.pbBuscarHembra.Name = "pbBuscarHembra";
            this.pbBuscarHembra.Size = new System.Drawing.Size(22, 21);
            this.pbBuscarHembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarHembra.Click += new System.EventHandler(this.pbBuscarHembra_Click);
            // 
            // Ltipo
            // 
            this.Ltipo.Location = new System.Drawing.Point(5, 38);
            this.Ltipo.Name = "Ltipo";
            this.Ltipo.Size = new System.Drawing.Size(56, 21);
            this.Ltipo.Text = "Tipo";
            // 
            // CbTipo
            // 
            this.CbTipo.Location = new System.Drawing.Point(75, 37);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(160, 22);
            this.CbTipo.TabIndex = 6;
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(5, 64);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(56, 22);
            this.LFecha.Text = "fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // LDias
            // 
            this.LDias.Location = new System.Drawing.Point(7, 90);
            this.LDias.Name = "LDias";
            this.LDias.Size = new System.Drawing.Size(180, 22);
            this.LDias.Text = "Dias (estimados) en gestacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 21);
            this.textBox1.TabIndex = 10;
            // 
            // LResultado
            // 
            this.LResultado.Location = new System.Drawing.Point(8, 122);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(63, 21);
            this.LResultado.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 15;
            this.button1.Text = "Negativo";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PbNegativo
            // 
            this.PbNegativo.Image = ((System.Drawing.Image)(resources.GetObject("PbNegativo.Image")));
            this.PbNegativo.Location = new System.Drawing.Point(77, 122);
            this.PbNegativo.Name = "PbNegativo";
            this.PbNegativo.Size = new System.Drawing.Size(27, 21);
            this.PbNegativo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pbPositivo
            // 
            this.pbPositivo.Image = ((System.Drawing.Image)(resources.GetObject("pbPositivo.Image")));
            this.pbPositivo.Location = new System.Drawing.Point(77, 122);
            this.pbPositivo.Name = "pbPositivo";
            this.pbPositivo.Size = new System.Drawing.Size(27, 21);
            this.pbPositivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPositivo.Visible = false;
            // 
            // InsertarDiagnosticoGestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pbPositivo);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.PbNegativo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LDias);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.Ltipo);
            this.Controls.Add(this.TbHembra);
            this.Controls.Add(this.pbBuscarHembra);
            this.Controls.Add(this.LHembra);
            this.Name = "InsertarDiagnosticoGestacion";
            this.Text = "Insertar Diagnostico de gestacion";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarDiagnosticoGestacion_Closing);
            this.Controls.SetChildIndex(this.LHembra, 0);
            this.Controls.SetChildIndex(this.pbBuscarHembra, 0);
            this.Controls.SetChildIndex(this.TbHembra, 0);
            this.Controls.SetChildIndex(this.Ltipo, 0);
            this.Controls.SetChildIndex(this.CbTipo, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.LDias, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.PbNegativo, 0);
            this.Controls.SetChildIndex(this.LResultado, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.pbPositivo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LHembra;
        private System.Windows.Forms.TextBox TbHembra;
        private System.Windows.Forms.PictureBox pbBuscarHembra;
        private System.Windows.Forms.Label Ltipo;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LDias;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PbNegativo;
        private System.Windows.Forms.PictureBox pbPositivo;
    }
}
