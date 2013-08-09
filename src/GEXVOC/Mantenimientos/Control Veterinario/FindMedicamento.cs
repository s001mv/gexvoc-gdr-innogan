using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public partial class FindMedicamento : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindMedicamento()
        {
            InitializeComponent();
        }

        public FindMedicamento(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera un estilo personalizado del grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "Nombre");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns.Add("SupresionLeche", "Días supresión leche");
            dtgResultado.Columns[1].DataPropertyName = "SupresionLeche";
            dtgResultado.Columns.Add("SupresionCarne", "Días supresión carne");
            dtgResultado.Columns[2].DataPropertyName = "SupresionCarne";
        }
        /// <summary>
        /// Devuelve los medicamentos que coinciden con los criterios de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            dtgResultado.DataSource = Medicamento.Buscar(txtDescripcion.Text);

        }
        /// <summary>
        /// Lanza el formulario de edición de medicamentos en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Medicamento ObjetoBase = new Medicamento();
            EditMedicamento editMedicamento = new EditMedicamento(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editMedicamento, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de medicamentos en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Medicamento ObjetoBase = (Medicamento)this.dtgResultado.CurrentRow.DataBoundItem;
                EditMedicamento editMedicamento = new EditMedicamento(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editMedicamento, this.dtgResultado);
            }
        }

        #endregion
    }
}
