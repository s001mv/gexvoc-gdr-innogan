namespace GEXVOC.UI
{
    partial class InsertarPartoMultiples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarPartoMultiples));
            this.LHembra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbBuscarhembra = new System.Windows.Forms.PictureBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.LTipo = new System.Windows.Forms.Label();
            this.LFacilidad = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.CbFacilidad = new System.Windows.Forms.ComboBox();
            this.LVivos = new System.Windows.Forms.Label();
            this.LMuertos = new System.Windows.Forms.Label();
            this.Tbvivos = new System.Windows.Forms.TextBox();
            this.tbMuertos = new System.Windows.Forms.TextBox();
            this.LcausaMuete = new System.Windows.Forms.Label();
            this.TbCausaDeLamuerte = new System.Windows.Forms.TextBox();
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
            this.LHembra.Location = new System.Drawing.Point(3, 8);
            this.LHembra.Name = "LHembra";
            this.LHembra.Size = new System.Drawing.Size(65, 21);
            this.LHembra.Text = "Hembra";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(133, 21);
            this.textBox1.TabIndex = 3;
            // 
            // pbBuscarhembra
            // 
            this.pbBuscarhembra.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarhembra.Image")));
            this.pbBuscarhembra.Location = new System.Drawing.Point(213, 8);
            this.pbBuscarhembra.Name = "pbBuscarhembra";
            this.pbBuscarhembra.Size = new System.Drawing.Size(26, 23);
            this.pbBuscarhembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarhembra.Click += new System.EventHandler(this.pbBuscarhembra_Click);
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(5, 33);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(62, 19);
            this.LFecha.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(74, 33);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(84, 22);
            this.dtFecha.TabIndex = 6;
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(5, 62);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(62, 19);
            this.LTipo.Text = "Tipo";
            // 
            // LFacilidad
            // 
            this.LFacilidad.Location = new System.Drawing.Point(6, 90);
            this.LFacilidad.Name = "LFacilidad";
            this.LFacilidad.Size = new System.Drawing.Size(62, 19);
            this.LFacilidad.Text = "Facilidad";
            // 
            // cbTipo
            // 
            this.cbTipo.Location = new System.Drawing.Point(76, 59);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(137, 22);
            this.cbTipo.TabIndex = 11;
            // 
            // CbFacilidad
            // 
            this.CbFacilidad.Location = new System.Drawing.Point(76, 90);
            this.CbFacilidad.Name = "CbFacilidad";
            this.CbFacilidad.Size = new System.Drawing.Size(137, 22);
            this.CbFacilidad.TabIndex = 12;
            // 
            // LVivos
            // 
            this.LVivos.Location = new System.Drawing.Point(6, 126);
            this.LVivos.Name = "LVivos";
            this.LVivos.Size = new System.Drawing.Size(40, 19);
            this.LVivos.Text = "vivos";
            // 
            // LMuertos
            // 
            this.LMuertos.Location = new System.Drawing.Point(110, 126);
            this.LMuertos.Name = "LMuertos";
            this.LMuertos.Size = new System.Drawing.Size(55, 19);
            this.LMuertos.Text = "muertos";
            // 
            // Tbvivos
            // 
            this.Tbvivos.Location = new System.Drawing.Point(52, 126);
            this.Tbvivos.Name = "Tbvivos";
            this.Tbvivos.Size = new System.Drawing.Size(36, 21);
            this.Tbvivos.TabIndex = 17;
            // 
            // tbMuertos
            // 
            this.tbMuertos.Location = new System.Drawing.Point(171, 126);
            this.tbMuertos.Name = "tbMuertos";
            this.tbMuertos.Size = new System.Drawing.Size(36, 21);
            this.tbMuertos.TabIndex = 18;
            // 
            // LcausaMuete
            // 
            this.LcausaMuete.Location = new System.Drawing.Point(10, 151);
            this.LcausaMuete.Name = "LcausaMuete";
            this.LcausaMuete.Size = new System.Drawing.Size(128, 21);
            this.LcausaMuete.Text = "Causa de la muerte";
            // 
            // TbCausaDeLamuerte
            // 
            this.TbCausaDeLamuerte.Location = new System.Drawing.Point(10, 175);
            this.TbCausaDeLamuerte.Name = "TbCausaDeLamuerte";
            this.TbCausaDeLamuerte.Size = new System.Drawing.Size(209, 21);
            this.TbCausaDeLamuerte.TabIndex = 20;
            // 
            // InsertarPartoMultiples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TbCausaDeLamuerte);
            this.Controls.Add(this.LcausaMuete);
            this.Controls.Add(this.tbMuertos);
            this.Controls.Add(this.Tbvivos);
            this.Controls.Add(this.LMuertos);
            this.Controls.Add(this.LVivos);
            this.Controls.Add(this.CbFacilidad);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.LFacilidad);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.pbBuscarhembra);
            this.Controls.Add(this.LHembra);
            this.Controls.Add(this.textBox1);
            this.Name = "InsertarPartoMultiples";
            this.Text = "Insertar Parto";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarParto_Closing);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.LHembra, 0);
            this.Controls.SetChildIndex(this.pbBuscarhembra, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.LFacilidad, 0);
            this.Controls.SetChildIndex(this.cbTipo, 0);
            this.Controls.SetChildIndex(this.CbFacilidad, 0);
            this.Controls.SetChildIndex(this.LVivos, 0);
            this.Controls.SetChildIndex(this.LMuertos, 0);
            this.Controls.SetChildIndex(this.Tbvivos, 0);
            this.Controls.SetChildIndex(this.tbMuertos, 0);
            this.Controls.SetChildIndex(this.LcausaMuete, 0);
            this.Controls.SetChildIndex(this.TbCausaDeLamuerte, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LHembra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbBuscarhembra;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label LFacilidad;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox CbFacilidad;
        private System.Windows.Forms.Label LVivos;
        private System.Windows.Forms.Label LMuertos;
        private System.Windows.Forms.TextBox Tbvivos;
        private System.Windows.Forms.TextBox tbMuertos;
        private System.Windows.Forms.Label LcausaMuete;
        private System.Windows.Forms.TextBox TbCausaDeLamuerte;
    }
}
