namespace GEXVOC.UI
{
    partial class Explotaciones
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
            this.DgExplotaciones = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // DgExplotaciones
            // 
            this.DgExplotaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DgExplotaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgExplotaciones.Location = new System.Drawing.Point(0, 0);
            this.DgExplotaciones.Name = "DgExplotaciones";
            this.DgExplotaciones.Size = new System.Drawing.Size(240, 268);
            this.DgExplotaciones.TabIndex = 2;
            this.DgExplotaciones.TableStyles.Add(this.dataGridTableStyle1);
            this.DgExplotaciones.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DgExplotaciones_MouseUp);
            this.DgExplotaciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgExplotaciones_MouseDown);
            this.DgExplotaciones.Click += new System.EventHandler(this.SeleccionExplotacion_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.MappingName = "explotacion";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridTextBoxColumn1.MappingName = "Nombre";
            this.dataGridTextBoxColumn1.Width = 250;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Id";
            this.dataGridTextBoxColumn2.MappingName = "Id";
            this.dataGridTextBoxColumn2.Width = 0;
            // 
            // Explotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.DgExplotaciones);
            this.Name = "Explotaciones";
            this.Text = "Explotaciones";
            this.Load += new System.EventHandler(this.Explotaciones_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Explotaciones_Closing);
            this.Controls.SetChildIndex(this.DgExplotaciones, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid DgExplotaciones;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
    }
}
