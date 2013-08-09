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
    public partial class FindConformacionCanal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindConformacionCanal()
        {
            InitializeComponent();
        }
        public FindConformacionCanal(Modo modo, ctlBuscarObjeto controlBusqueda)
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
                dtgResultado.Columns.Add("Codigo", "Código");
                dtgResultado.Columns[0].DataPropertyName = "Codigo";
                dtgResultado.Columns.Add("Descripcion", "Descripcion");
                dtgResultado.Columns[1].DataPropertyName = "descripcion";
                dtgResultado.Columns.Add("Detalle", "Detalle");
                dtgResultado.Columns[2].DataPropertyName = "Detalle";
                dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            /// <summary>
            /// Realiza la busqueda segun el criterio formado por los controles del formulario.
            /// </summary>
            protected override void Buscar()
            {
                AsignarOrigenDatos<ConformacionCanal>(ConformacionCanal.Buscar(Generic.ControlACharNullable(txtCodigo), 
                                                                               txtDescripcion.Text, string.Empty));
             //   dtgResultado.DataSource = ConformacionCanal.Buscar(Generic.ControlACharNullable(txtCodigo),txtDescripcion.Text,string.Empty);
            }
            /// <summary>
            /// Lanza el formulario de edición de ConformacionCanal en modo guardar.
            /// </summary>
            protected override void Insertar()
            {
                ConformacionCanal ObjetoBase = new ConformacionCanal();
                this.LanzarFormulario(new EditConformacionCanal(Modo.Guardar, ObjetoBase), this.dtgResultado);
            }
            /// <summary>
            /// Lanza el formulario edicion de ConformacionCanal en modo actualizar.
            /// </summary>
            protected override void Modificar()
            {
                if (dtgResultado.SelectedRows.Count == 1)
                {
                    ConformacionCanal ObjetoBase = (ConformacionCanal)this.dtgResultado.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditConformacionCanal(Modo.Actualizar, ObjetoBase), this.dtgResultado);
                }
            }

        #endregion
    }
}