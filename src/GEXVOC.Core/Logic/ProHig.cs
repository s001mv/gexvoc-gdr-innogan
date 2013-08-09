using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class ProHig :Notificable, IClaseBase,IControlStock,IControlGasto
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
            
            //bool trans = BD.IniciarTransaccion();
            //try
            //{
                ProHigData.Insertar(this);
                Movimiento.GenerarMovimiento(TipoOperacion.Insercion, this);
                Logic.Gasto.GenerarGasto(TipoOperacion.Insercion, this);
            //    if (trans) BD.FinalizarTransaccion(true);
            //}         
            //catch (Exception)
            //{
            //    if (trans) BD.FinalizarTransaccion(false);
            //    throw;
            //}
            
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            //ValidarLogica(TipoOperacion.Actualizacion);
            
            //bool trans = BD.IniciarTransaccion();
            //try
            //{

                 Movimiento.GenerarMovimiento(TipoOperacion.Actualizacion, this);
                 Logic.Gasto.GenerarGasto(TipoOperacion.Actualizacion, this);
                 ProHigData.Actualizar(this);                 
            //     if (trans) BD.FinalizarTransaccion(true);
            //}
            //catch (Exception)
            //{
            //    if (trans) BD.FinalizarTransaccion(false);
            //    throw;
            //}

          
            //ProHig anterior = ProHig.Buscar(this.IdTratHigiene, this.IdProducto);
            //if (anterior.Cantidad!=this.Cantidad)
            //{
            //    //Anulo la cantidad anterior.
            //    Movimiento.CrearMovimiento(DateTime.Now, TiposMovimientos.HIGIENE, anterior.IdProducto, null, anterior.Cantidad, null, anterior.IdTratHigiene.ToString() + "-" + anterior.IdProducto.ToString());
            //    //Creo la cantidad nueva.
            //    Movimiento.CrearMovimiento(DateTime.Now, TiposMovimientos.HIGIENE, this.IdProducto, null, this.Cantidad * -1, null, this.IdTratHigiene.ToString() + "-" + this.IdProducto.ToString());                
            //}
            

          
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            ValidarLogica(TipoOperacion.Borrado);
            
            //bool trans = BD.IniciarTransaccion();
            //try
            //{
                Movimiento.GenerarMovimiento(TipoOperacion.Borrado, this);
                Logic.Gasto.GenerarGasto(TipoOperacion.Borrado, this);
                ProHigData.Eliminar(this);
            //    if (trans) BD.FinalizarTransaccion(true);
            //}
            //catch (Exception)
            //{
            //    if (trans) BD.FinalizarTransaccion(false);
            //    throw;
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
                    rtno = new ProHig();
                    break;
                case TipoContexto.Modificacion:
                    rtno = ProHigData.GetProHigOP(this.IdTratHigiene,this.IdProducto);
                    break;
            }
            return rtno;

        }


        /// <summary>
        /// Obtiene un/una ProHig a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>ProHig con el id especificado.</returns>
        public static ProHig Buscar(int idTratHigiene, int idProducto)
        {
            return ProHigData.GetProHig(idTratHigiene,idProducto);
        }

        /// <summary>
        /// Obtiene los/las ProHig que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <param name="provincia">Provincia.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<ProHig> Buscar(int? idTratHigiene, int? idProducto,decimal? cantidad)
        {
            return ProHigData.GetProHig(idTratHigiene,idProducto,cantidad);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo ProHig
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<ProHig> Buscar()
        {
            return Buscar(null, null, null);
        }



        #endregion

        #region PROPIEDADES PERSONALIZADAS
        //Se utilizan habitualmente el los grids para ver el detalle de las foráneas
        //ej: Con DesProvincia en el Grid mostraremos "Pontevedra" en vez de mostrar el (int) que representa al ID

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la provincia a la que pertenece la explotación
        ///// </summary>
        //public string DescProvincia { get { return this.Municipio.Provincia.Descripcion; } }

        public int Id
        {
            get { return this.IdProducto; }
            set { }

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
        public string DescFamilia
        {
            get
            {
                string rtno = string.Empty;
                if (this != null && this.Producto != null)
                    rtno = this.Producto.DescFamilia;

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

            if (operacion== TipoOperacion.Insercion)            
                if (ProHig.Buscar(this.IdTratHigiene, this.IdProducto)!=null)                
                    throw new LogicException("No es posible realizar esta operación porque se duplicaría la asociación 'Tratamiento Higiene' -> 'Producto'");                    
             
        }
        partial void  OnIdProductoChanging(int value)
        {
            if (this.IdProducto!=0)//No se pueden modificar los valores de la clave            
                throw new LogicException("No es posible modificar el producto una vez creado el registro.( Pertenece a la clave)");            
        }
        partial void OnIdTratHigieneChanging(int value)
        {
            if(this.IdTratHigiene!=0)
                throw new LogicException("No es posible modificar el Tratamiento una vez creado el registro. (Pertenece a la clave)");            

        }

        //partial void OnValidate(System.Data.Linq.ChangeAction action)
        //{
        //    ///Impido que se pueda duplicar la clave formada por los campos: 
        //    /// - IdTratamiento
        //    /// - IdProducto
        //    if (action== System.Data.Linq.ChangeAction.Insert)
        //        if (ProHig.Buscar(this.IdTratHigiene, this.IdProducto,null).Count>1)                
        //            throw new LogicException("No es posible realizar esta operación porque se duplicaría la asociación 'Tratamiento Higiene' -> 'Producto'");                    
                
            
        //}


        
    
        #endregion

        #region CONTROL DE STOCK
        //Para un correcto funcionamiento del stock, debemos tener a mano en las modificaciones, los valores anteriores.
        //Para esto nos valemos de los eventos Changing que nos provee LINQ,
        //de esta manera, almacenamos en variables locales los valores anteriores para poder tenerlos siempre a mano.
        //Se utilizarán dichos valores sobre todo en el método ToMovimiento de la propia clase (obligatorio si se implementa IControlStock)

            public decimal? CantidadAnterior { get; set; }
            partial void OnCantidadChanging(decimal value) { CantidadAnterior = this.Cantidad; }

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
                movimiento.Identificacion = this.IdTratHigiene.ToString() + "-" + this.IdProducto.ToString();
                movimiento.Tipo = TiposMovimientos.HIGIENE;
                movimiento.IdProducto = this.IdProducto;
                movimiento.Cantidad = this.Cantidad;
                movimiento.Operacion = operacion;


                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                    movimiento.Cantidad *= -1;//Cambio de signo la cantidad ya que las inserciones y actualizaciones de la tabla ProHig restas stock.

                if (operacion == TipoOperacion.Actualizacion)
                {   //Si me encuentro en una actualización, debo proporcionar los valores anteriores a las correspondientes variables
                    //No siempre son los mismos, pues dependiendo de la clase algunos pueden cambiar y otros no.
                    movimiento.IdProductoAnterior = this.IdProducto;
                    movimiento.CantidadAnterior = this.CantidadAnterior ?? this.Cantidad;
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
                    gasto.lstGastos = Logic.Gasto.BuscarTratamientos(null, this.IdProducto, this.IdTratHigiene);
                    if (gasto.lstGastos != null && gasto.lstGastos.Count > 0)
                        gasto.GastoActual = gasto.lstGastos.First();
                }

                if (operacion == TipoOperacion.Insercion || operacion == TipoOperacion.Actualizacion)
                {
                    gasto.IdNaturaleza = Configuracion.NaturalezaGastoSistema(Configuracion.NaturalezasGastosSistema.TRATAMIENTO_HIGIENE).Id;
                    gasto.IdProducto = this.IdProducto;
                    gasto.IdTratHigiene = this.IdTratHigiene;
                    gasto.IdProductoTratamientos = this.IdProducto;
                    gasto.Cantidad = this.Cantidad;
                }
                if (operacion == TipoOperacion.Actualizacion)
                    gasto.CantidadAnterior = this.CantidadAnterior;

                return gasto;
            }
        #endregion


    }
}