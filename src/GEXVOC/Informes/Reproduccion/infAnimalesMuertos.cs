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
    public partial class InfAnimalesMuertos : GEXVOC.Core.Controles.ctlInforme
    {
        public enum TipoInformesMuerte
        {
            GENERAL,
            MUERTE_NACIMIENTO,
            MUERTE_PERINATAL,
            MUERTE_DESTETE,
            MUERTE_POSTDESTETE
        }
        public InfAnimalesMuertos()
        {
            InitializeComponent();
            TipoMostrar = TipoInformesMuerte.GENERAL;
        }
        public InfAnimalesMuertos(TipoInformesMuerte tipo)
        {
            InitializeComponent();
            TipoMostrar = tipo;
        }
        
        TipoInformesMuerte TipoMostrar { get; set; }
        public GenericMaestro FormularioMaestro
        {
            get { return ((GenericMaestro)this.FormularioInformes); }
        }

        public override CrystalDecisions.CrystalReports.Engine.ReportDocument Generar()
        {
            //INICIO - Declaro y establezo los valores a las variables que forman el filtro
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpte=null;
            //FIN - Declaro y establezo los valores a las variables que forman el filtro
          
            switch (TipoMostrar)
            {
                case TipoInformesMuerte.GENERAL:
                    rpte = new MuerteGeneral();

                    //Asigno los datos al subinforme 'Muerte Nacimiento'
                    try
                    {
                        rpte.Subreports["MuerteNacimiento"].SetDataSource(DatosInformes.MuerteNacimiento(Generic.ControlAIntNullable(cmbLote),
                                                                              Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                              Generic.ControlADatetimeNullable(txtFechaFin),
                                                                              Generic.ControlAIntNullable(cmbEspecie)));
                    }
                    catch (LogicException ex) {Traza.RegistrarError(ex);
                    rpte.Subreports["MuerteNacimiento"].SetDataSource(new MuerteNacimientoDS());
                    }

                    //Asigno los datos al subinforme 'Muerte Perinatal'
                    try
                    {
                        rpte.Subreports["MuertePerinatal"].SetDataSource(DatosInformes.MuertePerinatal(Generic.ControlAIntNullable(cmbLote),
                                                                              Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                              Generic.ControlADatetimeNullable(txtFechaFin),
                                                                              Generic.ControlAIntNullable(cmbEspecie)));
                    }
                    catch (LogicException ex) {Traza.RegistrarError(ex);
                    rpte.Subreports["MuertePerinatal"].SetDataSource(new MuerteDS());
                    }

                    //Asigno los datos al subinforme 'Muerte destete'
                    try
                    {
                        rpte.Subreports["MuerteDestete"].SetDataSource(DatosInformes.MuerteDestete(Generic.ControlAIntNullable(cmbLote),
                                                                              Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                              Generic.ControlADatetimeNullable(txtFechaFin),
                                                                              Generic.ControlAIntNullable(cmbEspecie)));
                    }
                    catch (LogicException ex) { Traza.RegistrarError(ex);
                    rpte.Subreports["MuerteDestete"].SetDataSource(new MuerteDS());
                    }

                    //Asigno los datos al subinforme 'Muerte post-destete'
                    try
                    {
                        rpte.Subreports["MuertePostDestete"].SetDataSource(DatosInformes.MuertePostDestete(Generic.ControlAIntNullable(cmbLote),
                                                                              Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                              Generic.ControlADatetimeNullable(txtFechaFin),
                                                                              Generic.ControlAIntNullable(cmbEspecie)));
                    }
                    catch (LogicException ex) { Traza.RegistrarError(ex);
                    rpte.Subreports["MuertePostDestete"].SetDataSource(new MuerteDS());
                    }

                    //Establezco los valores a los parámetros del informe si es necesario.
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteNacimiento_CEA, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteNacimiento_Explotacion, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteNacimiento_Filtro, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteNacimiento_MostrarComoSubInforme, true);

                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePerinatal_CEA, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePerinatal_Explotacion, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePerinatal_Filtro, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePerinatal_MostrarComoSubInforme, true);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePerinatal_Titulo, "MUERTES PERINATALES");

                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteDestete_CEA, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteDestete_Explotacion, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteDestete_Filtro, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteDestete_MostrarComoSubInforme, true);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuerteDestete_Titulo, "MUERTES DESTETE");

                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePostDestete_CEA, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePostDestete_Explotacion, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePostDestete_Filtro, string.Empty);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePostDestete_MostrarComoSubInforme, true);
                    Generic.EstablecerParametro(rpte, ((MuerteGeneral)rpte).Parameter_MuertePostDestete_Titulo, "MUERTES POST-DESTETE");

                   
                    break;
                case TipoInformesMuerte.MUERTE_NACIMIENTO:
                    //Creo el objeto del tipo adecuado (hereda de ReportDocument)
                    rpte = new MuerteNacimiento();

                    //Inicializo el dataset adecuado para el informe con los datos pertinentes.
                    MuerteNacimientoDS DatosMuerteNacimiento = DatosInformes.MuerteNacimiento(Generic.ControlAIntNullable(cmbLote),
                                                                              Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                              Generic.ControlADatetimeNullable(txtFechaFin),
                                                                              Generic.ControlAIntNullable(cmbEspecie));

                    //Establezco el origen de datos del informe
                    rpte.SetDataSource(DatosMuerteNacimiento);

                    //Establezco los valores a los parámetros del informe si es necesario.
                    Generic.EstablecerParametro(rpte, ((MuerteNacimiento)rpte).Parameter_MostrarComoSubInforme, false);
                   
                    break;

                default:
                              
                                
                    //Creo el objeto del tipo adecuado (hereda de ReportDocument)
                    rpte = new Muerte();
                    MuerteDS DatosMuerteGeneral = null;

                    switch (TipoMostrar)
                    {                      
                        case TipoInformesMuerte.MUERTE_PERINATAL:
                            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
                            DatosMuerteGeneral = DatosInformes.MuertePerinatal(Generic.ControlAIntNullable(cmbLote),
                                                                           Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                           Generic.ControlADatetimeNullable(txtFechaFin),
                                                                           Generic.ControlAIntNullable(cmbEspecie));
                            //Establezco el origen de datos del informe
                            rpte.SetDataSource(DatosMuerteGeneral);

                            //Establezco los valores a los parámetros del informe si es necesario.
                            Generic.EstablecerParametro(rpte, ((Muerte)rpte).Parameter_Titulo, "MUERTES PERINATALES");
                            Generic.EstablecerParametro(rpte, ((Muerte)rpte).Parameter_MostrarComoSubInforme, false);  
                            break;
                        case TipoInformesMuerte.MUERTE_DESTETE:
                            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
                            DatosMuerteGeneral = DatosInformes.MuerteDestete(Generic.ControlAIntNullable(cmbLote),
                                                                           Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                           Generic.ControlADatetimeNullable(txtFechaFin),
                                                                           Generic.ControlAIntNullable(cmbEspecie));

                            //Establezco el origen de datos del informe
                            rpte.SetDataSource(DatosMuerteGeneral);

                            //Establezco los valores a los parámetros del informe si es necesario.
                            Generic.EstablecerParametro(rpte, ((Muerte)rpte).Parameter_Titulo, "MUERTES DESTETE");
                            Generic.EstablecerParametro(rpte, ((Muerte)rpte).Parameter_MostrarComoSubInforme, false);  

                            break;
                        case TipoInformesMuerte.MUERTE_POSTDESTETE:
                            //Inicializo el dataset adecuado para el informe con los datos pertinentes.
                            DatosMuerteGeneral = DatosInformes.MuertePostDestete(Generic.ControlAIntNullable(cmbLote),
                                                                           Generic.ControlADatetimeNullable(txtFechaInicio),
                                                                           Generic.ControlADatetimeNullable(txtFechaFin),
                                                                           Generic.ControlAIntNullable(cmbEspecie));
                            //Establezco el origen de datos del informe
                            rpte.SetDataSource(DatosMuerteGeneral);

                            //Establezco los valores a los parámetros del informe si es necesario.
                            Generic.EstablecerParametro(rpte, ((Muerte)rpte).Parameter_Titulo, "MUERTES POST-DESTETE");
                            Generic.EstablecerParametro(rpte, ((Muerte)rpte).Parameter_MostrarComoSubInforme, false);                            
                            break;                     
                    }
                    break;                               
                  

                    
            }       

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

        public override void CargaControles()
        {
            FormularioMaestro.CargarCombo(this.cmbEspecie, Configuracion.Explotacion.lstEspecies, true);
        }

        private void btnbuscarLote_Click(object sender, EventArgs e)
        {
            FormularioMaestro.LanzarFormularioConsulta(new FindLoteAnimal(Modo.Consultar, this.cmbLote));
        }
    }

}