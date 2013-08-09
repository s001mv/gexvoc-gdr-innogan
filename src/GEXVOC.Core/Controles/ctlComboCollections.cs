using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Controles
{
  
    public class ctlComboCrearNuevoEventArgs : EventArgs
    {
        public string TextoCrear { get; set; }
        public bool MostrarTextoConfirmacion { get; set; }   

    }
}