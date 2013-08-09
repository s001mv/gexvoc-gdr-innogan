using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    public partial class FindTipoAnalisis : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTipoAnalisis()
        {
            InitializeComponent();
        }
        public FindTipoAnalisis(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "Descripción");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoAnalisis>(TipoAnalisis.Buscar(txtTipoAnalisis.Text));
            //dtgResultado.DataSource = TipoAnalisis.Buscar(txtTipoAnalisis.Text) ;
        }
        /// <summary>
        /// Lanza el formulario de edición de TipoAnalisis en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoAnalisis ObjetoBase = new TipoAnalisis();
            this.LanzarFormulario(new EditTipoAnalisis(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TipoAnalisis en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoAnalisis ObjetoBase = (TipoAnalisis)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTipoAnalisis(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion
    }
}
