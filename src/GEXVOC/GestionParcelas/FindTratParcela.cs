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
    public partial class FindTratParcela : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTratParcela()
        {
            InitializeComponent();
        }
        public FindTratParcela(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescPlaga", "Plaga");
            dtgResultado.Columns[1].DataPropertyName = "DescPlaga";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescProducto", "Producto");
            dtgResultado.Columns[2].DataPropertyName = "DescProducto";
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
            AsignarOrigenDatos<TratParcela>(TratParcela.Buscar(Generic.ControlAIntNullable(cmbParcela), 
                                                               Generic.ControlAIntNullable(cmbPlaga), 
                                                               Generic.ControlAIntNullable(cmbProducto), 
                                                               Generic.ControlADatetimeNullable(txtFecha)));
            //dtgResultado.DataSource = TratParcela.Buscar(Generic.ControlAIntNullable(cmbParcela), Generic.ControlAIntNullable(cmbPlaga), Generic.ControlAIntNullable(cmbProducto), Generic.ControlADatetimeNullable(txtFecha));
        }
        /// <summary>
        /// Lanza el formulario de edición de TratParcela en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TratParcela ObjetoBase = new TratParcela();
            this.LanzarFormulario(new EditTratParcela(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TratParcela en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TratParcela ObjetoBase = (TratParcela)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTratParcela(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region EVENTOS BOTON
        private void btnBuscarParcela_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar, cmbParcela));
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, cmbProducto) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA) });
        }

        private void btnBuscarPlaga_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindPlaga(Modo.Consultar, cmbPlaga));
        }

        #endregion
    }
}
