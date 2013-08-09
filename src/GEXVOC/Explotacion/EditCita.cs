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
    public partial class EditCita : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditCita()
        {
            InitializeComponent();
        }
        public EditCita(Modo modo, Cita ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Cita ObjetoBase { get { return (Cita)this.ClaseBase; } }

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
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void ClaseBaseAControles()
        {
            if (this.ObjetoBase.IdExplotacion > 0)
                this.ValorFijoIdExplotacion = this.ObjetoBase.IdExplotacion;

            DateTime fecha = this.ObjetoBase.Fecha;
            txtFecha.Text = fecha.ToShortDateString();
            txtHora.Text = fecha.ToString("HH:mm");        
           
            base.ClaseBaseAControles();
        }

        protected override void ControlesAClaseBase()
        {
            DateTime fecha;
            if (Generic.ControlValorado(txtHora))
                fecha = Convert.ToDateTime(txtFecha.Text + " " + txtHora.Text);
            else
                fecha = Generic.ControlADatetime(txtFecha);          

            
            this.ObjetoBase.Fecha = fecha;

            base.ControlesAClaseBase();
        }

        protected override void DefinirListaBinding()
        {

            cmbExplotacion.TipoDatos = typeof(Explotacion);
            cmbContacto.TipoDatos = typeof(Contacto);
            this.lstBinding.Add(new BindingMaestro(this.ClaseBase, "IdExplotacion", true, cmbExplotacion, lblExplotacion));
            this.lstBinding.Add(new BindingMaestro(this.ClaseBase,"IdContacto",false,cmbContacto,lblContacto));          
            this.lstBinding.Add(new BindingMaestro(this.ClaseBase,"Lugar",false,txtLugar,lblLugar));
            this.lstBinding.Add(new BindingMaestro(this.ClaseBase,"Tema",false,txtTema,lblTema));

        }

        protected override bool Validar()
        {
            bool Rtno = true;
            this.ErrorProvider.Clear();

          
            if (!Generic.ControlDatosCorrectos(txtFecha, this.ErrorProvider, typeof(DateTime), true)) Rtno = false;
            if (!Generic.ControlDatosCorrectos(txtHora, this.ErrorProvider, typeof(DateTime), false)) Rtno = false;          
            

            if (Rtno)
                return base.Validar();
            else
                return false;
        }
        #endregion

        #region CARGAS COMUNES

        protected override void CargarValoresDefecto()
        {

            if (this._ValorFijoIdExplotacion == null)
                this.ValorFijoIdExplotacion = Configuracion.Explotacion.Id;

            base.CargarValoresDefecto();
        }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            private void btnBuscarContacto_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindContacto(Modo.Consultar, this.cmbContacto));
            }

            private void btnBuscarExplotacion_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindExplotaciones(Modo.Consultar, this.cmbExplotacion));
            }
        
        #endregion

        #region COMBOS
            private void cmbContacto_CrearNuevo(object sender, EventArgs e)
            {
                
                Contacto ObjetoBase = new Contacto();
                EditContacto editContacto = new EditContacto(Modo.Guardar, ObjetoBase);                

                CrearNuevoElementoCombo(editContacto, sender);
             
            }
        #endregion
       
    }
}
