using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public partial class FindEnfermedad : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindEnfermedad()
        {
            InitializeComponent();
        }
        public FindEnfermedad(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescTipoEnfermedad", "Tipo");
            dtgResultado.Columns[0].DataPropertyName = "DescTipoEnfermedad";
            dtgResultado.Columns.Add("Descripcion", "Nombre");
            dtgResultado.Columns[1].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Devuelve las enfermedades que cumplen los criterios de busqueda de los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Enfermedad>(Enfermedad.Buscar(Generic.ControlAIntNullable(cmbTipo), txtDescripcion.Text));
            //dtgResultado.DataSource = Enfermedad.Buscar(Generic.ControlAIntNullable(cmbTipo), txtDescripcion.Text);

        }
        /// <summary>
        /// Lanza el formulario de edición de enfermedades en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Enfermedad ObjetoBase = new Enfermedad();
            EditEnfermedad editEnfermedad = new EditEnfermedad(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editEnfermedad, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de enfermedades en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Enfermedad ObjetoBase = (Enfermedad)this.dtgResultado.CurrentRow.DataBoundItem;
                EditEnfermedad editEnfermedad = new EditEnfermedad(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editEnfermedad, this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipo, TipoEnfermedad.Buscar());         
        }

        #endregion
    }
}
