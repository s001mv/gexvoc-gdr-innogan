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
    public partial class EditTipoDiagnostico : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditTipoDiagnostico()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditTipoDiagnostico(Modo modo, TipoDiagnostico ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que nos devuelve la clase base sobre la que actua el formulario edit.
        /// </summary>
        public TipoDiagnostico ObjetoBase { get { return (TipoDiagnostico) this.ClaseBase; } }

        #endregion

        #region BINDING (Intercambio entre la clase base y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", false, txtDescripcion, lblDescripcion));
                base.DefinirListaBinding();
            }
        /////// <summary>
        /////// Pasa los valores de la clase base a los controles del formulario.
        /////// </summary>
        ////protected override void ClaseBaseAControles()
        ////{
        ////    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        ////}
        /////// <summary>
        /////// Pasa los valores de los controles del formulario a la clase base.
        /////// </summary>
        ////protected override void ControlesAClaseBase()
        ////{
        ////    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        ////}
        /////// <summary>
        /////// Valida los datos de los controles del formulario antes de actualizar la clase base.
        /////// </summary>
        /////// <returns></returns>
        ////protected override bool Validar()
        ////{
        ////    bool rtno = true;
        ////    this.ErrorProvider.Clear();
        ////    if(!Generic.ControlValorado(txtDescripcion,this.ErrorProvider))
        ////        rtno=false;
        ////    return rtno;
        ////}

        #endregion


    }
}
