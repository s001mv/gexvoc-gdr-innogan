using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Informes;
using GEXVOC.UI;
using GEXVOC.UI.Clases;

namespace GEXVOC.Informes
{
    public partial class InfAnimalesImproductivos : GEXVOC.Core.Controles.ctlInforme
    {
        public InfAnimalesImproductivos()
        {
            InitializeComponent();
        }

        public GenericMaestro FormularioMaestro
        {
            get { return ((GenericMaestro)this.FormularioInformes); }
        }

        public override void CargaControles()
        {
            if (FormularioMaestro != null)
            {
                FormularioMaestro.CargarCombo(this.cmbEspecie, Especie.Buscar());
            }
             

            base.CargaControles();

           
        }


        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            DateTime fechaInforme=Generic.ControlADatetimeNullable(txtFecha)??DateTime.Today;          
            
            AnimalesImproductivos rpte = new AnimalesImproductivos();
            AnimalesImproductivosDS datos = DatosInformes.AnimalesImproductivos(Generic.ControlAIntNullable(cmbEspecie),fechaInforme);           

            rpte.SetDataSource(datos);
            rpte.SetParameterValue("CEA", Configuracion.Explotacion.CEA);
            rpte.SetParameterValue("Explotacion", Configuracion.Explotacion.Nombre);          
            rpte.SetParameterValue("Filtro", "Fecha: " + fechaInforme.ToShortDateString()
                + " ; Especie: " + (Generic.ControlAIntNullable(cmbEspecie).HasValue ? cmbEspecie.Text : "(Todas)"));

            return rpte;
        }
    }
}
