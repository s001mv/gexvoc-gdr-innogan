using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GEXVOC.Core.Logic;
using GEXVOC.UI.Clases;
using GEXVOC.Core.Reflection;
using System.Linq;



namespace GEXVOC.UI
{
    public partial class EditAnimales : GEXVOC.UI.GenericEdit
    {                

        #region VARIABLES Y PROPIEDADES PRINCIPALES DEL FORMULARIO
            /// <summary>
            /// Es una propiedad Tipada que nos devuelve la Clase Base sobre la que actúa el Formulario Edit 
            /// El tipo es popio del formulario, pero implementa siempre la interface  IClaseBase)
            /// </summary>
            public Animal ObjetoBase { get { return (Animal)this.ClaseBase; } }



            //int? _ValorFijoIdExplotacion= null;
            ///// <summary>
            ///// Propiedad que nos indica si el formulario debe aparecer con el combo de la explotacion fijo y con la explotacion que corresponde 
            ///// con el Id especificado aqui.
            ///// </summary>
            //public int? ValorFijoIdExplotacion
            //{
            //    get { return _ValorFijoIdExplotacion; }
            //    set
            //    {
            //        if (value != null)
            //        {
            //            this.cmbExplotacion.ClaseActiva = Explotacion.Buscar((int)value);
            //            this.cmbExplotacion.ReadOnly = true;
                      
            //        }
            //        else
            //            this.cmbExplotacion.ReadOnly = false;

            //        _ValorFijoIdExplotacion = value;
            //    }
            //}

            int? idParto = null;

            public int? IdParto
            {
                get { return idParto; }
                set { idParto = value; }
            }

            private Configuracion.ValorPredeterminadoNombreAnimal _ValorPredeterminadoNombreAnimal;

            public Configuracion.ValorPredeterminadoNombreAnimal ValorPredeterminadoNombreAnimal
            {
                get { return _ValorPredeterminadoNombreAnimal; }
                set {
                    if (value == Configuracion.ValorPredeterminadoNombreAnimal.Nombre)
                    {
                        chkNombreAutomatico.Checked = false;
                        chkNombreAutomatico.Visible = false;
                        chkNombreAutomatico.Enabled = false;

                    }
                    else
                    {
                        chkNombreAutomatico.Checked = true;
                        chkNombreAutomatico.Visible = true;
                        chkNombreAutomatico.Enabled = true;
                    }


                   
                     //= (value != Configuracion.ValorPredeterminadoNombreAnimal.Nombre);

                   
                    _ValorPredeterminadoNombreAnimal = value; 
                }
            }


            public char? ValorSexoFijo {get;set;}
            public string CI { get { return txtDIB.Text; } set { txtDIB.Text = value; } }
            public int? ValorEstadoFijo { get; set; }
         


        #endregion
       
        #region CONSTRUCTOR E INICIALIZACIONES REQUERIDAS

            /// <summary>
            /// Constructor por defecto
            /// </summary>
            public EditAnimales()
            {
                InitializeComponent();
                MostrarGrid = false;
            }       

            /// <summary>
            /// Sobrecarga del Constructor que nos permite inicializar un formulario GenericEdit con los datos propios del formulario.
            /// Para ello necesitamos el modo en el que se lanza y la clase base sobre la que actúa.
            /// Este tipo de sobrecargas son siempre obligatorias al heredar de GenericEdit.
            /// El Codigo es Siempre el mismo, salvo por el tipo de la ClaseBase, que es propio del formulario heredado.
            /// </summary>
            /// <param name="modo">Modo de Apertura del Formulario Edit</param>
            /// <param name="ClaseBase">Clase Base sobre la que actúa el formulario Edit.</param>
            public EditAnimales(Modo modo, Animal ClaseBase): base(modo, ClaseBase)
            {
                InitializeComponent();
                MostrarGrid = false;
              
            }
            public EditAnimales(Modo modo, Animal ClaseBase,int numTabSeleccionar)
                : base(modo, ClaseBase, numTabSeleccionar)
            {
                InitializeComponent();
                MostrarGrid = true;
            }
            public EditAnimales(Modo modo, Animal ClaseBase, string tabSeleccionar)
                : base(modo, ClaseBase, tabSeleccionar)
            {
                InitializeComponent();
                MostrarGrid = true;

                //Cuando se selecciona el tab desde base no se produce el evento selecting del tabcontrol, y este es el que carga la 
                //información sobre la lactación. Probocamos entonces esa carga en caso de que el formualrio sea abierto desde el botón lactación del find.
                if (tabSeleccionar == "Lactación")
                    CargarLactacionExtendida();
            }

            /// <summary>
        /// Sobrecarga que nos permite especificar un idParto para inicializar una serie de valores por defecto.        
        /// </summary>
        /// <param name="modo"></param>
        /// <param name="ClaseBase"></param>
        /// <param name="idParto"></param>
            public EditAnimales(int idParto)
                : base(Modo.Guardar, new Animal())
            {
                InitializeComponent();
                IdParto = idParto;
                MostrarGrid = false;
            }


            

        #endregion

        #region BINDING (Intercambio de datos entre la Clase y los controles del formulario)
            /// <summary>
            /// Pasa los Valores de la Clase Base a los Controles del Formulario
            /// </summary>
            protected override void ClaseBaseAControles()
            {
               
                //ValorFijoIdExplotacion = this.ObjetoBase.IdExplotacion;               

                
                ClaseBaseAcontrol(this.ObjetoBase, "DIB", txtDIB);
                ClaseBaseAcontrol(this.ObjetoBase, "Crotal", txtCrotal);
                ClaseBaseAcontrol(this.ObjetoBase, "Tatuaje", txtTatuaje);                
               
                ClaseBaseAcontrol(this.ObjetoBase, "Identificado", chkIndentificado);

                ClaseBaseAcontrol(this.ObjetoBase, "DescIdEspecie", cmbEspecie);//provoca la carga del combo raza
                cmbEspecie.Enabled = false;
                Application.DoEvents();
                ClaseBaseAcontrol(this.ObjetoBase, "IdRaza", cmbRaza);
              

                //Me aseguro de inicializar correctamente el valor del control chkNombreAutomatico, pues a pesar 
                //De estar en configuración de una manera, puede ser que el usuario haya querido personalizar el dato
                //y esto implica que cuando actualizamos, si el dato habia sido personalizado, desmarcamos el check
                switch (ValorPredeterminadoNombreAnimal)	
                {
		            case Configuracion.ValorPredeterminadoNombreAnimal.DIB:             
                            chkNombreAutomatico.Checked=this.ObjetoBase.Nombre==this.ObjetoBase.DIB;
                     break;
                    case Configuracion.ValorPredeterminadoNombreAnimal.Crotal:
                           chkNombreAutomatico.Checked=this.ObjetoBase.Nombre==this.ObjetoBase.Crotal;
                     break;
                    case Configuracion.ValorPredeterminadoNombreAnimal.Tatuaje:
                        chkNombreAutomatico.Checked=this.ObjetoBase.Nombre==this.ObjetoBase.Tatuaje;
                     break;
                
                }

                ClaseBaseAcontrol(this.ObjetoBase, "Nombre", txtNombre);

                ClaseBaseAcontrol(this.ObjetoBase, "FechaNacimiento", txtFecNacimiento);
                
                ClaseBaseAcontrol(this.ObjetoBase, "Sexo", cmbSexo);

                if (this.ObjetoBase.Sexo == Convert.ToChar("M"))
                { //Si es un macho sobran algunos grids

                    tbcContenido.TabPages.Remove(tbpPartos);
                    tbcContenido.TabPages.Remove(tbpControles);
                    tbcContenido.TabPages.Remove(tbpSecados);
                    tbcContenido.TabPages.Remove(tbpCelos);
                    tbcContenido.TabPages.Remove(tbpLactacion);
                    grpDiagnosticosGestacion.Enabled = false;
                    grpDiagnosticosGestacion.Visible = false;


                    //Muestro u oculto las Columnas del grid inseminaciones que correspondan
                    DescHembra.Visible = true;
                    DescMacho.Visible = false;
                }
                else
                {
                    //Muestro u oculto las Columnas del grid inseminaciones que correspondan
                    DescHembra.Visible = false;
                    DescMacho.Visible = true;
                }

                ClaseBaseAcontrol(this.ObjetoBase, "IdEstado", cmEstado);
                ClaseBaseAcontrol(this.ObjetoBase, "IdConformacion", cmbConformacion);
                ClaseBaseAcontrol(this.ObjetoBase, "IdTalla", cmbTalla);

                ClaseBaseAcontrol(this.ObjetoBase, "Morfologia", txtMorfologia);
                ClaseBaseAcontrol(this.ObjetoBase, "Externo", cbxExterno);
                ClaseBaseAcontrol(this.ObjetoBase, "AptoNovillas", cbxAptoNovillas);
                ClaseBaseAcontrol(this.ObjetoBase, "Testaje", cbxTestaje);
                ClaseBaseAcontrol(this.ObjetoBase, "Genotipo", txtGenotipo);
                ClaseBaseAcontrol(this.ObjetoBase, "RegistroGenealogico", txtRegGenealogico);

                ClaseBaseAcontrol(this.ObjetoBase, "FechaDestete", txtFechaDestete);

                CargarAlta();
                CargarBaja();
              


                if (this.ObjetoBase.ImagenCargada != null)
                {
                    MemoryStream ms = new MemoryStream(this.ObjetoBase.ImagenCargada.ToArray());
                    imgAnimal.Image = Image.FromStream(ms);
                }

            }

