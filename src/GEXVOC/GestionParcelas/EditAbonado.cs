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
    public partial class EditAbonado : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditAbonado()
            {
                InitializeComponent();
            }
            public EditAbonado(Modo modo, Abonado ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
            }        

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Abonado ObjetoBase { get { return (Abonado)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            protected override void DefinirListaBinding()
            {
                cmbAbono.TipoDatos = typeof(Producto);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdParcela", true, this.cmbParcela, lblFinca));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cantidad", true, txtCantidad, lblKg));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAbono", true, cmbAbono, lblTipoAbono));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, txtFecha, lblFecha));
                
            }
        #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {

                cmbParcela.CargarCombo();
                
            }
            protected override void CargarValoresDefecto()
            {
                this.txtFecha.Text = DateTime.Now.ToShortDateString();
                base.CargarValoresDefecto();
            }

        #endregion

        #region EVENTOS BOTON
        private void btnBuscarAbono_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, cmbAbono) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA),
                                                                                       ValorFijoIdFamilia=Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.ABONO).Id});
        }
        #endregion
        
        #region COMBOS
        private void cmbParcela_CargarContenido(object sender, EventArgs e)
        {
            this.CargarCombo(cmbParcela, "Nombre", Parcela.Buscar());
        }

        private void cmbParcela_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
        {
            
            Parcela ObjetoBase = new Parcela();
            EditParcela editParcela = new EditParcela(Modo.Guardar, ObjetoBase);
            editParcela.Nombre = e.TextoCrear;

            CrearNuevoElementoCombo(editParcela, sender);            
        }

        private void cmbAbono_CrearNuevo(object sender, EventArgs e)
        {
            Producto ObjetoBase = new Producto();
            EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
            editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA);
            editProducto.ValorFijoIdFamilia = Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.ABONO).Id;
     

            CrearNuevoElementoCombo(editProducto, sender);

        }

        #endregion


    }
}