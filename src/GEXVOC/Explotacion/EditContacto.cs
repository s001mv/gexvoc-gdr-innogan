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
    public partial class EditContacto : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
            public EditContacto()
            {
                InitializeComponent();
            }
            public EditContacto(Modo modo, Contacto ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
            }           
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Contacto ObjetoBase { get { return (Contacto)this.ClaseBase; } }

            int? _ValorFijoIdExplotacion = null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe de aparecer con el valor de la explotación fijo.
            /// </summary>
            public int? ValorFijoIdExplotacion
            {
                get { return _ValorFijoIdExplotacion; }
                set
                {
                    if (value != null)
                    {
                        this.cmbExplotacion.ClaseActiva = Explotacion.Buscar((int)value);
                        this.cmbExplotacion.ReadOnly = true;
                    }
                    else
                        this.cmbExplotacion.ReadOnly = false;
                    _ValorFijoIdExplotacion = value;
                }
            }

          public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.cmbExplotacion.TipoDatos = typeof(Explotacion);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdExplotacion", true, this.cmbExplotacion, lblExplotacion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", false, this.cmbTipo, lblTipo));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Nombre", true, this.txtNombre, lblNombre));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Direccion", false, this.txtDireccion, lblDireccion));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Telefono", false, this.txtTelefono, lblTelefono) { ValidacionEspecial= ValidacionesEspeciales.EsTelefono});
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Movil", false, this.txtMovil, lblMovil) { ValidacionEspecial = ValidacionesEspeciales.EsTelefono });
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Email", false, this.txtEmail, lblemail) { ValidacionEspecial= ValidacionesEspeciales.EsEmail});
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Observaciones", false, this.txtObservaciones, lblObservaciones));

                base.DefinirListaBinding();
            }
        #endregion

        #region CARGAS COMUNES

            protected override void CargarCombos()
            {
                cmbTipo.CargarCombo();
            }
            protected override void CargarValoresDefecto()
            {

                if (this._ValorFijoIdExplotacion == null)
                    this.ValorFijoIdExplotacion = Configuracion.Explotacion.Id; 
                
                base.CargarValoresDefecto();
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarExplotacion_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
            }


        #endregion

        #region COMBOS
            private void cmbTipo_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(this.cmbTipo, TipoContacto.Buscar());
            }

            private void cmbTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {

                TipoContacto ObjetoBase = new TipoContacto();
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Tipo de Contacto";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto = e.TextoCrear });

                CrearNuevoElementoCombo(frmLanzar, sender);

            }
        #endregion
    }
}
