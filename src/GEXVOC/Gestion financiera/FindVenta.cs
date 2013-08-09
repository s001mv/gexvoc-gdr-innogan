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
    public partial class FindVenta : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindVenta()
        {
            InitializeComponent();
        }
        public FindVenta(Modo modo, ctlBuscarObjeto controlBusqueda)
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

            dtgResultado.Columns.Add("DescCobrada", "Cobrado");
            dtgResultado.Columns[5].DataPropertyName = "DescCobrada";


        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Venta>(Venta.Buscar(null, Generic.ControlAIntNullable(cmbTipoProducto),
                                       Generic.ControlAIntNullable(cmbProducto), Generic.ControlAIntNullable(cmbCliente), txtConcepto.Text, Generic.ControlAIntNullable(txtCantidad), Generic.ControlADatetimeNullable(txtFechaDesde),
                                       Generic.ControlADatetimeNullable(txtFechaHasta), Generic.ControlADecimalNullable(txtImporte), Generic.ControlABooleanNullable(cmbPagada)));
            

        }
        /// <summary>
        /// Lanza el formulario de edición de Compra en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Venta ObjetoBase = new Venta();
            this.LanzarFormulario(new EditVenta(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Compra en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {               
                Venta ObjetoBase = (Venta)this.dtgResultado.CurrentRow.DataBoundItem;               
                this.LanzarFormulario(new EditVenta(Modo.Actualizar, ObjetoBase), this.dtgResultado);  
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
            this.CargarCombo(cmbCliente, "Nombre", Configuracion.Explotacion.lstClientes);
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
                if (tipoproducto != null)
                    this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, this.cmbProducto) { ValorFijoTipoProducto = tipoproducto });
            }
            else
                Generic.PonerError(this.ErrorProvider, cmbProducto, "Para poder desplegar la lista de los productos es necesario especificar el tipo de la compra");


        }

        #endregion

    }
}
