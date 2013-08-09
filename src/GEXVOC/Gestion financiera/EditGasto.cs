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
    public partial class EditGasto : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditGasto()
        {
            InitializeComponent();
        }
        public EditGasto(Modo modo, Gasto ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public Gasto ObjetoBase { get { return (Gasto)this.ClaseBase; } }

        int? _valorFijoIdAnimal = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario de edición de tratamientos debe de aparecer con el combo del diagnostico fijo.
        /// </summary>
        public int? ValorFijoIdAnimal
        {
            get { return _valorFijoIdAnimal; }
            set
            {
                if (value != null)
                {
                    this.cmbAnimal.ClaseActiva = Animal.Buscar((int)value);
                    this.cmbAnimal.ReadOnly = true;

                }
                else
                    this.cmbAnimal.ReadOnly = false;
                _valorFijoIdAnimal= value;
            }
        }
    

        int? _ValorFijoIdTratamiento = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la Tratamiento fijo y con la Tratamiento que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdTratamiento
        {
            get { return _ValorFijoIdTratamiento; }
            set
            {
                if (value != null)
                {
                    this.cmbTratamiento.ClaseActiva = TratEnfermedad.Buscar((int)value);
                    this.cmbTratamiento.ReadOnly = true;

                }
                else
                    this.cmbTratamiento.ReadOnly = false;

                _ValorFijoIdTratamiento = value;
            }
        }


        int? _ValorFijoIdReceta = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la Receta fijo y con la Receta que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdReceta
        {
            get { return _ValorFijoIdReceta; }
            set
            {
                if (value != null)
                {
                    this.cmbReceta.ClaseActiva = Receta.Buscar((int)value);
                    this.cmbReceta.ReadOnly = true;
                    pnlReceta.Visible = true;
                    pnlReceta.Enabled = true;

                }
                else
                {
                    this.cmbReceta.ReadOnly = false;
                    pnlReceta.Visible = false;
                    pnlReceta.Enabled = false;
                }

                _ValorFijoIdReceta = value;
            }
        }



        Naturaleza _ValorFijoNaturalezaGasto = null;
        public Naturaleza ValorFijoNaturalezaGasto
        {
            get { return _ValorFijoNaturalezaGasto; }
            set
            {
                _ValorFijoNaturalezaGasto = value;                                
            }

        }
       
        
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
        protected override void DefinirListaBinding()
        {
            this.cmbAnimal.TipoDatos = typeof(Animal);
            this.cmbParcela.TipoDatos = typeof(Parcela);
            this.cmbTratamiento.TipoDatos = typeof(TratEnfermedad);
            this.cmbReceta.TipoDatos = typeof(Receta);
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAnimal", false, this.cmbAnimal, lblAnimal));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdNaturaleza", true, this.cmbNaturaleza, lblNaturaleza));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTratamiento", false, this.cmbTratamiento, lblTratamiento));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdReceta", false, this.cmbReceta, lblReceta));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdParcela", false, this.cmbParcela, lblParcela));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Detalle", false, this.txtDetalle, lblDetalle));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", false, this.txtFecha, lblFecha));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Total", true, this.txtTotal, lblTotal));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Importe", true, this.txtTotal, lblTotal));


            base.DefinirListaBinding();
        }
        protected override void ClaseBaseAControles()
        {
            //Si el gasto ha sido generado automaticamente por algun elemento de la aplicacion
            //debemos impedir que se modifiquen los datos que puedan causar incongruencias.
            if (this.ObjetoBase.IdInseminacion.HasValue || this.ObjetoBase.IdSiembra.HasValue ||
                this.ObjetoBase.IdAbonado.HasValue || this.ObjetoBase.IdAsignacion.HasValue ||
                this.ObjetoBase.IdTratHigiene.HasValue ||
                this.ObjetoBase.IdTratProfilaxis.HasValue || this.ObjetoBase.IdReceta.HasValue)
            {
                cmbNaturaleza.Enabled = false;
                cmbAnimal.ReadOnly = true;
                cmbTratamiento.ReadOnly = true;
                cmbParcela.ReadOnly = true;
            }

            base.ClaseBaseAControles();
        }
  

        #endregion

        #region CARGAS COMUNES
        /// <summary>
        /// Carga el combo del formulario.
        /// </summary>
        protected override void CargarCombos()
        {
            cmbNaturaleza.CargarCombo();
        }
        /// <summary>
        /// Carga por defecto la fecha actual del sistema.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(txtFecha, DateTime.Now.Date);
                  

            if (this.ValorFijoNaturalezaGasto != null)
            {
                this.cmbNaturaleza.SelectedValue = ValorFijoNaturalezaGasto.Id;
                this.cmbNaturaleza.Enabled = false;
            }   
            

        }

        #endregion
     
        #region FUNCIONAMIENTO GENERAL
           
            /// <summary>
            /// Lanza el formulario de busqueda de un animal.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, cmbAnimal));
            }
            /// <summary>
            /// Lanza el formulario de busqueda de una parcela.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnParcela_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindParcela(Modo.Consultar,cmbParcela));
            }

            private void txtFecha_Leave(object sender, EventArgs e)
            {
                ((TextBox)sender).Text = Generic.FormatearFecha(((TextBox)sender).Text);
            }

            private void btnBuscarTratamiento_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindTratEnfermedad(Modo.Consultar, cmbTratamiento));
            }

        #endregion

        #region COMBOS
            private void cmbNaturaleza_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbNaturaleza, Naturaleza.Buscar());
            }
            private void cmbNaturaleza_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {

                Naturaleza ObjetoBase = new Naturaleza();
                EditNaturaleza editNaturaleza = new EditNaturaleza(Modo.Guardar, ObjetoBase);
                editNaturaleza.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editNaturaleza, sender);

            }
        #endregion            

    }
}