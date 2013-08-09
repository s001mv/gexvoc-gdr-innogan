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
    public partial class EditAborto : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditAborto()
            {
                InitializeComponent();
            }
            public EditAborto(Modo modo, Aborto ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Aborto ObjetoBase { get { return (Aborto)this.ClaseBase; } }


            int? _ValorFijoIdHembra = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public int? ValorFijoIdHembra
            {
                get { return _ValorFijoIdHembra; }
                set
                {
                    if (value != null)
                    {
                        this.cmbHembra.ClaseActiva = Animal.Buscar((int)value);
                        this.cmbHembra.ReadOnly = true;
                    }
                    else
                        this.cmbHembra.ReadOnly = false;

                    _ValorFijoIdHembra = value;
                }
            }

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
        {
            this.cmbHembra.TipoDatos = typeof(Animal);
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdHembra", true, this.cmbHembra, lblHembra));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));            
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));          

            base.DefinirListaBinding();
        }
            ////private void EditAborto_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            ////{
            ////    if (e.Control == this.cmbHembra)
            ////        this.cmbHembra.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdHembra);


            ////} 

        
        #endregion
                    
        #region CARGAS COMUNES

        /// <summary>
        /// Carga los combos del formulario
        /// </summary>
        protected override void CargarCombos()
        {
            this.cmbTipo.CargarCombo();
        }

        /// <summary>
        /// Carga los Valores por defecto del Formulario de Explotaciones
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(this.txtFecha, DateTime.Now.Date);

        }


        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
            }
        #endregion

        #region COMBOS
            private void cmbTipo_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbTipo, TipoAborto.Buscar());
            }
            private void cmbTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {


                TipoAborto ObjetoBase = new TipoAborto();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Tipo Aborto";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto = e.TextoCrear });

                CrearNuevoElementoCombo(frmLanzar, sender);


            }

        #endregion


    }
}