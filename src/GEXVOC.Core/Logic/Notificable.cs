using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEXVOC.Core.Logic
{
    public class Notificable :INotificable
    {
        /// <summary>
        /// Mensaje que se ha de notificar
        /// </summary>
        private ResultadoOperacion _MensajeNotificar; 
        /// <summary>
        /// Propiedad que lanza el evento Notificar cuando es asignada.        
        /// </summary>
        public ResultadoOperacion MensajeNotificar
        {
          get { return _MensajeNotificar; }
          set 
          { 
              if (value!=null)                
              {            	
                  //Inicializo los argumentos del evento Notificar
                  NotificableEventArgs eventArgs = new NotificableEventArgs();
                  eventArgs.Mensaje = value;
                  //Lanzo el evento Notificar
                  OnNotificar(eventArgs);	 
                
              }
              _MensajeNotificar = value; 
          }
        }

        /// <summary>
        /// Mensaje acumulado de notificaciones.
        /// </summary>
        public string MensajeNotificarVarios {get;set;}
        /// <summary>
        /// Capturador del evento de notificación, se utiliza cuando modificamos una clase notificable (B)
        /// desde otra clase (A), en este caso la clase A, debe tambien heredar de Notificable y asigna las notificaciones de la B
        /// a este método, de manera que recoge todas las notificaciones para por ultimo hacer ella misma (la clase A) la notificación final.
        /// OJO: en este proceso debemos asegurarnos de borrar la propiedad MensajeNotificarVarios, pues esta misma es el acumulador de mensajes.
        /// Podemos ver un ejemplo de este proceso en TratHigiene y TratProfilaxis en la lógica del borrado, donde borran clases hijas que son notificables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NotificarVarios(object sender, NotificableEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Mensaje.Mensaje))
                MensajeNotificarVarios += e.Mensaje.Mensaje + "\r";
        }

        #region EVENTOS
            public event EventHandler<NotificableEventArgs> Notificar;
            public virtual void OnNotificar(NotificableEventArgs e)
            {
                EventHandler<NotificableEventArgs> handler = Notificar;
                if (handler != null)
                {
                    handler(this, e);
                }
            }     
        #endregion
    }
}
