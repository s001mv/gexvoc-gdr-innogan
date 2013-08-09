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
    public partial class FindTratProfilaxis : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindTratProfilaxis()
        {
            InitializeComponent();
        }
        public FindTratProfilaxis(Modo modo, ctlBuscarObjeto controlBusqueda)
            : base(modo, controlBusqueda)
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
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[0].DataPropertyName = "Fecha";
            dtgResultado.Columns.Add("DescPrograma", "Programa");
            dtgResultado.Columns[1].DataPropertyName = "DescPrograma";
            dtgResultado.Columns.Add("Detalle", "Detalle");
            dtgResultado.Columns[2].DataPropertyName = "Detalle";

            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<TratProfilaxis>(TratProfilaxis.Buscar(null,Generic.ControlAIntNullable(cmbPrograma), txtDetalle.Text, 
                                                                     Generic.ControlADatetimeNullable(txtFecha)));
            //dtgResultado.DataSource = TratProfilaxis.Buscar(Generic.ControlAIntNullable(cmbPrograma),txtDetalle.Text,Generic.ControlADatetimeNullable(txtFecha));
        }
        /// <summary>
        /// Lanza el formulario de edición de TratProfilaxis en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            TratProfilaxis ObjetoBase = new TratProfilaxis();
            this.LanzarFormulario(new EditTratProfilaxis(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de TratProfilaxis en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                TratProfilaxis ObjetoBase = (TratProfilaxis)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditTratProfilaxis(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbPrograma, Programa.Buscar());
            base.CargarCombos();
        }

        #endregion
    }
}