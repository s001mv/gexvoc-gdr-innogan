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
    public partial class EditTipoSecado : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditTipoSecado()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditTipoSecado(Modo modo, TipoSecado ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDAES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad Tipada que nos devuelve la clase base sobre la que actúa el formulario edit.
        /// </summary>
        public TipoSecado ObjetoBase { get { return (TipoSecado)this.ClaseBase; } }
        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la clase y los controles del formulario)
        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", false, txtDescripcion, lblDescripcion));
            base.DefinirListaBinding();
        }
        ///// <summary>
        ///// Pasa los valores de la clase base a los controles del formulario.
        ///// </summary>
        //protected override void ClaseBaseAControles()
        //{
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}
        ///// <summary>
        ///// Pasa los valores de los controles del formulario a la clase base.
        ///// </summary>
        //protected override void ControlesAClaseBase()
        //{
        //    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}

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
