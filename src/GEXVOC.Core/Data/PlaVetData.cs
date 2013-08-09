using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class PlaVetData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="PlaVet">PlaVet a insertar.</param>
        public static void Insertar(PlaVet PlaVet)
        {
            BDController.BDOperaciones.PlaVet.InsertOnSubmit(PlaVet);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="PlaVet">PlaVet a actualizar.</param>
        public static void Actualizar(PlaVet PlaVet)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="PlaVet">PlaVet a eliminar.</param>
        public static void Eliminar(PlaVet PlaVet)
        {
            PlaVet ObjBorrar = GetPlaVetOP(PlaVet.IdPlantilla, PlaVet.IdPersonal, PlaVet.FechaInicio);

            BDController.BDOperaciones.PlaVet.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static PlaVet GetPlaVetOP(int idPlantilla, int idPersonal, DateTime fechaInicio)
        {
            PlaVet rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.PlaVet.Single(E => E.IdPlantilla == idPlantilla && E.IdPersonal == idPersonal && E.FechaInicio == fechaInicio);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una PlaVet a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="fechaEjecucion">Fecha de ejecucion.</param>
        /// <returns>PlaVet con el id especificado.</returns>
        public static List<PlaVet> GetPlaVet(int idPlantilla, DateTime fechaEjecucion)
        {
            List<PlaVet> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaVet> Consulta = BD.PlaVet;

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
        /// Obtiene un/una PlaVet a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idPersonal">Id del empleado.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaVet con el id especificado.</returns>
        public static PlaVet GetPlaVet(int idPlantilla, int idPersonal, DateTime fechaInicio)
        {
            PlaVet Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.PlaVet.Single(E => E.IdPlantilla == idPlantilla && E.IdPersonal == idPersonal && E.FechaInicio == fechaInicio);
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
        /// Obtiene un/una PlaVet abierta.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idPersonal">Id del empleado.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaVet con el id especificado.</returns>
        public static PlaVet GetPlaVetActual(int idPlantilla, int idPersonal)
        {
            PlaVet Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.PlaVet.Single(E => E.IdPlantilla == idPlantilla && E.IdPersonal == idPersonal && E.FechaFin == null);
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
        /// Obtiene los registros PlaVet actuales de la plantilla.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <returns>PlaVet actuales.</returns>
        public static List<PlaVet> GetActuales(int idPlantilla)
        {
            List<PlaVet> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaVet> Consulta = BD.PlaVet;

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
        /// Obtiene los/las PlaVet que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idPersonal">Id del empleado.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <param name="fechaFin">Fecha de fin.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<PlaVet> GetPlaVet(int? idPlantilla, int? idPersonal, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<PlaVet> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaVet> Consulta = BD.PlaVet;

                if (idPlantilla != null)
                    Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla);
                if (idPersonal != null)
                    Consulta = Consulta.Where(E => E.IdPersonal == idPersonal);
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
