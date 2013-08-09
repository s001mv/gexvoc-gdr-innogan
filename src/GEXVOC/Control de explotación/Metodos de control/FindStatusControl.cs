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
    public partial class FindStatusControl : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindStatusControl()
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
            dtgResultado.Location = new System.Drawing.Point(12, 106);
            dtgResultado.Size = new System.Drawing.Size(610, 309);
            dtgResultado.Columns.Add("Codigo", "Código");
            dtgResultado.Columns[0].DataPropertyName = "Codigo";
            dtgResultado.Columns.Add("Descripcion", "Status");
            dtgResultado.Columns[1].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Obtiene los status control que coinciden con el criterio de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<StatusControl>(StatusControl.Buscar(txtCodigo.Text, txtEntidad.Text));            
        }
        /// <summary>
        /// Lanza el formulario de edición de status control en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            StatusControl ObjetoBase = new StatusControl();
            EditStatusControl editStatusControl = new EditStatusControl(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editStatusControl, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de status control en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                StatusControl ObjetoBase = (StatusControl)this.dtgResultado.CurrentRow.DataBoundItem;
                EditStatusControl editStatusControl = new EditStatusControl(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editStatusControl, this.dtgResultado);
            }
        }
        #endregion
    }
}
