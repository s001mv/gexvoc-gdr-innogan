using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using System.Windows.Forms;

namespace GEXVOC.UI
{
    public class GenericEventArgs : EventArgs
    {
        IClaseBase _ClaseBase;

        public IClaseBase ClaseBase
        {
            get { return _ClaseBase; }
            set { _ClaseBase = value; }
        }
        Boolean _cancelar = false;

        public Boolean Cancelar
        {
            get { return _cancelar; }
            set { _cancelar = value; }
        }

        

    }

    public class PropiedadBindEventArgs : EventArgs
    {
        IClaseBase _ClaseBase;

        public IClaseBase ClaseBase
        {
            get { return _ClaseBase; }
            set { _ClaseBase = value; }
        }
        Boolean _cancelar = false;

        public Boolean Cancelar
        {
            get { return _cancelar; }
            set { _cancelar = value; }
        }

        string _NombrePropiedad = string.Empty;

        public string NombrePropiedad
        {
            get { return _NombrePropiedad; }
            set { _NombrePropiedad = value; }
        }

        Control _Control = null;

        public Control Control
        {
            get { return _Control; }
            set { _Control = value; }
        }



    }
   
}
