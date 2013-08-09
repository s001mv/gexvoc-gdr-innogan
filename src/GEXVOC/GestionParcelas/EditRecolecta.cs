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
    public partial class EditRecolecta : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditRecolecta()
        {
            InitializeComponent();
        }
        public EditRecolecta(Modo modo, Recolecta ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }

      
        #endregion


        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que nos devuelve la clase base sobre la que actua el formulario edit.
        /// </summary>
        public Recolecta ObjetoBase { get { return (Recolecta)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdParcela", true, this.cmbParcela, lblParcela));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdForraje", true, cmbForraje, lblForraje));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cantidad", true, txtCantidad, lblCantidad));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, txtFecha, lblFecha));
            }
            private void EditRecolecta_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                e.Cancelar = true;
                if (e.Control == cmbForraje)
                    this.cmbForraje.ClaseActiva = Producto.Buscar(this.ObjetoBase.IdForraje);
                else if (e.Control == cmbParcela)
                    this.cmbParcela.ClaseActiva = Parcela.Buscar(this.ObjetoBase.IdParcela);
                else 
                    e.Cancelar = false;
                
            }
        #endregion   

        #region CARGAS COMUNES
        /// <summary>
        /// Carga la fecha del sistema por defecto.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFecha, DateTime.Today);
        }

        #endregion

        #region EVENTOS BOTON

        private void btnBuscarParcela_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar, cmbParcela));

        }
        private void btnBuscarForraje_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, cmbForraje) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.ALIMENTACION) });
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void txtFecha_Leave(object sender, EventArgs e)
            {
                ((TextBox)sender).Text = Generic.FormatearFecha(((TextBox)sender).Text);
            }

        #endregion

        #region COMBOS

            private void cmbParcela_CrearNuevo(object sender, EventArgs e)
            {
                Parcela ObjetoBase = new Parcela();
                EditParcela editParcela = new EditParcela(Modo.Guardar, ObjetoBase);
              

                CrearNuevoElementoCombo(editParcela, sender);          
            }

            private void cmbForraje_CrearNuevo(object sender, EventArgs e)
            {
                Producto ObjetoBase = new Producto();
                EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
                editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.ALIMENTACION);
                
                CrearNuevoElementoCombo(editProducto, sender);
            }

        #endregion
    }
}
