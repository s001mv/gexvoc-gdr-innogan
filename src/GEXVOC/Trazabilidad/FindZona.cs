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
    public partial class FindZona : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES

        public FindZona()
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
            dtgResultado.Columns.Add("Descripcion", "Zona");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns.Add("Detalle", "Descripción");
            dtgResultado.Columns[1].DataPropertyName = "Detalle";
        }

        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            dtgResultado.DataSource = Zona.Buscar(txtDescripcion.Text);
        }

        /// <summary>
        /// Lanza el formulario de edición de altas en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Zona ObjetoBase = new Zona();
            EditZona editZona = new EditZona(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editZona, this.dtgResultado);
        }

        /// <summary>
        /// Lanza el formulario de edicion de altas en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Zona ObjetoBase = (Zona)this.dtgResultado.CurrentRow.DataBoundItem;
                EditZona formEditZona = new EditZona(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(formEditZona, this.dtgResultado);
            }
        }

        #endregion
    }
}
