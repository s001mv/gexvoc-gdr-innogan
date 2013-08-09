using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Asignacion : Notificable,IClaseBase,IControlStock,IControlGasto

    {
        #region CONSTRUCTORES PERSONALIZADOS


        #endregion

        #region  ACTUALIZACIÓN DE DATOS


        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            //bool TransacionPropia = false;

            //try
            //{
            //    TransacionPropia = BDController.IniciarTransaccion();

                ValidarLogica(TipoOperacion.Insercion);
               

                //ControlStockAlimentos((decimal)this.Porcentaje);
                AsignacionData.Insertar(this);
                Movimiento.GenerarMovimiento(TipoOperacion.Insercion, this);
                Logic.Gasto.GenerarGasto(TipoOperacion.Insercion, this);

                //ControlGasto(TipoOperacion.Insercion);

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

                ValidarLogica(TipoOperacion.Actualizacion);
                //ControlStockAlimentos((decimal)(PorcentajeAnterior ?? this.Porcentaje) * -1);
                //ControlStockAlimentos((decimal)this.Porcentaje);

               // ControlGasto(TipoOperacion.Actualizacion);
                Movimiento.GenerarMovimiento(TipoOperacion.Actualizacion, this);
                Logic.Gasto.GenerarGasto(TipoOperacion.Actualizacion, this);
                AsignacionData.Actualizar(this);

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
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            //bool TransacionPropia = false;

            //try
            //{
                
            //    TransacionPropia = BDController.IniciarTransaccion();

                ValidarLogica(TipoOperacion.Borrado);
               //ControlStockAlimentos((decimal)this.Porcentaje * -1);

                //ControlGasto(TipoOperacion.Borrado);
                Movimiento.GenerarMovimiento(TipoOperacion.Borrado, this);
                Logic.Gasto.GenerarGasto(TipoOperacion.Borrado, this);
                AsignacionData.Eliminar(this);

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
                    rtno = new Asignacion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = AsignacionData.GetAsignacionOP(this.Id);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una Asignacion a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Asignacion con el id especificado.</returns>
        public static Asignacion Buscar(int id)
        {
            return AsignacionData.GetAsignacion(id);
        }

        /// <summary>
        /// Obtiene los/las Asignacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Asignacion> Buscar(int? idRacion, int? idAnimal, decimal? porcentaje,DateTime?fechaIntervalo, DateTime? fechaInicio, DateTime? fechaFin)
        {
            return AsignacionData.GetAsignaciones(idRacion,idAnimal,porcentaje,fechaIntervalo,fechaInicio,fechaFin);
        }
        public static List<Asignacion> Buscar(int? idRacion, int? idAnimal, DateTime? fechaIntervaloInicio, DateTime? fechaIntervaloFin)
        {
            return AsignacionData.GetAsignaciones(idRacion, idAnimal, fechaIntervaloInicio, fechaIntervaloFin);
        }
        

        /// <summary>
        /// Obtiene todos los registros del tipo Asignacion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Asignacion> Buscar()
        {
            return AsignacionData.GetAsignaciones(null,null,null,null,null,null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

       
        /// <summary>
        /// Propiedad que nos devuelve el nombre del animal.
        /// </summary>
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
        /// <summary>
        /// Propiedad que nos devuelve el identificador del animal si es raza Bovina devuelve el DIB si no el Crotal.
        /// </summary>
        public string DescIdentificador
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null)
                {
                    Animal animal = Animal.Buscar(this.IdAnimal);
                    if (animal != null)
                    {
                        rtno = animal.Identificador;
                    }
                }
                return rtno;
            
            }
        
        }
        /// <summary>
        /// Propiedad que nos devuelve el estado del animal (cría,recria...)
        /// </summary>
        public string DescEstado
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Animal != null && this.Animal.Estado != null)
                    rtno = this.Animal.Estado.Descripcion;
                return rtno;
            }
        
        }
        /// <summary>
        /// Propiedad que nos devuelve la descripción de la ración.
        /// </summary>
        public string DescRacion
        {
            get 
            {
                string rtno = string.Empty;
                if (this != null && this.Racion != null)
                    rtno = this.Racion.Descripcion;
                return rtno;
            }
        
        }
        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.

        /// <summary>
        /// Nos da la lista de composiciones para cada una de las asignaciones.
        /// </summary>
        public List<Composicion> lstComposicion
        {
            get 
            {
                return Composicion.Buscar(this.IdRacion, null, null);
            }
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

      
        /// <summary>
        /// Controla si hay stock suficiente para asignar los alimentos a los animales.
        /// </summary>
        /// <param name="cantidad"></param>
        public void ControlStockAlimentos(decimal cantidad)
        {
            ////Stock stockAlimentos = null;
            ////bool AsignacionValida = true;
            ////decimal AsignacionConsumida=0;
            ////decimal CantidadAnterior=0;
            ////decimal PrecioAnterior=0;
            ////foreach (Composicion C in this.lstComposicion)
            ////{
            ////    //La función BuscarProducto de la clase Stock obtiene la última fila para cada producto.
            ////    stockAlimentos = Stock.BuscarProducto(C.IdAlimento);
            ////    if (this.FechaInicio == this.FechaFin || this.FechaFin == null)
            ////        AsignacionConsumida = (cantidad * C.Porcentaje) / 100;
            ////    else
            ////    {
            ////        if(this.FechaFin!=null)
            ////        AsignacionConsumida = (((cantidad * C.Porcentaje) / 100) * (((DateTime) this.FechaFin - this.FechaInicio).Days));
            ////    }
            ////    if (stockAlimentos==null ||((stockAlimentos.Cantidad - AsignacionConsumida) < 0))
            ////        AsignacionValida = false;            
            ////}
            ////if (AsignacionValida)
            ////    foreach (Composicion C in this.lstComposicion)
            ////    {
            ////        stockAlimentos = Stock.BuscarProducto(C.IdAlimento);
            ////        //stockAlimentos=(Stock)stockAlimentos.CargarContextoOperacion(TipoContexto.Modificacion);
            ////        //stockAlimentos.Cantidad -= AsignacionConsumida;
            ////        //stockAlimentos.Actualizar();
            ////        if(stockAlimentos!=null)
            ////        {
            ////            CantidadAnterior=stockAlimentos.Cantidad;
            ////            PrecioAnterior=stockAlimentos.Precio;
            ////        }
            ////        Stock stock = new Stock();
            ////        stock.IdProducto = C.IdAlimento;
            ////        stock.IdExplotacion = Configuracion.Explotacion.Id;
            ////        stock.Fecha = DateTime.Now;
            ////        stock.Cantidad = CantidadAnterior - AsignacionConsumida;
            ////        stock.Precio = PrecioAnterior;
            ////        stock.Insertar();
            ////    }
            ////else
            ////    throw new LogicException("No hay suficiente Stock para permitir la operación.");

            ////stockAlimentos = null;


        }

        /////// <summary>
        /////// Controla el gasto producido por la asignación alimentaria.
        /////// </summary>
        /////// <param name="operacion">Operación realizada con la asignación.</param>
        ////private void ControlGasto(TipoOperacion operacion)
        ////{
        ////    decimal Precio = decimal.Zero;

        ////    if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
        ////    {
        ////        decimal Peso = ((Racion.Buscar(this.IdRacion).Peso * this.Porcentaje) / 100) * (this.FechaFin.Value.Subtract(this.FechaInicio).Days + 1);

        ////        foreach (Composicion C in this.lstComposicion)
        ////            Precio += ((Peso * C.Porcentaje) / 100) * Stock.BuscarProducto(C.IdAlimento).Precio;
        ////    }

        ////    switch (operacion)
        ////    {
        ////        case TipoOperacion.Insercion:
        ////            new Gasto
        ////            {
        ////                IdExplotacion = Configuracion.Explotacion.Id,
        ////                IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.ALIMENTACION_ANIMAL).Id,
        ////                IdAnimal = this.IdAnimal,
        ////                IdAsignacion = this.Id,
        ////                Fecha = this.FechaInicio,
        ////                Importe = Precio

        ////            }.Insertar();

        ////            break;
        ////        case TipoOperacion.Borrado:
        ////            Logic.Gasto.Buscar(Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.ALIMENTACION_ANIMAL).Id,
        ////                Configuracion.Explotacion.Id, null, null, null, null, this.Id, null, null, null, string.Empty, null, null, null,null)[0].Eliminar();

        ////            break;
        ////        case TipoOperacion.Actualizacion:
        ////            Gasto G = Logic.Gasto.Buscar(Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.ALIMENTACION_ANIMAL).Id,
        ////                Configuracion.Explotacion.Id, null, null, null, null, this.Id, null, null, null, string.Empty, null, null, null,null)[0];

        ////            G.IdAnimal = this.IdAnimal;
        ////            G.IdAsignacion = this.Id;
        ////            G.Fecha = this.FechaInicio;
        ////            G.Importe = Precio;

        ////            G.Actualizar();

        ////            break;
        ////    }           
        ////}

        /// <summary>
        /// Valida la logica antes de realizar ninguna insercción, modificación o eliminación.
        /// </summary>
        /// <param name="operacion"></param>
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Insercion)
            {
                if (this.Porcentaje > 100)
                    throw new LogicException("Alguno de los porcentajes no es correcto ya que supera el 100%, el proceso no puede ser completado.");
            }
        
        }

       
        #endregion

        #region CONTROL DE STOCK
            //Preservar los valores anteriores
            public int? IdRacionAnterior { get; set; }
            partial void OnIdRacionChanging(int value) { IdRacionAnterior = this.IdRacion; }            
            public DateTime? FechaInicioAnterior { get; set; }
            partial void OnFechaInicioChanging(DateTime value){FechaInicioAnterior = this.FechaInicio;}
            public DateTime? FechaFinAnterior { get; set; }
            partial void OnFechaFinChanging(DateTime? value) { FechaFinAnterior = this.FechaFin; }      
            public decimal? PorcentajeAnterior { get; set; }
            partial void OnPorcentajeChanging(decimal value){PorcentajeAnterior = this.Porcentaje;}

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

                ///El funcionamiento de este tipo no funciona como el resto, es una escepción.       
                ///El funcionamiento es el siguiente:
                /// Tenemos Raciones y estas son las que contienen los productos y cantidades
                /// de manera que lo primero que hacemos es comprobar si la racion es o no la misma (esta comprobacion solo tiene sentido en la actualizacion)
                /// Si estamos en una insercion o borrado saltamos al segundo bucle, si es una modificacion, puede o no ejecutarse el primer bucle
                /// y el segundo siempre.
                /// Si nos han cambiado la racion, hacemos llamadas consecutivas a bajas por cada producto de la misma OJO: Todo bajas
                /// cuando hemos terminado se ejecuta el 2º bucle OJO: en modo insercion.
                /// 2º bucle: Recorremos los productos de la racion y generamos los movimientos oportunos por cada uno de ellos.

                ///NOTA: Este tipo lo unico que hace es generar uno o varios objetos del tipo MovimientoDefinicion (Dependera del número de elementos contenidos en la racion)               
              
                Racion racion = Racion.Buscar(this.IdRacion);
                if (this.IdRacionAnterior != null && this.IdRacionAnterior != this.IdRacion && this.IdRacionAnterior != 0)
                {   //Ha cambiado la racion, tenemos que eliminar todos los registros que habian sido generados con la racion anterior
                    Racion racionAnterior = Racion.Buscar((int)this.IdRacionAnterior);
                    foreach (Composicion item in racionAnterior.lstComposicion)
                    {
                        MovimientoDefinicion movimiento = new MovimientoDefinicion()
                        {
                            IdProducto = item.IdAlimento,
                            Cantidad = (((item.Porcentaje / 100) * racionAnterior.Peso) * ((this.PorcentajeAnterior ?? this.Porcentaje) / 100)) * ((this.FechaFinAnterior??this.FechaFin).Value.Subtract(this.FechaInicioAnterior??this.FechaInicio).Days + 1),
                            FechaEfecto = this.FechaInicioAnterior ?? this.FechaInicioAnterior,
                            Identificacion = this.Id.ToString() + "-" + item.IdAlimento.ToString(),
                            Operacion=TipoOperacion.Borrado,
                            Tipo=TiposMovimientos.ALIMENTACION_ANIMAL
                        };
                        lstMovimientos.Add(movimiento);
                    }
                    operacion = TipoOperacion.Insercion;//El resto de las operaciones actuan como si se tratase de inserciones.
                }
                foreach (Composicion item in racion.lstComposicion)
                {
                    MovimientoDefinicion movimiento = new MovimientoDefinicion()
                    {
                        IdProducto = item.IdAlimento,
                        IdProductoAnterior=item.IdAlimento,
                        Cantidad = ((item.Porcentaje / 100) * racion.Peso) * (this.Porcentaje / 100) * (this.FechaFin.Value.Subtract(this.FechaInicio).Days + 1),
                        FechaEfecto = this.FechaInicio,
                        Identificacion = this.Id.ToString() + "-" + item.IdAlimento.ToString(),
                        Operacion = operacion,
                        Tipo = TiposMovimientos.ALIMENTACION_ANIMAL

                    };
                    if (operacion == TipoOperacion.Actualizacion)
                    {
                        movimiento.CantidadAnterior = ((item.Porcentaje / 100) * racion.Peso) * ((this.PorcentajeAnterior ?? this.Porcentaje) / 100) * ((this.FechaFinAnterior??this.FechaFin).Value.Subtract(this.FechaInicioAnterior??this.FechaInicio).Days + 1);
                        movimiento.FechaEfectoAnterior = this.FechaInicioAnterior;
                    }
                    lstMovimientos.Add(movimiento);
                }

                //- Si la operacion real a realizar es insercion o actualizacion, se considera resta de stock, cambio por tanto el signo
                if (lstMovimientos!=null && lstMovimientos.Count>0)                
                    foreach (MovimientoDefinicion movimientoDefinicion in lstMovimientos)                    
                        if (movimientoDefinicion.Operacion== TipoOperacion.Insercion || operacion== TipoOperacion.Actualizacion)                        
                            movimientoDefinicion.Cantidad *= -1;
 

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
                gasto.OmitirCalculPrecio = true;

           
                if (operacion == TipoOperacion.Actualizacion || operacion == TipoOperacion.Borrado)
                {
                    gasto.lstGastos = Logic.Gasto.Buscar(null, Configuracion.Explotacion.Id, null, null, null, null, this.Id, null, null, null, string.Empty, null, null, null, null, null);
                    if (gasto.lstGastos != null && gasto.lstGastos.Count > 0)
                    {
                        gasto.GastoActual = gasto.lstGastos.First();
                        gasto.GastoActual=(Gasto)gasto.GastoActual.CargarContextoOperacion(TipoContexto.Modificacion);
                    }

                }

                
                //ASIGNO LOS VALORES COMUNES TANTO A INSERCION COMO ACTUALIZACION
                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                {
                    gasto.IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.ALIMENTACION_ANIMAL).Id;
                    gasto.IdAnimal = this.IdAnimal;
                    gasto.IdAsignacion = this.Id;
                    gasto.Fecha = this.FechaInicio;
                }

                // INICIO  - Calculo el precio individual de la ración.
                decimal PrecioRacion = decimal.Zero;
                Racion racion = Racion.Buscar(this.IdRacion);
                if (racion!=null)                
                    foreach (Composicion composicion in racion.lstComposicion)
                        PrecioRacion += ((composicion.Porcentaje / 100) * racion.Peso * Stock.PrecioProducto(composicion.IdAlimento, null));
                // FIN  - Calculo el precio individual de la ración.


                ///**** INICIO - CALCULO EL IMPORTE Y PRECIO TOTAL QUE DEPENDEN DE SI LA OPERACION ES INSERCION O ACTUALIZACION                           
                try
                {
                    if (operacion == TipoOperacion.Insercion)
                    {
                        //El importe y el total dependen de la operacion en cuestión
                        gasto.Importe = PrecioRacion;
                        gasto.Total = PrecioRacion * (this.Porcentaje / 100) * (this.FechaFin.Value.Subtract(this.FechaInicio).Days + 1);
                    }
                    if (operacion == TipoOperacion.Actualizacion)
                    {
                        if (gasto.GastoActual != null)
                        {
                            if (this.IdRacionAnterior != null)//Si ha cambiado la racion
                            {
                                gasto.ImporteAnterior = gasto.GastoActual.Importe;
                                gasto.Importe = PrecioRacion;
                            }
                            else//No ha cambiado la racion, el importe será el de la anterior operacion
                                gasto.Importe = gasto.GastoActual.Importe;


                            decimal GastoTotalAnterior=(gasto.ImporteAnterior ?? gasto.Importe) * ((this.PorcentajeAnterior ?? this.Porcentaje)/100) * ((this.FechaFinAnterior??this.FechaFin).Value.Subtract(this.FechaInicioAnterior??this.FechaInicio).Days + 1);
                            if (GastoTotalAnterior == gasto.GastoActual.Total)
                                gasto.Total = gasto.Importe * (this.Porcentaje / 100) * (this.FechaFin.Value.Subtract(this.FechaInicio).Days + 1);//Solo actualizo el total si el usuario no ha cambiado el total del gasto manualmente.
                            else
                                gasto.Total = gasto.GastoActual.Total;//Dejo el gasto total sin modificar, pues no se corresponden
                        }
                    }
                }
                catch (Exception ex)
                {
                    Traza.RegistrarError("No se ha podido calcular el total. Detalle: " + ex.Message);
                }
          
                ///****FIN - CALCULO EL IMPORTE Y PRECIO TOTAL QUE DEPENDEN DE SI LA OPERACION ES INSERCION O ACTUALIZACION
				return gasto;
            }
  	    #endregion

        
    }
}