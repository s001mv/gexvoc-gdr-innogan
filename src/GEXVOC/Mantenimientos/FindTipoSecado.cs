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
    public partial class FindTipoSecado : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindTipoSecado()
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo personalizado del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "T.Secado");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Obtiene los tipos de secado según los criterios de busqueda del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoSecado>(TipoSecado.Buscar(txtDescripcion.Text, null));
            //dtgResultado.DataSource = TipoSecado.Buscar(txtDescripcion.Text,null);
        }
        /// <summary>
        /// Lanza el formulario de edicion de tipo de secado en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoSecado ObjetoBase = new TipoSecado();
            EditTipoSecado editTipoSecado = new EditTipoSecado(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTipoSecado, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edicion de tipo de secado en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoSecado ObjetoBase = (TipoSecado)this.dtgResultado.CurrentRow.DataBoundItem;
                EditTipoSecado editTipoSecado = new EditTipoSecado(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editTipoSecado, this.dtgResultado);

            }
        }
        #endregion
    }
}
