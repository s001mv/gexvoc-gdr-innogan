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
    public partial class EditPlaVet : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS

            /// <summary>
            /// Constructor por Defecto
            /// </summary>
            public EditPlaVet()
            {
                InitializeComponent();
            }

            /// <summary>
            /// Sobrecarga del Constructor que nos permite inicializar un formulario GenericEdit con los datos propios del formulario.
            /// Para ello necesitamos el modo en el que se lanza y la clase base sobre la que actúa.
            /// Este tipo de sobrecargas son siempre obligatorias al heredar de GenericEdit.
            /// El Codigo es Siempre el mismo, salvo por el tipo de la ClaseBase, que es propio del formulario heredado.
            /// </summary>
            /// <param name="modo">Modo de Apertura del Formulario Edit</param>
            /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario Edit.</param>
            public EditPlaVet(Modo modo, PlaVet ClaseBase) : base(modo, ClaseBase)
            {
                InitializeComponent();
            }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO

            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public PlaVet ObjetoBase { get { return (PlaVet)this.ClaseBase; } }

            public int? Plantilla { get; set; }
          
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        /// <summary>
        /// Pasa los Valores de la Clase Base a los Controles del Formulario
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "IdPersonal", cmbPersonal);
        }

        /// <summary>
        /// Pasa los valores de los controles a la Clase Base
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            Generic.ControlAClaseBase(this.ObjetoBase, "IdPersonal", cmbPersonal);

            if (this.Plantilla != null)
                this.ObjetoBase.IdPlantilla = this.Plantilla.Value;
        }

        /// <summary>
        /// Validación de los Controles, se produce antes de actualizar la ClaseBase (ControlesAClaseBase)
        /// Si la validación retorna False no se continua con la actualización
        /// </summary>
        /// <returns>Controles Válidos (Sí/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();

            if (!Generic.ControlValorado(new Control[] { cmbPersonal }, this.ErrorProvider))
                Rtno = false;

            return Rtno;
        }

        #endregion

        #region CARGAS COMUNES

        private void cmbTipoPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            if (this.cmbTipoPersonal.SelectedValue != null)
                this.CargarCombo(cmbPersonal, "NombreCompleto", Core.Logic.Veterinario.Buscar(null,string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, null, ((int)this.cmbTipoPersonal.SelectedValue)), true);
            else
                this.CargarCombo(cmbPersonal, null);
        }

        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipoPersonal, "Descripcion", "Id", TipoPersonal.Buscar());
        }

        #endregion
    }
}
