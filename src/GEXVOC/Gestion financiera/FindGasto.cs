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
    public partial class FindGasto : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindGasto()
        {
            InitializeComponent();
        }
        public FindGasto(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescTipo", "Naturaleza de gasto");
            dtgResultado.Columns[1].DataPropertyName = "DescTipo";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Total", "Total");
            dtgResultado.Columns[2].DataPropertyName = "Total";           
            
      

        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Gasto>(Gasto.Buscar(Generic.ControlAIntNullable(cmbNaturaleza), Configuracion.Explotacion.Id, 
                                      null, null, null, null, null, null, null, null, string.Empty, 
                                      Generic.ControlADatetimeNullable(txtFechaDesde), 
                                      Generic.ControlADatetimeNullable(txtFechaHasta), null, null, null));
            //dtgResultado.DataSource = Gasto.Buscar(Generic.ControlAIntNullable(cmbNaturaleza), Configuracion.Explotacion.Id, null, null, null, null, null, null, null, null, string.Empty, Generic.ControlADatetimeNullable(txtFechaDesde), Generic.ControlADatetimeNullable(txtFechaHasta), null,null,null);

        }
        /// <summary>
        /// Lanza el formulario de edición de Gasto en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Gasto ObjetoBase = new Gasto();
            this.LanzarFormulario(new EditGasto(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Gasto en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Gasto ObjetoBase = (Gasto)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditGasto(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbNaturaleza, "Descripcion", "Id", Naturaleza.Buscar());
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void txtFechaDesde_Leave(object sender, EventArgs e)
            {
                ((TextBox)sender).Text = Generic.FormatearFecha(((TextBox)sender).Text);
            }

            private void txtFechaHasta_Leave(object sender, EventArgs e)
            {
                ((TextBox)sender).Text = Generic.FormatearFecha(((TextBox)sender).Text);
            }

        #endregion

    }
}