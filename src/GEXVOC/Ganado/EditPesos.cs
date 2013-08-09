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
    public partial class EditPesos : GEXVOC.UI.GenericEdit
    {
        
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS

            /// <summary>
            /// Constructor por defecto
            /// </summary>
            public EditPesos()
            {
                InitializeComponent();
            }

            /// <summary>
            /// Sobrecarga del Constructor que nos permite inicializar un formulario GenericEdit con los datos propios del formulario.
            /// Para ello necesitamos el modo en el que se lanza y la clase base sobre la que actúa.
            /// Este tipo de sobrecargas son siempre obligatorias al heredar de GenericEdit.
            /// El Codigo es Siempre el mismo, salvo por el tipo de la ClaseBase, que es propio del formulario heredado.
            /// </summary>
            /// <param name="modo">Modo de Apertura del Formulario Edit</param>
            /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario Edit.</param>
            public EditPesos(Modo modo, Peso ClaseBase)
                : base(modo, ClaseBase)
            {
                InitializeComponent();
              
               
            }
          
            
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public Peso ObjetoBase
            {
                get { return (Peso)ClaseBase; }
                set { ClaseBase = value; }
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

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                cmbAnimal.TipoDatos=typeof(Animal);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdAnimal", true, cmbAnimal, lblVaca));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Peso1", true, txtPeso, lblPeso));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, txtFecha, lblFecha));                
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdMomento", false, cmbMomentoPeso, lblMomento));

                
                base.DefinirListaBinding();
            }  

   

            /// <summary>
            /// Es necesario que se valide manualmente el formualrio si se encuentra en modo guardar.
            /// Lo unico que hacemos en este caso es forzar la validacion de lstBinding.
            /// </summary>
            /// <returns></returns>
            protected override bool Validar()
            {
                if (ModoActual == Modo.Guardar)
                    return validarlstBinding();//Validación normal del formulario
                else                    
                {///Realizo una validacion personalizada en caso de que nos encontremos en modo guardar multiple.
                    bool Rtno = true;
                    if (!Generic.ControlValorado(cmbAnimal, this.ErrorProvider)) Rtno = false;
                    if (!Generic.ControlDatosCorrectos(txtPeso, this.ErrorProvider, typeof(decimal), true)) Rtno = false;
                    if (!Generic.ControlDatosCorrectos(txtFecha, this.ErrorProvider, typeof(DateTime), true)) Rtno = false;

                    return Rtno;
                
                
                }
                


            }

        
        #endregion

        #region CARGAS COMUNES
        protected override void CargarCombos()
        {
            cmbMomentoPeso.CargarCombo();
        }

        /// <summary>
        ///Establezco los valores por defecto de la fecha (si estamos en modo insercion)
        ///Los valores dependen del elemento seleccionado en el combo, tenemos 3 posibilidades:
        ///a) Valor Combo "NACIMIENTO": Establecemos la fecha obteniendola de Animal.FechaNacimiento
        ///b) Valor Combo "DESTETE": Establecemos la fecha obteniendola de Animal.FechaDestete
        ///C) Valor Combo (Cualquier otro): Establecemos la fecha de hoy.
        /// </summary>
        protected override void CargarValoresDefecto()
        {
            Generic.DatetimeAControl(this.txtFecha, DateTime.Now.Date);
         
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
                    }
                }
                else
                    this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbAnimal));

             
            }
          
        #endregion

        #region FUNCIONES SOBREESCRITAS
           /// <summary>
        /// Se ha tenido que sobreescribir guardar, para dar la funcionalidad de inserción en lotes
        /// una característica importante que deriba de esto es que si existe mas de un animal en la selección, 
        /// el peso proporcionado se divide entre el número total de animales.
        /// PE: peso 3 animales, indico peso 3,30, se daran de alta 3 registros, uno por cada animal, en los que el peso será 1,10 
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

                            Peso peso = new Peso();                            
                            peso.IdAnimal = item.Id;
                            peso.Peso1 = Convert.ToDecimal(txtPeso.Text.Replace(".",",")) / cmbAnimal.Items.Count;                           
                            ControlAClaseBase(peso, "Fecha", txtFecha);
                            ControlAClaseBase(peso, "IdMomento", cmbMomentoPeso);

                            peso.Insertar();
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

        #region COMBOS
            private void cmbMomentoPeso_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (ModoActual == Modo.Guardar)
                {
                    if (cmbMomentoPeso.SelectedValue != null && this.cmbAnimal.ClaseActiva != null)
                    {
                        Animal animal = (Animal)cmbAnimal.ClaseActiva;
                        if ((int)cmbMomentoPeso.SelectedValue == Configuracion.MomentoPesoSistema(Configuracion.MomentosPesoSistema.NACIMIENTO).Id)
                            Generic.DatetimeAControl(txtFecha, animal.FechaNacimiento);
                        else if (((int)cmbMomentoPeso.SelectedValue == Configuracion.MomentoPesoSistema(Configuracion.MomentosPesoSistema.DESTETE).Id) && animal.FechaDestete != null)
                            Generic.DatetimeAControl(txtFecha, (DateTime)animal.FechaDestete);
                        else
                            Generic.DatetimeAControl(txtFecha, DateTime.Today);


                    }
                }
            }

            private void cmbMomentoPeso_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbMomentoPeso, "Descripcion", Momento.Buscar());  
            }

            private void cmbMomentoPeso_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                
                Momento ObjetoBase = new Momento();                 
                GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                frmLanzar.Titulo = "Momento Peso";
                frmLanzar.NumColumnas = 2;
                frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción") { ValorDefecto=e.TextoCrear});

                CrearNuevoElementoCombo(frmLanzar, sender);             
            }

        #endregion
    }
}
