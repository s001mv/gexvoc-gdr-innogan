using System;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace GEXVOC.Core.Logic
{
    public class Logueador
    {
        public static void RegistrarError(string error)
        {
            Logger.Write(error, "Error");
        }
    }
}
