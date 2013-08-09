using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class HistMedicamento : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	HistMedicamentoData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	HistMedicamentoData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	HistMedicamentoData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new HistMedicamento();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = HistMedicamentoData.GetHistMedicamentoOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una HistMedicamento a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>HistMedicamento con el id especificado.</returns>
            public static HistMedicamento Buscar(int id){
                return HistMedicamentoData.GetHistMedicamento(id);
            }

            /// <summary>
            /// Obtiene los/las HistMedicamento que coinciden con los criterios de búsqueda.
            /// </summary>
            /// <param name="nombre">Nombre.</param>  
            /// <param name="provincia">Provincia.</param>
            /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
            public static List<HistMedicamento> Buscar(int? idEspecie,int? idEnfermedad,int? idMedicamento)
            {
                return HistMedicamentoData.GetHistMedicamentos(idEspecie,idEnfermedad,idMedicamento);
            }

			/// <summary>
    	    /// Obtiene todos los registros del tipo HistMedicamento
	        /// </summary>
        	/// <returns>Devuelve todos los registros de la tabla></returns>
 			public static List<HistMedicamento> Buscar()
            {
                return HistMedicamentoData.GetHistMedicamentos(null,null,null);
            }


            /// <summary>
            /// Los retorna los medicamentos (Productos) que se han utilizado en una determinada enfermedad.
            /// </summary>
            /// <param name="idEnfermedad"></param>
            /// <returns></returns>
            public static List<Producto> BuscarMedicamento(int idEnfermedad)
            {
                return HistMedicamentoData.GetMedicamentos(idEnfermedad);
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
            ///// Propiedad que devuelve la descripción de el/la Medicamento a la que pertenece el elemento
            ///// </summary>
            public string DescMedicamento
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Producto != null)
                        rtno = this.Producto.Descripcion;

                    return rtno;
                }
            }

            
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
            ///// Propiedad que devuelve la descripción de el/la Enfermedad a la que pertenece el elemento
            ///// </summary>
            public string DescEnfermedad
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Enfermedad != null)
                        rtno = this.Enfermedad.Descripcion;

                    return rtno;
                }
            }
      
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public static bool ProductoExistenteEnHistMedicamentos(int idProducto)
        {return HistMedicamentoData.ProductoExistenteEnHistMedicamentos(idProducto);}

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
			/// <summary>
        	/// Valida la lógica de negocio, concluye si la operacion es admitida.
        	/// </summary>
        	/// <param name="operacion">Operación en curso que se debe validar.</param>
        	private void ValidarLogica(TipoOperacion operacion)
			{
                List<HistMedicamento> lstHistMedimamento = HistMedicamento.Buscar(this.IdEspecie, this.IdEnfermedad, this.IdMedicamento);
                if (lstHistMedimamento != null)
                {
                    if (operacion == TipoOperacion.Insercion && lstHistMedimamento.Count > 0)
                        throw new LogicException("No es posible insertar este elemento porque ya existe uno de iguales características");
                    if (operacion == TipoOperacion.Actualizacion && lstHistMedimamento.Count > 0 && lstHistMedimamento.First().IdMedicamento != this.Id)
                        throw new LogicException("No es posible actualizar este elemento porque ya existe uno de iguales características");                    
                                   
                }

                
                
               
            }
        
         
        #endregion


    }
}