﻿using System;
using System.Windows.Forms;

using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditMaquinaria : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditMaquinaria()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditMaquinaria(Modo modo, Maquinaria ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO

        /// <summary>
        /// Propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el formulario edit.
        /// </summary>
        public Maquinaria ObjetoBase { get { return (Maquinaria)this.ClaseBase; } }
        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la clase y los controles del formulario)
        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, txtDescripcion, lblDescripcion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Detalle", false, txtDetalle, lblDetalle));
            base.DefinirListaBinding();
        }

        ///// <summary>
        ///// Pasa los valores de la clase base a los controles del formulario.
        ///// </summary>
        //protected override void ClaseBaseAControles()
        //{
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Detalle", txtDetalle);
        //}

        ///// <summary>
        ///// Pasa los valores de los controles del formulario a la clase Base.
        ///// </summary>
        //protected override void ControlesAClaseBase()
        //{
        //    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        //    Generic.ControlAClaseBase(this.ObjetoBase, "Detalle", txtDetalle);
        //}

        ///// <summary>
        ///// Validación de controles se utiliza antes de actualizar la clase base.
        ///// </summary>
        ///// <returns></returns>
        //protected override bool Validar()
        //{
        //    bool Rtno = true;

        //    this.ErrorProvider.Clear();

        //    if (!Generic.ControlValorado(txtDescripcion,  this.ErrorProvider))
        //        Rtno = false;

        //    return Rtno;
        //}

        #endregion
    }
}