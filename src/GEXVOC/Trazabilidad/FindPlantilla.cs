using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class FindPlantilla : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES

        public FindPlantilla()
        {
            InitializeComponent();
        }

        #endregion

        #region FUNCIONES SOBREESCRITAS

        /// <summary>
        /// Genera un estilo propio para el Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "Proceso");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
            dtgResultado.Columns.Add("Detalle", "Descripción");
            dtgResultado.Columns[1].DataPropertyName = "Detalle";
        }

        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            dtgResultado.DataSource = Plantilla.Buscar(txtDescripcion.Text);
        }

        /// <summary>
        /// Lanza el formulario de edición de plantillas en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Plantilla ObjetoBase = new Plantilla();
            EditPlantilla editPlantilla = new EditPlantilla(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editPlantilla, this.dtgResultado);
        }

        /// <summary>
        /// Lanza el formulario de edicion de plantillas en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            this.Modificar(string.Empty);
        }

        protected void Modificar(string tab)
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Plantilla ObjetoBase = (Plantilla)this.dtgResultado.CurrentRow.DataBoundItem;
                EditPlantilla editPlantilla;

                if (tab == string.Empty)
                    editPlantilla = new EditPlantilla(Modo.Actualizar, ObjetoBase);
                else
                    editPlantilla = new EditPlantilla(Modo.Actualizar, ObjetoBase, tab);

                this.LanzarFormulario(editPlantilla, this.dtgResultado);
            }
        }

        #endregion

        #region BARRA HORIZONTAL ACCESOS

        private void btnesHorizontales_Click(object sender, EventArgs e)
        {
            Modificar(sender.ToString());
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                this.IniciarContextoOperacion();

                if (dtgResultado.SelectedRows.Count == 1)
                    ((Plantilla)this.dtgResultado.CurrentRow.DataBoundItem).Ejecutar();
            }
            catch (LogicException ex)
            {
                Generic.AvisoInformation(ex.Message);
            }
            catch (Exception ex)
            {
                Generic.AvisoError("Error en la ejecución del proceso.");
                Traza.RegistrarError(ex);
            }
            finally
            {
                this.FinalizarContextoOperacion();
            }
        }

        #endregion 
    }
}
