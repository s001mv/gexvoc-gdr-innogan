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
using GEXVOC.Core.Clases;

namespace GEXVOC.UI
{
    public partial class FindFamilia : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindFamilia()
        {
            InitializeComponent();
        }
        public FindFamilia(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }

        TipoProducto _ValorFijoTipoProducto = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public TipoProducto ValorFijoTipoProducto
        {
            get { return _ValorFijoTipoProducto; }
            set
            {
                if (value != null)
                {
                    _ValorFijoTipoProducto = value;
                    this.cmbTipoProducto.ClaseActiva = value;
                    this.cmbTipoProducto.ReadOnly = true;
                    this.Text = "Familias del tipo: " + Cadenas.ToUpperPrimerCaracter(_ValorFijoTipoProducto.Descripcion);
                }
                else
                    this.cmbTipoProducto.ReadOnly = false;

                _ValorFijoTipoProducto = value;
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
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Familia>(Familia.Buscar(Generic.ControlAIntNullable(cmbTipoProducto), txtDescripcion.Text,null));
            //dtgResultado.DataSource = Familia.Buscar(Generic.ControlAIntNullable(cmbTipoProducto),txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de Familia en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Familia ObjetoBase = new Familia();
            this.LanzarFormulario(new EditFamilia(Modo.Guardar, ObjetoBase) { ValorFijoTipoProducto = this.ValorFijoTipoProducto }, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Familia en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Familia ObjetoBase = (Familia)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditFamilia(Modo.Actualizar, ObjetoBase) { ValorFijoTipoProducto=this.ValorFijoTipoProducto}, this.dtgResultado);
            }
        }

        #endregion
    }
}