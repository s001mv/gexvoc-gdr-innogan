using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TipoAlta : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	TipoAltaData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	TipoAltaData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	TipoAltaData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new TipoAlta();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = TipoAltaData.GetTipoAltaOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una TipoAlta a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>TipoAlta con el id especificado.</returns>
            public static TipoAlta Buscar(int id){
                return TipoAltaData.GetTipoAlta(id);
            }

            /// <summary>
            /// Obtiene los/las TipoAlta que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<TipoAlta> Buscar(string descripcion,bool? sistema)
            {
                return TipoAltaData.GetTiposAltas(descripcion,sistema);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo TipoAlta
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
            public static List<TipoAlta> Buscar()
            {
                return TipoAltaData.GetTiposAltas(string.Empty,null);
            }


       
        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

            ///// <summary>
            ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
            ///// </summary>
            //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }
      
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
                if (operacion == TipoOperacion.Borrado || operacion == TipoOperacion.Actualizacion)
                {
                    if (this.Sistema != null && (bool)this.Sistema)
                        throw new LogicException("El tipo de alta: '" + this.Descripcion + "' no se puede cambiar ni eliminar porque forma parte del sistema");

                }
            }
         
        #endregion


    }
}