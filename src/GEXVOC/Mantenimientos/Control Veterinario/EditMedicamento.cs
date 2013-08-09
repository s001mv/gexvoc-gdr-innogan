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
    public partial class EditMedicamento : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditMedicamento()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar un formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario edit</param>
        /// <param name="ClaseBase">Clase base sobre la que actua el formulario</param>
        public EditMedicamento(Modo modo, Producto ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que devuelve la clase base con la que trabaja el formulario edit.
        /// </summary>
        public Producto ObjetoBase { get { return (Medicamento)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la clase base y los controles del formulario)
        /// <summary>
        /// Pasa los datos de la clase base a los controles del formulario.
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "SupresionLeche", txtSupresionLeche);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "SupresionCarne", txtSupresionCarne);
        }
        /// <summary>
        /// Pasa los datos de los controles del formulario a la clase base.
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
            Generic.ControlAClaseBase(this.ObjetoBase, "SupresionLeche", txtSupresionLeche);
            Generic.ControlAClaseBase(this.ObjetoBase, "SupresionCarne", txtSupresionCarne);
        }
        /// <summary>
        /// Valida los datos de los controles del formulario antes de actualizar la clase base.
        /// </summary>
        /// <returns></returns>
        protected override bool Validar()
        {
            bool rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(txtDescripcion, this.ErrorProvider))
                rtno = false;
            if (!Validacion.EsNumero(txtSupresionLeche, false))
                rtno = false;
            if (!Validacion.EsNumero(txtSupresionCarne, false))
                rtno = false;
            return rtno;

        }
        #endregion
    }
}
