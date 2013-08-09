using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class PlantillaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Plantilla">Plantilla a insertar.</param>
        public static void Insertar(Plantilla Plantilla)
        {
            BDController.BDOperaciones.Plantillas.InsertOnSubmit(Plantilla);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Plantilla">Plantilla a actualizar.</param>
        public static void Actualizar(Plantilla Plantilla)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Plantilla">Plantilla a eliminar.</param>
        public static void Eliminar(Plantilla Plantilla)
        {
            Plantilla ObjBorrar = GetPlantillaOP(Plantilla.Id);

            BDController.BDOperaciones.Plantillas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Plantilla GetPlantillaOP(int id)
        {
            Plantilla rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.Plantillas.Single(P => P.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene una plantilla a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Plantilla GetPlantilla(int id)
        {
            Plantilla Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.Plantillas.Single(P => P.Id == id);
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
        /// Obtiene las plantillas que coinciden con los criterios de búsqueda.
        /// </summary>
        /// <param name="idProducto">Id del producto implicado en el proceso.</param>
        /// <param name="inicioEjecucion">Inicio del intervalo de ejecución.</param>
        /// <param name="finEjecucion">Fin del intervalo de ejecución.</param>
        /// <returns>Plantillas que coinciden con los criterios de búsqueda.</returns>
        public static List<Plantilla> GetPlantillas(int idProducto, DateTime inicioEjecucion, DateTime finEjecucion)
        {
            List<Plantilla> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                var Consulta = (from P in BD.Plantillas
                               from T in P.Transformaciones
                               from E in P.Ejecuciones
                               where P.Id == T.IdPlantilla && P.Id == E.IdPlantilla && T.IdProducto == idProducto
                               && P.IdExplotacion == Configuracion.Explotacion.Id && (E.Fecha >= inicioEjecucion && E.Fecha <= finEjecucion)
                               orderby E.IdPlantilla, E.Fecha
                               select P).Distinct();

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
        /// Obtiene las plantillas que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Plantilla> GetPlantillas(int idExplotacion, string descripcion, bool? baja)
        {
            List<Plantilla> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Plantilla> Consulta = BD.Plantillas;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(P => P.Descripcion.Contains(descripcion));

                if (baja != null)
                    Consulta = Consulta.Where(P => P.Baja == baja);

                Consulta = Consulta.Where(P => P.IdExplotacion == idExplotacion);

                Consulta = Consulta.OrderBy(P => P.Descripcion);
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
        /// Obtiene si un producto está implicado en una fecha de ejecución del proceso.
        /// </summary>
        /// <param name="idPlantilla">Id de la plantilla.</param>
        /// <param name="idProducto">Id del producto.</param>
        /// <param name="ejecucion">Fecha de ejecución</param>
        /// <returns>Si el producto está implicado o no en una ejecución.</returns>
        public static bool TieneProductoImplicado(int idPlantilla, int idProducto, DateTime ejecucion)
        {
            bool rtno = false;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                rtno = !(BD.Transformaciones.Where(T => T.IdPlantilla == idPlantilla && T.IdProducto == idProducto
                    && T.FechaInicio <= ejecucion && (T.FechaFin == null || T.FechaFin >= ejecucion)).Count() == 0);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return rtno;
        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        #endregion
    }
}
