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
    public partial class FindRacion : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindRacion()
        {
            InitializeComponent();
        }
        public FindRacion(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("Descripcion", "Descripcion");
            dtgResultado.Columns[0].DataPropertyName = "descripcion";
            //dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Peso", "Peso");
            dtgResultado.Columns[1].DataPropertyName = "Peso";
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Racion>(Racion.Buscar(txtDescripcion.Text, Generic.ControlADecimalNullable(this.txtPeso)));
            //dtgResultado.DataSource = Racion.Buscar(txtDescripcion.Text,Generic.ControlADecimalNullable(this.txtPeso));
        }
        /// <summary>
        /// Lanza el formulario de edición de Racion en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Racion ObjetoBase = new Racion();
            this.LanzarFormulario(new EditRacion(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Racion en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Racion ObjetoBase = (Racion)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditRacion(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion
    }
}
