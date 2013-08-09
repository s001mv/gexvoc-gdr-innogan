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
    public partial class FindCombinacion : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindCombinacion()
        {
            InitializeComponent();
        }
        public FindCombinacion(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescMarcador1", "Marcador1");
            dtgResultado.Columns[0].DataPropertyName = "DescMarcador1";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescMarcador2", "Marcador2");
            dtgResultado.Columns[1].DataPropertyName = "DescMarcador2";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Grupo", "Grupo");
            dtgResultado.Columns[2].DataPropertyName = "Grupo";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Riesgo", "Riesgo");
            dtgResultado.Columns[3].DataPropertyName = "Riesgo";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            if (this.Validate(true))
            {
                ////int? idMarcador1 = null;
                ////if (cmbMarcador1.SelectedValue != null)
                ////    idMarcador1 = (int)cmbMarcador1.SelectedValue;

                ////int? idMarcador2 = null;
                ////if (cmbMarcador2.SelectedValue != null)
                ////    idMarcador2 = (int)cmbMarcador2.SelectedValue;


                AsignarOrigenDatos<Combinacion>(Combinacion.Buscar(Generic.ControlAIntNullable(cmbMarcador1),
                                                Generic.ControlAIntNullable(cmbMarcador2), txtGrupo.Text, string.Empty));
                //dtgResultado.DataSource = Combinacion.Buscar(idMarcador1, idMarcador2, txtGrupo.Text, string.Empty);
            }
        }
        /// <summary>
        /// Lanza el formulario de edición de Combinacion en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Combinacion ObjetoBase = new Combinacion();
            this.LanzarFormulario(new EditCombinacion(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Combinacion en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Combinacion ObjetoBase = (Combinacion)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditCombinacion(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES

        /// <summary>
        /// Carga los combos del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbMarcador1, "Marcador1", "Id", Marcador.Buscar());
            this.CargarCombo(cmbMarcador2, "Marcador1", "Id", Marcador.Buscar());
        }


        #endregion
    }
}
