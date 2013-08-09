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
    public partial class FindAbonado : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindAbonado()
        {
            InitializeComponent();
        }
        public FindAbonado(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DesAbono", "Abono");
            dtgResultado.Columns[1].DataPropertyName = "DescAbono";
            dtgResultado.Columns.Add("DesParcela", "Parcela");
            dtgResultado.Columns[2].DataPropertyName = "DescParcela";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Cantiad", "Cantidad");
            dtgResultado.Columns[3].DataPropertyName = "cantidad";            
  
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Abonado>(Abonado.Buscar(Generic.ControlAIntNullable(this.cmbAbono), 
                                                       Generic.ControlAIntNullable(cmbParcela), null, 
                                                       Generic.ControlADatetimeNullable(txtFecha)));
            //dtgResultado.DataSource = Abonado.Buscar(Generic.ControlAIntNullable(this.cmbAbono),Generic.ControlAIntNullable(cmbParcela),null,Generic.ControlADatetimeNullable(txtFecha));
        }
        /// <summary>
        /// Lanza el formulario de edición de Abonado en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Abonado ObjetoBase = new Abonado();
            this.LanzarFormulario(new EditAbonado(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Abonado en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Abonado ObjetoBase = (Abonado)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditAbonado(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        protected override void CargarCombos()
        {
            this.CargarCombo(cmbParcela, "Nombre", Parcela.Buscar());
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAbono_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindProducto(Modo.Consultar, cmbAbono)
                {
                    ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA),
                    ValorFijoIdFamilia = Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.ABONO).Id
                });
            }

        #endregion

    }
}