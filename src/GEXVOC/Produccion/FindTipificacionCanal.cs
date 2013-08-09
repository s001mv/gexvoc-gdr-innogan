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
    public partial class FindTipificacionCanal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTipificacionCanal()
        {
            InitializeComponent();
        }
        public FindTipificacionCanal(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescAnimal", "Animal");
            dtgResultado.Columns[0].DataPropertyName = "DescAnimal";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescConformacion", "Conformación");
            dtgResultado.Columns[1].DataPropertyName = "DescConformacion";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescCategoria", "Categoria");
            dtgResultado.Columns[2].DataPropertyName = "DescCategoria";
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
            AsignarOrigenDatos<TipificacionCanal>(TipificacionCanal.Buscar(Generic.ControlAIntNullable(cmbAnimal), 
                                                                           Generic.ControlAIntNullable(cmbConformacion), 
                                                                           Generic.ControlAIntNullable(cmbCategoria), 
                                                                           Generic.ControlADatetimeNullable(txtFechaDesde), 
                                                                           Generic.ControlADatetimeNullable(txtFechaHasta)));
            //dtgResultado.DataSource = TipificacionCanal.Buscar(Generic.ControlAIntNullable(cmbAnimal),Generic.ControlAIntNullable(cmbConformacion),Generic.ControlAIntNullable(cmbCategoria),Generic.ControlADatetimeNullable(txtFechaDesde),Generic.ControlADatetimeNullable(txtFechaHasta));
        }
        /// <summary>
        /// Lanza el formulario de edición de TipificacionCanal en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipificacionCanal ObjetoBase = new TipificacionCanal();
            this.LanzarFormulario(new EditTipificacionCanal(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TipificacionCanal en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipificacionCanal ObjetoBase = (TipificacionCanal)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTipificacionCanal(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga los combos del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            //Carga el combo de categoria de animal.
            this.CargarCombo(cmbCategoria, "Descripcion", "Id", Categoria.Buscar());
            //Carga el combo de conformación de la canal.
            this.CargarCombo(cmbConformacion, "Descripcion", "Id", Conformacion.Buscar());
        }

        #endregion 

        #region FUNCIONAMIENTO GENERAL
            /// <summary>
            /// Lanza el formulario de busqueda de animales en modo consulta.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));
            }


        #endregion
      
    }
}
