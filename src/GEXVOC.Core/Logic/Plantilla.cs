using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Data;

namespace GEXVOC.Core.Logic
{
    public partial class Plantilla : IClaseBase
    {
        #region CONSTRUCTORES PERSONALIZADOS
        #endregion

        #region  ACTUALIZACIÓN DE DATOS

        /// <summary>
        /// Guarda (Crea un nuevo registro).
        /// </summary>
        public void Insertar()
        {
            this.IdExplotacion = Configuracion.Explotacion.Id;

            ValidarLogica(TipoOperacion.Insercion);
            PlantillaData.Insertar(this);
        }

        /// <summary>
        /// Actualiza (Modifica un registro existente).
        /// </summary>
        public void Actualizar()
        {
            ValidarLogica(TipoOperacion.Actualizacion);
            PlantillaData.Actualizar(this);
        }

        /// <summary>
        /// Elimina un registro existente.
        /// </summary>
        public void Eliminar()
        {
            if (!this.Ejecutada)
            {
                Boolean TransacionPropia = false;

                ValidarLogica(TipoOperacion.Borrado);

                try
                {
                    TransacionPropia = BDController.IniciarTransaccion();

                    foreach (Transformacion Entrada in lstEntradas)
                        Entrada.Eliminar();

                    foreach (Transformacion Salida in lstSalidas)
                        Salida.Eliminar();

                    foreach (PlaVet Empleado in lstEmpleados)
                        Empleado.Eliminar();

                    foreach (PlaZon Zona in lstZonas)
                        Zona.Eliminar();

                    foreach (PlaMaq Maquina in lstMaquinas)
                        Maquina.Eliminar();

                    foreach (APPCC Punto in lstPuntosControl)
                        Punto.Eliminar();

                    PlantillaData.Eliminar(this);

                    if (TransacionPropia)
                        BDController.FinalizarTransaccion(true);
                }
                catch (Exception ex)
                {
                    if (TransacionPropia)
                        BDController.FinalizarTransaccion(false);

                    Traza.RegistrarError(ex);
                    throw ex;
                }
            }
            else
            {
                Plantilla Proceso = Plantilla.Buscar(this.Id);
                Proceso.Baja = true;
                Proceso.Actualizar();
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
                    rtno = new Plantilla();
                    break;
                case TipoContexto.Modificacion:
                    rtno = PlantillaData.GetPlantillaOP(this.Id);
                    break;
            }

            return rtno;
        }

        /// <summary>
        /// Obtiene una plantilla a partir de su id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Máquina con el id especificado.</returns>
        public static Plantilla Buscar(int id)
        {
            return PlantillaData.GetPlantilla(id);
        }

        /// <summary>
        /// Obtiene las plantillas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idProducto">Id del producto implicado en el proceso.</param>
        /// <param name="inicioEjecucion">Inicio del intervalo de ejecución.</param>
        /// <param name="finEjecucion">Fin del intervalo de ejecución.</param>
        /// <returns>Plantillas que coinciden con los criterios de búsqueda.</returns>
        public static List<Plantilla> Buscar(int idProducto, DateTime inicioEjecucion, DateTime finEjecucion)
        {
            return PlantillaData.GetPlantillas(idProducto, inicioEjecucion, finEjecucion);
        }

        /// <summary>
        /// Obtiene las plantillas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idExplotacion">Id de la explotación seleccionada.</param> 
        /// <param name="descripcion">Descripción.</param>  
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Plantilla> Buscar(int idExplotacion, string descripcion)
        {
            return PlantillaData.GetPlantillas(idExplotacion, descripcion, null);
        }

        /// <summary>
        /// Obtiene las plantillas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="nombre">Nombre.</param>  
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Plantilla> Buscar(string descripcion)
        {
            return PlantillaData.GetPlantillas(Configuracion.Explotacion.Id, descripcion, false);
        }

        /// <summary>
        /// Obtiene todos los registros de plantillas.
        /// </summary>
        /// <returns>Devuelve todos los registros de la tabla></returns>
        public static List<Plantilla> Buscar()
        {
            return PlantillaData.GetPlantillas(Configuracion.Explotacion.Id, string.Empty, null);
        }

        /// <summary>
        /// Obtiene si un producto está implicado en una fecha de ejecución del proceso.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id del producto.</param>
        /// <param name="ejecucion">Fecha de ejecución</param>
        /// <returns>Si el producto está implicado o no en una ejecución.</returns>
        public static bool TieneProductoImplicado(int idPlantilla, int idProducto, DateTime ejecucion)
        {
            return PlantillaData.TieneProductoImplicado(idPlantilla, idProducto, ejecucion);
        }

        #endregion

        #region PROPIEDADES PERSONALIZADAS

        public bool Ejecutada
        {
            get { return this.lstEjecuciones.Count > 0; }
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA

        /// <summary>
        /// Ejecuta el proceso.
        /// </summary>
        public void Ejecutar()
        {
            Boolean TransacionPropia = false;

            try
            {
                DateTime Ejecucion = DateTime.Now;

                TransacionPropia = BDController.IniciarTransaccion();

                if (lstEntradas.Count > 0 && lstSalidas.Count > 0)
                    new Ejecucion() { IdPlantilla = this.Id, Fecha = Ejecucion }.Insertar();
                else
                    throw new LogicException("El proceso debe tener al menos una entrada y una salida.");

                foreach (Transformacion Entrada in lstEntradas)
                {
                    Entrada.FechaEjecucion = Ejecucion;
                    Movimiento.GenerarMovimiento(TipoOperacion.Borrado, Entrada);
                }

                foreach (Transformacion Salida in lstSalidas)
                {
                    Salida.FechaEjecucion = Ejecucion;
                    Movimiento.GenerarMovimiento(TipoOperacion.Insercion, Salida);
                }

                if (TransacionPropia)
                    BDController.FinalizarTransaccion(true);
            }
            catch (LogicException)
            {
                if (TransacionPropia)
                    BDController.FinalizarTransaccion(false);

                throw;
            }
            catch (Exception ex)
            {
                if (TransacionPropia)
                    BDController.FinalizarTransaccion(false);

                Traza.RegistrarError(ex);
                throw ex;
            }
        }

        public List<Transformacion> lstEntradas
        {
            get { return Transformacion.BuscarActuales(this.Id, 'E'); }
        }

        public List<Transformacion> lstSalidas
        {
            get { return Transformacion.BuscarActuales(this.Id, 'S'); }
        }

        public List<PlaVet> lstEmpleados
        {
            get { return Logic.PlaVet.BuscarActuales(this.Id); }
        }

        public List<PlaZon> lstZonas
        {
            get { return Logic.PlaZon.BuscarActuales(this.Id); }
        }

        public List<PlaMaq> lstMaquinas
        {
            get { return Logic.PlaMaq.BuscarActuales(this.Id); }
        }

        public List<Ejecucion> lstEjecuciones
        {
            get { return Logic.Ejecucion.Buscar(this.Id, null); }
        }

        public List<APPCC> lstPuntosControl
        {
            get { return Logic.APPCC.Buscar(this.IdExplotacion, this.Id, null, null, null, null, null, null, null); }
        }

        #endregion

        #region VALIDACIONES Y COMPROBACIONES DE LA LOGICA DE NEGOCIO

        /// <summary>
        /// Valida la lógica de negocio, concluye si la operacion es admitida.
        /// </summary>
        /// <param name="operacion">Operación realizada.</param>
        private void ValidarLogica(TipoOperacion operacion)
        {
        }

        #endregion
    }
}
