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
    public partial class EditTratParcela : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditTratParcela()
        {
            InitializeComponent();
        }
        public EditTratParcela(Modo modo, TratParcela ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que devuelve la clase base sobre la que actua el formulario.
        /// </summary>
        public TratParcela ObjetoBase { get { return (TratParcela)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        /// <summary>
        /// Pasa los valores de la clase base a los controles del formulario.
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            cmbParcela.ClaseActiva = Parcela.Buscar(this.ObjetoBase.IdParcela);
            cmbPlaga.ClaseActiva = Plaga.Buscar(this.ObjetoBase.IdPlaga);
            cmbProducto.ClaseActiva = Producto.Buscar(this.ObjetoBase.IdProducto);             
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Superficie", txtSuperficie);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Caldo", txtCaldo);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Fecha", txtFecha);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Situacion", txtSituacion);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Tipo", txtTipoTratamiento);
        }
        /// <summary>
        /// Pasa los valores de los controles del formulario a la clase base.
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            this.ObjetoBase.IdParcela = Generic.ControlAInt(cmbParcela);
            this.ObjetoBase.IdPlaga = Generic.ControlAInt(cmbPlaga);
            this.ObjetoBase.IdProducto = Generic.ControlAInt(cmbProducto);
            this.ControlAClaseBase(this.ObjetoBase, "Superficie", txtSuperficie);
            this.ControlAClaseBase(this.ObjetoBase, "Caldo", txtCaldo);
            this.ControlAClaseBase(this.ObjetoBase, "Fecha", txtFecha);
            this.ControlAClaseBase(this.ObjetoBase, "Situacion", txtSituacion);
            this.ControlAClaseBase(this.ObjetoBase, "Tipo", txtTipoTratamiento);
           
        }



        /// <summary>
        /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /// </summary>
        /// <returns>Controles válidos (Si/No)</returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(new Control[] { txtTipoTratamiento, txtSituacion,txtFecha,txtCaldo,txtSuperficie,cmbProducto,cmbPlaga,cmbParcela }, this.ErrorProvider))
                Rtno = false;
            //if (!Generic.ControlDatosCorrectos(txtFecha, this.ErrorProvider, "El dato introducido no es de tipo fecha", typeof(System.DateTime), true))
            //    Rtno = false;
            //if (!Generic.ControlDatosCorrectos(txtSuperficie, this.ErrorProvider, "El dato introducido no es de tipo decimal", typeof(System.Decimal), true))
            //    Rtno = false;
            //if (!Generic.ControlDatosCorrectos(txtCaldo, this.ErrorProvider, "El dato introducido no es de tipo decimal", typeof(System.Decimal), true))
            //    Rtno = false;

            return Rtno;

        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga la fecha del sistema por defecto.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFecha, DateTime.Now.Date);
        }
        
        #endregion     

        #region EVENTOS BOTON
        private void btnBuscarParcela_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar, cmbParcela));
        }

        private void btnBuscarPlaga_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindPlaga(Modo.Consultar, cmbPlaga));
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, cmbProducto) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA) });
        }

        #endregion

        #region COMBOS
            private void cmbParcela_CrearNuevo(object sender, EventArgs e)
            {
                Parcela ObjetoBase = new Parcela();
                EditParcela editParcela = new EditParcela(Modo.Guardar, ObjetoBase);
                
                CrearNuevoElementoCombo(editParcela, sender);      
            }

            private void cmbPlaga_CrearNuevo(object sender, EventArgs e)
            {
                
                Plaga ObjetoBase = new Plaga();
                EditPlaga editPlaga = new EditPlaga(Modo.Guardar, ObjetoBase);
             
                CrearNuevoElementoCombo(editPlaga, sender);           

            }

            private void cmbProducto_CrearNuevo(object sender, EventArgs e)
            {
                Producto ObjetoBase = new Producto();
                EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
                editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA);
             
                CrearNuevoElementoCombo(editProducto, sender);
            }
        #endregion
    }
}
