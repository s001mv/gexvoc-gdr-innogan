namespace GEXVOC.UI
{
    partial class InsertarSecados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarSecados));
            this.LHembra = new System.Windows.Forms.Label();
            this.LTipo = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LMotivo = new System.Windows.Forms.Label();
            this.TbHembra = new System.Windows.Forms.TextBox();
            this.CbTipoSecado = new System.Windows.Forms.ComboBox();
            this.CbMotivo = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.PbBuscaHembra = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // LHembra
            // 
            this.LHembra.Location = new System.Drawing.Point(7, 13);
            this.LHembra.Name = "LHembra";
            this.LHembra.Size = new System.Drawing.Size(66, 19);
            this.LHembra.Text = "Hembra";
            // 
            // LTipo
            // 
            this.LTipo.Location = new System.Drawing.Point(7, 45);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(66, 19);
            this.LTipo.Text = "Tipo";
            // 
            // LFecha
            // 
            this.LFecha.Location = new System.Drawing.Point(7, 77);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(68, 19);
            this.LFecha.Text = "Fecha";
            // 
            // LMotivo
            // 
            this.LMotivo.Location = new System.Drawing.Point(7, 113);
            this.LMotivo.Name = "LMotivo";
            this.LMotivo.Size = new System.Drawing.Size(66, 19);
            this.LMotivo.Text = "Motivo";
            // 
            // TbHembra
            // 
            this.TbHembra.Location = new System.Drawing.Point(79, 15);
            this.TbHembra.Name = "TbHembra";
            this.TbHembra.Size = new System.Drawing.Size(126, 21);
            this.TbHembra.TabIndex = 9;
            // 
            // CbTipoSecado
            // 
            this.CbTipoSecado.Location = new System.Drawing.Point(79, 42);
            this.CbTipoSecado.Name = "CbTipoSecado";
            this.CbTipoSecado.Size = new System.Drawing.Size(125, 22);
            this.CbTipoSecado.TabIndex = 10;
            // 
            // CbMotivo
            // 
            this.CbMotivo.Location = new System.Drawing.Point(79, 113);
            this.CbMotivo.Name = "CbMotivo";
            this.CbMotivo.Size = new System.Drawing.Size(126, 22);
            this.CbMotivo.TabIndex = 11;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(81, 78);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(122, 22);
            this.dtFecha.TabIndex = 12;
            // 
            // PbBuscaHembra
            // 
            this.PbBuscaHembra.Image = ((System.Drawing.Image)(resources.GetObject("PbBuscaHembra.Image")));
            this.PbBuscaHembra.Location = new System.Drawing.Point(211, 16);
            this.PbBuscaHembra.Name = "PbBuscaHembra";
            this.PbBuscaHembra.Size = new System.Drawing.Size(19, 19);
            this.PbBuscaHembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuscaHembra.Click += new System.EventHandler(this.PbBuscaHembra_Click);
            // 
            // InsertarSecados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.PbBuscaHembra);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.CbMotivo);
            this.Controls.Add(this.CbTipoSecado);
            this.Controls.Add(this.TbHembra);
            this.Controls.Add(this.LMotivo);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.LHembra);
            this.Name = "InsertarSecados";
            this.Text = "Insertar Secados";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarSecados_Closing);
            this.Controls.SetChildIndex(this.LHembra, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.LTipo, 0);
            this.Controls.SetChildIndex(this.LFecha, 0);
            this.Controls.SetChildIndex(this.LMotivo, 0);
            this.Controls.SetChildIndex(this.TbHembra, 0);
            this.Controls.SetChildIndex(this.CbTipoSecado, 0);
            this.Controls.SetChildIndex(this.CbMotivo, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.PbBuscaHembra, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LHembra;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LMotivo;
        private System.Windows.Forms.TextBox TbHembra;
        private System.Windows.Forms.ComboBox CbTipoSecado;
        private System.Windows.Forms.ComboBox CbMotivo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.PictureBox PbBuscaHembra;
    }
}
