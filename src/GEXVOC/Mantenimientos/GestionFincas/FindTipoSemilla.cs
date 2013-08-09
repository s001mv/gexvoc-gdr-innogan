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
    public partial class FindTipoSemilla : GEXVOC.UI.GenericFind
    {
        public FindTipoSemilla()
        {
            InitializeComponent();
        }


        #region FUNCIONES SOBREESCRITAS
            /// <summary>
            /// Genera el estilo del Grid.
            /// </summary>
            protected override void GenerarEstiloGrid()
            {
                dtgResultado.Columns.Add("Familia", "Familia");
                dtgResultado.Columns[0].DataPropertyName = "DescFamilia";
                dtgResultado.Columns.Add("Descripcion", "Descripcion");
                dtgResultado.Columns[1].DataPropertyName = "descripcion";              
                dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            }
            /// <summary>
            /// Realiza la busqueda segun el criterio formado por los controles del formulario.
            /// </summary>
            protected override void Buscar()
            {
                dtgResultado.DataSource = Semilla.Buscar(Generic.ControlAIntNullable(this.cmbFamilia), txtDescripcion.Text);
            }
            /// <summary>
            /// Lanza el formulario de edición de razas en modo guardar.
            /// </summary>
            protected override void Insertar()
            {
                Semilla ObjetoBase = new Semilla();
                this.LanzarFormulario(new EditTipoSemilla(Modo.Guardar, ObjetoBase), this.dtgResultado);
            }
            /// <summary>
            /// Lanza el formulario edicion de raza en modo actualizar.
            /// </summary>
            protected override void Modificar()
            {
                if (dtgResultado.SelectedRows.Count == 1)
                {
                    Semilla ObjetoBase = (Semilla)this.dtgResultado.CurrentRow.DataBoundItem;
                    this.LanzarFormulario(new EditTipoSemilla(Modo.Actualizar, ObjetoBase), this.dtgResultado);

                }
            }

        #endregion

        #region CARGAS COMUNES
            /// <summary>
            /// Carga los combos del formulario
            /// </summary>
            protected override void CargarCombos()
            {

                this.cmbFamilia.DataSource = FamiliaSemilla.Buscar();
                this.cmbFamilia.DisplayMember = "Descripcion";
                this.cmbFamilia.ValueMember = "Id";
                this.cmbFamilia.SelectedIndex = -1;

            }
        #endregion 
    }


}
