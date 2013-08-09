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
    public partial class FindSecados : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
            public FindSecados()
            {
                InitializeComponent();
            }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipo, "Descripcion", TipoSecado.Buscar());
            this.CargarCombo(cmbMotivoSecado, "Descripcion", Motivo.Buscar());
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        /// <summary>
        /// Genera el estilo del Grid.
        /// </summary>
        protected override void GenerarEstiloGrid()
        {
            //dtgResultado.Location = new System.Drawing.Point(12, 106);
            //dtgResultado.Size = new System.Drawing.Size(610, 309);
            dtgResultado.Columns.Add("FInicio", "F.Inicio");
            dtgResultado.Columns[0].DataPropertyName = "Fecha";
            dtgResultado.Columns.Add("Hembra", "Hembra");
            dtgResultado.Columns[1].DataPropertyName = "DescHembra";
            dtgResultado.Columns.Add("Tipo", "Tipo");
            dtgResultado.Columns[2].DataPropertyName = "DescTipo";           
            dtgResultado.Columns.Add("Motivo", "Motivo");
            dtgResultado.Columns[3].DataPropertyName = "DescMotivoSecado";
            

        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            this.AsignarOrigenDatos<Secado>(Secado.Buscar(Generic.ControlAIntNullable(this.cmbTipo), Generic.ControlAIntNullable(this.cmbMotivoSecado),  Generic.ControlAIntNullable(cmbHembra), Generic.ControlADatetimeNullable(txtFecIniMayor), Generic.ControlADatetimeNullable(txtFecIniMenor), null));            
        }
        /// <summary>
        /// Lanza el formulario de edición de razas en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Secado ObjetoBase = new Secado();
            EditSecados frmLanzar = new EditSecados(Modo.Guardar, ObjetoBase);
            this.LanzarFormulario(frmLanzar, this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de raza en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Secado ObjetoBase = (Secado)this.dtgResultado.CurrentRow.DataBoundItem;
                EditSecados frmLanzar = new EditSecados(Modo.Actualizar, ObjetoBase);
                this.LanzarFormulario(frmLanzar, this.dtgResultado);

            }
        }

        private void btnBuscarHembra_Click(object sender, EventArgs e)
        {
            this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
        }
        #endregion
    }
}

