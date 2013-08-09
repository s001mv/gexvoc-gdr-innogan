using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Controles;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditProvincia : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditProvincia()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar un formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario Edit</param>
        /// <param name="ClaseBase">Clase Base sobre la que actua el formulario Edit</param>
        public EditProvincia(Modo modo, Provincia ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el formulario Edit.
        /// </summary>
        public Provincia ObjetoBase { get { return (Provincia)this.ClaseBase; } }

        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        /// <summary>
        /// Pasa los valores de la Clase Base a los Controles del Formulario.
        /// </summary>
        protected override void ClaseBaseAControles()
        {
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Codigo", txtCodigo);
            Generic.ClaseBaseAcontrol(this.ObjetoBase, "Descripcion", txtDescripcion);
        }
        /// <summary>
        /// Pasa los valores de los controles del formulario a la Clase Base.
        /// </summary>
        protected override void ControlesAClaseBase()
        {
            Generic.ControlAClaseBase(this.ObjetoBase, "Codigo", txtCodigo);
            Generic.ControlAClaseBase(this.ObjetoBase, "Descripcion", txtDescripcion);
        }
        /// <summary>
        /// Validación de controles se realiza la validacion antes de pasar los datos a la Clase Base. 
        /// Si la validación retorna false no se actualizan los datos.
        /// </summary>
        /// <returns></returns>
        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();
            if (!Generic.ControlValorado(new Control [] {txtDescripcion,txtCodigo}, this.ErrorProvider)) 
                Rtno = false;
            if (!Validacion.EsCodigo(this.txtCodigo, 2, true, ErrorProvider))
                Rtno = false;
            return Rtno;

        }
    
        

        #endregion

        #region CARGAS COMUNES
            protected override void CargarGrids()
            {
                this.dtgMunicipio.DataSource = this.ObjetoBase.lstMunicipio;
                base.CargarGrids();
            }

        #endregion

        #region GRID - MUNICIPIOS
            private void NuevoMunicipio()
            {
                if (ModoActual == Modo.Actualizar)
                {
                    Municipio ObjCrear = new Municipio();
                    this.LanzarFormulario(new EditMunicipios(Modo.Guardar, ObjCrear) { ValorFijoIdProvincia = this.ObjetoBase.Id }, dtgMunicipio);

                }
            }
            private void ModificarMunicipio()
            {

                if (this.dtgMunicipio.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                {

                    Municipio ObjActualizar = (Municipio)this.dtgMunicipio.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditMunicipios(Modo.Actualizar, ObjActualizar) { ValorFijoIdProvincia = this.ObjetoBase.Id }, this.dtgMunicipio);

                }
            }
            private void tsbNuevoMunicipio_Click(object sender, EventArgs e)
            {
                NuevoMunicipio();
            }
            private void tsbModificarMunicipio_Click(object sender, EventArgs e)
            {
                ModificarMunicipio();
            }
            private void tsbEliminarMunicipio_Click(object sender, EventArgs e)
            {
                this.EliminarObjGrid(this.dtgMunicipio, "Va a eliminar el municipio.\r¿Esta usted seguro de que desea continuar?");
            }
            private void dtgMunicipio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                ModificarMunicipio();
            }
        #endregion



    }
}
