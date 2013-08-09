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
    public partial class FindPartos : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FindPartos()
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
            dtgResultado.Columns.Add("Fecha", "Fecha");
            dtgResultado.Columns[0].DataPropertyName = "Fecha";
            dtgResultado.Columns.Add("DescHembra", "Hembra");
            dtgResultado.Columns[1].DataPropertyName = "DescHembra";
            dtgResultado.Columns.Add("DescTipo", "Tipo");
            dtgResultado.Columns[2].DataPropertyName = "DescTipo";
            dtgResultado.Columns.Add("DescFacilidad", "Dificultad");
            dtgResultado.Columns[3].DataPropertyName = "DescFacilidad";
            dtgResultado.Columns.Add("Vivos", "Vivos");
            dtgResultado.Columns[4].DataPropertyName = "Vivos";
            dtgResultado.Columns.Add("Muertos", "Muertos");
            dtgResultado.Columns[5].DataPropertyName = "Muertos";
         
        }
        /// <summary>
        /// Devuelve los partos que cumplen los criterios de busqueda de los formularios.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Parto>(Parto.Buscar(Generic.ControlAIntNullable(cmbHembra), Generic.ControlAIntNullable(cmbTipo), Generic.ControlAIntNullable(cmbDificultad), Generic.ControlAIntNullable(txtVivos), Generic.ControlAIntNullable(txtMuertos), Generic.ControlADatetimeNullable(this.txtFecIniMayor), Generic.ControlADatetimeNullable(this.txtFecIniMenor), null));
            //dtgResultado.DataSource = Parto.Buscar(Generic.ControlAIntNullable(cmbHembra),Generic.ControlAIntNullable(cmbTipo),Generic.ControlAIntNullable(cmbDificultad),Generic.ControlAIntNullable(txtVivos),Generic.ControlAIntNullable(txtMuertos), Generic.ControlADatetimeNullable(this.txtFecIniMayor), Generic.ControlADatetimeNullable(this.txtFecIniMenor), null);
        }
        /// <summary>
        /// Lanza el formulario de edición de un parto en modo guardar.
        /// </summary>
        
        protected override void Insertar()

        {
            Parto ObjetoBase = new Parto();
            EditPartos editPartos = new EditPartos(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(editPartos, this.dtgResultado);
        }

        /// <summary>
        /// Lanza el formulario de edicion de un parto en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Parto ObjetoBase = (Parto)dtgResultado.CurrentRow.DataBoundItem;
                EditPartos editPartos = new EditPartos(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(editPartos, this.dtgResultado);
            }
        }

        
        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga los combos del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.cmbTipo.DataSource = TipoParto.Buscar();
            this.cmbTipo.DisplayMember = "Descripcion";
            this.cmbTipo.ValueMember = "Id";
            this.cmbTipo.SelectedIndex = -1;

            this.cmbDificultad.DataSource = Facilidad.Buscar();
            this.cmbDificultad.DisplayMember = "Descripcion";
            this.cmbDificultad.ValueMember = "Id";
            this.cmbDificultad.SelectedIndex = -1;

            
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
        /// <summary>
        /// Lanza el formulario de busqueda de animarlies en modo consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarHembra_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
        }

        #endregion
        
    }
}
