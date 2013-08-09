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
using GEXVOC.Core.Reflection;



namespace GEXVOC.Informes
{
    public partial class InfFichaAnimal : GEXVOC.Core.Controles.ctlInforme
    {
        public InfFichaAnimal()
        {
            InitializeComponent();
        }

        
        public GenericMaestro FormularioMaestro
        { get { return ((GenericMaestro)this.FormularioInformes); } }

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

            FichaAnimal rpte = new FichaAnimal();
          

            Animal animal = (Animal)cmbAnimal.ClaseActiva;
            DateTime? fechaInicio=Generic.ControlADatetimeNullable(txtFechaInicio);
            DateTime? fechaFin = Generic.ControlADatetimeNullable(txtFechaFin);


            FichaAnimalDS datos = DatosInformes.FichaAnimal(animal, fechaInicio, fechaFin);           
            
            //Asigno los datos al informe principal
            rpte.SetDataSource(datos);
           

            //Asigno los datos al subinforme 'Genealogía Animal'
            try
            {
                if (chkGenealogia.Checked)                    
                    rpte.Subreports["GenealogiaAnimal.rpt"].SetDataSource(DatosInformes.Genealogia(new List<Animal>() { animal }));
                else
                    rpte.Subreports["GenealogiaAnimal.rpt"].SetDataSource(new GenealogiaAnimalDS());
                
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["GenealogiaAnimal.rpt"].SetDataSource(new GenealogiaAnimalDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Genealogía Animal, Mensaje: " + ex.Message);
            }


            //Asigno los datos al subinforme 'Celos'
            try
            {
                if (chkCelos.Checked)                 
                    rpte.Subreports["Celos.rpt"].SetDataSource(DatosInformes.Celos(animal.Id,fechaInicio,fechaFin));
                else
                    rpte.Subreports["Celos.rpt"].SetDataSource(new CelosDS());
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["Celos.rpt"].SetDataSource(new CelosDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme  Celos, Mensaje: " + ex.Message);
            }
            //Asigno los datos al subinforme 'Sincronizacion Celos'
            try
            {
                if (chkSincCelos.Checked)  
                    rpte.Subreports["SincCelos.rpt"].SetDataSource(DatosInformes.SincCelos(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["SincCelos.rpt"].SetDataSource(new SincCelosDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["SincCelos.rpt"].SetDataSource(new SincCelosDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme  Sincronizacion Celos, Mensaje: " + ex.Message);
            }
            //Asigno los datos al subinforme 'Inseminaciones'
            try
            {
                if (chkInseminaciones.Checked)  
                    rpte.Subreports["Inseminaciones.rpt"].SetDataSource(DatosInformes.Inseminaciones(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["Inseminaciones.rpt"].SetDataSource(new InseminacionesDS());
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["Inseminaciones.rpt"].SetDataSource(new InseminacionesDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme  Inseminaciones, Mensaje: " + ex.Message);
            }
            //Asigno los datos al subinforme 'DiagGestacion'
            try
            {
                if (chkDiagGestacion.Checked)
                    rpte.Subreports["DiagGestacion.rpt"].SetDataSource(DatosInformes.DiagGestacion(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["DiagGestacion.rpt"].SetDataSource(new DiagGestacionDS());
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["DiagGestacion.rpt"].SetDataSource(new DiagGestacionDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme  Diagnosticos de gestacion, Mensaje: " + ex.Message);
            }
            //Asigno los datos al subinforme 'Partos'
            try
            {
                if (chkPartos.Checked)                  
                    rpte.Subreports["Partos.rpt"].SetDataSource(DatosInformes.Partos(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["Partos.rpt"].SetDataSource(new PartosDS());
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["Partos.rpt"].SetDataSource(new PartosDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Partos, Mensaje: " + ex.Message);
            }
            //Asigno los datos al subinforme 'Abortos'
            try
            {
                if (chkAbortos.Checked)                  
                    rpte.Subreports["Abortos.rpt"].SetDataSource(DatosInformes.Abortos(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["Abortos.rpt"].SetDataSource(new AbortosDS());
                    
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["Abortos.rpt"].SetDataSource(new AbortosDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Abortos, Mensaje: " + ex.Message);
            }

            //Asigno los datos al subinforme 'Lactacions'
            try
            {
                if (chkLactaciones.Checked)                  
                    rpte.Subreports["Lactaciones.rpt"].SetDataSource(DatosInformes.Lactaciones(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["Lactaciones.rpt"].SetDataSource(new LactacionesDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["Lactaciones.rpt"].SetDataSource(new LactacionesDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Lactaciones, Mensaje: " + ex.Message);
            }

            //Asigno los datos al subinforme 'Secados'
            try
            {
                if (chkSecados.Checked)                  
                    rpte.Subreports["Secados.rpt"].SetDataSource(DatosInformes.Secados(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["Secados.rpt"].SetDataSource(new SecadosDS());
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["Secados.rpt"].SetDataSource(new SecadosDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Secados, Mensaje: " + ex.Message);
            }

            //Asigno los datos al subinforme 'Pesos'
            try
            {
                if (chkPesos.Checked)                  
                    rpte.Subreports["Pesos.rpt"].SetDataSource(DatosInformes.Pesos(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["Pesos.rpt"].SetDataSource(new PesosDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["Pesos.rpt"].SetDataSource(new PesosDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Pesos, Mensaje: " + ex.Message);
            }

            //Asigno los datos al subinforme 'CondicionesCorporales'
            try
            {
                if (chkCondicionesCorporales.Checked)                  
                    rpte.Subreports["CondicionesCorporales.rpt"].SetDataSource(DatosInformes.CondicionesCorporales(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["CondicionesCorporales.rpt"].SetDataSource(new CondicionesCorporalesDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["CondicionesCorporales.rpt"].SetDataSource(new CondicionesCorporalesDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme CondicionesCorporales, Mensaje: " + ex.Message);
            }


            //Asigno los datos al subinforme 'Historial de enfermedades'
            try
            {
                if (chkHistorialEnfermedades.Checked)                  
                    rpte.Subreports["HistorialEnfermedades.rpt"].SetDataSource(DatosInformes.HistorialEnfermedades(fechaInicio, fechaFin, null, null, new List<Animal>() { animal }));
                else
                    rpte.Subreports["HistorialEnfermedades.rpt"].SetDataSource(new HistorialDeEnfermedadesDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["HistorialEnfermedades.rpt"].SetDataSource(new HistorialDeEnfermedadesDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme HistorialEnfermedades, Mensaje: " + ex.Message);
            }


            //Asigno los datos al subinforme 'InformacionCanals'
            try
            {
                if (chkInformacionCanal.Checked)                  
                    rpte.Subreports["InformacionCanal.rpt"].SetDataSource(DatosInformes.InformacionCanal(animal.Id, fechaInicio, fechaFin));
                else
                    rpte.Subreports["InformacionCanal.rpt"].SetDataSource(new InformacionCanalDS());
            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["InformacionCanal.rpt"].SetDataSource(new InformacionCanalDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Informacion a la Canas, Mensaje: " + ex.Message);
            }

            //Asigno los datos al subinforme 'CapacidadMaternal'
            try
            {
                if (chkCapacidadMaternal.Checked)
                    rpte.Subreports["CapacidadMaternal.rpt"].SetDataSource(DatosInformes.CapacidadMaternal(new List<Animal>() { animal }));
                else
                    rpte.Subreports["CapacidadMaternal.rpt"].SetDataSource(new CapacidadMaternalDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos.
                rpte.Subreports["CapacidadMaternal.rpt"].SetDataSource(new CapacidadMaternalDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme Capacidad MAternal, Mensaje: " + ex.Message);
            }


            //Asigno los datos al subinforme 'GMD'
            try
            {
                if (chkGMD.Checked)                  
                    rpte.Subreports["GMD.rpt"].SetDataSource(DatosInformes.GMD(null,null, fechaInicio, fechaFin, null, animal.Id));
                else
                    rpte.Subreports["GMD.rpt"].SetDataSource(new GMDDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["GMD.rpt"].SetDataSource(new GMDDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme G.M.D., Mensaje: " + ex.Message);
            }

            //Asigno los datos al subinforme 'Indices de Conversión'
            try
            {
                if (chkIC.Checked)                  
                    rpte.Subreports["IndicesConversion.rpt"].SetDataSource(DatosInformes.IndicesConversion(null,null, fechaInicio, fechaFin, null, animal.Id));
                else
                    rpte.Subreports["IndicesConversion.rpt"].SetDataSource(new IndicesConversionDS());

            }
            catch (LogicException ex)
            {
                //Establezco datos vacíos para el subinforme si hay algun error obteniendo los datos, por ejemplo si no existen diagnósticos para ese animal.
                rpte.Subreports["IndicesConversion.rpt"].SetDataSource(new IndicesConversionDS());
                Traza.RegistrarInfo("No se ha podido establecer los datos para el subinforme  Indices de conversión, Mensaje: " + ex.Message);
            }
         


        
            //Asigno los parámetros al informe principal
            Generic.EstablecerParametro(rpte, rpte.Parameter_CEA, Configuracion.Explotacion.CEA);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Explotacion, Configuracion.Explotacion.Nombre);
            Generic.EstablecerParametro(rpte, rpte.Parameter_Filtro, (fechaInicio.HasValue?"Fecha >= "+ fechaInicio.Value.ToShortDateString()+ "; " : string.Empty) +
                                                                          (fechaFin.HasValue ? "Fecha <= " + fechaFin.Value.ToShortDateString() + "; " : string.Empty) + 
                                                                           "Nombre = " + animal.Nombre);

            //Asigno los parámetros al subinforme 'Historial de enfermedades'
            Generic.EstablecerParametro(rpte, rpte.Parameter_HistorialEnfermedadesrpt_Simplificado, true);
            Generic.EstablecerParametro(rpte, rpte.Parameter_HistorialEnfermedadesrpt_CEA, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_HistorialEnfermedadesrpt_Explotacion, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_HistorialEnfermedadesrpt_Filtro, string.Empty);

            //Asigno los parámetros al subinforme 'GMD'
            Generic.EstablecerParametro(rpte, rpte.Parameter_GMDrpt_CEA, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_GMDrpt_Explotacion, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_GMDrpt_Filtro, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_GMDrpt_MostrarComoSubInforme, true);

            //Asigno los parámetros al subinforme 'Indices de Conversion'
            Generic.EstablecerParametro(rpte, rpte.Parameter_IndicesConversionrpt_CEA, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_IndicesConversionrpt_Explotacion, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_IndicesConversionrpt_Filtro, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_IndicesConversionrpt_MostrarComoSubInforme, true);

            //Asigno los parámetros al subinforme 'Lactaciones'
            Generic.EstablecerParametro(rpte, rpte.Parameter_Lactacionesrpt_MostrarControles, chkMostrarControles.Checked);

            //Asigno los parámetros al subinforme 'Capacidad Maternal'
            Generic.EstablecerParametro(rpte, rpte.Parameter_CapacidadMaternalrpt_CEA, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_CapacidadMaternalrpt_Explotacion, string.Empty);
            Generic.EstablecerParametro(rpte, rpte.Parameter_CapacidadMaternalrpt_MostrarComoSubInforme, true);


            //Asigno los parametros que controlan la visualizacion de los subinformes en el informe principal
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarGenealogia, chkGenealogia.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarCelos, chkCelos.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarSincCelos, chkSincCelos.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarInseminaciones, chkInseminaciones.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarDiagGestacion, chkDiagGestacion.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarPartos, chkPartos.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarAbortos, chkAbortos.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarLactaciones, chkLactaciones.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarSecados, chkSecados.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarPesos, chkPesos.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarCondicionescorporales, chkCondicionesCorporales.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarHistorialEnfermedades, chkHistorialEnfermedades.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarInformacionCanal, chkInformacionCanal.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarCapacidadMaternal, chkCapacidadMaternal.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarGMD, chkGMD.Checked);
            Generic.EstablecerParametro(rpte, rpte.Parameter_MostrarIC, chkIC.Checked);

            
            
            return rpte;
        }


        #region FUNCIONAMIENTO GENERAL
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            FormularioMaestro.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
        }


        #endregion

        #region PROPIEDADES PARA PROCESOS

        [ProcesoDescripcion("Arbol de Informes -> Ficha Animal - Habilita los controles: Condiciones corporales, Información a la Canal, G.M.D, I.C y Pesos", "Producción de Carne")]
            public bool _proceso_ProducionCarne
            {
                set
                {
                    if (!value)
                    {
                        Generic.DesactivarControl(chkInformacionCanal);
                        Generic.DesactivarControl(chkGMD);
                        Generic.DesactivarControl(chkIC);
                        Generic.DesactivarControl(chkCondicionesCorporales);
                        Generic.DesactivarControl(chkPesos);


                    }
                }
            }
            [ProcesoDescripcion("Arbol de Informes -> Ficha Animal - Habilita los controles: Lactaciones, Controles y secados", "Producción de Leche")]
            public bool _proceso_ProducionLeche
            {
                set
                {
                    if (!value)
                    {
                        Generic.DesactivarControl(chkLactaciones);
                        Generic.DesactivarControl(chkMostrarControles);
                        Generic.DesactivarControl(chkSecados);

                    }
                }
            }
            [ProcesoDescripcion("Arbol de Informes -> Ficha Animal - Habilita los controles: Celos,Sinc. Celos, Inseminaciones, Diagnósticos de Gestación, Partos, Abortos y Capacidad Maternal", "Reproducción")]
            public bool _proceso_Reproduccion
            {
                set
                {
                    if (!value)
                    {
                        Generic.DesactivarControl(chkCelos);
                        Generic.DesactivarControl(chkSincCelos);
                        Generic.DesactivarControl(chkInseminaciones);
                        Generic.DesactivarControl(chkDiagGestacion);
                        Generic.DesactivarControl(chkPartos);
                        Generic.DesactivarControl(chkAbortos);
                        Generic.DesactivarControl(chkCapacidadMaternal);
                    }
                }
            }
            [ProcesoDescripcion("Arbol de Informes -> Ficha Animal - Habilita el control: Genealogía ", "Genealogía")]
            public bool _proceso_Genealogia
            {
                set
                {
                    if (!value)
                        Generic.DesactivarControl(chkGenealogia);

                }
            }
            [ProcesoDescripcion("Arbol de Informes -> Ficha Animal - Habilita el cotrol: Historial de Enfermedades ", "Sanidad")]
            public bool _proceso_Sanidad
            {
                set
                {
                    if (!value)
                        Generic.DesactivarControl(chkHistorialEnfermedades);

                }
            }

        #endregion

      


       

    }


   
    

    
}
