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
    public partial class FindStatusOrdeno : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindStatusOrdeno()
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
            dtgResultado.Columns.Add("Descripcion", "Status");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            

        }
        /// <summary>
        /// Obtiene los status ordeño que cumplen los criterios de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<StatusOrdeno>(StatusOrdeno.Buscar(txtDescripcion.Text));
           // dtgResultado.DataSource = StatusOrdeno.Buscar(txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario edit de Status Ordeño en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            StatusOrdeno ObjetoBase = new StatusOrdeno();
            EditStatusOrdeno editStatusOrdeno = new EditStatusOrdeno(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editStatusOrdeno, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edit de status ordeño en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                StatusOrdeno ObjetoBase = (StatusOrdeno)this.dtgResultado.CurrentRow.DataBoundItem;
                EditStatusOrdeno editStatusOrdeno = new EditStatusOrdeno(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editStatusOrdeno, this.dtgResultado);

            }
        }

        #endregion
    }
}
