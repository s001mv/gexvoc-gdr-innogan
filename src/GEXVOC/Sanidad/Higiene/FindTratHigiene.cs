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
    public partial class FindTratHigiene : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTratHigiene()
        {
            InitializeComponent();
        }
        public FindTratHigiene(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("FechaInicio", "Fecha");
            dtgResultado.Columns[0].DataPropertyName = "FechaInicio";
            dtgResultado.Columns.Add("DescPlanHigiene", "Plan");
            dtgResultado.Columns[1].DataPropertyName = "DescPlanHigiene";
            dtgResultado.Columns.Add("Detalle", "Detalle");
            dtgResultado.Columns[2].DataPropertyName = "Detalle";

            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TratHigiene>(TratHigiene.Buscar(Generic.ControlAIntNullable(cmbPlanHigiene), 
                                                               Configuracion.Explotacion.Id, txtDetalle.Text,
                                                               Generic.ControlADatetimeNullable(txtFechaInicio), 
                                                               Generic.ControlADatetimeNullable(txtFechaFin)));

            //////dtgResultado.DataSource = TratHigiene.Buscar(Generic.ControlAIntNullable(cmbPlanHigiene),Configuracion.Explotacion.Id,txtDetalle.Text,
            //////    Generic.ControlADatetimeNullable(txtFechaInicio),Generic.ControlADatetimeNullable(txtFechaFin));
        }
        /// <summary>
        /// Lanza el formulario de edición de TratHigiene en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TratHigiene ObjetoBase = new TratHigiene();
            this.LanzarFormulario(new EditTratHigiene(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TratHigiene en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TratHigiene ObjetoBase = (TratHigiene)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTratHigiene(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            this.CargarCombo(this.cmbPlanHigiene, PlanHigiene.Buscar());
        }

        #endregion
    }
}