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
    public partial class EditProHig : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditProHig()
        {
            InitializeComponent();
        }
        public EditProHig(Modo modo, ProHig ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public ProHig ObjetoBase { get { return (ProHig)this.ClaseBase; } }

        public int? ValorFijoIdTratHigiene { get; set; }
      
        public override void Cargar()
        {
            base.Cargar();           
            if (this.ModoActual == Modo.Actualizar)
            {
                this.cmbTratamiento.ReadOnly = true;
                this.cmbProducto.ReadOnly = true;
            }

        }
        
        #endregion           

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void DefinirListaBinding()
        {
            this.cmbTratamiento.TipoDatos = typeof(TratHigiene);
            this.cmbProducto.TipoDatos = typeof(Producto);
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTratHigiene", false, this.cmbTratamiento, lblTratamiento));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdProducto", true, this.cmbProducto, lblProducto));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cantidad", true, this.txtCantidad, lblCantidad));            

            base.DefinirListaBinding();
        }


        //////protected override void ClaseBaseAControles()
        //////{
        //////    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        //////}

        //////protected override void ControlesAClaseBase()
        //////{

        //////    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        //////}



        ///////// <summary>
        ///////// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        ///////// </summary>
        ///////// <returns>Controles válidos (Si/No)</returns>
        //////protected override bool Validar()
        //////{
        //////    bool Rtno = true;
        //////    this.ErrorProvider.Clear();
        //////    if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider))
        //////        Rtno = false;


        //////    return Rtno;

        //////}

        #endregion

        #region CARGAS COMUNES
        //protected override void CargarCombos()
        //{
        //    this.CargarCombo(cmbProducto,Producto.Buscar(Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_HIGIENE).Id,null,null,null,null,null));
        //}

        protected override void CargarValoresDefecto()
        {
            if (ValorFijoIdTratHigiene!=null)
            {
                cmbTratamiento.ClaseActiva=TratHigiene.Buscar((int)ValorFijoIdTratHigiene);
                cmbTratamiento.ReadOnly = true;
            }
            //if (ValorFijoIdProducto != null)
            //{
            //    Generic.IntAControl(cmbProducto,(int)ValorFijoIdProducto);
            //    //cmbProducto.Enabled = false;
            //}
                
        }

        #endregion

        #region COMBOS
            private void btnBuscarMedicamento_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, this.cmbProducto) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.HIGIENE) });
            }

            private void cmbProducto_CrearNuevo(object sender, EventArgs e)
            {
                Producto ObjetoBase = new Producto();
                EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
                editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.HIGIENE);           


                CrearNuevoElementoCombo(editProducto, sender);
            }

            private void btnBuscarTratamiento_Click(object sender, EventArgs e)
            {
                 this.LanzarFormularioConsulta(new FindTratHigiene(Modo.Consultar,cmbTratamiento));
            }
        #endregion

    }
}