using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class TratParcela : Notificable,IClaseBase,IControlStock,IControlGasto
    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {

            TratParcelaData.Insertar(this);
            Movimiento.GenerarMovimiento(TipoOperacion.Insercion, this);
            Logic.Gasto.GenerarGasto(TipoOperacion.Insercion, this);          
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            Movimiento.GenerarMovimiento(TipoOperacion.Actualizacion, this);
            Logic.Gasto.GenerarGasto(TipoOperacion.Actualizacion, this);
            TratParcelaData.Actualizar(this);         
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            Movimiento.GenerarMovimiento(TipoOperacion.Borrado, this);
            Logic.Gasto.GenerarGasto(TipoOperacion.Borrado, this);
            TratParcelaData.Eliminar(this);       
        }


        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;
            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new TratParcela();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TratParcelaData.GetTratParcelaOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una TratParcela a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TratParcela con el id especificado.</returns>
        public static TratParcela Buscar(int id)
        {
            return TratParcelaData.GetTratParcela(id);
        }

        /// <summary>
        /// Obtiene los/las TratParcela que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<TratParcela> Buscar(int? idParcela, int? idPlaga, int? idProducto, DateTime? fecha)
        {
            return TratParcelaData.GetTratsParcelas(idParcela, idPlaga, idProducto, fecha);
        }

        public static List<TratParcela> Buscar(int? idParcela, int? idPlaga, int? idProducto, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            return TratParcelaData.GetTratsParcelas(idParcela, idPlaga, idProducto, fechaMayorIgual, fechaMenorIgual);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo TratParcela
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<TratParcela> Buscar()
        {
            return TratParcelaData.GetTratsParcelas(null, null, null, null);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

     
        /// <summary>
        /// Propiedad que devuelve el nombre de la parcela
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
        /// Propiedad que devuelve la descripción de la plaga.
        /// </summary>
        public string DescPlaga
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Plaga != null)
                    rtno = this.Plaga.Descripcion;
                return rtno;

            }
        }
        /// <summary>
        /// Propiedad que devuelve la descripción del producto en este caso productos de tratamiento de fincas.
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
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        //private decimal? CaldoAnterior = null;

        ///// <summary>
        ///// Controla el cambio de cantidad para las tareas con stock y gasto asociado.
        ///// </summary>
        //partial void OnCaldoChanging(decimal value)
        //{
        //    CaldoAnterior = this.Caldo;
        //}

        //public decimal ControlStock(decimal cantidad)
        //{
        //    decimal PVP = decimal.Zero;

        //    Parcela parcela = Parcela.Buscar(this.IdParcela);

        //    decimal Total = cantidad * parcela.Extension;

        //    Stock stockProducto = Stock.BuscarProducto(this.IdProducto);

        //    try
        //    {
        //        if (stockProducto != null)
        //        {
        //            if (stockProducto.Cantidad >= Total)
        //            {
        //                PVP = stockProducto.Precio;

        //                stockProducto.Cantidad -= Total;
        //                stockProducto.Actualizar();
        //            }
        //            else
        //                throw new LogicException("No hay suficiente stock para realizar esa operación");
        //        }
        //        else
        //            throw new LogicException("No se ha podido guardar la relación con el stock");
        //    }
        //    finally
        //    {
        //        stockProducto = null;
        //    }

        //    return PVP;
        //}

        ///// <summary>
        ///// Controla el gasto producido por el tratamiento.
        ///// </summary>
        ///// <param name="operacion">Operación realizada con el tratamiento.</param>
        ///// <param name="importe">Importe del gasto asociado.</param>
        //private void ControlGasto(TipoOperacion operacion, decimal? importe)
        //{
        //    switch (operacion)
        //    {
        //        case TipoOperacion.Insercion:
        //            new Gasto
        //            {
        //                IdExplotacion = Configuracion.Explotacion.Id,
        //                IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.TRATAMIENTO_FINCAS).Id,
        //                IdParcela = this.IdParcela,
        //                IdTratParcela = this.Id,
        //                Fecha = this.Fecha,
        //                Importe = importe.Value * this.Caldo * this.Superficie

        //            }.Insertar();

        //            break;
        //        case TipoOperacion.Borrado:
        //            Logic.Gasto.Buscar(null, null, null, null, null, null, null, null, null, this.Id, string.Empty, null, null, null,null)[0].Eliminar();

        //            break;
        //        case TipoOperacion.Actualizacion:
        //            Gasto G = Logic.Gasto.Buscar(null, null, null, null, null, null, null, null, null, this.Id, string.Empty, null, null, null,null)[0];

        //            G.IdParcela = this.IdParcela;
        //            G.Fecha = this.Fecha;
        //            G.Importe = importe.Value * this.Caldo * this.Superficie;

        //            G.Actualizar();

        //            break;
        //    }
        //}

        #endregion

        #region CONTROL DE STOCK
            //Preservar los valores anteriores
            public decimal? CaldoAnterior { get; set; }
            partial void OnCaldoChanging(decimal value) { CaldoAnterior = this.Caldo; }
            public int? IdProductoAnterior { get; set; }
            partial void OnIdProductoChanging(int value) { IdProductoAnterior = this.IdProducto; }        
            public DateTime? FechaAnterior { get; set; }
            partial void OnFechaChanging(DateTime value) { FechaAnterior = this.Fecha; }
            public decimal? SuperficieAnterior { get; set; }
            partial void OnSuperficieChanging(decimal value) { SuperficieAnterior = this.Superficie; }


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
                movimiento.Tipo = TiposMovimientos.TRATAMIENTO_FINCAS;
                movimiento.IdProducto = this.IdProducto;
                movimiento.Cantidad = this.Caldo;
                movimiento.FechaEfecto = this.Fecha;
                movimiento.Cantidad *= this.Superficie;//Multiplico la cantidad de kg/ha por la cantidad tratada de la parcela.                                 

                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                    movimiento.Cantidad *= -1;//Cambio de signo a la cantidad ya que las inserciones y actualizaciones de la tabla Simbra restan stock.

                //Establecer valores a las variables con sufijo _Anterior (cambiantes)
                if (operacion == TipoOperacion.Actualizacion)
                {
                    movimiento.IdProductoAnterior = this.IdProductoAnterior ?? this.IdProducto;
                    movimiento.CantidadAnterior = this.CaldoAnterior ?? this.Caldo;
                    movimiento.FechaEfectoAnterior = this.FechaAnterior ?? this.Fecha;

                    ////Calculo la cantidad Anterior correcta, pues depende de la extension de la parcela.                
                    movimiento.CantidadAnterior *= this.SuperficieAnterior ?? this.Superficie;
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
            {   //Cargar la lista de gastos y asignar la variable GastoActual
                GastoDefinicion gasto = new GastoDefinicion();

                if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Borrado)
                {
                    gasto.lstGastos = Logic.Gasto.Buscar(null, null, null, null, null, null, null, null, null, this.Id, string.Empty, null, null, null, null,null);
                    if (gasto.lstGastos != null && gasto.lstGastos.Count > 0)
                        gasto.GastoActual = gasto.lstGastos.First();
                }
                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                {
                    gasto.IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.TRATAMIENTO_FINCAS).Id;
                    gasto.IdParcela = this.IdParcela;
                    gasto.IdTratParcela = this.Id;
                    gasto.Fecha = this.Fecha;

                    //Valores para el correcto cálculo del importe
                    gasto.Extension = this.Superficie;
                    gasto.Cantidad = this.Caldo;
                    gasto.IdProducto = this.IdProducto;
                }
                if (operacion == TipoOperacion.Actualizacion)
                {
                    gasto.ExtensionAnterior = this.SuperficieAnterior;
                    gasto.CantidadAnterior = this.CaldoAnterior;
                    gasto.IdProductoAnterior = this.IdProductoAnterior;
                }

           

                return gasto;
            }
        #endregion
    }
}
