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
    public partial class FindTipoBaja : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindTipoBaja()
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera un estilo personalizado al dataGrid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "T.Baja");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Obtiene las bajas segun el criterio de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoBaja>(TipoBaja.Buscar(txtDescripcion.Text, null));
            //dtgResultado.DataSource = TipoBaja.Buscar(txtDescripcion.Text,null);

        }
        /// <summary>
        /// Lanza el formulario de edición de tipo de baja en modo guardar
        /// </summary>
        protected override void Insertar()
        {
            TipoBaja ObjetoBase = new TipoBaja();
            EditTipoBaja editTipoBaja = new EditTipoBaja(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editTipoBaja, this.dtgResultado);
   
        }
        /// <summary>
        /// Lanza el formulario de edición de tipo de alta en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoBaja ObjetoBase = (TipoBaja)this.dtgResultado.CurrentRow.DataBoundItem;
                EditTipoBaja formEditTipoBaja = new EditTipoBaja(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(formEditTipoBaja, this.dtgResultado);
            }
        }


        #endregion
    }
}
