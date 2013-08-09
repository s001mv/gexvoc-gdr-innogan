using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ControlLeche : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS

        

        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            Boolean TransacionPropia = false;

            

            ValidarLogica(TipoOperacion.Insercion);
            
         
            try
            {
                TransacionPropia = BDController.IniciarTransaccion();
                if (this.IdHembra ==null)
                    throw new LogicException("No se ha proporcionado ningún valor para Hembra");

                Animal hembra = Animal.BuscarOP((int)this.IdHembra);
                Lactacion lactacion = hembra.UltimaLactacionAbierta();
                    

                //existe una lactación abierta y hay un nuevo parto o aborto con lactación ya que esto
                //puede ocurrir porque en inseminación no podemos controlar que tenga un secado o que 
                //no hubiese apertura de lactación para hacer la inseminación porque el ciclo (I-P-C-S)
                //en algunos casos finaliza en el parto o aborto.
                                                
               DateTime? UltimaFechaParto_Aborto=hembra.UltimaFechaParto_Aborto((int)this.IdHembra);
               
                if (lactacion != null && (lactacion.FechaInicio < UltimaFechaParto_Aborto) && (UltimaFechaParto_Aborto < this.Fecha))
                {               
                    ///Normalmente se reinicia la lactacacion pq tenemos un parto u aborto entre la lactacion y la fecha del control
                    ///pero en un caso en concreto se utiliza la misma lactación anterior (Solo en el caso en el que se produzca un aborto continuando lactacion)                
                    Aborto ultimoaborto = hembra.UltimoAborto();
                    if (ultimoaborto==null ||( ultimoaborto.IdTipo != Configuracion.TipoAbortoSistema(Configuracion.TiposAbortosSistema.ABORTO_CONTINUANDO_LACTACIÓN).Id && ultimoaborto.Fecha == UltimaFechaParto_Aborto))
                    {
                        Secado secado = new Secado();
                        secado.IdHembra = hembra.Id;
                        secado.Fecha = lactacion.UltimoControl().Fecha;
                        secado.Insertar(); //Al insertar un secado se cierra la lactación abierta.
                        lactacion = hembra.UltimaLactacionAbierta();                    
                    }                
                }
               
                if (lactacion == null)
                {
                    lactacion = new Lactacion();

                    lactacion.IdHembra = hembra.Id;

                    ///Tenemos que crear la nueva lactación, pero antes de nada comprobar si es posible crearla
                    ///Para ello se debe cumplir la condicion de que exista un parto o aborto seguido de nueva lactacion despues del ultimo secado.
                          
                    
                    
                    ///Obtengo la fecha de la lactacion
                    if (hembra != null)
                    {
                        //La hembra tiene que tener un parto o un aborto esto lo controla la validacion de la logica.
                        if (hembra.UltimoParto() != null && (hembra.UltimoSecado() == null || (hembra.UltimoSecado() != null && hembra.UltimoParto().Fecha > hembra.UltimoSecado().Fecha)))
                            lactacion.FechaInicio = hembra.UltimoParto().Fecha;
                        else if (hembra.UltimoAbortoConLactacion() != null && (hembra.UltimoSecado() == null || (hembra.UltimoSecado() != null && hembra.UltimoAbortoConLactacion().Fecha > hembra.UltimoSecado().Fecha)))
                            lactacion.FechaInicio = hembra.UltimoAborto().Fecha;
                        else
                            throw new LogicException("No ha sido posible crear la lactación correspondiente compruebe que existe un parto o aborto seguido de nueva lactación despues del último secado.");
                    }
                    ///Si es necesario cambio la fecha de la lactacion calculada antes, me interesa siempre hacer los calculos anteriores
                    ///por la excepcion
                    if (Configuracion.AperturaLactacion == Configuracion.TipoAperturaLactacion.Primer_control)
                            lactacion.FechaInicio = this.Fecha;
                    

                    lactacion.Insertar();//Puede probocar excepción

                }          
            
               
                this.IdLactacion = lactacion.Id;

                //asignar número al control
                if (lactacion != null)
                {
                    //Lactacion lactacion = Lactacion.Buscar(this.IdLactacion);
                    this.Numero = lactacion.lstControlesLeche.Count + 1;
                }      


                //Insertar Lactaciones extendidas
                Lactacion.CalcularProduccion(lactacion);
                lactacion = null;

               
                

                ControlLecheData.Insertar(this);
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

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            Boolean TransacionPropia=false;
            ControlLeche controlAnterior = ControlLeche.Buscar(this.Id);//Obtenemos el control que se está actualizando antes de la actualización.
            Lactacion lactacion = LactacionData.GetLactacionOP(this.IdLactacion);//Obtengo el objeto del tipo lactacion con contexto activo.
            try
            {
                TransacionPropia = BDController.IniciarTransaccion();
                Animal hembra = Animal.BuscarOP((int)this.IdHembra);

            //si existe una lactación abierta y hay un nuevo parto o aborto con lactación cerramos la 
            //lactacion anterior y abrimos una nueva siempre avisando al usuario y dandole a elegir.              
            //esto puede ocurrir porque en inseminación no podemos controlar que tenga un secado o que 
            //no hubiese apertura de lactación para hacer la inseminación porque el ciclo (I-P-C-S)
            //en algunos casos finaliza en el parto o aborto.               
                if (lactacion!=null &&(lactacion.FechaInicio < hembra.UltimaFechaParto_Aborto((int)this.IdHembra)) && (hembra.UltimaFechaParto_Aborto((int)this.IdHembra) < this.Fecha))
                {
                    Secado secado = new Secado();
                    secado.IdHembra = hembra.Id;
                    secado.Fecha = controlAnterior.Fecha;//ponemos como fecha de secado la fecha que tenía el control que se está actualizando porque siempre será anterior al último parto o aborto.
                    secado.Insertar(); //Al insertar un secado se cierra la lactación abierta.                      

                    lactacion = hembra.UltimaLactacionAbierta();

                    if (lactacion == null)
                    {
                        lactacion = new Lactacion();

                        lactacion.IdHembra = hembra.Id;
                        if (Configuracion.AperturaLactacion == Configuracion.TipoAperturaLactacion.Primer_control)
                            lactacion.FechaInicio = this.Fecha;
                        else //La fecha de inicio será la del parto o la del aborto con lactación.        
                        {
                            if (hembra != null)
                            {
                                //La hembra tiene que tener un parto o un aborto esto lo controla la validacion de la logica.
                                if (hembra.UltimoParto() != null && (hembra.UltimoSecado() == null || (hembra.UltimoSecado() != null && hembra.UltimoParto().Fecha > hembra.UltimoSecado().Fecha)))
                                    lactacion.FechaInicio = hembra.UltimoParto().Fecha;
                                else if (hembra.UltimoAbortoConLactacion() != null && (hembra.UltimoSecado() == null || (hembra.UltimoSecado() != null && hembra.UltimoAbortoConLactacion().Fecha > hembra.UltimoSecado().Fecha)))
                                    lactacion.FechaInicio = hembra.UltimoAborto().Fecha;
                                else
                                    throw new LogicException("No ha sido posible establecer la fecha a la lactación correspondiente al último parto o aborto con lactación porque no se ha encontrado dicho parto o aborto.");
                            }
                        }

                        lactacion.Insertar();//Puede probocar excepción

                    }
                }

                
                if (Configuracion.AperturaLactacion == Configuracion.TipoAperturaLactacion.Primer_control && this.Fecha != lactacion.FechaInicio)
                {
                    //Ha cambiado la fecha del control, y en configuracion esta marcado como que la fecha de la lactacion la 
                    //identifica la fecha del primer control

                    //Compruebo si es el primer control ya que si lo es, debo actualizar la fecha de la lactacion
                    if (lactacion.PrimerControl().Id == this.Id)
                    {
                                              
                            lactacion.FechaInicio = this.Fecha;
                            lactacion.Actualizar();                        
                    }
                }
                this.Lactacion = lactacion;
                Lactacion.CalcularProduccion(lactacion);

                ControlLecheData.Actualizar(this);
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

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            Boolean TransacionPropia = false;
           
            try
            {
                TransacionPropia = BDController.IniciarTransaccion();
                
                ////Elimino en cascada los análisis
                List<MuestraControl> lstMuestraControl = this.lstMuestrasControl;
                foreach (MuestraControl item in lstMuestraControl)
                    item.Eliminar();



                Lactacion lactacion = LactacionData.GetLactacionOP(this.IdLactacion);
                if (lactacion.lstControlesLeche.Count == 1)
                {
                    ControlLecheData.Eliminar(this);
                    lactacion.Eliminar();
                }
                else
                {
                    ControlLecheData.Eliminar(this);
                    if (lactacion != null)                    
                        Lactacion.CalcularProduccion(lactacion);
                    
                }

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

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
              IClaseBase rtno=null;
                switch (Modo)
                {
                    case TipoContexto.Insercion:
                        rtno = new ControlLeche();//Es una insercion
                        break;
                    case TipoContexto.Modificacion:
                        rtno = ControlLecheData.GetControlLecheOP(this.Id);//Es una modificacion
                        break;
                    default:
                        rtno = null;
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una ControlLeche a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>ControlLeche con el id especificado.</returns>
        public static ControlLeche Buscar(int id)
        {
            return ControlLecheData.GetControlLeche(id);
        }

        /// <summary>
        /// Obtiene los/las ControlLeche que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ControlLeche> Buscar(int? idLactacion,int? idControl,int? idOrdeno,DateTime? fecha,decimal? lecheManana,decimal? lecheTarde,decimal? lecheNoche,bool? modificable)
        {
            return ControlLecheData.GetControlesLeche(idLactacion, idControl, idOrdeno, fecha, lecheManana, lecheTarde, lecheNoche,modificable);
        }

        public static List<ControlLeche> Buscar(int? idLactacion, DateTime? fechaInicio,DateTime? fechaFin)
        {
            return ControlLecheData.GetControlesLeche(idLactacion,  fechaInicio, fechaFin);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo ControlLeche
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<ControlLeche> Buscar()
        {
            return ControlLecheData.GetControlesLeche(null,null,null,null,null,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

       
          public string DescStatusControl{
            get
            {
                string rtno=string.Empty;
                if (this !=null && this.StatusControl !=null)
                    rtno = this.StatusControl.Descripcion;

                return rtno;
            }
        }
        public string DescStatusOrdeno { 
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.StatusOrdeno != null)
                    rtno = this.StatusOrdeno.Descripcion;

                return rtno; 
            } 
        }
        public string DescAnimalMostar
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Lactacion != null && this.Lactacion.Animal != null)
                    rtno=this.Lactacion.Animal.Nombre;
                return rtno;
            }
        }
        
        public int? DescIdHembra
        {
            get
            {
                int? rtno = null;
                if (this != null && this.Lactacion != null && this.Lactacion.Animal != null)
                    rtno = this.Lactacion.Animal.Id;
                return rtno;
            }
            //set
            //{
            //    rtno = value;
            //}
        
        }
        public string DescCrotalMostrar
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Lactacion != null && this.Lactacion.Animal != null)
                    rtno=this.Lactacion.Animal.Crotal;
                return rtno;
            }
            
        }
        int? _IdHembra=null;
        
        /// <summary>
        ///Se va a utilizar para almacenar el id de la hembra cuyo control estamos haciendo
        ///Como lo que identifica al control es la lactacion, esta debe corresponder, pero en el caso 
        ///de que no exista dicha lactación, se creará en la lógica ayudándose de esta propiedad.
        ///De esta manera, utilizando esta propiedad, no nos vemos obligados a sobrecargar el método insertar enviando la vaca
        ///a la que se le asigna este control.
        /// </summary>
        public int? IdHembra
        {
            get { return _IdHembra; }
            set { _IdHembra = value; }
        }

        
        
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public List<MuestraControl> lstMuestrasControl
        {
            get { return Logic.MuestraControl.Buscar(this.Id, null, null, null, null, null, null, null, null, null, null, null, null); }

        }
        
                
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida
        /// </summary>
        /// <param name="eliminar"></param>
        private void ValidarLogica(TipoOperacion operacion)
        {
                      
            
            if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion || operacion==TipoOperacion.Borrado)
            { // No se puede insertar/modificar ni borrar controles de una vaca con secados posteriores.

                //Hay que comprobar si this.IdHembra es no nulo porque al eliminar desde la pantalla EditControlLechero 
                //recogemos this.DescIdHembra del Datagrid a la hora de eliminar. Y necesitamos el idHembra porque en la inserccion del control
                //aun no tenemos la lactación por lo tanto no tenemos acceso a lactacion.IdHembra.
                
                if (this.IdHembra != null)
                {  
                    if (Animal.TieneSecadoPosterior((int)this.IdHembra, this.Fecha))
                        throw new LogicException("La hembra tiene un secado posterior a la fecha: " + this.Fecha.ToShortDateString() + ", No es posible asignar dicha fecha al control");
                }
                else
                    if(Animal.TieneSecadoPosterior((int)this.DescIdHembra,this.Fecha))
                        throw new LogicException("La hembra tiene un secado posterior a la fecha: " + this.Fecha.ToShortDateString() + ", No es posible asignar dicha fecha al control.");

            }
            
            if(operacion==TipoOperacion.Insercion || operacion==TipoOperacion.Actualizacion)
            {
                
                
                Animal hembra = Animal.Buscar((int)this.IdHembra);
                Lactacion lactacion = hembra.UltimaLactacionAbierta();
                //Se comprueba que la fecha de control sea posterior al último parto o aborto.
                if (hembra.UltimaFechaParto_Aborto((int)this.IdHembra) > this.Fecha)
                    throw new LogicException("La fecha del control debe ser posterior al último parto o al último aborto con lactación.");
                //Se comprueba que el animal tenga un parto o un aborto con lactación.
                if (hembra.UltimoParto() == null && hembra.UltimoAbortoConLactacion()==null) 
                    throw new LogicException("La hembra no ha tenido un parto ni un aborto seguido de nueva lactación.");
                //Se comprueba si existe un parto o un aborto con lactación desde el último secado.
                if (hembra.UltimoParto()!=null && hembra.UltimoAbortoConLactacion()!=null || (hembra.UltimoParto()!=null || hembra.UltimoAbortoConLactacion()!=null))
                {
                    if (hembra.UltimoSecado() != null && (hembra.UltimaFechaParto_Aborto((int)this.IdHembra)<= hembra.UltimoSecado().Fecha))
                        throw new LogicException("La hembra no ha tenido un parto ni un aborto seguido de nueva lactación desde el último secado.");
                }
                
      
                if (lactacion != null)
                    
                    foreach (ControlLeche controles in lactacion.lstControlesLeche)
                        if (controles.Id != this.Id)
                        {
                            //Controla que los controles sean posteriores al primero de lactacion.
                            ControlLeche primerControl = lactacion.PrimerControl();
                            if (Configuracion.AperturaLactacion == Configuracion.TipoAperturaLactacion.Primer_control && primerControl.Id == this.Id && controles.Fecha > this.Fecha)
                                throw new LogicException("La fecha de control debe ser posterior al: " + controles.Fecha.ToShortDateString() + ".");
                            //Un control por día máximo.
                            if (controles.Fecha == this.Fecha)
                                throw new LogicException("Ya se ha realizado un control el día: " + this.Fecha.ToShortDateString() + ".");

                        }
                              
            }
           

            //if (operacion == TipoOperacion.Borrado)
            //{//No se puede eliminar un control sin eliminar antes los controles de muestras asociados.
               
            //    if (this.lstMuestrasControl.Count > 0)
            //        throw new LogicException("No se puede eliminar el control ya que tiene un control de muestras asociado");
                
            //}
            
        }

        // Debe existir un parto a controlar y que este sea posterior a los secados existentes.

        public static bool ExitenControlesPosteriores(int idHembra, DateTime fecha)
        {
            bool rtno = false;
            Animal animal = new Animal();
            animal.Id = idHembra;
            animal.CargarContextoOperacion(TipoContexto.Modificacion);
            List<ControlLeche> lstUltimosControles = animal.lstControlesUltimaLactacion;
            if (lstUltimosControles != null)
            { 
            foreach (ControlLeche item in lstUltimosControles)
                if (item.Fecha > fecha)
                {
                    rtno = true;
                    break;
                }
            
            }
            animal = null;
            return rtno;
        
        }


       



       
        
        
        
        #endregion



        
    }
}