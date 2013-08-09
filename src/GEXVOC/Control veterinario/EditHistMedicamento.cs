using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core;

namespace GEXVOC.UI
{
    public partial class EditHistMedicamento : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditHistMedicamento()
        {
            InitializeComponent();
        }
        public EditHistMedicamento(Modo modo, HistMedicamento ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public HistMedicamento ObjetoBase { get { return (HistMedicamento)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)


        protected override void DefinirListaBinding()
        {
            this.cmbMedicamento.TipoDatos = typeof(Producto);
            this.cmbEnfermedad.TipoDatos = typeof(Enfermedad);
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdEspecie", true, this.cmbEspecie, lblEspecie));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdEnfermedad", true, this.cmbEnfermedad, lblEnfermedad));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdMedicamento", true, this.cmbMedicamento, lblMedicamento));
            
            base.DefinirListaBinding();
        }            
        #endregion

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            this.CargarCombo(this.cmbEspecie, Configuracion.Explotacion.lstEspecies, true);

            base.CargarCombos();
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarEnfermedad_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindEnfermedad(Modo.Consultar, this.cmbEnfermedad));
            }

            private void btnBuscarMedicamento_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, this.cmbMedicamento) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.SANIDAD) });
            }

        #endregion

        #region COMBOS
            private void cmbEnfermedad_CrearNuevo(object sender, EventArgs e)
            {
                
                Enfermedad ObjetoBase = new Enfermedad();
                EditEnfermedad editEnfermedad = new EditEnfermedad(Modo.Guardar, ObjetoBase);           

                CrearNuevoElementoCombo(editEnfermedad, sender);             
            }

            private void cmbMedicamento_CrearNuevo(object sender, EventArgs e)
            {


                Producto ObjetoBase = new Producto();
                EditProducto editProducto = new EditProducto(Modo.Guardar, ObjetoBase);
                editProducto.ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.SANIDAD);
    
                CrearNuevoElementoCombo(editProducto, sender);               

            }

        #endregion
    }
}