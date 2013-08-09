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
    public partial class FindProducto : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindProducto()
        {
            InitializeComponent();
        }
        public FindProducto(Modo modo, ctlBuscarObjeto controlBusqueda)
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

                    this.Text = "Productos del tipo: " + Cadenas.ToUpperPrimerCaracter(_ValorFijoTipoProducto.Descripcion);

                    if (value.Familia != null && value.Familia == true)
                    {
                        this.cmbFamilia.Enabled = true;
                        this.cmbFamilia.Visible = true;
                        lblFamilia.Enabled = true;
                        lblFamilia.Visible = true;
                    }
                    else
                    {
                        this.cmbFamilia.Enabled = false;
                        this.cmbFamilia.Visible = false;
                        lblFamilia.Enabled = false;
                        lblFamilia.Visible = false;                        
                    
                    }

                }
                else
                    this.cmbTipoProducto.ReadOnly = false;

                _ValorFijoTipoProducto = value;
            }
        }

        public int? ValorFijoIdFamilia{get;set;}

        

        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            if (ValorFijoTipoProducto.Descripcion=="MEDICAMENTO")
            {
                dtgResultado.Columns.Add("Descripcion", "Descripcion");
                dtgResultado.Columns[0].DataPropertyName = "descripcion";
                dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgResultado.Columns.Add("SupresionLeche", "Dias Supresion Leche");
                dtgResultado.Columns[1].DataPropertyName = "SupresionLeche";
                dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtgResultado.Columns.Add("SupresionCarne", "Dias Supresion Carne");
                dtgResultado.Columns[2].DataPropertyName = "SupresionCarne";
                dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                if (ValorFijoTipoProducto != null && ValorFijoTipoProducto.Familia == true)
                {
                    dtgResultado.Columns.Add("DescFamilia", "Familia");
                    dtgResultado.Columns[0].DataPropertyName = "DescFamilia";
                    dtgResultado.Columns.Add("Descripcion", "Descripcion");
                    dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dtgResultado.Columns[1].DataPropertyName = "descripcion";
                    dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dtgResultado.Columns.Add("Descripcion", "Descripcion");
                    dtgResultado.Columns[0].DataPropertyName = "descripcion";
                    dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Producto>(Producto.Buscar(Generic.ControlAIntNullable(cmbTipoProducto), 
                                                         Generic.ControlAIntNullable(cmbFamilia), txtDescripcion.Text, null, null, null));
            //dtgResultado.DataSource = Producto.Buscar(Generic.ControlAIntNullable(cmbTipoProducto),Generic.ControlAIntNullable(cmbFamilia),txtDescripcion.Text,null,null,null);
        }
        /// <summary>
        /// Lanza el formulario de edición de Producto en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Producto ObjetoBase = new Producto();
            this.LanzarFormulario(new EditProducto(Modo.Guardar, ObjetoBase) { ValorFijoTipoProducto=this.ValorFijoTipoProducto}, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Producto en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Producto ObjetoBase = (Producto)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditProducto(Modo.Actualizar, ObjetoBase) { ValorFijoTipoProducto = this.ValorFijoTipoProducto }, this.dtgResultado);
            }
        }

      



        #endregion

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            this.CargarCombo(this.cmbFamilia, "Descripcion", Familia.Buscar(Generic.ControlAIntNullable(cmbTipoProducto),string.Empty,null));
            base.CargarCombos();
        }
        protected override void CargarValoresDefecto()
        {
            if (ValorFijoIdFamilia.HasValue)
            {
                Generic.IntNullableAControl(cmbFamilia, ValorFijoIdFamilia);
                cmbFamilia.Enabled = false;
            }
          
        }
        #endregion

    }
}