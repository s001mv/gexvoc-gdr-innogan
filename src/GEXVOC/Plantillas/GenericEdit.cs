using System;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using System.Collections.Generic;
using System.Reflection;
using GEXVOC.Core.Controles;


namespace GEXVOC.UI
{
  
    public partial class GenericEdit : GenericMaestro 
    {
        #region CONSTRUCTORES

            /// <summary>
            /// Constructor por defecto
            /// </summary>
            public GenericEdit()
            {
                InitializeComponent();

            }

            /// <summary>
            /// Constructor con parametros
            /// </summary>
            /// <param name="modo">Modo de apertura del formulario</param>
            /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario</param>
            public GenericEdit(Modo modo, IClaseBase ClaseBase)
            {
                InitializeComponent();

                this.ClaseBase = ClaseBase;

                ModoActual = modo;

            }

            /// <summary>
            /// Constructor con parametros
            /// </summary>
            /// <param name="modo">Modo de apertura del formulario</param>
            /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario</param>
            /// 
            public GenericEdit(IClaseBase ClaseBase)
            {
                InitializeComponent();
                this.ClaseBase = ClaseBase;
            }
        
            
            /// <summary>
            /// Constructor con parametros
            /// </summary>
            /// <param name="modo">Modo de apertura del formulario</param>
            /// <param name="ClaseBase"Clase Base sobre la que actúa el formulario></param>
            /// <param name="numTabSeleccionar">Nº del TabPage que queremos que apareza seleccionado</param>
            public GenericEdit(Modo modo, IClaseBase ClaseBase,int numTabSeleccionar)
            {
                InitializeComponent();

                this.ClaseBase = ClaseBase;

                ModoActual = modo;

                this.NumTabPageSeleccionar = numTabSeleccionar;

            }
            public GenericEdit(Modo modo, IClaseBase ClaseBase, string tabSeleccionar)
            {
                InitializeComponent();

                this.ClaseBase = ClaseBase;

                ModoActual = modo;

                this.TabPageSeleccionar = tabSeleccionar;

            }

        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO

            IClaseBase _ClaseBase;
            /// <summary>
            /// Variable Principal sobre la que actuará el formulario Edit
            /// Es asignada en el método InicializarGenericEdit()
            /// </summary>
            public IClaseBase ClaseBase
            {

                get { return _ClaseBase; }
                set
                {
                    _ClaseBase = value;
                    //Si la clase base implementa la interface INotificable, capturamos el evento notificar y se lo asignamos al método notificar de GenericMaestro
                    if (value.GetType().GetInterface(typeof(INotificable).Name) != null)
                        ((INotificable)value).Notificar += new EventHandler<NotificableEventArgs>(this.Notificar);
                }
            }


            AccionesDespuesInsertar _AccionDespuesInsertar = AccionesDespuesInsertar.Cerrar;
            /// <summary>
            /// Propiedad que nos indicará si el formulario Edit se cierra automaticamentea al Guardar o Modificar un registro
            /// Si tiene un valor TRUE (Valor por Defecto) el formulario es cerrado automaticamente despues de un guardado o una modificación
            /// Si tiene un Valor FALSE podremos podemos continuar con la edición.
            /// </summary>
            public AccionesDespuesInsertar AccionDespuesInsertar
            {
                get { return _AccionDespuesInsertar; }
                set { _AccionDespuesInsertar = value; }
            }

            public enum AccionesDespuesInsertar { Cerrar = 1, Preguntar, CambiarModoActualizar }


            private int? _numTabPageSeleccionar = null;
            /// <summary>
            /// Nos va a proporcionar el número del tabpage que tenemos que seleccionar autmaticamente
            /// al cargar el formulario, se utiliza sobre todo, cuando desde una barra horizontal de un formulario find lanzamos
            /// este formulario (En este caso la barra horizontal nos indicará que tabPage se desea seleccionar.
            /// Para el correcto funcionamiento (Para que la plantilla haga la seleccion automáticamente
            /// de las tabpages, es necesario tener establecida la propiedad TabControlPrincipal.
            /// </summary>
            public int? NumTabPageSeleccionar
            {
                get { return _numTabPageSeleccionar; }
                set { _numTabPageSeleccionar = value; }
            }


