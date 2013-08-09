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
    public partial class FindProveedor : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindProveedor()
        {
            InitializeComponent();
        }
        public FindProveedor(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("Nombre", "Nombre");
            dtgResultado.Columns[0].DataPropertyName = "Nombre";
            dtgResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("DNI", "DNI");
            dtgResultado.Columns[1].DataPropertyName = "DNI";
            dtgResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Direccion", "Direccion");
            dtgResultado.Columns[2].DataPropertyName = "Direccion";
            dtgResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("CP", "CP");
            dtgResultado.Columns[3].DataPropertyName = "CP";
            dtgResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("Telefono", "Telefono");
            dtgResultado.Columns[4].DataPropertyName = "Telefono";
            dtgResultado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("FechaAlta", "F.Alta");
            dtgResultado.Columns[5].DataPropertyName = "FechaAlta";
            dtgResultado.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgResultado.Columns.Add("FechaBaja", "F.Baja");
            dtgResultado.Columns[6].DataPropertyName = "FechaBaja";
            dtgResultado.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        protected override void Buscar()
        {
            //AsignarOrigenDatos<Proveedor>(Proveedor.Buscar(txtNombre.Text, txtDireccion.Text, txtCP.Text, txtDNI.Text, txtTelefono.Text, null, null));
            //dtgResultado.DataSource = Proveedor.Buscar(txtNombre.Text,txtDireccion.Text,txtCP.Text,txtDNI.Text,txtTelefono.Text,null,null);

            if (chkTodasExplotaciones.Checked)
                AsignarOrigenDatos<Proveedor>(Proveedor.Buscar(txtNombre.Text, txtDireccion.Text, txtCP.Text, txtDNI.Text, txtTelefono.Text, null, null));
            else
                AsignarOrigenDatos<Proveedor>(Explotacion.BuscarProveedores(Configuracion.Explotacion.Id, txtNombre.Text, txtDireccion.Text, txtCP.Text, txtDNI.Text, txtTelefono.Text, null, null));
        }

        /// <summary>
        /// Lanza el formulario de edición de Proveedor en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Proveedor ObjetoBase = new Proveedor();
            this.LanzarFormulario(new EditProveedor(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Proveedor en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Proveedor ObjetoBase = (Proveedor)this.dtgResultado.CurrentRow.DataBoundItem;
                this.LanzarFormulario(new EditProveedor(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion
    }
}