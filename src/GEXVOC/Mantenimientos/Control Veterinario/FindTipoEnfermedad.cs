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
    public partial class FindTipoEnfermedad : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindTipoEnfermedad()
        {
            InitializeComponent();
        }

        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera un estilo personalizado del grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            
            dtgResultado.Columns.Add("Descripcion", "T.Enfermedad");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Devuelve los tipos de enfermedad segun el criterio de busqueda.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TipoEnfermedad>(TipoEnfermedad.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = TipoEnfermedad.Buscar(txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edicion de tipo de enfermedad en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TipoEnfermedad ObjetoBase = new TipoEnfermedad();
            GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
            frmLanzar.Titulo = "Tipo de Enfermedad";
            frmLanzar.NumColumnas = 2;
            frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));


            this.LanzarFormulario(frmLanzar, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edicion de tipo de enfermedad en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TipoEnfermedad ObjetoBase = (TipoEnfermedad)this.dtgResultado.CurrentRow.DataBoundItem;

                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Actualizar, ObjetoBase);
                frmLanzar.Titulo = "Tipo de Enfermedad";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));

                this.LanzarFormulario(frmLanzar, this.dtgResultado);            
            }
        }

        #endregion
        
    }
}
