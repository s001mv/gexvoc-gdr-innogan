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
    public partial class FindDiagInseminacion : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindDiagInseminacion()
        {
            InitializeComponent();
        }
        public FindDiagInseminacion(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescHembra", "Hembra");
            dtgResultado.Columns[1].DataPropertyName = "DescHembra";
            dtgResultado.Columns.Add("DescTipo", "Tipo");
            dtgResultado.Columns[2].DataPropertyName = "DescTipo";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescResultado", "Resultado");
            dtgResultado.Columns[3].DataPropertyName = "DescResultado";

            
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            dtgResultado.DataSource = DiagInseminacion.Buscar(Generic.ControlAIntNullable(cmbAnimal),
                                                              Generic.ControlAIntNullable(cmbTipoDiagnostico),
                                                              Generic.ControlADatetimeNullable(txtFechaDiagnostico),
                                                              null,null);
        }
        /// <summary>
        /// Lanza el formulario de edición de DiagInseminacion en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            DiagInseminacion ObjetoBase = new DiagInseminacion();
            this.LanzarFormulario(new EditDiagInseminacion(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de DiagInseminacion en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                DiagInseminacion ObjetoBase = (DiagInseminacion)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditDiagInseminacion(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipoDiagnostico, TipoDiagnostico.Buscar());
            base.CargarCombos();
        }
    
        #endregion
    }
}