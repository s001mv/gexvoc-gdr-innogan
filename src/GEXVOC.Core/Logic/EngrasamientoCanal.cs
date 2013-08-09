using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class EngrasamientoCanal : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	EngrasamientoCanalData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	EngrasamientoCanalData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	EngrasamientoCanalData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new EngrasamientoCanal();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = EngrasamientoCanalData.GetEngrasamientoCanalOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una EngrasamientoCanal a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>EngrasamientoCanal con el id especificado.</returns>
            public static EngrasamientoCanal Buscar(int id){
                return EngrasamientoCanalData.GetEngrasamientoCanal(id);
            }

            /// <summary>
            /// Obtiene los/las EngrasamientoCanal que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<EngrasamientoCanal> Buscar(int? idAnimal,int? idTipo,DateTime? fecha)
            {
                return EngrasamientoCanalData.GetEngrasamientosCanal(idAnimal,idTipo,fecha);
            }
            public static List<EngrasamientoCanal> Buscar(int? idAnimal, int? idTipo, DateTime? fechaInicio,DateTime? fechaFin)
            {
                return EngrasamientoCanalData.GetEngrasamientosCanal(idAnimal, idTipo, fechaInicio, fechaFin);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo EngrasamientoCanal
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
 			public static List<EngrasamientoCanal> Buscar()
            {
                return EngrasamientoCanalData.GetEngrasamientosCanal(null, null, null);
            }


            public static EngrasamientoCanal BuscarAnimal(int idAnimal)
            {
                return EngrasamientoCanalData.GetEngrasamientoCanalAnimal(idAnimal);
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

            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Tipo a la que pertenece el elemento
            ///// </summary>
            public string DescTipo
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Tipo != null)
                        rtno = this.Tipo.Descripcion;

                    return rtno;
                }
            }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.
      

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
            /////// <summary>
            /////// Valida la lógica de negocio, concluye si la operacion es admitida.
            /////// </summary>
            /////// <param name="operacion">Operación en curso que se debe validar.</param>
           private void ValidarLogica(TipoOperacion operacion){
            ////{//Añadir código de validación
            ////    if (operacion== TipoOperacion.Insercion )
            ////    {
            ////        Animal animal = Animal.Buscar(this.IdAnimal);
            ////        if (animal!=null)
            ////        {
                        
            ////            if (animal.BajaAnimal() == null)
            ////                throw new LogicException("El animal: " + animal.Nombre + " no ha sido dado de baja, por tanto " +
            ////                                         "no es posible asignar su Engrasamiento a la canal");
            ////        }
                    
            ////    }
            }

           partial void OnFechaChanged()
           {
               if (IdAnimal > 0)
               {
                   Animal animal = Animal.Buscar(this.IdAnimal);
                   if (Fecha < animal.FechaNacimiento)
                       throw new LogicException("La fecha de Engrasamiento a la Canal debe ser mayor a la fecha de nacimiento del animal.");


               }
               else//Cuando no tenemos animal lanzamos una excepción al no poder validar su fecha de nacimiento, esto se suele producir
                   //en el formulario EditAnimales cuando todavía no se ha guardado el animal.
                   throw new LogicException("La fecha de Engrasamiento a la Canal no puede ser validada porque no es posible acceder al animal.\r" +
                       "Asegúrese de que el animal esta guardado correctamente antes de establecerle información referente a su Engrasamiento a la Canal.");


           }
         
        #endregion


    }
}