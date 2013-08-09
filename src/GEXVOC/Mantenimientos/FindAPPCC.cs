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
    public partial class FindAPPCC : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindAPPCC()
        {
            InitializeComponent();
        }
        public FindAPPCC(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("Fase", "Fase");
            dtgResultado.Columns[0].DataPropertyName = "Fase";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Peligro", "Peligro");
            dtgResultado.Columns[1].DataPropertyName = "Peligro";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            int? Proceso = null;

            if (cmbProceso.SelectedItem != null)
                Proceso = ((Plantilla)cmbProceso.SelectedItem).Id;

            AsignarOrigenDatos<APPCC>(APPCC.Buscar(Configuracion.Explotacion.Id, Proceso, txtFase.Text, txtPeligro.Text, txtPrevencion.Text,
                txtLimiteCritico.Text, txtVigilancia.Text, txtFrecuencia.Text, txtCorrecion.Text));
            //dtgResultado.DataSource = APPCC.Buscar(Configuracion.Explotacion.Id,txtFase.Text,txtPeligro.Text,txtPrevencion.Text,
            //    txtLimiteCritico.Text,txtVigilancia.Text,txtFrecuencia.Text,txtCorrecion.Text);
        }

        /// <summary>
        /// Lanza el formulario de edición de APPCC en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            APPCC ObjetoBase = new APPCC();
            this.LanzarFormulario(new EditAPPCC(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de APPCC en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                APPCC ObjetoBase = (APPCC)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditAPPCC(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES

        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbProceso, Plantilla.Buscar());
        }

        #endregion
    }
}