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
    public partial class InfConsultaMorbilidad : GEXVOC.Core.Controles.ctlInforme
    {
        public InfConsultaMorbilidad()
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
            //FIN - Declaro y establezo los valores a las variables que forman el filtro            


            //Creo el objeto del tipo adecuado (hereda de ReportDocument)
            ConsultaMorbilidad rpte = new ConsultaMorbilidad();

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            ConsultaMorbilidadDS datos = DatosInformes.ConsultaMorbilidad(Generic.ControlAInt(cmbEspecie),
                                                            Generic.ControlADatetimeNullable(txtFechaInicio),
                                                            Generic.ControlADatetimeNullable(txtFechaFin),
                                                            Generic.ControlAIntNullable(cmEstado));

            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Establezco los valores a los parámetros del informe si es necesario.
            //Generic.EstablecerParametro(rpte, rpte.Parameter_NOMBRE, VALOR);            
   
            return rpte;
        }
        public override void GenerarFiltroVisual()
        {
            DateTime? fechaInicio = Generic.ControlADatetimeNullable(txtFechaInicio);
            DateTime? fechaFin = Generic.ControlADatetimeNullable(txtFechaFin); 
            AgregarFiltroVisual(fechaInicio.HasValue ? "Fecha Inicio: " + fechaInicio.Value.ToShortDateString() :string.Empty);
            AgregarFiltroVisual(fechaFin.HasValue ? "Fecha Fin: " + fechaFin.Value.ToShortDateString(): string.Empty);
            AgregarFiltroVisual(Generic.ControlAIntNullable(cmEstado).HasValue ? "Estado: " + cmEstado.Text : string.Empty);
            AgregarFiltroVisual("Especie: " + cmbEspecie.Text);
        }
      
        public override void CargaControles()
        {
            FormularioMaestro.CargarCombo(this.cmbEspecie, Configuracion.Explotacion.lstEspecies, true);
            FormularioMaestro.CargarCombo(cmEstado, Estado.Buscar());
        }
        public override bool Validar()
        {
            Boolean rtno = true;
            if (FormularioMaestro != null)
            {           
                if (!Generic.ControlValorado(this.cmbEspecie, FormularioMaestro.ErrorProvider)) rtno = false;
            }



            return rtno;
        }
    }
}