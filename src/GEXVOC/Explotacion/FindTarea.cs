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
    public partial class FindTarea : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTarea()
        {
            InitializeComponent();
        }
        public FindTarea(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("Descripcion", "Descripcion");
            dtgResultado.Columns[1].DataPropertyName = "descripcion";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Tarea>(Tarea.Buscar(Configuracion.Explotacion.Id,txtDescripcion.Text,
                                      Generic.ControlADatetimeNullable(txtFechaInicial),
                                      Generic.ControlADatetimeNullable(txtFechaFinal)));
           // dtgResultado.DataSource = Tarea.Buscar(Configuracion.Explotacion.Id,txtDescripcion.Text,Generic.ControlADatetimeNullable(txtFechaInicial),Generic.ControlADatetimeNullable(txtFechaFinal));
        }
        /// <summary>
        /// Lanza el formulario de edición de Tarea en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Tarea ObjetoBase = new Tarea();
            this.LanzarFormulario(new EditTarea(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Tarea en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Tarea ObjetoBase = (Tarea)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTarea(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion       

        #region CARGAS COMUNES
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(txtFechaInicial, DateTime.Today);
                base.CargarValoresDefecto();
            }

        #endregion

    }
} 

