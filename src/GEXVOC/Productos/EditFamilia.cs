using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Clases;

namespace GEXVOC.UI
{
    /// <summary>
    /// Formulario de Edición de familias    
    /// </summary>
    public partial class EditFamilia : GEXVOC.UI.GenericEdit
    {

        #region CONTRUCTORES
        public EditFamilia()
        {
            InitializeComponent();
        }
        public EditFamilia(Modo modo, Familia ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            public Familia ObjetoBase { get { return (Familia)this.ClaseBase; } }

            TipoProducto _ValorFijoTipoProducto = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public TipoProducto ValorFijoTipoProducto
            {
                get { return _ValorFijoTipoProducto; }
                set
                {
                    if (value != null)
                    {
                        _ValorFijoTipoProducto = value;
                        this.cmbTipoProducto.ClaseActiva = value;
                        this.cmbTipoProducto.ReadOnly = true;
                        this.Text = "Familia del tipo: " + Cadenas.ToUpperPrimerCaracter(_ValorFijoTipoProducto.Descripcion);
                    }
                    else
                        this.cmbTipoProducto.ReadOnly = false;

                    _ValorFijoTipoProducto = value;
                }
            }


            public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
        {

            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, cmbTipoProducto, lblTipo));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, this.txtDescripcion, lblDescripcion));            

        }
        //private void EditFamilia_PropiedadAControl(object sender, PropiedadBindEventArgs e)
        //{
        //    if (e.Control==cmbTipoProducto)
        //    {
                
        //    }
        //}


        //protected override void ClaseBaseAControles()
        //{
        //    if ()
        //    {
                
        //    }
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Tipo", cmbTipoProducto);
        //}

        //protected override void ControlesAClaseBase()
        //{

        //    Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        //    Generic.ControlAClaseBase(this.ObjetoBase, "IdTipo", cmbTipoProducto);
        //}



        /// <summary>
        /// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        /// </summary>
        /// <returns>Controles válidos (Si/No)</returns>
        //protected override bool Validar()
        //{
        //    bool Rtno = true;
        //    this.ErrorProvider.Clear();
        //    if (!Generic.ControlValorado(new Control[] { cmbTipoProducto,txtDescripcion }, this.ErrorProvider))
        //        Rtno = false;


        //    return Rtno;
        
        //}

        protected override void CargarGrids()
        {
            this.dtgProductos.DataSource = this.ObjetoBase.lstProductos;
            base.CargarGrids();
        }
               

        #endregion

        #region GRID PRODUCTOS
            private void NuevoProducto()
        {
            if (ModoActual == Modo.Actualizar)
            {
                Producto ObjCrear = new Producto();
                this.LanzarFormulario(new EditProducto(Modo.Guardar, ObjCrear) { ValorFijoTipoProducto = this.ValorFijoTipoProducto, ValorFijoIdFamilia = this.ObjetoBase.Id }, dtgProductos);

            }
        }
            private void ModificarProducto()
        {

            if (this.dtgProductos.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
            {

                Producto ObjActualizar = (Producto)this.dtgProductos.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditProducto(Modo.Actualizar, ObjActualizar) { ValorFijoTipoProducto = this.ValorFijoTipoProducto,ValorFijoIdFamilia=this.ObjetoBase.Id }, this.dtgProductos);

            }
        }
            private void tsbNuevoProducto_Click(object sender, EventArgs e)
            {
                NuevoProducto();
            }
            private void tsbModificarProducto_Click(object sender, EventArgs e)
            {
                ModificarProducto();
            }
            private void tsbEliminarProducto_Click(object sender, EventArgs e)
            {
                this.EliminarObjGrid(this.dtgProductos, "Va a eliminar los productos.\r¿Esta usted seguro de que desea continuar?");
            }
            private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                ModificarProducto();
            }
        #endregion            

      
    }
}