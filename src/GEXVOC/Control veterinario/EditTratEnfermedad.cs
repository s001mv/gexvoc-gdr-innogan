

using System;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Reflection;

namespace GEXVOC.UI
{
    public partial class EditTratEnfermedad : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EditTratEnfermedad()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditTratEnfermedad(Modo modo, TratEnfermedad ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que devuelve la clase base sobre la que trabaja el formulario.
        /// </summary>
        public TratEnfermedad ObjetoBase { get { return (TratEnfermedad)this.ClaseBase; } }

        int? _valorFijoIdDiagnostico = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario de edición de tratamientos debe de aparecer con el combo del diagnostico fijo.
        /// </summary>
        public int? ValorFijoIdDiagnostico
        {
            get { return _valorFijoIdDiagnostico; }
            set
            {
                if (value != null)
                {
                    this.cmbDiagnostico.ClaseActiva = DiagAnimal.Buscar((int)value);
                    this.cmbDiagnostico.ReadOnly = true;

                }
                else
                    this.cmbDiagnostico.ReadOnly = false;
                _valorFijoIdDiagnostico = value;
            }
        }

        int? _ValorPredeterminadoPersonal = null;

        public int? ValorPredeterminadoPersonal
        {
            get { return _ValorPredeterminadoPersonal; }
            set { _ValorPredeterminadoPersonal = value; }
        }


        #endregion

        #region BINDING(Intercambio de datos entre los controles del formulario y la clase base)
            protected override void DefinirListaBinding()
            {

                cmbPersonal.TipoDatos = typeof(Veterinario);
                cmbDiagnostico.TipoDatos = typeof(DiagAnimal);

                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdDiagnostico", true, this.cmbDiagnostico, lblDiagnostico));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdVeterinario", false, this.cmbPersonal, lblPersonal));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecTratamiento, lblFecTratamiento));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "SupresionLeche", false, this.txtSupresionLeche, lblSupresionLeche));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "SupresionCarne", false, this.txtSupresionCarne, lblSupresionCarne));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Detalle", false, this.txtDetalle, lblDetalle));    
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Duracion", true, this.txtDuracion, lblDuracion));
                
                
                base.DefinirListaBinding();
            }     
        #endregion    

        #region CARGAS COMUNES
        /// <summary>
        /// Carga los valores por defecto del formulario.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(this.txtFecTratamiento, DateTime.Now.Date);

            if (ValorPredeterminadoPersonal!=null)            
                cmbPersonal.ClaseActiva = Veterinario.Buscar((int)this.ValorPredeterminadoPersonal);
                
            
        }
        protected override void CargarGrids()
        {
            this.dtgReceta.DataSource = this.ObjetoBase.lstRecetas;
            this.dtgGastos.DataSource = this.ObjetoBase.lstGastos;
        }
        #endregion

        #region GRID - GASTOS




        private void tsbNuevoGasto_Click(object sender, EventArgs e)
        {
            if (ModoActual == Modo.Actualizar)
            {
                Gasto ObjCrear = new Gasto();
                this.LanzarFormulario(new EditGasto(Modo.Guardar, ObjCrear) { ValorFijoIdAnimal = this.ObjetoBase.DescIdAnimal,ValorFijoIdTratamiento=this.ObjetoBase.Id, ValorFijoNaturalezaGasto = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.DIAGNOSTICO_ENFERMEDAD_ANIMAL) }, dtgGastos);
            }

        }
        private void tsbModificarGasto_Click(object sender, EventArgs e)
        {
            ModificarGasto();

        }
        private void ModificarGasto()
        {
            Gasto ObjActualizar = null;
            if (this.dtgGastos.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
            {
                ObjActualizar = (Gasto)this.dtgGastos.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditGasto(Modo.Actualizar, ObjActualizar) { ValorFijoIdAnimal = this.ObjetoBase.DiagAnimal.IdAnimal, ValorFijoIdTratamiento = this.ObjetoBase.Id,ValorFijoNaturalezaGasto = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.DIAGNOSTICO_ENFERMEDAD_ANIMAL) }, dtgGastos);

            }
        }
        private void tsbEliminarGasto_Click(object sender, EventArgs e)
        {
            this.EliminarObjGrid(this.dtgGastos, "Va a eliminar el gasto de la aplicación.\r ¿Esta usted seguro de que desea continuar?");
        }

        private void dtgGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarGasto();
        }

        #endregion

        #region GRID - RECETAS
        private void ModificarReceta()
        {
            Receta ObjActualizar = null;
            if (this.dtgReceta.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
            {
                ObjActualizar = (Receta)this.dtgReceta.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditReceta(Modo.Actualizar, ObjActualizar) { ValorFijoIdTratamiento = this.ObjetoBase.Id}, dtgReceta);

                //Recargo los valores del formulario pues la insercion de recetas puede cambiar automaticamente valores de tratEnfermedad como SupresionLeche, SupresionCarne
                this.ClaseBase = TratEnfermedad.Buscar(this.ObjetoBase.Id);
                this.ClaseBaseAControles();
            }
        }
        private void tsbNuevaReceta_Click(object sender, EventArgs e)
        {
            if (ModoActual == Modo.Actualizar)
            {
                Receta ObjCrear = new Receta();
                this.LanzarFormulario(new EditReceta(Modo.Guardar, ObjCrear) { ValorFijoIdTratamiento = this.ObjetoBase.Id }, dtgReceta);
                //Recargo los valores del formulario pues la insercion de recetas puede cambiar automaticamente valores de tratEnfermedad como SupresionLeche, SupresionCarne
                this.ClaseBase = TratEnfermedad.Buscar(this.ObjetoBase.Id);
                this.ClaseBaseAControles();
            }
        }

        private void tsbModificarReceta_Click(object sender, EventArgs e)
        {
            ModificarReceta();
        }

        private void tsbEliminarReceta_Click(object sender, EventArgs e)
        {
            this.EliminarObjGrid(this.dtgReceta, "Va a eliminar la receta de la aplicación.\r ¿Esta usted seguro de que desea continuar?");
        }

        private void dtgReceta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarReceta();
        }
        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void MostrarFechaSupresion()
            {
                
                    lblHastaLeche.Text = "hasta: ";
                    lblHastaCarne.Text = "hasta: ";
                    DateTime? fechaTratamiento = Generic.ControlADatetimeNullable(txtFecTratamiento);
                    decimal? diasSupresionLeche = Generic.ControlADecimalNullable(txtSupresionLeche);
                    decimal? diasSupresionCarne = Generic.ControlADecimalNullable(txtSupresionCarne);
                    if (fechaTratamiento != null)
                    {
                        if (diasSupresionLeche!=null && diasSupresionLeche>0)
                            lblHastaLeche.Text = "hasta: " + ((DateTime)fechaTratamiento).AddDays((double)diasSupresionLeche).ToShortDateString();
                        
                        if (diasSupresionCarne != null && diasSupresionCarne > 0)
                            lblHastaCarne.Text = "hasta: " + ((DateTime)fechaTratamiento).AddDays((double)diasSupresionCarne).ToShortDateString();
                        
                    
                    
                    }                             
            }
           
        
            private void txtFecTratamiento_TextChanged(object sender, EventArgs e)
            {
                MostrarFechaSupresion();
            }       

            private void txtSupresionLeche_TextChanged(object sender, EventArgs e)
            {
                MostrarFechaSupresion();
            }

            private void txtSupresionCarne_TextChanged(object sender, EventArgs e)
            {
                MostrarFechaSupresion();
            }


            private void btnBuscarDiagnostico_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindDiagAnimal(Modo.Consultar, cmbDiagnostico));
            }

            private void btnBuscarPersonal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, cmbPersonal));
            }

            private void txtFecTratamiento_ValueChanged(object sender, GEXVOC.Core.Controles.ctlFechaEventArgs e)
            {
                MostrarFechaSupresion();
            }

        #endregion

        #region PROPIEDADES PARA PROCESOS
            [ProcesoDescripcion("Edición de Tratamientos - Muestra la pestaña: Gastos", "Economía")]
            public bool _proceso_Economia
            {
                set
                {
                    if (!value) tbcContenido.TabPages.Remove(tbpGastos);

                }
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
