using System;
using System.Windows.Forms;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Logic;
using System.Collections.Generic;
using System.Linq;
using GEXVOC.Core.Controles;
using System.Threading;
using System.Reflection;
using System.Collections;
using GEXVOC.Core.Reflection;
using GEXVOC.Core.Clases;
using System.Configuration;
using GEXVOC.Core.Registro;


namespace GEXVOC.UI
{
    public enum Modo
    {
        /// <summary>
        /// Modo por defecto.
        /// </summary>
        Defecto = -1,

        /// <summary>
        /// Leer.
        /// </summary>
        Leer = 0,

        /// <summary>
        /// Consultar.
        /// </summary>
        Consultar = 1,

        /// <summary>
        /// Guardar.
        /// </summary>
        Guardar = 2,

        /// <summary>
        /// Actualizar.
        /// </summary>
        Actualizar = 3,

        GuardarMultiple=4

    }

    public partial class Principal : Form
    {
        #region CONSTRUCTORES
            public Principal()
            {
                InitializeComponent();

                //Si no nos encontramos en modo depuración, no muesto el menu desarrollo (Lo elimino)
                if (!System.Diagnostics.Debugger.IsAttached){
                    this.MenuPrincipal.Items.Remove(MSDesarrollo);
                }

                ///Muestro la pantalla de configuración del servidor de datos en 2 casos
                /// 1) Es una instalacion de cliente y no ha sido configurada la clave del registro 'InstanciaServidor'
                /// 1) Es una instalación de cliente, ha sido configurada la clave del registro 'InstanciaServidor' y falla la conexión.
                if (Registro.GetSetting("TipoInstalacion") == "cliente" && (string.IsNullOrEmpty(Registro.GetSetting("InstanciaServidor")) || !Core.Data.BDController.ExisteBD()))
                {
                    //Todavía no ha sido configurado la instancia del servidor de datos

                    SeleccionServidor frmLanzar = new SeleccionServidor();
                    frmLanzar.ShowDialog();
                    if (string.IsNullOrEmpty(Registro.GetSetting("InstanciaServidor")))                    
                        return;   
                    
                }

                ///Compruebo si los datos de la conexión son válidos, de no ser así se cancela el inicio de la operación.
                ///Esto significará que los valores configurados en el registro que definen parte de la cadena de conexión, no son correctos.
                if (!Core.Data.BDController.ExisteBD())
                        throw new Exception(("No es posible establecer una conexión con el origen de datos, la aplicación no puede continuar. Contacte con su administrador.\nTipo Instalación: '" + Registro.GetSetting("TipoInstalacion","servidor") + "' Instancia: '" + Registro.GetSetting("InstanciaServidor")??string.Empty + "'" ));
                
                               
                Configuracion.Cargar();


                ///Si no sobremasamos la comprobacion de version correcta, mostramos el actualizador de versiones
                if (!Versionado.VersionCorrecta()) 
                {
                    bool VersionadoSimpleAutomatico = false;                    
                    if (ConfigurationManager.AppSettings.Get("VersionadoSimpleAutomatico") != null)
                        VersionadoSimpleAutomatico = bool.Parse(ConfigurationManager.AppSettings.Get("VersionadoSimpleAutomatico"));


                    ///A la hora de mostrar el formualrio de actualización de versiones tenemos 2 opciones
                    /// a) Existen scripts para actualizar
                    ///     (Siempre se mostrará el formulario actualizador de versiones).
                    /// b) No hay scripts la bd no ha cambiado, pero si la versión
                    ///     Se mostrará o no el formuario actualizador de versiones dependiendo del parámetro de configuración 'VersionadoSimpleAutomatico'
                    ///     Si se encuentra activo, actualizaremos automaticamente la version en la base de datos y arrancaremos la aplicacion                   

                    
                    if (VersionadoSimpleAutomatico && Versionado.ScriptsActualizar().Where(E=>E.Script!=string.Empty).Count() == 0 && Versionado.VersionAplicacion>=Versionado.VersionBaseDatos)                    
                        Versionado.ActualizarVersionBD();                    
                    else
                    {
                        MuestraVersion frmVersiones = new MuestraVersion() { PermitirCerrar = true };

                        frmVersiones.ShowDialog(this);
                        frmVersiones.Dispose();                    
                    }

                    Configuracion.Cargar();//Recargo la configuración porque puede ser que los scripts hayan actualizado algun valor de la configuración o de las listas del sistema
                }


                ///El actualizador de versiones pudo haber actualizado la version de la base de datos, o no.
                ///comprobamos nuevamente si la version de la bd es la correcta.
                ///Si no lo fuera, al cerrar el actualizador de versiones se nos envia un application.Exit(), con lo que 
                ///no procesamos nada más, puesto que la aplicación se cerrará en breve.
                if (Versionado.VersionCorrecta())
                {
                  

                    CargarMenusProductos();
                    CargarMenusFamiliasProductos();
                    CargarMenusInformes();
                    CargarMenusAyuda();

                    AbrirSelector(true);
                }              

            }

           
        #endregion

        #region PROPIEDADES PARA PROCESOS
            [ProcesoDescripcion("Principal - Muestra el botón: Controles (En la botonera superior)", "Producción de Leche")]
            public bool _proceso_ProducionLeche
            {
                set
                {                    
                    btnControles.Visible = value;
                }
            }
            [ProcesoDescripcion("Principal - Muestra el botón: Inseminaciones (En la botonera superior)", "Reproducción")]
            public bool _proceso_Reproduccion
            {
                set
                {
                    btnInseminaciones.Visible = value;                    
                }
            }

            [ProcesoDescripcion("Principal - Muestra el botón: Asignaciones Alimentarias (En la botonera superior)", "Alimentación")]
            public bool _proceso_Alimentacion
            {
                set
                {
                    btnAsignaciones.Visible = value;
                }
            }
            [ProcesoDescripcion("Principal - Muestra los botones: Cortes de hierba y Sembrados (En la botonera superior)", "Fincas")]
            public bool _proceso_Fincas
            {
                set
                {
                    btnCortes.Visible = value;
                    btnSembrados.Visible = value;
                }
            }

            [ProcesoDescripcion("Principal - Muestra el botón: Gastos (En la botonera superior)", "Economía")]
            public bool _proceso_Economia
            {
                set
                {
                    btnGastos.Visible = value;                    
                }
            }
            [ProcesoDescripcion("Principal - Muestra los botones: Animales y Titulares (En la botonera superior)", "Básico")]
            public bool _proceso_Basico
            {
                set
                {
                    btnTitulares.Visible = value;
                    btnAnimales.Visible = value;
                }
            }

            public bool AlertasActivadas = false;
            [ProcesoDescripcion("Principal - Permite la exploración y ejecución de alertas, si se encuentra activo, se  notificarán las alertas al poco de abrir la aplicación.")]
            public bool _proceso_Alertas
            {
                set
                {
                    AlertasActivadas = value;
                }
            }


        #endregion

        #region FUNCIONAMIENTO GENERAL

            Dictionary<string, Core.Logic.Menu> lstPermisosMenu=null;
            void PersonalizarMenus(ToolStripItemCollection colMenus) 
            {
                foreach (ToolStripItem mnu in colMenus)
                {             
                    if ((System.Diagnostics.Debugger.IsAttached && mnu.Name==MSDesarrollo.Name))//Omito los permisos aplicados al menu desarrollo si estoy utilizando el depurador.                
                        return;

                    if (mnu.Name == MSAyuda.Name) //Omito los permisos aplicados al menu Ayuda, ya que se mostrará siempre entero (Con la ayuda disponible).
                        return;
                    

                    mnu.Visible = lstPermisosMenu.ContainsKey(mnu.Name);//Comprobar permiso y asignar propiedad visible como corresponde.
                   
                    if (mnu.GetType() == typeof(ToolStripMenuItem))//Si nos encontramos ante un elemento del tipo menú llamamos a la recursividad.
                        PersonalizarMenus(((ToolStripMenuItem)mnu).DropDownItems);                
                    
                }
            }
            void MostrarMenus(ToolStripItemCollection colMenus)
            {
                foreach (ToolStripItem mnu in colMenus)
                {

                    mnu.Visible = true;

                    if (mnu.GetType() == typeof(ToolStripMenuItem))//Si nos encontramos ante un elemento del tipo menú llamamos a la recursividad.
                        MostrarMenus(((ToolStripMenuItem)mnu).DropDownItems);

                }
            }

        

            /// <summary>
            /// Abre el formulario de selección de explotación.
            /// </summary>
            private void AbrirSelector(bool mostrarEnBarra)
            {
                if (CerrarVentanas())
                {
                    this.Text = "GEXVOC - Gestión Ganadera";
                    Inicio frmInicio = new Inicio();
                    frmInicio.ShowInTaskbar = mostrarEnBarra;
                    frmInicio.ShowDialog(this);
                    frmInicio.Dispose();

                    this.Text += " || Explotación: " + Configuracion.Explotacion.Nombre;



                    //Personalizo los menús
                    lstPermisosMenu = Configuracion.Explotacion.lstMenusPermitidos;
                    if (lstPermisosMenu != null && lstPermisosMenu.Count > 0)
                        PersonalizarMenus(MenuPrincipal.Items);
                    else//No existen permisos definidos, se muestran todos los menús.
                        MostrarMenus(MenuPrincipal.Items);
                    
                    Generic.EjecutarProcesos(this);
                    RecargarAlertasAsync();
                }

            }

