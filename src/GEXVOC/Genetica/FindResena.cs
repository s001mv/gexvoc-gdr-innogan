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
    public partial class FindResena : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindResena()
        {
            InitializeComponent();
        }
        public FindResena(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescAnimal", "Animal");
            dtgResultado.Columns[0].DataPropertyName = "DescAnimal";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescPersonal", "Personal");
            dtgResultado.Columns[1].DataPropertyName = "DescPersonal";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Lugar", "Lugar");
            dtgResultado.Columns[2].DataPropertyName = "Lugar";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[3].DataPropertyName = "Fecha";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            //if(this.Validate(true))
            //{
                //int? idAnimal=null;
                //if(cmbAnimal.IdClaseActiva!=0)
                //    idAnimal=cmbAnimal.IdClaseActiva;

                //int? idVeterinario=null;
                //if(cmbPersonal.IdClaseActiva!=0)
                //    idVeterinario=cmbPersonal.IdClaseActiva;

                AsignarOrigenDatos<Resena>(Resena.Buscar(Generic.ControlAIntNullable(cmbAnimal), Generic.ControlAIntNullable(cmbPersonal), string.Empty, Generic.ControlADatetimeNullable(txtFecha)));
                //dtgResultado.DataSource = Resena.Buscar(idAnimal, idVeterinario, string.Empty, Generic.ControlADatetimeNullable(txtFecha));
            //}
        }
        /// <summary>
        /// Lanza el formulario de edición de Resena en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Resena ObjetoBase = new Resena();
            this.LanzarFormulario(new EditResena(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Resena en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Resena ObjetoBase = (Resena)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditResena(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));
            }

            private void btnBuscarVeterinario_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindPersonal(Modo.Consultar, cmbPersonal));
            }
        #endregion
    }
}