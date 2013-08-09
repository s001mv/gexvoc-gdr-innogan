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
    public partial class FindMunicipios : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindMunicipios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar un formulario GenericFind con los controles propios del formulario.
        /// </summary>
        /// <param name="modo"></param>
        /// <param name="controlBusqueda"></param>
        public FindMunicipios(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();

        }
        #endregion

        # region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Crea el estilo personalizado para el Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Codigo","Código");
            dtgResultado.Columns[0].DataPropertyName = "Codigo";
            dtgResultado.Columns.Add("Descripcion", "Municipio");
            dtgResultado.Columns[1].DataPropertyName = "Descripcion";    
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio de los formularios.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Municipio>(Municipio.Buscar(txtCodigo.Text, txtDescripcion.Text, Generic.ControlAIntNullable(cmbProvincia)));
            //dtgResultado.DataSource = Municipio.Buscar(txtCodigo.Text, txtDescripcion.Text, Generic.ControlAIntNullable(cmbProvincia));

        }
        /// <summary>
        /// Lanza el formulario de edición de Municipio en modo Guardar.
        /// </summary>
        protected override void Insertar()
        {
            Municipio ObjetoBase = new Municipio();
            EditMunicipios editMunicipios = new EditMunicipios(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editMunicipios, this.dtgResultado);

        }

        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Municipio ObjetoBase = (Municipio)this.dtgResultado.CurrentRow.DataBoundItem;
                EditMunicipios FormEditMunicipios = new EditMunicipios(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(FormEditMunicipios, this.dtgResultado);

            }
        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            cmbProvincia.DataSource = Provincia.Buscar();
            cmbProvincia.DisplayMember = "Descripcion";
            cmbProvincia.ValueMember = "Id";
            cmbProvincia.SelectedIndex = -1;

        }

        #endregion

    }
}
