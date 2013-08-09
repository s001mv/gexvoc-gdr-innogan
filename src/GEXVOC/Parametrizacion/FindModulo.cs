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
    public partial class FindModulo : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindModulo()
        {
            InitializeComponent();
        }
        public FindModulo(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescPrincipal", "Principal");
            dtgResultado.Columns[1].DataPropertyName = "DescPrincipal";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Modulo>(Modulo.Buscar(null, txtDescripcion.Text));
            //dtgResultado.DataSource = Modulo.Buscar(null,txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de Modulo en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Modulo ObjetoBase = new Modulo();
            this.LanzarFormulario(new EditModulo(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Modulo en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Modulo ObjetoBase = (Modulo)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditModulo(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion
    }
}