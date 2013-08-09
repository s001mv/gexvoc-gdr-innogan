using System;
using System.IO;
using System.Text;

namespace GEXVOC.Core.Logic
{
    [Serializable]
    public class Traza
    {
        /// <summary>
        /// Registra un evento del sistema.
        /// </summary>
        /// <param name="evento">Evento a registrar.</param>
        public static void Registrar(string evento)
        {
            try
            {
                if (Configurador.LogActivo)
                    using (StreamWriter SW = new StreamWriter(Configurador.Log, true))
                    {
                        SW.WriteLine("<evento>[" + DateTime.Now.ToString("ddd dd-HH:mm:ss") + "] " + evento + "</evento>");

                        SW.Close();
                    }
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Registra un error del sistema.
        /// </summary>
        public static Exception Registrar(Exception error)
        {
            try
            {
                if (Configurador.LogActivo && error.GetType() != typeof(CoreException))
                {
                    using (StreamWriter SW = new StreamWriter(Configurador.Log, true))
                    {
                        SW.WriteLine("<error tipo='" + error.GetType().FullName + "'>");
                        SW.WriteLine("[" + DateTime.Now.ToString("ddd dd-HH:mm:ss") + "] " + error.Message);
                        SW.WriteLine("detalle: " + error.StackTrace);
                        SW.WriteLine("</error>");

                        SW.Close();
                    }

                    return new CoreException(error.Message, error);
                }
                else
                    return error;
            }
            catch (Exception) { throw; }
        }
    }
}
