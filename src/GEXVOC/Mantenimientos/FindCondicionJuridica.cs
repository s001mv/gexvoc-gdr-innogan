using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;



namespace GEXVOC.UI
{
    public partial class FindCondicionJuridica : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindCondicionJuridica()
        {
            InitializeComponent();
            Cargar();
        }
       

        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera un estilo personalizado del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Descripcion", "C.Jurídica");
            dtgResultado.Columns[0].DataPropertyName = "Descripcion";
        }
      
        
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<CondicionJuridica>(CondicionJuridica.Buscar(txtDescripcion.Text));
            //dtgResultado.DataSource = CondicionJuridica.Buscar(txtDescripcion.Text);

        }
        /// <summary>
        /// Lanza el formulario de edición de condiciones jurídicas en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            CondicionJuridica ObjetoBase = new CondicionJuridica();
            EditCondicionJuridica editCondicionJuridica = new EditCondicionJuridica(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editCondicionJuridica, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de condiciones jurídicas en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                CondicionJuridica objetoBase = (CondicionJuridica)this.dtgResultado.CurrentRow.DataBoundItem;
                EditCondicionJuridica FormEditCondicionJuridica = new EditCondicionJuridica(Modo.Actualizar, objetoBase);
                this.LanzarFormulario(FormEditCondicionJuridica, this.dtgResultado);
            }
        }

        #endregion
    }
        
}
