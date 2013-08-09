using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Logic;

namespace GEXVOC.UI
{
    public partial class EditAniLotLotes : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditAniLotLotes()
        {
            InitializeComponent();
        }
        public EditAniLotLotes(Modo modo, AniLot ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public AniLot ObjetoBase { get { return (AniLot)this.ClaseBase; } }

        int? _ValorFijoIdLote = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de los lotes fijo y con el que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdLote
        {
            get { return _ValorFijoIdLote; }
            set { _ValorFijoIdLote = value; }
        }


        int? _ValorFijoIdAnimal = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de los lotes fijo y con el que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdAnimal
        {
            get { return _ValorFijoIdAnimal; }
            set
            {
                if (value != null)
                    cmbAnimal.ClaseActiva = Animal.Buscar((int)value);

                cmbAnimal.ReadOnly = (value != null);
                _ValorFijoIdAnimal = value;
            }
        }

        DateTime? _ValorInicialFecha=null;
        public DateTime? ValorInicialFecha
        {
            get { return _ValorInicialFecha; }
            set { _ValorInicialFecha = value; }
        }

      
        #endregion          

        #region CARGAS COMUNES
            protected override void CargarCombos()
            {
                this.CargarCombo(cmbLoteAnimal, LoteAnimal.Buscar(Configuracion.Explotacion.Id, string.Empty,null,null,null,null ), ValorFijoIdLote);
                base.CargarCombos();
            }
            /// <summary>
            /// Carga los Valores por defecto del Formulario de Explotaciones
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                if (ValorInicialFecha==null)                
                    Generic.DatetimeAControl(this.txtFechaInicio, DateTime.Now.Date);
                else
                    Generic.DatetimeAControl(this.txtFechaInicio, (DateTime)ValorInicialFecha);
            }
        #endregion     

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                cmbAnimal.TipoDatos = typeof(Animal);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAnimal", true, this.cmbAnimal, lblAnimal));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdLote", true, this.cmbLoteAnimal, lblLoteAnimal));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaInicio", true, this.txtFechaInicio, lblFecInicio));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "FechaFin", false, this.txtFechaFin, lblFecFin));

                base.DefinirListaBinding();
            }         


            protected override void Guardar()
            {
                if (ModoActual == Modo.GuardarMultiple)
                {
                    if (ValidarControles())
                    {
                        IniciarContextoOperacion();

                        string mensajeError = string.Empty;
                        int OperacionesCorrectas = 0;
                        int OperacionesIncorrectas = 0;
                        foreach (Animal item in cmbAnimal.Items)
                        {
                            try
                            {

                                AniLot anilot = new AniLot();
                                anilot.IdAnimal = item.Id;

                                Generic.ControlAClaseBase(anilot, "IdLote", cmbLoteAnimal);
                                Generic.ControlAClaseBase(anilot, "FechaInicio", txtFechaInicio);
                                Generic.ControlAClaseBase(anilot, "FechaFin", txtFechaFin);

                                anilot.Insertar();
                                OperacionesCorrectas += 1;
                            }
                            catch (Exception ex)
                            {
                                OperacionesIncorrectas += 1;
                                mensajeError += ex.Message + "\r";

                            }

                        }
                        FinalizarContextoOperacion();

                        if (mensajeError != string.Empty)
                            Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                    "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                    "Resumen e Información adicional: \r" +
                                                      mensajeError);

                        this.Close();

                    }
                }
                else
                {
                    base.Guardar();
                }
            }

            protected override bool Validar()
            {
                if (ModoActual == Modo.GuardarMultiple)
                    return validarlstBinding();
                else
                    return base.Validar();

            }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarHembra_Click(object sender, EventArgs e)
            {
                if (ModoActual == Modo.GuardarMultiple)
                {
                    SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, (List<Animal>)this.cmbAnimal.DataSource);
                    this.LanzarFormulario(frmSelectorAnimales);


                    if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
                    {
                        this.cmbAnimal.DataSource = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
                        this.cmbAnimal.Text = "(" + frmSelectorAnimales.LstAnimalesSeleccionadosRtno.Count + ") Elementos en selección";
                    }

                }
                else
                    this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));





            }
        #endregion
    }
}
