using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Baja : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	BajaData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	BajaData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	BajaData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new Baja();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = BajaData.GetBajaOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una Baja a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Baja con el id especificado.</returns>
            public static Baja Buscar(int id){
                return BajaData.GetBaja(id);
            }
            public static Baja BuscarAnimal(int idAnimal){
                return BajaData.GetBajaAnimal(idAnimal);
            }


            /// <summary>
            /// Obtiene los/las Baja que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            //public static List<Baja> Buscar(string descripcion)
            //{
            //    return BajaData.GetBajas(descripcion);
            //}

			/// <summary>
    	    /// Obtiene todos los registros del tipo Baja
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
 			//public static List<Baja> Buscar()
            //{
            //    return BajaData.GetBajas(string.Empty);
            //}


       
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
                    if (this != null && this.TipoBaja != null)
                        rtno = this.TipoBaja.Descripcion;

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
            partial void OnFechaChanged()
            {
                if (IdAnimal > 0)
                {
                    Animal animal = Animal.Buscar(this.IdAnimal);
                    Alta alta = animal.AltaAnimal();
                    if (animal!=null && alta!=null)
                    {
                        if (Fecha < alta.Fecha)
                            throw new LogicException("La fecha de Baja debe ser mayor o igual a la fecha de alta del animal.");
                        
                    }                  


                }
                else//Cuando no tenemos animal lanzamos una excepción al no poder validar su fecha de nacimiento, esto se suele producir
                    //en el formulario EditAnimales cuando todavía no se ha guardado el animal.
                    throw new LogicException("La fecha de Baja no puede ser validada porque no es posible acceder al animal.\r" +
                        "Asegúrese de que el animal esta guardado correctamente antes de establecerle información referente a su Baja.");


            }
        #endregion


    }
}