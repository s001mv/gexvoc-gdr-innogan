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
    public partial class FindTalla : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindTalla()
        {
            InitializeComponent();
        }
        #endregion

        # region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera un estilo personalizado para el grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "Tamaño cría");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Obtiene todos los tipos de talla segun el criterio de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Talla>(Talla.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = Talla.Buscar(txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de talla en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Talla ObjetoBase = new Talla();
            EditTalla editTalla = new EditTalla(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTalla, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de talla en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Talla ObjetoBase = (Talla)this.dtgResultado.CurrentRow.DataBoundItem;
                EditTalla editTalla = new EditTalla(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editTalla, this.dtgResultado);
            }
        }

        #endregion
    }
}
