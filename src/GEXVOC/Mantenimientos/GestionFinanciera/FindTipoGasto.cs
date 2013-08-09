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
    public partial class FindTipoGasto : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindTipoGasto()
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
            dtgResultado.Columns.Add("Descripcion", "T.Gasto");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Obtiene los tipos de gasto que cumplen los criterios de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            dtgResultado.DataSource = TipoGasto.Buscar(txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de tipos de gasto en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoGasto ObjetoBase = new TipoGasto();
            EditTipoGasto editTipoGasto = new EditTipoGasto(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTipoGasto, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de tipos de gasto en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoGasto ObjetoBase = (TipoGasto)dtgResultado.CurrentRow.DataBoundItem;
                EditTipoGasto editTipoGasto = new EditTipoGasto(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editTipoGasto, this.dtgResultado);
            
            }

        }
        #endregion
    }
}
