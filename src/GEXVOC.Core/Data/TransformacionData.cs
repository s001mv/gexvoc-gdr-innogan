using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TransformacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Transformacion">Transformacion a insertar.</param>
        public static void Insertar(Transformacion Transformacion)
        {
            BDController.BDOperaciones.Transformaciones.InsertOnSubmit(Transformacion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Transformacion">Transformacion a actualizar.</param>
        public static void Actualizar(Transformacion Transformacion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Transformacion">Transformacion a eliminar.</param>
        public static void Eliminar(Transformacion Transformacion)
        {
            Transformacion ObjBorrar = GetTransformacionOP(Transformacion.IdPlantilla, Transformacion.IdProducto, Transformacion.FechaInicio);

            BDController.BDOperaciones.Transformaciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Transformacion GetTransformacionOP(int idPlantilla, int idProducto, DateTime fechaInicio)
        {
            Transformacion rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.Transformaciones.Single(E => E.IdPlantilla == idPlantilla && E.IdProducto == idProducto && E.FechaInicio == fechaInicio);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Transformacion a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id de la zona.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>Transformacion con el id especificado.</returns>
        public static Transformacion GetTransformacion(int idPlantilla, int idProducto, DateTime fechaInicio)
        {
            Transformacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.Transformaciones.Single(E => E.IdPlantilla == idPlantilla && E.IdProducto == idProducto && E.FechaInicio == fechaInicio);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception) { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return Obj;
        }

        /// <summary>
        /// Obtiene un/una Transformacion abierta.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id del producto.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>Transformacion con el id especificado.</returns>
        public static Transformacion GetTransformacionActual(int idPlantilla, int idProducto)
        {
            Transformacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.Transformaciones.Single(E => E.IdPlantilla == idPlantilla && E.IdProducto == idProducto && E.FechaFin == null);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception) { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return Obj;
        }

        public static List<Transformacion> GetActuales(int idPlantilla, char direccion)
        {
            List<Transformacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Transformacion> Consulta = BD.Transformaciones;

                Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla && E.FechaFin == null && E.Direccion == direccion);
                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);
                Funciones.DescubrirPropiedades(Consulta);

                lista = Consulta.ToList();
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return lista;
        }

        /// <summary>
        /// Obtiene los/las transformaciones que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id de la producto.</param>
        /// <param name="fechaEjecucion">Fecha de ejecucion.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Transformacion> GetTransformaciones(int? idPlantilla, int? idProducto, DateTime? fechaEjecucion, char direccion)
        {
            List<Transformacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Transformacion> Consulta = BD.Transformaciones;

                if (idPlantilla != null)
                    Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (fechaEjecucion != null)
                    Consulta = Consulta.Where(E => E.FechaInicio <= fechaEjecucion && (E.FechaFin == null || E.FechaFin >= fechaEjecucion));
                if (!char.IsWhiteSpace(direccion))
                    Consulta = Consulta.Where(E => E.Direccion == direccion);

                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);
                Funciones.DescubrirPropiedades(Consulta);

                lista = Consulta.ToList();
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return lista;
        }

        /// <summary>
        /// Obtiene los/las transformaciones que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id de la producto.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <param name="fechaFin">Fecha de fin.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<Transformacion> GetTransformaciones(int? idPlantilla, int? idProducto, DateTime? fechaInicio, DateTime? fechaFin, char direccion)
        {
            List<Transformacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Transformacion> Consulta = BD.Transformaciones;

                if (idPlantilla != null)
                    Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio == fechaInicio);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin == fechaFin);
                if (!char.IsWhiteSpace(direccion))
                    Consulta = Consulta.Where(E => E.Direccion == direccion);

                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);
                Funciones.DescubrirPropiedades(Consulta);

                lista = Consulta.ToList();
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return lista;
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        #endregion
    }
}
