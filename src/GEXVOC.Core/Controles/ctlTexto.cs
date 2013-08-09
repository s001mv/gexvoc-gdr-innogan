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
    public partial class ctlTexto : MaskedTextBox
    {
        public ctlTexto()
        {
            InitializeComponent();
        }

        System.Type _tipoDatos;        
        public System.Type TipoDatos
        {
          get { return _tipoDatos; }
          set {
              
              _tipoDatos = value;
           
          }
        }

        
    }
}
