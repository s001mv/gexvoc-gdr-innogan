using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;

namespace GEXVOC.UI
{
    public partial class FindTipoInseminacion : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindTipoInseminacion()
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo personalizado del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Location = new System.Drawing.Point(12, 106);
            dtgResultado.Size = new System.Drawing.Size(610, 309);
            dtgResultado.Columns.Add("Descripcion", "T.Inseminación");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Obtiene los tipos de inseminación que coinciden con los criterios de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoInseminacion>(TipoInseminacion.Buscar(txtDescripcion.Text, null));
            //dtgResultado.DataSource = TipoInseminacion.Buscar(txtDescripcion.Text,null);
        }
        /// <summary>
        /// Lanza el formulario de edición de tipo de inseminación en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoInseminacion ObjetoBase = new TipoInseminacion();
            EditTipoInseminacion editTipoInseminacion = new EditTipoInseminacion(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTipoInseminacion, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de tipo de inseminación en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            TipoInseminacion ObjetoBase = (TipoInseminacion)dtgResultado.CurrentRow.DataBoundItem;
            EditTipoInseminacion editTipoInseminacion = new EditTipoInseminacion(Modo.Actualizar, ObjetoBase);
            this.LanzarFormulario(editTipoInseminacion, this.dtgResultado);

        }
        
        #endregion
    }
}
