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
    public partial class FindPesos : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindPesos()
        {
            InitializeComponent();
        }
        public FindPesos(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("Peso", "Peso");
            dtgResultado.Columns[1].DataPropertyName = "Peso1";
            dtgResultado.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dtgResultado.Columns.Add("DescAnimal", "Animal");
            dtgResultado.Columns[2].DataPropertyName = "DescAnimal";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
          
            dtgResultado.Columns.Add("DescMomentoPeso", "Momento");
            dtgResultado.Columns[3].DataPropertyName = "DescMomentoPeso";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Peso>(Peso.Buscar(Generic.ControlAIntNullable(cmbAnimal), Generic.ControlADecimalNullable(txtPeso), 
                                     Generic.ControlADatetimeNullable(txtFecha), Generic.ControlAIntNullable(cmbMomentoPeso), null));
            //dtgResultado.DataSource = Peso.Buscar(Generic.ControlAIntNullable(cmbAnimal),Generic.ControlADecimalNullable(txtPeso),Generic.ControlADatetimeNullable(txtFecha),Generic.ControlAIntNullable(cmbMomentoPeso),null);
        }
        /// <summary>
        /// Lanza el formulario de edición de Pesos en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Peso ObjetoBase = new Peso();
            this.LanzarFormulario(new EditPesos(Modo.GuardarMultiple, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Pesos en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Peso ObjetoBase = (Peso)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditPesos(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
        }
        #endregion

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbMomentoPeso, Momento.Buscar());
            base.CargarCombos();
        }

        #endregion

    }
}