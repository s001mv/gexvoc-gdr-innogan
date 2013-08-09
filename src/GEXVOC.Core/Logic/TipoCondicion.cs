using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoCondicion : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	TipoCondicionData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	TipoCondicionData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	TipoCondicionData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new TipoCondicion();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = TipoCondicionData.GetTipoCondicionOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una TipoCondicion a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>TipoCondicion con el id especificado.</returns>
            public static TipoCondicion Buscar(int id){
                return TipoCondicionData.GetTipoCondicion(id);
            }

            /// <summary>
            /// Obtiene los/las TipoCondicion que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<TipoCondicion> Buscar(int? idEspecie, string codigo, string descripcion, string detalle,bool? apta)
            {
                return TipoCondicionData.GetTiposCondiciones(idEspecie, codigo, descripcion, detalle,apta);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo TipoCondicion
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
            public static List<TipoCondicion> Buscar()
            {
                return TipoCondicionData.GetTiposCondiciones(null,null,string.Empty,string.Empty,null);
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
            ///// Propiedad que devuelve la descripción de el/la Especie a la que pertenece el elemento
            ///// </summary>
            public string DescEspecie
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Especie != null)
                        rtno = this.Especie.Descripcion;

                    return rtno;
                }
            }

            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la TipoCondicion a la que pertenece el elemento
            ///// </summary>
            public string DescTipoCondicion
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null)
                        rtno = this.Codigo + " - " + this.Descripcion;

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
        	private void ValidarLogica(TipoOperacion operacion){}//Añadir código de validación
         
        #endregion


    }
}