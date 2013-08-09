namespace GEXVOC.UI
{
    partial class InsertarCondicionCorporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarCondicionCorporal));
            this.LAnimal = new System.Windows.Forms.Label();
            this.LTipo = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.TbAnimal = new System.Windows.Forms.TextBox();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.PbBuscarAnimal = new System.Windows.Forms.PictureBox();
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
            this.LAnimal.Location = new System.Drawing.Point(5, 13);
            this.LAnimal.Name = "LAnimal";
            this.LAnimal.Size = new System.Drawing.Size(49, 18);
            this.LAnimal.Text = "Animal";
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(3, 45);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(49, 22);
            this.LTipo.Text = "Tipo";
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(5, 82);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(49, 22);
            this.LFecha.Text = "Fecha";
            // 
            // TbAnimal
            // 
            this.TbAnimal.Location = new System.Drawing.Point(66, 12);
            this.TbAnimal.Name = "TbAnimal";
            this.TbAnimal.ReadOnly = true;
            this.TbAnimal.Size = new System.Drawing.Size(132, 21);
            this.TbAnimal.TabIndex = 7;
            // 
            // CbTipo
            // 
            this.CbTipo.Location = new System.Drawing.Point(67, 45);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(130, 22);
            this.CbTipo.TabIndex = 8;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(69, 82);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(127, 22);
            this.dtFecha.TabIndex = 9;
            // 
            // PbBuscarAnimal
            // 
            this.PbBuscarAnimal.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscarAnimal.Image")));
            this.PbBuscarAnimal.Location = new System.Drawing.Point(208, 12);
            this.PbBuscarAnimal.Name = "PbBuscarAnimal";
            this.PbBuscarAnimal.Size = new System.Drawing.Size(21, 20);
            this.PbBuscarAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscarAnimal.Click += new System.EventHandler(this.PbBuscarAnimal_Click);
            // 
            // InsertarCondicionCorporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.PbBuscarAnimal);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.TbAnimal);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.LAnimal);
            this.Name = "InsertarCondicionCorporal";
            this.Text = "Insertar Condicion Corporal";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarCondicionCorporal_Closing);
            this.Controls.SetChildIndex(this.LAnimal, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.TbAnimal, 0);
            this.Controls.SetChildIndex(this.CbTipo, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.PbBuscarAnimal, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LAnimal;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.TextBox TbAnimal;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.PictureBox PbBuscarAnimal;
    }
}
