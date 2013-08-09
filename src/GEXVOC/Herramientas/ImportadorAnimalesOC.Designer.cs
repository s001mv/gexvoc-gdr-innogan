namespace GEXVOC.UI
{
    partial class ImportadorAnimalesOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportadorAnimalesOC));
            this.label1 = new System.Windows.Forms.Label();
            this.chkDescripcionesPrimeraFila = new System.Windows.Forms.CheckBox();
            this.btnEjecutarProceso = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtFichero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstListaImportar = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione el fichero *.csv para importar los animales de los tipos Ovino y Capri" +
                "no\r\nTambién puede arrastrar el fichero directamente a la lista \'Información de f" +
                "ichero\'";
            // 
            // chkDescripcionesPrimeraFila
            // 
            this.chkDescripcionesPrimeraFila.AutoSize = true;
            this.chkDescripcionesPrimeraFila.Checked = true;
            this.chkDescripcionesPrimeraFila.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDescripcionesPrimeraFila.Location = new System.Drawing.Point(524, 40);
            this.chkDescripcionesPrimeraFila.Name = "chkDescripcionesPrimeraFila";
            this.chkDescripcionesPrimeraFila.Size = new System.Drawing.Size(132, 17);
            this.chkDescripcionesPrimeraFila.TabIndex = 10;
            this.chkDescripcionesPrimeraFila.Text = "Decripciones 1ª Línea";
            this.toolTip1.SetToolTip(this.chkDescripcionesPrimeraFila, "Nos indica si la primera línea del fichero contiene las descripciones de las colu" +
                    "mnas, o si simplemente contiene datos al igual que las demás.");
            this.chkDescripcionesPrimeraFila.UseVisualStyleBackColor = true;
            this.chkDescripcionesPrimeraFila.CheckedChanged += new System.EventHandler(this.chkDescripcionesPrimeraFila_CheckedChanged);
            // 
            // btnEjecutarProceso
            // 
            this.btnEjecutarProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutarProceso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEjecutarProceso.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecutarProceso.Image")));
            this.btnEjecutarProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutarProceso.Location = new System.Drawing.Point(245, 426);
            this.btnEjecutarProceso.Name = "btnEjecutarProceso";
            this.btnEjecutarProceso.Size = new System.Drawing.Size(180, 51);
            this.btnEjecutarProceso.TabIndex = 9;
            this.btnEjecutarProceso.Text = "Comenzar Proceso";
            this.btnEjecutarProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEjecutarProceso, "Comienza el proceso de importación de los controles lecheros");
            this.btnEjecutarProceso.UseVisualStyleBackColor = true;
            this.btnEjecutarProceso.Click += new System.EventHandler(this.btnEjecutarProceso_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(417, 40);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(86, 21);
            this.btnExaminar.TabIndex = 8;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtFichero
            // 
            this.txtFichero.BackColor = System.Drawing.Color.White;
            this.txtFichero.Location = new System.Drawing.Point(15, 40);
            this.txtFichero.Name = "txtFichero";
            this.txtFichero.Size = new System.Drawing.Size(396, 20);
            this.txtFichero.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListaImportar);
            this.groupBox1.Location = new System.Drawing.Point(9, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 353);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Fichero";
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
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos CSV|*.csv|Todos los Archivos|*.*";
            // 
            // ImportadorAnimalesOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(667, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkDescripcionesPrimeraFila);
            this.Controls.Add(this.btnEjecutarProceso);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.txtFichero);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportadorAnimalesOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importador Animales (Ovino-Caprino)";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDescripcionesPrimeraFila;
        private System.Windows.Forms.Button btnEjecutarProceso;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtFichero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstListaImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}
