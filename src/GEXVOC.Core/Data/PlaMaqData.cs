using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class PlaMaqData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="PlaMaq">PlaMaq a insertar.</param>
        public static void Insertar(PlaMaq PlaMaq)
        {
            BDController.BDOperaciones.PlaMaq.InsertOnSubmit(PlaMaq);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="PlaMaq">PlaMaq a actualizar.</param>
        public static void Actualizar(PlaMaq PlaMaq)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="PlaMaq">PlaMaq a eliminar.</param>
        public static void Eliminar(PlaMaq PlaMaq)
        {
            PlaMaq ObjBorrar = GetPlaMaqOP(PlaMaq.IdPlantilla, PlaMaq.IdMaquinaria, PlaMaq.FechaInicio);

            BDController.BDOperaciones.PlaMaq.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static PlaMaq GetPlaMaqOP(int idPlantilla, int idMaquinaria, DateTime fechaInicio)
        {
            PlaMaq rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.PlaMaq.Single(E => E.IdPlantilla == idPlantilla && E.IdMaquinaria == idMaquinaria && E.FechaInicio == fechaInicio);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una PlaMaq a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="fechaEjecucion">Fecha de ejecucion.</param>
        /// <returns>PlaMaq con el id especificado.</returns>
        public static List<PlaMaq> GetPlaMaq(int idPlantilla, DateTime fechaEjecucion)
        {
            List<PlaMaq> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaMaq> Consulta = BD.PlaMaq;

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
        /// Obtiene un/una PlaMaq a partir de su id.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idMaquinaria">Id de la máquina.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaMaq con el id especificado.</returns>
        public static PlaMaq GetPlaMaq(int idPlantilla, int idMaquinaria, DateTime fechaInicio)
        {
            PlaMaq Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.PlaMaq.Single(E => E.IdPlantilla == idPlantilla && E.IdMaquinaria == idMaquinaria && E.FechaInicio == fechaInicio);
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
        /// Obtiene un/una PlaMaq abierta.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idMaquinaria">Id de la máquina.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <returns>PlaMaq con el id especificado.</returns>
        public static PlaMaq GetPlaMaqActual(int idPlantilla, int idMaquinaria)
        {
            PlaMaq Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.PlaMaq.Single(E => E.IdPlantilla == idPlantilla && E.IdMaquinaria == idMaquinaria && E.FechaFin == null);
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
        /// Obtiene los registros PlaMaq actuales de la plantilla.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <returns>PlaMaq actuales.</returns>
        public static List<PlaMaq> GetActuales(int idPlantilla)
        {
            List<PlaMaq> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaMaq> Consulta = BD.PlaMaq;

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
        /// Obtiene los/las PlaMaq que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idMaquinaria">Id de la máquina.</param>
        /// <param name="fechaInicio">Fecha de inicio.</param>
        /// <param name="fechaFin">Fecha de fin.</param>
        /// <returns>ptlGenerics que coinciden con los criterios de búsqueda.</returns>
        public static List<PlaMaq> GetPlaMaq(int? idPlantilla, int? idMaquinaria, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<PlaMaq> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<PlaMaq> Consulta = BD.PlaMaq;

                if (idPlantilla != null)
                    Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla);
                if (idMaquinaria != null)
                    Consulta = Consulta.Where(E => E.IdMaquinaria == idMaquinaria);
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
