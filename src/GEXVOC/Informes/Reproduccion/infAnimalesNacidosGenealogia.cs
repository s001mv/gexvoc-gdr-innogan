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
    public partial class InfAnimalesNacidosGenealogia : GEXVOC.Core.Controles.ctlInforme
    {
        public InfAnimalesNacidosGenealogia()
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
            ////****Escribir aqui las variables necesarias para la llamada a: DatosInformes.AnimalesNacidosGenealogia();
            //FIN - Declaro y establezo los valores a las variables que forman el filtro


			//Creo el objeto del tipo adecuado (hereda de ReportDocument)
            AnimalesNacidosGenealogia rpte = new AnimalesNacidosGenealogia();

            List<Animal> lstAnimales = null;

			//Inicializo el dataset adecuado para el informe con los datos pertinentes.
            AnimalesNacidosGenealogiaDS datos = DatosInformes.AnimalesNacidosGenealogia(Generic.ControlAIntNullable(cmbLote),
                                                                                        Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                                        Generic.ControlADatetimeNullable(txtFechaFin),
                                                                                        Generic.ControlAIntNullable(cmbEspecie), ref lstAnimales);

			//Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            if (chkMostrarGenealogia.Checked)
            {
                //Asigno los datos al subinforme 'GENEALOGÍA'
                try
                {
                    rpte.Subreports["GenealogiaAnimal.rpt"].SetDataSource(DatosInformes.Genealogia(lstAnimales));
                }
                catch (LogicException ex)
                {
                    //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                    rpte.Subreports["GenealogiaAnimal.rpt"].SetDataSource(new GenealogiaAnimalDS());
                    Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Genealogía Animal, Mensaje: " + ex.Message);
                }
            }

            



			//Establezco los valores a los parámetros del informe si es necesario.
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarGenealogia, chkMostrarGenealogia.Checked);


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