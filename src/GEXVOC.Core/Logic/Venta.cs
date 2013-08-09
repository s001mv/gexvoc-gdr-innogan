using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Venta : Notificable,IClaseBase, IControlStock
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            ValidarLogica(TipoOperacion.Insercion);

            VentaData.Insertar(this);
            Movimiento.GenerarMovimiento(TipoOperacion.Insercion, this); 
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            Movimiento.GenerarMovimiento(TipoOperacion.Actualizacion, this); 
            VentaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            Movimiento.GenerarMovimiento(TipoOperacion.Borrado, this); 
            VentaData.Eliminar(this);
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Venta();
                    break;
                case TipoContexto.Modificacion:
                    rtno = VentaData.GetVentaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Venta a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Venta con el id especificado.</returns>
        public static Venta Buscar(int id)
        {
            return VentaData.GetVenta(id);
        }

        /// <summary>
        /// Obtiene las ventas que coinciden con los criterios de busqueda.
        /// </summary>
        /// <param name="idExplotacion">Id de la explotacion</param>
        /// <param name="idTipo">Id del tipo de venta</param>
        /// <param name="idProducto">Id del producto</param>
        /// <param name="idCliente">Id del cliente</param>
        /// <param name="concepto">Concepto de venta</param>
        /// <param name="cantidad">Cantidad de la venta</param>
        /// <param name="fecha">Fecha</param>
        /// <param name="importe">Importe de la venta</param>
        /// <param name="cobrada">Si la venta está cobrada o no</param>
        /// <returns></returns>
        public static List<Venta> Buscar(int? idExplotacion, int? idTipo, int? idProducto, int? idCliente, string concepto, 
            int? cantidad, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual, decimal? importe, Boolean? cobrada)
        {
            return VentaData.GetVentas(idExplotacion,idTipo,idProducto,idCliente,concepto,cantidad,fechaMayorIgual,fechaMenorIgual,importe,cobrada);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Venta
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Venta> Buscar()
        {
            return VentaData.GetVentas(null,null,null,null,string.Empty,null,null,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        /// <summary>
        /// Nos devuelve el nombre de la explotación.
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
        /// Obtiene la descripción del tipo de venta.
        /// </summary>
            public string DescTipo
            {
                get 
                {
                    string rtno = string.Empty;
                    if (this != null && this.TipoProducto != null)
                        rtno = this.TipoProducto.Descripcion;
                    return rtno;
                }
            }
        /// <summary>
        /// Obtiene la descripción del producto.
        /// </summary>
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
        /// <summary>
        /// Obtiene el nombre del cliente.
        /// </summary>
            public string DescCliente
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null && this.Cliente != null)
                        rtno = this.Cliente.Nombre;
                    return rtno;
                }
            }
        ///// <summary>
        ///// Obtiene el id del tipo de producto.
        ///// </summary>
        //    public int? DescIdTipoProducto
        //    {
        //        get
        //        {
        //            int? rtno = null;
        //            if (this != null && this.Producto != null && this.Producto.Tipo != null)
        //                rtno = this.Producto.Tipo.Id;
        //            return rtno;
        //        }
        //    }

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
                    int? rtno = null;
                    if (this != null && this.Producto != null && this.Producto.IdFamilia != null)
                        rtno = this.Producto.IdFamilia;

                    return rtno;
                }
            }



            ///// <summary>
            ///// Propiedad que devuelve la descripción de el/la Pagada a la que pertenece el elemento
            ///// </summary>
            public string DescCobrada
            {
                get
                {
                    string rtno = string.Empty;
                    if (this != null)
                        if (this.Cobrada)
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

        public static bool ProductoExistenteEnVentas(int idProducto)
        {return VentaData.ProductoExistenteEnVentas(idProducto);}

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación en curso que se debe validar.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {//Añadir código de validación      
            if (operacion== TipoOperacion.Insercion)
            {
                if (this.IdExplotacion == 0)//Establezco el valor predeterminado a la explotacion.
                    this.IdExplotacion = Configuracion.Explotacion.Id;
                
            }
        }


        //public void ControlStock()
        //    {
        //        BDController.IniciarTransaccion();
        //        Stock stockProductoVenta = Stock.BuscarProducto(this.IdProducto);
        //        try
        //        {
        //            if (stockProductoVenta != null)
        //            {
        //                if (stockProductoVenta.Cantidad >= this.Cantidad)
        //                {
        //                    stockProductoVenta.Cantidad -= (decimal)this.Cantidad;
        //                    stockProductoVenta.Actualizar();
        //                }
        //                else
        //                    throw new LogicException("No hay suficiente stock para realizar esa operación");
        //            }
        //            else
        //                throw new LogicException("No hay stock del producto seleccionado");
        //        }
        //        finally
        //        {
        //            stockProductoVenta = null;
        //            BDController.FinalizarTransaccion(true);
        //        }
        //    }

        partial void OnFechaChanged()
        {
            if (this.IdExplotacion == 0)
                this.IdExplotacion = Configuracion.Explotacion.Id;

            if (IdExplotacion>0)
            {
                Explotacion explotacion = Explotacion.Buscar(this.IdExplotacion);
                if (explotacion.FechaAlta > this.Fecha)
                    throw new LogicException("La fecha de la venta debe ser mayor que la fecha de alta de la explotación, correspondiente "
                        + "con el día: " + explotacion.FechaAlta.ToShortDateString());                
            }
            
        }

        #endregion


        #region CONTROL DE STOCK
        public decimal? CantidadAnterior { get; set; }
        partial void OnCantidadChanging(decimal? value) { CantidadAnterior = this.Cantidad; }
        public int? IdProductoAnterior { get; set; }
        partial void OnIdProductoChanging(int? value) { IdProductoAnterior = this.IdProducto; }      
        public DateTime? FechaAnterior { get; set; }
        public decimal? ImporteAnterior { get; set; }
        partial void OnImporteChanging(decimal value) { this.ImporteAnterior = this.Importe; }


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
                throw new LogicException("La venta proporcionada no tiene un producto válido para gestionar el stock.");



            movimiento.Identificacion = this.Id.ToString();
            movimiento.Tipo = TiposMovimientos.VENTA;
            movimiento.IdProducto = (int)this.IdProducto;
            movimiento.Cantidad = this.Cantidad ?? 0;
            try
            {
                movimiento.Precio = this.Importe / movimiento.Cantidad;
            }
            catch (Exception) { movimiento.Precio = 0; }

            
            movimiento.FechaEfecto = this.Fecha;
      


            if (operacion == TipoOperacion.Insercion || operacion== TipoOperacion.Actualizacion)
                movimiento.Cantidad *= -1;//Cambio de signo a la cantidad ya que la insercion o actualizacion resta stock

            //Establecer valores a las variables con sufijo _Anterior (cambiantes)
            if (operacion == TipoOperacion.Actualizacion)
            {
                movimiento.IdProductoAnterior = this.IdProductoAnterior ?? (int)this.IdProducto;
                movimiento.CantidadAnterior = this.CantidadAnterior ?? (decimal)this.Cantidad;//(anterior.Cantidad??decimal.Zero) * -1;
                try
                {
                    movimiento.PrecioAnterior = (this.ImporteAnterior ?? this.Importe) / (this.CantidadAnterior ?? (decimal)this.Cantidad);
                }
                catch (Exception) { movimiento.PrecioAnterior = 0; }
                
                movimiento.FechaEfectoAnterior = this.FechaAnterior ?? this.Fecha;
            }


            lstMovimientos.Add(movimiento);
            return lstMovimientos;
        }
        #endregion

    }
}
