using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using GEXVOC.Core.Data;
using GEXVOC.Core.Clases;


namespace GEXVOC.Core.Logic
{
    public partial class Animal:IClaseBase
    {

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)
        /// <summary>
        /// Obtiene un animal a partir de su Id
        /// </summary>
        /// <param name="id">Identificador de la tabla</param>
        /// <returns>Animal</returns>

        public static Animal Buscar(int id)
        {
            return AnimalData.GetAnimal(id);
        }
        public static Animal BuscarOP(int id)
        {
            return AnimalData.GetAnimalOP(id);
        }
        public static Animal Buscar(string DIB)
        {
            return AnimalData.GetAnimal(DIB);
        }
        public static List<Animal> Buscar(string crotal, int? idRaza)
        {
            return AnimalData.GetAnimales(null,   idRaza, null, null, null, null, string.Empty, crotal, string.Empty, string.Empty, null, null, null, null,null,null);
        }

        public static List<Animal> BuscarTodos(string CI, string crotal, string nombre)
        {
            return AnimalData.GetAnimales( CI,  crotal,   nombre);
        }
        public static List<Animal> Buscar(int? idExplotacion, int? idEspecie, Boolean? mostrarBajas)
        {
            return AnimalData.GetAnimales(idExplotacion, idEspecie, mostrarBajas);
        }
        public static List<Animal> Buscar(int? idExplotacion, int? idEspecie,
                                               string nombre, string tatuaje, string crotal,
                                               string CI, int? idEstado, char? sexo, bool? externo)
        {
            return AnimalData.GetAnimales(idExplotacion, idEspecie, nombre, tatuaje, crotal, CI, idEstado, sexo, externo);
        }
    


