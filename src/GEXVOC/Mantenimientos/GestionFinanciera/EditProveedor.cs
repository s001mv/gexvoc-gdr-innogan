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
    public partial class EditProveedor : GEXVOC.UI.GenericEdit
    {
        public bool ExplotacionAsignada { get; set; }

        #region CONTRUCTORES
        public EditProveedor()
        {
            InitializeComponent();
        }
        public EditProveedor(Modo modo, Proveedor ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Proveedor ObjetoBase { get { return (Proveedor)this.ClaseBase; } }

        public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Nombre", true, this.txtNombre, lblNombre));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "DNI", true, this.txtDNI, lblDNI) { ValidacionEspecial = ValidacionesEspeciales.EsDNI });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaAlta", true, this.txtFecAlta, lblFecAlta));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "CP", false, this.txtCP, lblCodPostal) { ValidacionEspecial = ValidacionesEspeciales.EsCodigoPostal });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Direccion", false, this.txtDireccion, lblDireccion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Telefono", false, this.txtTelefono, lblTlfno) { ValidacionEspecial = ValidacionesEspeciales.EsTelefono });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Movil", false, this.txtMovil, lblMovil) { ValidacionEspecial = ValidacionesEspeciales.EsTelefono });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Email", false, this.txtEmail, lblemail) { ValidacionEspecial = ValidacionesEspeciales.EsEmail });
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaBaja", false, this.txtFecBaja, lblFecBaja));

            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "ExplotacionAsignada", true, new CheckBox() { Checked = ExplotacionAsignada }, new Label()));

            base.DefinirListaBinding();
        }

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga los valores por defecto del formulario.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFecAlta, DateTime.Now.Date);
        }

        #endregion
    }
}