            /// <summary>
            /// Gestiona la visualización de formularios.
            /// </summary>
            /// <param name="formBase">Formulario a mostrar.</param>
            private void MostrarFormulario(Form formBase)
            {
                try
                {
                    if (!formBase.Visible)
                    {
                        formBase.MdiParent = this;

                        if (formBase.GetType().BaseType == typeof(GenericEdit) | formBase.GetType().BaseType == typeof(GenericFind))
                        {
                            ((GenericMaestro)formBase).Cargar(false);
                        }
                        //Console.WriteLine(DateTime.Now.ToString("fffffff"));
                        formBase.Show();
                    }
                    else
                    {
                        formBase.WindowState = FormWindowState.Normal;
                        formBase.Activate();
                    }
                }
                catch (Exception ex)
                {

                    Generic.AvisoError(ex.Message);
                }
                
            }

            
            /// <summary>
            /// Muestra un mensaje que emerje desde la barra de tareas
            /// </summary>
            /// <param name="Mensaje"></param>
            /// <param name="icono"></param>
            public static void Mostrar_Mensaje(string Mensaje, int icono)
            {
                
                if (!string.IsNullOrEmpty(Mensaje))
                {
                    ctlNotificador mensaje = new ctlNotificador(Mensaje, DateTime.Now);
                    mensaje.Mostrar();
                
                }
            }
         
        

            ////static Thread t = new Thread(new ThreadStart(mostrar));
            //static string Mensaje;
            ////static int icono;
            //static public void mostrar()
            //{
            //    if (Mensaje != string.Empty)
            //    {
                 
            //        ctlNotificadorMensajes gmailNotifierInfo = new ctlNotificadorMensajes();

            //        gmailNotifierInfo.Info = Mensaje;
            //        gmailNotifierInfo.Interval = 30;
            //        gmailNotifierInfo.TimeOut = 10;
            //        gmailNotifierInfo.ShowInfo();
            //        while (gmailNotifierInfo!=null)
            //        {
            //            Thread.Sleep(100);
            //        }
            //    }
            //}

            public static void Mostrar_Mensaje(string Mensaje)
            {
                Mostrar_Mensaje(Mensaje, -1);                
            }


            static public void  AgregarMensaje(string mensaje)
            {
                MensajesNotificar.Enqueue(mensaje);
            }


            static Queue<string> MensajesNotificar=new Queue<string>();

            static void mostrarCola() 
            {
                while (MensajesNotificar.Count>0)
                {
                    Mostrar_Mensaje(MensajesNotificar.Dequeue(), -1);
                }
            }



            public void CargarMenusAyuda() 
            {
                try
                {
                    System.IO.DirectoryInfo CarpetaAyuda = new System.IO.DirectoryInfo(Application.StartupPath + "/Ayuda/");
                    if (CarpetaAyuda.Exists)
                    {
                        foreach (System.IO.FileInfo item in CarpetaAyuda.GetFiles("*.swf",System.IO.SearchOption.AllDirectories))
                        {
                          
                            ToolStripMenuItem tsb = new ToolStripMenuItem(item.Name.Replace(item.Extension,string.Empty)) { Name = "MSAy" + item.Name, Tag = item.FullName};
                            tsb.Click += LanzadorAyuda;
                            MSAyuda.DropDownItems.Add(tsb);  
                            

                        }
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
                

            
            }

            GenericVisorSWF FVisorSWF = null; 
            private void LanzadorAyuda(object sender, EventArgs e)
            {             

                ToolStripMenuItem menu = (ToolStripMenuItem)sender;
                if (FVisorSWF == null || !FVisorSWF.Visible)
                    FVisorSWF = new GenericVisorSWF((string)menu.Tag);
                else
                    ((GenericVisorSWF)FVisorSWF).CargarSWF((string)menu.Tag);

                MostrarFormulario(FVisorSWF);
            }


            

            //static UI.PantallaEspera pantalla=null;
            //static Thread t = new Thread(new ThreadStart(Mostrar)); 
            //public void PantallaEspera(bool mostrar) 
            //{
            //    if (mostrar)
            //    {
            //        pantalla = new PantallaEspera();
            //        if (this.ActiveMdiChild != null)
            //            pantalla.Location = this.ActiveMdiChild.Location;

            //        t.Start();
            //    }
            //    else
            //        t.Abort();
                
            //}

            //static void Mostrar() 
            //{               
            //    pantalla.Show();
            //    while (t.IsAlive)
            //    {
            //        Application.DoEvents();
            //    }
            //}
          



        #endregion

        #region TODOS LOS MENÚS


            #region EXPLOTACIONES /
                FindExplotaciones FExplotaciones = null;
                FindContacto FContactos = null;
                FindTarea FTareas = null;
                FindCita FCitas = null;
                EditExplotaciones DatosExplotacion = null;

                private void MExplotaciones_Click(object sender, EventArgs e)
                {
                    if (FExplotaciones == null || !FExplotaciones.Visible)
                        FExplotaciones = new FindExplotaciones();
                    MostrarFormulario(FExplotaciones);
                }

                private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FContactos == null || !FContactos.Visible)
                        FContactos = new FindContacto();
                    MostrarFormulario(FContactos);
                }

