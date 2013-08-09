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
    public partial class EditStatusControl : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditStatusControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditStatusControl(Modo modo, StatusControl ClaseBase):base (modo, ClaseBase)
        {
            InitializeComponent();
        }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que nos devuelve la clase base sobre la que actua el formulario edit.
        /// </summary>
        public StatusControl ObjetoBase {get{return (StatusControl)this.ClaseBase;}}

        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre los controles del formulario y la clase base)
        /// <summary>
        /// Pasa los valores de la clase base a los controles del formulario.
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Codigo", txtCodigo);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        }
        /// <summary>
        /// Pasa los valores de los controles del formulario a la clase base.
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            Generic.ControlAClaseBase(this.ObjetoBase, "Codigo", txtCodigo);
            Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        }
        /// <summary>
        /// Valida los datos de los controles del formulario antes de actualizar la clase base.
        /// </summary>
        /// <returns></returns>
        protected override bool Validar()
        {
            bool rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(new Control[] { txtDescripcion, txtCodigo },this.ErrorProvider))
                rtno = false;
            return rtno;

        }
        #endregion


    }
}
