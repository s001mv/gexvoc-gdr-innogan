using System;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Controles;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GEXVOC.Core.Generic;
using System.ComponentModel;
namespace GEXVOC.UI
{
    public partial class GenericFind : GenericMaestro
    {

        #region CONSTRUCTORES
            /// <summary>
            /// Constructor sin parametros
            /// </summary>
            public GenericFind()
            {
                InitializeComponent();
             
            }

            /// <summary>
            /// Es la inicializacion de la clase base con parametros
            /// Dicha inicialización se hace cuando necesitamos heredar de GenericFind, y necesitamos la
            /// funcionalidad de lanzar el formulario en modo consulta (Para por ejemplo, rellenar el contenido de un combo (Llamado controlBusqueda)
            /// Es este caso el fomulario si se encuentra en modo consulta y se especifica un controlBusqueda, cambia su manera de actuar.
            /// Muestra u oculta algunos elementos, y el doble click en el grid tiene distintas consecuencias en funcion del modo en el que
            /// haya sido lanzado.
            /// <param name="modo">Modo en el que se lana el formulario (Consultar, Leer, ...)</param>
            /// <param name="controlBusqueda">Combo en el que añadiremos el valor seleccionado</param>
            public GenericFind(Modo modo, ctlBuscarObjeto controlBusqueda)
            {
                InitializeComponent();


                ControlBusqueda = controlBusqueda;
                this.ModoActual = modo;
                ControlModo(ModoActual == Modo.Leer || ModoActual == Modo.Consultar);
                this.MinimizeBox = false;

            }          
         
                
        #endregion

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO

      
            string _TextoEliminar = "Va a proceder a borrar los datos seleccionados\r" +
                        "¿Desea continuar y borrar los registros?";

            public string TextoEliminar
            {
                get { return _TextoEliminar; }
                set { _TextoEliminar = value; }
            }

         

            ctlBuscarObjeto ControlBusqueda = null;

            /// <summary>
            /// Control de modo de apertura.
            /// </summary>
            /// <param name="modo">Modo de apertura.</param>
            public void ControlModo(bool modo)
            {
                btnNuevo.Visible = !modo;
                btnModificar.Visible = !modo;
                btnEliminar.Visible = !modo;
                Separador.Visible = !modo;
            }


            //System.Drawing.Point _TamanodtgResultado;

            public System.Drawing.Size dtgResultadoTamano
            {
                get { return this.dtgResultado.Size; }
                set { this.dtgResultado.Size = value; }
            }
            public System.Drawing.Size pnlBusquedaTamano
            {
                get { return this.pnlBusqueda.Size; }
                set { this.pnlBusqueda.Size = value; }
            }
            public System.Drawing.Point pnlBusquedaPosicion
            {
                get { return this.pnlBusqueda.Location; }
                set { this.pnlBusqueda.Location = value; }
            }
            public System.Drawing.Point dtgResultadoPosicion
            {
                get { return this.dtgResultado.Location; }
                set { this.dtgResultado.Location = value; }
            }
                           
    

        #endregion
        
        #region CARGAS COMUNES

            /// <summary>
            /// Inicializa los elementos necesarios para el correcto funcionamiento de un formulario del tipo GenericFind.
            /// Debe ser llamado antes de hacer el show del formulario, esta llamada es hecha habitualmente por el MDI.
            /// Se llama en el método LanzarFormulario espeficacdo en GenericMaestro
            /// </summary>
            public override void Cargar()
            {
                //Pone nos controles predefinidos en mayusculas
                Generic.PonerControlesMayusculas(this);

                dtgResultado.AutoGenerateColumns = false;
                GenerarEstiloGrid();
                CargarCombos();
                this.CargarValoresDefecto();

                this.Cargado = true;//Activo la propiedad que indica que al menos hemos ejecutado 1 vez por el método Cargar()
            }

        #endregion

        #region FUNCIONAMIENTO GENERAL
        
            /// <summary>
            /// Genera el stilo del grid principal, ya que no podrá ser editado en modo diseño
            /// </summary>
            protected virtual void GenerarEstiloGrid() { }

