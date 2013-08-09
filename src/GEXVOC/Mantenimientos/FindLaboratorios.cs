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
    public partial class FindLaboratorios : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindLaboratorios()
        {
            InitializeComponent();
        }
        public FindLaboratorios(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
        {
            InitializeComponent();
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera un estilo personalizado para el grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Nombre", "Nombre");
            dtgResultado.Columns[0].DataPropertyName = "Nombre";
            dtgResultado.Columns.Add("Direccion", "Dirección");
            dtgResultado.Columns[1].DataPropertyName = "Direccion";
            dtgResultado.Columns.Add("Telefono", "Teléfono");
            dtgResultado.Columns[2].DataPropertyName = "Telefono";
        }
        /// <summary>
        /// Obtiene los laboratorios que cumplen los criterios de busqueda de los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Laboratorio>(Laboratorio.Buscar(txtNombre.Text, txtDireccion.Text, txtTelefono.Text));
            //dtgResultado.DataSource = Laboratorio.Buscar(txtNombre.Text, txtDireccion.Text, txtTelefono.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de laboratorios en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Laboratorio ObjetoBase = new Laboratorio();
            EditLaboratorios editLaboratorios = new EditLaboratorios(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editLaboratorios, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario de edición de laboratorios en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Laboratorio ObjetoBase = (Laboratorio)this.dtgResultado.CurrentRow.DataBoundItem;
                EditLaboratorios editLaboratorios = new EditLaboratorios(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editLaboratorios, this.dtgResultado);
            
            }
        }

        #endregion
    }
}
