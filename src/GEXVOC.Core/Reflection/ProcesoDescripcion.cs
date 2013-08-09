using System;
using System.Diagnostics;
namespace GEXVOC.Core.Reflection
{  
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ProcesoDescripcion : Attribute
    {
        private string _descripcion = string.Empty;
        private string _clasificacion = string.Empty;
     
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="descripcion">Descripción de la acción que realiza el proceso.</param>
        /// <param name="clasificacion">Ofrece una manera de clasificar procesos en grupos.</param>
        public ProcesoDescripcion(string descripcion,string clasificacion)
        {
            _descripcion = descripcion;
            _clasificacion = clasificacion;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="descripcion">Descripción de la acción que realiza el proceso.</param>
        public ProcesoDescripcion(string descripcion)
        {
            _descripcion = descripcion;            
        }

        /// <summary>
        /// Ofrece una descripción de la acción que realiza el proceso.
        /// </summary>
        public string Descripcion
        {
            get { return _descripcion; }
        }
        /// <summary>
        /// Ofrece una manera de clasificar procesos en grupos.
        /// </summary>
        public string Clasificacion
        {
            get { return _clasificacion; }
        }
    }
}
