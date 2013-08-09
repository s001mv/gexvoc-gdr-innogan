namespace GEXVOC.UI
{
    partial class InsertarCubricion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarCubricion));
            this.PbFiltrar = new System.Windows.Forms.PictureBox();
            this.TbLote = new System.Windows.Forms.TextBox();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.LFechaFin = new System.Windows.Forms.Label();
            this.LFechaIni = new System.Windows.Forms.Label();
            this.LLote = new System.Windows.Forms.Label();
            this.LTipo = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.TbFechaFIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // PbFiltrar
            // 
            this.PbFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("PbFiltrar.Image")));
            this.PbFiltrar.Location = new System.Drawing.Point(214, 14);
            this.PbFiltrar.Name = "PbFiltrar";
            this.PbFiltrar.Size = new System.Drawing.Size(23, 23);
            this.PbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFiltrar.Click += new System.EventHandler(this.PbFiltrar_Click);
            // 
            // TbLote
            // 
            this.TbLote.Location = new System.Drawing.Point(89, 14);
            this.TbLote.Name = "TbLote";
            this.TbLote.Size = new System.Drawing.Size(113, 21);
            this.TbLote.TabIndex = 16;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(87, 42);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(131, 22);
            this.dtFechaIni.TabIndex = 15;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(87, 70);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(131, 22);
            this.dtFechaFin.TabIndex = 14;
            this.dtFechaFin.ValueChanged += new System.EventHandler(this.dtFechaFin_ValueChanged);
            // 
            // LFechaFin
            // 
            this.LFechaFin.Location = new System.Drawing.Point(3, 74);
            this.LFechaFin.Name = "LFechaFin";
            this.LFechaFin.Size = new System.Drawing.Size(74, 19);
            this.LFechaFin.Text = "Fecha Fin";
            // 
            // LFechaIni
            // 
            this.LFechaIni.Location = new System.Drawing.Point(3, 42);
            this.LFechaIni.Name = "LFechaIni";
            this.LFechaIni.Size = new System.Drawing.Size(74, 19);
            this.LFechaIni.Text = "Fecha Inicio";
            // 
            // LLote
            // 
            this.LLote.Location = new System.Drawing.Point(3, 13);
            this.LLote.Name = "LLote";
            this.LLote.Size = new System.Drawing.Size(74, 19);
            this.LLote.Text = "Lote";
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(3, 105);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(74, 19);
            this.LTipo.Text = "Tipo";
            // 
            // CbTipo
            // 
            this.CbTipo.Location = new System.Drawing.Point(89, 105);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(125, 22);
            this.CbTipo.TabIndex = 22;
            // 
            // TbFechaFIn
            // 
            this.TbFechaFIn.Location = new System.Drawing.Point(87, 71);
            this.TbFechaFIn.Name = "TbFechaFIn";
            this.TbFechaFIn.Size = new System.Drawing.Size(114, 21);
            this.TbFechaFIn.TabIndex = 28;
            // 
            // InsertarCubricion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TbFechaFIn);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.PbFiltrar);
            this.Controls.Add(this.TbLote);
            this.Controls.Add(this.dtFechaIni);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.LFechaFin);
            this.Controls.Add(this.LFechaIni);
            this.Controls.Add(this.LLote);
            this.Name = "InsertarCubricion";
            this.Text = "Insertar Cubriciones";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarCubricion_Closing);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LLote, 0);
            this.Controls.SetChildIndex(this.LFechaIni, 0);
            this.Controls.SetChildIndex(this.LFechaFin, 0);
            this.Controls.SetChildIndex(this.dtFechaFin, 0);
            this.Controls.SetChildIndex(this.dtFechaIni, 0);
            this.Controls.SetChildIndex(this.TbLote, 0);
            this.Controls.SetChildIndex(this.PbFiltrar, 0);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.CbTipo, 0);
            this.Controls.SetChildIndex(this.TbFechaFIn, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbFiltrar;
        private System.Windows.Forms.TextBox TbLote;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label LFechaFin;
        private System.Windows.Forms.Label LFechaIni;
        private System.Windows.Forms.Label LLote;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.TextBox TbFechaFIn;
    }
}
