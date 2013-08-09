using System;
using System.Runtime.Serialization;

namespace GEXVOC.Core.Logic
{
    [Serializable]
    public class NotificableException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicException.
        /// </summary>
        public NotificableException() : base() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicException con un mensaje.
        /// </summary>
        /// <param name="mensaje">Mensaje que describe el error.</param>
        public NotificableException(string mensaje) : base(mensaje) { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicException con datos serializados.
        /// </summary>
        /// <param name="info">Datos serializados del objeto.</param>
        /// <param name="context">Información contextual sobre el origen o el destino.</param>
        protected NotificableException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}