            /// <summary>
            /// Selecciono la fila del grid principal que contiene el objeto que se me envia como parametro
            /// </summary>
            /// <param name="obj"></param>
            public void SeleccionarObjGridPrincipal(IClaseBase obj)
            {
                this.SeleccionarObjGrid(obj, this.dtgResultado);
             }


            /// <summary>
            /// Asigna al datagridview principal el origen de datos que se especifica como argumento
            /// Se vale de la función principal declarada en GenericMaestro.
            /// NOTA: El parámetro debe ser una lista normal, para ello nos valemos de los genéricos.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="lista"></param>
            public void AsignarOrigenDatos<T>(List<T> lista)
            {
                this.AsignarOrigenDatos<T>(lista, dtgResultado);
            }
        

        #endregion

        #region EVENTOS CAPTURADOS

            /// <summary>
            /// Capturo el momento de cambio en datos en en grid.
            /// En este cambio actualizo la barra de estado para mostrar el número de registros que muestra el grid
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void dtgResultado_DataSourceChanged(object sender, EventArgs e)
            {
                this.lblBarraEstado.Text = "Búsqueda finalizada. (Registros: " + dtgResultado.Rows.Count.ToString() + ") ";
            }
            
            /// <summary>
            /// Capturamos el Load de la plantilla para añadir cierta funcionalidad
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            //private void GenericFind_Load(object sender, EventArgs e)
            //{
            //    //dtgResultado.AutoGenerateColumns = false;
            //    //GenerarEstiloGrid();
            //    //CargarCombos();
            //    //this.CargarValoresDefecto();
            //}

            /// <summary>
            /// Capturamos el evento dobleclick del datagridview para realizar operaciones tipicas del formulario
            /// Dichas operaciones dependerán del estado del formulario, hay 2 posibilidades a grandes rasgos
            ///  - Modo Consultar: Habitualmente en este caso se recibe por referencia un control llamado ControlBusqueda
            /// En este caso el formulario establece la informacion seleccionada en ControlBusqueda y se cierra 
            ///  - Cualquier otro modo != LEER: Editamos el registro seleccionado
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void dtgResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {

                this.dtgResultado.Enabled = false;
                try
                {
                    if (ModoActual == Modo.Consultar)
                    {
                        if (ControlBusqueda != null)
                        {
                            if (dtgResultado.SelectedRows.Count == 1)
                            {
                                //ControlBusqueda.DataSource = dtgResultado.DataSource;
                                if (dtgResultado.CurrentRow.DataBoundItem != null)
                                {
                                    //string DisplayMember = ControlBusqueda.DisplayMember;//Guardo el display member pq lo pierde
                                    //ControlBusqueda.DataSource = null;
                                    //ControlBusqueda.Items.Clear();
                                    //ControlBusqueda.Items.Add(dtgResultado.CurrentRow.DataBoundItem);
                                    //ControlBusqueda.SelectedItem = dtgResultado.CurrentRow.DataBoundItem;
                                    //ControlBusqueda.DisplayMember = DisplayMember;//Vuelvo a asignar el DisplayMember
                                    ControlBusqueda.ClaseActiva = (IClaseBase)dtgResultado.CurrentRow.DataBoundItem;


                                    this.Salir(sender, e);
                                }
                            }
                        }
                    }
                    else if (this.ModoActual != Modo.Leer)
                    {
                        if (dtgResultado.SelectedRows.Count == 1)
                        {
                            this.Modificar(this, null);
                        }
                    }
                }
                catch (Exception ex)
                {

                    Generic.AvisoError("Se ha producido un error en GenericFind: " + ex.Message);

                }
                finally
                { this.dtgResultado.Enabled = true; }
              
            }


        #endregion

        #region BOTONES BARRA SUPERIOR

          #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)
                
                /// <summary>
                /// Se produce cuando se pulsa el botón Nuevo de la Barra superior
                /// No Debe ser sobreecrito salvo excepciones
                /// Llama a Insertar()
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                protected virtual void Nuevo(object sender, EventArgs e) { this.Insertar(); }
                /// <summary>
                /// Debe ser Sobreescrito para añadir funcionalidad de Inserción
                /// Proboca que se muestre el formulario Edit correspondiente a este formulario Find en modo "Guardar"
                /// </summary>
                protected virtual void Insertar() { }

