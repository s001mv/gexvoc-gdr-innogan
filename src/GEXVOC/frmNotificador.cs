using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GEXVOC
{    
    public partial class frmNotificador : Form
    {
        
        public frmNotificador()
        {
            InitializeComponent();          
        }

        int step = -5;
        int limiteSuperior = 0;
        int limeteInferior=0;

        bool _bloqueado;

        public bool Bloqueado
        {
            get { return _bloqueado; }
            set { 

                _bloqueado = value;
                if (!value)
                {
                    timerAnimacion.Enabled = true;
                    pictureBox1.Image=global::GEXVOC.Properties.Resources.kde2;
                }
                else
                    pictureBox1.Image = global::GEXVOC.Properties.Resources.kde1;
            }
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (step > 0) //Ocultando
            {
                if (Bloqueado)
                    timerAnimacion.Enabled = false;
                else
                {
                    if ((this.Top < limeteInferior))
                        this.Top += step;
                    else
                        this.Close();
                }

            }
            else//creciendo
            {
                if (this.Top > limiteSuperior)
                    this.Top += step;
                else
                {
                    timerAnimacion.Enabled = false;
                    timer1.Enabled = true;
                }            
            }
            this.Refresh();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            step *= -1;
            timerAnimacion.Enabled = true;
            timer1.Enabled = false;
            
        }

        public string Mensaje
        {
            get { return lblInfo.Text; }
            set { lblInfo.Text = value;

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Size.Width - 20,
                 Screen.PrimaryScreen.Bounds.Bottom);

             limiteSuperior = Top - this.Size.Height - 60;
             limeteInferior = Top +1;

            }
        }

        public string Tiempo
        {
            get { return lblTiempo.Text; }
            set
            {
                lblTiempo.Text = value;
            }
        }

        //private void Form1_LocationChanged(object sender, EventArgs e)
        //{
        //    this.Invalidate();
        //}


        public void Mostrar() 
        {
            this.Visible = true;
            this.timerAnimacion.Enabled = true;
        }
        public void Ocultar()         
        {
            if (step < 0)
                step *= -1;

            timerAnimacion.Enabled = true;
            timer1.Enabled = false;
        }
        


        //Doy el efecto de que al pulsar click con el ratón, la pantalla se oculte.
        private void Todos_MouseClick(object sender, MouseEventArgs e)
        {
            Ocultar();
        }
        private void Todos_Click(object sender, EventArgs e)
        {
            Ocultar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bloqueado = !Bloqueado;
        }




        
    }
}
