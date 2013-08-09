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
    public partial class FindCategoria : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindCategoria()
        {
            InitializeComponent();
        }
        public FindCategoria(Modo modo, ctlBuscarObjeto controlBusqueda)
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
                AsignarOrigenDatos<Categoria>(Categoria.Buscar(txtDescripcion.Text, txtDetalle.Text));
                //dtgResultado.DataSource = Categoria.Buscar(txtDescripcion.Text,txtDetalle.Text);
            }
            /// <summary>
            /// Lanza el formulario de edición de Categoria en modo guardar.
            /// </summary>
            protected override void Insertar()
            {
                Categoria ObjetoBase = new Categoria();
                this.LanzarFormulario(new EditCategoria(Modo.Guardar, ObjetoBase), this.dtgResultado);
            }
            /// <summary>
            /// Lanza el formulario edicion de Categoria en modo actualizar.
            /// </summary>
            protected override void Modificar()
            {
                if (dtgResultado.SelectedRows.Count == 1)
                {
                    Categoria ObjetoBase = (Categoria)this.dtgResultado.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditCategoria(Modo.Actualizar, ObjetoBase), this.dtgResultado);
                }
            }

        #endregion
    }
}