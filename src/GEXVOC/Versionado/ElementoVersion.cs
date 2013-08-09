using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace GEXVOC.UI.Clases
{
    /// <summary>
    /// Elemento cuyas características representan una versión de la aplicación.
    /// Normalmente se obtiene a partir de un xml con siminar estructura (como se demuestra en uno de sus constructores).
    /// </summary>
    public class ElementoVersion
    {
        /// <summary>
        /// Constructor Predeterminado
        /// </summary>
        public ElementoVersion() { }
        
        /// <summary>
        /// Constructor que crea el elemento e inicia el contenido de sus propiedades a través de un documento
        /// en formato xml pasado como parámetro en xmlPath;
        /// </summary>
        /// <param name="xmlPath"></param>
        public ElementoVersion (string xmlPath)
        {
            System.IO.FileInfo archivoxml = null;
            try
            {
                archivoxml = new System.IO.FileInfo(xmlPath);
            }
            catch (Exception) { }
          

            if (archivoxml != null && archivoxml.Exists)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(xmlPath);
              
                try
                {
                    this.Version = new Version(xDoc.DocumentElement.GetAttribute("Version"));
                }
                catch (Exception)
                { this.Version = new Version("1.0.0.0"); }

                try
                {
                    this.Fecha = DateTime.Parse(xDoc.DocumentElement.GetAttribute("Fecha"));
                }
                catch (Exception)
                { this.Fecha = null; }

                this.Descripcion = xDoc.DocumentElement.GetAttribute("Descripcion");
                this.Script = xDoc.DocumentElement.GetAttribute("Script");
            }
            else
                throw new Exception("No es posible crear un Elemento Version a partir de la ruta: " + xmlPath);
        }

       
        /// <summary>
        /// La versión a la que se refiere, en formato 1.0.0.0
        /// </summary>
        public System.Version Version { get; set; }
        /// <summary>
        /// Script SQL completo que transformará la versión anterior en la actual (definida en la propiedad Version)
        /// </summary>
        public string Script { get; set; }
        /// <summary>
        /// Fecha en la que se ha generado dicha versión.
        /// </summary>
        public DateTime? Fecha { get; set; }

        /// <summary>
        /// Detalles de la versión, aquí se reflejarán los cambios que forman la versión actual.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Sobreescritura del método ToString para que devuelva la version en modo string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Version.ToString();
        }

        
        
    }
}
