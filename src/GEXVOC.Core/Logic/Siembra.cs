using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Logic
{
    public partial class Siembra : Notificable,IClaseBase,IControlStock,IControlGasto
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
          

          
             
                
                SiembraData.Insertar(this);                  
                Movimiento.GenerarMovimiento(TipoOperacion.Insercion, this);
                Logic.Gasto.GenerarGasto(TipoOperacion.Insercion, this);

//                ControlGasto(TipoOperacion.Insercion);

            //    if (TransacionPropia)
            //        BDController.FinalizarTransaccion(true);
            //}
            //catch (Exception ex)
            //{
            //    if (TransacionPropia)
            //        BDController.FinalizarTransaccion(false);

            //    Traza.RegistrarError(ex);
            //    throw new LogicException(ex.Message);
            //}
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            //bool TransacionPropia = false;

            //try
            //{
            //    TransacionPropia = BDController.IniciarTransaccion();

                //ControlStock((decimal)(CantidadAnterior ?? this.Cantidad) * -1);
                //decimal PVP = ControlStock(this.Cantidad);
                                  
                Movimiento.GenerarMovimiento(TipoOperacion.Actualizacion, this);
                Logic.Gasto.GenerarGasto(TipoOperacion.Actualizacion,this);
                SiembraData.Actualizar(this);

                //if (TransacionPropia)
                //    BDController.FinalizarTransaccion(true);
            //}
            //catch (Exception ex)
            //{
            //    if (TransacionPropia)
            //        BDController.FinalizarTransaccion(false);

            //    Traza.RegistrarError(ex);
            //    throw new LogicException(ex.Message);
            //}
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            //bool TransacionPropia = false;

            //try
            //{
            //    //TransacionPropia = BDController.IniciarTransaccion();
                

                Movimiento.GenerarMovimiento(TipoOperacion.Borrado, this);         
                Logic.Gasto.GenerarGasto(TipoOperacion.Borrado, this);
                SiembraData.Eliminar(this);

            //    if (TransacionPropia)
            //        BDController.FinalizarTransaccion(true);
            //}
            //catch (Exception ex)
            //{
            //    if (TransacionPropia)
            //        BDController.FinalizarTransaccion(false);

            //    Traza.RegistrarError(ex);
            //    throw new LogicException(ex.Message);
            //}
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Siembra();
                    break;
                case TipoContexto.Modificacion:
                    rtno = SiembraData.GetSiembraOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Siembra a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Siembra con el id especificado.</returns>
        public static Siembra Buscar(int id)
        {
            return SiembraData.GetSiembra(id);
        }

        /// <summary>
        /// Obtiene los/las Siembra que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Siembra> Buscar(int? idSemilla, int? idParcela, decimal? cantidad, DateTime? fecha)
        {
            return SiembraData.GetSiembras(idSemilla, idParcela, cantidad, fecha);
        }

        public static List<Siembra> Buscar(int? idSemilla, int? idParcela, decimal? cantidad, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            return SiembraData.GetSiembras(idSemilla, idParcela, cantidad, fechaMayorIgual, fechaMenorIgual);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Siembra
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Siembra> Buscar()
        {
            return SiembraData.GetSiembras(null,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID
        /// <summary>
        /// Devuelve el nombre de la parcela.
        /// </summary>
        public string DescParcela
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Parcela != null)
                    rtno = this.Parcela.Nombre;
                return rtno;
            }
        
        }
        /// <summary>
        /// Devuelve la descripción del producto en este caso semilla.
        /// </summary>
        public string DescSemilla
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Semilla != null)
                    rtno = this.Semilla.Descripcion;
                return rtno;
            }
        }
        
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.



       
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        //private decimal? CantidadAnterior = null;

        ///// <summary>
        ///// Controla el cambio de cantidad para las tareas con stock y gasto asociado.
        ///// </summary>
        //partial void OnCantidadChanging(decimal value)
        //{
        //    CantidadAnterior = this.Cantidad;
        //}

        //public decimal ControlStock(decimal cantidad)
        //{
        //    decimal PVP = decimal.Zero;

        //    Parcela parcela = Parcela.Buscar(this.IdParcela);

        //    decimal Total = cantidad * parcela.Extension;

        //    Stock stockSemilla = Stock.BuscarProducto(this.IdSemilla);

        //    try
        //    {
        //        if (stockSemilla != null)
        //        {
        //            if (stockSemilla.Cantidad >= Total)
        //            {
        //                PVP = stockSemilla.Precio;

        //                stockSemilla.Cantidad -= Total;
        //                stockSemilla.Actualizar();
        //            }
        //            else
        //                throw new LogicException("No hay suficiente stock para realizar esa operación");
        //        }
        //        else
        //            throw new LogicException("No hay stock del producto seleccionado");
        //    }
        //    finally
        //    {
        //        stockSemilla = null;
        //    }

        //    return PVP;
        //}

        ///// <summary>
        ///// Controla el gasto producido por la siembra.
        ///// </summary>
        ///// <param name="operacion">Operación realizada con la siembra.</param>
        ///// <param name="importe">Importe del gasto asociado.</param>
        //private void ControlGasto(TipoOperacion operacion)
        //{
        //    decimal importe = Stock.PrecioProducto(this.IdSemilla, null);            
            
        
        //    switch (operacion)
        //    {
        //        case TipoOperacion.Insercion:
        //            new Gasto
        //            {
        //                IdExplotacion = Configuracion.Explotacion.Id,
        //                IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.SIEMBRA_FINCAS).Id,
        //                IdParcela = this.IdParcela,
        //                IdSiembra = this.Id,
        //                Fecha = this.Fecha,
        //                Importe = importe * this.Cantidad * Parcela.Buscar(this.IdParcela).Extension

        //            }.Insertar();

        //            break;
        //        case TipoOperacion.Borrado:
        //            List<Gasto> lstGasto = Logic.Gasto.Buscar(null, null, null, null, null, null, null, this.Id, null, null, string.Empty, null, null, null,null);
        //            if (lstGasto!=null && lstGasto.Count>0)                    
        //                lstGasto.First().Eliminar();
                    

        //            break;
        //        case TipoOperacion.Actualizacion:
        //            Gasto G=null;
        //            List<Gasto> lstGastoActualizar = Logic.Gasto.Buscar(null, null, null, null, null, null, null, this.Id, null, null, string.Empty, null, null, null,null);
        //            if (lstGastoActualizar != null && lstGastoActualizar.Count > 0)
        //                G = lstGastoActualizar.First();
        //           // Gasto G = Gasto.Buscar(null, null, null, null, null, null, null, this.Id, null, null, string.Empty, null, null, null)[0];
        //            if (G != null)
        //            {
        //                G.IdParcela = this.IdParcela;
        //                G.Fecha = this.Fecha;
        //                G.Importe = importe * this.Cantidad * Parcela.Buscar(this.IdParcela).Extension;
        //                G.Actualizar();
                    
        //            }
                    

        //            break;
        //    }
        //}

        #endregion

        #region CONTROL DE STOCK
            //Preservar los valores anteriores
            public decimal? CantidadAnterior { get; set; }
            partial void OnCantidadChanging(decimal value) { CantidadAnterior = this.Cantidad; }
            public int? IdSemillaAnterior { get; set; }
            partial void OnIdSemillaChanging(int value) { IdSemillaAnterior = this.IdSemilla; }
            public int? IdParcelaAnterior { get; set; }
            partial void OnIdParcelaChanging(int value) { IdParcelaAnterior = this.IdParcela; }
            public DateTime? FechaAnterior { get; set; }
            partial void OnFechaChanging(DateTime value) { FechaAnterior = this.Fecha; }

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


                movimiento.Identificacion = this.Id.ToString();
                movimiento.Tipo = TiposMovimientos.SIEMBRA_FINCAS;
                movimiento.IdProducto = this.IdSemilla;
                movimiento.Cantidad = this.Cantidad;
                movimiento.FechaEfecto = this.Fecha;


                //Calculo la cantidad correcta, pues depende de la extension de la parcela.
                Parcela parcela = Parcela.Buscar(this.IdParcela);
                if (parcela != null)//Multiplico la cantidad de kg/ha por la cantidad de ha que tiene la parcela.                
                    movimiento.Cantidad *= parcela.Extension;


                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                    movimiento.Cantidad *= -1;//Cambio de signo a la cantidad ya que las inserciones y actualizaciones de la tabla Simbra restan stock.

                //Establecer valores a las variables con sufijo _Anterior (cambiantes)
                if (operacion == TipoOperacion.Actualizacion)
                {
                    movimiento.IdProductoAnterior = this.IdSemillaAnterior ?? this.IdSemilla;
                    movimiento.CantidadAnterior = this.CantidadAnterior ?? this.Cantidad;
                    movimiento.FechaEfectoAnterior = this.FechaAnterior ?? this.Fecha;

                    //Calculo la cantidad Anterior correcta, pues depende de la extension de la parcela.
                    Parcela parcelaAnterior = Parcela.Buscar(this.IdParcelaAnterior ?? this.IdParcela);
                    if (parcelaAnterior != null)//Multiplico la cantidad de kg/ha por la cantidad de ha que tiene la parcela.                
                        movimiento.CantidadAnterior *= parcelaAnterior.Extension;
                }

                lstMovimientos.Add(movimiento);
                return lstMovimientos;
            }

 
        
        #endregion

        #region CONTROL DE GASTOS
            /// <summary>
            /// Convierto la clase actual a partir de sus valores actuales en una clase del tipo 'GastoDefinicion'
            /// Esta conversión se lleva a cabo en Gasto.GenerarGasto(TipoOperacion,objecto clase)
            /// que es llamada cada vez que se confirma una operación en clase que implementa la interface IControlGasto.
            /// Nota: NO se debe llamar esplicitamente a este método.
            /// </summary>
            /// <param name="operacion"></param>
            /// <returns></returns>
            public GastoDefinicion ToGasto(TipoOperacion operacion)
            {
                GastoDefinicion gasto = new GastoDefinicion();
              
                if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Borrado)
                {   //Cargar la lista de gastos y asignar la variable GastoActual
                    gasto.lstGastos = Logic.Gasto.Buscar(null, null, null, null, null, null, null, this.Id, null, null, string.Empty, null, null, null, null, null);
                    if (gasto.lstGastos != null && gasto.lstGastos.Count > 0)
                        gasto.GastoActual = gasto.lstGastos.First();
                }
                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                {
                    gasto.IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.SIEMBRA_FINCAS).Id;
                    gasto.IdParcela = this.IdParcela;
                    gasto.IdSiembra = this.Id;
                    gasto.Fecha = this.Fecha;

                    //Valores para el correcto cálculo del importe
                    gasto.Extension = Parcela.Buscar(this.IdParcela).Extension;
                    gasto.Cantidad = this.Cantidad;
                    gasto.IdProducto = this.IdSemilla;
                }
                if (operacion == TipoOperacion.Actualizacion)
                {
                    if (this.IdParcelaAnterior != null)
                        gasto.ExtensionAnterior = Parcela.Buscar((int)this.IdParcelaAnterior).Extension;
                    gasto.CantidadAnterior = this.CantidadAnterior;
                    gasto.IdProductoAnterior = this.IdSemillaAnterior;
                }

                return gasto;
            }
        #endregion

    }
}
