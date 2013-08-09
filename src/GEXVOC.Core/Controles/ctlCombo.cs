using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GEXVOC.Core.Controles
{
    public partial class ctlCombo : ComboBox
    {
        public ctlCombo()
        {
            InitializeComponent();
        }
        CharacterCasing _CharacterCasing= CharacterCasing.Normal;

        public CharacterCasing CharacterCasing
        {
            get { return _CharacterCasing; }
            set { _CharacterCasing = value; }
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
           
            //Si tengo activada la propiedad CharacterCasing actuo consecuentemente
            switch (CharacterCasing)
            {
                case CharacterCasing.Lower:
                    e.KeyChar = char.ToLower(e.KeyChar);
                    break;
                case CharacterCasing.Upper:
                    e.KeyChar = char.ToUpper(e.KeyChar);
                    break;
            }
            base.OnKeyPress(e);
        }

        //private void ctlCombo_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //base.OnKeyDown(e);
        //    if (e.Control && e.KeyCode==Keys.A)
        //    {
        //        this.FindForm().Validate(true);
        //        //RaiseCrearNuevo(new ctlComboCrearNuevoEventArgs());    
        //    }
        //}
        protected override void OnKeyDown(KeyEventArgs e)
        {
            
            
            if (e.Control && e.KeyCode == Keys.A)
            {   
                RaiseCrearNuevo(new ctlComboCrearNuevoEventArgs());                
                e.Handled = true;
            }

            base.OnKeyDown(e);
        }


        public void CargarCombo() 
        {
            //lanzo el evento de Cargar           
            OnCargarContenido(System.EventArgs.Empty);
        }



        #region EVENTOS PERSONALIZADOS

        public event System.EventHandler CargarContenido;
       
        /// <summary>
        /// Lanzador del evento.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnCargarContenido(System.EventArgs e)
        {
            System.EventHandler handler = CargarContenido;        
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<ctlComboCrearNuevoEventArgs> CrearNuevo;
        /// <summary>
        /// Lanzador del evento.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnCrearNuevo(ctlComboCrearNuevoEventArgs e)
        {
            //Asigno la descripcicion de texto a crear siempre se se cumplan 2 condiciones, que el control
            //contenga texto, y que dicho texto no se corresponda con un elemento existente.
            if (idClaseActiva == null && e != null && this.Text != string.Empty)
                e.TextoCrear = this.Text;

            EventHandler<ctlComboCrearNuevoEventArgs> handler = CrearNuevo;
            if (handler != null)
            {
                handler(this, e);
            }

        }

        void RaiseCrearNuevo(ctlComboCrearNuevoEventArgs eventArgs)
        {
            DialogResult? Pregunta=null;
            if (eventArgs.MostrarTextoConfirmacion)
               Pregunta=MessageBox.Show("El elemento proporcionado no existe, ¿Desea Crearlo?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            //Lanzo el evento en caso de que respondan sí a la pregunta, o en caso de que la pregunta no se haga (Pulsado Ctl+A Abir directamente);
            if (Pregunta==null || Pregunta.Value== DialogResult.OK)            
                OnCrearNuevo(eventArgs);        
        }

        #endregion

        private void ctlCombo_Leave(object sender, EventArgs e)
        {
            //Lo primero es hacer que el formulario valide el último control que será el propio combo
            //Esto es necesario porque si no se hace y el combo se encuentra en suggestAppend, estando tecleando un elemento exitente 
            //y pulsando por ejemplo tab para ir a otro control, como todavía no esta validado el selecteditem es null, a pesar de 
            //estar seleccionando un elemento válido (Pues no se ha terminado la selección)
            //La siguiente llamada soluciona esto, validandolo antes de hacer ninguna otra comprobación.
   



            if (idClaseActiva == null && this.Text != string.Empty && !this.FindForm().Disposing)
            {                
                //Hemos salido del control, tenemos texto en él, y el texto no se correspode con ningun elemento de la lista
                //En este caso tendríamos la posibilidad de lanzar el formulario de edición asociado al combo para crear dicho elemento.
                //if (MessageBox.Show("El elemento proporcionado no existe, ¿Desea Crearlo?","Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)                
                RaiseCrearNuevo(new ctlComboCrearNuevoEventArgs() { MostrarTextoConfirmacion=true});                    
            }

           
        }

        int? idClaseActiva 
        {            
            get 
            {
                 this.FindForm().Validate(true);
                 return (int?)this.SelectedValue;                
            }        
        }
        
       
    }
}
