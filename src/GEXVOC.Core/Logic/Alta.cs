using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Alta : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	AltaData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	AltaData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	AltaData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new Alta();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = AltaData.GetAltaOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una Alta a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Alta con el id especificado.</returns>
            public static Alta Buscar(int id){
                return AltaData.GetAlta(id);
            }

            /// <summary>
            /// Obtiene los/las Alta que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<Alta> Buscar(int? idTipo,int? idAnimal,string detalle,DateTime? fecha)
            {
                return AltaData.GetAltas(idTipo,idAnimal,detalle,fecha);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo Alta
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
 			public static List<Alta> Buscar()
            {
                return AltaData.GetAltas(null,null,string.Empty,null);
            }
            public static Alta BuscarAnimal(int idAnimal)
            {
                return AltaData.GetAltaAnimal(idAnimal);
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
            ///// Propiedad que devuelve la descripción de el/la Tipo a la que pertenece el elemento
            ///// </summary>
            public string DescTipo
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.TipoAlta != null)
                        rtno = this.TipoAlta.Descripcion;

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
			{//Añadir código de validación

                //if (operacion==TipoOperacion.Actualizacion || operacion== TipoOperacion.Insercion)
                //{
                //    Animal animal = null;
                //    if (this.Animal != null)
                //        animal = this.Animal;
                //    else
                //        animal = Animal.Buscar(this.IdAnimal);


                //    if (animal != null)
                //    {
                       
                //    }
                    
                //}
                
              
            }
            partial void OnValidate(System.Data.Linq.ChangeAction action)
            {
                //throw new NotImplementedException();
                if (action==System.Data.Linq.ChangeAction.Insert || action==System.Data.Linq.ChangeAction.Update)
                {
                 

                    if (this.Animal!=null)
                    {
                        if (this.Fecha < this.Animal.FechaNacimiento)                        
                            throw new LogicException("No es posible asignar una fecha de alta anterior a la fecha del nacimiento");

                        if (this.Animal.BajaAnimal()!=null && this.Fecha>this.Animal.BajaAnimal().Fecha)                        
                            throw new LogicException("No es posible asignar una fecha de alta posterior a la fecha de baja");
                    }

                    
                }
                
            }

       
         
        #endregion


    }
}