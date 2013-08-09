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
    public partial class FindTipoAlta : GEXVOC.UI.GenericFind
    {

        #region CONSTRUCTORES
            public FindTipoAlta()
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
            dtgResultado.Columns.Add("Descripcion","T.Alta");
            dtgResultado.Columns[0].DataPropertyName="Descripcion";                
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoAlta>(TipoAlta.Buscar(txtDescripcion.Text, null));
            //dtgResultado.DataSource = TipoAlta.Buscar(txtDescripcion.Text,null);
        }
        /// <summary>
        /// Lanza el formulario de edición de altas en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoAlta ObjetoBase = new TipoAlta();
            EditTipoAlta editTipoAlta = new EditTipoAlta(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTipoAlta, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edicion de altas en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoAlta ObjetoBase = (TipoAlta)this.dtgResultado.CurrentRow.DataBoundItem;
                EditTipoAlta formEditTipoAlta = new EditTipoAlta(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(formEditTipoAlta, this.dtgResultado);
            }
        }

        #endregion

    }
}
