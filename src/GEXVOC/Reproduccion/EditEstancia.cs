using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditEstancia : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditEstancia()
        {
            InitializeComponent();
        }
        public EditEstancia(Modo modo, Estancia ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Estancia ObjetoBase { get { return (Estancia)this.ClaseBase; } }

            int? _ValorFijoIdMacho = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo de la Macho fijo y con el animal que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public int? ValorFijoIdMacho
            {
                get { return _ValorFijoIdMacho; }
                set
                {
                    if (value != null)
                    {
                        this.cmbMacho.ClaseActiva = Animal.Buscar((int)value);
                        this.cmbMacho.ReadOnly = true;
                    }
                    else
                        this.cmbMacho.ReadOnly = false;

                    _ValorFijoIdMacho = value;
                }
            }

            int? _ValorFijoIdCubricion = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo de la cubricion fijo y con el  que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public int? ValorFijoIdCubricion
            {
                get { return _ValorFijoIdCubricion; }
                set
                {
                    if (value != null)
                    {
                        this.cmbCubricion.ClaseActiva = Cubricion.Buscar((int)value);
                        this.cmbCubricion.ReadOnly = true;
                    }
                    else
                        this.cmbCubricion.ReadOnly = false;

                    _ValorFijoIdCubricion = value;
                }
            }
            DateTime _ValorFijoFechaInicio;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo de la cubricion fijo y con el  que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public DateTime ValorFijoFechaInicio
            {
                get { return _ValorFijoFechaInicio; }
                set
                {                  
                        Generic.DatetimeAControl(txtFechaInicio,value);
                        this.txtFechaInicio.ReadOnly = true;
                        this.txtFechaInicio.TabStop = false;    
                    
                 

                    _ValorFijoFechaInicio = value;
                }
            }


        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdCubricion", true, this.cmbCubricion, lblCubricion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdMacho", true, this.cmbMacho, lblMacho));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaInicio", true, this.txtFechaInicio, lblFechaIni));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaFin", false, this.txtFechaFin, lblFechaFin));
                base.DefinirListaBinding();
            }
            private void EditEstancia_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                cmbMacho.TipoDatos = typeof(Animal);
                if (e.Control == this.cmbMacho)
                    // cmbMacho.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdMacho);
                    cmbMacho.IdClaseActiva = this.ObjetoBase.IdMacho;
                if (e.Control == this.cmbCubricion)
                    cmbCubricion.ClaseActiva = Cubricion.Buscar(this.ObjetoBase.IdCubricion);
            }

     

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                //#MOD_A3          
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbMacho) { ValorSexoFijo = Convert.ToChar("M"),ValorEstadoFijo=Configuracion.EstadoSistema(Configuracion.EstadosSistema.SEMENTAL).Id });
            }


        #endregion     

       
      
    }
}