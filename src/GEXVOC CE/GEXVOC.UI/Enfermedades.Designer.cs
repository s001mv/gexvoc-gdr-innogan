namespace GEXVOC.UI
{
    partial class Enfermedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enfermedades));
            this.LTipo = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DgEnfermedades = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
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
            this.LTipo.Location = new System.Drawing.Point(6, 9);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(71, 19);
            this.LTipo.Text = "Tipo";
            // 
            // LNombre
            // 
            this.LNombre.Location = new System.Drawing.Point(6, 43);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(71, 19);
            this.LNombre.Text = "Nombre";
            // 
            // CbTipo
            // 
            this.CbTipo.Location = new System.Drawing.Point(100, 9);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(100, 22);
            this.CbTipo.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 21);
            this.textBox1.TabIndex = 6;
            // 
            // DgEnfermedades
            // 
            this.DgEnfermedades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DgEnfermedades.Location = new System.Drawing.Point(6, 96);
            this.DgEnfermedades.Name = "DgEnfermedades";
            this.DgEnfermedades.Size = new System.Drawing.Size(227, 146);
            this.DgEnfermedades.TabIndex = 7;
            this.DgEnfermedades.TableStyles.Add(this.dataGridTableStyle1);
            this.DgEnfermedades.Click += new System.EventHandler(this.DgEnfermedades_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.MappingName = "Enfermedad";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridTextBoxColumn1.MappingName = "Tipo";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridTextBoxColumn2.MappingName = "Descripcion";
            // 
            // PbBuscar
            // 
            this.PbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscar.Image")));
            this.PbBuscar.Location = new System.Drawing.Point(92, 70);
            this.PbBuscar.Name = "PbBuscar";
            this.PbBuscar.Size = new System.Drawing.Size(29, 20);
            this.PbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // Enfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.PbBuscar);
            this.Controls.Add(this.DgEnfermedades);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LTipo);
            this.Name = "Enfermedades";
            this.Text = "Enfermedades";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Enfermedades_Closing);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LNombre, 0);
            this.Controls.SetChildIndex(this.CbTipo, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.DgEnfermedades, 0);
            this.Controls.SetChildIndex(this.PbBuscar, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGrid DgEnfermedades;
        private System.Windows.Forms.PictureBox PbBuscar;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
    }
}
