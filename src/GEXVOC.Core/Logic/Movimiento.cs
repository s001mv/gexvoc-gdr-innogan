using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public enum TiposMovimientos 
    { 
        NO_DEFINIDO,
        COMPRA,
        VENTA,
        ALIMENTACION_ANIMAL,
        SIEMBRA_FINCAS,
        RECOLECTA_FINCAS,
        INSEMINACION,
        HIGIENE,
        PROFILAXIS,
        REGULARIZACION,
        ABONADO_FINCAS,
        TRATAMIENTO_FINCAS,
        TRAZABILIDAD
    }    
    public partial class Movimiento : IClaseBase
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

            Stock.GenerarStock(this.IdProducto, this.Cantidad, this.Precio, this.IdMacho);                      

            MovimientoData.Insertar(this);
            
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            throw new LogicException("No se puede actualizar la clase movimiento.");        
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            throw new LogicException("No se puede eliminar la clase movimiento.");           
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Movimiento();
                    break;
                case TipoContexto.Modificacion:
                    rtno = MovimientoData.GetMovimientoOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Movimiento a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Movimiento con el id especificado.</returns>
        public static Movimiento Buscar(int id)
        {
            return MovimientoData.GetMovimiento(id);
        }

        /// <summary>
        /// Obtiene los/las Movimiento que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Movimiento> Buscar(int? idExplotacion,int? idProducto,int? idMacho,string origen,string identificacion,
            DateTime? fecha,decimal? cantidad,decimal? precio)
        {
            return MovimientoData.GetMovimiento(idExplotacion,idProducto,idMacho,origen,identificacion,fecha,cantidad,precio);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Movimiento
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Movimiento> Buscar()
        {
            return Buscar(null,null,null,null,null,null,null,null);
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
                if (this != null && this.Producto != null && this.Producto.Tipo!=null)
                    rtno = this.Producto.Tipo.Descripcion;

                return rtno;
            }
        }

        public int? DescIdTipoProducto
        {
            get
            {
                int? rtno = null;
                if (this != null && this.Producto != null )
                    rtno = this.Producto.IdTipo;

                return rtno;
            }
        }


        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la FamiliaProducto a la que pertenece el elemento
        ///// </summary>
        public string DescFamiliaProducto
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Producto != null)
                    rtno = this.Producto.DescFamilia;

                return rtno;
            }
        }

        public int? DescIdFamiliaProducto
        {
            get
            {
                int? rtno = null;
                if (this != null && this.Producto != null)
                    rtno = this.Producto.IdFamilia;

                return rtno;
            }
        }

        
        ///// <summary>
        ///// Propiedad que devuelve la descripción de el/la Macho a la que pertenece el elemento
        ///// </summary>
        public string DescMacho
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

        /// <summary>
        /// Crea un movimiento que genera cambios de stock.
        /// Esta función debe ser llamada especificamente desde lógica.
        /// Es llamada desde el Procedimiento GenerarMovimiento. 
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="idProducto"></param>
        /// <param name="idMacho"></param>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <param name="identificacion"></param>
        /// <param name="fechaEfecto"></param>
        public static void CrearMovimiento(TiposMovimientos tipo, int idProducto, int? idMacho, decimal cantidad, decimal? precio, string identificacion, DateTime? fechaEfecto) 
        {
            ///INICIO - COMPROBAR QUE EL PRODUCTO TENGA CONTROL DE STOCK
            ///Todos los productos llevan control de stock excepto los Medicamentos.
            Producto producto = Producto.Buscar(idProducto);
            if (producto!=null && producto.IdTipo==Configuracion.TipoProductoSistema(Configuracion.TiposProductosSistema.SANIDAD).Id)            
                return;//Es un medicamento, no continuo con el control de stock.
            ///FIN - COMPROBAR QUE EL PRODUCTO TENGA CONTROL DE STOCK
            
            Movimiento movimiento = new Movimiento();
            movimiento.IdExplotacion = Configuracion.Explotacion.Id;
            movimiento.Origen = tipo.ToString().Replace("_"," ");
            movimiento.Fecha = DateTime.Now;
            movimiento.FechaEfecto = fechaEfecto;
            movimiento.IdProducto = idProducto;
            movimiento.IdMacho = idMacho;
            movimiento.Cantidad = cantidad;
            movimiento.Precio = precio;
            movimiento.Identificacion = identificacion;
            movimiento.Insertar();
        }
    
        /// <summary>
        /// Se encarga de generar movimientos específicos segun el tipo de clase que le sea enviado como argumento.
        /// el resultado final será uno o varios movimientos.
        /// </summary>
        /// <param name="operacion">Indica la operación que está siendo ejecutada en la clase</param>
        /// <param name="clase">Clase sobre la que se realiza una operación (la clase debe implementar IControlStock)</param>
        public static ResultadoOperacion GenerarMovimiento(TipoOperacion operacion,object clase)         
        {
            ResultadoOperacion rtno = new ResultadoOperacion() { OperacionCorrecta=true};
            List<MovimientoDefinicion> lstMovimientos = null;

            if (clase.GetType().GetInterface(typeof(IControlStock).Name) != null)
            {
                try
                {
                    lstMovimientos = ((IControlStock)clase).ToMovimiento(operacion);

                    ///CONTINUAMOS CON EL PROCESO DESPUES DE LLAMAR AL MÉTODO TOMOVIMIENTO

                    if (lstMovimientos != null && lstMovimientos.Count > 0)
                    {
                        foreach (MovimientoDefinicion movimiento in lstMovimientos)
                        {
                            if (movimiento.Operacion == TipoOperacion.NoDefinida)
                                throw new LogicException("No se ha especificado la operación del movimiento, el proceso no puede continuar");

                            // ******* CREACIÓN DE MOVIMIENTOS ******* (Depende de las inicializaciones de las variables anteriores específicas según tipo)
                            if (movimiento.Operacion == TipoOperacion.Actualizacion)
                            {
                                //La actualización solo se realiza en caso de que cambie alguno de los valores que afectan al stock, el resto
                                //se consideran actualizaciones de campos básicos que no tienen por que generar movimientos como la actualización de un 
                                //campo descripcion, foto etc...
                                if (movimiento.Cantidad != (movimiento.CantidadAnterior * -1) || movimiento.IdProducto != movimiento.IdProductoAnterior ||
                                    movimiento.FechaEfecto != movimiento.FechaEfectoAnterior || movimiento.Precio != movimiento.PrecioAnterior ||
                                    movimiento.IdMacho != movimiento.IdMachoAnterior)
                                {
                                    CrearMovimiento(movimiento.Tipo, movimiento.IdProductoAnterior, movimiento.IdMachoAnterior, movimiento.CantidadAnterior, movimiento.PrecioAnterior, movimiento.Identificacion, movimiento.FechaEfectoAnterior);
                                    CrearMovimiento(movimiento.Tipo, movimiento.IdProducto, movimiento.IdMacho, movimiento.Cantidad, movimiento.Precio, movimiento.Identificacion, movimiento.FechaEfecto);
                                }
                            }
                            else//En las inserciones y borrados siempre se crea movimientos (Que actualizan el stock)
                                //Los pasos anteriores seleccionados por clases se encargan de que estos sean de adicción o sustraccion de stock (mediante el signo proporcionado a cantidad).
                                CrearMovimiento(movimiento.Tipo, movimiento.IdProducto, movimiento.IdMacho, movimiento.Cantidad, movimiento.Precio, movimiento.Identificacion, movimiento.FechaEfecto);


                            ///INFORMACION SOBRE EL STOCK.
                            Stock stockProducto = Stock.BuscarProducto(movimiento.IdProducto, movimiento.IdMacho);
                            if (stockProducto != null && stockProducto.Cantidad < 0)
                                rtno.Mensaje += "La operación concluída ha dejado el stock del producto: " + stockProducto.DescProducto + " en una cantidad negativa. (" + stockProducto.Cantidad.ToString() + ")\r";

                            if (movimiento.IdProductoAnterior != 0 && movimiento.IdProductoAnterior != movimiento.IdProducto)//Si se ha cambiado el producto en la moficicacion, tendremos que ofrecer tb estadísticas de si el producto anterior ha quedado a negativo
                            {
                                Stock stockProductoAnterior = Stock.BuscarProducto(movimiento.IdProductoAnterior, movimiento.IdMachoAnterior);
                                if (stockProductoAnterior != null && stockProductoAnterior.Cantidad < 0)
                                    rtno.Mensaje += "La operación concluída ha dejado el stock del producto: " + stockProductoAnterior.DescProducto + " en una cantidad negativa. (" + stockProductoAnterior.Cantidad.ToString() + ")\r";
                            }
                        }
                    }
                }
                catch (LogicException ex)
                {
                    rtno.OperacionCorrecta = false;
                    rtno.Mensaje = ex.Message;                    
                }
            }
            else
            {
                rtno.OperacionCorrecta = true;
                rtno.Mensaje = "El Objeto proporcionado no implementa IControlStock. Se omitirá cualquier operación";                          
            }


            //Si la clase es una clase que posee la capacidad de notificar cosas, establezo la información del mensaje que proporciona
            //el retorno de este procedimiento.
            if (clase.GetType().GetInterface(typeof(INotificable).Name) != null)            
                ((INotificable)clase).MensajeNotificar = rtno;
            
            
        
            return rtno;
        }

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