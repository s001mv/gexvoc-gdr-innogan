using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public class GenericInfArbolEventArgs:EventArgs
    {
        string _NombreCompleto = string.Empty;

        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; }
        }
        TreeNode _NodoSeleccionado = null;

        public TreeNode NodoSeleccionado
        {
            get { return _NodoSeleccionado; }
            set { _NodoSeleccionado = value; }
        }
        bool _Cancelar = false;

        public bool Cancelar
        {
            get { return _Cancelar; }
            set { _Cancelar = value; }
        }


        ctlInforme _InformeActivo = null;

        public ctlInforme InformeActivo
        {
            get { return _InformeActivo; }
            set { _InformeActivo = value; }
        }
         

    }
}
