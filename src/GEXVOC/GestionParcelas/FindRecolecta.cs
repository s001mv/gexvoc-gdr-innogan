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
    public partial class FindRecolecta : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindRecolecta()
        {
            InitializeComponent();
        }
        public FindRecolecta(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescParcela", "Parcela");
            dtgResultado.Columns[0].DataPropertyName = "DescParcela";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescForraje", "Forraje");
            dtgResultado.Columns[1].DataPropertyName = "DescForraje";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Cantidad", "Cantidad");
            dtgResultado.Columns[2].DataPropertyName = "Cantidad";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[3].DataPropertyName = "Fecha";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Recolecta>(Recolecta.Buscar(Generic.ControlAIntNullable(cmbForraje),
                                                           Generic.ControlAIntNullable(cmbParcela), null, 
                                                           Generic.ControlADatetimeNullable(txtFechaDesde), 
                                                           Generic.ControlADatetimeNullable(txtFechaHasta)));
            //dtgResultado.DataSource = Recolecta.Buscar(Generic.ControlAIntNullable(cmbForraje), Generic.ControlAIntNullable(cmbParcela), null, Generic.ControlADatetimeNullable(txtFechaDesde), Generic.ControlADatetimeNullable(txtFechaHasta));
        }
        /// <summary>
        /// Lanza el formulario de edición de Recolecta en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Recolecta ObjetoBase = new Recolecta();
            this.LanzarFormulario(new EditRecolecta(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Recolecta en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Recolecta ObjetoBase = (Recolecta)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditRecolecta(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region EVENTOS BOTON
        private void btnBuscarParcela_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar, cmbParcela));
        }
        private void btnBuscarForraje_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, cmbForraje) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.ALIMENTACION) });

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

            private void cmbForraje_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void lblForraje_Click(object sender, EventArgs e)
            {

            }
        #endregion
    }
}
