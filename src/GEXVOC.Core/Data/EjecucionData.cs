using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class EjecucionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Ejecucion">Ejecucion a insertar.</param>
        public static void Insertar(Ejecucion Ejecucion)
        {
            BDController.BDOperaciones.Ejecuciones.InsertOnSubmit(Ejecucion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Ejecucion">Ejecucion a actualizar.</param>
        public static void Actualizar(Ejecucion Ejecucion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Ejecucion">Ejecucion a eliminar.</param>
        public static void Eliminar(Ejecucion Ejecucion)
        {
            Ejecucion ObjBorrar = GetEjecucionOP(Ejecucion.Id);

            BDController.BDOperaciones.Ejecuciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Ejecucion GetEjecucionOP(int id)
        {
            Ejecucion rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.Ejecuciones.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene una máquina a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Ejecucion GetEjecucion(int id)
        {
            Ejecucion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.Ejecuciones.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return Obj;
        }

        /// <summary>
        /// Obtiene las máquinas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="fecha">Fecha de ejecución.</param>
        /// <returns>Lista de plantillas que se ajustan a los criterios de búsqueda.</returns>
        public static List<Ejecucion> GetEjecuciones(int? idPlantilla, DateTime? fecha)
        {
            List<Ejecucion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Ejecucion> Consulta = BD.Ejecuciones;

                if (idPlantilla != null)
                    Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla);

                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);

                Consulta = Consulta.OrderBy(E => E.Fecha);
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
