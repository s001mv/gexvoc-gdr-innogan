namespace GEXVOC.UI
{
    partial class InsertarPeso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarPeso));
            this.LAnimal = new System.Windows.Forms.Label();
            this.LPeso = new System.Windows.Forms.Label();
            this.LMomento = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.lKgs = new System.Windows.Forms.Label();
            this.TbAnimal = new System.Windows.Forms.TextBox();
            this.tbKg = new System.Windows.Forms.TextBox();
            this.cbMomento = new System.Windows.Forms.ComboBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.PbBuscaAnimal = new System.Windows.Forms.PictureBox();
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
            this.LAnimal.Location = new System.Drawing.Point(5, 12);
            this.LAnimal.Name = "LAnimal";
            this.LAnimal.Size = new System.Drawing.Size(70, 22);
            this.LAnimal.Text = "Animal";
            // 
            // LPeso
            // 
            this.LPeso.Location = new System.Drawing.Point(5, 43);
            this.LPeso.Name = "LPeso";
            this.LPeso.Size = new System.Drawing.Size(70, 22);
            this.LPeso.Text = "Peso";
            // 
            // LMomento
            // 
            this.LMomento.Location = new System.Drawing.Point(5, 84);
            this.LMomento.Name = "LMomento";
            this.LMomento.Size = new System.Drawing.Size(70, 22);
            this.LMomento.Text = "Momento";
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(5, 123);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(70, 22);
            this.LFecha.Text = "Fecha";
            // 
            // lKgs
            // 
            this.lKgs.Location = new System.Drawing.Point(169, 43);
            this.lKgs.Name = "lKgs";
            this.lKgs.Size = new System.Drawing.Size(36, 22);
            this.lKgs.Text = "Kgs";
            // 
            // TbAnimal
            // 
            this.TbAnimal.Location = new System.Drawing.Point(85, 10);
            this.TbAnimal.Name = "TbAnimal";
            this.TbAnimal.ReadOnly = true;
            this.TbAnimal.Size = new System.Drawing.Size(119, 21);
            this.TbAnimal.TabIndex = 11;
            // 
            // tbKg
            // 
            this.tbKg.Location = new System.Drawing.Point(85, 43);
            this.tbKg.Name = "tbKg";
            this.tbKg.Size = new System.Drawing.Size(34, 21);
            this.tbKg.TabIndex = 12;
            this.tbKg.TextChanged += new System.EventHandler(this.tbKg_TextChanged);
            // 
            // cbMomento
            // 
            this.cbMomento.Location = new System.Drawing.Point(88, 83);
            this.cbMomento.Name = "cbMomento";
            this.cbMomento.Size = new System.Drawing.Size(116, 22);
            this.cbMomento.TabIndex = 13;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(89, 123);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(92, 22);
            this.dtfecha.TabIndex = 14;
            // 
            // PbBuscaAnimal
            // 
            this.PbBuscaAnimal.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscaAnimal.Image")));
            this.PbBuscaAnimal.Location = new System.Drawing.Point(210, 12);
            this.PbBuscaAnimal.Name = "PbBuscaAnimal";
            this.PbBuscaAnimal.Size = new System.Drawing.Size(29, 18);
            this.PbBuscaAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscaAnimal.Click += new System.EventHandler(this.PbBuscaAnimal_Click);
            // 
            // InsertarPeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.PbBuscaAnimal);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.cbMomento);
            this.Controls.Add(this.tbKg);
            this.Controls.Add(this.TbAnimal);
            this.Controls.Add(this.lKgs);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LMomento);
            this.Controls.Add(this.LPeso);
            this.Controls.Add(this.LAnimal);
            this.Name = "InsertarPeso";
            this.Text = "Inserta Pesos";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarPeso_Closing);
            this.Controls.SetChildIndex(this.LAnimal, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LPeso, 0);
            this.Controls.SetChildIndex(this.LMomento, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.lKgs, 0);
            this.Controls.SetChildIndex(this.TbAnimal, 0);
            this.Controls.SetChildIndex(this.tbKg, 0);
            this.Controls.SetChildIndex(this.cbMomento, 0);
            this.Controls.SetChildIndex(this.dtfecha, 0);
            this.Controls.SetChildIndex(this.PbBuscaAnimal, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LAnimal;
        private System.Windows.Forms.Label LPeso;
        private System.Windows.Forms.Label LMomento;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label lKgs;
        private System.Windows.Forms.TextBox TbAnimal;
        private System.Windows.Forms.TextBox tbKg;
        private System.Windows.Forms.ComboBox cbMomento;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.PictureBox PbBuscaAnimal;
    }
}
