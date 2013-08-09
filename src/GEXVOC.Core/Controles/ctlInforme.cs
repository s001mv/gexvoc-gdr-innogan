using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GEXVOC.Core.Controles
{
    public  partial class ctlInforme : UserControl
    {
        public ctlInforme()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// Se produce al pulsar el botón de generar, dependiendo del valor devuelto, se continuará con la carga
        /// del informe, o ésta se cancelará
        /// Representamos aqui tanto los valores requeridos sin los que no tendría sentido el informe, como la 
        /// validación de los tipos de datos de los controles.
        /// </summary>
        /// <returns>Boolean (Datos Válidos para poder continuar o no)</returns>
        public virtual bool Validar()
        {
            return true;
        }

        /// <summary>
        /// Carga los controles con sus contenidos iniciales, combos etc...
        /// </summary>
        public virtual void CargaControles(){}

        /// <summary>
        /// Valores iniciales que deben contener los controles.
        /// </summary>
        public virtual void ValoresPredeterminados() { }

        /// <summary>
        /// Es el método que genera un objeto del tipo ReportDocument
        /// Generera un ReportDocument concreto valiéndonos para ello de la información del resto de los controles
        /// Aqui se cargan tambien los datos en el informe tal que el elemento devuelto por este procedimiento
        /// es ya un informe ya completo y preparado para ser mostrado al usuario.
        /// </summary>
        /// <returns></returns>
        public virtual CrystalDecisions.CrystalReports.Engine.ReportDocument Generar() { return null; }

        public virtual CrystalDecisions.CrystalReports.Engine.ReportDocument ConstruirInforme() 
        {
            this.FiltroVisual = string.Empty;//Me aseguro de limpiar el filtro, pues generar filtro visual simplemente añade las cadenas
            this.GenerarFiltroVisual();
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpte = this.Generar();

            if (rpte!=null)
            {
                //PARÁMETROS COMUNES
                ///En su mayoría los informes tienen una serie de parámetros predeterminados que por defecto se inicializan solos
                ///Dichos parámetros son los siguientes:
                ///Nota: Solo se inicializan si existe el parámetro definido en el informe en cualquier otro caso se omite esta seccion            
                ///Nota2: Solo se establece el valor si no ha sido establecido previamente, de lo contrario no se sobreescribe.

                ///PARÁMETRO FILTRO
                if (rpte.ParameterFields.Find("Filtro", string.Empty) != null && !rpte.ParameterFields.Find("Filtro", string.Empty).HasCurrentValue)

                    rpte.SetParameterValue("Filtro", FiltroVisual);

                ///PARÁMETRO CEA
                if (rpte.ParameterFields.Find("CEA", string.Empty) != null && !rpte.ParameterFields.Find("CEA", string.Empty).HasCurrentValue)
                    rpte.SetParameterValue("CEA", Logic.Configuracion.Explotacion.CEA);

                ///PARÁMETRO EXPLOTACION
                if (rpte.ParameterFields.Find("Explotacion", string.Empty) != null && !rpte.ParameterFields.Find("Explotacion", string.Empty).HasCurrentValue)
                    rpte.SetParameterValue("Explotacion", Logic.Configuracion.Explotacion.Nombre);

                
            }

            return rpte;

        }

        /// <summary>
        /// Título del Informe
        /// </summary>
        string _TituloInforme = string.Empty;
        public string TituloInforme
        {
            get { return _TituloInforme; }
            set { _TituloInforme = value; }
        }

        /// <summary>
        /// Descripción del Informe
        /// </summary>
        string _DescripcionInforme = string.Empty;
        public string DescripcionInforme
        {
            get { return _DescripcionInforme; }
            set { _DescripcionInforme = value; }
        }

        /// <summary>
        /// Representa el formulario que contiene el control del informe.
        /// Es una propiedad que es asignada automaticamente en GenericInfArbol, pero no representa
        /// el contenedor, si no el formulario que contiene el control Informe.
        /// Habitualmente contiene un formulario del tipo GenericInfArbol encapsulado en un object.
        /// Esta propiedad es utilizada para lanzar formularios, carbar combos y validar datos de acuerdo con lo establecido en un
        /// formulario del tipo GenericMaestros.
        /// Será muy habitual casi una obligación encontrarnos en un ctlinforme la siguiente propiedad:
        /// <code>public GenericMaestro FormularioMaestro {get{return ((GenericMaestro)this.FormularioInformes);}}</code>         
        /// </summary>
        private object _FormularioInformes;
        public object FormularioInformes
        {
            get {return _FormularioInformes; }
            set { _FormularioInformes = value; }
        }

        /// <summary>
        /// Variable que va a contener el filtro que se muesta en el informe al usuario, es meramente informativo,
        /// lo que contenga esta variable en ningún caso tendrá efectos sobre los datos.
        /// </summary>
        public string FiltroVisual{get;set;}

        /// <summary>
        /// Agrega una cadena específica al filtro acumulado.
        /// </summary>
        /// <param name="detalleFiltro"></param>
        public void AgregarFiltroVisual(string detalleFiltro) 
        {
            if (!string.IsNullOrEmpty(detalleFiltro))
            {
                if (string.IsNullOrEmpty(FiltroVisual))
                    FiltroVisual = detalleFiltro;
                else
                    FiltroVisual += SeparadorFiltro + " " + detalleFiltro;                            
            }
            
        }
       
        /// <summary>
        /// Función que debe ser sobreescrita y que contendrá el código necesario para la correcta inicialización de la
        /// propiedad FiltroVisual. 
        /// </summary>
        public virtual void GenerarFiltroVisual(){ }


        private char _SeparadorFiltro=char.Parse("|");
        /// <summary>
        /// Nos proporciona el carácter que será utilizado para separar las cadenas que forman el filtro.
        /// </summary>
        public char SeparadorFiltro
        {
            get { return _SeparadorFiltro; }
            set { _SeparadorFiltro = value; }
        }

    }
}
