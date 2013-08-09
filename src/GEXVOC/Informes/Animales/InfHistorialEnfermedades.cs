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
    public partial class InfHistorialEnfermedades : GEXVOC.Core.Controles.ctlInforme
    {
        public InfHistorialEnfermedades()
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
            DateTime? fechaInicio=null;
            DateTime? fechaFin=null;
            int? idPersonal = null;
            int? idEnfermedad = null;
            List<Animal> lstAnimales = (List<Animal>)cmbHembra.DataSource;
            string detallefiltroAnimales = "Animales:";

            if (lstAnimales == null)
            {
                lstAnimales = Configuracion.Explotacion.lstAnimales;
                detallefiltroAnimales += " (Todos)";
            }
            else
            {
                    
                foreach (Animal item in lstAnimales)                                        
                    detallefiltroAnimales += " " + item.Nombre + ",";
                   
                detallefiltroAnimales=detallefiltroAnimales.TrimEnd(char.Parse(","));
            }

            fechaInicio = Generic.ControlADatetimeNullable(txtFechaInicio);
            fechaFin = Generic.ControlADatetimeNullable(txtFechaFin);
            idPersonal = Generic.ControlAIntNullable(cmbPersonal);
            idEnfermedad = Generic.ControlAIntNullable(cmbEnfermedad);
            //FIN - Declaro y establezo los valores a las variables que forman el filtro

            //Creo el objeto del tipo adecuado (hereda de ReportDocument)
            HistorialEnfermedades rpte = new HistorialEnfermedades();

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            HistorialDeEnfermedadesDS datos=DatosInformes.HistorialEnfermedades(fechaInicio,fechaFin,idPersonal,idEnfermedad,lstAnimales);

            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Establezco los valores a los parámetros del informe.
            Generic.EstablecerParametro(rpte, rpte.Parameter_Simplificado, false);
            Generic.EstablecerParametro(rpte, rpte.Parameter_CEA, Configuracion.Explotacion.CEA);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Explotacion, Configuracion.Explotacion.Nombre);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Filtro,
                                   (fechaInicio.HasValue ? "Fecha Inicio: " + fechaInicio.Value.ToShortDateString() +"; ": string.Empty) +
                                   (fechaFin.HasValue ? "Fecha Fin: " + fechaFin.Value.ToShortDateString() + "; " : string.Empty) +
                                   (idEnfermedad.HasValue ? "Enfermedad: " + cmbEnfermedad.Text + "; " : string.Empty) +
                                   (idPersonal.HasValue ? "Personal: " + cmbPersonal.Text + "; " : string.Empty) +
                                    detallefiltroAnimales);                

            return rpte;//Retorno el ReportDocument debidamente formado.
        }

        private void btnBuscarHembra_Click(object sender, EventArgs e)
        {
            SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, (List<Animal>)this.cmbHembra.DataSource);
            FormularioMaestro.LanzarFormulario(frmSelectorAnimales);


            if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
            {
                this.cmbHembra.DataSource = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
                this.cmbHembra.Text = "(" + frmSelectorAnimales.LstAnimalesSeleccionadosRtno.Count + ") Elementos en selección";
            }
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            FormularioMaestro.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, this.cmbPersonal));
        }

        private void btnBuscarEnfermedad_Click(object sender, EventArgs e)
        {
            FormularioMaestro.LanzarFormularioConsulta(new FindEnfermedad(Modo.Consultar, this.cmbEnfermedad));
        }

        private void cmbEnfermedad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEnfermedad_Click(object sender, EventArgs e)
        {

        }
    }
}
