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
    public partial class EditDiagInseminacion : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditDiagInseminacion()
        {
            InitializeComponent();
        }
        public EditDiagInseminacion(Modo modo, DiagInseminacion ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }




        int? _ValorFijoIdInseminacion = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la inseminacino fijo y con la inseminacion que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdInseminacion
        {
            get { return _ValorFijoIdInseminacion; }
            set
            {
                if (value != null)
                {
                    this.cmbInseminacion.ClaseActiva = Inseminacion.Buscar((int)value);
                    this.cmbInseminacion.ReadOnly = true;
                }
                else
                    this.cmbInseminacion.ReadOnly = false;

                _ValorFijoIdInseminacion = value;
            }
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public DiagInseminacion ObjetoBase { get { return (DiagInseminacion)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void DefinirListaBinding()
        {
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdInseminacion", true, this.cmbInseminacion, lblInseminacion));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipoDiagnostico, lblTipoDiagnostico));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFechaDiagnostico, lblFechaDiagnostico));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "DiasGestacion", false, this.txtDiasGestacion, lblDias));
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Resultado", false, this.chkResultado, lblResultado));

            base.DefinirListaBinding();
        }


    
        



      

        #endregion

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {
                this.CargarCombo(cmbTipoDiagnostico, TipoDiagnostico.Buscar());           
                base.CargarCombos();
            }

            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(txtFechaDiagnostico, DateTime.Today);
                ActualizarDiasGestacion();       

                base.CargarValoresDefecto();
            }
        #endregion

        #region FUNCIONAMIENTO GENERAL
            void ActualizarDiasGestacion()
            {
                if (cmbInseminacion.ClaseActiva!=null)
                {
                    DateTime? fechaInseminacion = ((Inseminacion)cmbInseminacion.ClaseActiva).Fecha;
                    DateTime? fechaDiagnostico = Generic.ControlADatetimeNullable(txtFechaDiagnostico);
                    if (fechaInseminacion != null && fechaDiagnostico != null)
                    {
                        System.TimeSpan diffResult = ((DateTime)fechaDiagnostico).Subtract((DateTime)fechaInseminacion);
                        if (true)
                        {
                            if (diffResult.Days > -1)
                                txtDiasGestacion.Text = diffResult.Days.ToString();
                            else
                                txtDiasGestacion.Text = "0";
                        }
                    }                
                }           

            }

            private void txtFechaDiagnostico_TextChanged(object sender, EventArgs e)
            {
                ActualizarDiasGestacion();
            }
        #endregion

            
    }
}