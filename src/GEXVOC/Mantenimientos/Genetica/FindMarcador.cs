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
    public partial class FindMarcador : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindMarcador()
        {
            InitializeComponent();
        }
        public FindMarcador(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescTipoAnalisis", "Tipo de Análisis");
            dtgResultado.Columns[0].DataPropertyName = "DescTipoAnalisis";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescEspecie", "Especie");
            dtgResultado.Columns[1].DataPropertyName = "DescEspecie";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Marcador1", "Marcador");
            dtgResultado.Columns[2].DataPropertyName = "Marcador1";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            if (this.Validate(true))
            {
                //int? idTipoAnalisis=null;
                //if (cmbTipoAnalisis.SelectedValue != null)
                //    idTipoAnalisis = (int)cmbTipoAnalisis.SelectedValue;

                //int? idEspecie = null;
                //if (cmbEspecie.SelectedValue != null)
                //    idEspecie = (int)cmbEspecie.SelectedValue;

                AsignarOrigenDatos<Marcador>(Marcador.Buscar(Generic.ControlAIntNullable(cmbTipoAnalisis),
                                                             Generic.ControlAIntNullable(cmbEspecie), txtMarcador.Text));
                //dtgResultado.DataSource = Marcador.Buscar(idTipoAnalisis, idEspecie, txtMarcador.Text);
            }
        }
        /// <summary>
        /// Lanza el formulario de edición de Marcador en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Marcador ObjetoBase = new Marcador();
            this.LanzarFormulario(new EditMarcador(Modo.Guardar, ObjetoBase), this.dtgResultado);
            
        }
        /// <summary>
        /// Lanza el formulario edicion de Marcador en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Marcador ObjetoBase = (Marcador)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditMarcador(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga los combos del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipoAnalisis, "Descripcion", TipoAnalisis.Buscar());
            this.CargarCombo(cmbEspecie, "Descripcion", Especie.Buscar());
        }

        #endregion
    }
}
