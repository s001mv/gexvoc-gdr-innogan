using System;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GEXVOC.UI
{
    public partial class EditReceta : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditReceta()
        {
            InitializeComponent();
        }
        public EditReceta(Modo modo, Receta ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Receta ObjetoBase { get { return (Receta)this.ClaseBase; } }

            int? _valorFijoIdTratamiento = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario de edición de tratamientos debe de aparecer con el combo del Tratamiento fijo.
            /// </summary>
            public int? ValorFijoIdTratamiento
            {
                get { return _valorFijoIdTratamiento; }
                set
                {
                    if (value != null)
                    {
                        this.cmbTratamiento.ClaseActiva = TratEnfermedad.Buscar((int)value);
                        this.cmbTratamiento.ReadOnly = true;

                    }
                    else
                        this.cmbTratamiento.ReadOnly = false;
                    _valorFijoIdTratamiento = value;
                }
            }

            //int? _valorFijoIdMedicamento = null;
            ///// <summary>
            ///// Propiedad que nos indica si el formulario de edición de Medicamentos debe de aparecer con el combo del Medicamento fijo.
            ///// </summary>
            //public int? ValorFijoIdMedicamento
            //{
            //    get { return _valorFijoIdMedicamento; }
            //    set
            //    {
            //        if (value != null)
            //        {
            //            this.cmbMedicamento.ClaseActiva = Producto.Buscar((int)value);
            //            this.cmbMedicamento.ReadOnly = true;

            //        }
            //        else
            //            this.cmbMedicamento.ReadOnly = false;
            //        _valorFijoIdMedicamento = value;
            //    }
            //}
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.cmbMedicamento.TipoDatos = typeof(Producto);
                this.cmbTratamiento.TipoDatos = typeof(TratEnfermedad);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTratamiento", true, this.cmbTratamiento, lblTratamiento));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdMedicamento", true, this.cmbMedicamento, lblMedicamento));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Dosis", false, this.txtDosis, lblDosis));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Duracion", true, this.txtDuracion, lblDuracion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Importe", false, this.txtImporte, lblImporte));
                

                base.DefinirListaBinding();
            }
        #endregion

        #region CARGAS COMUNES
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(txtFecha, DateTime.Today);
                base.CargarValoresDefecto();
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarMedicamento_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, this.cmbMedicamento) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.SANIDAD) });
            }
            private void cmbTratamiento_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                //if (e.ClaseActiva != null)
                //{
                //    List<Producto> lstProductos = null;
                //    TratEnfermedad tratamiento = (TratEnfermedad)e.ClaseActiva;
                //    if (tratamiento.DescIdEnfermedad != null)
                //        lstProductos = HistMedicamento.BuscarMedicamento((int)tratamiento.DescIdEnfermedad);



                //    this.CargarCombo(this.cmbMedicamentosSugeridos, lstProductos);

                //}
                //else
                //{
                //    cmbMedicamentosSugeridos.SelectedIndex = -1;
                //    cmbMedicamentosSugeridos.Items.Clear();
                //    cmbMedicamentosSugeridos.Text = string.Empty;

                //}
                cmbMedicamentosSugeridos.CargarCombo();

            }
            private void cmbMedicamento_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                if (e.ClaseActiva != null)
                {
                    cmbMedicamentosSugeridos.Enabled = false;
                    cmbMedicamentosSugeridos.Visible = false;
                }
                else
                {
                    cmbMedicamentosSugeridos.SelectedIndex = -1;
                    cmbMedicamentosSugeridos.Enabled = true;
                    cmbMedicamentosSugeridos.Visible = true;

                    cmbMedicamentosSugeridos.Focus();
                }
                

            }
            private void cmbMedicamentosSugeridos_Validated(object sender, EventArgs e)
            {
                if (cmbMedicamentosSugeridos.SelectedValue != null)
                    cmbMedicamento.ClaseActiva = Producto.Buscar((int)cmbMedicamentosSugeridos.SelectedValue);


            }
        #endregion

        #region COMBOS
            private void cmbMedicamentosSugeridos_CargarContenido(object sender, EventArgs e)
            {
                TratEnfermedad tratamiento = (TratEnfermedad)cmbTratamiento.ClaseActiva;

                if (tratamiento != null)
                {
                    List<Producto> lstProductos = null;
                    
                    if (tratamiento.DescIdEnfermedad != null)
                        lstProductos = HistMedicamento.BuscarMedicamento((int)tratamiento.DescIdEnfermedad);

                    
                    this.CargarCombo(this.cmbMedicamentosSugeridos, lstProductos);

                }
                else
                {
                    cmbMedicamentosSugeridos.SelectedIndex = -1;
                    cmbMedicamentosSugeridos.Items.Clear();
                    cmbMedicamentosSugeridos.Text = string.Empty;

                }
            }
            private void cmbMedicamentosSugeridos_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                Producto ObjetoBase = new Producto();
                EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
                editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.SANIDAD);
                editProducto.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editProducto, sender);

                cmbMedicamento.ClaseActiva = editProducto.ClaseBase;
           
            }

 
        #endregion
           
    }
}