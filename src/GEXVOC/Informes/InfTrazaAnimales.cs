using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.UI;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Informes;

namespace GEXVOC.Informes
{
    public partial class InfTrazaAnimales : GEXVOC.Core.Controles.ctlInforme
    {
        public InfTrazaAnimales()
        {
            InitializeComponent();
        }

        public GenericMaestro FormularioMaestro
        { 
            get { return ((GenericMaestro)this.FormularioInformes); } 
        }

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, (List<Animal>)this.cmbAnimal.DataSource, Convert.ToChar("H"));

            if (FormularioMaestro != null)
                FormularioMaestro.LanzarFormulario(frmSelectorAnimales);

            if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
            {
                this.cmbAnimal.DataSource = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
                this.cmbAnimal.Text = "(" + frmSelectorAnimales.LstAnimalesSeleccionadosRtno.Count + ") Elementos en selección";
            }
        }

        public override bool Validar()
        {
            Boolean rtno = true;

            if (FormularioMaestro != null)
            {
                if (!Generic.ControlValorado(this.cmbAnimal, FormularioMaestro.ErrorProvider)) rtno = false;
            }

            return rtno;
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            Generic.AvisoAdvertencia("El informe se encuentra en construcción y no puede ser lanzado.");
            
            return null;
        }
    }
}
