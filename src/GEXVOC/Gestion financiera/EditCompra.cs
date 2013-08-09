
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
    public partial class EditCompra : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditCompra()
        {
            InitializeComponent();
        }
        public EditCompra(Modo modo, Compra ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Compra ObjetoBase { get { return (Compra)this.ClaseBase; } }
    
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)


        protected override void DefinirListaBinding()
        {
            cmbMacho.TipoDatos = typeof(Animal);
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, cmbTipoProducto, lblTipoProducto));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdProveedor", false, cmbProveedor, lblProveedor));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Importe", false, this.txtImporte, lblImporte));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Concepto", false, this.txtConcepto, lblConcepto));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdProducto", true, this.cmbProducto, lblProducto));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cantidad", true, this.txtCantidad, lblCantidad));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdMacho", false, this.cmbMacho, null));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Pagada", false, this.chkPagado, null));
            //this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdClasificacion", false, this.cmbClasificacionCompra, lblClasificacionCompra));


            base.DefinirListaBinding();
        }

      
        protected override bool Validar()
        {
            bool Rtno = true;
          
            //Validacion adicional del valor requerido para macho en una compra de pajuela
            if (Generic.ControlAIntNullable(cmbFamilia) != null && Generic.ControlAIntNullable(cmbFamilia) == Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.PAJUELA_SEMEN).Id)
                if (!Generic.ControlValorado(cmbMacho, this.ErrorProvider)) Rtno = false;

            if (Rtno)
                Rtno = base.Validar();


            return Rtno;

        }


        private void EditCompra_PropiedadAControl(object sender, PropiedadBindEventArgs e)
        {
            if (e.NombrePropiedad == "IdProducto")
                Generic.IntNullableAControl(cmbFamilia, this.ObjetoBase.DescIdFamilia);

        }
        
        #endregion
        
        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            ////Carga el combo de TipoCompra
            //this.CargarCombo(cmbClasificacionCompra, TipoCompra.Buscar());
            
            //Carga el combo de Tipo Producto
            this.CargarCombo(cmbTipoProducto, TipoProducto.Buscar());


            //Cargo los Proveedores
            cmbProveedor.CargarCombo();
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
        private void cmbFamilia_SelectedValueChanged(object sender, EventArgs e)
        {

            CargarProductos();
            if (cmbFamilia.SelectedValue != null)
            {

                Familia familia = Familia.Buscar(Generic.ControlAInt(cmbFamilia));
                //CargarCombo(this.cmbProducto, familia.lstProductos, true);
                if (familia.Id == Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.PAJUELA_SEMEN).Id)
                {
                    pnlMacho.Visible = true;
                    pnlMacho.Enabled = true;
                    Generic.IntAControl(cmbProducto, Configuracion.ProductoSistema(Configuracion.ProductosSistema.PAJUELA_PROPIA).Id);
                    pnlProducto.Visible = false;
                    pnlProducto.Enabled = false;
                    lblUnidad.Text = "Dosis";

                }
                else
                {
                    pnlProducto.Visible = true;
                    pnlProducto.Enabled = true;

                    pnlMacho.Visible = false;
                    pnlMacho.Enabled = false;

                }


            }


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

        private void btnBuscarMacho_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbMacho) { ValorSexoFijo = Convert.ToChar("M") });
        }

    
        #endregion      

        #region COMBOS

            
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

            private void cmbProveedor_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbProveedor, "Nombre", Configuracion.Explotacion.lstProveedores);
            }
            private void cmbProveedor_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                Proveedor ObjetoBase = new Proveedor();
                EditProveedor editProveedor = new EditProveedor(Modo.Guardar, ObjetoBase);
                editProveedor.Nombre = e.TextoCrear;

                CrearNuevoElementoCombo(editProveedor, sender);            
                
            }

         
      

        #endregion

    }
}
