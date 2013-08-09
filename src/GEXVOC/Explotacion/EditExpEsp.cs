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
    public partial class EditExpEsp : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS
            /// <summary>
            /// Constructor por Defecto
            /// </summary>
            public EditExpEsp()
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
            public EditExpEsp(Modo modo, ExpEsp ClaseBase):base(modo, ClaseBase)
            {
                InitializeComponent();
              
            }




        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
        /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
        /// </summary>
            public ExpEsp ObjetoBase { get { return (ExpEsp)this.ClaseBase; } }

            int? _ValorIdExplotacionFijo=null;

            public int? ValorIdExplotacionFijo
            {
                get { return _ValorIdExplotacionFijo; }
                set { _ValorIdExplotacionFijo = value; }
            }

          
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        /// <summary>
        /// Pasa los Valores de la Clase Base a los Controles del Formulario
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Especie", cmbEspecie);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Explotacion", cmbExplotacion);

            //this.cmbEspecie.SelectedItem = this.ObjetoBase.Especie;
            //this.cmbExplotacion.SelectedItem = this.ObjetoBase.Explotacion;                             
      

            //base.ClaseBaseAControles();

        }

        /// <summary>
        /// Pasa los valores de los controles a la Clase Base
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            Generic.ControlAClaseBase(this.ObjetoBase, "IdEspecie", cmbEspecie);
            Generic.ControlAClaseBase(this.ObjetoBase, "IdExplotacion", cmbExplotacion);
              
            //if (cmbEspecie.SelectedValue!=null)
            //    this.ObjetoBase.IdEspecie = (int)cmbEspecie.SelectedValue;
            //if (cmbExplotacion.SelectedValue!=null)
            //    this.ObjetoBase.IdExplotacion = (int)cmbExplotacion.SelectedValue;  

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

            if (!Generic.ControlValorado(new Control[] { cmbEspecie, cmbExplotacion }, this.ErrorProvider))
                Rtno = false;



            return Rtno;
        }
        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga los Valores por defecto del Formulario
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            if (ValorIdExplotacionFijo !=null)
            {
                this.cmbExplotacion.SelectedValue = this.ValorIdExplotacionFijo;
                this.cmbExplotacion.Enabled = false;
            
            }
                

        }

        /// <summary>
        /// Carga los combos del formulario
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbExplotacion, "Nombre", Explotacion.Buscar());
            this.CargarCombo(cmbEspecie,Especie.Buscar());  

        }


        #endregion
    }
}
