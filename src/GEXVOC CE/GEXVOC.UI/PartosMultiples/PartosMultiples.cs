using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GEXVOC.UI
{
    public partial class PartosMultiples : GEXVOC.UI.Principal
    {
        public PartosMultiples()
        {
            InitializeComponent();
        }

        private void PbAnadir_Click(object sender, EventArgs e)
        {
            InsertarPartosMultiples mForm = (InsertarPartosMultiples)FormFactory.Obtener(Formulario.InsertarPartosMultiples);
            mForm.refresca_Pantala();
            mForm.Show();
        }
    }
}

