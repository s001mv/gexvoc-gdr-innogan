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
    public partial class FindPastoreo : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindPastoreo()
        {
            InitializeComponent();
        }
        public FindPastoreo(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("FechaInicio", "Fecha Inicio");
            dtgResultado.Columns[0].DataPropertyName = "FechaInicio";           
            dtgResultado.Columns.Add("FechaFin", "Fecha Fin");
            dtgResultado.Columns[1].DataPropertyName = "FechaFin";         
            dtgResultado.Columns.Add("DescParcela", "Parcela");
            dtgResultado.Columns[2].DataPropertyName = "DescParcela";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DescLote", "Lote de Animales");
            dtgResultado.Columns[3].DataPropertyName = "DescLote";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
       

        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            //if (this.Validate(true))
            //{
            //    //int? idParcela = null;
            //    //if (cmbParcela.IdClaseActiva != 0)
            //    //    idParcela = cmbParcela.IdClaseActiva;

            //    //int? idLote = null;
            //    //if (cmbLote.IdClaseActiva != 0)
            //    //    idLote = cmbLote.IdClaseActiva;

            //    dtgResultado.DataSource = Pastoreo.Buscar(Generic.ControlAIntNullable(cmbParcela),Generic.ControlAIntNullable(cmbLote), Generic.ControlADatetimeNullable(txtFecha), null);
            //}
            AsignarOrigenDatos<Pastoreo>(Pastoreo.Buscar(Generic.ControlAIntNullable(cmbParcela), 
                                                         Generic.ControlAIntNullable(cmbLote), 
                                                         Generic.ControlADatetimeNullable(txtFecha), null));
            //dtgResultado.DataSource = Pastoreo.Buscar(Generic.ControlAIntNullable(cmbParcela), Generic.ControlAIntNullable(cmbLote), Generic.ControlADatetimeNullable(txtFecha), null);

        }
        /// <summary>
        /// Lanza el formulario de edición de Pastoreo en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Pastoreo ObjetoBase = new Pastoreo();
            this.LanzarFormulario(new EditPastoreo(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Pastoreo en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Pastoreo ObjetoBase = (Pastoreo)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditPastoreo(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarParcela_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar, cmbParcela));
            }

            private void btnBuscarLote_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindLoteAnimal(Modo.Consultar, cmbLote) { ValorFijoParidera=false});
            }
        #endregion
    }
}