        /// <summary>
        /// Obtiene un animal de acuerdo con los parametros establecidos
        /// </summary>
        /// <param name="explotacion"></param>
        /// <param name="crotal"></param>
        /// <param name="raza"></param>
        /// <param name="fechanacimiento"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static List<Animal> Buscar(int? id,   int? idRaza, int? idEstado, int? idTalla, int? idConformacion, int? idExplotacion, string DIB,
                                               string crotal, string tatuaje, string nombre, DateTime? fechaNacimiento, char? sexo, Boolean? testaje,
                                               Boolean? aptoNovillas,bool? mostrarBajas,int? idEspecie)
        {
            return AnimalData.GetAnimales(id,   idRaza, idEstado, idTalla, idConformacion, idExplotacion,  DIB, crotal, tatuaje,nombre, fechaNacimiento, sexo, testaje,
                                            aptoNovillas, mostrarBajas, idEspecie);
        }
        //public static List<Animal> Buscar(Explotacion explotacion, string crotal, Raza raza, Nullable<DateTime> fechanacimiento, string nombre,char? Sexo)
        //{
        //    int? idExplotacion = null;
        //    int? idRaza = null;
        //    if (explotacion != null)
        //        idExplotacion = explotacion.Id;
        //    if (raza != null)
        //        idRaza = raza.Id;


        //    return AnimalData.GetAnimales(idExplotacion, crotal, idRaza, fechanacimiento, nombre,null,Sexo);
        //}

        //public static List<Animal> Buscar(int? idAlta, int? idBaja, int? idRaza, int? idExplotacion, int? idLote)
        //{
        //    return AnimalData.GetAnimales(idAlta, idBaja, idRaza, idExplotacion, idLote);
        //}
        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno=null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Animal();//Es una insercion
                    break;
                case TipoContexto.Modificacion:
                    rtno = AnimalData.GetAnimalOP(this.Id);//Es una modificacion
                    break;               
            }
            return rtno;

        }

        //public static List<Animal> Buscar(int? idEspecie, int? idRaza, int? idExplotacion, string DIB,
        //                                       string crotal, string nombre, DateTime? fechaNacimiento, char? sexo)
        //{
        //    return AnimalData.GetAnimales(id, idAlta, idBaja, idRaza, idEstado, idTalla, idConformacion, idExplotacion, DIB, crotal, tatuaje, nombre, fechaNacimiento, sexo, testaje,
        //                                    aptoNovillas, imagen, fechaAlta, fechaBaja);
        //}

        #endregion

        #region  ACTUALIZACIÓN DE DATOS
            /// <summary>
            /// Guarda el animal.
            /// </summary>
            public void Insertar()
            {
                ValidarLogica(TipoOperacion.Insercion);
                //si no se ha especificado explotación, le asigno la explotación de configuración.
                if (this.IdExplotacion==0)                
                    this.IdExplotacion = Configuracion.Explotacion.Id;
                
                AnimalData.Insertar(this);
            }

            /// <summary>
            /// Actualiza el animal.
            /// </summary>
            public void Actualizar()
            {
                ValidarLogica(TipoOperacion.Actualizacion);
                AnimalData.Actualizar(this);
            }

            /// <summary>
            /// Elimina el animal.
            /// </summary>
            public void Eliminar()
            {
                ValidarLogica(TipoOperacion.Borrado);

                     Boolean TransacionPropia = false;

                     try//Iniciando la logica de negocio en el borrado.
                     {
                         TransacionPropia = BDController.IniciarTransaccion();
                         
                         ////Eliminar Morfologia
                         //Morfologia morfologiaEliminar = this.MorfologiaAnimal();
                         //if (morfologiaEliminar!=null)
                         //   morfologiaEliminar.Eliminar();
                         Alta alta = this.AltaAnimal();
                         if (alta!=null)
                            alta.Eliminar();

                         Baja Baja = this.BajaAnimal();
                         if (Baja != null)
                             Baja.Eliminar();

                         RendimientoCanal RendimientoCanal = this.RendimientoCanalAnimal();
                         if (RendimientoCanal != null)
                             RendimientoCanal.Eliminar();
                         TipificacionCanal TipificacionCanal = this.TipificacionCanalAnimal();
                         if (TipificacionCanal != null)
                             TipificacionCanal.Eliminar();
                         EngrasamientoCanal EngrasamientoCanal = this.EngrasamientoCanalAnimal();
                         if (EngrasamientoCanal != null)
                             EngrasamientoCanal.Eliminar();


                         LibroGenealogico libroAnimal = this.LibroAnimal();
                         if (libroAnimal != null)
                             libroAnimal.Eliminar();

                                                  
                         ////Eliminar partos
                         //List<Parto> lstPartos = this.lstPartos;
                         //foreach (Parto item in lstPartos)
                         //    item.Eliminar();
                         
                         ////Eliminar lactaciones
                         //List<Lactacion> lstLactacion = Lactacion.Buscar(this.Id, null, null, null);
                         //foreach (Lactacion item in lstLactacion)                     
                         //    item.Eliminar();
                         

                         //Eliminar pesos
                         List<Peso> lstPeso = this.lstPesos;
                         foreach (Peso item in lstPeso)                     
                             item.Eliminar();

                         //Eliminar CondicioneCorporales
                         List<CondicionCorporal> lstCondicionCorporal = this.lstCondicionesCorporales;
                         foreach (CondicionCorporal item in lstCondicionCorporal)
                             item.Eliminar();


                         
                         AnimalData.Eliminar(this);

                         if (TransacionPropia)
                             BDController.FinalizarTransaccion(true);
                     }
                     catch (Exception ex)
                     {

                         if (TransacionPropia)
                             BDController.FinalizarTransaccion(false);

                         Traza.RegistrarError(ex);
                         throw new LogicException(ex.Message);
                     }
                       
                      
                        

              
            }
        #endregion

        #region PROPIEDADES PERSONALIZADAS

            #region VALORES DE CONFIGURACION
            public int MinimoGestacion
            {
                get
                {
                    Raza raza = Raza.Buscar(IdRaza);
                    return Configuracion.MinimoGestacion(raza.IdEspecie);

                }

            }
            public int MaximoGestacion
            {
                get
                {
                    Raza raza = Raza.Buscar(IdRaza);
                    return Configuracion.MaximoGestacion(raza.IdEspecie);

                }

            }
            public int PeriodoPostParto
            {
                get
                {
                    Raza raza = Raza.Buscar(IdRaza);
                    return Configuracion.PeriodoPostParto(raza.IdEspecie);

                }

            }
            public int IntervaloCelosFin
            {
                get
                {
                    Raza raza = Raza.Buscar(IdRaza);
                    return Configuracion.IntervaloCelosFin(raza.IdEspecie);

                }

            }
            public int IntervaloCelosInicio
            {
                get
                {
                    Raza raza = Raza.Buscar(IdRaza);
                    return Configuracion.IntervaloCelosInicio(raza.IdEspecie);

                }

            }

            public int SecadoNormalEstimado
            {
                get
                {
                    Raza raza = Raza.Buscar(IdRaza);
                    return Configuracion.SecadoNormalEstimado(raza.IdEspecie);
                }

            }

            public int SecadoAbortoConLactacion
            {
                get
                {
                    Raza raza = Raza.Buscar(IdRaza);
                    return Configuracion.SecadoAbortoConLactacion(raza.IdEspecie);

                }

            }
            public int SecadoDiasVaciones
            {
                get
                {
                    Raza raza = Raza.Buscar(IdRaza);
                    return Configuracion.SecadoDiasVacaciones(raza.IdEspecie);
                }

            }
            #endregion

            #region FOTOGRAFÍA
            public System.Data.Linq.Binary ImagenAsociada { get; set; }
            System.Data.Linq.Binary _ImagenCargada = null;
            public System.Data.Linq.Binary ImagenCargada
            {
                get
                {
                    if (_ImagenCargada != null)
                        return _ImagenCargada;
                    else
                    {
                        if (this.IdFotografia.HasValue)
                        {
                            Fotografia fotografia = Fotografia.Buscar((int)this.IdFotografia);
                            if (fotografia != null && fotografia.Imagen != null)
                                _ImagenCargada = fotografia.Imagen;
                        }
                    }
                    return _ImagenCargada;
                }
            }
            #endregion

        
            public string DescRaza
            {
                get
                {
                    string rtno=string.Empty;

                    if (this != null && this.Raza != null)                   
                        rtno= this.Raza.Descripcion;

                    return rtno;
                }
            }
            public string DescEspecie
            {
                get
                {
                    string rtno = string.Empty;

                    if (this != null && this.Raza != null && this.Raza.Especie != null)
                        rtno = this.Raza.Especie.Descripcion;

                    return rtno;
                    
                }
            }
            public string DescExplotacion
            {
                get
                {
                    string rtno = string.Empty;

                    if (this != null && this.Explotacion != null)
                        rtno = this.Explotacion.Nombre;

                    return rtno;

                }
            }

            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Talla a la que pertenece el elemento
            ///// </summary>
            public string DescTalla
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Talla != null)
                        rtno = this.Talla.Descripcion;

                    return rtno;
                }
            }

            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Conformacion a la que pertenece el elemento
            ///// </summary>
            public string DescConformacion
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Conformacion != null)
                        rtno = this.Conformacion.Descripcion;

                    return rtno;
                }
            }

            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la IdEspecie a la que pertenece el elemento
            ///// </summary>
            public int? DescIdEspecie
            {
                get
                {
                    int? rtno = null;
                    Raza raza = Raza.Buscar(this.IdRaza);
                    if (this != null && raza != null)
                        rtno = raza.IdEspecie;

                    return rtno;
                }
            }
            /// <summary>
            /// Propiedad que devuelve la descripción del estado del animal.
            /// </summary>
            public string DescEstado
            {
                get 
                {
                    string rtno = string.Empty;
                    if (this != null && this.Estado != null)
                        rtno = this.Estado.Descripcion;
                    return rtno;
                }
            }
            public string Identificador
            {
                get {
                    string identificador = this.DIB;

                    Raza raza = Raza.Buscar(this.IdRaza);                 
                    if (raza!=null)
                    {
                        try
                        {
                            if (raza.IdEspecie == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.BOVINA).Id)
                                identificador = this.DIB;
                            else
                                identificador = this.Crotal;
                        }
                        catch (Exception)
                        {
                            identificador = this.DIB;
                        }              
                        
                    }

                    return identificador;
                
                }
            }

            bool _EnSeleccion;

            public bool EnSeleccion
            {
                get { return _EnSeleccion; }
                set { _EnSeleccion = value; }
            }

            /// <summary>
            /// Propiedad que nos proporciona la ultima fecha en la que el animal actual ha tenido un parto o un aborto.
            /// Si el animal no ha tenido ni partos ni abortos retorna null.
            /// </summary>
            public DateTime? UltimaFechaParto_Aborto(int idHembra)
            {
                 Animal animal = Animal.Buscar(idHembra);
              
                  DateTime? rtno = null;

                  Parto UltimoParto = animal.UltimoParto();
                  Aborto UltimoAborto = animal.UltimoAborto();

                  if (UltimoParto != null && UltimoAborto != null)//Tiene partos y abortos
                  {
                      if (UltimoParto.Fecha > UltimoAborto.Fecha)//La ultima fecha se corresponde con la del parto
                          rtno = UltimoParto.Fecha;
                      else//La ultima fecha se corresponde con la del aborto
                          rtno = UltimoAborto.Fecha;

                  }
                  else if (UltimoParto != null)//Solo tiene partos	            
                      rtno = UltimoParto.Fecha;
                  else if (UltimoAborto != null)//Solo tiene abortos	            
                      rtno = UltimoAborto.Fecha;

                  return rtno;                             
            }
            
            /// <summary>
            /// Propiedad que nos proporciona la ultima fecha en la que el animal actual ha tenido un Inseminacion o un Cubricion.
            /// Si el animal no ha tenido ni Inseminacions ni Cubricions retorna null.
            /// Si el último elemento es una cubrición y no tiene fecha fin, la variable por referencia cubricionAbierta valdrá true.
            /// </summary>
            public DateTime? UltimaFechaInseminacion_Cubricion(int idHembra,ref bool cubricionAbierta)
            {
                cubricionAbierta = false;
                Animal animal = Animal.Buscar(idHembra);

                DateTime? rtno = null;

                Inseminacion UltimaInseminacion = animal.UltimaInseminacion();
                Cubricion UltimaCubricion = animal.UltimaCubricion();

                if (UltimaInseminacion != null && UltimaCubricion != null)//Tiene Inseminacions y Cubricions
                {
                    if (UltimaInseminacion.Fecha > UltimaCubricion.FechaInicio)//La ultima fecha se corresponde con la del Inseminacion                 
                        rtno = UltimaInseminacion.Fecha;
                    else//La ultima fecha se corresponde con la del Cubricion
                    {
                        rtno = UltimaCubricion.FechaInicio;
                        if (UltimaCubricion.FechaFin == null)
                            cubricionAbierta = true;
                         
                    }

                }
                else if (UltimaInseminacion != null)//Solo tiene Inseminacions	            
                    rtno = UltimaInseminacion.Fecha;
                else if (UltimaCubricion != null)//Solo tiene Cubriciones	            
                {
                    rtno = UltimaCubricion.FechaInicio;
                    if (UltimaCubricion.FechaFin == null)
                        cubricionAbierta = true;
                }
                       

                return rtno;
            } 
         
            /// <summary>
            /// Obtiene si el animal tiene un parto porterior a la fecha del evento.
            /// </summary>
            /// <param name="idAnimal">Animal</param>
            /// <param name="fecha">Fecha</param>
            /// <returns></returns>
            public static bool TienePartoPosterior(int idAnimal, DateTime fecha)
            {
                bool rtno = false;
                Animal animal = new Animal();
                animal.Id = idAnimal;
                animal.CargarContextoOperacion(TipoContexto.Modificacion);

                List<Parto> lstParto = animal.lstPartos;
                if (lstParto!=null)                
                    rtno= lstParto.Where(E => E.Fecha >= fecha).Count() != 0;
                //if (lstParto != null)
                //{
                //    foreach (Parto item in lstParto)
                //        if (item.Fecha >= fecha)
                //        {
                //            rtno = true;
                //            break;
                //        }
                //}

                //animal = null;
                return rtno;

            }
            /// <summary>
            /// Obtiene si el animal tiene un Aborto porterior a la fecha del evento.
            /// </summary>
            /// <param name="idAnimal">Animal</param>
            /// <param name="fecha">Fecha</param>
            /// <returns></returns>
            public static bool TieneAbortoPosterior(int idAnimal, DateTime fecha)
            {
                bool rtno = false;
                Animal animal = new Animal();
                animal.Id = idAnimal;
                animal.CargarContextoOperacion(TipoContexto.Modificacion);

                List<Aborto> lstAborto = animal.lstAbortos;
                if (lstAborto!=null)                
                    rtno= lstAborto.Where(E => E.Fecha >= fecha).Count() != 0;

                //if (lstAborto != null)
                //{
                //    foreach (Aborto item in lstAborto)
                //        if (item.Fecha >= fecha)
                //        {
                //            rtno = true;
                //            break;
                //        }
                //}

              //  animal = null;
              return rtno;

            }
            /// <summary>
            /// Obtiene si el animal tiene un control posterior a la fecha del evento.
            /// </summary>
            /// <param name="idAnimal">Animal</param>
            /// <param name="fecha">Fecha</param>
            /// <returns></returns>
            public static bool TieneControlPosterior(int idAnimal, DateTime fecha)
            {
                bool rtno = false;
                Animal animal = new Animal();
                animal.Id = idAnimal;
                animal.CargarContextoOperacion(TipoContexto.Modificacion);
                List<ControlLeche> lstUltimosControles = animal.lstControlesUltimaLactacion;

                if (lstUltimosControles!=null)                
                    rtno= lstUltimosControles.Where(E => E.Fecha >= fecha).Count() != 0;
                //animal = null;
                return rtno;
            }
            /// <summary>
            /// Obtiene si el animal tiene un secado porterior a la fecha del evento.
            /// </summary>
            /// <param name="idAnimal">Animal</param>
            /// <param name="fecha">Fecha</param>
            /// <returns></returns>
            public static bool TieneSecadoPosterior(int idAnimal, DateTime fecha)
            {
                bool rtno = false;
                Animal animal = new Animal();
                animal.Id = idAnimal;
                animal.CargarContextoOperacion(TipoContexto.Modificacion);

                List<Secado> lstSecado = animal.lstSecados;
                if (lstSecado!=null)                
                    rtno= lstSecado.Where(E => E.Fecha >= fecha).Count() != 0;
                ////if (lstSecado != null)
                ////{
                ////    foreach (Secado item in lstSecado)
                ////        if (item.Fecha >= fecha)
                ////        {
                ////            rtno = true;
                ////            break;
                ////        }
                ////}

               // animal = null;
                return rtno;

            }
            public static bool TieneDiagnosticoPosterior(int idAnimal, DateTime fecha)
            {
                bool rtno = false;
                Animal animal = new Animal();
                animal.Id = idAnimal;
                animal.CargarContextoOperacion(TipoContexto.Modificacion);

                List<DiagInseminacion> lstdiag = animal.lstDiagGestacion;
                if (lstdiag!=null)                
                    rtno= lstdiag.Where(E => E.Fecha >= fecha).Count() != 0;

                return rtno;
          

            }

            /// <summary>       
            /// Nos indica mediante un valor booleano si el animal se encuentra enfermo o no.        
            /// </summary>
            /// <param name="idAnimal">Identificador del animal</param>
            /// <param name="fecha">fecha consulta</param>
            /// <returns></returns>
            public static bool AnimalEnfermo(int idAnimal, DateTime fecha)
            {
                DateTime? fechaInicio=null, fechaFin=null;
                return AnimalEnfermo(idAnimal, fecha, ref fechaInicio, ref fechaFin);       
              
            
            }
            /// <summary>
            /// Nos indica mediante un valor booleano si el animal se encuentra enfermo o no.  
            /// </summary>
            /// <param name="idAnimal"></param>
            /// <param name="fecha"></param>
            /// <param name="fechaInicio">Nos retorna por referencia el valor de la fecha de inicio del tratamiento en el que se encuentra el animal correspondiente a la fecha proporcionada.</param>
            /// <param name="fechaFin">Nos retorna por referencia el valor de la fecha fin del tratamiento en el que se encuentra el animal correspondiente a la fecha proporcionada.</param>
            /// <returns></returns>
            public static bool AnimalEnfermo(int idAnimal, DateTime fecha,ref DateTime? fechaInicio,ref DateTime? fechaFin)
            {
                bool rtno = false;
                fechaInicio = null;
                fechaFin = null;

                Animal animal = Animal.Buscar(idAnimal);
                if (animal != null)
                {
                    List<TratEnfermedad> lstTratamientos = animal.lstTratamientos;
                    if (lstTratamientos != null && lstTratamientos.Count > 0)
                    {
                        foreach (TratEnfermedad item in lstTratamientos)
                        {
                            try
                            {
                                if (fecha.Date >= item.Fecha.Date & fecha.Date <= item.Fecha.Date.AddDays(item.Duracion))
                                {
                                    fechaInicio = item.Fecha.Date;
                                    fechaFin = item.Fecha.Date.AddDays(item.Duracion);

                                    rtno = true;
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {

                                Traza.RegistrarError(ex);
                            }
                            
                        }
                    }
                }

                return rtno;

            }

            /// <summary>
            /// Un animal se dice que ha estado enfermo entre fechas, si tuvo algún tratamiento entre dichas fechas
            /// </summary>
            /// <param name="idAnimal"></param>
            /// <param name="fechaInicio"></param>
            /// <param name="fechaFin"></param>
            /// <returns></returns>
            public static bool AnimalEnfermoEntreFechas(int idAnimal, DateTime? fechaInicio,DateTime? fechaFin)
            {
                bool rtno = false;
                List<TratEnfermedad> lstTratamientos = Logic.TratEnfermedad.Buscar(idAnimal, null, null,null,null,null,fechaInicio, fechaFin, null);
                if (lstTratamientos.Count > 0)               
                    rtno=true;
                return rtno;
            }          
          



       #endregion

        #region FUNCIONALIDAD AÑADIDA
            //Puede contener propiedades o funciones tipicas de la instancia de Aninal
        //Estos elementos proveen de nuevas características.

            public List<Celo> lstCelos
            {
                get { return Logic.Celo.Buscar(this.Id,null,null); }

            }
            public List<Inseminacion> lstInseminaciones
            {
                get {
                    List<Inseminacion> rdo = null;
                    if (this.Sexo==Convert.ToChar("M"))
                        rdo = InseminacionData.GetInseminaciones(this.Id, null,  null, null, null, null, null, null); 
                    else
                        rdo = InseminacionData.GetInseminaciones(null, this.Id,  null, null, null, null, null, null);

                    return rdo;
                
                }

            }
            public List<SincronizacionCelo> lstSincronizacionCelos
            {
                get { return Logic.SincronizacionCelo.Buscar(this.Id, null, null, null, null, null); }

            }
            public List<DiagInseminacion> lstDiagGestacion
            {
                get
                {
                    List<DiagInseminacion> rdo = null;
                    rdo = Logic.DiagInseminacion.Buscar(this.Id, null, null, null, null);

                    return rdo;

                }

            }

            public List<Parto> lstPartos
            {
                get { return Logic.Parto.Buscar(this.Id, null, null, null, null, null, null, null); }

            }
            public List<Aborto> lstAbortos
            {
                get { return Logic.Aborto.Buscar(this.Id, null, null); }

            }
            /// <summary>
            /// Nos retorna la colección de los controles que se le han hecho a este animal, siempre teniedo en cuenta
            /// Su última lactación y que esté abierta.
            /// </summary>
            /// <returns></returns>
            public List<ControlLeche> lstControlesUltimaLactacion
            {
                get
                {
                    List<ControlLeche> lstRtno = null;

                    Lactacion ultimaLactacion = LactacionData.GetLactacioAbierta(this.Id);
                    if (ultimaLactacion != null)
                    {
                        lstRtno = ultimaLactacion.lstControlesLeche;
                    }

                    return lstRtno;

                }
            }
            public List<Secado> lstSecados
            {
                get { return SecadoData.GetSecados( null, null,this.Id, null, null); }

            }
            public List<Peso> lstPesos
            {
                get { return Logic.Peso.Buscar(this.Id, null, null, null, null); }

            }
            public List<CondicionCorporal> lstCondicionesCorporales
            {
                get { return Logic.CondicionCorporal.Buscar(this.Id,null,null); }

            }

            public List<Cubricion> lstCubriciones
            {
                get
                {
                    return AnimalData.GetCubriciones(this.Id);
                }

            }

            public List<AniLot> lstAniLot
            {
                get { return Logic.AniLot.Buscar(null,this.Id,null,null); }

            }

            public List<LoteAnimal> lstLotes
            {
                get
                {
                    return AnimalData.GetLotes(this.Id);
                }

            }
            /// <summary>
            /// Devuelve el listado de asignaciones alimenticias de cada animal.
            /// </summary>
            public List<Asignacion> lstAsignacion
            {
                get
                {
                    return Logic.Asignacion.Buscar(null, this.Id, null, null, null, null);
                }
            
            }
            /// <summary>
            /// Lista de lactaciones asociadas a una hembra.
            /// </summary>
            public List<Lactacion> lstLactaciones
            {
                get
                {
                    return Logic.Lactacion.Buscar(this.Id, null, null, null);
                }
            
            }

            public List<DiagAnimal> lstDiagnosticos
            {
                get { return Logic.DiagAnimal.Buscar(this.Id, null,null,null,null); }

            }
            public List<TratEnfermedad> lstTratamientos
            {
                get
                {
                    return AnimalData.GetTratamientos(this.Id);
                }

            }

            public List<Animal> lstHijos
            {
                get
                {
                    return AnimalData.GetHijos(this.DIB);
                }
            }

            public Inseminacion UltimaInseminacion()
            {
                Inseminacion rtno = null;
                try
                {
                    if (lstInseminaciones.Count > 0)
                        rtno = lstInseminaciones.OrderByDescending(p => p.Fecha).First();
                }
                catch (Exception)
                { }

                return rtno;
            }
            public Parto UltimoParto()
            {
                Parto rtno=null;
                try 
	            {	        
                    if (lstPartos.Count>0)
                        rtno=lstPartos.OrderByDescending(p=>p.Fecha).First();        		
	            }
	            catch (Exception)
	            {}
                
                return rtno;
            }
            public Aborto UltimoAborto()
            {
                Aborto rtno = null;
                try
                {
                    if (lstAbortos.Count > 0)
                        rtno = lstAbortos.OrderByDescending(p => p.Fecha).First();
                }
                catch (Exception)
                { }

                return rtno;
            }

            public DiagAnimal UltimoDiagnosticoAnimal()
            {
                DiagAnimal rtno = null;
                try
                {
                    if (lstDiagnosticos.Count > 0)
                        rtno = lstDiagnosticos.OrderByDescending(p => p.Fecha).First();
                }
                catch (Exception)
                { }
                return rtno;
            
            }
            public Aborto UltimoAbortoConLactacion()
            {
                Aborto rtno = null;
                try
                {
                    Aborto ultimoaborto = UltimoAborto();
                    //TipoAborto tipoAborto = new TipoAborto();
                    //tipoAborto = Configuracion.TipoAbortoSistema(Configuracion.TiposAbortosSistema.ABORTO_SEGUIDO_DE_NUEVA_LACTACIÓN);
                    if (ultimoaborto.IdTipo == Configuracion.TipoAbortoSistema(Configuracion.TiposAbortosSistema.ABORTO_SEGUIDO_DE_NUEVA_LACTACIÓN).Id ||
                        ultimoaborto.IdTipo == Configuracion.TipoAbortoSistema(Configuracion.TiposAbortosSistema.ABORTO_CONTINUANDO_LACTACIÓN).Id)
                        rtno = ultimoaborto;
                }
                catch (Exception)
                { }
                return rtno;
            }
            public Lactacion UltimaLactacion()
            {
                return LactacionData.GetUltimaLactacion(this.Id);
            }
            public Lactacion UltimaLactacionAbierta()
            { return LactacionData.GetLactacioAbierta(this.Id); }
            public Secado UltimoSecado()
            {
                Secado rtno = null;
                try
                {
                    if (lstPartos.Count > 0)
                        rtno = lstSecados.OrderByDescending(p => p.Fecha).First();
                }
                catch (Exception)
                { }

                return rtno;
            }

            public LoteAnimal UltimoLote()
            {
                LoteAnimal rtno = null;
                AniLot anilot = null;
                try
                {
                    
                    if (lstAniLot.Count > 0)
                    {
                        //try//Primero cojo el que tiene fecha fin nulo (Es el ultimo lote)
                        //{
                        //     anilot = lstAniLot.Where(E => E.FechaFin == null).First();                         
                        //}
                        //catch (InvalidOperationException)
                        //{}

                        ////Si no existe ningun lote con fecha fin cojo el de mayor fecha
                        //if (anilot == null)                        
                             anilot = lstAniLot.OrderByDescending(p => p.FechaInicio).First();
                           
                            
                        
                        
                    }


                }
                catch (Exception)
                { }

                if (anilot!=null)
                    rtno = LoteAnimal.Buscar(anilot.IdLote);

                return rtno;
            }

            public Cubricion UltimaCubricion()
            {
                LoteAnimal lote = this.UltimoLote();
                Cubricion rtno = null;
                try
                {
                    rtno = lote.UltimaCubricion();
                }
                catch (Exception)
                { }                
                return rtno;
            }


            public IClaseBase UltimaInseminacion_Cubricion()
            {
                
                Inseminacion UltimaInseminacion = this.UltimaInseminacion();
                Cubricion UltimaCubricion = this.UltimaCubricion();
                IClaseBase rtno = null;
                if (UltimaCubricion != null && UltimaInseminacion != null)
                {//Tiene inseminaciones y cubriciones
                    if (UltimaInseminacion.Fecha > UltimaCubricion.FechaInicio)
                        rtno = UltimaInseminacion;
                    else
                        rtno = UltimaCubricion;

                }
                else if (UltimaInseminacion != null)//Solo tiene inseminaciones                                    
                    rtno = UltimaInseminacion;
                else if (UltimaCubricion != null)//Solo tiene cubriciones                                    
                    rtno = UltimaCubricion;

                return rtno;
            }

            
        
            

            public Baja BajaAnimal()
            {
                Baja rtno = null;

                try
                {
                    rtno=Logic.Baja.BuscarAnimal(this.Id);
                    
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
                return rtno;

            }
            public Alta AltaAnimal()
            {
                Alta rtno = null;
                try
                {
                    rtno = Logic.Alta.BuscarAnimal(this.Id);
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
                return rtno;

            }
            public LibroGenealogico LibroAnimal()
            {
                LibroGenealogico rtno = null;

                try
                {
                    rtno = Logic.LibroGenealogico.BuscarAnimal(this.Id);
                }

                catch (Exception ex)
                { Console.WriteLine(ex.Message); }

                return rtno;
            }

            public TipificacionCanal TipificacionCanalAnimal()
            {         
                return Logic.TipificacionCanal.BuscarAnimal(this.Id);            
            }
            public EngrasamientoCanal EngrasamientoCanalAnimal()
            {
                return Logic.EngrasamientoCanal.BuscarAnimal(this.Id);
            }
            public RendimientoCanal RendimientoCanalAnimal()
            {
                return Logic.RendimientoCanal.BuscarAnimal(this.Id);
            }


            public static List<Animal> BuscarAmpliado(int? id, int? idRaza, int? idEstado, int? idTalla, int? idConformacion, int? idExplotacion, string DIB,
                                                  string crotal, string tatuaje, string nombre, DateTime? fechaNacimiento, char? sexo, Boolean? testaje,
                                                  Boolean? aptoNovillas, Boolean? mostrarBajas, int? idEspecie,
                                                  int? idTipoAlta, DateTime? fechaAlta, string detalleAlta,
                                                  int? idTipoBaja, DateTime? fechaBaja, string detalleBaja,bool? incluirExternos) {
                   return AnimalData.GetAnimalesAmpliado(id, idRaza, idEstado, idTalla, idConformacion, idExplotacion, DIB, crotal, tatuaje, nombre, fechaNacimiento, sexo, testaje,
                                                 aptoNovillas, mostrarBajas, idEspecie, idTipoAlta, fechaAlta, detalleAlta,
                                                 idTipoBaja, fechaBaja, detalleBaja, incluirExternos);
            }




            private void BorrarIconoAsociado()
            {
                this._ImagenCargada = null;
                if (this.IdFotografia != null)//Si hay icono  lo borro.
                {
                    Fotografia fotoborrar = Fotografia.Buscar((int)this.IdFotografia);
                    if (fotoborrar != null)
                    {
                        //Antes de poder borrar el icono tengo que desenlazarme de el.
                        //para ello me cargo con contexto activo y elimino la relación Recurso.IdIcono -> Icono.Id
                        Animal animal = Animal.Buscar(this.Id);
                        animal = (Animal)animal.CargarContextoOperacion(TipoContexto.Modificacion);
                        animal.IdFotografia = null;
                        //Ahora puedo eliminar sin temor el icono.
                        fotoborrar.Eliminar();
                    }
                }
            }
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

            partial void OnFechaDesteteChanged()
            {
                if (FechaDestete.HasValue && (FechaDestete.Value < FechaNacimiento))                
                    throw new LogicException("No es posible asignar la fecha de destete al animal: " + this.Nombre + " porque dicha fecha  debe ser superior a la fecha de nacimiento. (" + this.FechaNacimiento.ToShortDateString() + ")");                    
            }
            partial void OnFechaNacimientoChanged()
            {
                if (this.AltaAnimal()!=null && this.AltaAnimal().Fecha<this.FechaNacimiento)
                    throw new LogicException("No es posible asignar la fecha de nacimiento especificada, al animal: " + this.Nombre + " porque dicha fecha  no puede ser mayor a la fecha de alta. (" + this.AltaAnimal().Fecha.ToShortDateString() +")");                    
            }
      
            partial void  OnDIBChanging(string value)
            {
                if (value!=string.Empty)
                {
                    //if (value.Length != 14)
                    //    throw new LogicException("El DIB debe tener 14 caracteres.");

                    if (Animal.Buscar(value)!=null)//si existe el animal en la base de datos            
                        throw new LogicException("El animal con el DIB: " + value + " ya existe");

                    ///Hacer la validación del cib si es de la especie bobina
                    ///Para ello primero obtengo la raza (recordemos que los formularios solo asignan la propiedad idRaza no Raza (obj)
                    Raza raza = Raza.Buscar(this.IdRaza);
                    if (raza!=null)
                        if (raza.IdEspecie == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.BOVINA).Id)                    
                            ValidarCIB(value);
                        
                    
                }
            }

            /// <summary>
            /// Valida el Dígito de Control (DC) de un código CIB (Código Identificación Bovino): 
            /// Código Compuesto por 14 Caracteres, donde 2 primeros caracteres deben ser letras y los 12 restantes digitos.
            /// La Estuctura se corresponde con: ES 0 X AB CDE FHIJ
            /// Donde:
            ///     ES->        Pais
            ///     0 ->        Repetición
            ///     X ->        DC
            ///     A B ->      Autonomia
            ///     C D E F->   Serie
            ///     G H I J->   Nº correlativo
            /// Fórmula:         
            ///     Para series >='0200'	X = último dígito de (A*1 + B*2 + C*3 + D*4 + E*5 + F*6 + G*7 + H*8 + I*9 + J)
            ///     Para series < '0200'    X = último dígito de ( A+B+C+D+E+F+G+H+I+J+8 )
            /// </summary>
            /// <param name="cib"></param>
            void ValidarCIB(string cib)
            {
                //MOD_B1
                if (string.IsNullOrEmpty(cib))
                {
                    throw new LogicException("El CIB es obligatorio");
                }
                else if (cib.StartsWith("ES"))//Solo se realiza la validacion del cib en caso de que sea español
                {
                    ///Validación de CIB Español
                    if( cib.Length != 14)
                        throw new LogicException("El CIB debe ser un código de 14 caracteres");
                    else
                    {
                        int  X,A,B,C,D,E,F,G,H,I,J;

                        if (!Cadenas.IsLetter(cib,0,2))                
                            throw new LogicException("Los 2 primeros caracteres del CIB deben ser el código del pais en letras.");
                        if (!Cadenas.IsDigit(cib, 2, 12))
                            throw new LogicException("Los 12 últimos caracteres del CIB deben ser el dígitos.");

                        
                        int? DC = null;

                        ///Inicializo las variables para los calculos
                        X = int.Parse(cib.Substring(3, 1));
                        A = int.Parse(cib.Substring(4, 1));
                        B = int.Parse(cib.Substring(5, 1));
                        C = int.Parse(cib.Substring(6, 1));
                        D = int.Parse(cib.Substring(7, 1));
                        E = int.Parse(cib.Substring(8, 1));
                        F = int.Parse(cib.Substring(9, 1));
                        G = int.Parse(cib.Substring(10, 1));
                        H = int.Parse(cib.Substring(11, 1));
                        I = int.Parse(cib.Substring(12, 1));
                        J = int.Parse(cib.Substring(13, 1));
                     

                        if (int.Parse(cib.Substring(6, 4)) >= 200)                
                            DC = Cadenas.UltimoDigito((A * 1 + B * 2 + C * 3 + D * 4 + E * 5 + F * 6 + G * 7 + H * 8 + I * 9 + J).ToString());                
                        if (int.Parse(cib.Substring(6, 4)) < 200)                
                            DC = Cadenas.UltimoDigito((A + B + C + D + E + F + G + H + I + J + 8).ToString());                

                        if (!DC.HasValue)
                            throw new LogicException("No ha sido posible calcular el Dígito de control");
                        if (DC.HasValue && DC.Value!=X)
                            throw new LogicException("El Dígito de control propocionado ("+ X.ToString() + ") no es correcto, el DC debería ser: "+ DC.Value.ToString());
                    
                    }            
                }
            }
                  
                
                



            //partial void OnValidate(System.Data.Linq.ChangeAction action)
            //{
            //    if (this!=null && this.Alta!=null && this.Alta.First()!=null)
            //    {
            //        if (this.Alta.First().Fecha<this.FechaNacimiento)
            //            throw new LogicException("No es posible asignar una fecha de alta anterior a la fecha del nacimiento");
                    
            //    }
            ////}
            //partial void OnCrotalChanging(string value)
            //{
                     
            //}
      


        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida
        /// </summary>
        /// <param name="eliminar"></param>
        private void ValidarLogica(TipoOperacion operacion)
        {
           
            if (operacion== TipoOperacion.Borrado)
            {
                List<AniLot> lstAnilot = this.lstAniLot;
                if (lstAniLot!=null && lstAniLot.Count>0)                
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque forma parte de un lote.");

                List<Celo> lstCelos = this.lstCelos;
                if (lstCelos != null && lstCelos.Count > 0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene celos.");

                List<SincronizacionCelo> lstSincCelos = this.lstSincronizacionCelos;
                if (lstSincCelos != null && lstSincCelos.Count > 0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene sincronizaciones de celos.");

                List<Inseminacion> lstInseminaciones = this.lstInseminaciones;
                if (lstInseminaciones != null && lstInseminaciones.Count > 0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene inseminaciones.");                


                List<Parto> lstPartos = this.lstPartos;
                if (lstPartos != null && lstPartos.Count > 0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene partos.");

                List<Aborto> lstAbortos = this.lstAbortos;
                if (lstAbortos != null && lstAbortos.Count > 0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene Abortos.");



                List<Lactacion> lstLactacion = Logic.Lactacion.Buscar(this.Id, null, null, null);
                if (lstLactacion != null && lstLactacion.Count > 0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene lactaciones abiertas.");

                List<DiagAnimal> lstDiagAnimal = this.lstDiagnosticos;
                if (lstDiagAnimal!=null && lstDiagAnimal.Count>0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene Diagnósticos.");                
                
                if (GastoData.AnimalExistenteEnGastos(this.Id))
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene gastos.");

                List<AniPro> lstAniPro = Logic.AniPro.Buscar(null, this.Id);
                if (lstAniPro != null && lstAniPro.Count > 0)                
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene tratamientos de profilaxis.");

                List<Asignacion> lstAsignaciones = this.lstAsignacion;
                if (lstAsignaciones != null && lstAsignaciones.Count > 0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene Asignaciones alimentarias.");

                List<Stock> lstStock = Logic.Stock.Buscar(null, null, this.Id, null, null);
                if (lstStock != null && lstStock.Count > 0)
                    throw new LogicException("El animal " + Nombre + " no puede ser borrado porque tiene Stock.");

                
            }
            if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
            {
                if (this.DescIdEspecie.HasValue)
                {
                    if (this.DescIdEspecie.Value == Configuracion.EspecieSistema(Configuracion.EspeciesSistema.BOVINA).Id
                        && !string.IsNullOrEmpty(this.Crotal))
                    {///Es una vaca y tiene crotal
                        if (this.Crotal.Length != 4)                        
                            throw new Exception("El crotal de manejo para la especie Bovina si se proporciona, debe tener 4 caracteres obligatorio.");                       
                    }                 
                }

            }

            ///###INICIO### - TRATAMIENTO IMAGEN
            ///Ejecuto el código de borrado de la imagen en 2 casos
            ///a) Si estoy borrando el registro
            ///b) Si ImagenAsociada es nulo (Da igual que nunca huviese imagen y ejecuto el código.
            if (operacion == TipoOperacion.Borrado || (ImagenAsociada == null))
                BorrarIconoAsociado();//En el borrado si tiene icono lo elimino

            ///Solo ejecuto el codigo para la persistencia de la imagen en 2 casos:
            ///a) Es una actualización y ha cambiado la imagen.
            ///b) Es una inserción y la imagen se ha especificado.
            if ((operacion == TipoOperacion.Actualizacion && ImagenAsociada != null && ImagenAsociada != ImagenCargada) ||//Es una actualizacion y ha cambiado la imagen
                (operacion == TipoOperacion.Insercion && ImagenAsociada != null))//Es una insercion y se ha especificado una imagen.
            {
                //Tenemos que insertar o actualizar el icono

                BorrarIconoAsociado();//Si existe alguno anterior lo elimino

                Fotografia fotocrear = new Fotografia();
                fotocrear.Imagen = ImagenAsociada;
                fotocrear.Animal.Add(this);
            }
            ///###FIN### - TRATAMIENTO IMAGEN
            
        }



        #endregion

        #region GENEALOGÍA
        public struct LGenealogicoCompleto
        {
            //Animal a tratar
            public Animal animal;
            //DATOS PADRE            
            public string Padre;

            //(abuelos paternos)
            public string PadrePadre;
            public string MadrePadre;

            //bisabuelos paternos padre
            public string AbueloPaternoPadre;
            public string AbuelaPaternoPadre;

            //bisabuelos paternos madre
            public string AbueloPaternoMadre;
            public string AbuelaPaternoMadre;            
            
            //DATOS MADRE
            public string Madre;
            
            //Abuelos maternos
            public string PadreMadre;
            public string MadreMadre;

            //bisabuelos maternos padre
            public string AbueloMaternoPadre;
            public string AbuelaMaternoPadre;

            //bisabuelos maternos madre
            public string AbueloMaternoMadre;
            public string AbuelaMaternoMadre;
            


        }
        public struct LGenealogicoSimple
        {
            //Animal a tratar
            public Animal animal;

            //Padre
            public string Padre;                        
            //Madre
            public string Madre;
        }


        public static LGenealogicoSimple CargarLGenealogicoSimple(string dibAnimal)
        {
            LGenealogicoSimple rtno = new LGenealogicoSimple();

            if (dibAnimal!=string.Empty)
            {
                //List<Animal> Animales = null;
                Animal animal = Animal.Buscar(dibAnimal);
                if (animal!=null)//Si he encontrado el animal con el dib especificado                
                    rtno = CargarLGenealogicoSimple(animal);
            }
            return rtno;
        }
        public static LGenealogicoSimple CargarLGenealogicoSimple(Animal animal)
        {
            //Comprobación de validez de los argumentos
            if (animal == null)
                throw new ArgumentException("El valor es obligatorio", "animal");

            LGenealogicoSimple rtno = new LGenealogicoSimple();
            LibroGenealogico Ascendencia = animal.LibroAnimal();
            if (Ascendencia != null)
            {
                rtno.Padre = Ascendencia.Padre;
                rtno.Madre = Ascendencia.Madre;
            }
            
            return rtno;
        }


        
        public static LGenealogicoCompleto CargarLGenealogicoCompleto(Animal animal)
        {
            LGenealogicoCompleto rtno = new LGenealogicoCompleto();
            rtno.animal = animal;

            //Padres
            LGenealogicoSimple Padres = Animal.CargarLGenealogicoSimple(animal);

            //Abuelos 
            LGenealogicoSimple AbuelosPaternos = Animal.CargarLGenealogicoSimple(Padres.Padre);
            LGenealogicoSimple AbuelosMaternos = Animal.CargarLGenealogicoSimple(Padres.Madre);

            //Bisabuelos Paternos por parte de padre
            LGenealogicoSimple BisAbuelosPaternosPadre = Animal.CargarLGenealogicoSimple(AbuelosPaternos.Padre);
            //Bisabuelos Paternos por parte de Madre
            LGenealogicoSimple BisAbuelosPaternosMadre = Animal.CargarLGenealogicoSimple(AbuelosPaternos.Madre);
            //Bisabuelos Maternos por parte de padre
            LGenealogicoSimple BisAbuelosMaternosPadre = Animal.CargarLGenealogicoSimple(AbuelosMaternos.Padre);
            //Bisabuelos Maternos por parte de Madre
            LGenealogicoSimple BisAbuelosMaternosMadre = Animal.CargarLGenealogicoSimple(AbuelosMaternos.Madre);

            //DATOS POR PARTE DEL PADRE
            rtno.Padre = Padres.Padre;            

            rtno.PadrePadre = AbuelosPaternos.Padre;
            rtno.MadrePadre = AbuelosPaternos.Madre;             

            
            //bisabuelos paternos padre
            rtno.AbueloPaternoPadre = BisAbuelosPaternosPadre.Padre;
            rtno.AbuelaPaternoPadre = BisAbuelosPaternosPadre.Madre;

            //bisabuelos paternos madre
            rtno.AbueloPaternoMadre = BisAbuelosPaternosMadre.Padre;
            rtno.AbuelaPaternoMadre = BisAbuelosPaternosMadre.Madre;


            //DATOS POR PARTE DEL MADRE
            rtno.Madre = Padres.Madre;

            rtno.PadreMadre = AbuelosMaternos.Padre;
            rtno.MadreMadre = AbuelosMaternos.Madre;

            
            //bisabuelos maternos padre
            rtno.AbueloMaternoPadre = BisAbuelosMaternosPadre.Padre;
            rtno.AbuelaMaternoPadre = BisAbuelosMaternosPadre.Madre;

            //bisabuelos maternos madre
            rtno.AbueloMaternoMadre = BisAbuelosMaternosMadre.Padre;
            rtno.AbuelaMaternoMadre = BisAbuelosMaternosMadre.Madre;
                               
            
            return rtno;
            
        }



        #endregion

    }
}

//---------------------Código Comentado----------------------------------------------//

  //partial void OnCrotalChanging(string value)
        //{
        //    if (value != string.Empty)
        //    {
        //        List<Animal> lstAnimales = Animal.Buscar(value, null);
        //        if (lstAnimales != null && lstAnimales.Count > 0)
        //            throw new LogicException("El crotal:  " + value + " indicado ya se encuentra dado de alta");
                
        //    }
        //}  