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
    public partial class EditCliente : GEXVOC.UI.GenericEdit
    {
        public bool ExplotacionAsignada { get; set; }

        #region CONTRUCTORES
        public EditCliente()
        {
            InitializeComponent();
        }
        public EditCliente(Modo modo, Cliente ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Cliente ObjetoBase { get { return (Cliente)this.ClaseBase; } }

        public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Nombre", true, this.txtNombre, lblNombre));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "DNI", true, this.txtDNI, lblDNI) { ValidacionEspecial= ValidacionesEspeciales.EsDNI});
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaAlta", true, this.txtFecAlta, lblFecAlta));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "CP", false, this.txtCP, lblCodPostal) { ValidacionEspecial= ValidacionesEspeciales.EsCodigoPostal});
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Direccion", false, this.txtDireccion, lblDireccion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Telefono", false, this.txtTelefono, lblTlfno) { ValidacionEspecial = ValidacionesEspeciales.EsTelefono });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Movil", false, this.txtMovil, lblMovil) { ValidacionEspecial = ValidacionesEspeciales.EsTelefono });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Email", false, this.txtEmail, lblemail) { ValidacionEspecial = ValidacionesEspeciales.EsEmail });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaBaja", false, this.txtFecBaja, lblFecBaja));

            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "ExplotacionAsignada", true, new CheckBox() { Checked = ExplotacionAsignada }, new Label()));

            base.DefinirListaBinding();
        }


        ///// <summary>
        ///// Pasa los valores de la clase base a los controles del formulario.
        ///// </summary>
        //protected override void ClaseBaseAControles()
        //{
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Nombre", txtNombre);
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Direccion", txtDireccion);
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "CP", txtCP);
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "DNI", txtDNI);
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "Telefono", txtTelefono);
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "FechaAlta", txtFecAlta);
        //    Generic.ClaseBaseAcontrol(this.ObjetoBase, "FechaBaja", txtFecBaja);
        //}
        ///// <summary>
        ///// Pasa los valores de los controles del formulario a la clase base.
        ///// </summary>
        //protected override void ControlesAClaseBase()
        //{
        //    Generic.ControlAClaseBase(this.ObjetoBase, "Nombre", txtNombre);
        //    Generic.ControlAClaseBase(this.ObjetoBase, "Direccion", txtDireccion);
        //    Generic.ControlAClaseBase(this.ObjetoBase, "CP", txtCP);
        //    Generic.ControlAClaseBase(this.ObjetoBase, "DNI", txtDNI);
        //    Generic.ControlAClaseBase(this.ObjetoBase, "Telefono", txtTelefono);
        //    Generic.ControlAClaseBase(this.ObjetoBase, "FechaAlta", txtFecAlta);
        //    Generic.ControlAClaseBase(this.ObjetoBase, "FechaBaja", txtFecBaja);
            
        //}



        ///// <summary>
        ///// Validación de los Controles, se produce antes de actualizar la ClaseBase.
        ///// </summary>
        ///// <returns>Controles válidos (Si/No)</returns>
        //protected override bool Validar()
        //{
        //    bool Rtno = true;
        //    this.ErrorProvider.Clear();
        //    if (!Generic.ControlValorado(new Control[] {txtFecAlta,txtDNI,txtNombre}, this.ErrorProvider))
        //        Rtno = false;
        //    if(!Generic.ControlDatosCorrectos(txtFecAlta,this.ErrorProvider,"El valor introducido no es una fecha",typeof (System.DateTime),true))
        //        Rtno=false;
        //    if(!Generic.ControlDatosCorrectos(txtFecBaja,this.ErrorProvider,"El valor introducido no es una fecha",typeof(System.DateTime),false))
        //        Rtno=false;
        //    if(!Validacion.EsCodigoPostal(txtCP,false))
        //        Rtno=false;
        //    if(!Validacion.EsTelefono(txtTelefono,false))
        //        Rtno=false;

        //    return Rtno;

        //}

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga valores por defecto del formulario.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(this.txtFecAlta, DateTime.Now.Date);
        }

        #endregion 

        
    }
}