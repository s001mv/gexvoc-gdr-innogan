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
    public partial class FindMaquinaria : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES

        public FindMaquinaria()
        {
            InitializeComponent();
        }

        #endregion

        #region FUNCIONES SOBREESCRITAS

        /// <summary>
        /// Genera un estilo propio para el Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "Maquinaria");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns.Add("Detalle", "Descripción");
            dtgResultado.Columns[1].DataPropertyName = "Detalle";
        }

        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            dtgResultado.DataSource = Maquinaria.Buscar(txtDescripcion.Text);
        }

        /// <summary>
        /// Lanza el formulario de edición de altas en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Maquinaria ObjetoBase = new Maquinaria();
            EditMaquinaria editMaquinaria = new EditMaquinaria(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editMaquinaria, this.dtgResultado);
        }

        /// <summary>
        /// Lanza el formulario de edicion de altas en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Maquinaria ObjetoBase = (Maquinaria)this.dtgResultado.CurrentRow.DataBoundItem;
                EditMaquinaria formEditMaquinaria = new EditMaquinaria(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(formEditMaquinaria, this.dtgResultado);
            }
        }

        #endregion
    }
}
