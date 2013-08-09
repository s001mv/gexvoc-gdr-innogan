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
    public partial class FindEngrasamientoCanal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindEngrasamientoCanal()
        {
            InitializeComponent();
        }
        public FindEngrasamientoCanal(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescTipo", "Tipo");
            dtgResultado.Columns[2].DataPropertyName = "DescTipo";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<EngrasamientoCanal>(EngrasamientoCanal.Buscar(Generic.ControlAIntNullable(cmbAnimal), 
                                                                             Generic.ControlAIntNullable(cmbTipo), 
                                                                             Generic.ControlADatetimeNullable(txtFecha)));
            //dtgResultado.DataSource = EngrasamientoCanal.Buscar(Generic.ControlAIntNullable(cmbAnimal),Generic.ControlAIntNullable(cmbTipo),Generic.ControlADatetimeNullable(txtFecha));
        }
        /// <summary>
        /// Lanza el formulario de edición de EngrasamientoCanal en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            EngrasamientoCanal ObjetoBase = new EngrasamientoCanal();
            this.LanzarFormulario(new EditEngrasamientoCanal(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de EngrasamientoCanal en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                EngrasamientoCanal ObjetoBase = (EngrasamientoCanal)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditEngrasamientoCanal(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {
                this.CargarCombo(cmbTipo, TipoEngrasamiento.Buscar());        
                base.CargarCombos();
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
            }

        #endregion
                    
       
    }
}