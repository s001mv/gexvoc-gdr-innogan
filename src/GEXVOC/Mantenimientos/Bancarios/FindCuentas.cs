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
    public partial class FindCuenta : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindCuenta()
        {
            InitializeComponent();
        }
        public FindCuenta(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("Cuenta", "Cuenta");
            dtgResultado.Columns[0].DataPropertyName = "Numero";
            dtgResultado.Columns.Add("Banco", "Banco");
            dtgResultado.Columns[1].DataPropertyName = "Banco";
            dtgResultado.Columns.Add("Sucursal", "Sucursal");
            dtgResultado.Columns[2].DataPropertyName = "Sucursal";
            dtgResultado.Columns.Add("Titular", "Titular");
            dtgResultado.Columns[3].DataPropertyName = "DescTitular";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            
            
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Cuenta>(Cuenta.Buscar(Generic.ControlAIntNullable(this.cmbTitular), 
                                                     this.txtBanco.Text, this.txtSucursal.Text, txtCuenta.Text));
            //dtgResultado.DataSource = Cuenta.Buscar(Generic.ControlAIntNullable(this.cmbTitular),this.txtBanco.Text,this.txtSucursal.Text,txtCuenta.Text);
        }
        /// <summary>
        /// Lanza el formulario de edición de Cuenta en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Cuenta ObjetoBase = new Cuenta();
            this.LanzarFormulario(new EditCuentas(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Cuenta en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Cuenta ObjetoBase = (Cuenta)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditCuentas(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarTitular_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindTitulares(Modo.Consultar, this.cmbTitular));
            }

        #endregion

    }
}