using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    /// <summary>
    /// Muestra el detalle de todas las versiones reconocidas por el sistema.
    /// </summary>
    public partial class frmDetallesVersiones : Form
    {
        #region CONSTRUCTORES
        public frmDetallesVersiones()
        {
            InitializeComponent();
        }
        #endregion

        #region CARGAS COMUNES

            private void frmDetallesVersiones_Load(object sender, EventArgs e)
            {
                List<ElementoVersion> lstVersiones=Versionado.TodasVersiones();
                StringBuilder cadena = new StringBuilder();
                foreach (ElementoVersion item in lstVersiones)
                {
                    cadena.AppendLine();
                    cadena.AppendLine("================================================================");
                    cadena.AppendLine("\tVersión: " + item.Version.ToString() + "\tFecha: " + (item.Fecha.HasValue?item.Fecha.Value.ToShortDateString():string.Empty));
                    cadena.AppendLine("================================================================");                
                    cadena.AppendLine(item.Descripcion);
                    cadena.AppendLine();
                }
                txtDetalles.Text = cadena.ToString();
            }
        #endregion

    }
}
