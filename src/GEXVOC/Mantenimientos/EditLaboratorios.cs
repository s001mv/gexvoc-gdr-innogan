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
    public partial class EditLaboratorios : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditLaboratorios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga de un constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditLaboratorios(Modo modo, Laboratorio ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que nos devuelve la clase base sobre la que actua el formulario edit.
        /// </summary>
        public Laboratorio ObjetoBase { get { return (Laboratorio)this.ClaseBase; } }
        public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la clase base y los controles del formulario)
        /// <summary>
        /// Pasa los datos de la clase base a los controles del formulario.
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Nombre", txtNombre);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Direccion", txtDireccion);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Telefono", txtTelefono);
        }
        /// <summary>
        /// Pasa los datos de los controles del formulario a la clase base.
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            this.ControlAClaseBase(this.ObjetoBase, "Nombre", txtNombre);
            this.ControlAClaseBase(this.ObjetoBase, "Direccion", txtDireccion);
            this.ControlAClaseBase(this.ObjetoBase, "Telefono", txtTelefono);
        }
        /// <summary>
        /// Valida los controles del formulario antes de actualizar la clase base.
        /// </summary>
        /// <returns></returns>
        protected override bool Validar()
        {
            bool rtno = true;
            this.ErrorProvider.Clear();
            if(!Generic.ControlValorado(txtNombre,this.ErrorProvider))
                rtno = false;
            if(!Validacion.EsTelefono(txtTelefono,false))
                rtno=false;
            return rtno;

        }
        #endregion
    }
}
