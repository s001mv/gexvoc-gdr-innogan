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
    public partial class FindRazas : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindRazas()
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
            dtgResultado.Columns.Add("Descripcion", "Especie");
            dtgResultado.Columns[0].DataPropertyName = "DescEspecie";
            dtgResultado.Columns.Add("Descripcion","Raza");
            dtgResultado.Columns[1].DataPropertyName="Descripcion";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


         

        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Raza>(Raza.Buscar(txtDescripcion.Text, Generic.ControlAIntNullable(cmbEspecie)));
            //dtgResultado.DataSource = Raza.Buscar(txtDescripcion.Text, Generic.ControlAIntNullable(cmbEspecie));
        }
        /// <summary>
        /// Lanza el formulario de edición de razas en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Raza ObjetoBase = new Raza();
            EditRazas editRazas = new EditRazas(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editRazas, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de raza en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Raza ObjetoBase = (Raza)this.dtgResultado.CurrentRow.DataBoundItem;
                EditRazas FormEditRazas = new EditRazas(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(FormEditRazas, this.dtgResultado);
            
            }
        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario
        /// </summary>
        protected override void CargarCombos()
        {
            cmbEspecie.DataSource = Especie.Buscar();
            cmbEspecie.DisplayMember = "Descripcion";
            cmbEspecie.ValueMember = "Id";
            cmbEspecie.SelectedIndex = -1;
        }
        #endregion
    }
}
