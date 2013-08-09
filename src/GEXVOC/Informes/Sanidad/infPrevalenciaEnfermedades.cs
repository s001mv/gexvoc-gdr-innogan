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
    public partial class InfPrevalenciaEnfermedades : GEXVOC.Core.Controles.ctlInforme
    {
        public InfPrevalenciaEnfermedades()
        {
            InitializeComponent();
        }
        public GenericMaestro FormularioMaestro
        {
            get { return ((GenericMaestro)this.FormularioInformes); }
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            //INICIO - Declaro y establezo los valores a las variables que forman el filtro
            DateTime? fechaInicio = Generic.ControlADatetimeNullable(txtFechaInicio);
            DateTime? fechaFin = Generic.ControlADatetimeNullable(txtFechaFin);  
            //FIN - Declaro y establezo los valores a las variables que forman el filtro


            //Creo el objeto del tipo adecuado (hereda de ReportDocument)
            PrevalenciaEnfermedades rpte = new PrevalenciaEnfermedades();

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            PrevalenciaEnfermedadesDS datos = DatosInformes.PrevalenciaEnfermedades(Generic.ControlAIntNullable(cmbEnfermedad),fechaInicio,fechaFin);

            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Establezco los valores a los parámetros del informe.
            Generic.EstablecerParametro(rpte, rpte.Parameter_CEA, Configuracion.Explotacion.CEA);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Explotacion, Configuracion.Explotacion.Nombre);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Filtro,  
                ((fechaInicio.HasValue ? "Fecha Inicio: " + fechaInicio.Value.ToShortDateString() + "; " : string.Empty) +
                (fechaFin.HasValue ? "Fecha Fin: " + fechaFin.Value.ToShortDateString() + "; " : string.Empty) + 
                (Generic.ControlAIntNullable(cmbEnfermedad).HasValue ? "Enfermedad: " + cmbEnfermedad.Text + "; " : string.Empty)).TrimEnd(char.Parse(" ")).TrimEnd(char.Parse(";"))); 

            //Retorno el ReportDocument debidamente formado.
            return rpte;
        }

        private void btnBuscarEnfermedad_Click(object sender, EventArgs e)
        {
             FormularioMaestro.LanzarFormularioConsulta(new FindEnfermedad(Modo.Consultar, this.cmbEnfermedad));
        }
    }
}