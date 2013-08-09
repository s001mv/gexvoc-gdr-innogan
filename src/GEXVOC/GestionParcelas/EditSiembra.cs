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
    public partial class EditSiembra : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditSiembra()
        {
            InitializeComponent();
        }
        public EditSiembra(Modo modo, Siembra ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }

   

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Siembra ObjetoBase { get { return (Siembra)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdParcela", true, this.cmbParcela, lblParcela));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdSemilla", true, cmbSemilla, lblSemilla));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cantidad", true, txtCantidad, lblCantidad));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, txtFecha, lblFecha));
            }
            private void EditSiembra_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control == cmbParcela)
                {
                    cmbParcela.ClaseActiva = Parcela.Buscar(this.ObjetoBase.IdParcela);
                    e.Cancelar = true;
                }
                if (e.Control == cmbSemilla)
                {
                    cmbSemilla.ClaseActiva = Producto.Buscar(this.ObjetoBase.IdSemilla);
                    e.Cancelar = true;
                }
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
        /// <summary>
        /// Lanza el formulario de busqueda de parcela en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarParcela_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar, cmbParcela));

        }
        /// <summary>
        /// Lanza el formulario de busqueda de semilla en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarSemilla_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, cmbSemilla) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA),
                                                                                         ValorFijoIdFamilia=Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.SEMILLA).Id});
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

            private void cmbSemilla_CrearNuevo(object sender, EventArgs e)
            {
                Producto ObjetoBase = new Producto();
                EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
                editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA);
                editProducto.ValorFijoIdFamilia = Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.SEMILLA).Id;


                CrearNuevoElementoCombo(editProducto, sender);

            }
        #endregion
       
    }
}
