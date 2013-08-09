using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;
using GEXVOC.UI.Clases;

namespace GEXVOC.UI
{
    public partial class FindPersonal : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FindPersonal()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario FindEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo"></param>
        /// <param name="controlBusqueda"></param>
        public FindPersonal(Modo modo,  ctlBuscarObjeto controlBusqueda)
            : base(modo,  controlBusqueda)
        {
            InitializeComponent();
          
        }
        #endregion

        #region FUNCIONES SOBREESCRITAS
        protected override void GenerarEstiloGrid()
        {
            dtgResultado.Columns.Add("Nombre", "Nombre");
            dtgResultado.Columns[0].DataPropertyName = "Nombre";
            dtgResultado.Columns.Add("Apellidos", "Apellidos");
            dtgResultado.Columns[1].DataPropertyName = "Apellidos";
            dtgResultado.Columns.Add("Telefono", "Teléfono");
            dtgResultado.Columns[2].DataPropertyName = "Telefono";
            dtgResultado.Columns.Add("Tipo", "Tipo");
            dtgResultado.Columns[3].DataPropertyName = "DescTipo";
            dtgResultado.Columns.Add("DNI", "DNI");
            dtgResultado.Columns[4].DataPropertyName = "DNI";
            dtgResultado.Columns.Add("Direccion", "Dirección");
            dtgResultado.Columns[5].DataPropertyName = "Direccion";
            dtgResultado.Columns.Add("CP", "CP");
            dtgResultado.Columns[6].DataPropertyName = "CP";         
         
           

        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void Buscar()
        {
            AsignarOrigenDatos<Veterinario>(Veterinario.Buscar(null,this.txtNombre.Text, txtApellidos.Text, txtDNI.Text, txtDireccion.Text, 
                                                               txtCP.Text, txtTelefono.Text, null, Generic.ControlAIntNullable(cmbTipo)));
            //dtgResultado.DataSource = Veterinario.Buscar(this.txtNombre.Text,txtApellidos.Text,txtDNI.Text,txtDireccion.Text,txtCP.Text, txtTelefono.Text,null,Generic.ControlAIntNullable(cmbTipo));
            
        }

        /// <summary>
        /// Lanza el formulario de edición de Personal en modo Guardar.
        /// </summary>
        protected override void Insertar()
        {
            Veterinario ObjetoBase = new Veterinario();
            EditPersonal frmLanzar = new EditPersonal(Modo.Guardar, ObjetoBase);
            LanzarFormulario(frmLanzar, dtgResultado);
            

        }
        /// <summary>
        /// Lanza el formulario de edición de Personal en modo Actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Veterinario ObjetoBase = (Veterinario)this.dtgResultado.CurrentRow.DataBoundItem;
                EditPersonal frmLanzar = new EditPersonal(Modo.Actualizar, ObjetoBase);
                LanzarFormulario(frmLanzar, dtgResultado);
            }

        }
        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            this.CargarCombo(cmbTipo, TipoPersonal.Buscar());
        }

        #endregion

    }

}
