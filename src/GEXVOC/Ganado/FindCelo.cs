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
    public partial class FindCelo : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindCelo()
        {
            InitializeComponent();
        }
        public FindCelo(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescAnimal", "Animal");
            dtgResultado.Columns[1].DataPropertyName = "DescAnimal";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescPersonal", "Personal");
            dtgResultado.Columns[2].DataPropertyName = "DescPersonal";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

           
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Celo>(Celo.Buscar(Generic.ControlAIntNullable(cmbHembra), null, 
                                     Generic.ControlADatetimeNullable(txtFecha)));
            //dtgResultado.DataSource = Celo.Buscar(Generic.ControlAIntNullable(cmbHembra),null,Generic.ControlADatetimeNullable(txtFecha));
        }
        /// <summary>
        /// Lanza el formulario de edición de Celo en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Celo ObjetoBase = new Celo();
            this.LanzarFormulario(new EditCelo(Modo.GuardarMultiple, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Celo en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Celo ObjetoBase = (Celo)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditCelo(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo=Convert.ToChar("H")});
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, this.cmbPersonal));
        }
    }
}