using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class SincronizacionCelo : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	SincronizacionCeloData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	SincronizacionCeloData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	SincronizacionCeloData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new SincronizacionCelo();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = SincronizacionCeloData.GetSincronizacionCeloOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una SincronizacionCelo a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>SincronizacionCelo con el id especificado.</returns>
            public static SincronizacionCelo Buscar(int id){
                return SincronizacionCeloData.GetSincronizacionCelo(id);
            }

            /// <summary>
            /// Obtiene los/las SincronizacionCelo que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<SincronizacionCelo> Buscar(int? idHembra, int? idVeterinario, DateTime? fechaColocacion,
            DateTime? fechaInyeccion, DateTime? fechaPrevision, DateTime? fechaRetirada)
            {
                return SincronizacionCeloData.GetSincronizacionCelos(idHembra, idVeterinario, fechaColocacion, fechaInyeccion, fechaPrevision, fechaRetirada);
            }

            public static List<SincronizacionCelo> Buscar(int? idHembra,  DateTime? fechaInicio,
              DateTime? fechaFin)
            {
                return SincronizacionCeloData.GetSincronizacionFecha(idHembra, fechaInicio, fechaFin);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo SincronizacionCelo
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
            public static List<SincronizacionCelo> Buscar()
            {
                return SincronizacionCeloData.GetSincronizacionCelos(null,null,null,null,null,null);
            }


       
        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

            ///// <summary>
            ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
            ///// </summary>
            //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Veterinario a la que pertenece el elemento
            ///// </summary>
            public string DescPersonal
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Veterinario != null)
                        rtno = this.Veterinario.NombreCompleto;

                    return rtno;
                }
            }

            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Animal a la que pertenece el elemento
            ///// </summary>
            public string DescAnimal
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Animal != null)
                        rtno = this.Animal.Nombre;

                    return rtno;
                }
            }



            /// <summary>
            /// Especifica el tipo de la Sincronización.
            /// Es un campo calculado, no existe como tal almacenado.
            /// Una sincronización tiene valorada la Fecha de colocación o la Fecha de Inyeccion (Solo uno de estos datos)
            /// En función de esto se calcula el tipo respondiendo al siguiente criterio:
            ///  - Si Fecha Colocación Valorada:    Tipo=Esponja
            ///  - Si Fecha de Inyección Valorada:  Tipo=Inyección Hormonal
            /// </summary>
            public string Tipo
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.FechaColocacion != null)
                        rtno = "ESPONJA";
                    if (this != null && this.FechaInyeccion != null)
                        rtno = "INYECCIÓN HORMONAL";

                    return rtno;
                }
            }


            /// <summary>
            /// Especifica la fecha de la Sincronización.
            /// Es un campo calculado, no existe como tal almacenado.
            /// Una sincronización tiene valorada la Fecha de colocación o la Fecha de Inyeccion (Solo uno de estos datos)
            /// En función de esto se calcula la fecha respondiendo al siguiente criterio:
            ///  - Si Fecha Colocación Valorada:    Fecha=Fecha Colocación
            ///  - Si Fecha de Inyección Valorada:  Fecha=Fecha de Inyección
            /// </summary>
            public DateTime? Fecha
            {
                get
                {
                    DateTime? rtno = null;
                    if (this != null && this.FechaColocacion != null)
                        rtno = this.FechaColocacion;
                    if (this != null && this.FechaInyeccion != null)
                        rtno = this.FechaInyeccion;

                    return rtno;
                }
            
            }
      
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
      

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
			/// <summary>
        	/// Valida la lógica de negocio, concluye si la operacion es admitida.
        	/// </summary>
        	/// <param name="operacion">Operación en curso que se debe validar.</param>
        	private void ValidarLogica(TipoOperacion operacion)
			{

                if (operacion== TipoOperacion.Insercion || operacion==TipoOperacion.Actualizacion)
                {
                    //1@# INICIO - Comprobar que se encuentre valorada o bien la fecha de colocacion o la de inyeccion
                    if (this.FechaColocacion == null && this.FechaInyeccion == null)
                        throw new LogicException("Es obligatoria una de las siguientes fechas:\r- Fecha de Colocación\r-Fecha de Inyección");
                    //1@# FIN - Comprobar que se encuentre valorada o bien la fecha de colocacion o la de inyeccion


                    //##########################################################################################

                    //2@#INICIO - COMPROBAR que no exista mas de una sincronizacion el mismo dia
                    Animal hembra = Animal.Buscar(this.IdHembra);
                    DateTime? Fecha;
                    if (this.FechaColocacion == null)
                        Fecha = this.FechaInyeccion;
                    else
                        Fecha = this.FechaColocacion;
                    if (Fecha != null)
                    {                       
                        List<SincronizacionCelo> lstSincCelos = SincronizacionCeloData.GetSincronizacionFecha(this.IdHembra, (DateTime)Fecha);


                        if (operacion == TipoOperacion.Actualizacion)
                        {
                            if ((lstSincCelos != null && lstSincCelos.Count > 1))
                                throw new LogicException("Solo puede existir una sincronización de celo por día, la hembra: " + hembra.Nombre + " ya tiene una sincronización para el día: " + ((DateTime)Fecha).ToShortDateString());

                        }
                        else if (operacion == TipoOperacion.Insercion)
                        {
                            if (lstSincCelos != null && lstSincCelos.Count > 0)
                                throw new LogicException("Solo puede existir una sincronización de celo por día, la hembra: " + hembra.Nombre + " ya tiene una sincronización para el día: " + ((DateTime)Fecha).ToShortDateString());
                        }
                    }
                    //2@#FIN - COMPROBAR que no exista mas de una sincronizacion el mismo dia
                    
                }


               
                
            }

            partial void OnFechaPrevisionChanged()
            {
                if (this.FechaPrevision < Fecha)
                    throw new LogicException("La fecha de previsión no puede ser menor que la fecha de la sincronización.");                

            }
            partial void OnFechaRetiradaChanged()
            {
                if (FechaColocacion!=null && FechaRetirada!=null)                
                    if (FechaRetirada < FechaColocacion)
                        throw new LogicException("La fecha de retirada no puede ser menor que la fecha de colocación.");                

            }
            partial void OnFechaColocacionChanged()
            {
                if (FechaColocacion != null && FechaRetirada != null)
                    if (FechaRetirada < FechaColocacion)
                        throw new LogicException("La fecha de colocación no puede ser mayor que la fecha de retirada.");                
                
            }
        #endregion


    }
}