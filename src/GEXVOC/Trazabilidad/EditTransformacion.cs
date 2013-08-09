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
    public partial class EditTransformacion : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS

            /// <summary>
            /// Constructor por Defecto
            /// </summary>
            public EditTransformacion()
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
            public EditTransformacion(Modo modo, Transformacion ClaseBase) : base(modo, ClaseBase)
            {
                InitializeComponent();
            }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO

            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public Transformacion ObjetoBase { get { return (Transformacion)this.ClaseBase; } }

            public int? Plantilla { get; set; }
            public int? Producto { get; set; }

            private char _Direccion;

            public char Direccion
            {
                get
                {
                    return _Direccion;
                }
                set
                {
                    _Direccion = value;

                    if (value == 'E')
                        this.Text += " entradas";
                    else
                        this.Text += " salidas";
                }
            }
          
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        /// <summary>
        /// Pasa los Valores de la Clase Base a los Controles del Formulario
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.ObjetoBase.Producto, "IdTipo", cmbTipoProducto);
            cmbTipoProducto.Enabled = false;

            Generic.ClaseBaseAcontrol(this.ObjetoBase, "IdProducto", cmbProducto);
            cmbProducto.Enabled = false;

            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Cantidad", txtCantidad);
        }

        /// <summary>
        /// Pasa los valores de los controles a la Clase Base
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            ControlAClaseBase(this.ObjetoBase, "IdProducto", cmbProducto);
            ControlAClaseBase(this.ObjetoBase, "Cantidad", txtCantidad);

            if (this.Plantilla != null)
                this.ObjetoBase.IdPlantilla = this.Plantilla.Value;

            this.ObjetoBase.Direccion = this.Direccion;
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

            if (!Generic.ControlValorado(new Control[] { cmbProducto, txtCantidad }, this.ErrorProvider))
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
            if (Producto != null)
            {
                this.cmbTipoProducto.SelectedValue = Core.Logic.Producto.Buscar(Producto.Value).IdTipo;
                this.cmbProducto.SelectedValue = this.Producto;
                this.cmbProducto.Enabled = false;
            }
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();

            if (cmbTipoProducto.Text != string.Empty)
            {
                lblUnidad.Text = "Kg";

                if ((int)cmbTipoProducto.SelectedValue == Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.HIGIENE).Id ||
                    //(int)cmbTipoProducto.SelectedValue == Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PROFILAXIS).Id ||//TRATAMIENTO_PROFILAXIS
                    (int)cmbTipoProducto.SelectedValue == Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.SANIDAD).Id)
                    lblUnidad.Text = "Unidades";

                if ((int)cmbTipoProducto.SelectedValue == Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.PRODUCCION).Id)//PAJUELA_DE_SEMEN
                    lblUnidad.Text = "Dosis";
            }
        }

        private void CargarProductos()
        {
            if (this.cmbTipoProducto.SelectedValue != null)
                this.CargarCombo(cmbProducto, Core.Logic.Producto.Buscar((int)this.cmbTipoProducto.SelectedValue, null, string.Empty, null, null, null), true);
            else
                this.CargarCombo(cmbProducto, null);
        }

        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipoProducto, "Descripcion", "Id", TipoProducto.Buscar());
        }

        #endregion
    }
}
