using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using System.Windows.Forms;
using System.Configuration;


namespace GEXVOC.UI.Clases
{
    /// <summary>
    /// Clase stática que se encarga de comprobar si la version de la base de datos se corresponde con la versión de la apliación en ejecución. 
    /// </summary>
    static public class Versionado
    {
        static string RutaScrips = Application.StartupPath + "\\Scripts";
        
        /// <summary>
        /// Versión actual de la Base de Datos
        /// </summary>
        public static System.Version VersionBaseDatos { 
            get 
            {
                System.Version rtno = new Version("1.0.0.0");
                try
                {
                    if (Configuracion.ObtenerValor(Claves.vBD)!=string.Empty)                    
                        rtno=new System.Version(Configuracion.ObtenerValor(Claves.vBD));
                }
                catch (Exception){}

                return rtno;        
            } 
        }                

        /// <summary>
        /// Versión Actual de la Aplicación en ejecución.
        /// </summary>
        public static System.Version VersionAplicacion { get { return new System.Version(Application.ProductVersion); } }  


        /// <summary>
        /// Nos indica si las versiones de base de datos y aplicación son iguales
        /// Retrorna true si son iguales, false en cualquier otro caso.
        /// 
        /// Existe un valor en el archivo de configuración que nos hace retornar true siempre a esta función, este valor se
        /// corresponde con la clave 'OmitirVersionado' que por defecto está a false, y no se debería cambiar nunca, salvo para solucionar 
        /// errores en aplicaciones producción.
        /// </summary>
        /// <returns></returns>
        public static bool VersionCorrecta()
        {

            bool rdo = true;
            bool OmitirVersionado = false; 
            try
            {
                if (ConfigurationManager.AppSettings.Get("OmitirVersionado")!=null)                
                    OmitirVersionado = bool.Parse(ConfigurationManager.AppSettings.Get("OmitirVersionado"));          
            }
            catch (Exception){}

            ///Si la aplicación se encuentra en modo depuración omitimos siempre el versionado
            if (System.Diagnostics.Debugger.IsAttached)
                OmitirVersionado=true;

            if (!OmitirVersionado)
            {
               
                // string vBD = Configuracion.ObtenerValor(Claves.vBD);

                if (VersionBaseDatos != VersionAplicacion)
                    rdo = false;            
                
            }
            return rdo;
        }

        /// <summary>
        /// Nos retorna una lista de objetos del tipo ElementoVersion que son necesarios para 
        /// actualizar la version de la base de datos.
        /// Dichos elementos tienen una propiedad llamada Script.
        /// </summary>
        /// <returns></returns>
        public static List<ElementoVersion> ScriptsActualizar()
        {
            //List<ElementoVersion> rto = new List<ElementoVersion>();
            List<ElementoVersion> lstScripts = new List<ElementoVersion>();
            try
            {
                System.IO.DirectoryInfo DirectorioScripts = null;
                DirectorioScripts = new System.IO.DirectoryInfo(RutaScrips);
                if (DirectorioScripts.Exists)
                {
                    foreach (System.IO.FileInfo script in DirectorioScripts.GetFiles("*.xml"))
                    {
                        try
                        {
                            System.Version versionscript = new System.Version(script.Name.Replace(script.Extension, string.Empty));
                            if (versionscript > Versionado.VersionBaseDatos && versionscript <= Versionado.VersionAplicacion)
                            {
                                lstScripts.Add(new ElementoVersion(script.FullName));
                            }
                        }
                        catch (Exception causa)
                        {
                            Traza.RegistrarError("No se ha prodido procesar el archivo: " + script.FullName + " Causa: " + causa.Message);                            
                        }                    
                    }
                }
            }
            catch (Exception ex)
            {
                Traza.RegistrarError("No se ha podido acceder a la ruta: " + RutaScrips + " Causa: " + ex.Message);
            }

            //Tengo la lista de los scripts pero desordenada, la retornaré ordenada.         

            return Versionado.OrdenarListaSegunVersion(lstScripts);
        }
    

        /// <summary>
        /// Carga en una lista ordenada todas las versiones reconocidas por el sistema.
        /// Es independiente de si las versiones se encuentran o no instaladas.
        /// </summary>
        /// <returns></returns>
        public static List<ElementoVersion> TodasVersiones()
        {
          
            List<ElementoVersion> lstScripts = new List<ElementoVersion>();
            try
            {
                System.IO.DirectoryInfo DirectorioScripts = null;
                DirectorioScripts = new System.IO.DirectoryInfo(RutaScrips);
                if (DirectorioScripts.Exists)
                {
                    foreach (System.IO.FileInfo script in DirectorioScripts.GetFiles("*.xml"))
                    {
                        try
                        {
                            //La siguiente linea puede dar una excepción, en este caso el nombre del archivo no se correspondería 
                            //con la nomenclatura de la versión, por tanto no se procesa dicho archivo.
                            System.Version versionscript = new System.Version(script.Name.Replace(script.Extension, string.Empty));
                            lstScripts.Add(new ElementoVersion(script.FullName));                           
                        }
                        catch (Exception causa)
                        {
                            Traza.RegistrarError("No se ha prodido procesar el archivo: " + script.FullName + " Causa: " + causa.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Traza.RegistrarError("No se ha podido acceder a la ruta: " + RutaScrips + " Causa: " + ex.Message);
            }

            //Tengo la lista de los scripts pero desordenada, la retornaré ordenada.            

            return Versionado.OrdenarListaSegunVersion(lstScripts);
        }

        /// <summary>
        /// Actualiza la versión de la base de datos, con la versión de la aplicación en ejecución.
        /// Puede provocar una exceptción del tipo 'LogicException' si la versión de la Aplicación es anterior a la versión de la base de datos.
        /// </summary>
        public static void ActualizarVersionBD() 
        {
            if (Versionado.VersionAplicacion < Versionado.VersionBaseDatos)
                throw new LogicException("Operación no Admitida: Los datos deben ser actualizados a versiones posteriones, nunca a anteriores");

            //Si todo se ha ejecutado correctamente, actualizo la versión de la bd a la versión de la aplicación
            Configuracion.GuardarValor(Claves.vBD, Versionado.VersionAplicacion.ToString());            
        }


        /// <summary>
        /// Ordena una lista de ElementoVersion según su campo Version, en orden Ascendente.
        /// </summary>
        /// <param name="lstOrdenar"></param>
        /// <returns></returns>
        static List<ElementoVersion> OrdenarListaSegunVersion(List<ElementoVersion> lstOrdenar)
        {
            //Lista definitiva a retornar
            List<ElementoVersion> rto = new List<ElementoVersion>();


            //Creo una lista temporal solo con las propiedades de las Versiones
            List<Version> lstTemporal = new List<Version>();
            //Cargo la lista temporal con las propiedades Version de la lista que se me envia como parámetro
            foreach (ElementoVersion item in lstOrdenar)
                lstTemporal.Add(item.Version);

            //Ordeno la lista de Temporal Versiones
            lstTemporal.Sort();

            //Recorro en orden la lista de versiones y añado cada elemento en la lista definitiva
            foreach (Version item in lstTemporal)
                rto.Add(lstOrdenar.Find(E => E.Version == item));



            return rto;
        }
    }
}
