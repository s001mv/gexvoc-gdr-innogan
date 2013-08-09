using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Data;

namespace GEXVOC.UI
{
    public partial class Cubriciones : GEXVOC.UI.Principal
    {
        public Cubriciones()
        {
            InitializeComponent();
        }
        public void Refrescar_Pantalla()
        {
            dgCubriciones.DataSource = CubricionTA.ObtenerTodasCubriciones();
            dgCubriciones.Refresh();
        }
        private void PbAnadir_Click(object sender, EventArgs e)
        {
            InsertarCubricion mForm = (InsertarCubricion)FormFactory.Obtener(Formulario.InsertarCubricion);
            mForm.refrescar_pantalla();
            Program.OcultarCursorEspera();
            mForm.Show();
        }
    }
}

