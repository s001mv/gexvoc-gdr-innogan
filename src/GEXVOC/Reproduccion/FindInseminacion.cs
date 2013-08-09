using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;
using GEXVOC.UI.Clases;


namespace GEXVOC.UI
{
    public partial class FindInseminacion : GEXVOC.UI.GenericFind
    {        
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindInseminacion()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario FindEdit con los datos propios del formulario
        /// </summary>
        /// <param name="modo"></param>
        /// <param name="controlBusqueda"></param>
        public FindInseminacion(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo,  controlBusqueda)
        {
            InitializeComponent();
           

        }
        #endregion

        #region FUNCIONES SOBREESCRITAS

        /// <summary>
        /// Crea el Estilo Personalizado para el Grid
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[0].DataPropertyName = "Fecha";
            dtgResultado.Columns.Add("DescTipo", "Tipo");
            dtgResultado.Columns[1].DataPropertyName = "DescTipo";
            dtgResultado.Columns.Add("DescHembra", "Hembra");
            dtgResultado.Columns[2].DataPropertyName = "DescHembra";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescMacho", "Macho");
            dtgResultado.Columns[3].DataPropertyName = "DescMacho";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            
        }

        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Buscar()
        {
            if (this.Validate(true))
            {
                

                int? idTipoInseminacion = null;
                if (this.cmbTipo.SelectedValue != null)
                    idTipoInseminacion = (int)this.cmbTipo.SelectedValue;

                int? idMacho = null;
                if (cmbMacho.IdClaseActiva != 0)
                    idMacho = cmbMacho.IdClaseActiva;

                int? idHembra = null;
                if (cmbHembra.IdClaseActiva != 0)
                    idHembra = cmbHembra.IdClaseActiva;

                AsignarOrigenDatos<Inseminacion>(Inseminacion.Buscar(idMacho, idHembra, idTipoInseminacion, null, null, null, 
                                                 Generic.ControlADatetimeNullable(this.txtFecha), null));
                //dtgResultado.DataSource = Inseminacion.Buscar(idMacho, idHembra, idTipoInseminacion,  null, null, null, Generic.ControlADatetimeNullable(this.txtFecha), null);

            }
        }
        /// <summary>
        /// Lanza el formulario de Edición de Inseminacion en Modo =>Guardar.
        /// </summary>
       
        protected override void Insertar()
        {
            Inseminacion ObjetoBase = new Inseminacion();
            EditInseminacion EditInseminacion = new EditInseminacion(Modo.GuardarMultiple, ObjetoBase);
            this.LanzarFormulario(EditInseminacion, this.dtgResultado);
            

        }
        /// <summary>
        /// Lanza el formulario de Edición de Inseminacion en Modo =>Actualizar.
        /// </summary>
        
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Inseminacion ObjetoBase = (Inseminacion)this.dtgResultado.CurrentRow.DataBoundItem;

                EditInseminacion frmEditInseminacion = new EditInseminacion(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(frmEditInseminacion, this.dtgResultado);
            }
        }
       
        
        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el Combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.cmbTipo.DataSource =TipoInseminacion.Buscar();
            this.cmbTipo.DisplayMember = "Descripcion";
            this.cmbTipo.ValueMember = "Id";
            this.cmbTipo.SelectedIndex = -1;

        }
        #endregion

        #region EVENTOS BOTON

        private void btnBuscarHembra_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
        }

        private void btnBuscarMacho_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbMacho) { ValorSexoFijo = Convert.ToChar("M") });
        }
        #endregion       

    }
}
