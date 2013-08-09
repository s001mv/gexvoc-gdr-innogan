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
    public partial class FindConformacion : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindConformacion()
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo personalizado del grid
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "Conformación");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Obtiene todas las conformaciones que cumplen los criterios de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Conformacion>(Conformacion.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = Conformacion.Buscar(txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de conformacion en modo guardar.
        /// </summary>

        protected override void Insertar()
        {
            Conformacion ObjetoBase = new Conformacion();
            EditConformacion editConformacion = new EditConformacion(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editConformacion, this.dtgResultado);

        }
        /// <summary>
        /// Lanza el formulario de edición de conformación en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Conformacion ObjetoBase = (Conformacion)this.dtgResultado.CurrentRow.DataBoundItem;
             EditConformacion editConformacion = new EditConformacion(Modo.Actualizar, ObjetoBase);
             this.LanzarFormulario(editConformacion, this.dtgResultado);

            }
        }

        #endregion
    }
}
