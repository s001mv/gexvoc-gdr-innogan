using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.UI;
using GEXVOC.Core.Logic;

namespace GEXVOC.Informes
{
    
    public partial class InfConsumos : GEXVOC.Core.Controles.ctlInforme
    {
        public InfConsumos()
        {
            InitializeComponent();          
        }

        public GenericMaestro FormularioMaestro 
        {get{return ((GenericMaestro)this.FormularioInformes);}}

 
        public override bool Validar()
        {
            bool rtno = true;
            if (FormularioMaestro != null)
            {
                if (!Generic.ControlValorado(cmbExplotacion, FormularioMaestro.ErrorProvider))
                    rtno = false;
                
            }            

            return rtno;
        }

        private void btnBuscarExplotacion_Click_1(object sender, EventArgs e)
        {
            if (FormularioMaestro!=null)
                FormularioMaestro.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
        }

        private void btnBuscarAnimal_Click_1(object sender, EventArgs e)
        {
            if (FormularioMaestro != null)
                FormularioMaestro.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal) { ValorSexoFijo=Convert.ToChar("H")});
        }

        public override void CargaControles()
        {
            if (FormularioMaestro != null)
                FormularioMaestro.CargarCombo(cmbRacion, Racion.Buscar());

            base.CargaControles();
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            Generic.AvisoAdvertencia("El informe se encuentra en construcción y no puede ser lanzado.");
            return null;
        }
    }
}
