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
    public partial class FindTipoCondicion : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTipoCondicion()
        {
            InitializeComponent();
        }
        public FindTipoCondicion(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescEspecie", "Especie");
            dtgResultado.Columns[0].DataPropertyName = "DescEspecie";
            dtgResultado.Columns.Add("Codigo", "Código");
            dtgResultado.Columns[1].DataPropertyName = "Codigo";
            dtgResultado.Columns.Add("Descripcion", "Descripcion");
            dtgResultado.Columns[2].DataPropertyName = "descripcion";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewCheckBoxColumn d = new DataGridViewCheckBoxColumn();
            d.DataPropertyName = "Apta";
            d.HeaderText = "Apta";
            dtgResultado.Columns.Add(d);
         

        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            //dtgResultado.DataSource = TipoCondicion.Buscar(Generic.ControlAIntNullable(cmbEspecie),Generic.ControlACharNullable(txtCodigo),txtDescripcion.Text,string.Empty,null);//txtDescripcion.Text);
            AsignarOrigenDatos<TipoCondicion>(TipoCondicion.Buscar(Generic.ControlAIntNullable(cmbEspecie), 
                                                                   txtCodigo.Text, 
                                                                   txtDescripcion.Text, string.Empty, null));
        }
        /// <summary>
        /// Lanza el formulario de edición de TipoCondicion en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoCondicion ObjetoBase = new TipoCondicion();
            this.LanzarFormulario(new EditTipoCondicion(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TipoCondicion en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoCondicion ObjetoBase = (TipoCondicion)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTipoCondicion(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

       

        #endregion

        #region CARGAS COMUNES
             protected override void CargarCombos()
            {
                this.CargarCombo(cmbEspecie, Especie.Buscar());
                base.CargarCombos();
            }
        #endregion

       
    }
}