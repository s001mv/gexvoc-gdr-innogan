using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Reflection;
using System.Reflection;
using GEXVOC.Core.Generic;
using GEXVOC.Core.Controles;

namespace GEXVOC.UI
{
    /// <summary>
    /// Plantilla Generica de la que heredan las plantillas base como GenericFind y GenericEdit
    /// Esta platilla proporcionará los elementos comunes y necesarios para el correcto funcionamiento de las plantillas más concretas
    /// Aqui se establecerán los métodos y propiedades comunes, en ocasiones esta plantilla generica establecerá la funcionalidad, y en 
    /// otras requerirá que dicha funcionalidad sea proporcionada por los elementos dependientes.
    /// </summary>
    public partial class GenericMaestro : Form
    {
        
        #region CONSTRUCTORES
            /// <summary>
            /// Constructor sin parametros
            /// </summary>
            public GenericMaestro()
            {
                InitializeComponent();
            }
        #endregion

        #region EVENTOS
            public event EventHandler<ModoCambiandoEventArgs> ModoCambiando;
            public event EventHandler<ModoEventArgs> ModoCambiado;

            protected virtual void OnModoCambiando(ModoCambiandoEventArgs e)
            {
                EventHandler<ModoCambiandoEventArgs> handler = ModoCambiando;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
            protected virtual void OnModoCambiado(ModoEventArgs e)
            {
                EventHandler<ModoEventArgs> handler = ModoCambiado;
                if (handler != null)
                {
                    handler(this, e);
                }
            }
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
          
            /// <summary>
            /// Propiedad que nos indicará si se ha ejecutado al menos una vez el método Cargar();
            /// Es utilizada por la plantilla para invocar automaticamente el método Cargar() en caso de que este no haya sido invocado
            /// </summary>
            public Boolean Cargado{get;set;}
          

            // <summary>
            /// Variable que guarda el Estado del formulario Find
            /// Dicha variable probocará un funcionamiento u otro del formulario Find
            /// Puede Tener los Valores Leer o Consultar
            /// </summary>
            private Modo _ModoActual = Modo.Defecto;

            protected Modo ModoActual
            {
                get { return _ModoActual; }
                set 
                {
                    //Inicializo los argumentos del evento ModoCambiando
                    ModoCambiandoEventArgs eventArgs = new ModoCambiandoEventArgs();
                    eventArgs.ModoAntes = _ModoActual;
                    eventArgs.ModoDespues = value;

                    //Lanzo el evento ModoCambiando
                    OnModoCambiando(eventArgs);

                    if (!eventArgs.Cancelar)
                    {
                        _ModoActual = value;

                        //Inicializo los argumentos del evento ModoCambiado
                        ModoEventArgs eventArgsCambiado = new ModoEventArgs();
                        eventArgsCambiado.modo = _ModoActual;
                        //Lanzo el evento ModoCambiado
                        OnModoCambiado(eventArgsCambiado);
                    }
                }
            }



          
            /// <summary>
            /// Propiedad que nos indica si despues de pulsar el botón limpiar se produce la carga de valores por defecto.
            /// Si es Verdadero, cada vez que se ejecute el método Limpiar, se enlazará automáticamente con una ejecución del método ValoresDefecto
            /// Se utiliza en el método limpiar.
            /// </summary>
            public Boolean CargarValoresDefectoDespuesLimpiar{get;set;}


         
            public Principal MDI 
            {
                get
                {
                    if (MdiParent != null && this.MdiParent.GetType() == typeof(Principal))
                        return (Principal)this.MdiParent;
                    else
                        return null;
                    
                }
            }

            /// <summary>
            /// Colección de elementos que proporcionan el Binding Automatico en el formulario.
            /// Es una colección Ordenada de elementos del tipo BindingMaestro
            /// </summary>
            public List<BindingMaestro> lstBinding = new List<BindingMaestro>();

            /// <summary>
            /// Lista que contiene referencias a los controles que actualmente tienen errores en el formulario.
            /// </summary>
            public List<Control> lstControlesConErrores = new List<Control>();

            /// <summary>
            /// Variable principal del tipo PantallaEspera que nos proporcionará acceso a las propiedades de la Pantalla de espera.
            /// </summary>
            public PantallaEspera pantallaEspera = null;
        #endregion

        #region CARGAS COMUNES

            /// <summary>
            /// Método que Carga los Grids 
            /// Es llamado despues de ClaseBaseAControles
            /// Sólo es necesario sobreecribirlo cuando nos encontramos ante un formulario Edit con Grids de Detalle
            /// Aqui se establecerá la información especifica para actualizar el contenido de los grid de detalle
            /// con la información que contiene la ClaseBase (Objeto Principal)
            /// </summary>
            protected virtual void CargarGrids() { }

            /// <summary>
            /// Método de Carga de Combos
            /// Es llamado desde Cargar() que se ejecuta en las sobrecargas necesarias de los constructores GenericEdit y GenericFind
            /// Carga el contenido (Inicial) de los combos existente en el formulario
            /// NOTA: Si existe un combo que depende del contenido de otro combo, no se inicializa aquí, se inicializa
            /// En el Evento correspondiente del Combo en cuestión.
            /// </summary>
            protected virtual void CargarCombos() { }

            /// <summary>
            /// Método que Inicializa los controles de un formulario a sus valores por Defecto
            /// Este método debe ser sobreescrito si es necesaria esta funcionalidad.
            /// Es llamado por la plantilla en Cargar()
            /// - Es utilizado en Inserciones en formularios GenericEdit
            /// - Es utlizado en la carga en los formularios GemericFind
            /// - Puede ser llamado en GenericFind despues de limpiar los controles (Depende de la propiedad Booleana "CargarValoresDefectoDespuesLimpiar"
            /// </summary>
            protected virtual void CargarValoresDefecto() { }

            /// <summary>  
            /// Debe ser sobreecrito para añadir la funcionalidad de Buscar
            /// Probocará que se cargue el grid principal con los elementos que cumplen el criterio de búsqueda
            /// formado por la combinación de los controles visibles.
            /// Se utiliza en los formularios GenericFind
            /// </summary>
            protected virtual void Buscar() { }


            /// <summary>
            /// Método de carga de datos utilizado en formularios del tipo GenericFind y GenericEdit
            /// Es un método necesario para la carga inicial de los controles.
            /// Debe ser ejecutado siempre antes de mostrar el formulario, y sobreescrito en todo formulario que herede directamente de GenericMaestro.
            /// Dicha sobreescritura debe finalizar siempre estableciendo la propiedad Cargado a true (Propiedad de GenericMaestro)
            /// Si no se llama a Cargar() antes de hacer el show de un formulario, es llamado en el Load() (Codigo establecido en GenericMaestro)
            /// 
            /// Sería el método ideal para mostrar una pantalla de "Cargando..." por cada formulario.
            /// </summary>
            public virtual void Cargar() 
            {
                Generic.PonerControlesMayusculas(this);
                CargarCombos();            
            }

            public virtual void Cargar(Boolean Forzar) 
            {
               

                if ((this.Cargado & Forzar) | !this.Cargado)
                {
                    Generic.EjecutarProcesos(this);
                    this.Cargar();
                    
                }
            }

            public void CargarCombo(ComboBox combo, string displayMember, string valueMember, object dataSource, int? valorFijo, bool seleccionarUnico)
            {
                combo.ValueMember = valueMember;
                combo.DisplayMember = displayMember;
                combo.DataSource = dataSource;
                combo.SelectedIndex = -1;
                Application.DoEvents();
                if (valorFijo != null)
                    combo.SelectedValue = valorFijo;
                combo.Enabled = (valorFijo == null);

                if (seleccionarUnico)
                    if (combo.DataSource != null && combo.Items.Count == 1)//Si el combo posee solo un elemento, este se seleccionará automaticamente
                        combo.SelectedIndex = 0;




            }
            public void CargarCombo(ComboBox combo, string displayMember, string valueMember, object dataSource)
            {
                CargarCombo(combo, displayMember, valueMember, dataSource, null, false);
            }
            public void CargarCombo(ComboBox combo, string displayMember, object dataSource)
            {
                CargarCombo(combo, displayMember, "Id", dataSource, null, false);
            }
            public void CargarCombo(ComboBox combo, string displayMember, object dataSource, bool seleccionarUnico)
            {
                CargarCombo(combo, displayMember, "Id", dataSource, null, seleccionarUnico);
            }
            public void CargarCombo(ComboBox combo, object dataSource)
            {
                CargarCombo(combo, "Descripcion", "Id", dataSource, null, false);
            }
            public void CargarCombo(ComboBox combo, object dataSource, bool seleccionarUnico)
            {
                CargarCombo(combo, "Descripcion", "Id", dataSource, null, seleccionarUnico);
            }
            public void CargarCombo(ComboBox combo, object dataSource, int? valorFijo)
            {
                CargarCombo(combo, "Descripcion", "Id", dataSource, valorFijo, false);
            }
            public void CargarCombo(ComboBox combo, string displayMember, object dataSource, int? valorFijo)
            {
                CargarCombo(combo, displayMember, "Id", dataSource, valorFijo, false);
            }

            /// <summary>
            /// Carga el combo con los valores descriptivos de una enumeración.
            /// Utiliza el atributo "EnumDescription" en caso de existir.
            /// </summary>
            /// <param name="combo"></param>
            /// <param name="enumeracion"></param>
            public void CargarComboEnum(ComboBox combo, Enum enumeracion)
            {
                if (combo != null && enumeracion != null)
                {
                    combo.DataSource = enumeracion.GetType().ToList<int>();// typeof(Enum).ToList<int>();
                    combo.DisplayMember = "Value";
                    combo.ValueMember = "Key";
                    combo.SelectedIndex = -1;
                }
            }

       

        #endregion

        #region FUNCIONAMIENTO GENERAL

            /// <summary>
            /// Lanza un formulario y recarga el/los grid.
            /// - Se llama a este método desde las acciones de insertar y modificar de los grids de detalle en los formulario GenericEdit. 
            /// - Se llama a este método desde las acciones de Nuevo y Modificar de los formularios GenericFind.   
            /// La recarga de el/los grid será realizada a través de los métodos CargarGrids() (Usado en GenericEdit) y Buscar() (Usado en GenericFind)
            /// </summary>
            /// <param name="frmLanzar">Formulario que debe lanzar</param>
            /// <returns>Resultado del formulario en forma de DialogResult. </returns>
            public DialogResult LanzarFormulario(Form frmLanzar)
            {
                DialogResult rtno = DialogResult.Cancel;
                if (frmLanzar != null)
                {
                    //Antes de mostrar el formulario, y por tanto antes del load, ejecuto el método Cargar(), para asegurarme de cargar
                    //los datos necesarios (combos entre otros)
                    //Tb utilizo la carga antes y no en el load, pq cuando esta carga se realiza en el load, si tarda se produce un efecto muy feo
                    //en el formulario cuando se esta mostrando, parece que queda como colgado, si esto tarda y el usuario quiere interactuar no puede.
                    //Con este método lo que hacemos es no mostrar absolutamente nada del formulario hasta que este tenga los datos necesarios,
                    //con lo que como mucho, nos tarda un poco mas en cargar el formulario pero cuando se muestra ya esta cargado, activo y respondiendo
                    //al usuario.                    
                    if (frmLanzar.GetType().BaseType == typeof(GenericEdit) | frmLanzar.GetType().BaseType == typeof(GenericFind))
                        ((GenericMaestro)frmLanzar).Cargar(false);

                    Application.DoEvents();
                    rtno = frmLanzar.ShowDialog(this);
                    Application.DoEvents();
                    this.CargarGrids();//Para formularios GenericEdit

                    if (this.GetType().BaseType == typeof(GenericFind))                    
                        this.Buscar();//Para formularios GenericFind

                    Application.DoEvents();

                    frmLanzar.Dispose();
                }

                return rtno;

            }

            /// <summary>
            /// Sobrecarga que brinda la posibilidad de seleccionar, dentro del grid tomado como parametro, 
            /// el objeto concreto que se encuentra en edición.
            /// </summary>
            /// <param name="frmLanzar">Formulario que debe lanzar</param>
            /// <param name="grid">DataGridView en el que se buscará el objeto a seleccionar despues de su tratamiento</param>
            /// <returns></returns>
            public DialogResult LanzarFormulario(GenericEdit frmLanzar, DataGridView grid)
            {
                DialogResult rtno = LanzarFormulario(frmLanzar);
                if (grid != null)
                    SeleccionarObjGrid(frmLanzar.ClaseBase, grid);

                return rtno;
            }

            /// <summary>
            /// Sobrecarga que lanza el formulario en modo consulta.
            /// </summary>
            /// <param name="frmLanzar"></param>
            /// <returns></returns>
            public DialogResult LanzarFormularioConsulta(GenericMaestro frmLanzar)
            {
                frmLanzar.MinimizeBox = false;
                frmLanzar.ModoActual = Modo.Consultar;
                DialogResult rtno = frmLanzar.ShowDialog(this);
                frmLanzar.Dispose();
                return rtno;
            }

            /// <summary>
            /// Puede ser sobreescrito pero no es lo habitual
            /// Elimina la informacion cargada en el formulario y limpia el contenido de los controles 
            /// Se utiliza habitualmente para iniciar nuevas búsquedas
            /// </summary>
            protected virtual void Limpiar()
            {
                Generic.LimpiarControles(this);
                this.ErrorProvider.Clear();
                this.lstControlesConErrores.Clear();
                

                if (this.CargarValoresDefectoDespuesLimpiar)
                    this.CargarValoresDefecto();
            }

            /// <summary>
            /// Selecciona un objeto del tipo iclasebase en el grid.
            /// Dicho objeto debe estar incluido en el grid, de lo contrario no se hace nada.
            /// </summary>
            /// <param name="obj"></param>
            /// <param name="grid"></param>
            public void SeleccionarObjGrid(IClaseBase obj, DataGridView grid)
            {
                if (grid != null && grid.DataSource != null && obj != null)
                {
                    foreach (DataGridViewRow row in grid.Rows)
                        if (((IClaseBase)row.DataBoundItem).Id == obj.Id)
                            if (row.Cells.Count > 0)//Si la fila tiene celdas (Debe tener siempre)
                            {
                                //Nota: Debe ser mejorado, pq si coincide que selecciona un elemento no visible, lo hace visible
                                //pero no se actualiza correctamente el scroll del grid.                            
                                grid.CurrentCell = row.Cells[0]; //Marco la primera celda de la fila como actual                            

                            }
                }
            }

            /// <summary>
            /// Asiga una lista genérica a un datagrid.
            /// Transforma la lista genérica en una lista que soporta ordenación.
            /// Si el datagrid tenía algún orden aplicado, se restablece despues de asignar el origen de datos.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="lista"></param>
            /// <param name="dtg"></param>
            public void AsignarOrigenDatos<T>(List<T> lista, DataGridView dtg)
            {

                if (dtg == null)
                    throw new ArgumentException("El elemento debe existir", "dtg");



                //Guardo el orden anterior si es que lo tenia establecido
                DataGridViewColumn colOrden = dtg.SortedColumn;
                SortOrder orden = dtg.SortOrder;

                //Primero elimino cualquier dato que pueda tener asignado
                dtg.DataSource = null;

                //Asigno el origen de datos pero transformado en una Lista que soporta ordenación
                dtg.DataSource = new SortableBindingList<T>(lista);

                //Restablezco el orden si lo tenía.
                if (colOrden != null)
                    dtg.Sort(colOrden, orden == SortOrder.Descending ? ListSortDirection.Descending : ListSortDirection.Ascending);

            }


            /// <summary>
            /// Deshabilita el formulario y muestra una pantalla de espera.
            /// Puede ser infinita, o podemos proporcionar número de elementos.
            /// </summary>
            public void IniciarEspera()
            {
                Application.DoEvents();
                pantallaEspera = new PantallaEspera();
                Generic.CentrarFormulario(this, pantallaEspera);
                pantallaEspera.Show(this);
                this.Enabled = false;
                Application.DoEvents();
            }

            /// <summary>
            /// Habilita el formulario y elimina la pantalla de espera.      
            /// </summary>
            public void FinalizarEspera()
            {
                Application.DoEvents();
                this.Enabled = true;
                if (pantallaEspera != null)
                {
                    pantallaEspera.pgbProceso.Value = pantallaEspera.pgbProceso.Maximum;
                    pantallaEspera.pgbProceso.Refresh();
                    Application.DoEvents();
                    pantallaEspera.Dispose();
                }
                Application.DoEvents();
            }

            #region NOTIFICACIONES
            public void Notificar(object sender, NotificableEventArgs e)
            {
                if (!string.IsNullOrEmpty(e.Mensaje.Mensaje))
                    Principal.Mostrar_Mensaje(e.Mensaje.Mensaje);


            }
            public string MensajeNotificarVarios = string.Empty;
            public void NotificarVarios(object sender, NotificableEventArgs e)
            {
                if (!string.IsNullOrEmpty(e.Mensaje.Mensaje))
                    MensajeNotificarVarios += e.Mensaje.Mensaje + "\r";
            }
            #endregion

            /// <summary>
            /// Lanza el formulario especificado para la creación de un elemento desde un combo.
            /// Cuando se termina la edición se carga el combo con los nuevos datos y se selecciona el objeto creado si existe.
            /// </summary>
            /// <param name="frmLanzar"></param>
            /// <param name="combo"></param>
            public void CrearNuevoElementoCombo(GenericEdit frmLanzar, object combo)
            {
                this.LanzarFormulario(frmLanzar);


                if (frmLanzar.ClaseBase.Id != 0)
                {
                    int IdSeleccionar = frmLanzar.ClaseBase.Id;
                    if (combo.GetType() == typeof(ctlCombo))
                    {
                        ctlCombo ctlCombo = (ctlCombo)combo;
                        ctlCombo.CargarCombo();
                        Generic.IntNullableAControl(ctlCombo, IdSeleccionar);
                    }
                    if (combo.GetType() == typeof(ctlBuscarObjeto))
                    {
                        ctlBuscarObjeto ctlBuscarObjeto = (ctlBuscarObjeto)combo;
                        ctlBuscarObjeto.ClaseActiva = frmLanzar.ClaseBase;
                    }
                }

                Application.DoEvents();
            }

        #endregion

        #region EVENTOS CAPTURADOS

            private void GenericMaestro_Load(object sender, EventArgs e)
            {
                if (!this.DesignMode)
                    this.Cargar(false);
            }

           
        #endregion

        #region FUNCIONAMIENTO CONTEXTO (OPERACIONES BASE DATOS)

            /// <summary>
            /// Inicia el contexto BDOperaciones, que se utilizará antes de hacer actualizaciones de datos
            /// Todas las clases para su actualizacion utilizan por defecto el contexto de operaciones.
            /// Dicha modificación provocará un error si dicho contexto no se encuentra iniciado.
            /// Nota: El contexto no puede ser iniciado varias veces, esto provocará una excepción.
            /// Nota: El contexto debe mantenerse abierto el menor tiempo posible, debe iniciarse operar y cerrarse.
            /// </summary>
            public void IniciarContextoOperacion()
            {

                BD.IniciarBDOperaciones();
            }

            /// <summary>
            /// Finaliza el contexto BDOperaciones.
            /// Una vez finalizado dicho contexto una clase no prodrá ser modificada (a nivel de datos) hasta que dicho contexto vuelva a ser abierto.
            /// </summary>
            public void FinalizarContextoOperacion()
            {
                BD.FinalizarBDOperaciones();
            }
        
        #endregion

        #region VALIDACIÓN Y ERRORES


        /// <summary>
        /// Elimina las marcas de error del formulario y vacía la Lista que contiene los controles con errores asociados.
        /// </summary>
        protected void QuitarErrores()
        {         
            this.ErrorProvider.Clear();
            this.lstControlesConErrores.Clear();
        }       

        /// <summary>
        /// Es un Método que Valida los controles del formulario antes de traspasar sus valores a la ClaseBase
        /// Este método debe ser sobreescrito si es necesaria esta funcionalidad.
        /// Retorna un Valor Booleano que nos indica si todos los controles contienen datos válidos.
        /// Es ejecutado auutomáticamente por la plantilla cuando se pulsa guardar (Para añadir o actualizar)
        /// Si se devuelve un valor negativo, se cancela el proceso.
        /// </summary>
        /// <returns>Valido(Sí/No)</returns>
        protected virtual bool Validar()
        {
           return true;
        }

        /// <summary>
        /// Método que realiza la validacion de los controles del formulario
        /// La validación la realiza a través del método validar()
        /// Establece el foco en el siguiente control con errores.
        /// NO debe ser sobreescrita salvo excepciones.
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidarControles()
        {
            bool Rtno = true;
            QuitarErrores();


            Rtno = Validar();

            MoverFocoSiguienteError();

            return Rtno;

        }

        /// <summary>
        /// Posiciona el foco en el siguiente control con errores, para ello utiliza una 
        /// lista conocida como lstControlesConErrores que es rellenada por las funciones generic
        /// de comprobacion de datos en los controles, y que debe ser borrada cada vez que borramos nuestro 
        /// error Provider.
        /// </summary>
        public void MoverFocoSiguienteError()
        {
            //Nota: Tiene un problema si existen varios grupos o paneles, puestos que estos 
            //reinician los contadores de los indices y puede ser que se nos muestre como
            //siguiente control con errores un control dentro de un panel con el indice 3 a pesar de tener
            //en controles anteriores 3 controles con errores que no esten en un panel con indices pe: 7,8,9
            if (lstControlesConErrores.Count > 0)//Me aseguro de que existen elementos en la lista
            {
                Control indiceMenor = null;
                //Recorro los controles y selecciono el que tenga menor valor en TabIndex
                foreach (Control item in this.lstControlesConErrores)
                {
                    if (indiceMenor != null)
                    {
                        if ((item.TabIndex < indiceMenor.TabIndex) && item.TabStop)
                            indiceMenor = item;
                    }
                    else
                        indiceMenor = item;

                }
                indiceMenor.Focus();
            }
        }

        #endregion

        #region DATOS - BINDING

        /// <summary>
        /// Elimina el/los objeto/s seleccionado/s del grid
        /// Se llama a este método desde la acción eliminar de los grids de detalle.
        /// </summary>
        /// <param name="Grid"></param>
        /// <param name="mensaje"></param>
        public void EliminarObjGrid(DataGridView Grid, string mensaje)
        {
          
            try
            {
                if (Grid.SelectedRows.Count > 0 && ModoActual == Modo.Actualizar)
                {
                    int OperacionesCorrectas = 0;
                    int OperacionesIncorrectas = 0;
                    if (DialogResult.Yes == Generic.Aviso(mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mensajeError = string.Empty;
                        MensajeNotificarVarios = string.Empty;
                        foreach (DataGridViewRow item in Grid.SelectedRows)
                        {
                            try
                            {
                                this.IniciarContextoOperacion();
                                bool trans = BD.IniciarTransaccion();
                                IClaseBase objEliminar = (IClaseBase)item.DataBoundItem;
                                try
                                {
                                    if (objEliminar.GetType().GetInterface(typeof(INotificable).Name) != null)
                                        ((INotificable)objEliminar).Notificar += new EventHandler<NotificableEventArgs>(this.NotificarVarios);

                                    objEliminar.Eliminar();
                                    if (trans) BD.FinalizarTransaccion(true);
                                }
                                catch (Exception)
                                {
                                    if (trans) BD.FinalizarTransaccion(false);
                                    throw;
                                }
                                OperacionesCorrectas += 1;
                            }
                            catch (Exception ex)
                            {
                                mensajeError += ex.Message + "\r";
                                OperacionesIncorrectas += 1;
                            }
                            finally
                            {
                                this.FinalizarContextoOperacion();
                            }
                        }
                        if (!string.IsNullOrEmpty(MensajeNotificarVarios))//Si se han producido notificaciones de una clase del tipo INotificable, las muestro                        
                            Principal.Mostrar_Mensaje(this.MensajeNotificarVarios);
                        
                        if (!string.IsNullOrEmpty(mensajeError))
                        {
                            Generic.AvisoAdvertencia("Se han producido errores en un total de (" + ((int)OperacionesCorrectas + OperacionesIncorrectas) + ") Operaciones => " +
                                                 "(" + OperacionesCorrectas + ") Correctas y (" + OperacionesIncorrectas + ") Incorrectas.\r" +
                                                 "Resumen e Información adicional: \r" +
                                                   mensajeError);
                        }
                        CargarGrids();
                    }
                }
            }
            catch (Exception ex)
            {
                Generic.AvisoError("Error eliminando.\rMensaje: " + ex.Message);
            }
            finally
            { this.FinalizarContextoOperacion(); }

        }

        /// <summary>
        /// Elimina el objeto seleccionado del grid
        /// Se llama a este método desde la acción eliminar de los grids de detalle.
        /// </summary>
        /// <param name="Grid"></param>
        public void EliminarObjGrid(DataGridView Grid)
        {
            this.EliminarObjGrid(Grid, "Va a eliminar el/los elemento/s seleccionado/s de la Aplicación.\r¿Esta usted seguro de que desea continuar?");
        }


        #endregion            

       
    }
}
