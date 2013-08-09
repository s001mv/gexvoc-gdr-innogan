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
    public partial class EditEnfermedad : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditEnfermedad()
        {
            InitializeComponent();
        }

        public EditEnfermedad(Modo modo, Enfermedad ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO.
        /// <summary>
        /// Propiedad tipada que devuelve la clase base con la que trabaja el formulario edit.
        /// </summary>
        public Enfermedad ObjetoBase { get { return (Enfermedad)this.ClaseBase; } }

        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la clase base y los controles del formulario)

            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, this.txtDescripcion, lblDescripcion));
              


                base.DefinirListaBinding();
            }
       

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            cmbTipo.CargarCombo();       
        }

        #endregion 

        #region COMBOS
            private void cmbTipo_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbTipo, TipoEnfermedad.Buscar());    
            }

            private void cmbTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                TipoEnfermedad ObjetoBase = new TipoEnfermedad();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Tipo de Enfermedad";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto=e.TextoCrear});

                CrearNuevoElementoCombo(frmLanzar, sender);

                //Poner en el formulario TipoEnfermedad si es necesario
                //public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
            }
        #endregion
    }
}
