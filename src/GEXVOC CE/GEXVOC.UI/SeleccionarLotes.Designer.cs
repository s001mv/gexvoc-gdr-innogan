namespace GEXVOC.UI
{
    partial class SeleccionarLotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarLotes));
            this.LTipo = new System.Windows.Forms.Label();
            this.Descripticon = new System.Windows.Forms.Label();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.dglotes = new System.Windows.Forms.DataGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PbBuscar = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(4, 0);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(55, 20);
            this.LTipo.Text = "Tipo";
            // 
            // Descripticon
            // 
            this.Descripticon.Location = new System.Drawing.Point(4, 32);
            this.Descripticon.Name = "Descripticon";
            this.Descripticon.Size = new System.Drawing.Size(72, 20);
            this.Descripticon.Text = "Descripcion";
            // 
            // cbTipos
            // 
            this.cbTipos.Location = new System.Drawing.Point(92, 0);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(127, 22);
            this.cbTipos.TabIndex = 5;
            // 
            // dglotes
            // 
            this.dglotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dglotes.Location = new System.Drawing.Point(1, 99);
            this.dglotes.Name = "dglotes";
            this.dglotes.Size = new System.Drawing.Size(238, 149);
            this.dglotes.TabIndex = 6;
            this.dglotes.Click += new System.EventHandler(this.dglotes_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 21);
            this.textBox1.TabIndex = 7;
            // 
            // PbBuscar
            // 
            this.PbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscar.Image")));
            this.PbBuscar.Location = new System.Drawing.Point(92, 59);
            this.PbBuscar.Name = "PbBuscar";
            this.PbBuscar.Size = new System.Drawing.Size(23, 21);
            this.PbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // SeleccionarLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.PbBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dglotes);
            this.Controls.Add(this.cbTipos);
            this.Controls.Add(this.Descripticon);
            this.Controls.Add(this.LTipo);
            this.Name = "SeleccionarLotes";
            this.Text = "Seleccionar Lotes";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.SeleccionarLotes_Closing);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.Descripticon, 0);
            this.Controls.SetChildIndex(this.cbTipos, 0);
            this.Controls.SetChildIndex(this.dglotes, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.PbBuscar, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label Descripticon;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.DataGrid dglotes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox PbBuscar;
    }
}
