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
    public partial class FindAnalisis : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindAnalisis()
        {
            InitializeComponent();
        }
        public FindAnalisis(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescTipo", "Tipo de Análisis");
            dtgResultado.Columns[0].DataPropertyName = "DescTipo";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescAnimal", "Animal");
            dtgResultado.Columns[1].DataPropertyName = "DescAnimal";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescLaboratorio", "Laboratorio");
            dtgResultado.Columns[2].DataPropertyName = "DescLaboratorio";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[3].DataPropertyName = "Fecha";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Registro", "Registro");
            dtgResultado.Columns[4].DataPropertyName = "Registro";
            dtgResultado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            //if(this.Validate(true))
            //{
                //int? idTipoAnalisis=null;
                //if(cmbTipoAnalisis.SelectedValue!=null)
                //    idTipoAnalisis=(int)cmbTipoAnalisis.SelectedValue;

                //int? idAnimal=null;
                //if(cmbAnimal.IdClaseActiva!=0)
                //    idAnimal=cmbAnimal.IdClaseActiva;

                //int? idLaboratorio=null;
                //if(cmbLaboratorio.IdClaseActiva!=0)
                //    idLaboratorio=cmbLaboratorio.IdClaseActiva;

                AsignarOrigenDatos<Analisis>(Analisis.Buscar(Generic.ControlAIntNullable(cmbTipoAnalisis),
                                                             Generic.ControlAIntNullable(cmbAnimal),
                                                             Generic.ControlAIntNullable(cmbLaboratorio),
                                                             Generic.ControlADatetimeNullable(txtFecha), txtRegistro.Text, null));
                //dtgResultado.DataSource = Analisis.Buscar(idTipoAnalisis, idAnimal, idLaboratorio, Generic.ControlADatetimeNullable(txtFecha), txtRegistro.Text, null);
            //}
        }
        /// <summary>
        /// Lanza el formulario de edición de Analisis en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Analisis ObjetoBase = new Analisis();
            this.LanzarFormulario(new EditAnalisis(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Analisis en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Analisis ObjetoBase = (Analisis)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditAnalisis(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES

        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipoAnalisis, "Descripcion", "Id", TipoAnalisis.Buscar());
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));
        }

        private void btnBuscarLaboratorio_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindLaboratorios(Modo.Consultar, cmbLaboratorio));
        }
        #endregion

    }
}
