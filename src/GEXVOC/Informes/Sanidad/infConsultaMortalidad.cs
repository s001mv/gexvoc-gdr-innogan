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
    public partial class InfConsultaMortalidad : GEXVOC.Core.Controles.ctlInforme
    {
        public InfConsultaMortalidad()
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
            ConsultaMortalidad rpte = new ConsultaMortalidad();            

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            ConsultaMortalidadDS datos = DatosInformes.ConsultaMortalidad(Generic.ControlAIntNullable(cmbEspecie),fechaInicio, fechaFin);

            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Retorno el ReportDocument debidamente formado.
            return rpte;
        }
        public override void GenerarFiltroVisual()
        {
            DateTime? fechaInicio = Generic.ControlADatetimeNullable(txtFechaInicio);
            DateTime? fechaFin = Generic.ControlADatetimeNullable(txtFechaFin);

            AgregarFiltroVisual(fechaInicio.HasValue ? "Fecha Inicio: " + fechaInicio.Value.ToShortDateString() : string.Empty);
            AgregarFiltroVisual(fechaFin.HasValue ? "Fecha Fin: " + fechaFin.Value.ToShortDateString() : string.Empty);
            AgregarFiltroVisual(Generic.ControlAIntNullable(cmbEspecie).HasValue ? "Especie: " + cmbEspecie.Text : string.Empty);

        }

        public override void CargaControles()
        {
            FormularioMaestro.CargarCombo(this.cmbEspecie, Configuracion.Explotacion.lstEspecies, true);
        }
    }
}