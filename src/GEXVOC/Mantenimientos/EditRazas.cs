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
    public partial class EditRazas : GEXVOC.UI.GenericEdit
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public EditRazas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sobrecarga del constructor que nos permite inicializar el formulario GenericEdit con los datos propios del formulario.
        /// </summary>
        /// <param name="modo">Modo de apertura del formulario</param>
        /// <param name="ClaseBase">Clase base del formulario</param>
        public EditRazas(Modo modo, Raza ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();

        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        /// <summary>
        /// Propiedad tipada que nos devuelve la clase base sobre la que actúa el formulario edit.
        /// </summary>
        public Raza ObjetoBase { get { return (Raza)this.ClaseBase; } }

        public int? ValorEspecieFijo { get; set; }
        public string Descripcion { get { return txtDescripcion.Text; } set { txtDescripcion.Text = value; } }

        #endregion

        #region BINDING (Intercambio de datos entre la clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdEspecie", true, this.cmbEspecie, lblEspecie));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Descripcion", true, this.txtDescripcion, lblDescripcion));
               // this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Genotipo", false, this.txtGenotipo, lblGenotipo));         
                base.DefinirListaBinding();
            }
        #endregion

        #region CARGAS COMUNES

        protected override void CargarCombos()
        {
            this.CargarCombo(cmbEspecie, Especie.Buscar());            
        }

        protected override void CargarValoresDefecto()
        {

            if (ValorEspecieFijo != null)
            {
                this.cmbEspecie.Enabled = false;
                this.cmbEspecie.SelectedValue = this.ValorEspecieFijo;
            }
        }
        
        #endregion
    }
}
