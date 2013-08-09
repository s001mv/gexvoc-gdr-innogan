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
    public partial class EditTipificacionCanal : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditTipificacionCanal()
        {
            InitializeComponent();
        }
        public EditTipificacionCanal(Modo modo, TipificacionCanal ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public TipificacionCanal ObjetoBase { get { return (TipificacionCanal)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ClaseBase, "IdAnimal", true, cmbAnimal, lblAnimal));
            this.lstBinding.Add(new BindingMaestro(this.ClaseBase, "IdConformacion", true, cmbConformacion, lblConformacion));
            this.lstBinding.Add(new BindingMaestro(this.ClaseBase, "IdCategoria", true, cmbCategoria, lblCategoria));
            this.lstBinding.Add(new BindingMaestro(this.ClaseBase, "Fecha", true, txtFecha,lblFecha));
        }
        private void EditTipificacionCanal_PropiedadAControl(object sender, PropiedadBindEventArgs e)
        {
            if (e.Control == cmbAnimal)
            {
                cmbAnimal.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdAnimal);
                e.Cancelar = true;
            }
        }
        #endregion

        #region CARGAS COMUNES
            /// <summary>
            /// Carga los combos del formulario.
            /// </summary>
            protected override void CargarCombos()
            {
                cmbCategoria.CargarCombo();
                cmbConformacion.CargarCombo();            
            
            }
            /// <summary>
            /// Carga como valor por defecto la fecha del sistema
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(txtFecha, DateTime.Today);
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL

            /// <summary>
            /// Lanza el formulario de busqueda de animales en modo consulta.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));
            }
        #endregion

        #region COMBOS

            private void cmbConformacion_CargarContenido(object sender, EventArgs e)
            {
                //Carga el combo de conformación de la canal.
                this.CargarCombo(cmbConformacion, ConformacionCanal.Buscar());
            }
            private void cmbConformacion_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                ConformacionCanal ObjetoBase = new ConformacionCanal();
                EditConformacionCanal editConformacionCanal = new EditConformacionCanal(Modo.Guardar, ObjetoBase);
                editConformacionCanal.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editConformacionCanal, sender);
            }

            private void cmbCategoria_CargarContenido(object sender, EventArgs e)
            {      
                //Carga el combo de categoría del animal
                this.CargarCombo(cmbCategoria, Categoria.Buscar());
            }
            private void cmbCategoria_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {                
                Categoria ObjetoBase = new Categoria();
                EditCategoria editCategoria = new EditCategoria(Modo.Guardar, ObjetoBase);
                editCategoria.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editCategoria, sender);                
            }

 
        #endregion
        
    }
}
