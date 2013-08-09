using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Reflection;

namespace GEXVOC.UI
{
    public partial class ArbolInfomes : GEXVOC.UI.GenericInfArbol
    {
        #region CONSTUCTORES
        public ArbolInfomes()
        {
            InitializeComponent();
        }

        public ArbolInfomes(string InformeSeleccionar)
            : base(InformeSeleccionar)
        {
            InitializeComponent();
        }

        #endregion       

        #region FUNCIONAMIENTO GENERAL
        private void ArbolInfomes_InformeSeleccionando(object sender, GenericInfArbolEventArgs e)
        {
            switch (e.NombreCompleto)
            {
                case "ANIMALES\\FICHA DEL ANIMAL":
                    e.InformeActivo = new Informes.InfFichaAnimal();
                    break;
                case "ANIMALES\\LISTADO DE ANIMALES":
                    e.InformeActivo = new Informes.InfListadoAnimales();
                    break;
                case "ANIMALES\\ANIMALES IMPRODUCTIVOS":
                    e.InformeActivo = new Informes.InfAnimalesImproductivos();
                    break;
                case "ANIMALES\\HISTORIAL DE ENFERMEDADES":
                    e.InformeActivo = new Informes.InfHistorialEnfermedades();
                    break;
                case "GESTIÓN DE PARCELAS\\SEMBRADOS":
                    e.InformeActivo = new Informes.InfSembrado();
                    break;
                case "GESTIÓN DE PARCELAS\\ABONADOS":
                    e.InformeActivo = new Informes.InfAbonado();
                    break;
                case "GESTIÓN DE PARCELAS\\TRATAMIENTOS":
                    e.InformeActivo = new Informes.InfTratParcela();
                    break;
                case "GESTIÓN DE PARCELAS\\CORTES DE HIERBA":
                    e.InformeActivo = new Informes.InfRecolecta();
                    break;
                case "ALIMENTACIÓN\\CONSUMOS Y PRODUCCIÓN":
                    e.InformeActivo = new Informes.InfConsumos();
                    break;
                case "ALIMENTACIÓN\\CONTROL DE STOCK DE ALIMENTACIÓN":
                    e.InformeActivo = new Informes.InfControlDeStockDeAlimentacion();
                    break;
                case "EXPLOTACIÓN\\LIBRO DE EXPLOTACIÓN GANADERA":
                    e.InformeActivo = new Informes.InfLibroExplotacion();
                    break;
                case "TRAZABILIDAD\\PRODUCTOS":
                    e.InformeActivo = new Informes.InfTrazaProductos();
                    break;
                case "TRAZABILIDAD\\ANIMALES":
                    e.InformeActivo = new Informes.InfTrazaAnimales();
                    break;
                case "PRODUCCIÓN\\PRODUCCIÓN DE LECHE\\RESUMEN PRODUCCIÓN DE LECHE":
                    e.InformeActivo = new Informes.InfProduccionLeche();
                    break;
                case "SANIDAD\\CONSULTA MORBILIDAD":
                    e.InformeActivo = new Informes.InfConsultaMorbilidad();
                    break;
                case "SANIDAD\\CONSULTA MORTALIDAD":
                    e.InformeActivo = new Informes.InfConsultaMortalidad();
                    break;
                case "SANIDAD\\PREVALENCIA ENFERMEDADES":
                    e.InformeActivo = new Informes.InfPrevalenciaEnfermedades();
                    break;
                case "SANIDAD\\ANIMALES EN TRATAMIENTO":
                    e.InformeActivo = new Informes.InfAnimalesEnTratamiento();
                    break;
                case "REPRODUCCIÓN\\PROLIFICIDAD":
                    e.InformeActivo = new Informes.InfProlificidad();
                    break;
                case "REPRODUCCIÓN\\ANIMALES NACIDOS Y GENEALOGÍA":
                    e.InformeActivo = new Informes.InfAnimalesNacidosGenealogia();
                    break;
                case "REPRODUCCIÓN\\ANIMALES DESTETADOS":
                    e.InformeActivo = new Informes.InfAnimalesDestetados();
                    break;
                case "REPRODUCCIÓN\\ANIMALES MUERTOS\\GENERAL":
                    e.InformeActivo = new Informes.InfAnimalesMuertos(GEXVOC.Informes.InfAnimalesMuertos.TipoInformesMuerte.GENERAL);
                    break;
                case "REPRODUCCIÓN\\ANIMALES MUERTOS\\NACIDOS MUERTOS":
                    e.InformeActivo = new Informes.InfAnimalesMuertos( GEXVOC.Informes.InfAnimalesMuertos.TipoInformesMuerte.MUERTE_NACIMIENTO);
                    break;
                case "REPRODUCCIÓN\\ANIMALES MUERTOS\\MUERTE PERINATAL":
                    e.InformeActivo = new Informes.InfAnimalesMuertos(GEXVOC.Informes.InfAnimalesMuertos.TipoInformesMuerte.MUERTE_PERINATAL);
                    break;
                case "REPRODUCCIÓN\\ANIMALES MUERTOS\\MUERTE HASTA DESTETE":
                    e.InformeActivo = new Informes.InfAnimalesMuertos(GEXVOC.Informes.InfAnimalesMuertos.TipoInformesMuerte.MUERTE_DESTETE);
                    break;
                case "REPRODUCCIÓN\\ANIMALES MUERTOS\\MUERTE POST-DESTETE":
                    e.InformeActivo = new Informes.InfAnimalesMuertos(GEXVOC.Informes.InfAnimalesMuertos.TipoInformesMuerte.MUERTE_POSTDESTETE);
                    break;
                case "PRODUCCIÓN\\PRODUCCIÓN DE LECHE\\RECUENTO DE CÉLULAS SOMÁTICAS":
                    e.InformeActivo = new Informes.InfRecuento();
                    break;
                case "PRODUCCIÓN\\PRODUCCIÓN DE LECHE\\RECUENTO DE CÉLULAS SOMÁTICAS GRÁFICO":
                    e.InformeActivo = new Informes.InfRecuento() { Grafico = true };
                    break;
                case "PRODUCCIÓN\\PRODUCCIÓN DE CARNE\\INDICES DE CONVERSIÓN":
                    e.InformeActivo = new Informes.InfIndicesConversion();
                    break;
                case "PRODUCCIÓN\\PRODUCCIÓN DE CARNE\\GANANCIAS MEDIAS DIARIAS":
                    e.InformeActivo = new Informes.InfGMD();
                    break;
                case "GESTIÓN FINANCIERA\\GASTOS E INGRESOS":
                    e.InformeActivo = new Informes.InfGastosIngresos();
                    break;
                case "REPRODUCCIÓN\\PARTOS\\INTERVALOS ENTRE PARTOS":
                    e.InformeActivo = new Informes.InfIntervaloPartos();
                    break;
                case "REPRODUCCIÓN\\CAPACIDAD MATERNAL":
                    e.InformeActivo = new Informes.InfCapacidadMaternal();
                    break;
                case "REPRODUCCIÓN\\PARTOS\\DISTRIBUCION ENTRE PARTOS":
                    e.InformeActivo = new Informes.InfDistribucionPartos();
                    break;
                case "REPRODUCCIÓN\\PARTOS\\TASA DE ABORTOS":
                    e.InformeActivo = new Informes.InfTasaAbortos();
                    break;
                case "REPRODUCCIÓN\\PARTOS\\TASA DE PARTOS":
                    e.InformeActivo = new Informes.InfTasaPartos();
                    break;
                case "REPRODUCCIÓN\\ESTADÍSTICA DE FERTILIDAD":
                    e.InformeActivo = new Informes.InfEstadisticasFertilidad();
                    break;
                case "REPRODUCCIÓN\\EVOLUCIÓN ANUAL":
                    e.InformeActivo = new Informes.InfEvolucionAnual();
                    break;
                default:
                    e.Cancelar = true;
                    break;
            }
        }

