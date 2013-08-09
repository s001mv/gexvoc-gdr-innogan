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
    public partial class FindSiembra : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindSiembra()
        {
            InitializeComponent();
        }
        public FindSiembra(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescSemilla", "Semilla");
            dtgResultado.Columns[1].DataPropertyName = "DescSemilla";
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
            AsignarOrigenDatos<Siembra>(Siembra.Buscar(Generic.ControlAIntNullable(cmbSemilla), 
                                                       Generic.ControlAIntNullable(cmbParcela), null, 
                                                       Generic.ControlADatetimeNullable(txtFecha)));
            //dtgResultado.DataSource = Siembra.Buscar(Generic.ControlAIntNullable(cmbSemilla), Generic.ControlAIntNullable(cmbParcela), null, Generic.ControlADatetimeNullable(txtFecha));

        }
        /// <summary>
        /// Lanza el formulario de edición de Siembra en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Siembra ObjetoBase = new Siembra();
            this.LanzarFormulario(new EditSiembra(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Siembra en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Siembra ObjetoBase = (Siembra)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditSiembra(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region EVENTOS BOTON
        private void btnBuscarParcela_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar, cmbParcela));
        }
        private void btnBuscarSemilla_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, cmbSemilla)
            {
                ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA),
                ValorFijoIdFamilia = Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.SEMILLA).Id
            });
        }


        #endregion
    }
}