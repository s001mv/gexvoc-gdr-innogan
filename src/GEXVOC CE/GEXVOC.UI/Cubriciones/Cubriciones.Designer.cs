namespace GEXVOC.UI
{
    partial class Cubriciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cubriciones));
            this.LLote = new System.Windows.Forms.Label();
            this.LFechaIni = new System.Windows.Forms.Label();
            this.LFechaFin = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PbFiltrar = new System.Windows.Forms.PictureBox();
            this.PbAnadir = new System.Windows.Forms.PictureBox();
            this.dgCubriciones = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // LLote
            // 
            this.LLote.Location = new System.Drawing.Point(4, 10);
            this.LLote.Name = "LLote";
            this.LLote.Size = new System.Drawing.Size(74, 19);
            this.LLote.Text = "Lote";
            // 
            // LFechaIni
            // 
            this.LFechaIni.Location = new System.Drawing.Point(4, 39);
            this.LFechaIni.Name = "LFechaIni";
            this.LFechaIni.Size = new System.Drawing.Size(74, 19);
            this.LFechaIni.Text = "Fecha Inicio";
            // 
            // LFechaFin
            // 
            this.LFechaFin.Location = new System.Drawing.Point(4, 71);
            this.LFechaFin.Name = "LFechaFin";
            this.LFechaFin.Size = new System.Drawing.Size(74, 19);
            this.LFechaFin.Text = "Fecha Fin";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(88, 67);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(131, 22);
            this.dtFechaFin.TabIndex = 7;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Location = new System.Drawing.Point(88, 39);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(131, 22);
            this.dtFechaIni.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 21);
            this.textBox1.TabIndex = 9;
            // 
            // PbFiltrar
            // 
            this.PbFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("PbFiltrar.Image")));
            this.PbFiltrar.Location = new System.Drawing.Point(96, 104);
            this.PbFiltrar.Name = "PbFiltrar";
            this.PbFiltrar.Size = new System.Drawing.Size(23, 23);
            this.PbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // PbAnadir
            // 
            this.PbAnadir.Image = ((System.Drawing.Image)(resources.GetObject("PbAnadir.Image")));
            this.PbAnadir.Location = new System.Drawing.Point(196, 104);
            this.PbAnadir.Name = "PbAnadir";
            this.PbAnadir.Size = new System.Drawing.Size(23, 23);
            this.PbAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnadir.Click += new System.EventHandler(this.PbAnadir_Click);
            // 
            // dgCubriciones
            // 
            this.dgCubriciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgCubriciones.Location = new System.Drawing.Point(4, 135);
            this.dgCubriciones.Name = "dgCubriciones";
            this.dgCubriciones.Size = new System.Drawing.Size(225, 106);
            this.dgCubriciones.TabIndex = 13;
            // 
            // Cubriciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dgCubriciones);
            this.Controls.Add(this.PbAnadir);
            this.Controls.Add(this.PbFiltrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtFechaIni);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.LFechaFin);
            this.Controls.Add(this.LFechaIni);
            this.Controls.Add(this.LLote);
            this.Name = "Cubriciones";
            this.Text = "Cubriciones";
            this.Controls.SetChildIndex(this.LLote, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LFechaIni, 0);
            this.Controls.SetChildIndex(this.LFechaFin, 0);
            this.Controls.SetChildIndex(this.dtFechaFin, 0);
            this.Controls.SetChildIndex(this.dtFechaIni, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.PbFiltrar, 0);
            this.Controls.SetChildIndex(this.PbAnadir, 0);
            this.Controls.SetChildIndex(this.dgCubriciones, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LLote;
        private System.Windows.Forms.Label LFechaIni;
        private System.Windows.Forms.Label LFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox PbFiltrar;
        private System.Windows.Forms.PictureBox PbAnadir;
        private System.Windows.Forms.DataGrid dgCubriciones;
    }
}
