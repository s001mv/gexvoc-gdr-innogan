using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public partial class FindCompra : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindCompra()
        {
            InitializeComponent();
        }
        public FindCompra(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[0].DataPropertyName = "Fecha";
            dtgResultado.Columns.Add("DescTipoProducto", "Tipo");
            dtgResultado.Columns[1].DataPropertyName = "DescTipoProducto";  
            dtgResultado.Columns.Add("DescProducto", "Producto");
            dtgResultado.Columns[2].DataPropertyName = "DescProducto";
            dtgResultado.Columns.Add("Importe", "Importe");
            dtgResultado.Columns[3].DataPropertyName = "Importe";
            dtgResultado.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgResultado.Columns.Add("Concepto", "Concepto");
            dtgResultado.Columns[4].DataPropertyName = "Concepto";
            dtgResultado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtgResultado.Columns.Add("DescPagada", "Pagado");
            dtgResultado.Columns[5].DataPropertyName = "DescPagada";
            
            
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Compra>(Compra.Buscar(null, Generic.ControlAIntNullable(cmbTipoProducto), 
                                       Generic.ControlAIntNullable(cmbProducto), null, Generic.ControlAIntNullable(cmbProveedor), txtConcepto.Text, Generic.ControlAIntNullable(txtCantidad), Generic.ControlADatetimeNullable(txtFechaDesde), 
                                       Generic.ControlADatetimeNullable(txtFechaHasta),Generic.ControlADecimalNullable(txtImporte), Generic.ControlABooleanNullable(cmbPagada)));
            //dtgResultado.DataSource = Compra.Buscar(Configuracion.Explotacion.Id, Generic.ControlAIntNullable(cmbTipoCompra), null, null, null, string.Empty, null, Generic.ControlADatetimeNullable(txtFechaDesde),Generic.ControlADatetimeNullable(txtFechaHasta), null, null);

        }
        /// <summary>
        /// Lanza el formulario de edición de Compra en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Compra ObjetoBase = new Compra();
            this.LanzarFormulario(new EditCompra(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Compra en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                //this.IniciarContextoOperacion();
                Compra ObjetoBase = (Compra)this.dtgResultado.CurrentRow.DataBoundItem;
                //Compra compraStock = null;
                //compraStock = new Compra(ObjetoBase);
                this.LanzarFormulario(new EditCompra(Modo.Actualizar, ObjetoBase), this.dtgResultado);
                //this.FinalizarContextoOperacion(); 
                
               
            }
        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {           
            this.CargarCombo(cmbTipoProducto, TipoProducto.Buscar());
            this.CargarCombo(cmbProveedor,"Nombre",Configuracion.Explotacion.lstProveedores);
            Generic.CargarComboSiNo(cmbPagada);
        }
        #endregion

        #region FUNCIONAMIENTO GENERAL


        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.ErrorProvider.Clear();

            if (Generic.ControlAIntNullable(cmbTipoProducto) != null)
            {
                TipoProducto tipoproducto = TipoProducto.Buscar(Generic.ControlAInt(cmbTipoProducto));
                if (tipoproducto!=null)                
                    this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, this.cmbProducto) { ValorFijoTipoProducto = tipoproducto });
            }
            else
                Generic.PonerError(this.ErrorProvider, cmbProducto, "Para poder desplegar la lista de los productos es necesario especificar el tipo de la compra");

            
        }

        #endregion
    }
}
