using System;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class EditDiagAnimal : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditDiagAnimal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditDiagAnimal(Modo modo, DiagAnimal ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO.
        /// <summary>
        /// Propiedad tipada que nos devuelve la clase base sobre la que actua el formulario.
        /// </summary>
        public DiagAnimal ObjetoBase { get { return (DiagAnimal)this.ClaseBase; } }

        int? _ValorFijoIdAnimal = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdAnimal
        {
            get { return _ValorFijoIdAnimal; }
            set
            {
                if (value != null)
                {
                    this.cmbAnimal.ClaseActiva = Animal.Buscar((int)value);
                    this.cmbAnimal.ReadOnly = true;
                }
                else
                    this.cmbAnimal.ReadOnly = false;

                _ValorFijoIdAnimal = value;
            }
        }
        #endregion

        #region BINDING (Intercambio de datos entre los controles del formulario y la clase base)
        protected override void DefinirListaBinding()
        {
            //Asigno a los controles del tipo ctlBuscarObjeto el tipo de datos que va a contener.
            this.cmbPersonal.TipoDatos = typeof(Veterinario);
            this.cmbAnimal.TipoDatos = typeof(Animal);
            this.cmbEnfermedad.TipoDatos = typeof(Enfermedad);

            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdVeterinario", false, this.cmbPersonal, lblPersonal));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAnimal", true, this.cmbAnimal, lblAnimal));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdEnfermedad", false, this.cmbEnfermedad, lblEnfermedad));            
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecDiagnostico, lblFecDiagnostico));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Diagnostico", false, this.txtDiagnostico, lblDiagnostico));


            base.DefinirListaBinding();
        }

    

        #endregion

        #region CARGAS COMUNES

        /////// <summary>
        /////// Carga los combos del formulario.
        /////// </summary>
        ////protected override void CargarCombos()
        ////{

        ////   // this.CargarCombo(cmbTipoEnfermedad, TipoEnfermedad.Buscar());
        ////    //cmbTipoEnfermedad.DisplayMember = "Descripcion";
        ////    //cmbTipoEnfermedad.ValueMember = "Id";
        ////    //cmbTipoEnfermedad.DataSource = TipoEnfermedad.Buscar();
        ////    //cmbTipoEnfermedad.SelectedIndex = -1;
        ////    //this.CargarCombo(cmbTipoEnfermedad, "Descripcion", "Id", TipoEnfermedad.Buscar());

        ////}
        ///// <summary>
        ///// Carga el combo de enfermedades en función de lo seleccionado en el combo de tipo de enfermedad.
        ///// </summary>
        //private void CargarEnfermedades()
        //{
        //    if (this.cmbTipoEnfermedad.SelectedValue != null)
        //    {
        //        this.CargarCombo(cmbEnfermedad, Enfermedad.Buscar(Generic.ControlAIntNullable(cmbTipoEnfermedad), string.Empty));                
        //    }
        //    else
        //    {               
        //        this.cmbEnfermedad.DataSource = null;
        //        this.cmbEnfermedad.Text = string.Empty;                
        //    }
        //}
        //private void cmbTipoEnfermedad_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    CargarEnfermedades();
        //}



        /// <summary>
        /// Carga los valores por defecto del formulario de edición del diagnóstico del animal.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(this.txtFecDiagnostico, DateTime.Today);
        }

        /// <summary>
        /// Carga el grid de detalle
        /// </summary>
        protected override void CargarGrids()
        {
            this.dtgTratamientos.DataSource = this.ObjetoBase.lstTratEnfermedad;
        }

        #endregion

        #region EVENTOS BOTON
        /// <summary>
        /// Lanza el formulario de busqueda de animales en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
        }
     
      
        


        #endregion

        #region GRID - TRATAMIENTOS

      
            
            private void tsbNuevoTratamiento_Click(object sender, EventArgs e)
            {
                if (ModoActual == Modo.Actualizar)
                {
                    TratEnfermedad ObjCrear = new TratEnfermedad();
                    this.LanzarFormulario(new EditTratEnfermedad(Modo.Guardar, ObjCrear) { ValorFijoIdDiagnostico = this.ObjetoBase.Id,ValorPredeterminadoPersonal=this.ObjetoBase.IdVeterinario }, dtgTratamientos);
                }
            }
            private void tsbModificarTratamiento_Click(object sender, EventArgs e)
            {
                ModificarTratamiento();
            }
            private void ModificarTratamiento()
            {
                TratEnfermedad ObjActualizar = null;
                if (this.dtgTratamientos.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                {
                    ObjActualizar = (TratEnfermedad)this.dtgTratamientos.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditTratEnfermedad(Modo.Actualizar, ObjActualizar) { ValorFijoIdDiagnostico = this.ObjetoBase.Id, ValorPredeterminadoPersonal = this.ObjetoBase.IdVeterinario }, dtgTratamientos);
                }

            
            }
            private void tsbEliminarTratamiento_Click(object sender, EventArgs e)
            {
                this.EliminarObjGrid(this.dtgTratamientos, "Va a eliminar el Tratamiento de la Aplicación.\r¿Esta usted seguro de que desea continuar?");

            }
            private void dtgTratamientos_cellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                ModificarTratamiento();
            }


        #endregion

        #region COMBOS

        private void btnBuscarEnfermedad_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindEnfermedad(Modo.Consultar, this.cmbEnfermedad));
        }

        /// <summary>
        /// Lanza el formulario de busqueda de personal en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, this.cmbPersonal));
        }

        private void cmbPersonal_CrearNuevo(object sender, EventArgs e)
        {
            Veterinario ObjetoBase = new Veterinario();
            EditPersonal editPersonal = new EditPersonal(Modo.Guardar, ObjetoBase);
            //editPersonal.Nombre = e.TextoCrear;

            CrearNuevoElementoCombo(editPersonal, sender);
        }

        private void cmbEnfermedad_CrearNuevo(object sender, EventArgs e)
        {
            
            Enfermedad ObjetoBase = new Enfermedad();
            EditEnfermedad editEnfermedad = new EditEnfermedad(Modo.Guardar, ObjetoBase);
            //editEnfermedad.Descripcion = e.TextoCrear;

            CrearNuevoElementoCombo(editEnfermedad, sender);
            
        }

        #endregion

    }
}
