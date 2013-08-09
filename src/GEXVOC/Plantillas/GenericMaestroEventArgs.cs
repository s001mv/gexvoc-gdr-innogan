using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using System.Windows.Forms;

namespace GEXVOC.UI
{
    public class ModoCambiandoEventArgs : EventArgs
    {
        Modo _modoAntes;

        public Modo ModoAntes
        {
            get { return _modoAntes; }
            set { _modoAntes = value; }
        }


        Modo _modoDespues;

        public Modo ModoDespues
        {
            get { return _modoDespues; }
            set { _modoDespues = value; }
        }

       

        Boolean _cancelar = false;

        public Boolean Cancelar
        {
            get { return _cancelar; }
            set { _cancelar = value; }
        }
    }
    public class ModoEventArgs : EventArgs
    {
        Modo _modo;

        public Modo modo
        {
            get { return _modo; }
            set { _modo = value; }
        }

    }
}