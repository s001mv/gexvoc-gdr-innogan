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
    public partial class FindCita : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindCita()
        {
            InitializeComponent();
        }
        public FindCita(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescContacto", "Contacto");
            dtgResultado.Columns[1].DataPropertyName = "DescContacto";
            dtgResultado.Columns.Add("Lugar", "Lugar");
            dtgResultado.Columns[2].DataPropertyName = "Lugar";            
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Tema", "Tema");
            dtgResultado.Columns[3].DataPropertyName = "Tema";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {

            AsignarOrigenDatos<Cita>(Cita.Buscar(Configuracion.Explotacion.Id, Generic.ControlAIntNullable(cmbContacto), 
                                     Generic.ControlADatetimeNullable(txtFechaDesde), Generic.ControlADatetimeNullable(txtFechaHasta), 
                                     txtLugar.Text, txtTema.Text));
            //dtgResultado.DataSource = Cita.Buscar(Configuracion.Explotacion.Id, Generic.ControlAIntNullable(cmbContacto), Generic.ControlADatetimeNullable(txtFechaDesde), Generic.ControlADatetimeNullable(txtFechaHasta), txtLugar.Text, txtTema.Text);

        }
        /// <summary>
        /// Lanza el formulario de edición de Cita en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Cita ObjetoBase = new Cita();
            this.LanzarFormulario(new EditCita(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Cita en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Cita ObjetoBase = (Cita)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditCita(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        

        #endregion

        #region CARGAS COMUNES
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFechaDesde, DateTime.Today);
            base.CargarValoresDefecto();
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindContacto(Modo.Consultar, this.cmbContacto));
        }


        #endregion


    }
}
