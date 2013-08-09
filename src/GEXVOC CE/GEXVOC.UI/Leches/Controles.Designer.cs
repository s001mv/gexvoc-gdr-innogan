namespace GEXVOC.UI
{
    partial class Controles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controles));
            this.DgControlesLecheros = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.LFechaControl = new System.Windows.Forms.Label();
            this.LEspecie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.CbEspecie = new System.Windows.Forms.ComboBox();
            this.CbControl = new System.Windows.Forms.ComboBox();
            this.CbOrdeño = new System.Windows.Forms.ComboBox();
            this.PbBuscar = new System.Windows.Forms.PictureBox();
            this.PbAnadir = new System.Windows.Forms.PictureBox();
            this.TbFecha = new System.Windows.Forms.TextBox();
            this.TbControl = new System.Windows.Forms.TextBox();
            this.TbEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // DgControlesLecheros
            // 
            this.DgControlesLecheros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DgControlesLecheros.Location = new System.Drawing.Point(13, 147);
            this.DgControlesLecheros.Name = "DgControlesLecheros";
            this.DgControlesLecheros.Size = new System.Drawing.Size(216, 94);
            this.DgControlesLecheros.TabIndex = 2;
            this.DgControlesLecheros.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.MappingName = "Control";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Animal";
            this.dataGridTextBoxColumn1.MappingName = "Nombre";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "NºControl";
            this.dataGridTextBoxColumn2.MappingName = "Numero";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridTextBoxColumn3.MappingName = "Fecha";
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Mañana";
            this.dataGridTextBoxColumn4.MappingName = "LecheManana";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Tarde";
            this.dataGridTextBoxColumn5.MappingName = "LecheTarde";
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Noche";
            this.dataGridTextBoxColumn6.MappingName = "LecheNoche";
            // 
            // LFechaControl
            // 
            this.LFechaControl.Location = new System.Drawing.Point(0, 0);
            this.LFechaControl.Name = "LFechaControl";
            this.LFechaControl.Size = new System.Drawing.Size(92, 19);
            this.LFechaControl.Text = "Fecha control";
            // 
            // LEspecie
            // 
            this.LEspecie.Location = new System.Drawing.Point(3, 29);
            this.LEspecie.Name = "LEspecie";
            this.LEspecie.Size = new System.Drawing.Size(92, 19);
            this.LEspecie.Text = "Especie";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.Text = "Estado Control";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.Text = "Estado ordeño";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(98, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(131, 22);
            this.dtFecha.TabIndex = 9;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // CbEspecie
            // 
            this.CbEspecie.Location = new System.Drawing.Point(98, 28);
            this.CbEspecie.Name = "CbEspecie";
            this.CbEspecie.Size = new System.Drawing.Size(131, 22);
            this.CbEspecie.TabIndex = 10;
            // 
            // CbControl
            // 
            this.CbControl.Location = new System.Drawing.Point(98, 64);
            this.CbControl.Name = "CbControl";
            this.CbControl.Size = new System.Drawing.Size(131, 22);
            this.CbControl.TabIndex = 11;
            this.CbControl.SelectedValueChanged += new System.EventHandler(this.CbControl_SelectedValueChanged);
            // 
            // CbOrdeño
            // 
            this.CbOrdeño.Location = new System.Drawing.Point(98, 96);
            this.CbOrdeño.Name = "CbOrdeño";
            this.CbOrdeño.Size = new System.Drawing.Size(131, 22);
            this.CbOrdeño.TabIndex = 12;
            this.CbOrdeño.SelectedValueChanged += new System.EventHandler(this.CbOrdeño_SelectedValueChanged);
            // 
            // PbBuscar
            // 
            this.PbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscar.Image")));
            this.PbBuscar.Location = new System.Drawing.Point(70, 124);
            this.PbBuscar.Name = "PbBuscar";
            this.PbBuscar.Size = new System.Drawing.Size(28, 23);
            this.PbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscar.Click += new System.EventHandler(this.PbBuscar_Click);
            // 
            // PbAnadir
            // 
            this.PbAnadir.Image = ((System.Drawing.Image)(resources.GetObject("PbAnadir.Image")));
            this.PbAnadir.Location = new System.Drawing.Point(13, 124);
            this.PbAnadir.Name = "PbAnadir";
            this.PbAnadir.Size = new System.Drawing.Size(28, 23);
            this.PbAnadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnadir.Click += new System.EventHandler(this.PbAnadir_Click);
            // 
            // TbFecha
            // 
            this.TbFecha.Location = new System.Drawing.Point(99, 1);
            this.TbFecha.Name = "TbFecha";
            this.TbFecha.Size = new System.Drawing.Size(119, 21);
            this.TbFecha.TabIndex = 17;
            // 
            // TbControl
            // 
            this.TbControl.Location = new System.Drawing.Point(98, 64);
            this.TbControl.Name = "TbControl";
            this.TbControl.Size = new System.Drawing.Size(118, 21);
            this.TbControl.TabIndex = 24;
            // 
            // TbEstado
            // 
            this.TbEstado.Location = new System.Drawing.Point(98, 97);
            this.TbEstado.Name = "TbEstado";
            this.TbEstado.Size = new System.Drawing.Size(118, 21);
            this.TbEstado.TabIndex = 25;
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TbEstado);
            this.Controls.Add(this.TbControl);
            this.Controls.Add(this.TbFecha);
            this.Controls.Add(this.PbAnadir);
            this.Controls.Add(this.PbBuscar);
            this.Controls.Add(this.CbOrdeño);
            this.Controls.Add(this.CbControl);
            this.Controls.Add(this.CbEspecie);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LEspecie);
            this.Controls.Add(this.LFechaControl);
            this.Controls.Add(this.DgControlesLecheros);
            this.Name = "Controles";
            this.Text = "Control lechero";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Controles_Closing);
            this.Controls.SetChildIndex(this.DgControlesLecheros, 0);
            this.Controls.SetChildIndex(this.LFechaControl, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LEspecie, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.CbEspecie, 0);
            this.Controls.SetChildIndex(this.CbControl, 0);
            this.Controls.SetChildIndex(this.CbOrdeño, 0);
            this.Controls.SetChildIndex(this.PbBuscar, 0);
            this.Controls.SetChildIndex(this.PbAnadir, 0);
            this.Controls.SetChildIndex(this.TbFecha, 0);
            this.Controls.SetChildIndex(this.TbControl, 0);
            this.Controls.SetChildIndex(this.TbEstado, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid DgControlesLecheros;
        private System.Windows.Forms.Label LFechaControl;
        private System.Windows.Forms.Label LEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox CbEspecie;
        private System.Windows.Forms.ComboBox CbControl;
        private System.Windows.Forms.ComboBox CbOrdeño;
        private System.Windows.Forms.PictureBox PbBuscar;
        private System.Windows.Forms.PictureBox PbAnadir;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.TextBox TbFecha;
        private System.Windows.Forms.TextBox TbControl;
        private System.Windows.Forms.TextBox TbEstado;
    }
}
