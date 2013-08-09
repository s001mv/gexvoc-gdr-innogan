using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GEXVOC.UI
{
    public partial class ctlInforme : UserControl
    {
        public ctlInforme()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(712, 95);
        }
        protected virtual void validacion(){}
        protected virtual void CargaControles(){}
        protected virtual void ValoresPredeterminados(){}
        protected virtual void Generar(){}

    }
}
