using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class CondicionCorporal : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	CondicionCorporalData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	CondicionCorporalData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	CondicionCorporalData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new CondicionCorporal();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = CondicionCorporalData.GetCondicionCorporalOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una CondicionCorporal a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>CondicionCorporal con el id especificado.</returns>
            public static CondicionCorporal Buscar(int id){
                return CondicionCorporalData.GetCondicionCorporal(id);
            }

            /// <summary>
            /// Obtiene los/las CondicionCorporal que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<CondicionCorporal> Buscar(int? idHembra,int? idTipo,DateTime? fecha)
            {
                return CondicionCorporalData.GetCondicionesCorporales(idHembra,idTipo,fecha);
            }

            public static List<CondicionCorporal> Buscar(int? idHembra, int? idTipo, DateTime? fechaInicio,DateTime? fechaFin)
            {
                return CondicionCorporalData.GetCondicionesCorporales(idHembra, idTipo, fechaInicio, fechaFin);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo CondicionCorporal
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
 			public static List<CondicionCorporal> Buscar()
            {
                return CondicionCorporalData.GetCondicionesCorporales(null,null,null);
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
                    if (this != null && this.TipoCondicion != null)
                        rtno = this.TipoCondicion.Descripcion;

                    return rtno;
                }
            }

            ///// <summary>
            ///// Propiedad que devuelve el código del Tipo a la que pertenece el elemento
            ///// </summary>
            public string DescCodTipo
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.TipoCondicion != null)
                        rtno = this.TipoCondicion.Codigo.ToString();

                    return rtno;
                }
            }

            
            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la DetalleTipo a la que pertenece el elemento
            ///// </summary>
            public string DescDetalleTipo
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.TipoCondicion != null)
                        rtno = this.TipoCondicion.Detalle;

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
            }
         
        #endregion


    }
}