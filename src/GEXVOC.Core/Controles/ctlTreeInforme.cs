using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GEXVOC.Core.Controles
{
    public partial class ctlTreeInforme : TreeNode
    {
        public ctlTreeInforme()
        {
            InitializeComponent();
        }
        string _TituloInforme = string.Empty;

        public string TituloInforme
        {
            get { return _TituloInforme; }
            set { _TituloInforme = value; }
        }
        string _DescripcionInforme = string.Empty;

        public string DescripcionInforme
        {
            get { return _DescripcionInforme; }
            set { _DescripcionInforme = value; }
        }



    }
}
