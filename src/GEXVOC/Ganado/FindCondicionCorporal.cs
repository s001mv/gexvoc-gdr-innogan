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
    public partial class FindCondicionCorporal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindCondicionCorporal()
        {
            InitializeComponent();
        }
        public FindCondicionCorporal(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescCodTipo", "Cod. Tipo");
            dtgResultado.Columns[2].DataPropertyName = "DescCodTipo";
            dtgResultado.Columns.Add("DescTipo", "Tipo");
            dtgResultado.Columns[3].DataPropertyName = "DescTipo";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<CondicionCorporal>(CondicionCorporal.Buscar(Generic.ControlAIntNullable(cmbAnimal), 
                                                  Generic.ControlAIntNullable(cmbTipo), Generic.ControlADatetimeNullable(txtFecha)));
           // dtgResultado.DataSource = CondicionCorporal.Buscar(Generic.ControlAIntNullable(cmbAnimal),Generic.ControlAIntNullable(cmbTipo),Generic.ControlADatetimeNullable(txtFecha));
        }
        /// <summary>
        /// Lanza el formulario de edición de CondicionCorporal en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            CondicionCorporal ObjetoBase = new CondicionCorporal();
            this.LanzarFormulario(new EditCondicionCorporal(Modo.GuardarMultiple, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de CondicionCorporal en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                CondicionCorporal ObjetoBase = (CondicionCorporal)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditCondicionCorporal(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
            }

            private void btnBuscarTipo_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindTipoCondicion(Modo.Consultar, this.cmbTipo));
            }


        #endregion

    }
}