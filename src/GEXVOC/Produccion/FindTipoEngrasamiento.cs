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
    public partial class FindTipoEngrasamiento : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
            public FindTipoEngrasamiento()
            {
                InitializeComponent();
            }
            public FindTipoEngrasamiento(Modo modo, ctlBuscarObjeto controlBusqueda)
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
                dtgResultado.Columns.Add("Descripcion", "Descripcion");
                dtgResultado.Columns[0].DataPropertyName = "descripcion";
                dtgResultado.Columns.Add("Detalle", "Detalle");
                dtgResultado.Columns[1].DataPropertyName = "Detalle";
                dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            /// <summary>
            /// Realiza la busqueda segun el criterio formado por los controles del formulario.
            /// </summary>
            protected override void Buscar()
            {
                AsignarOrigenDatos<TipoEngrasamiento>(TipoEngrasamiento.Buscar(txtDescripcion.Text, txtDetalle.Text));
                //dtgResultado.DataSource = TipoEngrasamiento.Buscar(txtDescripcion.Text,txtDetalle.Text);
            }
            /// <summary>
            /// Lanza el formulario de edición de TipoEngrasamiento en modo guardar.
            /// </summary>
            protected override void Insertar()
            {
                TipoEngrasamiento ObjetoBase = new TipoEngrasamiento();
                this.LanzarFormulario(new EditTipoEngrasamiento(Modo.Guardar, ObjetoBase), this.dtgResultado);
            }
            /// <summary>
            /// Lanza el formulario edicion de TipoEngrasamiento en modo actualizar.
            /// </summary>
            protected override void Modificar()
            {
                if (dtgResultado.SelectedRows.Count == 1)
                {
                    TipoEngrasamiento ObjetoBase = (TipoEngrasamiento)this.dtgResultado.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditTipoEngrasamiento(Modo.Actualizar, ObjetoBase), this.dtgResultado);
                }
            }

        #endregion
    }
}