            /// <summary>
            /// Pasa los valores de los controles a la Clase Base
            /// </summary>
            protected override void ControlesAClaseBase()
            {
              

                    //Cargo en el objeto de datos (animales), los valores introducidos en los combos
                    //Para ello debo asegurarme de que hay algo seleccionado, si es así transformo
                    //El SelectedItem del combo (Que es un object) en el objeto de datos que corresponda
                    //Pudiendo asi acceder a cualquiera de sus propiedades


                ControlAClaseBase(this.ObjetoBase, "Nombre", txtNombre);
                ControlAClaseBase(this.ObjetoBase, "IdRaza", cmbRaza);
                ControlAClaseBase(this.ObjetoBase, "DIB", txtDIB);


                if (lstControlesConErrores.Count==0)                
                    ValidarCrotal(txtCrotal);
                
                ControlAClaseBase(this.ObjetoBase, "Crotal", txtCrotal);

                ControlAClaseBase(this.ObjetoBase, "Identificado", chkIndentificado);    
                ControlAClaseBase(this.ObjetoBase, "Tatuaje", txtTatuaje);                     
                //ControlAClaseBase(this.ObjetoBase, "IdAlta", cmbTipoAlta);
                //ControlAClaseBase(this.ObjetoBase, "FechaAlta", txtFecAlta);           
            
                ControlAClaseBase(this.ObjetoBase, "FechaNacimiento", txtFecNacimiento);
              
          
                ControlAClaseBase(this.ObjetoBase, "Sexo", cmbSexo);
                //ControlAClaseBase(this.ObjetoBase, "IdExplotacion", cmbExplotacion);
                ControlAClaseBase(this.ObjetoBase, "IdEstado", cmEstado);
                ControlAClaseBase(this.ObjetoBase, "IdConformacion", cmbConformacion);
                ControlAClaseBase(this.ObjetoBase, "IdTalla", cmbTalla);


                ControlAClaseBase(this.ObjetoBase, "Morfologia", txtMorfologia);
                ControlAClaseBase(this.ObjetoBase, "Externo", cbxExterno);
                ControlAClaseBase(this.ObjetoBase, "AptoNovillas", cbxAptoNovillas);
                ControlAClaseBase(this.ObjetoBase, "Testaje", cbxTestaje);
                ControlAClaseBase(this.ObjetoBase, "FechaDestete", txtFechaDestete);
                ControlAClaseBase(this.ObjetoBase, "Genotipo", txtGenotipo);
                ControlAClaseBase(this.ObjetoBase, "RegistroGenealogico", txtRegGenealogico);


                if (this.imgAnimal.Image != null)
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        imgAnimal.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        this.ObjetoBase.ImagenAsociada = ms.ToArray();
                    }
                    catch (Exception) { }
                }
                else
                    this.ObjetoBase.ImagenAsociada = null;


                //try
                //{


                //    //#############Codigo para Tratamiento de la imagen####################
                //    if (lblFoto.Text != String.Empty)
                //    {

                //        string Imagenes = Application.StartupPath + @"\Imagenes\";

                //        if (!Directory.Exists(Imagenes))
                //            Directory.CreateDirectory(Imagenes);

                //        if (lblFoto.Text != ObjetoBase.Imagen)
                //        {
                //            if (File.Exists(ObjetoBase.Imagen))
                //                File.Delete(ObjetoBase.Imagen);

                //            string Archivo = Imagenes + ObjetoBase.Crotal;

                //            File.Copy(lblFoto.Text, Archivo, true);

                //            ObjetoBase.Imagen = Archivo;
                //        }
                //    }
                //    else
                //        ObjetoBase.Imagen = String.Empty;
                //    //FIN#############Codigo para Tratamiento de la imagen#################





