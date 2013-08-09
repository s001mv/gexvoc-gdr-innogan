using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using System.Linq;

namespace GEXVOC.UI
{
    public partial class EditCondicionCorporal : GEXVOC.UI.GenericEdit
    {
        #region CONTRUCTORES
        public EditCondicionCorporal()
        {
            InitializeComponent();
        }
        public EditCondicionCorporal(Modo modo, CondicionCorporal ClaseBase)
            : base(modo, ClaseBase)
        {
            InitializeComponent();
        }

        int? _ValorFijoIdAnimal = null;
        /// <summary>
        /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
        /// con el Id especificado aqui.
        /// </summary>
        public int? ValorFijoIdAnimal
        {
            get { return _ValorFijoIdAnimal; }
            set
            {
                if (value != null)
                {
                    this.cmbAnimal.ClaseActiva = Animal.Buscar((int)value);
                    this.cmbAnimal.ReadOnly = true;
                }
                else
                    this.cmbAnimal.ReadOnly = false;

                _ValorFijoIdAnimal = value;
            }
        }
        #endregion
        
        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
        public CondicionCorporal ObjetoBase { get { return (CondicionCorporal)this.ClaseBase; } }
        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                cmbAnimal.TipoDatos = typeof(Animal);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdHembra", true, this.cmbAnimal, lblhembra));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));

                base.DefinirListaBinding();
            }
             
            protected override bool Validar()
            {
                if (ModoActual == Modo.Guardar)
                    return validarlstBinding();//Validación normal del formulario
                else
                {///Realizo una validacion personalizada en caso de que nos encontremos en modo guardar multiple.
                    bool Rtno = true;
                    if (!Generic.ControlValorado(cmbAnimal, this.ErrorProvider)) Rtno = false;
                    if (!Generic.ControlDatosCorrectos(cmbTipo, this.ErrorProvider, typeof(int), true)) Rtno = false;
                    if (!Generic.ControlDatosCorrectos(txtFecha, this.ErrorProvider, typeof(DateTime), true)) Rtno = false;

                    return Rtno;
                }

            }

        #endregion

        #region CARGAS COMUNES
            protected override void CargarValoresDefecto()
            {
                this.txtFecha.Text = DateTime.Today.ToShortDateString();
                base.CargarValoresDefecto();
            }
            private void CargarComboTipo(Animal animal)
            {
                if (animal != null)
                {
                    this.CargarCombo(cmbTipo, "DescTipoCondicion", TipoCondicion.Buscar(animal.DescIdEspecie, null, null, null, null));
                }
                else
                {
                    cmbTipo.DataSource = null;
                    cmbTipo.SelectedIndex = -1;
                    cmbTipo.Text = string.Empty;
                }
            }

        #endregion

        #region FUNCIONAMIENTO GENERAL
            private void btnBuscarAnimal_Click(object sender, EventArgs e)
            {
                if (ModoActual == Modo.GuardarMultiple)
                {
                    SelectorAnimales frmSelectorAnimales = new SelectorAnimales(Modo.Consultar, (List<Animal>)this.cmbAnimal.DataSource);
                    this.LanzarFormulario(frmSelectorAnimales);


                    if (frmSelectorAnimales.LstAnimalesSeleccionadosRtno != null)
                    {
                        this.cmbAnimal.DataSource = frmSelectorAnimales.LstAnimalesSeleccionadosRtno;
                        this.cmbAnimal.Text = "(" + frmSelectorAnimales.LstAnimalesSeleccionadosRtno.Count + ") Elementos en selección";

                        CargarComboTipo(frmSelectorAnimales.LstAnimalesSeleccionadosRtno.First());
                    }
                    else
                        CargarComboTipo(null);


                }
                else
                    this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));
            }

            private void cmbAnimal_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                CargarComboTipo((Animal)cmbAnimal.ClaseActiva);
            }

            //private void btnBuscarTipo_Click(object sender, EventArgs e)
            //{
            //    this.LanzarFormularioConsulta(new FindTipoCondicion(Modo.Consultar, this.cmbTipo));
            //}
        #endregion

        #region FUNCIONES SOBREESCRITAS
            /// <summary>
            /// Se ha tenido que sobreescribir guardar, para dar la funcionalidad de inserción en lotes      
            /// </summary>
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

                                CondicionCorporal condicionCorporal = new CondicionCorporal();
                                condicionCorporal.IdHembra = item.Id;                                
                                Generic.ControlAClaseBase(condicionCorporal, "Fecha", txtFecha);
                                Generic.ControlAClaseBase(condicionCorporal, "IdTipo", cmbTipo);


                                condicionCorporal.Insertar();
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


                //base.Guardar();
            }
        #endregion
        
    }
}