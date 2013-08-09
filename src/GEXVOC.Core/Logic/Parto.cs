using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Logic
{
    public partial class Parto : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ValidarLogica(TipoOperacion.Insercion);

            Animal animal = Animal.Buscar(this.IdHembra);

                         
            this.Numero = animal.lstPartos.Count + 1;//Asignar el número al parto.
            

            foreach (Inseminacion item in Inseminacion.BuscarInseminacionesLibres(this.IdHembra, animal.UltimaFechaParto_Aborto(this.IdHembra)))
            {
                InsPar inspar = new InsPar();
                inspar.IdInseminacion = item.Id;
                this.InsPar.Add(inspar);
            }

            PartoData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            PartoData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);

            Boolean TransacionPropia = false;
            TransacionPropia = BDController.IniciarTransaccion();
            try
            {
                //ELIMINO LOS REGISTROS RELACIONADOS DE LA TABLA INSPAR
                List<InsPar> lstInsPar = this.lstInsPar;
                foreach (InsPar item in lstInsPar)
                    item.Eliminar();

                PartoData.Eliminar(this);

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
                        rtno = new Parto();
                        break;
                    case TipoContexto.Modificacion:
                        rtno = PartoData.GetPartoOP(this.Id);
                        break;
                }
                return rtno;

        }


        /// <summary>
        /// Obtiene un/una Parto a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Parto con el id especificado.</returns>
        public static Parto Buscar(int id)
        {
            return PartoData.GetParto(id);
        }

        /// <summary>
        /// Obtiene los/las Parto que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Parto> Buscar(int? idHembra, int? idTipo, int? idFacilidad,int? vivos, int? muertos, DateTime? fechaMayorIgual,DateTime? fechaMenorIgual , Boolean? modificable)
        {
            return PartoData.GetPartos(idHembra, idTipo, idFacilidad,vivos,muertos, fechaMayorIgual,fechaMenorIgual, modificable);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

            /// <summary>
            /// Propiedad que devuelve el nombre de la hembra a la que pertenece el parto
            /// </summary>
            public string DescHembra
            {
                get
                {
                    string Desc = string.Empty;
                    if (this != null && this.Animal != null)
                        Desc = this.Animal.Nombre;
                    return Desc;
                }
            }
            /// <summary>
            /// Propiedad que devuelve la descripción del tipo del parto
            /// </summary>
            public string DescTipo
            { 
                    get 
                    {
                        string Desc = string.Empty;
                        if (this != null && this.TipoParto != null)
                            Desc = this.TipoParto.Descripcion;
                        return Desc;
                     }
        
            }
            /// <summary>
            /// Propiedad que devuelve la descripción de la facilidad del parto
            /// </summary>
            public string DescFacilidad
            {
                get
                {
                    string Desc = string.Empty;
                    if (this != null && this.Facilidad != null)
                        Desc = this.Facilidad.Descripcion;
                    return Desc;
                }
            }



            ///// <summary>
            ///// Nos indica la cantidad de días que debe haber entre la última inseminación y el parto        
            ///// </summary>
            //private int MinimoGestacion = Convert.ToInt32(Configuracion.Parametros["DiasMinimoGestacion"]);
            ///// <summary>
            ///// Nos indica la cantidad de días que debe no se debe exceder entre la última inseminación y el parto        
            ///// </summary>
            //private int MaximoGestacion = Convert.ToInt32(Configuracion.Parametros["DiasMaximoGestacion"]);



            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Especie a la que pertenece el elemento
            ///// </summary>
            public string DescEspecie
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Animal != null && this.Animal.Raza!=null && this.Animal.Raza.Especie!=null)
                        rtno = this.Animal.Raza.Especie.Descripcion;

                    return rtno;
                }
            }
           

        #endregion        

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        /// <summary>
        /// Nos devuelve la lista de inseminaciones de la vaca que ha tenido el parto que estamos editando
        /// </summary>
        public List<Inseminacion> lstInseminaciones
        {
             get { return PartoData.GetInseminaciones(this.Id); }
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
        public Cubricion UltimaCubricion()
        {
            Cubricion rtno = null;

            try
            {
                Animal animal=Animal.Buscar(this.IdHembra);
                if (animal!=null)
                {
                    List<Cubricion> lstCubriciones = animal.lstCubriciones;
                    rtno=(Cubricion)lstCubriciones.Where(E => E.FechaInicio < this.Fecha).OrderByDescending(E => E.FechaInicio).First();
                    // rtno = lstCubriciones.First();               
                                    
                }
            }
            catch (Exception)
            { }

            return rtno;
        }

        public List<InsPar> lstInsPar
        {
            get { return Logic.InsPar.Buscar(null,this.Id); }
        }
        
       
      
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        public bool OmitirValidacionPeriodoGestacion { get; set; }

            /// <summary>
            /// Valida la lógica de negocio, concluye si la operacion es admitida
            /// </summary>
            /// <param name="eliminar"></param>
            private void ValidarLogica(TipoOperacion operacion)
            {
                if (operacion== TipoOperacion.Insercion || operacion== TipoOperacion.Actualizacion)
                {
                    Animal hembra = Animal.Buscar(this.IdHembra);
                
                    DateTime? UltimaFechaParto_Aborto = hembra.UltimaFechaParto_Aborto(this.IdHembra);
                    bool cubricionAbierta=false;
                    DateTime? UltimaFechaInseminacion_Cubricion = hembra.UltimaFechaInseminacion_Cubricion(this.IdHembra, ref cubricionAbierta);
                    //if (cubricionAbierta)
                    //    throw new LogicException("La hembra: " + hembra.Nombre + " tiene una cubricion, pero se encuentra sin fecha fin, el proceso no puede continuar sin una fecha fin válida.");                                            
                    
                    if (UltimaFechaInseminacion_Cubricion == null)
                        throw new LogicException("La hembra: " + hembra.Nombre + " no ha sido inseminada ni dispone de cubriciones.");                    
                    else
                    {
                        Parto UltimoParto =hembra.UltimoParto();                      
                        if (UltimoParto!=null)
                        {
                             if (UltimaFechaInseminacion_Cubricion < UltimaFechaParto_Aborto && UltimoParto.Id != this.Id)
                                 throw new LogicException("La hembra: " + hembra.Nombre + " no ha sido inseminada ni dispone de cubriciones desde el último parto o aborto.");
                        }
                        else
                            if (UltimaFechaInseminacion_Cubricion < UltimaFechaParto_Aborto)
                                throw new LogicException("La hembra: " + hembra.Nombre + " no ha sido inseminada ni dispone de cubriciones desde el último parto o aborto.");

                       

                        //if (hembra.lstPartos.Count > 0)
                        //{
                        //    Parto UltimoParto = hembra.lstPartos.OrderByDescending(E => E.Fecha).First();

                        //    if (UltimaFechaInseminacion_Cubricion < UltimaFechaParto_Aborto && UltimoParto.Id != this.Id)
                        //        throw new LogicException("La hembra no ha sido inseminada ni dispone de cubriciones desde el último parto o aborto.");

                        //}

                        List<Parto> lstPartos = null;
                        if (this.Id != 0)//Es una modificacion, en la modificacion solo comparamos con la lista menor del id a modificar.                     
                            lstPartos = PartoData.GetPartosMenores(this.IdHembra, this.Id);
                        else//Es una insercion, comparamos con toda la lista de Partos.
                            lstPartos = hembra.lstPartos;
                        if (lstPartos != null && (lstPartos.Where(E => E.Fecha.Date == this.Fecha.Date).Count() > 0))
                            throw new LogicException("No es posible la asignación de la fecha (" + this.Fecha.ToShortDateString() + ") al Parto, porque ya existe otro Parto con esta fecha."); 


                       
                        //Comprobar que el parto se encuentre entre los dias minimo y maximo de gestacion
                        if (!OmitirValidacionPeriodoGestacion)                        
                            Parto.ValidarPeriodoGestacion(hembra.Id, this.Fecha);

                        //////Comprobar que el parto se encuentre entre los dias minimo y maximo de gestacion
                        ////if (this.Fecha < ((DateTime)UltimaFechaInseminacion_Cubricion).AddDays(hembra.MinimoGestacion)
                        ////      || this.Fecha > ((DateTime)UltimaFechaInseminacion_Cubricion).AddDays(hembra.MaximoGestacion))
                        ////    throw new LogicException("La fecha de parto para la hembra: " + hembra.Nombre + "  no es válida. No se ha respetado el período de gestación establecido.\r"
                        ////        + "La fecha del parto debe estar comprendida entre: " + ((DateTime)UltimaFechaInseminacion_Cubricion).AddDays(hembra.MinimoGestacion).ToShortDateString()
                        ////        + " y " + ((DateTime)UltimaFechaInseminacion_Cubricion).AddDays(hembra.MaximoGestacion).ToShortDateString());
                    }
                }
                else //Borrado
                {    // No se pueden borrar partos con controles posteriores.
                    if (Animal.TieneControlPosterior(this.IdHembra, this.Fecha))
                        throw new LogicException("El parto no puede ser eliminado porque tiene un control posterior.");
                    if (Animal.TieneSecadoPosterior(this.IdHembra, this.Fecha))
                        throw new LogicException("El parto no puede ser eliminado porque tiene un secado posterior.");
                    
                }
            
            }

            partial void OnFechaChanged()
            {
                if (Fecha.Date > DateTime.Today && !Configuracion.PermitirRegistrosFuturos)
                    throw new LogicException("No esta permitido establecer una fecha de parto posterior a la fecha del sistema.");           
            }

            /// <summary>
            /// Comprueba si una fecha dada es válida para ser asignada a un parto
            /// valida el periodo de inseminación.
            /// </summary>
            /// <param name="idAnimal"></param>
            /// <param name="fechaValidar"></param>
            public static void ValidarPeriodoGestacion (int idAnimal, DateTime fechaValidar)
            {
                Animal animal = Animal.Buscar(idAnimal);
                if (animal!=null)
                {
                   
                    ///La fecha inicio será la fecha de la inseminacion o bién la fecha de inicio del rango de la cubrición
                    ///En cualquier caso es obligatoria
                    DateTime FechaInicioRango;
                    ///La fecha fin en caso de las inseminaciones será la misma que la fecha de inicio
                    ///En caso de las cubriciones será la fecha fin de la cubrición, si no tiene será la fecha del sistema
                    ///En cualquier caso es obligaroria.
                    DateTime FechaFinRango;
                  
                    IClaseBase inscub = animal.UltimaInseminacion_Cubricion();
                    if (inscub != null)
                    {
                        if (inscub.GetType() == typeof(Inseminacion))//la ultima ins-cubri se corresponde con una inseminacion
                        {
                            FechaInicioRango = ((Inseminacion)inscub).Fecha;
                            FechaFinRango = FechaInicioRango;
                        }
                        else //la ultima ins-cubri se corresponde con una cubricion
                        {
                            FechaInicioRango = ((Cubricion)inscub).FechaInicio;
                            FechaFinRango = ((Cubricion)inscub).FechaFin.HasValue?((Cubricion)inscub).FechaFin.Value:DateTime.Today;

                            //No podemos permitir que la fecha fin del rango sea anterior a la fecha inicio.
                            //Si se da este caso, igualamos las fechas.
                            if (FechaFinRango<FechaInicioRango)                            
                                FechaFinRango = FechaInicioRango;
                            
                        }

                        //Comprobar que el parto se encuentre entre los dias minimo y maximo de gestacion
                        if (fechaValidar < FechaInicioRango.AddDays(animal.MinimoGestacion)
                              || fechaValidar > (FechaFinRango.AddDays(animal.MaximoGestacion)))
                            throw new LogicException("La fecha de parto para la hembra: " + animal.Nombre + "  no es válida. No se ha respetado el período de gestación establecido.\r"
                                + "La fecha del parto debe estar comprendida entre: " + FechaInicioRango.AddDays(animal.MinimoGestacion).ToShortDateString()
                                + " y " + FechaFinRango.AddDays(animal.MaximoGestacion).ToShortDateString());
       

                    }
                }
            }
        #endregion


    }
}