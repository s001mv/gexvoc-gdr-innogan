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
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[0].DataPropertyName = "Fecha";
            dtgResultado.Columns.Add("DescProducto", "Producto");
            dtgResultado.Columns[1].DataPropertyName = "DescProducto";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescPrograma", "Programa");
            dtgResultado.Columns[2].DataPropertyName = "DescPrograma";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
                
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            dtgResultado.DataSource = TratHigiene.Buscar(Configuracion.Explotacion.Id,Generic.ControlAIntNullable(cmbPrograma),string.Empty,Generic.ControlADatetimeNullable(txtFecha),null);
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

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FindProducto frmProducto = new FindProducto(Modo.Consultar, cmbProducto) { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.PRODUCTO_PARA_PLANES_DE_HIGIENE) };

            LanzarFormularioConsulta(frmProducto);  
        }

        protected override void CargarCombos()
        {
            this.CargarCombo(cmbPrograma, Programa.Buscar());        
            base.CargarCombos();
        }
    }
}
