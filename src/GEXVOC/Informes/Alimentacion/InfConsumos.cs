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
using GEXVOC.Core.Informes;
using GEXVOC.Core.Reflection;

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

 
        //public override bool Validar()
        //{
        //    bool rtno = true;
        //    //if (FormularioMaestro != null)
        //    //{
        //    //    if (!Generic.ControlValorado(cmbExplotacion, FormularioMaestro.ErrorProvider))
        //    //        rtno = false;
                
        //    //}            

        //    return rtno;
        //}

        //private void btnBuscarExplotacion_Click_1(object sender, EventArgs e)
        //{
        //    if (FormularioMaestro!=null)
        //        FormularioMaestro.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
        //}

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
            
           // throw new LogicException ("El informe se encuentra en construcción y no puede ser lanzado.");            
            //INICIO - Declaro y establezo los valores a las variables que forman el filtro
            DateTime? FechaInicio = Generic.ControlADatetimeNullable(txtFInicio);
            DateTime? FechaFin = Generic.ControlADatetimeNullable(txtFFin);
            //FIN - Declaro y establezo los valores a las variables que forman el filtro


            //Creo el objeto del tipo adecuado (hereda de ReportDocument)
            Consumos rpte = new Consumos();

            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
            ConsumosDS datos = DatosInformes.Consumos(Generic.ControlAIntNullable(cmbAnimal), FechaInicio, FechaFin);
            //Establezco el origen de datos del informe
            rpte.SetDataSource(datos);

            //Establezco los valores a los parámetros del informe.
            Generic.EstablecerParametro(rpte, rpte.Parameter_CEA, Configuracion.Explotacion.CEA);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Explotacion, Configuracion.Explotacion.Nombre);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Filtro,
                (FechaInicio.HasValue ? "Fecha >= " + FechaInicio.Value.ToShortDateString() + "; " : string.Empty) +
                (FechaFin.HasValue ? "Fecha <= " + FechaFin.Value.ToShortDateString() + "; " : string.Empty) +
                (cmbAnimal.ClaseActiva!=null ? "ANIMAL = " + ((Animal)cmbAnimal.ClaseActiva).Nombre + "; " : string.Empty) +
                (Generic.ControlAIntNullable(cmbRacion).HasValue ? "RACIÓN = " + cmbRacion.Text + "; " : string.Empty));

            //Asigno los datos al subinforme 'Consumos Asignacion'
            try
            {                
                rpte.Subreports["ConsumosAsignacion.rpt"].SetDataSource(DatosInformes.ConsumosAsignacion(Generic.ControlAIntNullable(cmbAnimal), FechaInicio, FechaFin,Generic.ControlAIntNullable(cmbRacion)));              
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["ConsumosAsignacion.rpt"].SetDataSource(new ConsumosAsignacionDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Consumos asignacion, Mensaje: " + ex.Message);
            }


            //Asigno los datos al subinforme 'Consumos Produccion'
            try
            {
                if (chkProduccionLeche.Checked)                
                    rpte.Subreports["ConsumosProduccion.rpt"].SetDataSource(DatosInformes.ConsumosProduccion(Generic.ControlAIntNullable(cmbAnimal), FechaInicio, FechaFin));
                else
                    rpte.Subreports["ConsumosProduccion.rpt"].SetDataSource(new ConsumosProduccionDS());
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["ConsumosProduccion.rpt"].SetDataSource(new ConsumosProduccionDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Consumos Producción, Mensaje: " + ex.Message);
            }


            //Asigno los datos al subinforme 'Indices de Conversión'
            try
            {
                if (chkIC.Checked)                
                    rpte.Subreports["IndiceConversionReducido.rpt"].SetDataSource(DatosInformes.IndicesConversion(null,null, FechaInicio, FechaFin, null, Generic.ControlAIntNullable(cmbAnimal)));
                else
                    rpte.Subreports["IndiceConversionReducido.rpt"].SetDataSource(new IndicesConversionDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["IndiceConversionReducido.rpt"].SetDataSource(new IndicesConversionDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme  Indices de conversión, Mensaje: " + ex.Message);
            }

       

            //Retorno el ReportDocument debidamente formado.
            return rpte;
        }


        #region PROPIEDADES PARA PROCESOS

        [ProcesoDescripcion("Arbol de Informes -> Alimentación -> Consumos y producción - Habilita el control: I.C", "Producción de Carne")]
        public bool _proceso_ProducionCarne
        {
            set
            {
                if (!value)
                {                
                    Generic.DesactivarControl(chkIC);
                }
            }
        }
        [ProcesoDescripcion("Arbol de Informes -> Alimentación -> Consumos y producción - Habilita el control: Producción Leche", "Producción de Leche")]
        public bool _proceso_ProducionLeche
        {
            set
            {
                if (!value)
                {
                    Generic.DesactivarControl(chkProduccionLeche);
                    
                }
            }
        }
    }

        #endregion

}
