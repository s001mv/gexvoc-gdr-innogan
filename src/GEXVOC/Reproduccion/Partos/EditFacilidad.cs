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
    public partial class EditFacilidad : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EditFacilidad()
        {
            InitializeComponent();
        }
        public EditFacilidad(Modo modo, Facilidad ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que nos devuelve la clase base sobre la que actúa el formulario edit.
        /// </summary>
        public Facilidad ObjtoBase { get { return (Facilidad)this.ClaseBase; } }

        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }

        #endregion

        #region BINDING (Intercambio de datos entre la clase base y los controles del formulario)
        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjtoBase, "Descripcion", true, txtDescripcion, lblDescripcion));
            base.DefinirListaBinding();
        }

        ///// <summary>
        ///// Pasa los valores de la clase base a los controles del formulario.
        ///// </summary>
        //protected override void ClaseBaseAControles()
        //{
        //    Generic.ClaseBaseAcontrol(this.ObjtoBase, "Descripcion", txtDescripcion);
        //}
        ///// <summary>
        ///// Pasa los valores de los controles del formulario a la clase base.
        ///// </summary>
        //protected override void ControlesAClaseBase()
        //{
        //    Generic.ControlAClaseBase(this.ObjtoBase, "Descripcion", txtDescripcion);
        //}
        ///// <summary>
        ///// Validación de controles se utiliza antes de actualizar la clase base.
        ///// </summary>
        ///// <returns></returns>
        //protected override bool Validar()
        //{
        //    bool rtno = true;
        //    this.ErrorProvider.Clear();
        //    if (!Generic.ControlValorado(txtDescripcion, this.ErrorProvider))
        //        rtno = false;
        //    return rtno;

        //}
        #endregion
    }
}
