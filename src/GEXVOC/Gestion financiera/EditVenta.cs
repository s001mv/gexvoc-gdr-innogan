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
    public partial class EditVenta : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditVenta()
        {
            InitializeComponent();
        }
        public EditVenta(Modo modo, Venta ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Venta ObjetoBase { get { return (Venta)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)


        protected override void DefinirListaBinding()
        {
           
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, cmbTipoProducto, lblTipoProducto));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdCliente", false, cmbCliente, lblCliente));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Importe", false, this.txtImporte, lblImporte));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Concepto", false, this.txtConcepto, lblConcepto));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdProducto", true, this.cmbProducto, lblProducto));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cantidad", true, this.txtCantidad, lblCantidad));
            
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cobrada", false, this.chkCobrado, null));
            //this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdClasificacion", false, this.cmbClasificacionCompra, lblClasificacionCompra));


            base.DefinirListaBinding();
        }




        private void EditVenta_PropiedadAControl(object sender, PropiedadBindEventArgs e)
        {
            if (e.NombrePropiedad == "IdProducto")
                Generic.IntNullableAControl(cmbFamilia, this.ObjetoBase.DescIdFamilia);

        }
        
        #endregion
        
        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
         
            this.CargarCombo(cmbTipoProducto, TipoProducto.Buscar());


            //Cargo los Clientes
            this.cmbCliente.CargarCombo();
        }       
    
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFecha, DateTime.Today);
        }

        #region Carga de Familias y Productos - Funcionamiento dependiente del valor seleccionado en Tipos de Productos
        /// <summary>
        /// switch q nos indica si cargar o no productos (se utiliza para no llamar mas de una vez a cargar productos si no es necesario)
        /// </summary>
        bool CargaBloqueada = false;
        void CargarProductos()
        {
            if (!CargaBloqueada)
            {
                List<Producto> lstProductos = null;
                if (cmbTipoProducto.SelectedValue != null)
                {
                    if (cmbFamilia.SelectedValue != null)//Cargo los productos asociados a la familia.
                    {
                        Familia familia = Familia.Buscar(Generic.ControlAInt(cmbFamilia));
                        lstProductos = familia.lstProductos;
                    }
                    else//Cargo los productos asociados a tipo de producto
                    {
                        TipoProducto tipoSeleccionado = TipoProducto.Buscar(Generic.ControlAInt(cmbTipoProducto));
                        lstProductos = tipoSeleccionado.lstProductos;
                    }
                }
                else
                {
                    this.cmbFamilia.Text = string.Empty;
                    this.cmbFamilia.DataSource = null;
                }
                this.cmbProducto.Text = string.Empty;
                this.cmbProducto.DataSource = null;
                CargarCombo(this.cmbProducto, lstProductos, true);
            }
        }
        private void CargarFamilias()
        {
            if (cmbTipoProducto.SelectedValue != null)
            {
                TipoProducto tipoSeleccionado = TipoProducto.Buscar(Generic.ControlAInt(cmbTipoProducto));

                if (tipoSeleccionado != null)
                {

                    if (tipoSeleccionado.Familia ?? false)
                    {//Si el tipo tiene familias
                        CargarCombo(this.cmbFamilia, tipoSeleccionado.lstFamilias);
                        cmbFamilia.Enabled = true;
                    }
                    else
                        cmbFamilia.Enabled = false;
                }
            }
            else
            {
                this.cmbFamilia.DataSource = null;
                this.cmbProducto.DataSource = null;
            }
        }
        private void cmbTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarFamilias();
                Application.DoEvents();
                CargarProductos();
                CargaBloqueada = true;



                if (cmbTipoProducto.SelectedValue != null)
                {
                    TipoProducto tipoSeleccionado = TipoProducto.Buscar(Generic.ControlAInt(cmbTipoProducto));
                    lblUnidad.Text = "Kg";

                }
            }
            finally
            {
                CargaBloqueada = false;

            }
        }
        private void cmbFamilia_SelectedValueChanged(object sender, EventArgs e)
        {

            CargarProductos();          

        }
        private void cmbFamilia_TextUpdate(object sender, EventArgs e)
        {
            if (cmbFamilia.Text == string.Empty)
            {
                cmbFamilia.SelectedIndex = -1;
                //Validate(true);            
                //CargarProductos();
            }

        }
        private void cmbTipoProducto_TextUpdate(object sender, EventArgs e)
        {
            if (cmbTipoProducto.Text == string.Empty)
            {
                cmbTipoProducto.SelectedIndex = -1;

            }

        }
        #endregion

      

      

        #endregion        

        #region EVENTOS BOTON
        ///// <summary>
        ///// Lanza el formulario de busqueda de explotación en modo consulta.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnBuscarExplotacion_Click(object sender, EventArgs e)
        //{
        //    this.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, cmbExplotacion));
        //}
        /// <summary>
        /// Lanza el formulario de busqueda de proveedor en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnProveedor_Click(object sender, EventArgs e)
        //{
        //    this.LanzarFormularioConsulta(new FindProveedor(Modo.Consultar, cmbProveedor));
        //}

        //private void txtFecha_Leave(object sender, EventArgs e)
        //{
        //    ((TextBox)sender).Text = Generic.FormatearFecha(((TextBox)sender).Text);

        //}

       
    
        #endregion      

        #region COMBOS
            private void cmbCliente_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbCliente, "Nombre", Configuracion.Explotacion.lstClientes);
            }
            private void cmbCliente_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                Cliente ObjetoBase = new Cliente();
                EditCliente editCliente = new EditCliente(Modo.Guardar, ObjetoBase);
                editCliente.Nombre = e.TextoCrear;
                CrearNuevoElementoCombo(editCliente, sender);               
            }


            private void cmbProducto_CargarContenido(object sender, EventArgs e)
            {
                CargarProductos();
            }
            private void cmbProducto_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                Generic.PonerError(this.ErrorProvider, cmbProducto, string.Empty);
                int? IdTipoProducto = Generic.ControlAIntNullable(cmbTipoProducto);
                if (IdTipoProducto.HasValue)
                {

                    Producto ObjetoBase = new Producto();
                    EditProducto edit = new EditProducto(Modo.Guardar, ObjetoBase);
                    edit.ValorFijoTipoProducto = TipoProducto.Buscar((int)IdTipoProducto);
                    edit.ValorFijoIdFamilia = Generic.ControlAIntNullable(cmbFamilia);
                    edit.Descripcion = e.TextoCrear;

                    CrearNuevoElementoCombo(edit, sender);
                }
                else
                    Generic.PonerError(this.ErrorProvider, cmbProducto, "Para poder crear un Producto es necesario tener seleccionado el tipo de compra.");

            }

            private void cmbFamilia_CargarContenido(object sender, EventArgs e)
            {
                CargarFamilias();
            }
            private void cmbFamilia_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                Generic.PonerError(this.ErrorProvider, cmbFamilia, string.Empty);

                int? IdTipoProducto = Generic.ControlAIntNullable(cmbTipoProducto);
                if (IdTipoProducto.HasValue)
                {
                    Familia ObjetoBase = new Familia();
                    EditFamilia edit = new EditFamilia(Modo.Guardar, ObjetoBase);
                    edit.ValorFijoTipoProducto = TipoProducto.Buscar((int)IdTipoProducto);
                    edit.Descripcion = e.TextoCrear;

                    CrearNuevoElementoCombo(edit, sender);
                }
                else
                    Generic.PonerError(this.ErrorProvider, cmbFamilia, "Para poder crear una Famila es necesario tener seleccionado el tipo de compra.");

            }


        #endregion      
    }
}