            private string _tabPageSeleccionar = null;

            public string TabPageSeleccionar
            {
                get { return _tabPageSeleccionar; }
                set { _tabPageSeleccionar = value; }
            }

            private TabControl _TabControlPrincipal = null;
            /// <summary>
            /// Es utilizado para que la plantilla pueda identificar el control que contiene las tabpages
            /// que se desean seleccionar, es necesaria esta propiedad pq no todos los formularios genericEdit
            /// tienen controles del tipo tab, pero si los que los tienen, deben asignar esta propiedad
            /// conjuntamente con la propiedad NumTabPageSeleccionar.
            /// </summary>
            public TabControl TabControlPrincipal
            {
                get { return _TabControlPrincipal; }
                set { _TabControlPrincipal = value; }
            }

            public bool BotonBuscarVisible
            {
                get { return btnEditBuscar.Visible; }
                set { btnEditBuscar.Visible = value; }
            }
            public bool BotonLimpiarVisible
            {
                get { return btnEditLimpiar.Visible; }
                set { btnEditLimpiar.Visible = value; }
            }


        #endregion

        #region EVENTOS

            public event EventHandler<GenericEventArgs> ClaseBaseInsertando;
            public event EventHandler<GenericEventArgs> ClaseBaseInsertado;
            public event EventHandler<GenericEventArgs> ClaseBaseActualizando;
            public event EventHandler<GenericEventArgs> ClaseBaseActualizado;
            public event EventHandler<GenericEventArgs> ClaseBaseBorrando;
            public event EventHandler<GenericEventArgs> ClaseBaseBorrado;           


