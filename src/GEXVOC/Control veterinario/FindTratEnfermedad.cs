using System;
using GEXVOC.Core.Controles;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class FindTratEnfermedad : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindTratEnfermedad()
        {
            InitializeComponent();
        }
        public FindTratEnfermedad(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }

        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo personalizado del grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[0].DataPropertyName = "Fecha";
            dtgResultado.Columns.Add("DescAnimal", "Animal");
            dtgResultado.Columns[1].DataPropertyName = "DescAnimal";         
            dtgResultado.Columns.Add("Detalle", "Detalle");
            dtgResultado.Columns[2].DataPropertyName = "Detalle";          
            dtgResultado.Columns.Add("Duracion", "Duración");
            dtgResultado.Columns[3].DataPropertyName = "Duracion";
            dtgResultado.Columns.Add("Personal", "Personal");
            dtgResultado.Columns[4].DataPropertyName = "DescPersonal";
        }
        /// <summary>
        /// Devuelve los tratamientos de enfermedad que cumplen con los criterios de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TratEnfermedad>(TratEnfermedad.Buscar(Generic.ControlAIntNullable(cmbAnimal),null,  string.Empty,
                                               null, null, null, Generic.ControlADatetimeNullable(txtFecIniMenor), 
                                               Generic.ControlADatetimeNullable(txtFecIniMayor), null));
            //dtgResultado.DataSource = TratEnfermedad.Buscar(Generic.ControlAIntNullable(cmbAnimal),null,  string.Empty, null, null, null, Generic.ControlADatetimeNullable(txtFecIniMenor), Generic.ControlADatetimeNullable(txtFecIniMayor), null);
        }
        /// <summary>
        /// Lanza el formulario de edición de tratamiento de enfermedad en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TratEnfermedad ObjetoBase = new TratEnfermedad();
            EditTratEnfermedad editTratamiento = new EditTratEnfermedad(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTratamiento, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de tratamiento de enfermedad en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TratEnfermedad ObjetoBase = (TratEnfermedad)this.dtgResultado.CurrentRow.DataBoundItem;
                EditTratEnfermedad editTratamiento = new EditTratEnfermedad(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editTratamiento, this.dtgResultado);
            }
        }

        #endregion

        #region EVENTO BOTON
        /// <summary>
        /// Lanza el formulario de busqueda de animales en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));

        }

        #endregion


    }
}
