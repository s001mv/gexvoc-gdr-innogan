using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Estancia : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        TipoOperacion _operacion = TipoOperacion.NoDefinida;

        public TipoOperacion Operacion
        {
            get { return _operacion; }
            set { _operacion = value; }
        }

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){            
    			ValidarLogica(TipoOperacion.Insercion);
            	EstanciaData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
             
				ValidarLogica(TipoOperacion.Actualizacion);
            	EstanciaData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){              
				ValidarLogica(TipoOperacion.Borrado);                
            	EstanciaData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new Estancia();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = EstanciaData.GetEstanciaOP(this.IdCubricion,this.IdMacho,this.FechaInicio);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una Estancia a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Estancia con el id especificado.</returns>
            public static Estancia Buscar(int idCubricion,int idMacho,DateTime fechaInicio){
                return EstanciaData.GetEstancia(idCubricion, idMacho, fechaInicio);
            }

            /// <summary>
            /// Obtiene los/las Estancia que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<Estancia> Buscar(int? idCubricion,int? idMacho, DateTime? fechaInicio, DateTime? fechaFin)
            {
                return EstanciaData.GetEstancias(idCubricion, idMacho, fechaInicio, fechaFin);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo Estancia
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
            public static List<Estancia> Buscar()
            {
                return EstanciaData.GetEstancias(null,null,null,null);
            }


       
        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

            ///// <summary>
            ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
            ///// </summary>
            //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }


            public int Id
            {
                get { return this.IdMacho; }
                set { }

            }
            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Macho a la que pertenece el elemento
            ///// </summary>
            public string DescMacho
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Animal != null)
                        rtno = this.Animal.Nombre;

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
                if (operacion== TipoOperacion.Insercion)
                {
                    //Comprobar que no se repite la clave.
                    if (Estancia.Buscar(IdCubricion, this.IdMacho,this.FechaInicio) != null)
                        throw new LogicException("No es posible asignar este macho y fecha porque ya se encuentra asignado a la Estacia actual");
                    
                }
            }

            partial void OnIdMachoChanging(int value)
            {
                //comprobar que no se cambie el valor de la clave (solo en actualizacion)
                if (this.IdMacho!=value && this.IdMacho!=0)        
                    throw new LogicException("No es posible cambiar el macho en una Estancia.");                 
            }
            partial void OnFechaInicioChanging(DateTime value) 
            {
                //comprobar que no se cambie el valor de la clave (solo en actualizacion)
                if (this.FechaInicio != value && this.FechaInicio!=Convert.ToDateTime("01/01/0001"))
                    throw new LogicException("No es posible cambiar la fecha en una Estancia");

                ////comprobar que la fecha inicio de la estancia se encuentra entre la fecha inicio de la cubricion y su fecha fin
                //Cubricion cubricion = Cubricion.Buscar(this.IdCubricion);
                //if (cubricion!=null)
                //{
                //    if (cubricion.FechaFin!=null)
                //    {
                //        if ((value < cubricion.FechaInicio) || (value > cubricion.FechaFin))
                //            throw new LogicException("La fecha proporcionada no es válida, debe proporcionarse una fecha entre: " +
                //                                        cubricion.FechaInicio + " y " + cubricion.FechaFin);                                              
                //    }
                //    else
                //        if (value < cubricion.FechaInicio)
                //            throw new LogicException("La fecha proporcionada no es válida, debe proporcionarse una fecha mayor a: " +
                //                                        cubricion.FechaInicio);
                                        
                    
                //}             
                
                
                    
                



            }


            partial void OnFechaFinChanged()
            {
                if (this.FechaFin != null)
                {
                    //Validar que la fecha fin de la estancia sea siempre mayor que la fecha inicio de la estancia
                    if (this.FechaFin < FechaInicio)
                        throw new LogicException("La fecha fin debe ser posterior o igual a la fecha de inicio, nunca anterior");

                    ValidarFecha((DateTime)this.FechaFin);
                
                }

            }
            partial void OnFechaInicioChanged()
            {            
                ValidarFecha(FechaInicio);
            }

        void ValidarFecha(DateTime fecha)
        {

            //comprobar que la fecha proporcionada de la estancia se encuentra entre la fecha inicio de la cubricion y su fecha fin
            Cubricion cubricion = Cubricion.Buscar(this.IdCubricion);
            if (cubricion != null)
            {
                if (cubricion.FechaFin != null)
                {
                    if ((fecha < cubricion.FechaInicio) || (fecha > cubricion.FechaFin))
                        throw new LogicException("La fecha proporcionada no es válida, debe proporcionarse una fecha entre: " +
                                                    cubricion.FechaInicio.ToShortDateString() + " y " + ((DateTime)cubricion.FechaFin).ToShortDateString());
                }
                else
                    if (fecha < cubricion.FechaInicio)
                        throw new LogicException("La fecha proporcionada no es válida, debe proporcionarse una fecha mayor a: " +
                                                    cubricion.FechaInicio);


            }
        }
         
        #endregion

        


    }
}