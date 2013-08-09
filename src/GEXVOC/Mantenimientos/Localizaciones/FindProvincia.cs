using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;
using GEXVOC.UI.Clases;


namespace GEXVOC.UI
{
    public partial class FindProvincia : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindProvincia()
        {
            InitializeComponent();
               
        }
        
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Crea el estilo personalizado para el Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Codigo", "Código");
            dtgResultado.Columns[0].DataPropertyName = "Codigo";
            dtgResultado.Columns.Add("Descripcion", "Provincia");
            dtgResultado.Columns[1].DataPropertyName = "Descripcion";
        }
        /// <summary>
        /// Realiza la Busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Provincia>(Provincia.Buscar(txtCodigo.Text, txtDescripcion.Text));
            //dtgResultado.DataSource = Provincia.Buscar(txtCodigo.Text, txtDescripcion.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de provincias en modo Guardar.
        /// </summary>
        protected override void Insertar()
        {
            Provincia ObjetoBase = new Provincia();
            EditProvincia editProvincia = new EditProvincia(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editProvincia, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de Provincias en modo Actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Provincia ObjetoBase = (Provincia)this.dtgResultado.CurrentRow.DataBoundItem;
                EditProvincia FormEditProvincia = new EditProvincia(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(FormEditProvincia, this.dtgResultado);
            }   
        }

        
       
        #endregion


    }
}
