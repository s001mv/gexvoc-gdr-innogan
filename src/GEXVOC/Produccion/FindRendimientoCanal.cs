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
    public partial class FindRendimientoCanal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
            public FindRendimientoCanal()
            {
                InitializeComponent();
            }
            public FindRendimientoCanal(Modo modo, ctlBuscarObjeto controlBusqueda)
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
                dtgResultado.Columns.Add("Fecha", "Fecha");
                dtgResultado.Columns[0].DataPropertyName = "Fecha";     

                dtgResultado.Columns.Add("DescAnimal", "Animal");
                dtgResultado.Columns[1].DataPropertyName = "DescAnimal";
                dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtgResultado.Columns.Add("Rendimiento", "Rendimiento");
                dtgResultado.Columns[2].DataPropertyName = "Rendimiento";
                dtgResultado.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                 
                
              
            }
            /// <summary>
            /// Realiza la busqueda segun el criterio formado por los controles del formulario.
            /// </summary>
            protected override void Buscar()
            {
                AsignarOrigenDatos<RendimientoCanal>(RendimientoCanal.Buscar(Generic.ControlAIntNullable(cmbAnimal), null, 
                                                                             Generic.ControlADatetimeNullable(txtFechaDesde), 
                                                                             Generic.ControlADatetimeNullable(txtFechaHasta)));
                //dtgResultado.DataSource = RendimientoCanal.Buscar(Generic.ControlAIntNullable(cmbAnimal),null,Generic.ControlADatetimeNullable(txtFechaDesde),Generic.ControlADatetimeNullable(txtFechaHasta));
            }
            /// <summary>
            /// Lanza el formulario de edición de RendimientoCanal en modo guardar.
            /// </summary>
            protected override void Insertar()
            {
                RendimientoCanal ObjetoBase = new RendimientoCanal();
                this.LanzarFormulario(new EditRendimientoCanal(Modo.Guardar, ObjetoBase), this.dtgResultado);
            }
            /// <summary>
            /// Lanza el formulario edicion de RendimientoCanal en modo actualizar.
            /// </summary>
            protected override void Modificar()
            {
                if (dtgResultado.SelectedRows.Count == 1)
                {
                    RendimientoCanal ObjetoBase = (RendimientoCanal)this.dtgResultado.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditRendimientoCanal(Modo.Actualizar, ObjetoBase), this.dtgResultado);
                }
            }

        #endregion
    }
}
