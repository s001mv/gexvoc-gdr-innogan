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
    public partial class EditCondicionJuridica : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EditCondicionJuridica()
        {
            InitializeComponent();
        }
        public EditCondicionJuridica(Modo modo, CondicionJuridica ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
           
        }

        
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que nos devulve la clase base sobre la que actúa el formulario edit.
        /// </summary>
        public CondicionJuridica objetoBase { get { return (CondicionJuridica)this.ClaseBase; } }

        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }
      
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        /// <summary>
        /// Pasa los valores de la clase base a los controles del formulario.
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.objetoBase, "Descripcion", txtDescripcion);
            
        }
        /// <summary>
        /// Pasa los valores de los controles a la clase base.
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            Generic.ControlAClaseBase(this.objetoBase, "Descripcion", txtDescripcion);
            
        }
        /// <summary>
        /// Validacion de controles se utiliza antes de actualizar la clase base.
        /// </summary>
        /// <returns></returns>
        protected override bool Validar()
        {
            
                bool Rtno = true;
                this.ErrorProvider.Clear();
                if (!Generic.ControlValorado(txtDescripcion,  this.ErrorProvider))
                    Rtno = false;
                return Rtno;

        }
        #endregion
    }
}
