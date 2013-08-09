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
    public partial class EditAniLot : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditAniLot()
        {
            InitializeComponent();
        }
        public EditAniLot(Modo modo, AniLot ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion


        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public AniLot ObjetoBase { get { return (AniLot)this.ClaseBase; } }

        int? _ValorFijoIdLote = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de los lotes fijo y con el que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdLote
        {
            get { return _ValorFijoIdLote; }
            set { _ValorFijoIdLote = value; }
        }

        int? _ValorFijoIdAnimal = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de los lotes fijo y con el que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdAnimal
        {
            get { return _ValorFijoIdAnimal; }
            set 
            {
                if (value!=null)                
                    cmbAnimal.ClaseActiva = Animal.Buscar((int)value);                    
                
                cmbAnimal.ReadOnly = (value != null);
                _ValorFijoIdAnimal = value; 
            }
        }
       
      
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAnimal", true, this.cmbAnimal, lblAnimal));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdLote", true, this.cmbLoteAnimal, lblLoteAnimal));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaInicio", true, this.txtFechaInicio, lblFecInicio));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaFin", false, this.txtFechaFin, lblFecFin));

                base.DefinirListaBinding();
            }

            private void EditAniLot_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control == cmbAnimal)
                    this.cmbAnimal.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdAnimal);
                    
            }

    
        #endregion

            protected override void CargarCombos()
            {
                this.CargarCombo(cmbLoteAnimal, LoteAnimal.Buscar(Configuracion.Explotacion.Id, string.Empty), ValorFijoIdLote);
                base.CargarCombos();
            }
            /// <summary>
            /// Carga los Valores por defecto del Formulario de Explotaciones
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(this.txtFechaInicio, DateTime.Now.Date);
            }

          

            private void btnBuscarHembra_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
            }

    }
}