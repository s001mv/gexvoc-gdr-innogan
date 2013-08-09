using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;

namespace GEXVOC.UI
{
    public partial class FindFacilidad : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindFacilidad()
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
            dtgResultado.Columns.Add("Descripcion", "T.Dificultad");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Obtiene todos los tipos de dificultades de parto segun el criterio de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Facilidad>(Facilidad.Buscar(txtDescripcion.Text, null));
            //dtgResultado.DataSource = Facilidad.Buscar(txtDescripcion.Text, null);
        }
        /// <summary>
        /// Lanza el formulario de edición de tipos de dificultad en partos en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Facilidad ObjetoBase = new Facilidad();
            EditFacilidad editFacilidad = new EditFacilidad(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editFacilidad, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de tipos de dificultad en partos en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Facilidad ObjetoBase = (Facilidad)this.dtgResultado.CurrentRow.DataBoundItem;
                EditFacilidad editFacilidad = new EditFacilidad(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editFacilidad, this.dtgResultado);
            }
        }

        #endregion
    }
}