            protected virtual void OnClaseBaseInsertando(GenericEventArgs e)
            {
                EventHandler<GenericEventArgs> handler = ClaseBaseInsertando;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
            protected virtual void OnClaseBaseInsertado(GenericEventArgs e)
            {
                EventHandler<GenericEventArgs> handler = ClaseBaseInsertado;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
            protected virtual void OnClaseBaseActualizando(GenericEventArgs e)
            {
                EventHandler<GenericEventArgs> handler = ClaseBaseActualizando;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
            protected virtual void OnClaseBaseActualizado(GenericEventArgs e)
            {
                EventHandler<GenericEventArgs> handler = ClaseBaseActualizado;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
            protected virtual void OnClaseBaseBorrando(GenericEventArgs e)
            {
                EventHandler<GenericEventArgs> handler = ClaseBaseBorrando;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
            protected virtual void OnClaseBaseBorrado(GenericEventArgs e)
            {
                EventHandler<GenericEventArgs> handler = ClaseBaseBorrado;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

            
            public event EventHandler<PropiedadBindEventArgs> PropiedadAControl;
            public event EventHandler<PropiedadBindEventArgs> ControlAPropiedad;
            protected virtual void OnPropiedadAControl(PropiedadBindEventArgs e)
            {
                EventHandler<PropiedadBindEventArgs> handler = PropiedadAControl;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
            protected virtual void OnControlAPropiedad(PropiedadBindEventArgs e)
            {
                EventHandler<PropiedadBindEventArgs> handler = ControlAPropiedad;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

       





        
        #endregion

        #region CARGAS COMUNES

            /// <summary>
            /// Inicializa los elementos necesarios para el correcto funcionamiento de un formulario del tipo GenericEdit.
            /// Debe ser llamado antes de hacer el show del formulario, esta llamada es hecha habitualmente por las plantillas.
            /// Se llama en el método MostrarFormulario espeficacdo en Principal.
            /// Si este no es llamado antes de mostrar el formulario, se llamará automáticamente en el load.
            /// </summary>
            public override void Cargar()
            {
                Console.WriteLine("Cargando: " + this.Name + " " +   DateTime.Now.ToString("ss - fffffff"));

                DefinirListaBinding();
                //Pone nos controles predefinidos en mayusculas
                Generic.PonerControlesMayusculas(this);
                //Eliminar las columnas automaticas del los grids
                Generic.EliminarAutogenerateColumns(this);
                CargarCombos();
                
                if (ModoActual == Modo.Actualizar)
                {
                    try
                    {
                        this.ClaseBaseAControles();                       
                    }
                    catch (Exception ex)
                    {                        
                        throw new LogicException ("Error en ClaseBaseAControles. Error: " + ex.Message);
                    }

                    CargarGrids(); 
                     
                }
                else if (ModoActual == Modo.Guardar||ModoActual==Modo.GuardarMultiple)
                {
                    this.CargarValoresDefecto();
                }


                //Selección automatica de TabPages (La pagina a seleccionar se envia en el constructor sobrecargado)
                if (this.TabControlPrincipal != null && this.NumTabPageSeleccionar != null && NumTabPageSeleccionar < this.TabControlPrincipal.TabCount)
                    this.TabControlPrincipal.SelectedTab = this.TabControlPrincipal.TabPages[(int)NumTabPageSeleccionar];

                if (this.TabControlPrincipal != null && this.TabPageSeleccionar != string.Empty)
                {
                    //Selecciono un tab page por su nombre si lo encuentro
                    foreach (TabPage item in TabControlPrincipal.TabPages)
                    {
                        if (item.Text==TabPageSeleccionar)
                        {
                            this.TabControlPrincipal.SelectedTab = item;
                        }
                    }
                    
                    
                }

                this.Cargado = true;//Activo la propiedad que indica que al menos hemos ejecutado 1 vez por el método Cargar()
                Console.WriteLine("Cargado: " + this.Name + " " + DateTime.Now.ToString("ss - fffffff"));
            }

        #endregion

        #region FUNCIONAMIENTO GENERAL

            /// <summary>
            /// Cierra el formulario sin guardar los cambios
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected virtual void Salir(object sender, EventArgs e)
            {

                this.Close();
            }

            /// <summary>
            /// Se produce cuando se pulsa el boton buscar de la barra de herramientas superior.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected virtual void Buscar(object sender, EventArgs e)
            {
                this.Validate(true);
                this.Buscar();
            }
            protected virtual void limpiar(object sender, EventArgs e)
            {
                this.Limpiar();

            }
            protected override void Limpiar()
            {
                
                lblBarraEstado.Text = String.Empty;
                base.Limpiar();
            }        



        #endregion

        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,...)

            /// <summary>
            /// No debe ser sobreescrito salvo excepciones
            /// Proboca una llamada a Guardar();       
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected virtual void Guardar(object sender, EventArgs e) {Guardar();}

            /// <summary>
            /// Método que guarda el contenido de los controles en la Base de Datos
            /// En función del modo en el que ha sido lanzado el formulario Edit (Guardar o Actualizar) puede
            /// probocar que se cree un registro nuevo o que se actualicen los datos de un registro existente.
            /// </summary>
            protected virtual void Guardar()
            {
                try
                {
                    if (ModoActual != Modo.Guardar && ModoActual != Modo.Actualizar)
                        throw new LogicException("El formulario actual no tiene un estado válido que permita realizar operaciones");


                    this.Validate(true);//Valida los controles del formulario (hace que todos los controles se encuentren validated

                    if (ValidarControles())
                    {
                        this.IniciarContextoOperacion();
                        
                        if (ModoActual == Modo.Guardar)                           
                            this.ClaseBase = this.ClaseBase.CargarContextoOperacion(TipoContexto.Insercion);                       
                        else if (ModoActual == Modo.Actualizar)                           
                            this.ClaseBase = this.ClaseBase.CargarContextoOperacion(TipoContexto.Modificacion);

                        QuitarErrores();

                        this.ControlesAClaseBase();//Es posible en algunos casos que se utilice el error provider principal, que carguen elementos en lstControlesConErrores

                        if (this.lstControlesConErrores.Count == 0)
                        {
                             if (ModoActual == Modo.Guardar) //CODIGO RELATIVO A LAS INSERCIONES
                             {
                                    this.GuardarClaseBase();

                                    switch (this.AccionDespuesInsertar)
                                    {
                                        case AccionesDespuesInsertar.CambiarModoActualizar:
                                            this.ModoActual = Modo.Actualizar;
                                            break;
                                        case AccionesDespuesInsertar.Preguntar:
                                            DialogResult Rdo = Generic.Pregunta("¿Desea continuar editando?");
                                            if (Rdo == DialogResult.Yes)
                                                this.ModoActual = Modo.Actualizar;
                                            else
                                            {
                                                this.DialogResult = DialogResult.OK;
                                                this.Close();
                                            }
                                            break;

                                        default:
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();

                                            break;

                                    }
                            }
                            else if (ModoActual == Modo.Actualizar)//CODIGO RELATIVO A LAS MODIFICACIONES
                            {                             
                                    this.ActualizarClaseBase();
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();  
                            }
                        }
                        else//Hay errores en el formulario, no continúo (Los errores han sido asignador mediante el proveedor de errores principal)
                            this.MoverFocoSiguienteError();

                     }                   
                }
                catch (LogicException ex)
                {                    
                    Generic.Aviso(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {                                                            
                    Generic.AvisoError("Error en el proceso de guardado.");
                    Traza.RegistrarError(ex);
                }
                finally
                { this.FinalizarContextoOperacion(); }
            }

        


            /// <summary>
            /// Es una Función se puede sobreescribir en los formularios heredados pero no es lo habitual
            /// Solo se sobreescribe esta función para dar funcionadad a sobrecargas del Metodo de la ClaseBase (Guardar())
            /// Se llamará automaticamente desde Guardar (que puede lanzar guardar objeto o actualizar)
            /// Siempre insertará un nuevo elemento.
            /// Antes de llamar a esta función ha de llamarse previamente a ControlesAClaseBase() aunque esta llamada
            /// es hecha habitualmente desde Guardar() si no esta sobreescrita.
            /// </summary>
            protected virtual void GuardarClaseBase() { 
                GenericEventArgs eventArgs = new GenericEventArgs();
                eventArgs.ClaseBase = ClaseBase;

                OnClaseBaseInsertando(eventArgs);

                if (!eventArgs.Cancelar)
                {
                    bool trans = BD.IniciarTransaccion();
                    try
                    {                    
                        ClaseBase.Insertar();
                        if (trans) BD.FinalizarTransaccion(true);                   
                      
                    }
                    catch (Exception ex)
                    {
                        if (trans) BD.FinalizarTransaccion(false);
                        Traza.RegistrarError("Error en Generic Edit: " + ex);
                        throw;
                    }
                    OnClaseBaseInsertado(eventArgs);
                }

            
            }

            /// <summary>
            /// Es una Función se puede sobreescribir en los formularios heredados pero no es lo habitual
            /// Solo se sobreescribe esta función para dar funcionadad a sobrecargas del Metodo de la ClaseBase (Actualizar())
            /// Se llamará automaticamente desde Guardar (que puede lanzar guardar objeto o actualizar)
            /// Siempre actualizará un elemento existente.
            /// Antes de llamar a esta función ha de llamarse previamente a ControlesAClaseBase() aunque esta llamada
            /// es hecha habitualmente desde Guardar() si no esta sobreescrita.
            /// </summary>
            protected virtual void ActualizarClaseBase() {

                GenericEventArgs eventArgs = new GenericEventArgs();
                eventArgs.ClaseBase = ClaseBase;

                OnClaseBaseActualizando(eventArgs);
                if (!eventArgs.Cancelar)
                {
                    bool trans = BD.IniciarTransaccion();
                    try
                    {                       
                        ClaseBase.Actualizar();
                        if (trans) BD.FinalizarTransaccion(true);
                    }
                    catch (Exception)
                    {
                        if (trans) BD.FinalizarTransaccion(false);
                        throw;
                    }
                    
                    OnClaseBaseActualizado(eventArgs);
                
                }

                
            
            }

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)

            /// <summary>
            /// Es un procedimiento que debe ser sobreescrito en los formularios heredados para dar funcionalidad al formulario.
            /// No es obligatorio que sea sobreescrito ya que se puede dar la funcionalidad del binding sobreescribiendo ClaseBaseAControles y ControlesAClaseBase
            /// Es recomendable el utilizar DefinirListaBinding.
            /// </summary>
            protected virtual void DefinirListaBinding()
            { 
            }


            /// <summary>
            /// Es una Función que se debe sobreescribir en los formularios heredados si no utilizamos lstBinding
            /// Su función es la de pasar el contenido de la clase base a los controles del formulario.
            /// Para ello se valdrá de la función ClaseBaseAcontrol, a la que llamará por cada uno de los controles.
            /// </summary>
            protected virtual void ClaseBaseAControles()
            {
                if (lstBinding.Count > 0)
                    foreach (BindingMaestro item in lstBinding)
                        ClaseBaseAcontrol(ClaseBase, item.NombrePropiedad, item.ControlAsociado);
                            
            }

            /// <summary>
            /// Es una funcion a la que se debe llamar en claseBaseAControles, por cada control existente
            /// genera el evento PropiedadAControl. 
            /// Dicho evento nos indica la clase a la que se le cambiará la propiedad, el nombre de la propiedad y el control
            /// desde el que se obtendrá el valor.             
            /// </summary>            
            /// <param name="claseBase"></param>
            /// <param name="nombrePropiedad"></param>
            /// <param name="controlAsociado"></param>
            protected virtual void ClaseBaseAcontrol(IClaseBase claseBase,string nombrePropiedad,Control controlAsociado)
            {
                PropiedadBindEventArgs eventArgs = new PropiedadBindEventArgs();
                eventArgs.ClaseBase = claseBase;
                eventArgs.NombrePropiedad = nombrePropiedad;
                eventArgs.Control = controlAsociado;

                OnPropiedadAControl(eventArgs);
                if (!eventArgs.Cancelar)
                    Generic.ClaseBaseAcontrol(claseBase, nombrePropiedad, controlAsociado); 
            }

            /// <summary>
            /// Es una Función a la que se debe llamar en ControlesAClaseBase, por cada control existente
            /// Genera el Evento ControlAPropiedad.
            /// Se debe usar cuando no utilizamos lstBinding
            /// </summary>
            /// <param name="claseBase"></param>
            /// <param name="nombrePropiedad"></param>
            /// <param name="controlAsociado"></param>
            /// <param name="requerido"></param>
            protected virtual void ControlAClaseBase(IClaseBase claseBase, string nombrePropiedad, Control controlAsociado,bool requerido)
            {
                PropiedadBindEventArgs eventArgs = new PropiedadBindEventArgs();
                eventArgs.ClaseBase = claseBase;
                eventArgs.NombrePropiedad = nombrePropiedad;
                eventArgs.Control = controlAsociado;

                OnControlAPropiedad(eventArgs);
                if (!eventArgs.Cancelar)
                    Generic.ControlAClaseBaseConValidacion(claseBase, nombrePropiedad, controlAsociado, requerido, this.ErrorProvider);
            }

            /// <summary>
            /// Es una funcion que debe ser llamada en ControlesAClaseBase, por cada control existente
            /// Es llamada automáticamente cuando utilizamos lstBinding
            /// Nos permite mucho mas juego.
            /// </summary>
            /// <param name="elementoBind"></param>
            protected virtual void ControlAClaseBase(BindingMaestro elementoBind)
            {               
                PropiedadBindEventArgs eventArgs = new PropiedadBindEventArgs();
                eventArgs.ClaseBase = elementoBind.Objeto;
                eventArgs.NombrePropiedad = elementoBind.NombrePropiedad;
                eventArgs.Control = elementoBind.ControlAsociado;

                OnControlAPropiedad(eventArgs);
                if (!eventArgs.Cancelar)
                    Generic.ControlAClaseBaseConValidacion(elementoBind,this.ErrorProvider,this.ClaseBase);
                    //OJO CON ESTA LINEA (le mando el objeto del formulario cuando deberia mandarle el de la lista)
                    //pero el formulario cada vez que actualiza, carga la clase en un nuevo contexto
                    ///y esto hace que el objeto almacenado en la lista (elementoBind) no sea el mismo que el objeto activo del formulario.

            }

         
            /// <summary>
            /// Sobrecarga que permite tratar todos los elementos como no requeridos
            /// </summary>
            /// <param name="claseBase"></param>
            /// <param name="nombrePropiedad"></param>
            /// <param name="controlAsociado"></param>
            protected virtual void ControlAClaseBase(IClaseBase claseBase, string nombrePropiedad, Control controlAsociado)
            {
                ControlAClaseBase(claseBase, nombrePropiedad, controlAsociado, false);
            }
        
        
            /// <summary>
            /// Es una Función que se debe sobreescribir en los formularios heredados si no utilizamos lstBinding
            /// Su función es la de pasar el contenido de los controles del formulario a la clase base   
            /// Su llamada se realiza desde Guardar() en el formulario base GenericEdit.
            /// </summary>
            protected virtual void ControlesAClaseBase()
            {                
                if (lstBinding.Count > 0)
                    foreach (BindingMaestro item in lstBinding)
                        ControlAClaseBase(item);
                
            }

            /// <summary>
            /// Es una Función que se debe sobreescribir en los formularios heredados si no utilizamos lstBinding
            /// Es una función que se llama antes de iniciar cualquier operación de actualizacion (Inserción o modificacion)
            /// Se encarga de retornar un valor booleano que nos indica si los datos encontrados en el formulario son válidos o no.
            /// Entre otras aqui comprobaremos, elementos requeridos, tipos de datos, etc...            
            /// </summary>
            /// <returns></returns>
            protected override bool Validar()
            {
                return true;
                //Ya no es necesaria la validacion de los elementos del lstbinding pq se hacen en ControlAClaseBaseConValidacion

                //bool Rtno = true;

                ////Validacion general si existe lstBinding, de lo contrario debe hacerse en el propio formulario
                //foreach (BindingMaestro item in this.lstBinding)
                //{
                //    if (!Generic.ControlDatosCorrectos(item.ControlAsociado,this.ErrorProvider,item.TipoDatos,item.Requerido))
                //        Rtno = false;

                //}

                //return Rtno;

            }

        /// <summary>
        /// Función que valida los controles en funcion de la lista de binding establecida en el formulario
        /// puede ser llamada en ocasiones desde formularios heredados para comprobar que todos los datos son correctos antes de hacer operaciones.
        /// </summary>
        /// <returns></returns>
        protected virtual bool validarlstBinding()
        {
            bool Rtno = true;

            //Validacion general si existe lstBinding, de lo contrario debe hacerse en el propio formulario
            foreach (BindingMaestro item in this.lstBinding)
            {
                if (!Generic.ControlDatosCorrectos(item.ControlAsociado, this.ErrorProvider, item.TipoDatos, item.Requerido))
                    Rtno = false;

            }

            return Rtno;

        
        }
         


        
        #endregion


    }
}
