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
    public partial class FindSincronizacionCelo : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindSincronizacionCelo()
        {
            InitializeComponent();
        }
        public FindSincronizacionCelo(Modo modo, ctlBuscarObjeto controlBusqueda)
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

            //dtgResultado.Columns.Add("FechaColocacion", "F.Colocación");
            //dtgResultado.Columns[0].DataPropertyName = "FechaColocacion";
            //dtgResultado.Columns.Add("FechaInyeccion", "F.Inyección");
            //dtgResultado.Columns[1].DataPropertyName = "FechaInyeccion";
            //dtgResultado.Columns.Add("FechaRetirada", "F.Retirada");
            //dtgResultado.Columns[2].DataPropertyName = "FechaRetirada";
            dtgResultado.Columns.Add("FechaPrevision", "F.Previsión");
            dtgResultado.Columns[1].DataPropertyName = "FechaPrevision";
            dtgResultado.Columns.Add("Tipo", "Tipo");
            dtgResultado.Columns[2].DataPropertyName = "Tipo";          

            dtgResultado.Columns.Add("DescAnimal", "Animal");
            dtgResultado.Columns[3].DataPropertyName = "DescAnimal";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescPersonal", "Personal");
            dtgResultado.Columns[4].DataPropertyName = "DescPersonal";
            dtgResultado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<SincronizacionCelo>(SincronizacionCelo.Buscar(Generic.ControlAIntNullable(cmbHembra),
                                                   Generic.ControlAIntNullable(cmbPersonal), 
                                                   Generic.ControlADatetimeNullable(txtFechaColocacion),
                                                   Generic.ControlADatetimeNullable(txtFechaInyeccion), 
                                                   Generic.ControlADatetimeNullable(txtFechaPrevision),
                                                   Generic.ControlADatetimeNullable(txtFechaRetirada)));
            ////dtgResultado.DataSource = SincronizacionCelo.Buscar(Generic.ControlAIntNullable(cmbHembra),
            ////    Generic.ControlAIntNullable(cmbPersonal),Generic.ControlADatetimeNullable(txtFechaColocacion),
            ////    Generic.ControlADatetimeNullable(txtFechaInyeccion),Generic.ControlADatetimeNullable(txtFechaPrevision),
            ////    Generic.ControlADatetimeNullable(txtFechaRetirada));
        }
        /// <summary>
        /// Lanza el formulario de edición de SincronizacionCelo en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            SincronizacionCelo ObjetoBase = new SincronizacionCelo();
            this.LanzarFormulario(new EditSincronizacionCelo(Modo.GuardarMultiple, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de SincronizacionCelo en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                SincronizacionCelo ObjetoBase = (SincronizacionCelo)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditSincronizacionCelo(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
            }

            private void btnBuscarPersonal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, this.cmbPersonal));
            }
        #endregion
       
    }
}