                //}
              
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);

                //    Generic.Aviso("Error en el proceso de guardado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                //}

                //this.GuardarMorfologia();
                ActualizarAlta();
                ActualizarBaja();
                ActualizarLGenealogico();
                ActualizarTipificacionCanal();
                ActualizarEngrasamientoCanal();
                ActualizarRendimientoCanal();
            }
       
            /// <summary>
            /// Validación de los Controles, se produce antes de actualizar la ClaseBase (ControlesAClaseBase)
            /// Si la validación retorna False no se continua con la actualización
            /// </summary>
            /// <returns>Controles Válidos (Sí/No)</returns>
            protected override bool Validar()
            {
                bool Rtno = true;
                //this.ErrorProvider.Clear();               
                
                //NOTA: Ponemos los campos a validar justo al revés, para que cuando se les establezca el foco (Si no se encuentran valorados), se haga
                //en orden
                if (!Generic.ControlValorado(new Control[] { cmbEspecie, cmbAltaTipo, cmbSexo, txtFecNacimiento, txtAltaFecha, cmbRaza, txtNombre }, this.ErrorProvider))
                    Rtno = false;

                //Validaciones de tipos de datos (Siempre despues de validar los requeridos, pues son 
                //los que posicionan el foco en el control cuando no tiene valor (La validacion de tipos no lo hace)
                if (!Generic.ControlDatosCorrectos(this.txtFecNacimiento,  this.ErrorProvider, typeof(System.DateTime), true))
                    Rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtAltaFecha,  this.ErrorProvider,  typeof(System.DateTime), false))
                    Rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtBajaFecha,  this.ErrorProvider,  typeof(System.DateTime), false))
                    Rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtFechaDestete, this.ErrorProvider, typeof(System.DateTime), false))
                    Rtno = false;
                if (!Generic.ControlDatosCorrectos(this.txtMorfologia, this.ErrorProvider, typeof(System.Int32), false))
                    Rtno = false;
                
                if (cmbEspecie.SelectedValue!=null)
                {
                      //si es una vaca es obligatorio el DIB
                    if ((int)cmbEspecie.SelectedValue == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.BOVINA).Id)
                    {
                        if (!Generic.ControlValorado(this.txtDIB, this.ErrorProvider)) Rtno = false;
                        //Si tiene crotal debe ser de 4 caracteres obligatorios
                        if (!string.IsNullOrEmpty(txtCrotal.Text) && txtCrotal.Text.Length != 4)
                        {
                            Generic.PonerError(ErrorProvider, txtCrotal, "Para la especie bovina, si se especifica crotal, éste debe constar de 4 caracteres");
                            Rtno = false;
                        }
                        
                    }
                     //Si es oveja o cabra es obligatorio el Crotal
                    if ((int)cmbEspecie.SelectedValue == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.CAPRINA).Id ||
                        (int)cmbEspecie.SelectedValue == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.OVINA).Id)
                        if (!Generic.ControlValorado(this.txtCrotal, this.ErrorProvider)) Rtno = false;                    
                
                }

              


                return Rtno;
            }

            /// <summary>
            /// La validacion del crotal se realiza en caso de:
            /// - Inserciones
            /// - Modificaciones en las que se ha modificado el crotal
            /// </summary>
            /// <param name="crotal"></param>
            private void ValidarCrotal(Control crotal)
            {
                if (this.ModoActual == Modo.Guardar || this.ObjetoBase.Crotal != crotal.Text)//Insercion o crotal modificado
                {
                    if (crotal.Text != string.Empty)
                    {
                        List<Animal> lstAnimales = Animal.Buscar(crotal.Text, null);
                        if (lstAnimales != null && lstAnimales.Count > 0)
                        {
                            DialogResult rdo = MessageBox.Show("El animal con el crotal: " + crotal.Text + " ya se encuentra dado de alta \r" +
                                "¿Desea insertar el animal de todos modos?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rdo != DialogResult.Yes)
                            {
                                crotal.Focus();
                                throw new LogicException("No se ha insertado el animal porque ya existe el crotal indicado");
                            }
                        }
                    }
                }


            }



            #region TRATAMIENTO BAJAS
                 void CargarBaja()
                {
                    Baja objBaja = this.ObjetoBase.BajaAnimal();
                    if (objBaja != null)
                    {
                        chkBaja.Checked = true;
                        ClaseBaseAcontrol(objBaja, "IdTipo", cmbBajaTipo);
                        ClaseBaseAcontrol(objBaja, "Detalle", txtBajaDetalle);
                        ClaseBaseAcontrol(objBaja, "Fecha", txtBajaFecha);
                        ClaseBaseAcontrol(objBaja, "Importe", txtImporteBaja);
                        ClaseBaseAcontrol(objBaja, "NumeroGuia", txtNumeroGuiaSalida);
                    }
                    else
                        chkBaja.Checked = false;


                }
                 void ActualizarBaja()
                {
                    Baja objBaja = this.ObjetoBase.BajaAnimal();
                    if (chkBaja.Checked)
                    {
                        if (objBaja == null)
                        {
                            objBaja = new Baja();
                            this.ObjetoBase.Baja.Add(objBaja);
                        }
                        else
                            objBaja = (Baja)objBaja.CargarContextoOperacion(TipoContexto.Modificacion);

                        ControlAClaseBase(objBaja, "IdTipo", cmbBajaTipo, true);
                        ControlAClaseBase(objBaja, "Detalle", txtBajaDetalle, false);
                        ControlAClaseBase(objBaja, "Fecha", txtBajaFecha, true);
                        ControlAClaseBase(objBaja, "Importe", txtImporteBaja, false);
                        ControlAClaseBase(objBaja, "NumeroGuia", txtNumeroGuiaSalida, false);
                    }
                    else
                    {
                        if (objBaja != null)//Significa que hemos deschequeado el check de baja para eliminarla                
                            objBaja.Eliminar();

                    }


                }
                private void chkBaja_CheckedChanged(object sender, EventArgs e)
                {
                    pnlBaja.Enabled = chkBaja.Checked;
                }
            #endregion
            #region TRATAMIENTO ALTAS
                void CargarAlta()
                {
                    Alta objAlta = this.ObjetoBase.AltaAnimal();
                    if (objAlta != null)
                    {
                        ClaseBaseAcontrol(objAlta, "IdTipo", cmbAltaTipo);
                        ClaseBaseAcontrol(objAlta, "Detalle", txtAltaDetalle);
                        ClaseBaseAcontrol(objAlta, "Fecha", txtAltaFecha);
                        ClaseBaseAcontrol(objAlta, "Importe", txtImporteAlta);
                        ClaseBaseAcontrol(objAlta, "NumeroGuia", txtNumeroGuiaEntrada);
                        
                    }


                }
                void ActualizarAlta()
                {
                    Alta objAlta = this.ObjetoBase.AltaAnimal();

                    if (objAlta == null)
                    {
                        objAlta = new Alta();
                        this.ObjetoBase.Alta.Add(objAlta);
                    }
                    else
                        objAlta = (Alta)objAlta.CargarContextoOperacion(TipoContexto.Modificacion);

                    ControlAClaseBase(objAlta, "IdTipo", cmbAltaTipo, true);
                    ControlAClaseBase(objAlta, "Detalle", txtAltaDetalle, false);
                    ControlAClaseBase(objAlta, "Fecha", txtAltaFecha, true);
                    ControlAClaseBase(objAlta, "Importe", txtImporteAlta,false);
                    ControlAClaseBase(objAlta, "NumeroGuia", txtNumeroGuiaEntrada, false);


                }
            #endregion
            #region TRATAMIENTO LGENEALÓGICO
                void CargarLGenealogico()
                {
                    if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpLibroGenealogico.Name))
                    {
                        LibroGenealogico Libro = this.ObjetoBase.LibroAnimal();                       

                        if (Libro != null)
                        {
                            // Cargo el LGenealogico del Padre.
                            CargarLGenealogicoAnimal(new LGenealogico(){
                                                        CIAnimal = Libro.Padre,
                                                        CtlAnimal = txtCrotalPadre,
                                                        CtlPadre = txtCrotalPadrePadre,
                                                        CtlMadre = txtCrotalMadrePadre,
                                                        CtlPadrePadre = txtCrotalAbueloPPadre,
                                                        CtlMadrePadre = txtCrotalAbuelaPPadre,
                                                        CtlPadreMadre = txtCrotalAbueloMPadre,
                                                        CtlMadreMadre = txtCrotalAbuelaMPadre
                                                     });
                            // Cargo el LGenealogico de la Madre                           
                            CargarLGenealogicoAnimal(new LGenealogico()
                            {
                                CIAnimal = Libro.Madre,
                                CtlAnimal = txtCrotalMadre,
                                CtlPadre = txtCrotalPadreMadre,
                                CtlMadre = txtCrotalMadreMadre,
                                CtlPadrePadre = txtCrotalAbueloPMadre,
                                CtlMadrePadre = txtCrotalAbuelaPMadre,
                                CtlPadreMadre = txtCrotalAbueloMMadre,
                                CtlMadreMadre = txtCrotalAbuelaMMadre
                            });


                        
                            Animal animal =Animal.Buscar(Libro.Madre);

                            if (animal!=null)
                            {
                                Animal madre = animal;                             
                                
                                List<Parto> lstpartos=Parto.Buscar(madre.Id,null,null,null,null,this.ObjetoBase.FechaNacimiento,this.ObjetoBase.FechaNacimiento,null);
                                Parto parto = null;                                                              
                                
                                if (lstpartos != null && lstpartos.Count>0)                                
                                    parto= lstpartos.First();
                                    
                                
                                if (parto!=null)
                                {
                                    txtTipoParto.Text = parto.DescTipo;
                                    txtFacilidadParto.Text = parto.DescFacilidad;

                                    Inseminacion UltimaInseminacion = parto.UltimaInseminacion();
                                    Cubricion UltimaCubricion = parto.UltimaCubricion();
                                    IClaseBase UltimoElemento = null;
                                    if (UltimaCubricion!=null && UltimaInseminacion!=null)
                                    {//Tiene inseminaciones y cubriciones
                                        if (UltimaInseminacion.Fecha > UltimaCubricion.FechaInicio)
                                            UltimoElemento = UltimaInseminacion;
                                        else
                                            UltimoElemento = UltimaCubricion;
                                        
                                    }
                                    else if (UltimaInseminacion!=null)//Solo tiene inseminaciones                                    
                                        UltimoElemento = UltimaInseminacion;                                    
                                    else if (UltimaCubricion!=null)//Solo tiene cubriciones                                    
                                        UltimoElemento = UltimaCubricion;

                                    if (UltimoElemento!=null)
                                    {
                                        if (UltimoElemento.GetType()==typeof(Inseminacion))
                                        {
                                            lblTipoInseCubri.Text = "Tipo de Inseminacion:";
                                            txtTipoInseCubri.Text = ((Inseminacion)UltimoElemento).DescTipo;
                                            
                                        }
                                        else if (UltimoElemento.GetType()==typeof(Cubricion))
                                        {
                                            lblTipoInseCubri.Text = "Tipo de Cubricion:";
                                            txtTipoInseCubri.Text = ((Cubricion)UltimoElemento).DescTipo;
                                        }
                                    }
                                }
                            }
                            animal = null;                           
                        }
                        Libro = null;
                    }
                    
                }
                void ActualizarLGenealogico()
                {
                    if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpLibroGenealogico.Name))
                    {
                        LibroGenealogico Libro = this.ObjetoBase.LibroAnimal();

                        if (Libro == null)
                        {
                            Libro = new LibroGenealogico();
                            this.ObjetoBase.LibroGenealogico.Add(Libro);
                        }
                        else
                            Libro = (LibroGenealogico)Libro.CargarContextoOperacion(TipoContexto.Modificacion);

                        Libro.Animal = ObjetoBase;
                        ControlAClaseBase(Libro, "Padre", txtCrotalPadre, false);
                        ControlAClaseBase(Libro, "Madre", txtCrotalMadre, false);
                    }                    
                }

                struct LGenealogico
                {
                    //Animal a tratar
                    public string CIAnimal;
                    public Control CtlAnimal;

                    //Padre
                    public Control CtlPadre;
                    //Padres del Padre
                    public Control CtlPadrePadre;
                    public Control CtlMadrePadre;
                    //Madre
                    public Control CtlMadre;
                    //Padres de la Madre
                    public Control CtlPadreMadre;
                    public Control CtlMadreMadre;
                }

                void CargarLGenealogicoAnimal(LGenealogico lGenealogico) 
                {
                    if (lGenealogico.CIAnimal != string.Empty)
                    {
                        Animal animal = null;
                        LibroGenealogico Ascendencia = null;
                        LibroGenealogico AscendenciaPadres = null;
                       
                        lGenealogico.CtlAnimal.Text = lGenealogico.CIAnimal;

                        animal = Animal.Buscar(lGenealogico.CIAnimal);

                        if (animal!=null)
                        {
                            Ascendencia = animal.LibroAnimal();

                            if (Ascendencia != null)
                            {
                                ClaseBaseAcontrol(Ascendencia, "Padre", lGenealogico.CtlPadre);
                                ClaseBaseAcontrol(Ascendencia, "Madre", lGenealogico.CtlMadre);

                                //Abuelos padre
                                animal = Animal.Buscar(Ascendencia.Padre);
                                if (animal!=null)
                                {
                                    AscendenciaPadres = animal.LibroAnimal();

                                    if (AscendenciaPadres != null)
                                    {
                                        ClaseBaseAcontrol(AscendenciaPadres, "Padre", lGenealogico.CtlPadrePadre);
                                        ClaseBaseAcontrol(AscendenciaPadres, "Madre", lGenealogico.CtlMadrePadre);
                                    }
                                }
                                //Abuelos madre
                                animal = Animal.Buscar(Ascendencia.Madre);
                                if (animal!=null)
                                {
                                    AscendenciaPadres = animal.LibroAnimal();

                                    if (AscendenciaPadres != null)
                                    {
                                        ClaseBaseAcontrol(AscendenciaPadres, "Padre", lGenealogico.CtlPadreMadre);
                                        ClaseBaseAcontrol(AscendenciaPadres, "Madre", lGenealogico.CtlMadreMadre);
                                    }
                                }
                            }                           
                        }
                    }
                }

            #endregion

            #region TRATAMIENTO TIPIFICACION
             private void chkTipificacion_CheckedChanged(object sender, EventArgs e)
                {
                    pnlTipificacion.Enabled = chkTipificacion.Checked;

                }
             void CargarTipificacionCanal()
             {
                 if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpCanal.Name))
                 {
                         
                     TipificacionCanal objTipificacionCanal = this.ObjetoBase.TipificacionCanalAnimal();
                     if (objTipificacionCanal != null)
                     {
                         chkTipificacion.Checked = true;                 
                         
                         ClaseBaseAcontrol(objTipificacionCanal, "IdConformacion", cmbTipificacionConformacion);
                         ClaseBaseAcontrol(objTipificacionCanal, "Fecha", txtTipificacionFecha);
                         ClaseBaseAcontrol(objTipificacionCanal, "IdCategoria", cmbTipificacionCategoria);
                         
                     }
                     else
                         chkTipificacion.Checked = false;
                 }



             }
             void ActualizarTipificacionCanal()
             {
                 if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpCanal.Name))
                 {
                     TipificacionCanal objTipificacionCanal = this.ObjetoBase.TipificacionCanalAnimal();
                     if (chkTipificacion.Checked)
                     {
                         if (objTipificacionCanal == null)
                         {
                             objTipificacionCanal = new TipificacionCanal();
                             this.ObjetoBase.TipificacionCanal.Add(objTipificacionCanal);
                         }
                         else
                             objTipificacionCanal = (TipificacionCanal)objTipificacionCanal.CargarContextoOperacion(TipoContexto.Modificacion);

                         
                         //objTipificacionCanal.IdAnimal = this.ObjetoBase.Id;//Establezco esta información para que funcione correctamente la validacion de logica.
                             
                         ControlAClaseBase(objTipificacionCanal, "IdConformacion", cmbTipificacionConformacion, true);
                         ControlAClaseBase(objTipificacionCanal, "Fecha", txtTipificacionFecha, true);
                         ControlAClaseBase(objTipificacionCanal, "IdCategoria", cmbTipificacionCategoria, true);
                     }
                     else
                     {
                         if (objTipificacionCanal != null)//Significa que hemos deschequeado el check de TipificacionCanal para eliminarla                
                             objTipificacionCanal.Eliminar();

                     }


                 }


             }
        
            #endregion
            #region TRATAMIENTO ENGRASAMIENTO
                private void chkEngrasamiento_CheckedChanged(object sender, EventArgs e)
                {
                    pnlEngrasamiento.Enabled = chkEngrasamiento.Checked;

                }

                void CargarEngrasamientoCanal()
                {
                    if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpCanal.Name))
                    {
                        EngrasamientoCanal objEngrasamientoCanal = this.ObjetoBase.EngrasamientoCanalAnimal();
                        if (objEngrasamientoCanal != null)
                        {
                            chkEngrasamiento.Checked = true;
                            ClaseBaseAcontrol(objEngrasamientoCanal, "IdTipo", cmbEngrasamientoTipo);
                            ClaseBaseAcontrol(objEngrasamientoCanal, "Fecha", txtEngrasamientoFecha);
                          

                        }
                        else
                            chkEngrasamiento.Checked = false;

                    }


                }
                void ActualizarEngrasamientoCanal()
                {
                    if (TabControlPrincipal.TabPages.ContainsKey(tbpCanal.Name))
                    {

                        EngrasamientoCanal objEngrasamientoCanal = this.ObjetoBase.EngrasamientoCanalAnimal();
                        if (chkEngrasamiento.Checked)
                        {
                            if (objEngrasamientoCanal == null)
                            {
                                objEngrasamientoCanal = new EngrasamientoCanal();
                                this.ObjetoBase.EngrasamientoCanal.Add(objEngrasamientoCanal);
                            }
                            else
                                objEngrasamientoCanal = (EngrasamientoCanal)objEngrasamientoCanal.CargarContextoOperacion(TipoContexto.Modificacion);

                            ControlAClaseBase(objEngrasamientoCanal, "IdTipo", cmbEngrasamientoTipo, true);
                            ControlAClaseBase(objEngrasamientoCanal, "Fecha", txtEngrasamientoFecha, true);

                        }
                        else
                        {
                            if (objEngrasamientoCanal != null)//Significa que hemos deschequeado el check de EngrasamientoCanal para eliminarla                
                                objEngrasamientoCanal.Eliminar();

                        }

                    }

                }
            #endregion
            #region TRATAMIENTO RENDIMIENTO
                private void chkRendimiento_CheckedChanged(object sender, EventArgs e)
                {
                    pnlRendimiento.Enabled = chkRendimiento.Checked;
                }

                void CargarRendimientoCanal()
                {
                    if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpCanal.Name))
                    {
                        RendimientoCanal objRendimientoCanal = this.ObjetoBase.RendimientoCanalAnimal();
                        if (objRendimientoCanal != null)
                        {
                            chkRendimiento.Checked = true;
                            ClaseBaseAcontrol(objRendimientoCanal, "Rendimiento", txtRendimiento);
                            ClaseBaseAcontrol(objRendimientoCanal, "Fecha", txtRendimientoFecha);


                        }
                        else
                            chkRendimiento.Checked = false;

                    }
                }
                void ActualizarRendimientoCanal()
                {
                    if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpCanal.Name))
                    {
                        RendimientoCanal objRendimientoCanal = this.ObjetoBase.RendimientoCanalAnimal();
                        if (chkRendimiento.Checked)
                        {
                            if (objRendimientoCanal == null)
                            {
                                objRendimientoCanal = new RendimientoCanal();
                                this.ObjetoBase.RendimientoCanal.Add(objRendimientoCanal);
                            }
                            else
                                objRendimientoCanal = (RendimientoCanal)objRendimientoCanal.CargarContextoOperacion(TipoContexto.Modificacion);

                            ControlAClaseBase(objRendimientoCanal, "Rendimiento", txtRendimiento, true);
                            ControlAClaseBase(objRendimientoCanal, "Fecha", txtRendimientoFecha, true);

                        }
                        else
                        {
                            if (objRendimientoCanal != null)//Significa que hemos deschequeado el check de RendimientoCanal para eliminarla                
                                objRendimientoCanal.Eliminar();

                        }
                    }

                }
            #endregion


        #endregion

        #region BOTONES IMAGEN
        private void imgAñadir_Click_1(object sender, EventArgs e)   
        {                   
            if (FileDialog.ShowDialog() == DialogResult.OK)            
                imgAnimal.Image = Image.FromFile(FileDialog.FileName);
        }

        private void imgEliminar_Click(object sender, EventArgs e)
        {
            imgAnimal.Image = null;
        }

        #endregion        
     
        #region CARGAS COMUNES
            public override void Cargar()
            {
              
                ////////if (!((Configuracion.Aptitud & Aptitudes.Carnica) > 0))
                ////////{
                ////////    tbcContenido.TabPages.Remove(tbpCondicionCorporal);
                ////////    tbcContenido.TabPages.Remove(tbpCanal);

                ////////}

                if (Configuracion.Explotacion == null)
                {
                    throw new LogicException("No es posible mostrar el formulario porque no se encuentra una explotación activa");
                }
               
                
                base.Cargar();
            }
   
            protected override void CargarGrids()
            {               
                CargarLGenealogico();
                CargarTipificacionCanal();
                CargarEngrasamientoCanal();
                CargarRendimientoCanal();

                if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpInseminaciones.Name))
                {
                   
                    dtgInseminaciones.DataSource = this.ObjetoBase.lstInseminaciones;
                    dtgDiagGestacion.DataSource = this.ObjetoBase.lstDiagGestacion;
                }

                if (this.MostrarGrid &&  TabControlPrincipal.TabPages.ContainsKey(tbpPartos.Name))
                {
                    dtgAbortos.DataSource = this.ObjetoBase.lstAbortos;
                    dtgPartos.DataSource = this.ObjetoBase.lstPartos;                
                }

                if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpControles.Name))              
                    dtgControles.DataSource = this.ObjetoBase.lstControlesUltimaLactacion;

                if (this.MostrarGrid &&  TabControlPrincipal.TabPages.ContainsKey(tbpSecados.Name))                              
                    this.dtgSecados.DataSource = this.ObjetoBase.lstSecados;

                if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpPesos.Name))                                              
                    this.dtgPesos.DataSource = this.ObjetoBase.lstPesos;

                if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpCelos.Name))
                {
                    this.dtgCelos.DataSource = this.ObjetoBase.lstCelos;
                    this.dtgSincronizacionCelos.DataSource = this.ObjetoBase.lstSincronizacionCelos;
                }

                if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpCondicionCorporal.Name))                                                              
                    this.dtgCondicionCorporal.DataSource = this.ObjetoBase.lstCondicionesCorporales;

                if (this.MostrarGrid && TabControlPrincipal.TabPages.ContainsKey(tbpDiagnosticos.Name))                                                                              
                    this.dtgDiagnosticos.DataSource = this.ObjetoBase.lstTratamientos;

                   

            }

            protected override void CargarValoresDefecto()
            {
                //if (this._ValorFijoIdExplotacion == null)            
                //    this.ValorFijoIdExplotacion = Configuracion.Explotacion.Id;

                if (ValorSexoFijo != null)
                {
                    this.cmbSexo.Enabled = false;
                    this.cmbSexo.SelectedValue = this.ValorSexoFijo;
                }
                if (ValorEstadoFijo != null)
                {
                    this.cmEstado.Enabled = false;
                    this.cmEstado.SelectedValue = this.ValorEstadoFijo;
                }

                if (IdParto!=null)//Establezo los valores correspondientes si este formulario es lanzado con el constructor que identifica un idParto
                {   //Algunos valores será automáticos en este caso como fecha nacimiento, madre, etc...
                    Parto parto = Parto.Buscar((int)IdParto);
                    Animal hembra = Animal.Buscar(parto.IdHembra);
                    Inseminacion UltimaInseminacion = parto.UltimaInseminacion();

                    if (parto!=null)
                    {
                        Generic.DatetimeAControl(txtFecNacimiento, parto.Fecha);
                        cmbAltaTipo.SelectedValue = Configuracion.TipoAltaSistema(Configuracion.TiposAltaSistema.NACIMIENTO).Id;
                        if (hembra != null)
                        {
                            txtCrotalMadre.Text = hembra.DIB;
                            Raza raza = Raza.Buscar(hembra.IdRaza);
                            if (raza != null)
                            {
                                cmbEspecie.SelectedValue = raza.IdEspecie;
                                cmbRaza.SelectedValue = raza.Id;
                            }                        
                            // Cargo el LGenealogico de la Madre                           
                            CargarLGenealogicoAnimal(new LGenealogico()
                            {
                                CIAnimal = hembra.DIB,
                                CtlAnimal = txtCrotalMadre,
                                CtlPadre = txtCrotalPadreMadre,
                                CtlMadre = txtCrotalMadreMadre,
                                CtlPadrePadre = txtCrotalAbueloPMadre,
                                CtlMadrePadre = txtCrotalAbuelaPMadre,
                                CtlPadreMadre = txtCrotalAbueloMMadre,
                                CtlMadreMadre = txtCrotalAbuelaMMadre
                            });

                        }
                        if (UltimaInseminacion!=null)
                        {
                            Animal macho = Animal.Buscar(UltimaInseminacion.IdMacho);
                            if (macho != null)
                            {
                                txtCrotalPadre.Text = macho.DIB;
                                // Cargo el LGenealogico del Padre.
                                CargarLGenealogicoAnimal(new LGenealogico()
                                {
                                    CIAnimal = macho.DIB,
                                    CtlAnimal = txtCrotalPadre,
                                    CtlPadre = txtCrotalPadrePadre,
                                    CtlMadre = txtCrotalMadrePadre,
                                    CtlPadrePadre = txtCrotalAbueloPPadre,
                                    CtlMadrePadre = txtCrotalAbuelaPPadre,
                                    CtlPadreMadre = txtCrotalAbueloMPadre,
                                    CtlMadreMadre = txtCrotalAbuelaMPadre
                                });
                            }
                        }
                    }
                }
                

                this.txtAltaFecha.Text = DateTime.Now.ToShortDateString();
            }

     
    


        protected override void CargarCombos()
        {
            this.cmbAltaTipo.CargarCombo();
            this.cmbBajaTipo.CargarCombo();         
            this.CargarCombo(cmbEspecie, "Descripcion", Configuracion.Explotacion.lstEspecies);
            this.CargarCombo(cmbTalla, "Descripcion", Talla.Buscar());
            this.CargarCombo(cmbConformacion, "Descripcion", Conformacion.Buscar());            
            this.CargarCombo(cmEstado, "Descripcion", Estado.Buscar());
            Generic.CargarComboSexos(cmbSexo);
            CargarCombosGrids();


          
            
            

        }

        public void CargarCombosGrids()
        {
          if (this.MostrarGrid &&TabControlPrincipal.TabPages.ContainsKey(tbpCanal.Name))
            {
                ///TAB CANAL:            
                this.CargarCombo(cmbTipificacionCategoria, Categoria.Buscar());
                this.CargarCombo(cmbTipificacionConformacion, ConformacionCanal.Buscar());
                this.CargarCombo(cmbEngrasamientoTipo, TipoEngrasamiento.Buscar());
            }

        }
        

        ///// <summary>
        ///// Carga del combo de Especies en funcion la la explotacion activa
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void cmbExplotacion_ClaseActivaChanged(object sender, GEXVOC.Core.Controles.ctlBuscarObjetoEventArgs e)
        //{
        //    if (e.ClaseActiva != null)
        //    {
        //        this.CargarCombo(this.cmbEspecie, "Descripcion", ((Explotacion)e.ClaseActiva).lstEspecies,true);             
        //    }
        //}

        /// <summary>
        /// Carga del combo razas en funcion de la especie activa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecie.SelectedValue != null)
            {
                ValorPredeterminadoNombreAnimal = (Configuracion.ValorPredeterminadoNombreAnimal)(Configuracion.ObtenerValorInt(Claves.ValorPredeterminadoNombreAnimal,Generic.ControlAIntNullable(cmbEspecie)) ?? 0);

                if ((int)cmbEspecie.SelectedValue == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.BOVINA).Id)
                {
                    lblDIB.Text = "CIB";
                    lblDIB.Font = new Font(lblDIB.Font, FontStyle.Bold);
                    lblCrotal.Font = new Font(lblCrotal.Font, FontStyle.Regular);
                    txtCrotal.MaxLength = 4;
                    //Generic.OcultarControl(pnlTatuaje);
                    //Generic.MostrarControl(pnlRegistroGenealogico);
                    txtRegGenealogico.Enabled = true;

                }
                else
                {
                    //Generic.MostrarControl(pnlTatuaje);
                    //Generic.OcultarControl(pnlRegistroGenealogico);                   
                    txtRegGenealogico.Enabled = false;
                    txtCrotal.MaxLength = 12;

                    if ((int)cmbEspecie.SelectedValue == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.OVINA).Id)                    
                        lblDIB.Text = "CIO";
                    if ((int)cmbEspecie.SelectedValue == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.CAPRINA).Id)
                        lblDIB.Text = "CIC";
                  
                                     
                    lblDIB.Font = new Font(lblDIB.Font, FontStyle.Regular);
                    lblCrotal.Font = new Font(lblCrotal.Font, FontStyle.Bold);
                }

                cmbRaza.CargarCombo();

              

            }
            else
            {
                this.cmbRaza.DataSource = null;
                ValorPredeterminadoNombreAnimal = Configuracion.ValorPredeterminadoNombreAnimal.Nombre;
                lblDIB.Text = "CI";
            }
            ActualizarValorNombre();

        }


        #endregion 

        #region EVENTOS CAPTURADOS



            //private void EditAnimales_Load(object sender, EventArgs e)
            //{
            //    //Por ahora ocultamos algunos tab
               
            //   // tbcContenido.TabPages.Remove(tbpLibroGenealogico);
            //    //tbcContenido.TabPages.Remove(tbpLactacion);
            //   // tbcContenido.TabPages.Remove(tbpLactacionCLechero);

                

                
            //}

        #endregion

        #region GRIDS
            

            #region CONTROLES
                void NuevoControl()
                {               
                
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        ControlLeche ObjActualizar = new ControlLeche();
                        EditControlLeche frmLanzar = new EditControlLeche(Modo.Guardar, ObjActualizar) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgControles);

                    }
                
                }
                private void ModificarControl()
                {
                    if (this.dtgControles.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {
                        ControlLeche ObjActualizar = (ControlLeche)this.dtgControles.CurrentRow.DataBoundItem;
                        EditControlLeche frmLanzar = new EditControlLeche(Modo.Actualizar, ObjActualizar) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgControles);

                    }
                }

                private void tsbNuevoControlLechero_Click(object sender, EventArgs e)
                {
                    NuevoControl();
                }
                private void tsbModificarControlLechero_Click(object sender, EventArgs e)
                {
                    ModificarControl();
                }
                private void tsbEliminarControlLechero_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgControles, "Va a eliminar el Control.\r¿Esta usted seguro de que desea continuar?");
                }
                private void dtgControles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarControl();
                }           
           #endregion

            #region LACTACION
                private void CargarLactacionExtendida()
                {
                    Lactacion lactacion = this.ObjetoBase.UltimaLactacionAbierta();
                    if (lactacion == null && this.ObjetoBase.lstLactaciones != null)
                        lactacion = (Lactacion)this.ObjetoBase.UltimaLactacion();
                    LimpiarLactacionExtendida();
                    if(lactacion!=null)
                        if (lactacion.lstLactacionExtendida.Count > 0)
                        {
                            Extendida extendida = (Extendida)lactacion.lstLactacionExtendida[0];
                            lblFecIniNorm2.Text = (lactacion.FechaInicio == null ? "" : lactacion.FechaInicio.ToShortDateString());
                            lblFecFinNorm2.Text = (lactacion.FechaFin == null ? "" : lactacion.FechaFin.Value.ToShortDateString());
                            if (extendida != null)
                            {
                                //Producción natural
                                lblProteina2.Text = (extendida.Proteina == 0 ? "" : extendida.Proteina.ToString());
                                lblExtracto2.Text = (extendida.Extracto == 0 ? "" : extendida.Extracto.ToString());
                                lblLeche2.Text = (extendida.Leche == 0 ? "" : extendida.Leche.ToString());
                                lblLactosa2.Text = (extendida.Lactosa == 0 ? "" : extendida.Lactosa.ToString());
                                lblGrasa2.Text = (extendida.Grasa == 0 ? "" : extendida.Grasa.ToString());

                                //Producción normalizada
                                lblProteinaNorm2.Text=(extendida.ProteinaNorm==0 ? "":extendida.ProteinaNorm.ToString());
                                lblExtractoNorm2.Text=(extendida.ExtractoNorm==0 ? "" :extendida.ExtractoNorm.ToString());
                                lblLecheNorm2.Text=(extendida.LecheNorm==0 ? "":extendida.LecheNorm.ToString());
                                lblLactosaNorm2.Text=(extendida.LactosaNorm==0 ? "": extendida.LactosaNorm.ToString());
                                lblGrasaNorm2.Text=(extendida.GrasaNorm==0 ? "":extendida.GrasaNorm.ToString());

                                //Producción extendida
                                lblProteina3052.Text=(extendida.ProteinaExt==0 ? "": extendida.ProteinaExt.ToString());
                                lblExtracto3052.Text=(extendida.ExtractoExt==0 ? "": extendida.ExtractoExt.ToString());
                                lblLeche3052.Text=(extendida.LecheExt==0 ? "":extendida.LecheExt.ToString());
                                lblLactosa3052.Text=(extendida.LactosaExt==0 ? "":extendida.LactosaExt.ToString());
                                lblLactosa3052.Text=(extendida.GrasaExt==0 ? "":extendida.GrasaExt.ToString());
                          
                            }
                            extendida=null;
                        }
                   lactacion=null;
                }

                /// <summary>
                /// Limpia el contenido de la lactación extendida.
                /// </summary>
                private void LimpiarLactacionExtendida()
                {
                    // Producción natural
                    lblProteina2.Text = "";
                    lblExtracto2.Text = "";
                    lblLeche2.Text = "";
                    lblLactosa2.Text = "";
                    lblGrasa2.Text = "";

                    // Producción normalizada
                    lblProteinaNorm2.Text = "";
                    lblExtractoNorm2.Text = "";
                    lblLecheNorm2.Text = "";
                    lblLactosaNorm2.Text = "";
                    lblGrasaNorm2.Text = "";

                    // Producción extendida
                    lblProteina3052.Text = "";
                    lblExtracto3052.Text = "";
                    lblLeche3052.Text = "";
                    lblLactosa3052.Text = "";
                    lblGrasa3052.Text = "";
                }

               
        

            
         
            #endregion

            #region PESOS
                private void NuevoPeso()
                {
                    if (ModoActual == Modo.Actualizar)
                    {
                        Peso ObjCrear = new Peso();                    
                        this.LanzarFormulario(new EditPesos(Modo.Guardar, ObjCrear) { ValorFijoIdAnimal = this.ObjetoBase.Id }, dtgPesos);

                    }
                }
                private void ModificarPeso()
                {
                    
                    if (this.dtgPesos.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {

                        Peso ObjActualizar = (Peso)this.dtgPesos.CurrentRow.DataBoundItem;                    
                        this.LanzarFormulario(new EditPesos(Modo.Actualizar, ObjActualizar) { ValorFijoIdAnimal = this.ObjetoBase.Id }, this.dtgPesos);



                    }
                }

                private void dtgPesos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
                {
                    ModificarPeso();
                }
                private void tsbNuevoPeso_Click(object sender, EventArgs e)
                {
                    NuevoPeso();
                }
                private void tsbModificarPeso_Click(object sender, EventArgs e)
                {
                    ModificarPeso();
                }
                private void tsbEliminarPeso_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgPesos, "Va a eliminar el Peso.\r¿Esta usted seguro de que desea continuar?");
                }
           #endregion

            #region INSEMINACIONES
                void NuevaInseminacion()
                {
                    if (ModoActual == Modo.Actualizar)
                    {
                        Inseminacion ObjetoBase = new Inseminacion();
                        EditInseminacion frmEditInseminaciones = null;

                        if (this.ObjetoBase.Sexo == Convert.ToChar("M"))
                            frmEditInseminaciones = new EditInseminacion(Modo.Guardar, ObjetoBase) { ValorFijoIdMacho = this.ObjetoBase.Id };
                        else
                            frmEditInseminaciones = new EditInseminacion(Modo.Guardar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };

                        this.LanzarFormulario(frmEditInseminaciones,dtgInseminaciones);
                    }
                }
                void ModificarInseminacion()
                {

                    if (ModoActual == Modo.Actualizar && this.dtgInseminaciones.SelectedRows.Count == 1)
                    {
                        Inseminacion ObjetoBase = (Inseminacion)this.dtgInseminaciones.CurrentRow.DataBoundItem;
                        EditInseminacion frmEditInseminaciones=null;

                          if (this.ObjetoBase.Sexo == Convert.ToChar("M"))
                              frmEditInseminaciones = new EditInseminacion(Modo.Actualizar, ObjetoBase) { ValorFijoIdMacho = this.ObjetoBase.Id };
                          else
                              frmEditInseminaciones = new EditInseminacion(Modo.Actualizar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };

                        this.LanzarFormulario(frmEditInseminaciones,dtgInseminaciones);
                    }
                }
             

                private void tsbInsertarInseminacion_Click(object sender, EventArgs e){                 
                        NuevaInseminacion();

                }
                private void dtgInseminaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarInseminacion();
                }
                private void tsbModificarInseminacion_Click(object sender, EventArgs e)
                {
                    ModificarInseminacion();
                }
                private void tsbEliminarInseminacion_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgInseminaciones, "Va a eliminar la Inseminación.\r¿Esta usted seguro de que desea continuar?");
                }
            #endregion

            #region DIAGNOSTICOS DE GESTACION
                void NuevoDiagGestacion()
                {
                    if (ModoActual == Modo.Actualizar)
                    {
                        DiagInseminacion ObjetoBase = new DiagInseminacion();
                        EditDiagInseminacion frmEditDiagInseminaciones = new EditDiagInseminacion(Modo.Guardar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };

                        this.LanzarFormulario(frmEditDiagInseminaciones, dtgDiagGestacion);
                    }
                }
                void ModificarDiagGestacion()
                {

                    if (ModoActual == Modo.Actualizar && this.dtgDiagGestacion.SelectedRows.Count == 1)
                    {
                        DiagInseminacion ObjetoBase = (DiagInseminacion)this.dtgDiagGestacion.CurrentRow.DataBoundItem;
                        EditDiagInseminacion frmEditDiagInseminaciones = new EditDiagInseminacion(Modo.Actualizar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };

                        this.LanzarFormulario(frmEditDiagInseminaciones, dtgDiagGestacion);
                    }
                }
                private void tsbNuevoDiagGestacion_Click(object sender, EventArgs e)
                {
                    NuevoDiagGestacion();
                }

                private void tsbModificarDiagGestacion_Click(object sender, EventArgs e)
                {
                    ModificarDiagGestacion();
                }

                private void tsbEliminarDiagGestacion_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgDiagGestacion, "Va a eliminar el Diagnóstico de Gestación.\r¿Esta usted seguro de que desea continuar?");
                }

                private void dtgDiagGestacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarDiagGestacion();
                }
                
                #endregion

            #region PARTOS
                private void NuevoParto()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        Parto ObjetoBase = new Parto();                       
                        EditPartos frmLanzar = new EditPartos(Modo.Guardar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgPartos);

                    }
                }
                private void ModificarParto()
                {
                    Parto ObjActualizar = null;
                    if (this.dtgPartos.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {
                        ObjActualizar = (Parto)this.dtgPartos.CurrentRow.DataBoundItem;
                        EditPartos frmLanzar = new EditPartos(Modo.Actualizar, ObjActualizar) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgPartos);
                    }
                }

                private void tsbNuevoParto_Click(object sender, EventArgs e){
                    NuevoParto();
                }         
                private void tsbModificarParto_Click(object sender, EventArgs e){
                    ModificarParto();
                }
                private void dtgPartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
                    ModificarParto();
                }
                private void tsbEliminarParto_Click(object sender, EventArgs e){
                    this.EliminarObjGrid(this.dtgPartos, "Va a eliminar el Parto.\r¿Esta usted seguro de que desea continuar?");
                }
            #endregion

            #region ABORTOS
                private void NuevoAborto()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        Aborto ObjetoBase = new Aborto();
                        EditAborto frmLanzar = new EditAborto(Modo.Guardar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgAbortos);

                    }
                }
                private void ModificarAborto()
                {
                    Aborto ObjActualizar = null;
                    if (this.dtgAbortos.SelectedRows.Count == 1 && this.ModoActual == Modo.Actualizar)
                    {
                        ObjActualizar = (Aborto)this.dtgAbortos.CurrentRow.DataBoundItem;
                        EditAborto frmLanzar = new EditAborto(Modo.Actualizar, ObjActualizar) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgAbortos);
                    }
                }

                private void dtgAbortos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarAborto();
                }
                private void tsbNuevoAborto_Click(object sender, EventArgs e)
                {
                    NuevoAborto();
                }
                private void tsbModificarAborto_Click(object sender, EventArgs e)
                {
                    ModificarAborto();
                }
                private void tsbEliminarAborto_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgAbortos, "Va a eliminar los Abortos.\r¿Esta usted seguro de que desea continuar?");
                }
            #endregion

            #region SECADOS
                private void NuevoSecado()
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        Secado ObjetoBase = new Secado();

                        EditSecados frmLanzar = new EditSecados(Modo.Guardar, ObjetoBase) { ValorFijoIdHembra=this.ObjetoBase.Id};
                        this.LanzarFormulario(frmLanzar, this.dtgSecados);

                    }
                }
                private void ModificarSecado()
                {
                    if (this.ModoActual == Modo.Actualizar && this.dtgSecados.SelectedRows.Count == 1)
                    {
                        Secado ObjetoBase = (Secado)this.dtgSecados.CurrentRow.DataBoundItem;
                        EditSecados frmLanzar = new EditSecados(Modo.Actualizar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgSecados);

                    }
                }

                private void tsbInsertarSecado_Click(object sender, EventArgs e)
                {
                    NuevoSecado();
                }
                private void tsbModificarSecado_Click(object sender, EventArgs e)
                {
                    ModificarSecado();

                }
                private void tsbEliminarSecado_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgSecados, "Va a eliminar el Secado.\r¿Esta usted seguro de que desea continuar?");
                }
                private void dtgSecados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarSecado();
                }                
            #endregion            

            #region CELOS
                private void ModificarCelo()
                {
                    if (this.ModoActual == Modo.Actualizar && this.dtgCelos.SelectedRows.Count == 1)
                    {
                        Celo ObjetoBase = (Celo)this.dtgCelos.CurrentRow.DataBoundItem;
                        EditCelo frmLanzar = new EditCelo(Modo.Actualizar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgCelos);

                    }
                }

                private void tsbNuevoCelo_Click_1(object sender, EventArgs e)
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        Celo ObjetoBase = new Celo();

                        EditCelo frmLanzar = new EditCelo(Modo.Guardar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgCelos);

                    }
                }
                private void tsbModificarCelo_Click_1(object sender, EventArgs e)
                {
                    ModificarCelo();
                }
                private void tsbEliminarCelo_Click_1(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgCelos, "Va a eliminar los Celos.\r¿Esta usted seguro de que desea continuar?");
                }
                private void dtgCelos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
                {
                    this.ModificarCelo();

                }
            #endregion

            #region SINCRONIZACION CELOS
                private void ModificarSincronizacionCelo()
                {
                    if (this.ModoActual == Modo.Actualizar && this.dtgSincronizacionCelos.SelectedRows.Count == 1)
                    {
                        SincronizacionCelo ObjetoBase = (SincronizacionCelo)this.dtgSincronizacionCelos.CurrentRow.DataBoundItem;
                        EditSincronizacionCelo frmLanzar = new EditSincronizacionCelo(Modo.Actualizar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgSincronizacionCelos);

                    }
                }

                private void tsbNuevaSincronizacion_Click(object sender, EventArgs e)
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        SincronizacionCelo ObjetoBase = new SincronizacionCelo();

                        EditSincronizacionCelo frmLanzar = new EditSincronizacionCelo(Modo.Guardar, ObjetoBase) { ValorFijoIdHembra = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgSincronizacionCelos);

                    }

                }
                private void tsbModificarSincronizacion_Click(object sender, EventArgs e)
                {
                    ModificarSincronizacionCelo();
                }
                private void tsbEliminarSincronizacion_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgSincronizacionCelos, "Va a eliminar las Sincronizaciones de Celos.\r¿Esta usted seguro de que desea continuar?");
                }
                private void dtgSincronizacionCelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                { ModificarSincronizacionCelo(); }
	        #endregion

            #region CONDICION CORPORAL
                private void ModificarCondicionCorporal()
                {
                    if (this.ModoActual == Modo.Actualizar && this.dtgCondicionCorporal.SelectedRows.Count == 1)
                    {
                        CondicionCorporal ObjetoBase = (CondicionCorporal)this.dtgCondicionCorporal.CurrentRow.DataBoundItem;
                        EditCondicionCorporal frmLanzar = new EditCondicionCorporal(Modo.Actualizar, ObjetoBase) { ValorFijoIdAnimal = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgCondicionCorporal);

                    }
                }

                private void tsbNuevaCondicionCorporal_Click(object sender, EventArgs e)
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        CondicionCorporal ObjetoBase = new CondicionCorporal();

                        EditCondicionCorporal frmLanzar = new EditCondicionCorporal(Modo.Guardar, ObjetoBase) { ValorFijoIdAnimal = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgCondicionCorporal);

                    }

                }
                private void tsbModificarCondicionCorporal_Click(object sender, EventArgs e)
                {
                    ModificarCondicionCorporal();
                }
                private void tsbEliminarCondicionCorporal_Click(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgCondicionCorporal, "Va a eliminar las condiciones corporales.\r¿Esta usted seguro de que desea continuar?");
                }
                private void dgvCondicionCorporal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarCondicionCorporal();
                }
            #endregion

            #region DIAGNÓSTICOS
                private void ModificarDiagnostico()
                {
                    if (this.ModoActual == Modo.Actualizar && this.dtgDiagnosticos.SelectedRows.Count == 1)
                    {
                        TratEnfermedad ObjetoGrid = (TratEnfermedad)this.dtgDiagnosticos.CurrentRow.DataBoundItem;
                        DiagAnimal ObjetoBase = DiagAnimal.Buscar(ObjetoGrid.IdDiagnostico);

                        EditDiagAnimal frmLanzar = new EditDiagAnimal(Modo.Actualizar, ObjetoBase) { ValorFijoIdAnimal = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgDiagnosticos);
                        
                    }
                }

                private void tsbNuevoDiagnostico_Click(object sender, EventArgs e)
                {
                    if (this.ModoActual == Modo.Actualizar)
                    {
                        DiagAnimal ObjetoBase = new DiagAnimal();

                        EditDiagAnimal frmLanzar = new EditDiagAnimal(Modo.Guardar, ObjetoBase) { ValorFijoIdAnimal = this.ObjetoBase.Id };
                        this.LanzarFormulario(frmLanzar, this.dtgDiagnosticos);

                    }

                }
              

                private void tsbModificarDiagnostico_Click_1(object sender, EventArgs e)
                {
                    ModificarDiagnostico();
                }

                private void tsbEliminarDiagnostico_Click_1(object sender, EventArgs e)
                {
                    this.EliminarObjGrid(this.dtgDiagnosticos, "Va a eliminar los tratamientos.\r¿Esta usted seguro de que desea continuar?");
                }

                private void dtgDiagnosticos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
                {
                    ModificarDiagnostico();
                }
            #endregion

       #endregion

        #region FUNCIONAMIENTO GENERAL
              
                private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
                {
                        if (cmbSexo.SelectedItem != null && ((Generic.Valores_ChrStr)cmbSexo.SelectedItem).Codigo == Convert.ToChar("M"))
                        {//es un macho
                            pnlMacho.Enabled = true;
                            pnlMacho.Visible = true;
                            
                        }
                        else
                        {
                            pnlMacho.Enabled = false;
                            pnlMacho.Visible = false;

                        }

                }            
                private void tbcContenido_Selecting(object sender, TabControlCancelEventArgs e)
                {
                    if (e.TabPage.Name == "tbpLactacion")
                        CargarLactacionExtendida();
                }

                #region Tratamiento automatico del nombre
                private void ControlesNombrePredeterminado_Validated(object sender, EventArgs e)
                {
                    if (chkNombreAutomatico.Enabled && chkNombreAutomatico.Checked)
                    {
                        switch (this.ValorPredeterminadoNombreAnimal)
                        {
                            case Configuracion.ValorPredeterminadoNombreAnimal.DIB:
                                if (sender == txtDIB)
                                    txtNombre.Text = txtDIB.Text;
                                break;
                            case Configuracion.ValorPredeterminadoNombreAnimal.Crotal:
                                if (sender == txtCrotal)
                                    txtNombre.Text = txtCrotal.Text;
                                break;
                            case Configuracion.ValorPredeterminadoNombreAnimal.Tatuaje:
                                if (sender == txtTatuaje)
                                    txtNombre.Text = txtTatuaje.Text;
                                break;
                        }
                    }
                }

                private void chkNombreAutomatico_CheckedChanged(object sender, EventArgs e)
                {
                    ActualizarValorNombre();

                }

                private void ActualizarValorNombre()
                {
                    txtNombre.ReadOnly = chkNombreAutomatico.Checked;
                    Control control = null;

                    if (chkNombreAutomatico.Checked)//Si lo cambio a modo checked, ejecuto el validated del control correspondiente.
                    {
                        switch (this.ValorPredeterminadoNombreAnimal)
                        {
                            case Configuracion.ValorPredeterminadoNombreAnimal.DIB:
                                control = txtDIB;
                                break;
                            case Configuracion.ValorPredeterminadoNombreAnimal.Crotal:
                                control = txtCrotal;
                                break;
                            case Configuracion.ValorPredeterminadoNombreAnimal.Tatuaje:
                                control = txtTatuaje;
                                break;
                        }

                        ControlesNombrePredeterminado_Validated(control, null);
                    }
                }

                #endregion

                #region Mostrar/Ocultar Grid
                public bool MostrarGrid
                {
                    get
                    {
                        return this.Controls.ContainsKey(tbcContenido.Name);
                    }
                    set
                    {
                        if (value != this.MostrarGrid)
                        {
                            if (value)
                            {
                                if (tbcContenido.TabCount>0)
                                {
                                    this.Controls.Add(tbcContenido);
                                    Generic.EliminarAutogenerateColumns(this);
                                    CargarCombosGrids();
                                    CargarGrids();
                                    Application.DoEvents();
                                    this.Size = new Size(735, 775);
                                    this.btnMostrarGrid.Visible = false;
                                    this.btnMostrarGrid.Enabled = false;
                                    Application.DoEvents();    
                                }
                            }
                            else
                            {
                                this.Controls.Remove(tbcContenido);
                                this.Size = new Size(735, 475);
                                Application.DoEvents();
                            }
                        }
                    }
                }
                private void btnMostrarGrid_Click(object sender, EventArgs e)
                {
                        this.IniciarEspera();
                        MostrarGrid = !MostrarGrid;
                        this.FinalizarEspera();
                        
                    
                }
                #endregion
                
        #endregion        

        #region PROPIEDADES PARA PROCESOS

            [ProcesoDescripcion("Edición de Animales - Muestra las pestañas: Celos, Inseminaciones, Partos y Pesos","Reproducción")]
            public bool _proceso_Reproduccion
            {
                set
                {
                    if (!value)
                    {
                        tbcContenido.TabPages.Remove(tbpCelos);
                        tbcContenido.TabPages.Remove(tbpInseminaciones);
                        tbcContenido.TabPages.Remove(tbpPartos);
                        tbcContenido.TabPages.Remove(tbpPesos);
                    }

                }
            }
            [ProcesoDescripcion("Edición de Animales - Muestra las pestañas: Condición Corporal y Canal","Producción de Carne")]
            public bool _proceso_ProducionCarne
            {
                set
                {
                    if (!value)
                    {
                      
                        tbcContenido.TabPages.Remove(tbpCondicionCorporal);
                        tbcContenido.TabPages.Remove(tbpCanal);
                    }

                }
            }
            [ProcesoDescripcion("Edición de Animales - Muestra las pestañas: Lactación, Controles y Secados","Producción de Leche")]
            public bool _proceso_ProducionLeche
            {
                set
                {
                    if (!value)
                    {
                        tbcContenido.TabPages.Remove(tbpLactacion);
                        tbcContenido.TabPages.Remove(tbpControles);
                        tbcContenido.TabPages.Remove(tbpSecados);
                    }

                }
            }
            [ProcesoDescripcion("Edición de Animales - Muestra la pestaña: Libro Genealógico","Genealogía")]
            public bool _proceso_Genealogia
            {
                set
                {
                    if (!value)
                    {
                        tbcContenido.TabPages.Remove(tbpLibroGenealogico);
                    }

                }
            }
            [ProcesoDescripcion("Edición de Animales - Muestra la pestaña: Diagnósticos","Sanidad")]
            public bool _proceso_Sanidad
            {
                set
                {
                    if (!value)
                    {
                        tbcContenido.TabPages.Remove(tbpDiagnosticos);
                    }

                }
            }

        #endregion       

        #region COMBOS
            private void cmbRaza_CargarContenido(object sender, EventArgs e)
            {
                if (this.cmbEspecie.SelectedValue != null)
                    this.CargarCombo(this.cmbRaza, "Descripcion", Raza.Buscar(string.Empty, Generic.ControlAIntNullable(cmbEspecie)));
                else
                    this.cmbRaza.DataSource = null;

                this.cmbRaza.Text = string.Empty;
                this.cmbRaza.SelectedIndex = -1;
            }

            private void cmbRaza_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {
                int? IdEspecie = Generic.ControlAIntNullable(cmbEspecie);
                if (IdEspecie.HasValue)
                {
                    Raza ObjetoBase = new Raza();
                    EditRazas editRaza = new EditRazas(Modo.Guardar, ObjetoBase);
                    editRaza.ValorEspecieFijo = IdEspecie;
                    editRaza.Descripcion = e.TextoCrear;

                    CrearNuevoElementoCombo(editRaza, sender);
                }
                else
                    Generic.PonerError(this.ErrorProvider, cmbRaza, "Para poder crear una Raza es necesario tener seleccionada la Especie.");

            }

            private void cmbAltaTipo_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbAltaTipo, "Descripcion", TipoAlta.Buscar());          
            }

            private void cmbAltaTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {

                TipoAlta ObjetoBase = new TipoAlta();
                EditTipoAlta editAlta = new EditTipoAlta(Modo.Guardar, ObjetoBase);
                editAlta.Descripcion = e.TextoCrear;
                CrearNuevoElementoCombo(editAlta, sender);
            }

            private void cmbBajaTipo_CargarContenido(object sender, EventArgs e)
            {
                this.CargarCombo(cmbBajaTipo, "Descripcion", TipoBaja.Buscar());
            }

            private void cmbBajaTipo_CrearNuevo(object sender, GEXVOC.Core.Controles.ctlComboCrearNuevoEventArgs e)
            {

                TipoBaja ObjetoBase = new TipoBaja();
                EditTipoBaja editBaja = new EditTipoBaja(Modo.Guardar, ObjetoBase);
                editBaja.Descripcion = e.TextoCrear;

                CrearNuevoElementoCombo(editBaja, sender);

                

            }
        #endregion

           
         
    }
}
