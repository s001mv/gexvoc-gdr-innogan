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
    public partial class EditConformacion : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EditConformacion()
        {
            InitializeComponent();
        }
        public EditConformacion(Modo modo, Conformacion ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que devuelve la clase base con la que trabaja el formulario.
        /// </summary>
        public Conformacion ObjetoBase { get { return (Conformacion) this.ClaseBase; } }
        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }

        #endregion

        #region BINDING (Intercambio de datos entre la clase base y los controles del formulario)
        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, txtDescripcion, lblDescripcion));
            base.DefinirListaBinding();
        }

        ///// <summary>
        ///// Pasa los datos de la clase base a los controles del formulario.
        ///// </summary>
        //protected override void ClaseBaseAControles()
        //{
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}
        ///// <summary>
        ///// Pasa los datos de los controles del formulario a la clase base.
        ///// </summary>
        //protected override void ControlesAClaseBase()
        //{
        //    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}
        ///// <summary>
        ///// Valida los datos de los controles del formulario antes de actualizar la clase base.
        ///// </summary>
        ///// <returns></returns>
        //protected override bool Validar()
        //{
        //    bool rtno = true;
        //    this.ErrorProvider.Clear();
        //    if (!Generic.ControlValorado(txtDescripcion,  this.ErrorProvider))
        //        rtno = false;
        //    return rtno;
        //}

        #endregion
    }
}
