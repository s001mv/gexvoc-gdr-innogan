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
    public partial class FindAborto : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindAborto()
        {
            InitializeComponent();
        }
        public FindAborto(Modo modo, ctlBuscarObjeto controlBusqueda)
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
           
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Aborto>(Aborto.Buscar(Generic.ControlAIntNullable(cmbHembra),
                                       Generic.ControlAIntNullable(cmbTipo), Generic.ControlADatetimeNullable(txtFecha)));

            ////dtgResultado.DataSource = Aborto.Buscar(Generic.ControlAIntNullable(cmbHembra),
            ////    Generic.ControlAIntNullable(cmbTipo),Generic.ControlADatetimeNullable(txtFecha));
        }
        /// <summary>
        /// Lanza el formulario de edición de Aborto en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Aborto ObjetoBase = new Aborto();
            this.LanzarFormulario(new EditAborto(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Aborto en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Aborto ObjetoBase = (Aborto)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditAborto(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
        }

        #region CARGAS COMUNES

        /// <summary>
        /// Carga los combos del formulario
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipo, TipoAborto.Buscar());
        }

    

        #endregion
    }
}