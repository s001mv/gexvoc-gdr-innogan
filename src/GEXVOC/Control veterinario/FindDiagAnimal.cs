using System;
using GEXVOC.Core.Controles;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class FindDiagAnimal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindDiagAnimal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite lanzar el formulario GenericFind con los datos del propio formulario.
        /// </summary>
        /// <param name="modo"></param>
        /// <param name="controlBusqueda"></param>
        public FindDiagAnimal(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera un estilo personalizado para el grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[0].DataPropertyName = "Fecha";
            dtgResultado.Columns.Add("DescAnimal", "Animal");
            dtgResultado.Columns[1].DataPropertyName = "DescAnimal";
            dtgResultado.Columns.Add("Diagnostico", "Diagnostico");
            dtgResultado.Columns[2].DataPropertyName = "Diagnostico";
            dtgResultado.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Enfermedad", "Enfermedad");
            dtgResultado.Columns[3].DataPropertyName = "DescEnfermedad";
            dtgResultado.Columns.Add("Personal", "Personal");
            dtgResultado.Columns[4].DataPropertyName = "DescPersonal";
        }
        /// <summary>
        /// Obtiene los diagnósticos que cumplen los criterios de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<DiagAnimal>(DiagAnimal.Buscar(Generic.ControlAIntNullable(cmbAnimal), null, 
                                                             Generic.ControlADatetimeNullable(txtFecIniMenor), 
                                                             Generic.ControlADatetimeNullable(txtFecIniMayor),
                                                             Generic.ControlAIntNullable(cmbEnfermedad)));
            //dtgResultado.DataSource = DiagAnimal.Buscar(Generic.ControlAIntNullable(cmbAnimal), null,Generic.ControlADatetimeNullable(txtFecIniMenor), Generic.ControlADatetimeNullable(txtFecIniMayor));
        }
        /// <summary>
        /// Lanza el formulario de edición de diagnóstico de animal en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            DiagAnimal ObjetoBase = new DiagAnimal();
            EditDiagAnimal editDiagAnimal = new EditDiagAnimal(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editDiagAnimal, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de diagnóstico de animal en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                DiagAnimal ObjetoBase = (DiagAnimal)this.dtgResultado.CurrentRow.DataBoundItem;
                EditDiagAnimal editDiagAnimal = new EditDiagAnimal(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editDiagAnimal, this.dtgResultado);
            
            }
        }
        #endregion

        #region EVENTOS BOTON
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
        }
       
        
        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarEnfermedad_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindEnfermedad(Modo.Consultar, this.cmbEnfermedad));
            }
        #endregion

  
    }
}
