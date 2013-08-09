using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public static class BD
    {
        public static void IniciarBDOperaciones()
        { 
            BDController.InicializarBDOperaciones();        
        }
        public static void FinalizarBDOperaciones()
        {
            BDController.FinalizarBDOperaciones();
        }
        public static bool IniciarTransaccion()
        {
            return BDController.IniciarTransaccion();
        }
        public static void FinalizarTransaccion(bool operacionCorrecta)
        {
            BDController.FinalizarTransaccion(operacionCorrecta);
        }
        public static void Recargar()
        {
            BDController.Recargar();
        }
        public static bool BDOperacionesIniciada()
        {
            return BDController.BDOperacionesIniciada();
        }
      
    }
}
