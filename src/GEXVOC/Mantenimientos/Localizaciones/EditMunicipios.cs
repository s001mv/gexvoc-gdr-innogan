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
    public partial class EditMunicipios : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public EditMunicipios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditMunicipios(Modo modo, Municipio ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
            Cargar();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit.
        /// </summary>
        public Municipio ObjetoBase { get { return (Municipio)this.ClaseBase; } }


        int? _ValorFijoIdProvincia = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la Provincia fijo y con la seleccion que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdProvincia
        {
            get { return _ValorFijoIdProvincia; }
            set
            {
                if (value != null)
                {
                    this.CargarCombo(cmbProvincia, "Descripcion", Provincia.Buscar());            
                    this.cmbProvincia.SelectedValue =value;
                    this.cmbProvincia.Enabled = false;
                }
                else
                    this.cmbProvincia.Enabled = true;

                _ValorFijoIdProvincia = value;
            }
        }

        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)


        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Codigo", true, this.txtCodigo, lblCodigo));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, this.txtDescripcion, lblDescripcion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdProvincia", true, this.cmbProvincia, lblProvincia));
            
        }


        protected override bool Validar()
        {
            bool Rtno = true;
   
            if (!Validacion.EsCodigo(txtCodigo, 3,true,ErrorProvider)) Rtno = false;

            return Rtno;
        }


        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            cmbProvincia.CargarCombo();
        }

        #endregion

        #region COMBOS
            private void cmbProvincia_CargarContenido(object sender, EventArgs e)
            {
                if (this.ValorFijoIdProvincia == null)//Solo lo recargo si el valor idprovinciafijo es nulo, puesto que de no ser asi el combo ya se encontrará cargado
                    this.CargarCombo(cmbProvincia, "Descripcion", Provincia.Buscar());            

            }

            private void cmbProvincia_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                Provincia ObjetoBase = new Provincia();
                EditProvincia editProvincia = new EditProvincia(Modo.Guardar, ObjetoBase);
                editProvincia.Descripcion = e.TextoCrear;
                editProvincia.AccionDespuesInsertar = AccionesDespuesInsertar.Cerrar;

                CrearNuevoElementoCombo(editProvincia, sender);
                
            }

        #endregion

   
    }
}
