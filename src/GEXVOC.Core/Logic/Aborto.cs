using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Aborto : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	AbortoData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	AbortoData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	AbortoData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new Aborto();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = AbortoData.GetAbortoOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una Aborto a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Aborto con el id especificado.</returns>
            public static Aborto Buscar(int id){
                return AbortoData.GetAborto(id);
            }

            /// <summary>
            /// Obtiene los/las Aborto que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<Aborto> Buscar(int? idHembra, int? idTipo, DateTime? fecha)
            {
                return AbortoData.GetAbortos(idHembra, idTipo, fecha);
            }
            public static List<Aborto> Buscar(int? idHembra, int? idTipo, DateTime? fechaInicio,DateTime? fechaFin)
            {
                return AbortoData.GetAbortos(idHembra, idTipo, fechaInicio, fechaFin);
            }


			/// <summary>
    	    /// Obtiene todos los registros del tipo Aborto
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
            public static List<Aborto> Buscar()
            {
                return AbortoData.GetAbortos(null,null,null);
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
            /// Propiedad que devuelve el nombre de la hembra a la que pertenece el aborto
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
            /// Propiedad que devuelve la descripción del tipo del aborto
            /// </summary>
            public string DescTipo
            {
                get
                {
                    string Desc = string.Empty;
                    if (this != null && this.TipoAborto != null)
                        Desc = this.TipoAborto.Descripcion;
                    return Desc;
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
			{//Añadir código de validación
                Animal hembra = Animal.Buscar(this.IdHembra);


                //Impedimos que se modifiquen o borren todos aquellos registros que no sean el último introducido
                if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Borrado)
                {
                    List<Aborto> lstAbortos = hembra.lstAbortos;
                    if (lstAbortos != null && lstAbortos.Count > 0)
                    {
                        Aborto UltimoAborto = lstAbortos.OrderByDescending(E => E.Id).First();
                        if (UltimoAborto.Id > this.Id)
                            throw new LogicException("Solo se puede modificar o borrar el último aborto introducido para el animal: " + hembra.Nombre + " , el resto de las operaciones se encuentran restringidas.");
                    }
                }


                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                {
                   

                    DateTime? UltimaFechaParto_Aborto = hembra.UltimaFechaParto_Aborto(this.IdHembra);
                    bool cubricionAbierta = false;
                    DateTime? UltimaFechaInseminacion_Cubricion = hembra.UltimaFechaInseminacion_Cubricion(this.IdHembra, ref cubricionAbierta);
                    //if (cubricionAbierta)
                    //    throw new LogicException("La hembra tiene una cubricion, pero se encuentra sin fecha fin, el proceso no puede continuar sin una fecha fin válida.");

                    if (UltimaFechaInseminacion_Cubricion == null)
                        throw new LogicException("La hembra no ha sido inseminada ni dispone de cubriciones.");
                    else
                    {
                        Aborto UltimoAborto = hembra.UltimoAborto();
                        if (UltimoAborto != null)
                        {
                            if (UltimaFechaInseminacion_Cubricion < UltimaFechaParto_Aborto && UltimoAborto.Id != this.Id)
                                throw new LogicException("La hembra no ha sido inseminada ni dispone de cubriciones desde el último parto o aborto.");
                        }
                        else
                            if (UltimaFechaInseminacion_Cubricion < UltimaFechaParto_Aborto)
                                throw new LogicException("La hembra no ha sido inseminada ni dispone de cubriciones desde el último parto o aborto.");

                        if (this.Fecha<UltimaFechaInseminacion_Cubricion)                       
                            throw new LogicException("La fecha del aborto debe ser posterior a la fecha de la última inseminación o cubrición,\r" +
                                                     "La la última fecha de inseminación o cubrición se corresponde con : " + UltimaFechaInseminacion_Cubricion.Value.ToShortDateString());
                            
                       
                    }
                }
                else //Borrado
                {    // No se pueden borrar partos con controles posteriores.
                    if (Animal.TieneControlPosterior(this.IdHembra, this.Fecha))
                        throw new LogicException("El aborto no puede ser eliminado porque tiene un control posterior.");
                    if (Animal.TieneSecadoPosterior(this.IdHembra, this.Fecha))
                        throw new LogicException("El aborto no puede ser eliminado porque tiene un secado posterior.");

                }

            }
         
        #endregion


    }
}