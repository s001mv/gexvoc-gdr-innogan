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
    public partial class FindNaturaleza : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindNaturaleza()
        {
            InitializeComponent();
        }
        public FindNaturaleza(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("Descripcion", "Naturaleza del Gasto");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Naturaleza>(Naturaleza.Buscar(txtDescripcion.Text, null));
            //dtgResultado.DataSource = Naturaleza.Buscar(txtDescripcion.Text,null);
        }
        /// <summary>
        /// Lanza el formulario de edición de Naturaleza en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Naturaleza ObjetoBase = new Naturaleza();
            this.LanzarFormulario(new EditNaturaleza(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Naturaleza en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Naturaleza ObjetoBase = (Naturaleza)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditNaturaleza(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion
    }
}
