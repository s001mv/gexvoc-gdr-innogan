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
    public partial class EditResena : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditResena()
        {
            InitializeComponent();
        }
        public EditResena(Modo modo, Resena ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Resena ObjetoBase { get { return (Resena)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void DefinirListaBinding()
        {
            cmbAnimal.TipoDatos = typeof(Animal);
            cmbPersonal.TipoDatos = typeof(Veterinario);
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase,"IdAnimal",true,cmbAnimal,lblAnimal));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase,"IdVeterinario",true,cmbPersonal,lblPersonal));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase,"Lugar",false,txtLugar,lblLugar));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase,"Cabeza",false,txtCabeza,lblCabeza));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase,"Cuello",false,txtCuello,lblCuello));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase,"ExtAntIzda",false,txtExtrAntIzda,lblExtAntIzda));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase,"ExtAntDcha",false,txtExtrAntDcha,lblExtrAntDcha));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "ExtPostIzda", false, txtExtrPostIzda, lblExtPostIzda));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "ExtPostDcha", false, txtExtPostDcha, lblExtPostDcha));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Cuerpo", false, txtCuerpo, lblCuerpo));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, txtFecha, lblFecha));
        }

    

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga la fecha de actual por defecto.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFecha, DateTime.Now.Date);
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
        /// <summary>
        /// Lanza el formulario de busqueda de animales en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
        }
        /// <summary>
        /// Lanza el formulario de busqueda de veterinarios en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, this.cmbPersonal));

        }

        #endregion

        #region COMBOS
            private void cmbPersonal_CrearNuevo(object sender, EventArgs e)
            {

                Veterinario ObjetoBase = new Veterinario();
                EditPersonal editPersonal = new EditPersonal(Modo.Guardar, ObjetoBase);            

                CrearNuevoElementoCombo(editPersonal, sender);

            }

        #endregion
    }
}