                private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FTareas == null || !FTareas.Visible)
                        FTareas = new FindTarea();
                    MostrarFormulario(FTareas);

                }

                private void ditasToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FCitas == null || !FCitas.Visible)
                        FCitas = new FindCita();
                    MostrarFormulario(FCitas);
                }


                private void proximaTareaToolStripMenuItem_Click_1(object sender, EventArgs e)
                {
                    List<Tarea> lstTareas = Tarea.Buscar(Configuracion.Explotacion.Id, string.Empty, DateTime.Today, null);
                    Tarea ProximaTarea = null;
                    if (lstTareas != null && lstTareas.Count > 0)
                        ProximaTarea = lstTareas.OrderBy(E => E.Fecha).First();

                    if (ProximaTarea != null)
                    {

                        Mostrar_Mensaje("TAREA: " + ProximaTarea.Fecha.ToString() +
                                        "\r" + ProximaTarea.Descripcion, 1);

                    }

                }

                private void proximaCitaToolStripMenuItem_Click_1(object sender, EventArgs e)
                {
                    List<Cita> lstCitas = Cita.Buscar(Configuracion.Explotacion.Id, null, DateTime.Today, null, string.Empty, string.Empty);
                    Cita ProximaCita = null;
                    if (lstCitas != null && lstCitas.Count > 0)
                        ProximaCita = lstCitas.OrderBy(E => E.Fecha).First();

                    if (ProximaCita != null)
                    {

                        Mostrar_Mensaje("CITA: " + ProximaCita.Fecha.ToString() +
                                        "\rContacto: " + ProximaCita.DescContacto +
                                        "\rLugar: " + ProximaCita.Lugar +
                                        "\rTema: " + ProximaCita.Tema,0);

                    }
                }

                private void MLibro_Click(object sender, EventArgs e)
                {
                    if (FAbolInformes == null || !FAbolInformes.Visible)
                        FAbolInformes = new ArbolInfomes("EXPLOTACIÓN\\LIBRO DE EXPLOTACIÓN GANADERA");
                    else
                        ((GenericInfArbol)FAbolInformes).SeleccionarNodo("EXPLOTACIÓN\\LIBRO DE EXPLOTACIÓN GANADERA");
                    MostrarFormulario(FAbolInformes);
                }


                private void MDatosExplotacion_Click(object sender, EventArgs e)
                {
                    
                    if (DatosExplotacion == null || !DatosExplotacion.Visible)
                        DatosExplotacion = new EditExplotaciones(Modo.Actualizar, Configuracion.Explotacion);                    
                  
                    this.MostrarFormulario(DatosExplotacion);                    
                }

            #endregion

            #region TITULARES /
                FindTitulares FTitulares = null;

                private void MTitulares_Click(object sender, EventArgs e)
                {
                    if (FTitulares == null || !FTitulares.Visible)
                        FTitulares = new FindTitulares();
                    MostrarFormulario(FTitulares);

                }
            #endregion

            #region REPRODUCCIÓN / 
                FindInseminacion FInseminacion = null;
                FindPartos FPartos = null;
                FindAborto FAbortos = null;
                FindCelo FCelos = null;
                FindSincronizacionCelo FSincCelos = null;
                FindCubricion FCubricion = null;
                FindDiagInseminacion FDiagGestacion = null;

                EditPartosMultiples FPartosMultiples = null;

                private void MDiagGestacion_Click(object sender, EventArgs e)
                {
                    if (FDiagGestacion == null || !FDiagGestacion.Visible)
                        FDiagGestacion = new FindDiagInseminacion();
                    MostrarFormulario(FDiagGestacion);
                }

                private void MInseminaciones_Click(object sender, EventArgs e)
                {
                    if (FInseminacion == null || !FInseminacion.Visible)
                        FInseminacion = new FindInseminacion();
                    MostrarFormulario(FInseminacion);

                }
                private void MPartos_Click(object sender, EventArgs e)
                {
                    if (FPartos == null || !FPartos.Visible)
                        FPartos = new FindPartos();
                    MostrarFormulario(FPartos);
                }

                private void sincronizaciónCelosToolStripMenuItem_Click_1(object sender, EventArgs e)
                {
                    if (FSincCelos == null || !FSincCelos.Visible)
                        FSincCelos = new FindSincronizacionCelo();
                    MostrarFormulario(FSincCelos); 
                }

                private void celosToolStripMenuItem_Click_1(object sender, EventArgs e)
                {
                    if (FCelos == null || !FCelos.Visible)
                        FCelos = new FindCelo();
                    MostrarFormulario(FCelos); 
                }

                private void MAbortos_Click(object sender, EventArgs e)
                {
                    if (FAbortos == null || !FAbortos.Visible)
                        FAbortos = new FindAborto();
                    MostrarFormulario(FAbortos);
                }


                private void cubricionesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FCubricion == null || !FCubricion.Visible)
                        FCubricion = new FindCubricion();
                    MostrarFormulario(FCubricion);
                }

                private void MPartosMultiples_Click(object sender, EventArgs e)
                {
                    if (FPartosMultiples == null || !FPartosMultiples.Visible)
                        FPartosMultiples = new EditPartosMultiples();
                    MostrarFormulario(FPartosMultiples);
                }

            #endregion

            #region ANIMALES /
                FindAnimales FAnimales = null;
                FindLoteAnimal FLotesAnimales = null;
                FindPesos FPesos = null;
                EditDestete FDestete = null;               
                FindCondicionCorporal FCondicionCorporal = null;
                private void animalesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FAnimales == null || !FAnimales.Visible)
                        FAnimales = new FindAnimales();
                    MostrarFormulario(FAnimales); 
                    
                }

                private void lotesAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FLotesAnimales == null || !FLotesAnimales.Visible)
                        FLotesAnimales = new FindLoteAnimal();
                    MostrarFormulario(FLotesAnimales); 


                }

                private void pesosToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FPesos == null || !FPesos.Visible)
                        FPesos = new FindPesos();
                    MostrarFormulario(FPesos); 
                }

             
                private void condicionesCorporalesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FCondicionCorporal == null || !FCondicionCorporal.Visible)
                        FCondicionCorporal = new FindCondicionCorporal();
                    MostrarFormulario(FCondicionCorporal); 

                }

                private void MDesteteMultiple_Click(object sender, EventArgs e)
                {
                    if (FDestete == null || !FDestete.Visible)
                        FDestete = new EditDestete(Modo.GuardarMultiple) ;
                    MostrarFormulario(FDestete); 
                }
              



            #endregion

            #region GESTION FINANCIERA /
                FindCompra FCompra = null;
                FindVenta FVenta = null;
                FindGasto FGasto = null;
                private void MVentas_Click(object sender, EventArgs e)
                {
                    if (FVenta == null || !FVenta.Visible)
                        FVenta = new FindVenta();
                    MostrarFormulario(FVenta);
                }
                private void MCompras_Click(object sender, EventArgs e)
                {
                    if (FCompra == null || !FCompra.Visible)
                        FCompra = new FindCompra();
                    MostrarFormulario(FCompra);
                }
                private void MGastos_Click(object sender, EventArgs e)
                {
                    if (FGasto == null || !FGasto.Visible)
                        FGasto = new FindGasto();
                    MostrarFormulario(FGasto);
                }
            #endregion

            #region GESTIÓN DE PARCELAS /
                FindAbonado FAbonado = null;
                FindParcela FParcela = null;
                FindRecolecta FRecolecta = null;
                FindSiembra FSiembra = null;
                FindTratParcela FTratParcela = null;

                private void MAbono_Click(object sender, EventArgs e)
                {
                    if (FAbonado == null || !FAbonado.Visible)
                        FAbonado = new FindAbonado();
                    MostrarFormulario(FAbonado);
                }
                private void MFincas_Click(object sender, EventArgs e)
                {
                    if (FParcela == null || !FParcela.Visible)
                        FParcela = new FindParcela();
                    MostrarFormulario(FParcela);
                }
                private void MRecolecta_Click(object sender, EventArgs e)
                {
                    if (FRecolecta == null || !FRecolecta.Visible)
                        FRecolecta = new FindRecolecta();
                    MostrarFormulario(FRecolecta);
                }
                private void MSiembra_Click(object sender, EventArgs e)
                {
                    if (FSiembra == null || !FSiembra.Visible)
                        FSiembra = new FindSiembra();
                    MostrarFormulario(FSiembra);
                }

                private void MTratamiento_Click(object sender, EventArgs e)
                {
                    if (FTratParcela == null || !FTratParcela.Visible)
                        FTratParcela = new FindTratParcela();
                    MostrarFormulario(FTratParcela);
                }

            #endregion

            #region GESTIÓN ALIMENTICIA
                EditAsignacion FAsignacion = null;
                FindPastoreo FPastoreo = null;
                private void MAsignaciones_Click(object sender, EventArgs e)
                {
                    if (FAsignacion == null || !FAsignacion.Visible)
                        FAsignacion = new EditAsignacion();
                    MostrarFormulario(FAsignacion);


                }
                private void btnAsignaciones_Click(object sender, EventArgs e)
                {
                    if (FAsignacion == null || !FAsignacion.Visible)
                        FAsignacion = new EditAsignacion();
                    MostrarFormulario(FAsignacion);
                }
               
                private void MPastoreo_Click(object sender, EventArgs e)
                {
                    if (FPastoreo == null || !FPastoreo.Visible)
                        FPastoreo = new FindPastoreo();
                    MostrarFormulario(FPastoreo);
                }



            #endregion           

            #region CONTROL EXPLOTACIÓN
            
                FindSecados FSecados = null;
                EditMuestraControl FMuestraControl = null;
                EditMuestras FMuestras = null;

                private void MControles_Click(object sender, EventArgs e)
                {
                    if (FMuestraControl == null || !FMuestraControl.Visible)
                        FMuestraControl = new EditMuestraControl();
                    MostrarFormulario(FMuestraControl);
                }

                private void MAnalisis_Click(object sender, EventArgs e)
                {
                    if (FMuestras == null || !FMuestras.Visible)                                    
                        FMuestras = new EditMuestras();                
                    MostrarFormulario(FMuestras);
                }

            

                private void MSecados_Click(object sender, EventArgs e)
                {
                    if (FSecados == null || !FSecados.Visible)
                        FSecados = new FindSecados();
                    MostrarFormulario(FSecados);

                }
                private void btnControles_Click(object sender, EventArgs e)
                {
                    if (FMuestraControl == null || !FMuestraControl.Visible)
                        FMuestraControl = new EditMuestraControl();
                    MostrarFormulario(FMuestraControl);
                }

                #region CONTROL VETERINARIO
                FindDiagAnimal FDiagAnimal = null;
                FindTratEnfermedad FTratEnfermedad = null;
                FindHistMedicamento FHistMedicamento = null;

                private void MDiagnosticos_Click(object sender, EventArgs e)
                {
                    if (FDiagAnimal == null || !FDiagAnimal.Visible)
                        FDiagAnimal = new FindDiagAnimal();
                    MostrarFormulario(FDiagAnimal);
                }


                private void MTratamientos_Click(object sender, EventArgs e)
                {
                    if (FTratEnfermedad == null || !FTratEnfermedad.Visible)
                        FTratEnfermedad = new FindTratEnfermedad();
                    MostrarFormulario(FTratEnfermedad);

                }
                private void MHistoricoMedicamentos_Click(object sender, EventArgs e)
                {
                    if (FHistMedicamento == null || !FHistMedicamento.Visible)
                        FHistMedicamento = new FindHistMedicamento();
                    MostrarFormulario(FHistMedicamento);

                }


                #endregion

                #region PRODUCCIÓN DE CARNE


                FindTipificacionCanal FTipificacionCanal = null;
            
                FindRendimientoCanal FRendimientoCanal = null;
                FindEngrasamientoCanal FEngrasamientoCanal = null;              


                private void MEngrasamientoCanal_Click(object sender, EventArgs e)
                {
                    if (FEngrasamientoCanal == null || !FEngrasamientoCanal.Visible)
                        FEngrasamientoCanal = new FindEngrasamientoCanal();
                    MostrarFormulario(FEngrasamientoCanal);
                }

                

                private void MTipificacionCanal_Click(object sender, EventArgs e)
                {
                    if (FTipificacionCanal == null || !FTipificacionCanal.Visible)
                        FTipificacionCanal = new FindTipificacionCanal();
                    MostrarFormulario(FTipificacionCanal);
                }

                private void MRendimientoCanal_Click(object sender, EventArgs e)
                {
                    if (FRendimientoCanal == null || !FRendimientoCanal.Visible)
                        FRendimientoCanal = new FindRendimientoCanal();
                    MostrarFormulario(FRendimientoCanal);
                }

                #endregion


            #endregion

                
            #region MANTENIMIENTOS / BANCARIOS
                FindCuenta FCuentas = null;    
                private void MCuentas_Click(object sender, EventArgs e)
                {
                    if (FCuentas == null || !FCuentas.Visible)
                        FCuentas = new FindCuenta();
                    MostrarFormulario(FCuentas);
                }
            #endregion

            #region MANTENIMIENTOS / CONTROL ALIMENTARIO
                FindProducto FAlimento = null;
                FindFamilia FFamiliaAlimento = null;
                FindRacion FRaciones = null;    

                private void MAlimentos_Click(object sender, EventArgs e)
                 {
                    if (FAlimento == null || !FAlimento.Visible)
                        FAlimento = new FindProducto() { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.ALIMENTACION) };
                    MostrarFormulario(FAlimento);
                 }
                private void MFamiliasAlimentos_Click(object sender, EventArgs e)
                 {
                     if (FFamiliaAlimento == null || !FFamiliaAlimento.Visible)
                         FFamiliaAlimento = new FindFamilia() { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.ALIMENTACION) };
                     MostrarFormulario(FFamiliaAlimento);

                 }
                private void MRaciones_Click(object sender, EventArgs e)
                 {
                     if (FRaciones == null || !FRaciones.Visible)
                         FRaciones = new FindRacion();
                     MostrarFormulario(FRaciones);
                 }
             #endregion

            #region MANTENIMIENTOS / GENÉTICA
                FindMarcador FMarcador = null;        
                FindCombinacion FCombinacion = null;

                private void MTipoAnalisis_Click(object sender, EventArgs e)
                {
                   
                    //Genero un grupo de formularios Find-Edit completamente dinámicos (Estados).
                    TipoAnalisis ObjetoBase = new TipoAnalisis();
                    GenericFindDinamico frmLanzar = new GenericFindDinamico() { ClaseBase = ObjetoBase };
                    frmLanzar.Titulo = "Tipos Análisis Genéticos";                    
                    frmLanzar.NumColumnas = 2;
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));
                    MostrarFormulario(frmLanzar);

                }
                private void MMarcador_Click(object sender, EventArgs e)
                {
                    if (FMarcador == null || !FMarcador.Visible)
                        FMarcador = new FindMarcador();
                    MostrarFormulario(FMarcador);

                }              
                private void MCombinacion_Click(object sender, EventArgs e)
                {
                    if (FCombinacion == null || !FCombinacion.Visible)
                        FCombinacion = new FindCombinacion();
                    MostrarFormulario(FCombinacion);
                }
            #endregion

            #region MANTENIMIENTOS / CONTROL VETERINARIO
                FindProducto FMedicamento = null;
                FindTipoEnfermedad FTipoEnfermedad = null;
                FindEnfermedad FEnfermedad = null;
                FindPersonal FVeterinarios = null;
                FindTipoPersonal FTipoPersonal = null;
             

                private void MEnfermedades_Click(object sender, EventArgs e)
                 {
                     if (FEnfermedad == null || !FEnfermedad.Visible)
                         FEnfermedad = new FindEnfermedad();
                     MostrarFormulario(FEnfermedad);
                 }
                private void MMedicamentos_Click(object sender, EventArgs e)
                 {
                     if (FMedicamento == null || !FMedicamento.Visible)
                         FMedicamento = new FindProducto() { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.SANIDAD) };
                     MostrarFormulario(FMedicamento);

                 }
                private void MTiposEnfermedades_Click(object sender, EventArgs e)
                 {
                     if (FTipoEnfermedad == null || !FTipoEnfermedad.Visible)
                         FTipoEnfermedad = new FindTipoEnfermedad();
                     MostrarFormulario(FTipoEnfermedad);
                 }
              


           
             #endregion
                 
            #region MANTENIMIENTOS / GESTIÓN DE FINCAS
                FindProducto FProductoSemilla = null;
                FindProducto FTipoAbono = null;
                FindFamilia FFamiliaSemilla = null;           
                FindProducto FProdTratParcelas = null;
                FindPlaga FPlaga = null;

                private void MSemillas_Click_1(object sender, EventArgs e)
                {
                    if (FProductoSemilla == null || !FProductoSemilla.Visible)
                        FProductoSemilla = new FindProducto() { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA),
                                                                ValorFijoIdFamilia=Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.SEMILLA).Id};
                    MostrarFormulario(FProductoSemilla);
                }
                private void MAbonos_Click(object sender, EventArgs e)
                {
                    if (FTipoAbono == null || !FTipoAbono.Visible)
                        FTipoAbono = new FindProducto(){ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA),
                                                        ValorFijoIdFamilia = Configuracion.FamiliaSistema(Configuracion.FamiliasSistema.ABONO).Id};
                    MostrarFormulario(FTipoAbono);
                }
                private void MFamiliaSemilla_Click(object sender, EventArgs e)
                {
                    if (FFamiliaSemilla == null || !FFamiliaSemilla.Visible)
                        FFamiliaSemilla = new FindFamilia() { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA) };
                    MostrarFormulario(FFamiliaSemilla);
                }
                //private void MForraje_Click(object sender, EventArgs e)
                //{
                //    if (FForraje == null || !FForraje.Visible)
                //        FForraje = new FindProducto() { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.FORRAJE) };
                //    MostrarFormulario(FForraje);
                //}
                private void MEnfermedad_Click(object sender, EventArgs e)
                {
                    if (FPlaga == null || !FPlaga.Visible)
                        FPlaga = new FindPlaga();
                    MostrarFormulario(FPlaga);
                }
                private void MProductoTratParcelas_Click(object sender, EventArgs e)
                {
                    if (FProdTratParcelas == null || !FProdTratParcelas.Visible)
                        FProdTratParcelas = new FindProducto() { ValorFijoTipoProducto = Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.TRATAMIENTO_PARCELA) };
                    MostrarFormulario(FProdTratParcelas);
                }
               

              
            #endregion

            #region MANTENIMIENTOS / GESTIÓN FINANCIERA
                FindCliente FCliente = null;
                FindProveedor FProveedor = null;
                //FindTipoVenta FTipoVenta = null;
                //FindTipoCompra FTipoCompra = null;
                FindNaturaleza FNaturaleza = null;

                private void MClientes_Click(object sender, EventArgs e)
                {
                    if (FCliente == null || !FCliente.Visible)
                        FCliente = new FindCliente();
                    MostrarFormulario(FCliente);
                }
                private void MProveedores_Click(object sender, EventArgs e)
                {
                    if (FProveedor == null || !FProveedor.Visible)
                        FProveedor = new FindProveedor();
                    MostrarFormulario(FProveedor);
                }
                //private void MTiposVentas_Click(object sender, EventArgs e)
                //{
                //    if (FTipoVenta == null || !FTipoVenta.Visible)
                //        FTipoVenta = new FindTipoVenta();
                //    MostrarFormulario(FTipoVenta);
                //}
                //private void MTiposCompras_Click(object sender, EventArgs e)
                //{
                //    if (FTipoCompra == null || !FTipoCompra.Visible)
                //        FTipoCompra = new FindTipoCompra();
                //    MostrarFormulario(FTipoCompra);
                //}
                private void MNaturalezaGasto_Click(object sender, EventArgs e)
                {
                    if (FNaturaleza == null || !FNaturaleza.Visible)
                        FNaturaleza = new FindNaturaleza();
                    MostrarFormulario(FNaturaleza);
                }
            #endregion

            #region MANTENIMIENTOS / LOCALIZACIONES
                FindProvincia FProvincia = null;
                FindMunicipios FMunicipio = null;

                private void MProvincias_Click(object sender, EventArgs e)
                {
                    if (FProvincia == null || !FProvincia.Visible)
                        FProvincia = new FindProvincia();
                    MostrarFormulario(FProvincia);

                }
                private void MMunicipios_Click(object sender, EventArgs e)
                {
                    if (FMunicipio == null || !FMunicipio.Visible)
                        FMunicipio = new FindMunicipios();

                    MostrarFormulario(FMunicipio);
                }
            #endregion

            #region MANTENIMIENTOS / PARTOS

                FindTipoParto FTipoParto = null;
                FindFacilidad FFacilidad = null;
                FindTalla FTalla = null;
                FindConformacion FConformacion = null;

                private void MTParto_Click(object sender, EventArgs e)
                {
                    if (FTipoParto == null || !FTipoParto.Visible)
                        FTipoParto = new FindTipoParto();
                    MostrarFormulario(FTipoParto);

                }
                private void MDificultad_Click(object sender, EventArgs e)
                {
                    if (FFacilidad == null || !FFacilidad.Visible)
                        FFacilidad = new FindFacilidad();
                    MostrarFormulario(FFacilidad);
                }
                private void MTamanosCria_Click(object sender, EventArgs e)
                {
                    if (FTalla == null || !FTalla.Visible)
                        FTalla = new FindTalla();
                    MostrarFormulario(FTalla);
                }
                private void MConformacionCria_Click(object sender, EventArgs e)
                {
                    if (FConformacion == null || !FConformacion.Visible)
                        FConformacion = new FindConformacion();
                    MostrarFormulario(FConformacion);
                }        



            #endregion

            #region MANTENIMIENTOS / PRODUCCION CARNE

                FindMomentoPeso FMomentoPeso = null;
                FindTipoCondicion FTipoCondicion = null;
                FindCategoria FCategoria = null;
                FindTipoEngrasamiento FTipoEngrasamiento = null;
                FindConformacionCanal FConformacionCanal = null;
                
        

                private void MMomentoPeso_Click(object sender, EventArgs e)
                {
                    if (FMomentoPeso == null || !FMomentoPeso.Visible)
                        FMomentoPeso = new FindMomentoPeso();
                    MostrarFormulario(FMomentoPeso);
                }

                
                private void MTiposDeCondiciones_Click(object sender, EventArgs e)
                {
                    if (FTipoCondicion == null || !FTipoCondicion.Visible)
                        FTipoCondicion = new FindTipoCondicion();
                    MostrarFormulario(FTipoCondicion);

                }
                private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FCategoria == null || !FCategoria.Visible)
                        FCategoria = new FindCategoria();
                    MostrarFormulario(FCategoria);
                }
                private void tipoEngrasamientoToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FTipoEngrasamiento == null || !FTipoEngrasamiento.Visible)
                        FTipoEngrasamiento = new FindTipoEngrasamiento();
                    MostrarFormulario(FTipoEngrasamiento);
                }

        
                private void MConformacionCanal_Click(object sender, EventArgs e)
                {
                    if (FConformacionCanal == null || !FConformacionCanal.Visible)
                        FConformacionCanal = new FindConformacionCanal();
                    MostrarFormulario(FConformacionCanal);
                }



            #endregion

            #region MANTENIMIENTOS / SANITARIO

                //FindPrograma FPrograma = null;
                //FindTratHigiene FTratHigiene = null;
                //private void programaToolStripMenuItem_Click(object sender, EventArgs e)
                //{
                //    if (FPrograma == null || !FPrograma.Visible)
                //        FPrograma = new FindPrograma();
                //    MostrarFormulario(FPrograma);
                //}

                //private void tratamientosHigieneToolStripMenuItem_Click(object sender, EventArgs e)
                //{
                //    if (FTratHigiene == null || !FTratHigiene.Visible)
                //        FTratHigiene = new FindTratHigiene();
                //    MostrarFormulario(FTratHigiene);
                //}

                FindPlanHigiene FPlanHigiene = null;
              
                FindPrograma FProgramaProfilaxis = null;
                
                

                private void MPlanHigiene_Click(object sender, EventArgs e)
                {
                    if (FPlanHigiene == null || !FPlanHigiene.Visible)
                        FPlanHigiene = new FindPlanHigiene();
                    MostrarFormulario(FPlanHigiene);
                }

               

                private void MProgramasProfilaxis_Click(object sender, EventArgs e)
                {
                    if (FProgramaProfilaxis == null || !FProgramaProfilaxis.Visible)
                        FProgramaProfilaxis = new FindPrograma();
                    MostrarFormulario(FProgramaProfilaxis);
                }

             


            #endregion

            #region MANTENIMIENTOS / TRAZABILIDAD

                FindMaquinaria FMaquinaria = null;
                FindZona Zona = null;

                private void Maquinaria_Click(object sender, EventArgs e)
                {
                    if (FMaquinaria == null || !FMaquinaria.Visible)
                        FMaquinaria = new FindMaquinaria();

                    MostrarFormulario(FMaquinaria);
                }

                private void Zonas_Click(object sender, EventArgs e)
                {
                    if (Zona == null || !Zona.Visible)
                        Zona = new FindZona();

                    MostrarFormulario(Zona);
                }

            #endregion

            #region MANTENIMIENTOS / PERSONAL
                private void MPersonal_Click(object sender, EventArgs e)
                {
                    if (FVeterinarios == null || !FVeterinarios.Visible)
                        FVeterinarios = new FindPersonal();
                    MostrarFormulario(FVeterinarios);
                }
                private void MTipoPersonal_Click(object sender, EventArgs e)
                {
                    if (FTipoPersonal == null || !FTipoPersonal.Visible)
                        FTipoPersonal = new FindTipoPersonal();
                    MostrarFormulario(FTipoPersonal);
                }

            #endregion
                
            #region MANTENIMIENTOS / PRODUCCIÓN DE LECHE
                FindStatusControl FStatusControl = null;
                FindStatusOrdeno FStatusOrdeno = null;
                private void MEstadoControl_Click(object sender, EventArgs e)
                {
                    if (FStatusControl == null || !FStatusControl.Visible)
                        FStatusControl = new FindStatusControl();
                    MostrarFormulario(FStatusControl);
                }

                private void MEstadoOrdeno_Click(object sender, EventArgs e)
                {
                    if (FStatusOrdeno == null || !FStatusOrdeno.Visible)
                        FStatusOrdeno = new FindStatusOrdeno();
                    MostrarFormulario(FStatusOrdeno);
                }

            #endregion

            #region MANTENIMIENTOS /

                //FindCondicionJuridica FCondicionJuridica = null;
                FindLaboratorios FLaboratorios = null;
                FindRazas FRazas = null;
                FindTipoAlta FTipoAlta = null;
                FindTipoBaja FTipoBaja = null;
                FindTipoDiagnostico FTipoDiagnostico = null;      
                FindTipoSecado FTipoSecado = null;
                FindTipoInseminacion FTipoInseminacion = null;
                FindTipoaborto FTipoAborto = null;
                FindTipoCubricion FTipoCubricion = null;
               
                FindTipoContacto FTipoContacto = null;
              

                

                private void MCondicionesJuridicas_Click(object sender, EventArgs e)
                {
                //    if (FCondicionJuridica == null || !FCondicionJuridica.Visible)
                //        FCondicionJuridica = new FindCondicionJuridica();
                //    MostrarFormulario(FCondicionJuridica);

                       //Genero un grupo de formularios Find-Edit completamente dinámicos (Estados).
                    CondicionJuridica ObjetoBase = new CondicionJuridica();         
                    GenericFindDinamico frmLanzar = new GenericFindDinamico() { ClaseBase = ObjetoBase };
                    frmLanzar.Titulo = "Condiciones Jurídicas";
                    frmLanzar.NumColumnas = 2;
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));
                    MostrarFormulario(frmLanzar);

                }
                private void MLaboratorios_Click(object sender, EventArgs e)
                {
                    if (FLaboratorios == null || !FLaboratorios.Visible)
                        FLaboratorios = new FindLaboratorios();
                    MostrarFormulario(FLaboratorios);
                }
                private void MRazas_Click(object sender, EventArgs e)
                {
                    if (FRazas == null || !FRazas.Visible)
                        FRazas = new FindRazas();
                    MostrarFormulario(FRazas);

                }
                private void MTiposAltas_Click(object sender, EventArgs e)
                {
                    if (FTipoAlta == null || !FTipoAlta.Visible)
                        FTipoAlta = new FindTipoAlta();
                    MostrarFormulario(FTipoAlta);

                }
                private void MTiposBajas_Click(object sender, EventArgs e)
                {
                    if (FTipoBaja == null || !FTipoBaja.Visible)
                        FTipoBaja = new FindTipoBaja();
                    MostrarFormulario(FTipoBaja);
                }
                private void MTiposDiagnostico_Click(object sender, EventArgs e)
                {
                    if (FTipoDiagnostico == null || !FTipoDiagnostico.Visible)
                        FTipoDiagnostico = new FindTipoDiagnostico();
                    MostrarFormulario(FTipoDiagnostico);
                }
                private void MTiposInseminacion_Click(object sender, EventArgs e)
                {
                    if (FTipoInseminacion == null || !FTipoInseminacion.Visible)
                        FTipoInseminacion = new FindTipoInseminacion();
                    MostrarFormulario(FTipoInseminacion);
                }
                private void MTiposAbortos_Click(object sender, EventArgs e)
                {
                    if (FTipoAborto == null || !FTipoAborto.Visible)
                        FTipoAborto = new FindTipoaborto();
                    MostrarFormulario(FTipoAborto);
                }
                private void MTiposCubricion_Click(object sender, EventArgs e)
                {
                    if (FTipoCubricion == null || !FTipoCubricion.Visible)
                        FTipoCubricion = new FindTipoCubricion();
                    MostrarFormulario(FTipoCubricion);
                }

                private void MTiposSecado_Click(object sender, EventArgs e)
                {
                    if (FTipoSecado == null || !FTipoSecado.Visible)
                        FTipoSecado = new FindTipoSecado();
                    MostrarFormulario(FTipoSecado);
                }

            



            

                private void tiposDeContactosToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    if (FTipoContacto == null || !FTipoContacto.Visible)
                        FTipoContacto = new FindTipoContacto();
                    MostrarFormulario(FTipoContacto);
                }


                
                private void MEstadosAnimal_Click(object sender, EventArgs e)
                {   
                    //Genero un grupo de formularios Find-Edit completamente dinámicos (Estados).
                    Estado ObjetoBase = new Estado();                 
                    GenericFindDinamico frmLanzar = new GenericFindDinamico() { ClaseBase = ObjetoBase };
                    frmLanzar.Titulo = "Estado Animal";
                    frmLanzar.NumColumnas = 2;
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));
                    MostrarFormulario(frmLanzar);
                }

                private void MTiposLotes_Click(object sender, EventArgs e)
                {
                    //Genero un grupo de formularios Find-Edit completamente dinámicos (Tipos de lotes).
                    TipoLote ObjetoBase = new TipoLote();

                    GenericFindDinamico frmLanzar = new GenericFindDinamico() { ClaseBase = ObjetoBase };
                    frmLanzar.Titulo = "Tipos de Lotes";
                    frmLanzar.NumColumnas = 2;
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripción"));
                    MostrarFormulario(frmLanzar);
                }  

            #endregion

            #region PRODUCTOS /

                FindTipoProducto FTipoProducto = null;
                ExploradorProductos FExploradorProdutos = null;
                FindFamilia FFamiliaProducto = null;


                private void CargarMenusProductos()
                {
                    try
                    {

                        lstProductos = null;
                        MProductos.DropDownItems.Clear();

                        lstProductos = TipoProducto.Buscar();
                        foreach (TipoProducto Tipo in lstProductos)
                        {
                            string nombre = Cadenas.ToUpperPrimerCaracter(Tipo.Descripcion);
                            ToolStripMenuItem tsb = new ToolStripMenuItem(nombre) { Name = "MP" + nombre };
                            this.MProductos.DropDownItems.Add(tsb);
                            tsb.Click += LanzarMenusProductos;

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se ha producido un error en la carga del menú de productos personalizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                List<TipoProducto> lstProductos = null;//Lista que contendra los objetos del tipo "TipoProducto" que se utilizan en en procedimiento LanzarMenuProductos        
                private void LanzarMenusProductos(object sender, EventArgs e)
                {
                    string menuseleccionado = ((ToolStripMenuItem)sender).Text.ToLower();

                    TipoProducto tipoproducto = lstProductos.Find(E => E.Descripcion.ToLower() == menuseleccionado);
                    if (tipoproducto != null)
                    {
                        FindProducto frmProducto = new FindProducto() { ValorFijoTipoProducto = tipoproducto };

                        MostrarFormulario(frmProducto);
                    }

                }


                private void CargarMenusFamiliasProductos()
                {

                    try
                    {

                        lstFamiliasProductos = null;
                        MFamiliasProductos.DropDownItems.Clear();

                        lstFamiliasProductos = TipoProducto.Buscar(string.Empty, true, null);
                        foreach (TipoProducto Tipo in lstFamiliasProductos)
                        {
                            string nombre = Cadenas.ToUpperPrimerCaracter(Tipo.Descripcion);
                            ToolStripMenuItem tsb = new ToolStripMenuItem(nombre) { Name = "MF" + nombre };
                            this.MFamiliasProductos.DropDownItems.Add(tsb);
                            tsb.Click += LanzarMenusFamiliasProductos;

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se ha producido un error en la carga del menú de Familias Productos personalizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                List<TipoProducto> lstFamiliasProductos = null;//Lista que contendra los objetos del tipo "TipoProducto" que se utilizan en en procedimiento LanzarMenuFamiliasProductos        
                private void LanzarMenusFamiliasProductos(object sender, EventArgs e)
                {
                    string menuseleccionado = ((ToolStripMenuItem)sender).Text.ToLower();

                    TipoProducto tipoproducto = lstFamiliasProductos.Find(E => E.Descripcion.ToLower() == menuseleccionado);
                    if (tipoproducto != null)
                    {
                        FindFamilia frmProducto = new FindFamilia() { ValorFijoTipoProducto = tipoproducto };

                        MostrarFormulario(frmProducto);
                    }


                }
                private void exploradorProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
                {

                    if (FExploradorProdutos == null || !FExploradorProdutos.Visible)
                        FExploradorProdutos = new ExploradorProductos();
                    MostrarFormulario(FExploradorProdutos);

                }

             
                private void tsmFamiliasProductos_Click(object sender, EventArgs e)
                {
                    if (FFamiliaProducto == null || !FFamiliaProducto.Visible)
                        FFamiliaProducto = new FindFamilia();
                    MostrarFormulario(FFamiliaProducto);
                }

                private void tiposProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
                {
                    if (FTipoProducto == null || !FTipoProducto.Visible)
                        FTipoProducto = new FindTipoProducto();
                    MostrarFormulario(FTipoProducto);
                }

             
            #endregion

            #region GENETICA /

                FindAnalisis FAnalisisGenetico = null;
                FindResena FResena = null;
                private void MAnalisisGenetico_Click(object sender, EventArgs e)
                {
                    if (FAnalisisGenetico == null || !FAnalisisGenetico.Visible)
                        FAnalisisGenetico = new FindAnalisis();
                    MostrarFormulario(FAnalisisGenetico);

                }                
                private void MResena_Click(object sender, EventArgs e)
                {
                    if (FResena == null || !FResena.Visible)
                        FResena = new FindResena();
                    MostrarFormulario(FResena);
                }

                #endregion

            #region SANIDAD /
                FindTratHigiene FTratHigiene = null;
                FindTratProfilaxis FTratProfilaxis = null;
                private void MTratamientosHigiene_Click(object sender, EventArgs e)
                {
                    if (FTratHigiene == null || !FTratHigiene.Visible)
                        FTratHigiene = new FindTratHigiene();
                    MostrarFormulario(FTratHigiene);
                }
                private void MTratamientosProfilaxis_Click(object sender, EventArgs e)
                {
                    if (FTratProfilaxis == null || !FTratProfilaxis.Visible)
                        FTratProfilaxis = new FindTratProfilaxis();
                    MostrarFormulario(FTratProfilaxis);
                }
            #endregion

            #region TRAZABILIDAD

                FindPlantilla Proceso = null;

                private void TProcesos_Click(object sender, EventArgs e)
                {
                    if (Proceso == null || !Proceso.Visible)
                        Proceso = new FindPlantilla();

                    MostrarFormulario(Proceso);
                }

            #endregion

            #region APPCC
                FindAPPCC FAPPCC = null;
                private void MAPPCC_Click(object sender, EventArgs e)
                {
                    if (FAPPCC == null || !FAPPCC.Visible)
                        FAPPCC = new FindAPPCC();
                    MostrarFormulario(FAPPCC);
                }


            #endregion

            #region INFORMES /
                /// <summary>
                /// fgh: 26-06-2008
                /// Se ha mejorado la carga de informes haciéndola dinámica, se lee la estructura de nodos de Arbol Informes
                /// y se pinta representada a modo de menús. Dichos menús son enlazados directamente al nodo del informe en cuentión
                /// al que representan, por tanto no hay que capturar eventos click, ni cargar menús manualmente
                /// La representacion en el MDI del menu informes solo debe contener 2 SubMenús (Arbol y separador), el resto será cosa de la 
                /// función CargarMenusInformes.
                /// </summary>
                
                
                ArbolInfomes FAbolInformes = null; 
                private void tsmInformesArbol_Click(object sender, EventArgs e)
                {
                    if (FAbolInformes == null || !FAbolInformes.Visible)
                        FAbolInformes = new ArbolInfomes();
                    MostrarFormulario(FAbolInformes);
                }

                /// <summary>
                /// Se ejecuta al crear el mdi principal
                /// Crea la estructura del menú de informes de acuerdo con el formulario ArbolInformes
                /// </summary>
                private void CargarMenusInformes()
                {
                    try
                    {

                        MSInformes.DropDownItems.Clear();
                        MSInformes.DropDownItems.Add(MINFArbol);
                        MSInformes.DropDownItems.Add(MSeparadorInformes);

                        ArbolInfomes arbol = new ArbolInfomes();
                        CargarRecursivaInformes(arbol.trvInformes.Nodes, MSInformes);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se ha producido un error en la carga del menú de productos personalizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                /// <summary>
                /// Funcion recursiva que crea una estructura de menus a partir de una coleccion de nodos.
                /// Se Utiliza por CargarMenusInformes y asigna los eventos click de boton al LanzadorInformes.
                /// Nota: solamente son asignados al manejador los menús que sean fin de árbol (el resto se considera una manera de 
                /// clasificación).
                /// </summary>
                /// <param name="colNodos"></param>
                /// <param name="Menu"></param>
                private void CargarRecursivaInformes(TreeNodeCollection colNodos, ToolStripMenuItem Menu)
                {
                    try
                    {
                        foreach (TreeNode nodo in colNodos)
                        {
                            ToolStripMenuItem tsb = new ToolStripMenuItem(nodo.Text) { Name = "MP" + nodo.Name, Tag = nodo.FullPath.ToUpper() };
                            Menu.DropDownItems.Add(tsb);


                            if (nodo.Nodes.Count > 0)//Llamada a la recursividad                            
                                CargarRecursivaInformes(nodo.Nodes, tsb);
                            else
                                tsb.Click += LanzadorInformes; //Si no tiene hijos es que es el último y es un informe no una carpeta contenedora.


                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se ha producido un error en la carga del menú de productos personalizados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }


                private void LanzadorInformes(object sender, EventArgs e)
                {
                    ToolStripMenuItem menu = (ToolStripMenuItem)sender;
                    if (FAbolInformes == null || !FAbolInformes.Visible)
                        FAbolInformes = new ArbolInfomes((string)menu.Tag);
                    else
                        ((GenericInfArbol)FAbolInformes).SeleccionarNodo((string)menu.Tag);

                    MostrarFormulario(FAbolInformes);
                }
            #endregion

            //#region INFORMES / ALIMENTACIÓN

            //    private void MConsumos_Click(object sender, EventArgs e)
            //    {
            //        if (FAbolInformes == null || !FAbolInformes.Visible)
            //            FAbolInformes = new ArbolInfomes("ALIMENTACIÓN\\CONSUMOS Y PRODUCCIÓN");
            //        else
            //            ((GenericInfArbol)FAbolInformes).SeleccionarNodo("ALIMENTACIÓN\\CONSUMOS Y PRODUCCIÓN");

            //        MostrarFormulario(FAbolInformes);        
            //    }
            //    private void MINFStockAlimentacion_Click(object sender, EventArgs e)
            //    {
            //        if (FAbolInformes == null || !FAbolInformes.Visible)
            //            FAbolInformes = new ArbolInfomes("ALIMENTACIÓN\\CONTROL DE STOCK DE ALIMENTACIÓN");
            //        else
            //            ((GenericInfArbol)FAbolInformes).SeleccionarNodo("ALIMENTACIÓN\\CONTROL DE STOCK DE ALIMENTACIÓN");

            //        MostrarFormulario(FAbolInformes);        
            //    }

            //#endregion

            //#region INFORMES / GESTIÓN DE FINCAS

            //    private void MAbonados_Click(object sender, EventArgs e)
            //    {
            //        if (FAbolInformes == null || !FAbolInformes.Visible)
            //            FAbolInformes = new ArbolInfomes("GESTIÓN DE FINCAS\\ABONADOS");
            //        else
            //            ((GenericInfArbol)FAbolInformes).SeleccionarNodo("GESTIÓN DE FINCAS\\ABONADOS");
            //        MostrarFormulario(FAbolInformes);
            //    }


            //#endregion

            #region HERRAMIENTAS / 

                #region ALERTAS
                    Alertas FAlertas = null;
                    private void tsmMostrarAlertas_Click(object sender, EventArgs e)
                    {
                        MostrarAlertas();
                    }
                    private void tsmRecargarAlertas_Click(object sender, EventArgs e)
                    {
                        RecargarAlertasAsync();
                    }

                #endregion

                EditConfiguracion FConfiguracion = null;
                FindModulo FModulo = null;
                EditPersonalizarMenus FMenu=null;
                EditPersonalizarProcesos FProcesos=null;
                EditRegularizacionStock FRegularizarStock = null;
                EditDatosSistema FDatosSistema = null;
               

                private void MOpciones_Click(object sender, EventArgs e)
                {
                    if (FConfiguracion == null || !FConfiguracion.Visible)
                        FConfiguracion = new EditConfiguracion();
                    MostrarFormulario(FConfiguracion);
                }

        
                private void MModulos_Click(object sender, EventArgs e)
                {

                    if (FModulo == null || !FModulo.Visible)
                        FModulo = new FindModulo();
                    MostrarFormulario(FModulo);
                }
                private void MProcesos_Click(object sender, EventArgs e)
                {                
                    if (FProcesos == null || !FProcesos.Visible)
                        FProcesos = new EditPersonalizarProcesos();
                    MostrarFormulario(FProcesos);
                }
                private void MMenus_Click(object sender, EventArgs e)
                {

                    if (FMenu == null || !FMenu.Visible)
                        FMenu = new EditPersonalizarMenus();
                    MostrarFormulario(FMenu);
                
                }

                private void MSincronizarContactos_Click(object sender, EventArgs e)
                {
                    try
                    {
                        GEXVOC.Core.Logic.SincronizarContactos.Sincronizar();
                        Generic.AvisoInformation("El proceso a concluído correctamente");

                    }
                    catch (Exception ex)
                    {
                        Generic.AvisoAdvertencia(ex.Message);                        
                    }
                    
                }

                private void MRegularizarStock_Click(object sender, EventArgs e)
                {
                    if (FRegularizarStock == null || !FRegularizarStock.Visible)
                        FRegularizarStock = new EditRegularizacionStock();
                    MostrarFormulario(FRegularizarStock);
                }

                private void MDatosSistema_Click(object sender, EventArgs e)
                {
                    if (FDatosSistema == null || !FDatosSistema.Visible)
                        FDatosSistema = new EditDatosSistema();
                    MostrarFormulario(FDatosSistema);
                }

                private void MBackups_Click(object sender, EventArgs e)
                {
                    if (Registro.GetSetting("TipoInstalacion", "servidor") == "servidor")
                    {
                        if (CerrarVentanas())
                        {
                            MakeBackup frmBackup = new MakeBackup();
                            frmBackup.ShowDialog(this);
                            frmBackup.Dispose();

                            //Recargo la conexión activa de datos 
                            BD.Recargar();
                        }
                    }
                    else
                    {
                        Generic.AvisoAdvertencia("No puede administrar las bases de datos desde un equipo cliente.\nEsta acción solo está disponible en el equipo 'servidor'");
                    }

                }

                private void MSHerramientas_DropDownOpening(object sender, EventArgs e)
                {
                    ///Solo permitimos que el menú mbackups se encuentre activo si nos encontramos en el servidor
                    ///Esto será independiente del subsistema o permisos que tengamos asignados.
                    MBackups.Enabled = (Registro.GetSetting("TipoInstalacion", "servidor") == "servidor");

                }

                ImportadorControles FImportador = null;
                private void MFicherosCLechero_Click(object sender, EventArgs e)
                {
                    if (FImportador == null || !FImportador.Visible)
                        FImportador = new ImportadorControles();
                    MostrarFormulario(FImportador);
                }
                ImportadorAnimales FImportadorAnimales = null;
                private void MImportacionDatos_Click(object sender, EventArgs e)
                {
                    if (FImportadorAnimales == null || !FImportadorAnimales.Visible)
                        FImportadorAnimales = new ImportadorAnimales();
                    MostrarFormulario(FImportadorAnimales);
                }
                ImportadorAnimalesOC FImportadorAnimalesOC = null;
                private void tsmImportarAnimalesOC_Click(object sender, EventArgs e)
                {
                    if (FImportadorAnimalesOC == null || !FImportadorAnimalesOC.Visible)
                        FImportadorAnimalesOC = new ImportadorAnimalesOC();
                    MostrarFormulario(FImportadorAnimalesOC);
                }

                ImportadorAnimalesWebPigan FImportadorAnimalesBWeb = null;
                private void tsmImportarAnimalesBWeb_Click(object sender, EventArgs e)
                {
                    if (FImportadorAnimalesBWeb == null || !FImportadorAnimalesBWeb.Visible)
                        FImportadorAnimalesBWeb = new ImportadorAnimalesWebPigan();
                    MostrarFormulario(FImportadorAnimalesBWeb);
                }


            #endregion

            #region VENTANA /
                private void MCascada_Click(object sender, EventArgs e)
                {
                    this.LayoutMdi(MdiLayout.Cascade);
                }

                private void MMinimizar_Click(object sender, EventArgs e)
                {

                    for (int i = 0; i < this.MdiChildren.Length; i++)
                        this.MdiChildren[i].WindowState = FormWindowState.Minimized;
                }

                /// <summary>
                /// Cierra todas las ventanas abiertas en la aplicación.
                /// </summary>
                private bool CerrarVentanas()
                {
                    bool Result = true;

                    string Aviso = "Se cerrarán todos los formularios abiertos.\nGuarde todos los datos antes de continuar.\n¿Desea continuar?";

                    if (this.MdiChildren.Length > 0)
                        if (MessageBox.Show(Aviso, "Confirmación de operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            foreach (Form F in this.MdiChildren)
                                F.Close();
                        }
                        else
                            Result = false;

                    return Result;
                }
            #endregion

            #region AYUDA / 
                private void MAcerca_Click(object sender, EventArgs e)
                {
                    Acerca frm = new Acerca();
                    frm.ShowDialog(this);
                    frm.Dispose();

                    ////GenericVisorSWF visor = new GenericVisorSWF();
                    ////visor.MdiParent = this;
                    ////visor.Show();
                    //////visor.Dispose();
                    
                }
                private void tsmVersion_Click(object sender, EventArgs e)
                {
                    MuestraVersion frmVersiones = new MuestraVersion() { PermitirCerrar = false };
                    frmVersiones.ShowDialog(this);
                    frmVersiones.Dispose();
                }
            #endregion

            #region DESARROLLLO /


                private void frmLogToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    UI.Desarrollo.frmLog frmLog = new UI.Desarrollo.frmLog();
                    MostrarFormulario(frmLog);
                }

                private void reiniciarConexioToolStripMenuItem_Click(object sender, EventArgs e)
                {
                   BD.Recargar();
                }
                
                private void cargarMenusProductosToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    CargarMenusProductos();
                    this.CargarMenusFamiliasProductos();
                }


                

                private void MDinamico_Click(object sender, EventArgs e)
                {

                    Provincia ObjetoBase = new Provincia();//(Momento)this.dtgResultado.CurrentRow.DataBoundItem;

                    GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ObjetoBase);
                    frmLanzar.Titulo = "Provincia";
                    frmLanzar.NumColumnas = 2;                    
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Codigo", "Codigo"));
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripcion"));


                    MostrarFormulario(frmLanzar);

                }
                private void MVisorMovimientos_Click(object sender, EventArgs e)
                {
                    VisorMovimientos frmLanzar = new VisorMovimientos();//;(Modo.Guardar, ObjetoBase);
                    MostrarFormulario(frmLanzar);
                }

                private void FDinamico_Click(object sender, EventArgs e)
                {
                    Cliente ObjetoBase = new Cliente();//(Momento)this.dtgResultado.CurrentRow.DataBoundItem;
                    //ObjetoBase.FechaAlta
                  
                    GenericFindDinamico frmLanzar = new GenericFindDinamico() { ClaseBase = ObjetoBase };
                    frmLanzar.Titulo = "Cliente";
                    frmLanzar.NumColumnas = 2;
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Nombre", "Nombre"));
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Direccion", "Direccion"));
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "DNI", "DNI") { ValidacionEspecial= ValidacionesEspeciales.EsDNI});
                    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "FechaAlta", "F. Alta"));
                    //whereBinding<Provincia> where = new whereBinding<Provincia>();
                    //where.EnlaceExpr = E => E.Codigo.Contains(frmLanzar.lstBinding[0].ControlAsociado);

                    //System.Linq.Expressions.Expression<Func<Cliente, bool>> expresion;
                    //expresion=E=>E.Nombre.Contains(Generic.ControlAString(frmLanzar.lstBinding[0].ControlAsociado));
                    

                    //frmLanzar.lstBinding[0].EnlaceExpr=(System.Linq.Expressions.Expression<Func<object, bool>>) expresion;
                    



                    MostrarFormulario(frmLanzar);
                }

    //private void pantallaEsperaToolStripMenuItem_Click(object sender, EventArgs e)
    //        {
    //            PantallaEspera(true);


    //        }

                //-------------Código Comentado----------------------------
                //private void frmBuscarToolStripMenuItem_Click(object sender, EventArgs e)
                //{
                //    UI.Ejemplos.FindBuscar findBuscar = new UI.Ejemplos.FindBuscar();
                //    MostrarFormulario(findBuscar);
                //}
                //private void frmParcelaToolStripMenuItem_Click(object sender, EventArgs e)
                //{
                //    EditParcela frmlanzar = new EditParcela();
                //    frmlanzar.Show();
                //}
                //private void frmDinamicoToolStripMenuItem_Click(object sender, EventArgs e)
                //{
                //    Desarrollo.frmDinamico frmLanzar = new Desarrollo.frmDinamico();
                //    frmLanzar.MdiParent = this;
                //    frmLanzar.Show();
                //}

                //private void frmArbolInformesToolStripMenuItem_Click(object sender, EventArgs e)
                //{
                //    if (FAbolInformes == null || !FAbolInformes.Visible)
                //        FAbolInformes = new ArbolInfomes();
                //    MostrarFormulario(FAbolInformes);
                //}
                //private void frmGenericEditDinamicoToolStripMenuItem_Click(object sender, EventArgs e)
                //{
                //    //Cuenta ClaseBase = new Cuenta();
                //    //GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ClaseBase);
                //    //frmLanzar.Titulo = "Cuentas";
                //    //frmLanzar.NumColumnas = 2;

                //    //frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Numero", "Numero", 23, true));
                //    //frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Banco", "Banco", 100, false));
                //    //frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Sucursal", "Sucursal", 100, false));




                //    //////MostrarFormulario(frmLanzar);


                //    Contacto ClaseBase = new Contacto();
                //    ClaseBase.IdExplotacion = Configuracion.Explotacion.Id;

                //    GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ClaseBase);
                //    frmLanzar.Titulo = "Contactos";
                //    frmLanzar.NumColumnas = 2;

                //    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Nombre", "Nombre", 150));
                //    Console.WriteLine(frmLanzar.lstBinding[0]._max_length.ToString());
                //    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Direccion", "Direccion", 100));
                //    frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Telefono", "Telefono", 9) { Requerido=true});


                //    //TipoInseminacion ClaseBase = new TipoInseminacion();
                //    //GenericEditDinamico frmLanzar = new GenericEditDinamico(Modo.Guardar, ClaseBase);
                //    //frmLanzar.Titulo = "Tipo Inseminación";
                //    //frmLanzar.NumColumnas = 2;

                //    //frmLanzar.lstBinding.Add(new BindingMaestro(frmLanzar.ClaseBase, "Descripcion", "Descripcion", 100, true));                


                //    MostrarFormulario(frmLanzar);
                //}
                //private void frmGenericFindDinamicoToolStripMenuItem_Click(object sender, EventArgs e)
                //{
               



                //}

                //private void selectorAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
                //{
                //    MostrarFormulario(new SelectorAnimales());
                //}

                private void datosSistemaToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    MostrarFormulario(new EditDatosSistema());
                }

           #endregion         

        #endregion

        #region BARRA MENÚ HORIZONTAL

            private void btnTitulares_Click(object sender, EventArgs e)
            {
                MTitulares.PerformClick();
            }
            private void btnAnimales_Click(object sender, EventArgs e)
            {
                MAnimales.PerformClick();
            }
            private void btnInseminaciones_Click(object sender, EventArgs e)
            {
                MInseminaciones.PerformClick();
            }            
            private void btnSembrados_Click(object sender, EventArgs e)
            {
                MSiembra.PerformClick();
            }
            private void btnCortes_Click(object sender, EventArgs e)
            {
                MRecolecta.PerformClick();
            }
            private void btnGastos_Click(object sender, EventArgs e)
            {
                MGastos.PerformClick();             
            }
            private void btnCambio_Click(object sender, EventArgs e)
            {
                AbrirSelector(false);
            }

        #endregion                             

        #region ALERTAS
        
        /// <summary>
        /// Recarga la consulta de alertas haciendo iniciando el proceso asincrono lanzado por el backgroundworker(CargarAlertas)
        /// </summary>
            private void RecargarAlertasAsync()
            {
                if (!CargarAlertas.IsBusy && AlertasActivadas)
                    CargarAlertas.RunWorkerAsync();
            }

            /// <summary>
            /// Realiza las consultas a la Base de datos, que inicializan el contenido de las alertas
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void CargarAlertas_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
            {
             
                    
                Core.Logic.Alertas alertas = new Core.Logic.Alertas();                    
                alertas.CargarAlertas();
             
            
            }                       

            /// <summary>
            /// Se ha completado la consulta de las alertas, se muestra un mensaje y se da la opcion de abrir el formulario
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void CargarAlertas_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
            {
                if (Core.Logic.Alertas.HayAlertas() && AlertasActivadas)
                {
                    //MostrarAlertas();
                    ctlNotificador mensaje = new ctlNotificador(string.Empty, DateTime.Now, "Existen alertas disponibles, Pulse el texto para consultar la pantalla: 'Información de alertas'");
                    mensaje.BackColor = System.Drawing.Color.FromArgb(254, 250, 218);//Amarillo clarito
                    mensaje.Mostrar();
                    mensaje.Bloqueado = true;
                    mensaje.LinkClicked += mensaje_LinkClicked;
                }
              
            }

            /// <summary>
            /// El usuario ha pinchado el link text del control mensaje.
            /// Lanzamos el formulario de alertas y ocultamos el notificador.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void mensaje_LinkClicked(object sender, EventArgs e)
            {
                ctlNotificador notificador = (ctlNotificador)sender;
                notificador.Bloqueado = false;
                notificador.Ocultar();              

                MostrarAlertas();
            }

            /// <summary>
            /// Lanza o recarga con las alertas ya cargadas, el formulario de alertas
            /// </summary>
            private void MostrarAlertas()
            {
                if (AlertasActivadas)
                {
                    if (FAlertas == null || !FAlertas.Visible)
                        FAlertas = new Alertas();
                    else
                        FAlertas.CargarElementos();

                    Application.DoEvents();
                    MostrarFormulario(FAlertas);
                }
            }

            /// <summary>
            /// Me aseguro de que no se pueda acceder a los menús alertas si no se encuentra el módulo activo
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void tsmAlertas_DropDownOpening(object sender, EventArgs e)
            {
                tsmMostrarAlertas.Enabled = AlertasActivadas;
                tsmRecargarAlertas.Enabled = AlertasActivadas;
                
            }            
        #endregion

            private void Principal_Load(object sender, EventArgs e)
            {
                //MdiClient ctlMDI;

                //// Loop through all of the form's controls looking
                //// for the control of type MdiClient.
                //foreach (Control ctl in this.Controls)
                //{
                //    try
                //    {
                //        // Attempt to cast the control to type MdiClient.
                //        ctlMDI = (MdiClient)ctl;

                //        // Set the BackColor of the MdiClient control.
                //        ctlMDI.BackColor = this.BackColor;
                //    }
                //    catch (InvalidCastException exc)
                //    {
                //        // Catch and ignore the error if casting failed.
                //    }
                //}

            }

          
          

            
    }
}
