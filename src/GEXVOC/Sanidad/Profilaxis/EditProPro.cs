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
    public partial class EditProPro : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditProPro()
        {
            InitializeComponent();
        }
        public EditProPro(Modo modo, ProPro ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public ProPro ObjetoBase { get { return (ProPro)this.ClaseBase; } }

        public int? ValorFijoIdTratProfilaxis { get; set; }

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

        #region CARGAS COMUNES
            //protected override void CargarCombos()
            //{
            //    //this.CargarCombo(cmbProducto, Producto.Buscar(Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PROFILAXIS).Id, null, null, null, null,null));
            //}

            protected override void CargarValoresDefecto()
            {
                if (ValorFijoIdTratProfilaxis != null)
                {
                    cmbTratamiento.ClaseActiva = TratProfilaxis.Buscar((int)ValorFijoIdTratProfilaxis);
                    cmbTratamiento.ReadOnly = true;
                }
            }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.cmbTratamiento.TipoDatos = typeof(TratProfilaxis);
                this.cmbProducto.TipoDatos = typeof(Producto);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTratProfilaxis", false, this.cmbTratamiento, lblTratamiento));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdProducto", true, this.cmbProducto, lblProducto));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cantidad", true, this.txtCantidad, lblCantidad));

                base.DefinirListaBinding();
            }

         
        #region COMBOS
            private void cmbProducto_CrearNuevo(object sender, EventArgs e)
            {
                Producto ObjetoBase = new Producto();
                EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
                editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.HIGIENE);


                CrearNuevoElementoCombo(editProducto, sender);
            }

            private void btnBuscarTratamiento_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindTratProfilaxis(Modo.Consultar, cmbTratamiento));
            }

            private void btnBuscarMedicamento_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, this.cmbProducto) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.HIGIENE) });//TRATAMIENTO_PROFILAXIS
            }
        #endregion

          
        //protected override void ClaseBaseAControles()
        //{
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}

        //protected override void ControlesAClaseBase()
        //{

        //    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        //}



        ///// <summary>
        ///// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        ///// </summary>
        ///// <returns>Controles válidos (Si/No)</returns>
        //protected override bool Validar()
        //{
        //    bool Rtno = true;
        //    this.ErrorProvider.Clear();
        //    if (!Generic.ControlValorado(new Control[] { txtDescripcion }, this.ErrorProvider))
        //        Rtno = false;


        //    return Rtno;

        //}

        #endregion
    }
}