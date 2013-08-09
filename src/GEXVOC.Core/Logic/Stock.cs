using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Stock : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        
           
        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        	/// <summary>
        	/// Guarda (Crea un nuevo registro).
        	/// </summary>
        	public void Insertar(){
    			ValidarLogica(TipoOperacion.Insercion);
            	StockData.Insertar(this);            
        	}

        	/// <summary>
        	/// Actualiza (Modifica un registro existente).
        	/// </summary>
	        public void Actualizar(){
				ValidarLogica(TipoOperacion.Actualizacion);
            	StockData.Actualizar(this);
			}

        	/// <summary>
        	/// Elimina un registro existente.
        	/// </summary>
       	 	public void Eliminar(){
				ValidarLogica(TipoOperacion.Borrado);
            	StockData.Eliminar(this);            
        	}
       
			
        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        	public IClaseBase CargarContextoOperacion(TipoContexto Modo){ 
                IClaseBase rtno=null;
			    switch (Modo)
                {
                	case TipoContexto.Insercion:
                    	rtno = new Stock();
	                    break;
    	            case TipoContexto.Modificacion:
        	            rtno = StockData.GetStockOP(this.Id);
            	        break;               
            	}             
                return rtno;
            	
        	}


            /// <summary>
            /// Obtiene un/una Stock a partir de su id.
            /// </summary>
            /// <param name="id">Id.</param>
            /// <returns>Stock con el id especificado.</returns>
            public static Stock Buscar(int id){
                return StockData.GetStock(id);
            }

         /// <summary>
        /// Obtiene la última linea en el stock del producto que estamos buscando.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public static Stock BuscarProducto(int? idProducto)
        {
            return StockData.GetStockproducto(idProducto);
        }
        public static Stock BuscarProducto(int idProducto,int? idMacho)
        {
            Stock rtno = null;
            List<Stock> lstStock = Buscar(Configuracion.Explotacion.Id, idProducto, idMacho, null, null);
            if (lstStock!=null && lstStock.Count>0)
                rtno=lstStock.First();

            return rtno;
        }


        /// <summary>
        /// Obtiene los/las Stock que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Stock> Buscar(int? idExplotacion, int? idProducto, int? idMacho, decimal? cantidad, decimal? precio)
        {
            return StockData.GetStocks(idExplotacion,idProducto,idMacho,cantidad,precio);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Stock
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Stock> Buscar()
        {
            return Buscar(null, null, null, null, null);
        }
        public static decimal PrecioProducto(int idProducto,int? idMacho)
        {
            decimal rtno=decimal.Zero;
            Stock stock = BuscarProducto(idProducto, idMacho);
            if (stock != null)
                rtno = stock.Precio;

            return rtno;
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
        ///// Propiedad que devuelve la descripción de el/la Producto a la que pertenece el elemento
        ///// </summary>
        public string DescProducto
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Producto != null)
                    rtno = this.Producto.DescAmpliada;

                if (this.IdMacho!=null)//Si el stock pertenece a un macho, agregamos su nombre a la descripcion del producto.
                {
                    Animal animal = Animal.Buscar((int)this.IdMacho);
                    if (animal!=null)                    
                        rtno += " - SEMENTAL: " + animal.Nombre;
                    
                }

                return rtno;
            }
        }


        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Tipo a la que pertenece el elemento
        ///// </summary>
        public string DescTipoProducto
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Producto != null && this.Producto.Tipo!=null)
                    rtno = this.Producto.Tipo.Descripcion;

                return rtno;
            }
        }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public static void GenerarStock(int idProducto, decimal cantidad, decimal? precio,int? idMacho) 
        {
            List<Stock> lststockProducto = Logic.Stock.Buscar(Configuracion.Explotacion.Id, idProducto, idMacho, null,null);
            Stock Stock = null;
           
            if (lststockProducto != null && lststockProducto.Count > 0)
                Stock = lststockProducto.First();//lststockProducto.OrderByDescending(E => E.Id).First();


            if (Stock != null)
            {
                Stock = (Stock)Stock.CargarContextoOperacion(TipoContexto.Modificacion);
                Stock.Cantidad += cantidad;                
                Stock.Precio = precio ?? Stock.Precio;
                Stock.Actualizar();
            }
            else
            {
                Stock = new Stock();
                Stock.IdProducto = idProducto;
                Stock.IdExplotacion = Configuracion.Explotacion.Id;
                Stock.IdMacho = idMacho;
                Stock.Cantidad = cantidad;
                Stock.Precio = precio??0;
                Stock.Insertar();
            }

            //if (Stock.Cantidad < 0) throw new LogicStockException("No es posible continuar con la operación porque esta probocaría que la cantidad del producto adquiera un valor negativo");

        }
      
   


        public static bool ProductoExistenteEnStocks(int idProducto)
        {return StockData.ProductoExistenteEnStocks(idProducto);}


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