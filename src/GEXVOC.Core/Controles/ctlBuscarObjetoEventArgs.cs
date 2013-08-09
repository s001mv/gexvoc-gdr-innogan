using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Controles
{
    public class ctlBuscarObjetoEventArgs : EventArgs
    {
        IClaseBase _ClaseActiva;

        public IClaseBase ClaseActiva
        {
            get { return _ClaseActiva; }
            set { _ClaseActiva = value; }
        }

        //Boolean _cancelar = false;

        //public Boolean Cancelar
        //{
        //    get { return _cancelar; }
        //    set { _cancelar = value; }
        //}



    }
   


}
