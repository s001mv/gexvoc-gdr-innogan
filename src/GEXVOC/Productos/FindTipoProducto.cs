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
    public partial class FindTipoProducto : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTipoProducto()
        {
            InitializeComponent();
        }
        public FindTipoProducto(Modo modo, ctlBuscarObjeto controlBusqueda)
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
                dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewCheckBoxColumn d = new DataGridViewCheckBoxColumn();
                d.DataPropertyName = "Familia";
                d.HeaderText = "Familia";
                dtgResultado.Columns.Add(d);
             


            

            }
            /// <summary>
            /// Realiza la busqueda segun el criterio formado por los controles del formulario.
            /// </summary>
            protected override void Buscar()
            {
                AsignarOrigenDatos<TipoProducto>(TipoProducto.Buscar(txtDescripcion.Text, null, null));
                //dtgResultado.DataSource = TipoProducto.Buscar(txtDescripcion.Text,null,null);

            }
            /// <summary>
            /// Lanza el formulario de edición de TipoProducto en modo guardar.
            /// </summary>
            protected override void Insertar()
            {
                TipoProducto ObjetoBase = new TipoProducto();
                this.LanzarFormulario(new EditTipoProducto(Modo.Guardar, ObjetoBase), this.dtgResultado);
            }
            /// <summary>
            /// Lanza el formulario edicion de TipoProducto en modo actualizar.
            /// </summary>
            protected override void Modificar()
            {
                if (dtgResultado.SelectedRows.Count == 1)
                {
                    TipoProducto ObjetoBase = (TipoProducto)this.dtgResultado.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditTipoProducto(Modo.Actualizar, ObjetoBase), this.dtgResultado);
                }
            }

        #endregion
    }
}