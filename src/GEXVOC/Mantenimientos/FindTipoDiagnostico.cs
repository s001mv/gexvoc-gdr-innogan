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
    public partial class FindTipoDiagnostico : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindTipoDiagnostico()
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
            
            dtgResultado.Columns.Add("Descripcion", "T.Diagnóstico");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Devuelve los tipos de diagnóstico que cumplan el criterio de busqueda del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoDiagnostico>(TipoDiagnostico.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = TipoDiagnostico.Buscar(txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de tipo de diagnóstico en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoDiagnostico ObjetoBase = new TipoDiagnostico();
            EditTipoDiagnostico editTipoDiagnostico = new EditTipoDiagnostico(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTipoDiagnostico, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de tipo de diagnóstico en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoDiagnostico ObjetoBase = (TipoDiagnostico)this.dtgResultado.CurrentRow.DataBoundItem;
                EditTipoDiagnostico editTipoDiagnostico = new EditTipoDiagnostico(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editTipoDiagnostico, this.dtgResultado);
            }
        }

        #endregion


    }
}
