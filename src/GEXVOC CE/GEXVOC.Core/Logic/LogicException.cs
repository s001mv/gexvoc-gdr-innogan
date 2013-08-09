using System;

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
        /// Construye una instancia en base a un mensaje de error y a una excepción original.
        /// </summary>
        /// <param name="mensaje">El mensaje de error.</param>
        /// <param name="original">La excepción original.</param>
        public LogicException(string mensaje, Exception original) : base(mensaje, original) { }
    }
}
