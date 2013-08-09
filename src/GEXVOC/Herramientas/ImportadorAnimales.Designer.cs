namespace GEXVOC.UI
{
    partial class ImportadorAnimales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportadorAnimales));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFichero = new System.Windows.Forms.TextBox();
            this.lstListaImportar = new System.Windows.Forms.ListView();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEjecutarProceso = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nudFilasDescartar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilasDescartar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtFichero
            // 
            this.txtFichero.BackColor = System.Drawing.Color.White;
            this.txtFichero.Location = new System.Drawing.Point(13, 47);
            this.txtFichero.Name = "txtFichero";
            this.txtFichero.Size = new System.Drawing.Size(396, 20);
            this.txtFichero.TabIndex = 7;
            // 
            // lstListaImportar
            // 
            this.lstListaImportar.AllowDrop = true;
            this.lstListaImportar.FullRowSelect = true;
            this.lstListaImportar.Location = new System.Drawing.Point(6, 19);
            this.lstListaImportar.Name = "lstListaImportar";
            this.lstListaImportar.ShowItemToolTips = true;
            this.lstListaImportar.Size = new System.Drawing.Size(629, 328);
            this.lstListaImportar.TabIndex = 0;
            this.lstListaImportar.UseCompatibleStateImageBehavior = false;
            this.lstListaImportar.View = System.Windows.Forms.View.Details;
            this.lstListaImportar.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstListaImportar_DragDrop);
            this.lstListaImportar.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstListaImportar_DragEnter);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(415, 47);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(86, 21);
            this.btnExaminar.TabIndex = 8;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListaImportar);
            this.groupBox1.Location = new System.Drawing.Point(7, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 353);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Fichero";
            // 
            // btnEjecutarProceso
            // 
            this.btnEjecutarProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutarProceso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEjecutarProceso.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecutarProceso.Image")));
            this.btnEjecutarProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutarProceso.Location = new System.Drawing.Point(243, 433);
            this.btnEjecutarProceso.Name = "btnEjecutarProceso";
            this.btnEjecutarProceso.Size = new System.Drawing.Size(180, 51);
            this.btnEjecutarProceso.TabIndex = 9;
            this.btnEjecutarProceso.Text = "Comenzar Proceso";
            this.btnEjecutarProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEjecutarProceso, "Comienza el proceso de importación de los controles lecheros");
            this.btnEjecutarProceso.UseVisualStyleBackColor = true;
            this.btnEjecutarProceso.Click += new System.EventHandler(this.btnEjecutarProceso_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos CSV|*.csv|Todos los Archivos|*.*";
            // 
            // nudFilasDescartar
            // 
            this.nudFilasDescartar.Location = new System.Drawing.Point(607, 49);
            this.nudFilasDescartar.Name = "nudFilasDescartar";
            this.nudFilasDescartar.Size = new System.Drawing.Size(35, 20);
            this.nudFilasDescartar.TabIndex = 11;
            this.nudFilasDescartar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFilasDescartar.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFilasDescartar.ValueChanged += new System.EventHandler(this.nudFilasDescartar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filas Descartar";
            // 
            // ImportadorAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(698, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudFilasDescartar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEjecutarProceso);
            this.Controls.Add(this.txtFichero);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportadorAnimales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importador de Animales (Bovino)";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFilasDescartar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEjecutarProceso;
        private System.Windows.Forms.TextBox txtFichero;
        private System.Windows.Forms.ListView lstListaImportar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown nudFilasDescartar;
        private System.Windows.Forms.Label label2;
    }
}
