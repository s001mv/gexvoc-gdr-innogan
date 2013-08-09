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
    public partial class FindTipoParto : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindTipoParto()
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo personalizado para el grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "T.Parto");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Crias", "Crias");
            dtgResultado.Columns[1].DataPropertyName = "Crias";
        }
        /// <summary>
        /// Obtiene los tipos de parto que coincidan con los criterios de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoParto>(TipoParto.Buscar(txtDescripcion.Text, null));
            //dtgResultado.DataSource = TipoParto.Buscar(txtDescripcion.Text, null);
        }
        /// <summary>
        /// Lanza el formulario edit de tipo de partos en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoParto ObjetoBase = new TipoParto();
            EditTipoParto editTipoParto = new EditTipoParto(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTipoParto, this.dtgResultado);

        }
        /// <summary>
        /// Lanza el formulario edit de tipo de partos en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoParto ObjetoBase = (TipoParto)this.dtgResultado.CurrentRow.DataBoundItem;
                EditTipoParto editTipoParto = new EditTipoParto(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editTipoParto, this.dtgResultado);
            }
        }
        #endregion
    }
}
