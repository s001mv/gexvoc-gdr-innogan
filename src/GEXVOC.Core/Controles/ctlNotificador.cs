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
   

    public  partial class ctlNotificador : Form
    {

        #region CONSTRUCTORES
        public ctlNotificador()
        {
            InitializeComponent();
            pbxBloquear.Image = imlBoqueo.Images[1];
        }
        public ctlNotificador(string mensaje, DateTime tiempo):this()
        {           
            this.Mensaje = mensaje;
            this.Tiempo = tiempo;
        }
        public ctlNotificador(string mensaje, DateTime tiempo,string link)
            : this()
        {
            this.Mensaje = mensaje;
            this.Tiempo = tiempo;
            this.MensajeLink = link;
        }

        #endregion       

        #region VARIABLES Y PROPIEDADES PRINCIPALES
        int step = -5;
        int limiteSuperior = 0;
        int limeteInferior = 0;

        bool _bloqueado;
        public bool Bloqueado
        {
            get { return _bloqueado; }
            set
            {

                _bloqueado = value;
                if (!value)
                {
                    tmrAnimacion.Enabled = true;
                    pbxBloquear.Image = imlBoqueo.Images[1];//=global::GEXVOC.Properties.Resources.kde2;
                }
                else
                    pbxBloquear.Image = imlBoqueo.Images[0]; //pbxBloquear.Image = global::GEXVOC.Properties.Resources.kde1;

            }
        }

        public string Mensaje
        {
            get { return lblInfo.Text; }
            set
            {
                lblInfo.Text = value;

                this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Size.Width - 20,
                     Screen.PrimaryScreen.Bounds.Bottom);

                limiteSuperior = Top - this.Size.Height - 60;
                limeteInferior = Top + 1;

            }
        }
        public string MensajeLink
        {
            get { return lblLink.Text; }
            set
            {
                lblLink.Text = value;

                this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Size.Width - 20,
                     Screen.PrimaryScreen.Bounds.Bottom);

                limiteSuperior = Top - this.Size.Height - 60;
                limeteInferior = Top + 1;

            }
        }

        private DateTime? _tiempo = null;
        public DateTime? Tiempo
        {
            get { return _tiempo; }
            set { 
                _tiempo = value;
                lblTiempo.Text = value.ToString();
            }
        }
       
        #endregion

        #region MÉTODOS
            public void Mostrar() 
            {
                this.Visible = true;
                this.tmrAnimacion.Enabled = true;
            }
            public void Ocultar() 
            {
                if (step < 0)
                    step *= -1;

                tmrAnimacion.Enabled = true;
                tmrDuracion.Enabled = false;
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void timerAnimacion_Tick(object sender, EventArgs e)
            {
                if (step > 0) //Ocultando
                {
                    if (Bloqueado)
                        tmrAnimacion.Enabled = false;
                    else
                    {
                        if ((this.Top < limeteInferior))
                            this.Top += step;
                        else
                        {
                            this.Close();
                            OnOculto(EventArgs.Empty);
                        }
                    }

                }
                else//creciendo
                {
                    if (this.Top > limiteSuperior)
                        this.Top += step;
                    else
                    {
                        tmrAnimacion.Enabled = false;
                        tmrDuracion.Enabled = true;
                    }            
                }
                this.Refresh();            
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                step *= -1;
                tmrAnimacion.Enabled = true;
                tmrDuracion.Enabled = false;
                
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

            /// <summary>
            /// Cambio el modo de bloqueo en cuanto pulso la imagen superior derecha (aspecto de boton)
            /// Rojo:   Bloqueado       (La animacion se detiene en cuanto el mensaje es mostrado completamente)
            /// Verde:  Desbloqueado    (La animación continúa, si le toca ir ocultando el panel se oculta) 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void pictureBox1_Click(object sender, EventArgs e)
            {
                Bloqueado = !Bloqueado;
            }

            /// <summary>
            /// Cuando hago click en en link, genero el evento LinkClicked
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                OnLinkClicked(EventArgs.Empty);
            }
        #endregion

        #region EVENTOS
        
        
        public event System.EventHandler Oculto;
        /// <summary>
        /// Lanzador del evento.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnOculto(System.EventArgs e)
        {           
            System.EventHandler handler = Oculto;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event System.EventHandler LinkClicked;
        /// <summary>
        /// Lanzador del evento.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnLinkClicked(System.EventArgs e)
        {
            System.EventHandler handler = LinkClicked;
            if (handler != null)
            {
                handler(this, e);
            }
        }



        #endregion

       

    }
}
