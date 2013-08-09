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
using GEXVOC.Core.Reflection;

namespace GEXVOC.UI
{
    public partial class FindLoteAnimal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindLoteAnimal()
        {
            InitializeComponent();
        }
        public FindLoteAnimal(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }
        bool? _ValorFijoParidera = null;

        public bool? ValorFijoParidera
        {
            get { return _ValorFijoParidera; }
            set 
            { 
                _ValorFijoParidera = value; 
            }
        }

        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "Descripcion");
            dtgResultado.Columns[0].DataPropertyName = "descripcion";            
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtgResultado.Columns.Add("DescTipo", "Tipo");
            dtgResultado.Columns[1].DataPropertyName = "DescTipo";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

            
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<LoteAnimal>(LoteAnimal.Buscar(Configuracion.Explotacion.Id,  txtDescripcion.Text, null, null,null,
                Generic.ControlAIntNullable(cmbTipoLote)));
           //dtgResultado.DataSource = LoteAnimal.Buscar(Configuracion.Explotacion.Id,null,txtDescripcion.Text,chkParidera.Checked,null,null);
        }
        /// <summary>
        /// Lanza el formulario de edición de LoteAnimal en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            LoteAnimal ObjetoBase = new LoteAnimal();
            this.LanzarFormulario(new EditLoteAnimal(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de LoteAnimal en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            Modificar(null);
        }

        protected void Modificar(string TabSeleccionar)
        {

            if (dtgResultado.SelectedRows.Count == 1)
            {
                LoteAnimal ObjetoBase = (LoteAnimal)this.dtgResultado.CurrentRow.DataBoundItem;
                EditLoteAnimal frmEditLoteAnimales;
                if (TabSeleccionar == string.Empty)
                    frmEditLoteAnimales = new EditLoteAnimal(Modo.Actualizar, ObjetoBase);
                else
                    frmEditLoteAnimales = new EditLoteAnimal(Modo.Actualizar, ObjetoBase, TabSeleccionar);

                this.LanzarFormulario(frmEditLoteAnimales, this.dtgResultado);

            }
        }

        protected override void CargarValoresDefecto()
        {
            //if (ValorFijoParidera!=null)
            //{
            //    chkParidera.Checked = (bool)ValorFijoParidera;
            //    chkParidera.Enabled = false;
            //}          
 
            base.CargarValoresDefecto();
            

        }

        #endregion

        #region CARGAS COMUNES

        protected override void CargarCombos()
        {
            this.CargarCombo(this.cmbTipoLote, TipoLote.Buscar());
            base.CargarCombos();
        }

        #endregion

        #region BARRA HORIZONTAL ACCESOS
        private void botones_Click(object sender, EventArgs e)
            {
                Modificar(sender.ToString());
            }           
        #endregion

        #region PROPIEDADES PARA PROCESOS
            [ProcesoDescripcion("Búsqueda de Lotes - Muestra el botón: Cubriciones (en la barra superior)", "Reproducción")]
            public bool _proceso_Reproduccion
            {
                set
                {
                    if (!value) SubBarraHerramientas.Items.Remove(btnCubriciones);

                }
            }

            #endregion
    }
}