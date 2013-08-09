using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Compra : Notificable,IClaseBase,IControlStock
    {
        #region CONSTRUCTORES PERSONALIZADOS
        //public Compra(Compra stockActualizar)
        //{
        //    if (stockActualizar != null)
        //    { ActualizarStock(stockActualizar); }

        //}

        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            if (this.IdExplotacion == 0)//Establezco el valor predeterminado a la explotacion.
                this.IdExplotacion = Configuracion.Explotacion.Id;

            CompraData.Insertar(this);           
            Movimiento.GenerarMovimiento(TipoOperacion.Insercion, this);          
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            Movimiento.GenerarMovimiento(TipoOperacion.Actualizacion, this);                           
            CompraData.Actualizar(this); 
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {                   
                Movimiento.GenerarMovimiento(TipoOperacion.Borrado, this);
                CompraData.Eliminar(this);                     
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Compra();
                    break;
                case TipoContexto.Modificacion:
                    rtno = CompraData.GetCompraOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Compra a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Compra con el id especificado.</returns>
        public static Compra Buscar(int id)
        {
            return CompraData.GetCompra(id);
        }

        

        /// <summary>
        /// Obtiene los/las Compra que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Compra> Buscar(int? idExplotacion, int? idTipo, int? idProducto, int? idMacho, int? idProveedor,string concepto,
            int? cantidad,DateTime? fechaMayorIgual, DateTime? fechaMenorIgual, decimal? importe, Boolean? pagada)
        {
            return CompraData.GetCompras(idExplotacion,idTipo,idProducto,idMacho,idProveedor,concepto,cantidad,fechaMayorIgual, fechaMenorIgual,importe,pagada);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Compra
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Compra> Buscar()
        {
            return CompraData.GetCompras(null,null,null,null,null,string.Empty,null,null,null,null,null);
        }

        


        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID
        /// <summary>
        /// Nos devuelve la descripción de la explotación.
        /// </summary>
        public string DescExplotacion
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Explotacion != null)
                    rtno = this.Explotacion.Nombre;
                return rtno;
            }
        }
        /// <summary>
        /// Nos devuelve la descripción del tipo de compra.
        /// </summary>
        public string DescTipoClasificacion
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.TipoCompra != null)
                    rtno = this.TipoCompra.Descripcion;
                return rtno;
            }
        }
        /// <summary>
        /// Nos devuelve el nombre del proveedor.
        /// </summary>
        public string DescProveedor
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Proveedor != null)
                    rtno = this.Proveedor.Nombre;
                return rtno;
            }
        
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Producto a la que pertenece el elemento
        ///// </summary>
        public string DescProducto
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
        ///// Propiedad que devuelve la descripción de el/la TipoProducto a la que pertenece el elemento
        ///// </summary>
        public string DescTipoProducto
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.TipoProducto != null)
                    rtno = this.TipoProducto.Descripcion;

                return rtno;
            }
        }

        ///// <summary>
        ///// Nos devuelve el id del tipo de producto.
        ///// </summary>
        //public int? IdTipoProducto
        //{
        //    get
        //    {
        //        int? rtno = null;
        //        if (this != null && this.Producto != null && this.Producto.Tipo != null)
        //            rtno = this.Producto.Tipo.Id;
        //        return rtno;
        //    }
       
        //}


        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la IdFamilia a la que pertenece el elemento
        ///// </summary>
        public int? DescIdFamilia
        {
            get
            {
                int? rtno =null;
                if (this != null && this.Producto != null && this.Producto.IdFamilia != null)
                    rtno = this.Producto.IdFamilia;

                return rtno;
            }
        }


        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Pagada a la que pertenece el elemento
        ///// </summary>
        public string DescPagada
        {
            get
            {
                string rtno = string.Empty;
                if (this != null)
                    if (this.Pagada)                    
                        rtno = "SÍ";
                    else
                        rtno = "NO";

                return rtno;
            }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        public static bool ProductoExistenteEnCompras(int idProducto)
        { return CompraData.ProductoExistenteEnCompras(idProducto); }
        
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO
        partial void OnFechaChanging(DateTime value)
        {
            this.FechaAnterior = this.Fecha;//Linea específica del control de stock   
            if (this.IdExplotacion == 0)
                this.IdExplotacion = Configuracion.Explotacion.Id;

            Explotacion explotacion = Explotacion.Buscar(this.IdExplotacion);
            if (value < explotacion.FechaAlta)
                throw new LogicException("La fecha de la compra debe ser superior a la fecha de alta de la explotación");
    
            
            
        }

        //public void EliminarStock(int? idProducto)
        //{
        //    Stock stockProducto = Stock.BuscarProducto(idProducto);
        //    BDController.IniciarTransaccion();
        //    try
        //    {
        //        if (stockProducto != null)
        //        {
        //            stockProducto.Eliminar();
        //        }   
        //            else
        //                throw new LogicException("No hay suficiente stock para realizar la operación");
        //    }
        //    catch
        //    {
        //        throw new LogicException("No se ha podido guardar la relación con el stock");
                
        //    }
        //    finally
        //    {
        //        stockProducto = null;
        //        BDController.FinalizarTransaccion(true);
        //    }

        //}
        
        
        //public void InsertarStock(int idExplotacion, int? idProducto, int? idMacho, DateTime fecha, decimal? cantidad, decimal importe)
        //{
        //    ////Stock stockProducto = new Stock();
        //    ////Stock productoExistente = Stock.BuscarProducto(idProducto);
        //    ////BDController.IniciarTransaccion();
        //    ////try
        //    ////{
        //    ////    if (cantidad != null)
        //    ////    {
        //    ////        if (productoExistente != null)
        //    ////        {
        //    ////            productoExistente.Cantidad += (decimal)cantidad;
        //    ////            stockProducto.Cantidad = productoExistente.Cantidad;
        //    ////        }
        //    ////        else
        //    ////        {
        //    ////            stockProducto.Cantidad =(decimal) cantidad;
        //    ////        }

        //    ////        stockProducto.Precio = importe /(decimal) cantidad;
        //    ////    }
        //    ////    else
        //    ////    {
        //    ////        stockProducto.Cantidad = 0;
        //    ////        stockProducto.Precio = 0;
        //    ////    }
        //    ////    stockProducto.IdExplotacion = idExplotacion;
        //    ////    if(idProducto!=null)
        //    ////        stockProducto.IdProducto =(int)idProducto;
        //    ////    if (idMacho != null)
        //    ////        stockProducto.IdMacho = idMacho;
        //    ////    stockProducto.Fecha = fecha; 
        //    ////    stockProducto.Insertar();

        //    ////}
        //    ////catch (Exception)
        //    ////{
        //    ////    throw new LogicException("No se ha podido guardar la relación con el stock");
        //    ////}
        //    ////finally
        //    ////{
        //    ////    stockProducto = null;
        //    ////    productoExistente = null;
        //    ////    BDController.FinalizarTransaccion(true);
        //    ////}
        //}

        ////public void ActualizarStock(Compra ObjetoActualizar)
        ////{
        ////    BDController.IniciarTransaccion();
        ////    if (ObjetoActualizar !=null && this != null)
        ////    {
        ////        EliminarStock(ObjetoActualizar.IdProducto);
        ////        InsertarStock(this.IdExplotacion, this.IdProducto, this.IdMacho, this.Fecha, this.Cantidad, this.Importe);
        ////        this.Actualizar();
        ////    }
        ////    BDController.FinalizarTransaccion(true);
        ////}

        #endregion

        #region CONTROL DE STOCK
            public decimal? CantidadAnterior { get; set; }            
            partial void OnCantidadChanging(decimal? value){CantidadAnterior = this.Cantidad;}
            public int? IdProductoAnterior { get; set; }
            partial void OnIdProductoChanging(int? value){IdProductoAnterior = this.IdProducto;}        
            public int? IdMachoAnterior { get; set; }
            partial void  OnIdMachoChanging(int? value){ IdMachoAnterior = this.IdMacho; }       
            public DateTime? FechaAnterior { get; set; }
            public decimal? ImporteAnterior { get; set; }
            partial void OnImporteChanging(decimal value){this.ImporteAnterior=this.Importe;}


            /// <summary>
            /// Convierto la clase actual a partir de sus valores actuales en clases del tipo 'MovimientoDefinicion'
            /// susceptibles de crear stock.
            /// Esta conversión se lleva a cabo en Movimiento.GenerarMovimiento(TipoOperacion operacion,object clase) 
            /// que es llamada cada vez que se confirma una operación en clase que implementa la interface IControlStock.
            /// Nota: NO se debe llamar esplicitamente a este método.
            /// </summary>
            /// <param name="operacion"></param>
            /// <returns></returns>
            public List<MovimientoDefinicion> ToMovimiento(TipoOperacion operacion)
            {
                List<MovimientoDefinicion> lstMovimientos = new List<MovimientoDefinicion>();

                MovimientoDefinicion movimiento = new MovimientoDefinicion();
                movimiento.Operacion = operacion;
             
                if (this.IdProducto == null)//No tiene sentido llevar stock si no se compran productos.                                
                    throw new LogicException ("La compra proporcionada no tiene un producto válido para gestionar el stock.");



                movimiento.Identificacion = this.Id.ToString();
                movimiento.Tipo = TiposMovimientos.COMPRA;
                movimiento.IdProducto = (int)this.IdProducto;
                movimiento.Cantidad = this.Cantidad ?? 0;
                try
                {
                    movimiento.Precio = this.Importe / movimiento.Cantidad;
                }
                catch (Exception) { movimiento.Precio = 0; }

                movimiento.FechaEfecto = this.Fecha;
                movimiento.IdMacho = this.IdMacho;


                if (operacion == TipoOperacion.Borrado)
                    movimiento.Cantidad *= -1;//Cambio de signo a la cantidad ya que el borrado de la tabla Compra resta stock.

                //Establecer valores a las variables con sufijo _Anterior (cambiantes)
                if (operacion == TipoOperacion.Actualizacion)
                {
                    movimiento.IdProductoAnterior = this.IdProductoAnterior ?? (int)this.IdProducto;
                    movimiento.CantidadAnterior = this.CantidadAnterior ?? (decimal)this.Cantidad;//(anterior.Cantidad??decimal.Zero) * -1;
                    try
                    {
                        movimiento.PrecioAnterior = (this.ImporteAnterior ?? this.Importe) / (this.CantidadAnterior ?? (decimal)this.Cantidad);
                    }
                    catch (Exception){movimiento.PrecioAnterior = 0;}
                    
                    movimiento.FechaEfectoAnterior = this.FechaAnterior ?? this.Fecha;
                    movimiento.IdMachoAnterior = this.IdMachoAnterior ?? this.IdMacho;

                    movimiento.CantidadAnterior *= -1;//Cambio de signo a la cantidad anterior ya que la Compra Anterior se resta del stock.
                }


                lstMovimientos.Add(movimiento);
                return lstMovimientos;
            }
        #endregion


    }
}
