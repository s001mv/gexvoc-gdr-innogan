namespace GEXVOC.UI
{
    partial class InsertarPartosMultiples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarPartosMultiples));
            this.TbCausaDeLamuerte = new System.Windows.Forms.TextBox();
            this.LcausaMuete = new System.Windows.Forms.Label();
            this.tbMuertos = new System.Windows.Forms.TextBox();
            this.Tbvivos = new System.Windows.Forms.TextBox();
            this.LMuertos = new System.Windows.Forms.Label();
            this.LVivos = new System.Windows.Forms.Label();
            this.CbFacilidad = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.LFacilidad = new System.Windows.Forms.Label();
            this.LTipo = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.LFecha = new System.Windows.Forms.Label();
            this.pbBuscarhembra = new System.Windows.Forms.PictureBox();
            this.LLote = new System.Windows.Forms.Label();
            this.TbLote = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // TbCausaDeLamuerte
            // 
            this.TbCausaDeLamuerte.Location = new System.Drawing.Point(3, 166);
            this.TbCausaDeLamuerte.Name = "TbCausaDeLamuerte";
            this.TbCausaDeLamuerte.Size = new System.Drawing.Size(209, 21);
            this.TbCausaDeLamuerte.TabIndex = 35;
            // 
            // LcausaMuete
            // 
            this.LcausaMuete.Location = new System.Drawing.Point(3, 142);
            this.LcausaMuete.Name = "LcausaMuete";
            this.LcausaMuete.Size = new System.Drawing.Size(128, 21);
            this.LcausaMuete.Text = "Causa de la muerte";
            // 
            // tbMuertos
            // 
            this.tbMuertos.Location = new System.Drawing.Point(176, 118);
            this.tbMuertos.Name = "tbMuertos";
            this.tbMuertos.Size = new System.Drawing.Size(36, 21);
            this.tbMuertos.TabIndex = 34;
            // 
            // Tbvivos
            // 
            this.Tbvivos.Location = new System.Drawing.Point(48, 118);
            this.Tbvivos.Name = "Tbvivos";
            this.Tbvivos.Size = new System.Drawing.Size(36, 21);
            this.Tbvivos.TabIndex = 33;
            // 
            // LMuertos
            // 
            this.LMuertos.Location = new System.Drawing.Point(115, 118);
            this.LMuertos.Name = "LMuertos";
            this.LMuertos.Size = new System.Drawing.Size(55, 21);
            this.LMuertos.Text = "muertos";
            // 
            // LVivos
            // 
            this.LVivos.Location = new System.Drawing.Point(2, 118);
            this.LVivos.Name = "LVivos";
            this.LVivos.Size = new System.Drawing.Size(40, 19);
            this.LVivos.Text = "vivos";
            // 
            // CbFacilidad
            // 
            this.CbFacilidad.Location = new System.Drawing.Point(75, 87);
            this.CbFacilidad.Name = "CbFacilidad";
            this.CbFacilidad.Size = new System.Drawing.Size(137, 22);
            this.CbFacilidad.TabIndex = 32;
            // 
            // cbTipo
            // 
            this.cbTipo.Location = new System.Drawing.Point(75, 58);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(137, 22);
            this.cbTipo.TabIndex = 31;
            // 
            // LFacilidad
            // 
            this.LFacilidad.Location = new System.Drawing.Point(2, 87);
            this.LFacilidad.Name = "LFacilidad";
            this.LFacilidad.Size = new System.Drawing.Size(62, 19);
            this.LFacilidad.Text = "Facilidad";
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(2, 58);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(62, 19);
            this.LTipo.Text = "Tipo";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(73, 30);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(84, 22);
            this.dtFecha.TabIndex = 30;
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(2, 30);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(62, 19);
            this.LFecha.Text = "Fecha";
            // 
            // pbBuscarhembra
            // 
            this.pbBuscarhembra.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscarhembra.Image")));
            this.pbBuscarhembra.Location = new System.Drawing.Point(212, 0);
            this.pbBuscarhembra.Name = "pbBuscarhembra";
            this.pbBuscarhembra.Size = new System.Drawing.Size(26, 23);
            this.pbBuscarhembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarhembra.Click += new System.EventHandler(this.pbBuscarhembra_Click);
            // 
            // LLote
            // 
            this.LLote.Location = new System.Drawing.Point(2, 0);
            this.LLote.Name = "LLote";
            this.LLote.Size = new System.Drawing.Size(65, 21);
            this.LLote.Text = "Lote";
            // 
            // TbLote
            // 
            this.TbLote.Location = new System.Drawing.Point(73, 0);
            this.TbLote.Name = "TbLote";
            this.TbLote.ReadOnly = true;
            this.TbLote.Size = new System.Drawing.Size(133, 21);
            this.TbLote.TabIndex = 29;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(4, 191);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(224, 57);
            this.dataGrid1.TabIndex = 44;
            // 
            // InsertarPartosMultiples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dataGrid1);
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
            this.Controls.Add(this.LLote);
            this.Controls.Add(this.TbLote);
            this.Name = "InsertarPartosMultiples";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarPartosMultiples_Closing);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.TbLote, 0);
            this.Controls.SetChildIndex(this.LLote, 0);
            this.Controls.SetChildIndex(this.pbBuscarhembra, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
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
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbCausaDeLamuerte;
        private System.Windows.Forms.Label LcausaMuete;
        private System.Windows.Forms.TextBox tbMuertos;
        private System.Windows.Forms.TextBox Tbvivos;
        private System.Windows.Forms.Label LMuertos;
        private System.Windows.Forms.Label LVivos;
        private System.Windows.Forms.ComboBox CbFacilidad;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label LFacilidad;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.PictureBox pbBuscarhembra;
        private System.Windows.Forms.Label LLote;
        private System.Windows.Forms.TextBox TbLote;
        private System.Windows.Forms.DataGrid dataGrid1;
    }
}
