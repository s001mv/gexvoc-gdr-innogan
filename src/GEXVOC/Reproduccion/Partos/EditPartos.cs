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
    public partial class EditPartos : GEXVOC.UI.GenericEdit
    {
         #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS

            /// <summary>
            /// Constructor por defecto
            /// </summary>
            public EditPartos()
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
            public EditPartos(Modo modo, Parto ClaseBase):base(modo, ClaseBase)
            {
                InitializeComponent();
              
               
            }

        #endregion

         #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public Parto ObjetoBase
            {
                get { return (Parto)ClaseBase; }
                set { ClaseBase = value; }
            }

            int? _ValorFijoIdHembra=null;
            /// <summary>
            /// Propiedad que nos indica si el formulario debe aparecer con el combo de la hembra fijo y con el animal que corresponde 
            /// con el Id especificado aqui.
            /// </summary>
            public int? ValorFijoIdHembra
            {
                get { return _ValorFijoIdHembra; }
                set
                {
                    if (value != null)
                    {
                        
                        this.cmbHembra.ClaseActiva = Animal.Buscar((int)value);
                       
                        this.cmbHembra.ReadOnly = true;                        
                    }
                    else
                        this.cmbHembra.ReadOnly = false;

                    _ValorFijoIdHembra = value; }
            }


          #endregion

         #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            protected override void DefinirListaBinding()
            {
                this.cmbHembra.TipoDatos = typeof(Animal);
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdHembra", true, this.cmbHembra, lblHembra));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdTipo", true, this.cmbTipo, lblTipo));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "IdFacilidad", true, this.cmbfacilidad, lblFacilidad));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Fecha", true, this.txtFecha, lblFecha));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Vivos", false, this.txtVivos, lblVivos));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Muertos", false, this.txtMuertos, lblMuertos));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "Muertos", false, this.txtMuertos, lblMuertos));
                this.lstBinding.Add(new BindingMaestro(this.ObjetoBase, "CausaMuerte", false, this.txtCausaMuerte, lblCausaMuerte));

                
                base.DefinirListaBinding();
            }
            //private void EditPartos_PropiedadAControl(object sender, PropiedadBindEventArgs e)
            //{
            //    if (e.Control == cmbHembra)
            //        this.cmbHembra.ClaseActiva = Animal.Buscar(this.ObjetoBase.IdHembra);

            //}           

            protected override bool Validar()
            {
                bool rtno = true;

                int? idTipoParto = Generic.ControlAIntNullable(cmbTipo);
                TipoParto tipoparto=null;
                if (idTipoParto!=null)                
                    tipoparto = TipoParto.Buscar((int)idTipoParto);

                int? vivos, muertos;
                vivos = Generic.ControlAIntNullable(txtVivos);
                muertos = Generic.ControlAIntNullable(txtMuertos);


                //Compruebo que el número de animales se corresponde con el tipo de parto.
                if (tipoparto != null && tipoparto.Crias != null && tipoparto.Crias != ((vivos ?? 0) + (muertos ?? 0)))
                {
                   
                        Generic.PonerError(this.ErrorProvider, cmbTipo, "El tipo no se corresponde con el número de crías, debe cambiar el tipo o las cifras vivos-muertos.\r" +
                          "El número esperado debe ser: " + tipoparto.Crias.ToString());
                        rtno = false;
                   
                }

               
                return rtno;
            }
         #endregion

         #region CARGAS COMUNES

            /// <summary>
            /// Carga los combos del formulario
            /// </summary>
            protected override void CargarCombos()
            {
                cmbTipo.CargarCombo();
                cmbfacilidad.CargarCombo();

            }

            /// <summary>
            /// Carga los Valores por defecto del Formulario de Explotaciones
            /// </summary>
            protected override void CargarValoresDefecto()
            {
                Generic.DatetimeAControl(this.txtFecha, DateTime.Now.Date);
                //this.dtgInseminaciones.DataSource = Inseminacion.BuscarInseminacionesLibres(this.ValorFijoIdHembra);

            }

            /// <summary>
            /// Carga los grids de detalle
            /// </summary>
            protected override void CargarGrids() { 
                //PENDIENTE: AQUI CARGAR TODAS LAS INSEMINACIONES NO ASOCIADAS A NINGUN PARTO                
                this.dtgInseminaciones.DataSource = this.ObjetoBase.lstInseminaciones;}

         #endregion
        
         #region FUNCIONALIDAD GENERAL

            private void btnBuscarVaca_Click(object sender, EventArgs e)
            {
               this.LanzarFormularioConsulta(new FindAnimales(Modo.Consultar, this.cmbHembra) { ValorSexoFijo = Convert.ToChar("H") });
            }
            
            private void cmbHembra_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
            {
                 if (ModoActual == Modo.Guardar && cmbHembra.IdClaseActivaNullable != null)
                 {
                     Animal animal=Animal.Buscar(cmbHembra.IdClaseActiva);
                     this.dtgInseminaciones.AutoGenerateColumns = false;//Se pone esta linea pq cuando lanzamos el formulario desde el formularios
                     //de animales, la clase activa cambia antes de que se haga la llamada a eliminarAutogenerateColumns en la plantilla, y sin
                     //esta llamada el grid intenta mostrar todos los elementos de la clase, cosa que no es posible pq no se encuentra con  un contexto activo.
                     this.dtgInseminaciones.DataSource = Inseminacion.BuscarInseminacionesLibres(cmbHembra.IdClaseActiva,animal.UltimaFechaParto_Aborto(cmbHembra.IdClaseActiva));             
                 }
                 else
                     this.dtgInseminaciones.DataSource = null;

            }

            private void btnCrearAnimal_Click(object sender, EventArgs e)
            {
                 if (ModoActual == Modo.Actualizar)
                 {
                     EditAnimales frmLanzar = new EditAnimales(this.ObjetoBase.Id) { MostrarGrid=true};
                     this.LanzarFormulario(frmLanzar);

                 }
            }

        #endregion        

         #region COMBOS
            private void cmbTipo_CargarContenido(object sender, System.EventArgs e)
            {
                this.CargarCombo(cmbTipo, TipoParto.Buscar(string.Empty, null));
            }
            private void cmbTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {

                TipoParto ObjetoBase = new TipoParto();
                EditTipoParto editTipoParto = new EditTipoParto(Modo.Guardar, ObjetoBase);
                editTipoParto.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editTipoParto, sender);
            }

            private void cmbfacilidad_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {

                Facilidad ObjetoBase = new Facilidad();
                EditFacilidad editFacilidad = new EditFacilidad(Modo.Guardar, ObjetoBase);
                editFacilidad.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editFacilidad, sender);

            }
            private void cmbfacilidad_CargarContenido(object sender, System.EventArgs e)
            {
                this.CargarCombo(cmbfacilidad, Facilidad.Buscar(string.Empty, null));
            }
        #endregion

      

            private void EditPartos_ControlAPropiedad(object sender, PropiedadBindEventArgs e)
            {
                if (e.Control==txtFecha)
                {
                    try //Esta debe ser la ultima de las comprobaciones y solo se ejecuta si el resto de las comprobaciones han sido correctas
                    {   //Comprobamos si la fecha valida el periodo de gestacion
                        if (Generic.ControlValorado(txtFecha) && cmbHembra.ClaseActiva != null)
                            Parto.ValidarPeriodoGestacion(cmbHembra.ClaseActiva.Id, Generic.ControlADatetime(txtFecha));
                    }
                    catch (LogicException ex)
                    {


                        DialogResult rdo = Generic.Pregunta(ex.Message + "\r¿Desea insertar o actualizar el parto a pesar de ésta advertencia?");
                        if (rdo == DialogResult.Yes)//Si queremos omitir el periodo de gestacion debemos proporcionar un valor positivo a la propiedad OmitirValidacionPeriodoGestacion de la clase parto
                            //Con esto conseguiremos que se omita la validacion que ya hemos realizado y sobre la cual el usuario ha contestado.
                            this.ObjetoBase.OmitirValidacionPeriodoGestacion = true;
                        else//Al usuario no le interesa saltarse las advertencias                        
                            Generic.PonerError(this.ErrorProvider, txtFecha, ex.Message);                            
                        

                    }

                }
            }

          

    }
}
 //---------------------Código Comentado----------------------------------------------//
          
        // #region FUNCIONALIDAD - GRIDS DETALLE


        //    void InsertarInseminacion()
        //    {
        //        if (ModoActual == Modo.Actualizar)
        //        {
        //            Inseminacion ObjetoBase = new Inseminacion();
        //            ObjetoBase.IdHembra = this.ObjetoBase.IdHembra;
        //            EditInseminacion frmEditInseminaciones = new EditInseminacion(Modo.Guardar, ObjetoBase);

        //            this.LanzarFormulario(frmEditInseminaciones, dtgInseminaciones);
        //        }
        //    }
        //    void ModificarInseminacion()
        //    {

        //        if (ModoActual == Modo.Actualizar && this.dtgInseminaciones.SelectedRows.Count == 1)
        //        {
        //            Inseminacion ObjetoBase = (Inseminacion)this.dtgInseminaciones.CurrentRow.DataBoundItem;

        //            EditInseminacion frmEditInseminaciones = new EditInseminacion(Modo.Actualizar, ObjetoBase);

        //            this.LanzarFormulario(frmEditInseminaciones, dtgInseminaciones);
        //        }
        //    }


        //    private void tsbNuevaInseminacion_Click(object sender, EventArgs e)
        //    {
        //        InsertarInseminacion();

        //    }
        //    private void tsbModificarInseminacion_Click(object sender, EventArgs e)
        //    {
        //        ModificarInseminacion();
        //    }
        //    private void dtgInseminaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //    {
        //        ModificarInseminacion();
        //    }
        //    private void tsbEliminarInseminacion_Click(object sender, EventArgs e)
        //    {
        //        this.EliminarObjGrid(this.dtgInseminaciones, "Va a eliminar la Inseminación.\r¿Esta usted seguro de que desea continuar?");
        //    }





        //#endregion
        