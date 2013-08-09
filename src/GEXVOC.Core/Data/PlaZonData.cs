using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class PlaZonData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="PlaZon">PlaZon a insertar.</param>
        public static void Insertar(PlaZon PlaZon)
        {
            BDController.BDOperaciones.PlaZon.InsertOnSubmit(PlaZon);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="PlaZon">PlaZon a actualizar.</param>
        public static void Actualizar(PlaZon PlaZon)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="PlaZon">PlaZon a eliminar.</param>
        public static void Eliminar(PlaZon PlaZon)
        {
            PlaZon ObjBorrar = GetPlaZonOP(PlaZon.IdPlantilla, PlaZon.IdZona, PlaZon.FechaInicio);

            BDController.BDOperaciones.PlaZon.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static PlaZon GetPlaZonOP(int idPlantilla, int idZona, DateTime fechaInicio)
        {
            PlaZon rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.PlaZon.Single(E => E.IdPlantilla == idPlantilla && E.IdZona == idZona && E.FechaInicio == fechaInicio);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una PlaZon a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="fechaEjecucion">Fecha de ejecucion.</param>
        /// <returns>PlaZon con el id especificado.</returns>
        public static List<PlaZon> GetPlaZon(int idPlantilla, DateTime fechaEjecucion)
        {
            List<PlaZon> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaZon> Consulta = BD.PlaZon;

                Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla && E.FechaInicio <= fechaEjecucion && (E.FechaFin == null || E.FechaFin >= fechaEjecucion));
                Funciones.DescubrirPropiedades(Consulta);

                lista = Consulta.ToList();
            }
            catch (Exception) { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return lista;
        }

        /// <summary>
        /// Obtiene un/una PlaZon a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idZona">Id de la zona.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaZon con el id especificado.</returns>
        public static PlaZon GetPlaZon(int idPlantilla, int idZona, DateTime fechaInicio)
        {
            PlaZon Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.PlaZon.Single(E => E.IdPlantilla == idPlantilla && E.IdZona == idZona && E.FechaInicio == fechaInicio);
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
        /// Obtiene un/una PlaZon abierta.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idZona">Id de la zona.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaZon con el id especificado.</returns>
        public static PlaZon GetPlaZonActual(int idPlantilla, int idZona)
        {
            PlaZon Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.PlaZon.Single(E => E.IdPlantilla == idPlantilla && E.IdZona == idZona && E.FechaFin == null);
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
        /// Obtiene los registros PlaZon actuales de la plantilla.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <returns>PlaZon actuales.</returns>
        public static List<PlaZon> GetActuales(int idPlantilla)
        {
            List<PlaZon> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaZon> Consulta = BD.PlaZon;

                Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla && E.FechaFin == null);
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
        /// Obtiene los/las PlaZon que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idZona">Id de la zona.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <param name="fechaFin">Fecha de fin.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<PlaZon> GetPlaZon(int? idPlantilla, int? idZona, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<PlaZon> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaZon> Consulta = BD.PlaZon;

                if (idPlantilla != null)
                    Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla);
                if (idZona != null)
                    Consulta = Consulta.Where(E => E.IdZona == idZona);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio == fechaInicio);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin == fechaFin);

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