        #endregion       

        #region PROPIEDADES PARA PROCESOS

            [ProcesoDescripcion("Arbol de Informes - Muestra el nodo: Alimentación", "Alimentación")]
            public bool _proceso_Alimentacion
            {
                set
                {
                    if (!value) trvInformes.Nodes.RemoveByKey("NodoAlimentacion");                
                    
                }
            }

            [ProcesoDescripcion("Arbol de Informes - Muestra el nodo: Producción de Leche", "Producción de Leche")]
            public bool _proceso_ProducionLeche
            {
                set
                {
                    if (!value) trvInformes.Nodes.RemoveByKey("NodoProduccionLeche"); 
                }
            }

            [ProcesoDescripcion("Arbol de Informes - Muestra el nodo: Gestión de Fincas", "Fincas")]
            public bool _proceso_Fincas
            {
                set
                {
                    if (!value) trvInformes.Nodes.RemoveByKey("NodoFincas"); 
                }
            }

            [ProcesoDescripcion("Arbol de Informes - Muestra el nodo: Gestión Financiera", "Economía")]
            public bool _proceso_Economia
            {
                set
                {
                    if (!value) trvInformes.Nodes.RemoveByKey("NodoGestionFinanciera"); 

                }
            }

            [ProcesoDescripcion("Arbol de Informes - Muestra el nodo: Sanidad y Animales -> Historial de Enfermedades", "Sanidad")]
            public bool _proceso_Sanidad
            {
                set
                {
                    if (!value)
                    {
                        trvInformes.Nodes.RemoveByKey("NodoSanidad");
                        
                        //Elimino el nodo Animales -> Historial Enfermedades
                        TreeNode nodoAnimales = null;
                        if (trvInformes.Nodes.ContainsKey("NodoAnimales"))
                        {
                            nodoAnimales = trvInformes.Nodes["NodoAnimales"];
                            nodoAnimales.Nodes.RemoveByKey("ndHistorialEnfermedades");
                        }                      
                    }
                }
            }

            [ProcesoDescripcion("Arbol de Informes - Muestra el nodo: Reproducción y Animales -> Animales Improductivos", "Reproducción")]
            public bool _proceso_Reproduccion
            {
                set
                {
                    if (!value)
                    {
                        //Elimino el nodo Reproducción
                        trvInformes.Nodes.RemoveByKey("NodoReproduccion");


                        //Elimino el nodo Animales -> Animales Improductivos
                        TreeNode nodoAnimales = null;
                        if (trvInformes.Nodes.ContainsKey("NodoAnimales"))
                        {
                            nodoAnimales = trvInformes.Nodes["NodoAnimales"];
                            nodoAnimales.Nodes.RemoveByKey("ndAnimalesImproductivos");
                        }
                    }

                }
            }
            [ProcesoDescripcion("Arbol de Informes - Muestra el nodo: Trazabilidad", "Trazabilidad")]
            public bool _proceso_Trazabilidad
            {
                set
                {
                    if (!value)
                        trvInformes.Nodes.RemoveByKey("NodoTrazabilidad");

                }
            }

        #endregion           
        
    }
}
