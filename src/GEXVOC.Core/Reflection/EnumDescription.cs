
using System;
using System.Diagnostics;
namespace GEXVOC.Core.Reflection
{
    /// <summary>
    /// Atributo que se puede especificar a cada uno de los valores de una enumeración
    /// Esto nos vale por ejemplo para personalizar las descripciones de cada uno de los valores.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumDescription : Attribute
    {
        private string _descripcion = string.Empty;

        /// <summary>
        /// Establece el detalle (descripcion) para el atributo
        /// este detalle es utilizado para mostrar al usuario final valores claramente reconocibles.
        /// </summary>
        /// <param name="descripcion">cadena de detalle</param>
        public EnumDescription(string descripcion)
        {
            _descripcion = descripcion;
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }
    }
}
