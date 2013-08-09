using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Controles;
using GEXVOC.Core.Generic;

namespace GEXVOC.UI
{
    public partial class FindContacto : GEXVOC.UI.GenericFind
    {
        #region CONSTRUCTORES
        public FindContacto()
        {
            InitializeComponent();
        }
        public FindContacto(Modo modo, ctlBuscarObjeto controlBusqueda)
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
            dtgResultado.Columns.Add("DescTipo", "Tipo");
            dtgResultado.Columns[1].DataPropertyName = "DescTipo";   
            dtgResultado.Columns.Add("Telefono", "Teléfono");
            dtgResultado.Columns[2].DataPropertyName = "Telefono";
            dtgResultado.Columns.Add("Movil", "Móvil");
            dtgResultado.Columns[3].DataPropertyName = "Movil";                                   
            dtgResultado.Columns.Add("Email", "Email");
            dtgResultado.Columns[4].DataPropertyName = "Email";      
            
        }
        /// <summary>
        /// Realiza la busqueda segun el criterio formado por los controles del formulario.
        /// </summary>        
        protected override void Buscar()
        {
          
            AsignarOrigenDatos<Contacto>(Contacto.Buscar(Configuracion.Explotacion.Id, Generic.ControlAIntNullable(cmbTipo),
                                        txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtMovil.Text, txtEmail.Text));
         
        }


        /// <summary>
        /// Lanza el formulario de edición de Contacto en modo guardar.
        /// </summary>
        protected override void Insertar()
        {
            Contacto ObjetoBase = new Contacto();
            this.LanzarFormulario(new EditContacto(Modo.Guardar, ObjetoBase), this.dtgResultado);
        }
        /// <summary>
        /// Lanza el formulario edicion de Contacto en modo actualizar.
        /// </summary>
        protected override void Modificar()
        {
            if (dtgResultado.SelectedRows.Count == 1)
            {
                Contacto ObjetoBase = (Contacto)this.dtgResultado.CurrentRow.DataBoundItem;
                if (ObjetoBase.Id!=0)
                    this.LanzarFormulario(new EditContacto(Modo.Actualizar, ObjetoBase), this.dtgResultado);
            }
        }

        #endregion

        #region CARGAS COMUNES

            protected override void CargarCombos()
            {
                this.CargarCombo(this.cmbTipo, TipoContacto.Buscar());
                base.CargarCombos();
            }
         

        #endregion
    
    }

}


//////////////public static Contacto ClienteAContacto(Cliente cli)
//////////////{
//////////////    Contacto contacto = new Contacto();
//////////////    contacto.Nombre = cli.Nombre;
//////////////    contacto.Direccion = cli.Direccion;
//////////////    contacto.Telefono = cli.Telefono;
//////////////    return contacto;            
//////////////}
//////////////public static Contacto ProveedorAContacto(Proveedor cli)
//////////////{
//////////////    Contacto contacto = new Contacto();
//////////////    contacto.Nombre = cli.Nombre;
//////////////    contacto.Direccion = cli.Direccion;
//////////////    contacto.Telefono = cli.Telefono;
//////////////    return contacto;
//////////////}
//////////////protected override void Buscar()
//////////////{
//////////////           List<Contacto> lstContactos = Contacto.Buscar(Configuracion.Explotacion.Id, Generic.ControlAIntNullable(cmbTipo), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
//////////////           List<Cliente> lstClientes = Cliente.Buscar(txtNombre.Text, txtDireccion.Text, string.Empty, string.Empty, txtTelefono.Text, null, null);
//////////////           List<Proveedor> lstProveedores = Proveedor.Buscar(txtNombre.Text, txtDireccion.Text, string.Empty, string.Empty, txtTelefono.Text, null, null);
//////////////           List<Contacto> lstContactosClientes = lstClientes.ConvertAll(new Converter<Cliente, Contacto>(ClienteAContacto));
//////////////           List<Contacto> lstContactosProveedores = lstProveedores.ConvertAll(new Converter<Proveedor, Contacto>(ProveedorAContacto));
//////////////           lstContactos.AddRange(lstContactosClientes);
//////////////           lstContactos.AddRange(lstContactosProveedores);            
//////////////           dtgResultado.DataSource = lstContactos; //Contacto.Buscar(Configuracion.Explotacion.Id,Generic.ControlAIntNullable(cmbTipo), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
//////////////}