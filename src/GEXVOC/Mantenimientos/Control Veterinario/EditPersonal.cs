using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Controles;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Logic;

namespace GEXVOC.UI
{
    public partial class EditPersonal : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EditPersonal()
        {
            InitializeComponent();            
        }
        /// <summary>
        /// Sobrecarga del Constructor que nos permite inicializar un formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario Edit</param>
        /// <param name="ClaseBase">Clase Base sobre la que actua el formulario Edit</param>
        public EditPersonal(Modo modo, Veterinario ClaseBase):base (modo, ClaseBase)
        {
            InitializeComponent();
            
        }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit.
        /// </summary>

        public Veterinario ObjetoBase { get { return (Veterinario)this.ClaseBase; } }
        public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Nombre", true, this.txtNombre, lblNombre));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Apellidos", true, this.txtApellidos, lblApellidos));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "DNI", false, this.txtDNI, lblDNI) { ValidacionEspecial= ValidacionesEspeciales.EsDNI});
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Telefono", false, this.txtTelefono, lblTlfno) { ValidacionEspecial = ValidacionesEspeciales.EsTelefono });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Direccion", false, this.txtDireccion, lblDireccion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "CP", false, this.txtCP, lblCodPostal) { ValidacionEspecial = ValidacionesEspeciales.EsCodigoPostal });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaNacimiento", false, this.txtFecNacimiento, lblFecNacimiento));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Movil", false, this.txtMovil, lblMovil) { ValidacionEspecial = ValidacionesEspeciales.EsTelefono });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Email", false, this.txtEmail, lblemail) { ValidacionEspecial = ValidacionesEspeciales.EsEmail });



            base.DefinirListaBinding();
        }
            /////// <summary>
            /////// Pasa los valores de la Clase Base a los Controles del Formulario.
            /////// </summary>
            ////protected override void ClaseBaseAControles()
            ////{
            ////    txtNombre.Text = this.ObjetoBase.Nombre;
            ////    txtApellidos.Text = this.ObjetoBase.Apellidos;
            ////    txtDNI.Text = this.ObjetoBase.DNI;
            ////    txtDireccion.Text = this.ObjetoBase.Direccion;
            ////    txtCP.Text = this.ObjetoBase.CP;
            ////    txtTelefono.Text = this.ObjetoBase.Telefono;
            ////    Generic.DatetimeNullableAControl(txtFecNacimiento, this.ObjetoBase.FechaNacimiento);
            ////}
            /////// <summary>
            /////// Pasa los valores de los controles del formulario a la Clase Base.
            /////// </summary>
            ////protected override void ControlesAClaseBase()
            ////{
            ////    this.ObjetoBase.Nombre = txtNombre.Text;
            ////    this.ObjetoBase.Apellidos = txtApellidos.Text;
            ////    this.ObjetoBase.DNI = txtDNI.Text;
            ////    this.ObjetoBase.Direccion = txtDireccion.Text;
            ////    this.ObjetoBase.CP = txtCP.Text;
            ////    this.ObjetoBase.Telefono = txtTelefono.Text;
            ////    this.ObjetoBase.FechaNacimiento =Generic.ControlADatetimeNullable(this.txtFecNacimiento);
                
            ////}
            /////// <summary>
            /////// Validación de controles se utiliza antes de actualizar la claseBase.
            /////// </summary>
            /////// <returns></returns>
            ////protected override bool Validar()
            ////{
            ////    {
            ////        bool Rtno = true;
            ////        this.ErrorProvider.Clear();
            ////        if (!Generic.ControlValorado (new Control[]{txtApellidos,txtNombre}, this.ErrorProvider))
            ////            Rtno = false;
            ////        if (!Generic.ControlDatosCorrectos(this.txtFecNacimiento,  this.ErrorProvider, "El valor introducido no es del tipo fecha", typeof(System.DateTime), false))
            ////            Rtno = false;
            ////        if (!Validacion.EsTelefono(txtTelefono, false))
            ////            Rtno = false;
            ////        if (!Validacion.EsCodigoPostal(txtCP, false))
            ////            Rtno = false;

            ////        return Rtno;
            ////    }

            ////}
        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            cmbTipo.CargarCombo();
        }

        #endregion

        #region COMBOS
            private void cmbTipo_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbTipo, TipoPersonal.Buscar());
            }

            private void cmbTipo_CrearNuevo(object sender, ctlComboCrearNuevoEventArgs e)
            {
                
                TipoPersonal ObjetoBase = new TipoPersonal();                
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Tipo Personal";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto=e.TextoCrear});

                CrearNuevoElementoCombo(frmLanzar, sender);
            }
        #endregion

    }
}
