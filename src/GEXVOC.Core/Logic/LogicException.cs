using System;
using System.Runtime.Serialization;

namespace GEXVOC.Core.Logic
{
    [Serializable]
    public class LogicException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicException.
        /// </summary>
        public LogicException() : base() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicException con un mensaje.
        /// </summary>
        /// <param name="mensaje">Mensaje que describe el error.</param>
        public LogicException(string mensaje) : base(mensaje) { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicException con datos serializados.
        /// </summary>
        /// <param name="info">Datos serializados del objeto.</param>
        /// <param name="context">Información contextual sobre el origen o el destino.</param>
        protected LogicException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
