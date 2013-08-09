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
    public partial class FindCubricion : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindCubricion()
        {
            InitializeComponent();
        }
        public FindCubricion(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("FechaInicio", "F. Inicial");
            dtgResultado.Columns[0].DataPropertyName = "FechaInicio";
            dtgResultado.Columns.Add("fechaFin", "F. Final");
            dtgResultado.Columns[1].DataPropertyName = "FechaFin";
            dtgResultado.Columns.Add("DescLote", "Lote");
            dtgResultado.Columns[2].DataPropertyName = "DescLote";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Cubricion>(Cubricion.Buscar(Generic.ControlAIntNullable(cmbLote), null,
                                                           Generic.ControlADatetimeNullable(txtFechaIni),
                                                           Generic.ControlADatetimeNullable(txtFechaFin)));

            ////dtgResultado.DataSource = Cubricion.Buscar(Generic.ControlAIntNullable(cmbLote),null,
            ////                                           Generic.ControlADatetimeNullable(txtFechaIni),
            ////                                           Generic.ControlADatetimeNullable(txtFechaFin));
        }
        /// <summary>
        /// Lanza el formulario de edición de Cubricion en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Cubricion ObjetoBase = new Cubricion();
            this.LanzarFormulario(new EditCubricion(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Cubricion en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Cubricion ObjetoBase = (Cubricion)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditCubricion(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnbuscarLote_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindLoteAnimal(Modo.Consultar, this.cmbLote) { ValorFijoParidera=false});
            }

        #endregion         

    }
}