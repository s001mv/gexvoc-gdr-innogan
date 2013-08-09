using System;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace GEXVOC.Core.Logic
{
    /// <summary>
    /// Realiza el registro de errores.
    /// Categoría Error: Logs\error.log
    /// Categoría Informacion: Logs\info.log (Habilitado sólo en desarrollo)
    /// </summary>
    public class Traza
    {
        /// <summary>
        /// Registra un error del sistema.
        /// </summary>
        /// <param name="error">Mensaje a registrar.</param>
        public static void RegistrarError(string error)
        {
            Logger.Write(error, "Error");
        }

        /// <summary>
        /// Registra un error del sistema.
        /// </summary>
        /// <param name="error">Excepción a registrar.</param>
        public static void RegistrarError(Exception error)
        {
            Logger.Write(error.Message + error.StackTrace, "Error");
        }

        /// <summary>
        /// Registra información para facilitar el desarrollo.
        /// </summary>
        /// <param name="mensaje">Mensaje a registrar.</param>
        public static void RegistrarInfo(string mensaje)
        {
            Logger.Write(mensaje, "Informacion");
        }


    }
}
