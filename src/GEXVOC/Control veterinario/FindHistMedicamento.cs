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
    public partial class FindHistMedicamento : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindHistMedicamento()
        {
            InitializeComponent();
        }
        public FindHistMedicamento(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescEspecie", "Especie");
            dtgResultado.Columns[0].DataPropertyName = "DescEspecie";
            dtgResultado.Columns.Add("DescEnfermedad", "Enfermedad");
            dtgResultado.Columns[1].DataPropertyName = "DescEnfermedad";
            dtgResultado.Columns.Add("DescMedicamento", "Medicamento");
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns[2].DataPropertyName = "DescMedicamento";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<HistMedicamento>(HistMedicamento.Buscar(Generic.ControlAIntNullable(cmbEspecie),Generic.ControlAIntNullable(cmbEnfermedad),Generic.ControlAIntNullable(cmbMedicamento)));
            //dtgResultado.DataSource = HistMedicamento.Buscar(Generic.ControlAIntNullable(cmbEspecie),Generic.ControlAIntNullable(cmbEnfermedad),Generic.ControlAIntNullable(cmbMedicamento));
        }
        /// <summary>
        /// Lanza el formulario de edición de HistMedicamento en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            HistMedicamento ObjetoBase = new HistMedicamento();
            this.LanzarFormulario(new EditHistMedicamento(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de HistMedicamento en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                HistMedicamento ObjetoBase = (HistMedicamento)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditHistMedicamento(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

     
        #endregion  

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            this.CargarCombo(this.cmbEspecie, Especie.Buscar());

            base.CargarCombos();
        }

        #endregion

    }
}