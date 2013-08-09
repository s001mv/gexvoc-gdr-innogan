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
    public partial class InfAnimalesDestetados : GEXVOC.Core.Controles.ctlInforme
    {
        public InfAnimalesDestetados()
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
            ////****Escribir aqui las variables necesarias para la llamada a: DatosInformes.AnimalesDestetados();
            //FIN - Declaro y establezo los valores a las variables que forman el filtro


            //Creo el objeto del tipo adecuado (hereda de ReportDocument)
            AnimalesDestetados rpte = new AnimalesDestetados();

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            AnimalesDestetadosDS datos = DatosInformes.AnimalesDestetados(Generic.ControlAIntNullable(cmbLote),
                                                                          Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                          Generic.ControlADatetimeNullable(txtFechaFin),
                                                                          Generic.ControlAIntNullable(cmbEspecie));

            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Establezco los valores a los parámetros del informe si es necesario.
            //Generic.EstablecerParametro(rpte, rpte.Parameter_NOMBRE, VALOR);

            //Retorno el ReportDocument debidamente formado.
            return rpte;
        }
        public override void GenerarFiltroVisual()
        {
            DateTime? fechaInicio = Generic.ControlADatetimeNullable(txtFechaInicio);
            DateTime? fechaFin = Generic.ControlADatetimeNullable(txtFechaFin);
            AgregarFiltroVisual(fechaInicio.HasValue ? "Fecha Inicio: " + fechaInicio.Value.ToShortDateString() : string.Empty);
            AgregarFiltroVisual(fechaFin.HasValue ? "Fecha Fin: " + fechaFin.Value.ToShortDateString() : string.Empty);
            AgregarFiltroVisual(cmbLote.ClaseActiva != null ? "Lote: " + ((LoteAnimal)cmbLote.ClaseActiva).Descripcion : string.Empty);
            AgregarFiltroVisual(Generic.ControlAIntNullable(cmbEspecie).HasValue ? "Especie: " + cmbEspecie.Text : string.Empty);
        }
        private void btnbuscarLote_Click(object sender, EventArgs e)
        {
            FormularioMaestro.LanzarFormularioConsulta(new FindLoteAnimal(Modo.Consultar, this.cmbLote));
        }

        public override void CargaControles()
        {
            FormularioMaestro.CargarCombo(this.cmbEspecie, Configuracion.Explotacion.lstEspecies, true);
        }
    }

}