                /// <summary>
                /// Se produce cuando se pulsa el botón Modificar de la Barra superior
                /// No Debe ser sobreecrito salvo excepciones
                /// Llama a Modificar()                               
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                protected virtual void Modificar(object sender, EventArgs e) { this.Modificar(); }
                /// <summary>
                /// Debe ser sobreecrito para añadir la funcionalidad de Modificación
                /// Proboca que se muestre el formulario Edit correspondiente a este formulario Find en modo "Actualizar"
                /// Nota: Si hay varios elementos seleccionados o ninguno, no hace nada, solo funciona cuando hay
                /// un elemento seleccionado (solo 1).
                /// </summary>
                protected virtual void Modificar() { }


                /// <summary>
                /// Se produce cuando se pulsa el botón Eliminar de la Barra superior
                /// No Debe ser sobreecrito salvo excepciones
                /// Llama a Eliminar()
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                protected virtual void Eliminar(object sender, EventArgs e) {this.Eliminar(); }
                /// <summary>
                /// Se produce cuando se pulsa el botón Eliminar de la Barra superior
                /// Puede ser sobreecrito, pero no es lo habitual
                /// Proboca que sean eliminados todos los registros selecionados (Previa confirmación)
                /// Despues de eliminar, recarga el grid llamando a buscar()
                /// Nota: Si no hay elementos seleccionados en el grid no hace nada, debe haber mínimo 1 elemento seleccionado.
                /// </summary>
                protected virtual void Eliminar(){
                    this.ModoActual = Modo.Actualizar;
                    this.EliminarObjGrid(this.dtgResultado, TextoEliminar);
                    this.ModoActual = Modo.Defecto;
                    Buscar();                   
                }

                /// <summary>
                /// Se produce cuando se pulsa el boton eliminar, se llama tantas veces como registros seleccionados  existan.
                /// Puede ser sobreescrito, pero no es lo habitual
                /// Podemos sobreescribirlo para implementar en un formulario concreto distintas sobrecargas de eliminar.
                /// </summary>
                /// <param name="ObjEliminar">IClaseBase que se va a eliminar</param>
                protected virtual void EliminarObjeto(IClaseBase ObjEliminar)
                {
                    try
                    {
                        ObjEliminar.Eliminar();
                    }
                    catch (LogicException ex)
                    {
                        Generic.AvisoAdvertencia("No se ha podido eliminar el registro.\rDetalles: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Generic.AvisoError("No se ha podido eliminar el registro.\rDetalles: " + ex.Message);
                    }
                   

                }



          #endregion

            /// <summary>
            /// Se produce cuando se pulsa el botón salir de la Barra superior
            /// Llama a Salir()
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected virtual void Salir(object sender, EventArgs e){this.Salir();}
            /// <summary>
            /// Puede ser sobreecrito, pero no es lo habitual
            /// Proboca el cierre del formulario sin comprobaciones de actualizaciones pendientes
            /// </summary>
            protected virtual void Salir()
            {
                this.Close();
            }


               

            /// <summary>
            /// Se produce cuando se pulsa el botón buscar en la barra superior
            /// No Debe ser sobreecrito salvo excepciones       
            /// Llama a Buscar(), previamente valida el fommulario.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected virtual void Buscar(object sender, EventArgs e) {
                this.Validate(true);
                this.Buscar();
            }
       
          


            /// <summary>
            /// Se produce cuando se pulsa el botón Limpiar en la barra superior
            /// No Debe ser sobreecrito salvo excepciones     
            /// Llama a Limpiar       
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected virtual void Limpiar(object sender, EventArgs e){this.Limpiar();}

            /// <summary>     
            /// Elimina la informacion cargada en el formulario y limpia el contenido de los controles 
            /// Se utiliza habitualmente para iniciar nuevas búsquedas
            /// </summary>
            protected override void Limpiar()
            {
                lblBarraEstado.Text = String.Empty;
                base.Limpiar();
            }
         
         

        #endregion
    }
}
