namespace GEXVOC.UI
{
    partial class InsertarAnimal
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
            this.CbEspecie = new System.Windows.Forms.ComboBox();
            this.LEspecie = new System.Windows.Forms.Label();
            this.CBRaza = new System.Windows.Forms.ComboBox();
            this.Lraza = new System.Windows.Forms.Label();
            this.LDIB = new System.Windows.Forms.Label();
            this.TbDIB = new System.Windows.Forms.TextBox();
            this.LCrotal = new System.Windows.Forms.Label();
            this.TbCrotal = new System.Windows.Forms.TextBox();
            this.LFnac = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LSexo = new System.Windows.Forms.Label();
            this.CbSexo = new System.Windows.Forms.ComboBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LTatuaje = new System.Windows.Forms.Label();
            this.TbTatuaje = new System.Windows.Forms.TextBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.LTalla = new System.Windows.Forms.Label();
            this.CBTnacimiento = new System.Windows.Forms.ComboBox();
            this.LConformacion = new System.Windows.Forms.Label();
            this.CBConformacionActual = new System.Windows.Forms.ComboBox();
            this.LFalta = new System.Windows.Forms.Label();
            this.DTFalta = new System.Windows.Forms.DateTimePicker();
            this.LTalta = new System.Windows.Forms.Label();
            this.CbTAlta = new System.Windows.Forms.ComboBox();
            this.LDetalle = new System.Windows.Forms.Label();
            this.TbDetalle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 342);
            this.statusBar1.Size = new System.Drawing.Size(227, 20);
            // 
            // CbEspecie
            // 
            this.CbEspecie.Location = new System.Drawing.Point(68, 0);
            this.CbEspecie.Name = "CbEspecie";
            this.CbEspecie.Size = new System.Drawing.Size(151, 22);
            this.CbEspecie.TabIndex = 3;
            this.CbEspecie.SelectedValueChanged += new System.EventHandler(this.CbEspecie_SelectedValueChanged);
            // 
            // LEspecie
            // 
            this.LEspecie.Location = new System.Drawing.Point(3, 0);
            this.LEspecie.Name = "LEspecie";
            this.LEspecie.Size = new System.Drawing.Size(48, 21);
            this.LEspecie.Text = "Especie";
            // 
            // CBRaza
            // 
            this.CBRaza.Location = new System.Drawing.Point(68, 29);
            this.CBRaza.Name = "CBRaza";
            this.CBRaza.Size = new System.Drawing.Size(151, 22);
            this.CBRaza.TabIndex = 5;
            // 
            // Lraza
            // 
            this.Lraza.Location = new System.Drawing.Point(3, 29);
            this.Lraza.Name = "Lraza";
            this.Lraza.Size = new System.Drawing.Size(35, 21);
            this.Lraza.Text = "Raza";
            // 
            // LDIB
            // 
            this.LDIB.Location = new System.Drawing.Point(3, 58);
            this.LDIB.Name = "LDIB";
            this.LDIB.Size = new System.Drawing.Size(28, 21);
            this.LDIB.Text = "DIB";
            // 
            // TbDIB
            // 
            this.TbDIB.Location = new System.Drawing.Point(68, 58);
            this.TbDIB.Name = "TbDIB";
            this.TbDIB.Size = new System.Drawing.Size(151, 21);
            this.TbDIB.TabIndex = 9;
            this.TbDIB.TextChanged += new System.EventHandler(this.TbDIB_TextChanged);
            // 
            // LCrotal
            // 
            this.LCrotal.Location = new System.Drawing.Point(3, 91);
            this.LCrotal.Name = "LCrotal";
            this.LCrotal.Size = new System.Drawing.Size(38, 21);
            this.LCrotal.Text = "Crotal";
            // 
            // TbCrotal
            // 
            this.TbCrotal.Location = new System.Drawing.Point(68, 91);
            this.TbCrotal.Name = "TbCrotal";
            this.TbCrotal.Size = new System.Drawing.Size(151, 21);
            this.TbCrotal.TabIndex = 11;
            this.TbCrotal.TextChanged += new System.EventHandler(this.TbCrotal_TextChanged);
            // 
            // LFnac
            // 
            this.LFnac.Location = new System.Drawing.Point(3, 121);
            this.LFnac.Name = "LFnac";
            this.LFnac.Size = new System.Drawing.Size(35, 21);
            this.LFnac.Text = "F.Nac";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // LSexo
            // 
            this.LSexo.Location = new System.Drawing.Point(137, 120);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(42, 21);
            this.LSexo.Text = "Sexo";
            // 
            // CbSexo
            // 
            this.CbSexo.Items.Add("H");
            this.CbSexo.Items.Add("M");
            this.CbSexo.Location = new System.Drawing.Point(185, 120);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(41, 22);
            this.CbSexo.TabIndex = 26;
            // 
            // LNombre
            // 
            this.LNombre.Location = new System.Drawing.Point(3, 145);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(59, 21);
            this.LNombre.Text = "Nombre";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(68, 145);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(150, 21);
            this.TbNombre.TabIndex = 28;
            this.TbNombre.TextChanged += new System.EventHandler(this.TbNombre_TextChanged);
            // 
            // LTatuaje
            // 
            this.LTatuaje.Location = new System.Drawing.Point(3, 194);
            this.LTatuaje.Name = "LTatuaje";
            this.LTatuaje.Size = new System.Drawing.Size(59, 21);
            this.LTatuaje.Text = "Tatuaje";
            // 
            // TbTatuaje
            // 
            this.TbTatuaje.Location = new System.Drawing.Point(68, 194);
            this.TbTatuaje.Name = "TbTatuaje";
            this.TbTatuaje.Size = new System.Drawing.Size(150, 21);
            this.TbTatuaje.TabIndex = 38;
            this.TbTatuaje.TextChanged += new System.EventHandler(this.TbTatuaje_TextChanged);
            // 
            // LEstado
            // 
            this.LEstado.Location = new System.Drawing.Point(3, 171);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(56, 21);
            this.LEstado.Text = "Estado";
            // 
            // CBEstado
            // 
            this.CBEstado.Location = new System.Drawing.Point(68, 170);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(150, 22);
            this.CBEstado.TabIndex = 40;
            // 
            // LTalla
            // 
            this.LTalla.Location = new System.Drawing.Point(3, 218);
            this.LTalla.Name = "LTalla";
            this.LTalla.Size = new System.Drawing.Size(109, 21);
            this.LTalla.Text = "Talla al nacimiento";
            // 
            // CBTnacimiento
            // 
            this.CBTnacimiento.Location = new System.Drawing.Point(112, 217);
            this.CBTnacimiento.Name = "CBTnacimiento";
            this.CBTnacimiento.Size = new System.Drawing.Size(107, 22);
            this.CBTnacimiento.TabIndex = 51;
            // 
            // LConformacion
            // 
            this.LConformacion.Location = new System.Drawing.Point(3, 242);
            this.LConformacion.Name = "LConformacion";
            this.LConformacion.Size = new System.Drawing.Size(117, 21);
            this.LConformacion.Text = "Conformacion Actual";
            // 
            // CBConformacionActual
            // 
            this.CBConformacionActual.Location = new System.Drawing.Point(126, 241);
            this.CBConformacionActual.Name = "CBConformacionActual";
            this.CBConformacionActual.Size = new System.Drawing.Size(93, 22);
            this.CBConformacionActual.TabIndex = 63;
            // 
            // LFalta
            // 
            this.LFalta.Location = new System.Drawing.Point(3, 266);
            this.LFalta.Name = "LFalta";
            this.LFalta.Size = new System.Drawing.Size(38, 20);
            this.LFalta.Text = "F.Alta";
            // 
            // DTFalta
            // 
            this.DTFalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFalta.Location = new System.Drawing.Point(52, 264);
            this.DTFalta.Name = "DTFalta";
            this.DTFalta.Size = new System.Drawing.Size(90, 22);
            this.DTFalta.TabIndex = 76;
            // 
            // LTalta
            // 
            this.LTalta.Location = new System.Drawing.Point(3, 291);
            this.LTalta.Name = "LTalta";
            this.LTalta.Size = new System.Drawing.Size(43, 21);
            this.LTalta.Text = "T.Alta";
            // 
            // CbTAlta
            // 
            this.CbTAlta.Location = new System.Drawing.Point(52, 290);
            this.CbTAlta.Name = "CbTAlta";
            this.CbTAlta.Size = new System.Drawing.Size(166, 22);
            this.CbTAlta.TabIndex = 78;
            // 
            // LDetalle
            // 
            this.LDetalle.Location = new System.Drawing.Point(3, 318);
            this.LDetalle.Name = "LDetalle";
            this.LDetalle.Size = new System.Drawing.Size(43, 24);
            this.LDetalle.Text = "Detalle";
            // 
            // TbDetalle
            // 
            this.TbDetalle.Location = new System.Drawing.Point(52, 318);
            this.TbDetalle.Name = "TbDetalle";
            this.TbDetalle.Size = new System.Drawing.Size(162, 21);
            this.TbDetalle.TabIndex = 80;
            this.TbDetalle.TextChanged += new System.EventHandler(this.TbDetalle_TextChanged);
            // 
            // InsertarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.CbTAlta);
            this.Controls.Add(this.TbDetalle);
            this.Controls.Add(this.LEstado);
            this.Controls.Add(this.DTFalta);
            this.Controls.Add(this.LTalta);
            this.Controls.Add(this.LDetalle);
            this.Controls.Add(this.CBConformacionActual);
            this.Controls.Add(this.CBTnacimiento);
            this.Controls.Add(this.LFalta);
            this.Controls.Add(this.LConformacion);
            this.Controls.Add(this.LTalla);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.TbDIB);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LTatuaje);
            this.Controls.Add(this.TbTatuaje);
            this.Controls.Add(this.LFnac);
            this.Controls.Add(this.CbSexo);
            this.Controls.Add(this.TbCrotal);
            this.Controls.Add(this.LSexo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LCrotal);
            this.Controls.Add(this.LDIB);
            this.Controls.Add(this.CBRaza);
            this.Controls.Add(this.Lraza);
            this.Controls.Add(this.LEspecie);
            this.Controls.Add(this.CbEspecie);
            this.Name = "InsertarAnimal";
            this.Text = "Insertar Animal";
            this.Closed += new System.EventHandler(this.InsertarAnimal_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InsertarAnimal_Closing);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.CbEspecie, 0);
            this.Controls.SetChildIndex(this.LEspecie, 0);
            this.Controls.SetChildIndex(this.Lraza, 0);
            this.Controls.SetChildIndex(this.CBRaza, 0);
            this.Controls.SetChildIndex(this.LDIB, 0);
            this.Controls.SetChildIndex(this.LCrotal, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.LSexo, 0);
            this.Controls.SetChildIndex(this.TbCrotal, 0);
            this.Controls.SetChildIndex(this.CbSexo, 0);
            this.Controls.SetChildIndex(this.LFnac, 0);
            this.Controls.SetChildIndex(this.TbTatuaje, 0);
            this.Controls.SetChildIndex(this.LTatuaje, 0);
            this.Controls.SetChildIndex(this.TbNombre, 0);
            this.Controls.SetChildIndex(this.CBEstado, 0);
            this.Controls.SetChildIndex(this.TbDIB, 0);
            this.Controls.SetChildIndex(this.LNombre, 0);
            this.Controls.SetChildIndex(this.LTalla, 0);
            this.Controls.SetChildIndex(this.LConformacion, 0);
            this.Controls.SetChildIndex(this.LFalta, 0);
            this.Controls.SetChildIndex(this.CBTnacimiento, 0);
            this.Controls.SetChildIndex(this.CBConformacionActual, 0);
            this.Controls.SetChildIndex(this.LDetalle, 0);
            this.Controls.SetChildIndex(this.LTalta, 0);
            this.Controls.SetChildIndex(this.DTFalta, 0);
            this.Controls.SetChildIndex(this.LEstado, 0);
            this.Controls.SetChildIndex(this.TbDetalle, 0);
            this.Controls.SetChildIndex(this.CbTAlta, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbEspecie;
        private System.Windows.Forms.Label LEspecie;
        private System.Windows.Forms.ComboBox CBRaza;
        private System.Windows.Forms.Label Lraza;
        private System.Windows.Forms.Label LDIB;
        private System.Windows.Forms.TextBox TbDIB;
        private System.Windows.Forms.Label LCrotal;
        private System.Windows.Forms.TextBox TbCrotal;
        private System.Windows.Forms.Label LFnac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.ComboBox CbSexo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LTatuaje;
        private System.Windows.Forms.TextBox TbTatuaje;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label LTalla;
        private System.Windows.Forms.ComboBox CBTnacimiento;
        private System.Windows.Forms.Label LConformacion;
        private System.Windows.Forms.ComboBox CBConformacionActual;
        private System.Windows.Forms.Label LFalta;
        private System.Windows.Forms.DateTimePicker DTFalta;
        private System.Windows.Forms.Label LTalta;
        private System.Windows.Forms.ComboBox CbTAlta;
        private System.Windows.Forms.Label LDetalle;
        private System.Windows.Forms.TextBox TbDetalle;
    }
}
