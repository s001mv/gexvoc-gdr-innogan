using System;
using System.Runtime.Serialization;

namespace GEXVOC.Core.Logic
{
    [Serializable]
    public class LogicStockException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicStockException.
        /// </summary>
        public LogicStockException() : base() { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicStockException con un mensaje.
        /// </summary>
        /// <param name="mensaje">Mensaje que describe el error.</param>
        public LogicStockException(string mensaje) : base(mensaje) { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase LogicStockException con datos serializados.
        /// </summary>
        /// <param name="info">Datos serializados del objeto.</param>
        /// <param name="context">Información contextual sobre el origen o el destino.</param>
        protected LogicStockException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
