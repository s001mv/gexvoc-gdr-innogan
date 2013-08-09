using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Transformacion : IClaseBase, IControlStock
    {
        #region CONSTRUCTORES PERSONALIZADOS
        #endregion

        #region  ACTUALIZACIÓN DE DATOS

        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            this.FechaInicio = DateTime.Now;

            ValidarLogica(TipoOperacion.Insercion);
            TransformacionData.Insertar(this);
        }

        public decimal CantidadAnterior { get; set; }
        partial void OnCantidadChanging(decimal value) { CantidadAnterior = this.Cantidad; }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            if (!this.Plantilla.Ejecutada)
            {
                ValidarLogica(TipoOperacion.Actualizacion);
                TransformacionData.Actualizar(this);
            }
            else
            {
                decimal CantidadActual = this.Cantidad;

                this.Cantidad = CantidadAnterior;
                this.FechaFin = DateTime.Now;

                ValidarLogica(TipoOperacion.Actualizacion);
                TransformacionData.Actualizar(this);

                new Transformacion() { IdPlantilla = this.IdPlantilla, IdProducto = this.IdProducto,
                    Direccion = this.Direccion, Cantidad = CantidadActual }.Insertar();
            }
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (!this.Plantilla.Ejecutada)
            {
                ValidarLogica(TipoOperacion.Borrado);
                TransformacionData.Eliminar(this);
            }
            else
            {
                Transformacion Movimiento = Transformacion.Buscar(this.IdPlantilla, this.IdProducto, this.FechaInicio);
                Movimiento.FechaFin = DateTime.Now;
                TransformacionData.Actualizar(Movimiento);
            }
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public IClaseBase CargarContextoOperacion(TipoContexto Modo)
        {
            IClaseBase rtno = null;

            switch (Modo)
            {
                case TipoContexto.Insercion:
                    rtno = new Transformacion();
                    break;
                case TipoContexto.Modificacion:
                    rtno = TransformacionData.GetTransformacionOP(this.IdPlantilla, this.IdProducto, this.FechaInicio);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Transformacion a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id del producto.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>Transformacion con el id especificado.</returns>
        public static Transformacion Buscar(int idPlantilla, int idProducto, DateTime fechaInicio)
        {
            return TransformacionData.GetTransformacion(idPlantilla, idProducto, fechaInicio);
        }

        /// <summary>
        /// Obtiene los/las Transformacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id del producto.</param>
        /// <param name="fechaEjecucion">Fecha de ejecucion.</param>
        /// <param name="direccion">'E': Entrada, 'S': Salida.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Transformacion> Buscar(int? idPlantilla, int? idProducto, DateTime? fechaEjecucion, char direccion)
        {
            return TransformacionData.GetTransformaciones(idPlantilla, idProducto, fechaEjecucion, direccion);
        }

        /// <summary>
        /// Obtiene los/las Transformacion que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id del producto.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <param name="fechaFin">Fecha de fin.</param>
        /// <param name="direccion">'E': Entrada, 'S': Salida.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Transformacion> Buscar(int? idPlantilla, int? idProducto, DateTime? fechaInicio, DateTime? fechaFin, char direccion)
        {
            return TransformacionData.GetTransformaciones(idPlantilla, idProducto, fechaInicio, fechaFin, direccion);
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Transformacion de un producto.
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla para un producto.</returns>
        public static List<Transformacion> Buscar(int idProducto)
        {
            return TransformacionData.GetTransformaciones(null, idProducto, null, null, ' ');
        }

        /// <summary>
        /// Obtiene todos los registros del tipo Transformacion
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Transformacion> Buscar()
        {
            return TransformacionData.GetTransformaciones(null, null, null, null, ' ');
        }

        /// <summary>
        /// Obtiene las transformaciones actuales de la plantilla.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="direccion">'E': Entrada, 'S': Salida.</param>
        /// <returns></returns>
        public static List<Transformacion> BuscarActuales(int idPlantilla, char direccion)
        {
            return TransformacionData.GetActuales(idPlantilla, direccion);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS

        public int Id
        {
            get { return this.IdPlantilla; }
            set { }
        }

        public DateTime FechaEjecucion { get; set; }

        ///// <summary>
        ///// Propiedad que devuelve la descripción de la plantilla.
        ///// </summary>
        public string DescPlantilla
        {
            get
            {
                string rtno = string.Empty;

                if (this != null && this.Plantilla != null)
                    rtno = this.Plantilla.Descripcion.ToString();

                return rtno;
            }
        }

        ///// <summary>
        ///// Propiedad que devuelve la descripción del producto.
        ///// </summary>
        public string DescProducto
        {
            get
            {
                string rtno = string.Empty;

                if (this != null && this.Producto != null)
                    rtno = this.Producto.Descripcion.ToString();

                return rtno;
            }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación realizada.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {
            if (operacion == TipoOperacion.Insercion)
            {
                Transformacion T = TransformacionData.GetTransformacionActual(this.IdPlantilla, this.IdProducto);

                if (T != null)
                    throw new LogicException("El producto '" + T.DescProducto + "' ya está asignada al proceso '" + T.DescPlantilla + "'.");
            }
        }

        #endregion

        #region CONTROL DE STOCK

        /// <summary>
        /// Convierto la clase actual a partir de sus valores actuales en clases del tipo 'MovimientoDefinicion'
        /// susceptibles de crear stock.
        /// Esta conversión se lleva a cabo en Movimiento.GenerarMovimiento(TipoOperacion operacion, object clase) 
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
            movimiento.Tipo = TiposMovimientos.TRAZABILIDAD;
            movimiento.IdProducto = this.IdProducto;
            movimiento.Cantidad = this.Cantidad;
            movimiento.FechaEfecto = this.FechaEjecucion;

            if (operacion == TipoOperacion.Borrado)
                movimiento.Cantidad *= -1;

            lstMovimientos.Add(movimiento);

            return lstMovimientos;
        }

        #endregion
    }
}
