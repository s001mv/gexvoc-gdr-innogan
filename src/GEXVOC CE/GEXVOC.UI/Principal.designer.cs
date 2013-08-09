namespace GEXVOC.UI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal = new System.Windows.Forms.MainMenu();
            this.miOpciones = new System.Windows.Forms.MenuItem();
            this.miSalir = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SincronizarB = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.Inseminaciones = new System.Windows.Forms.MenuItem();
            this.Partos = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.PartosMultiples = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.Animales = new System.Windows.Forms.MenuItem();
            this.PesosB = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.LechesB = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(24, 13);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(195, 229);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.Visible = false;
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.MenuItems.Add(this.miOpciones);
            this.MenuPrincipal.MenuItems.Add(this.menuItem1);
            // 
            // miOpciones
            // 
            this.miOpciones.MenuItems.Add(this.miSalir);
            this.miOpciones.Text = "Opciones";
            // 
            // miSalir
            // 
            this.miSalir.Text = "Salir";
            this.miSalir.Click += new System.EventHandler(this.miSalir_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.SincronizarB);
            this.menuItem1.MenuItems.Add(this.menuItem7);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.Text = "Acciones";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Explotaciones";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // SincronizarB
            // 
            this.SincronizarB.Text = "Sincronizar";
            this.SincronizarB.Click += new System.EventHandler(this.Sincronizar_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.MenuItems.Add(this.menuItem8);
            this.menuItem7.MenuItems.Add(this.menuItem9);
            this.menuItem7.Text = "Veterinario";
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "Diagnosticos";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "Tratamientos";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.MenuItems.Add(this.Inseminaciones);
            this.menuItem5.MenuItems.Add(this.Partos);
            this.menuItem5.MenuItems.Add(this.menuItem3);
            this.menuItem5.MenuItems.Add(this.PartosMultiples);
            this.menuItem5.MenuItems.Add(this.menuItem11);
            this.menuItem5.Text = "Reproducion";
            // 
            // Inseminaciones
            // 
            this.Inseminaciones.Text = "Inseminaciones";
            this.Inseminaciones.Click += new System.EventHandler(this.Inseminaciones_Click);
            // 
            // Partos
            // 
            this.Partos.Text = "Partos";
            this.Partos.Click += new System.EventHandler(this.Partos_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Diagnostico de gestación";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // PartosMultiples
            // 
            this.PartosMultiples.Text = "PartosMultiples";
            this.PartosMultiples.Click += new System.EventHandler(this.PartosMultiples_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.MenuItems.Add(this.Animales);
            this.menuItem6.MenuItems.Add(this.PesosB);
            this.menuItem6.MenuItems.Add(this.menuItem4);
            this.menuItem6.MenuItems.Add(this.LechesB);
            this.menuItem6.MenuItems.Add(this.menuItem10);
            this.menuItem6.Text = "Ganado";
            // 
            // Animales
            // 
            this.Animales.Text = "Animales";
            this.Animales.Click += new System.EventHandler(this.Animales_Click);
            // 
            // PesosB
            // 
            this.PesosB.Text = "Pesos";
            this.PesosB.Click += new System.EventHandler(this.Pesos_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Condiciones Corporales";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // LechesB
            // 
            this.LechesB.Text = "Leches";
            this.LechesB.Click += new System.EventHandler(this.LechesB_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Text = "Secados";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 248);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 20);
            // 
            // menuItem11
            // 
            this.menuItem11.Text = "Cubriciones";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.imgLogo);
            this.Menu = this.MenuPrincipal;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Principal_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.MainMenu MenuPrincipal;
        private System.Windows.Forms.MenuItem miOpciones;
        private System.Windows.Forms.MenuItem miSalir;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem Animales;
        private System.Windows.Forms.MenuItem Inseminaciones;
        private System.Windows.Forms.MenuItem Partos;
        private System.Windows.Forms.MenuItem PartosMultiples;
        private System.Windows.Forms.MenuItem PesosB;
        private System.Windows.Forms.MenuItem LechesB;
        private System.Windows.Forms.MenuItem SincronizarB;
        public System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
    }
}