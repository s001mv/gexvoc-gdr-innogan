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




        int? _ValorFijoIdHembra = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la inseminacino fijo y con la Hembra que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdHembra
        {
            get { return _ValorFijoIdHembra; }
            set
            {
                if (value != null)
                {
                    this.cmbAnimal.ClaseActiva = Animal.Buscar((int)value);
                    this.cmbAnimal.ReadOnly = true;
                }
                else
                    this.cmbAnimal.ReadOnly = false;

                _ValorFijoIdHembra = value;
            }
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public DiagInseminacion ObjetoBase { get { return (DiagInseminacion)this.ClaseBase; } }

        DateTime? fechaUltimaInseminacionCubricion;
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

        protected override void DefinirListaBinding()
        {
            this.cmbAnimal.TipoDatos = typeof(Animal);
            this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAnimal", true, this.cmbAnimal, lblAnimal));
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
                if (cmbAnimal.ClaseActiva!=null)
                {   
                    DateTime? fechaDiagnostico = Generic.ControlADatetimeNullable(txtFechaDiagnostico);
                    if (fechaUltimaInseminacionCubricion != null && fechaDiagnostico != null)
                    {
                        System.TimeSpan diffResult = ((DateTime)fechaDiagnostico).Subtract((DateTime)fechaUltimaInseminacionCubricion);
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

            private void chkResultado_CheckedChanged(object sender, EventArgs e)
            {

                if (((CheckBox)sender).Checked)
                {
                    ((CheckBox)sender).Text = "Positivo";
                    this.chkResultado.Image = global::GEXVOC.Properties.Resources.positivo;
                }
                else
                {
                    ((CheckBox)sender).Text = "Negativo";
                    this.chkResultado.Image = global::GEXVOC.Properties.Resources.Negativo;
                }
            }

            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal) { ValorSexoFijo = Convert.ToChar("H") });
            }

            private void cmbAnimal_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                bool cubricionAbierta = false;
                Animal hembra = (Animal)cmbAnimal.ClaseActiva;
                fechaUltimaInseminacionCubricion = hembra.UltimaFechaInseminacion_Cubricion(hembra.Id, ref cubricionAbierta);
                ActualizarDiasGestacion();
            }


            private void txtFechaDiagnostico_ValueChanged(object sender, GEXVOC.Core.Controles.ctlFechaEventArgs e)
            {
                ActualizarDiasGestacion();
            }
            
        #endregion
            
    }
}   
//private void txtFechaDiagnostico_TextChanged(object sender, EventArgs e)
            //{
            //    if (txtFechaDiagnostico.MaskCompleted)                
            //        ActualizarDiasGestacion();                
            //}