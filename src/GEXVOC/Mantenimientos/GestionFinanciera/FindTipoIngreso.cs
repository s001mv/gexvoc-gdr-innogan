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
    public partial class FindTipoIngreso : GEXVOC.UI.GenericFind
    {
		#region CONSTRUCTORES
	        public FindTipoIngreso()
    	    {
        	    InitializeComponent();
	        }
   			public FindTipoIngreso(Modo modo, ctlBuscarObjeto controlBusqueda): base(modo, controlBusqueda)
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
    	        dtgResultado.Columns.Add("Descripcion", "T.Ingreso");
        	    dtgResultado.Columns[0].DataPropertyName = "descripcion";
            	dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
	        }
    	    /// <summary>
        	/// Realiza la busqueda segun el criterio formado por los controles del formulario.
	        /// </summary>
    	    protected override void Buscar()
        	{
            	dtgResultado.DataSource = TipoIngreso.Buscar(txtDescripcion.Text);
	        }
    	    /// <summary>
        	/// Lanza el formulario de edición de TipoIngreso en modo guardar.
	        /// </summary>
    	    protected override void Insertar()
        	{
            	TipoIngreso ObjetoBase = new TipoIngreso();
	            this.LanzarFormulario(new EditTipoIngreso(Modo.Guardar, ObjetoBase), this.dtgResultado);
    	    }
        	/// <summary>
	        /// Lanza el formulario edicion de TipoIngreso en modo actualizar.
    	    /// </summary>
	        protected override void Modificar()
    	    {
        	    if (dtgResultado.SelectedRows.Count == 1)
            	{
                	TipoIngreso ObjetoBase = (TipoIngreso)this.dtgResultado.CurrentRow.DataBoundItem;
	                this.LanzarFormulario(new EditTipoIngreso(Modo.Actualizar, ObjetoBase), this.dtgResultado);
	            }
    	    }

 		#endregion
	}
}
