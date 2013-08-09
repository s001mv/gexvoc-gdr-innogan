using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ExpCliData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ExpCli">ExpCli a insertar.</param>
        public static void Insertar(ExpCli ExpCli)
        {
            BDController.BDOperaciones.ExpCli.InsertOnSubmit(ExpCli);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ExpCli">ExpCli a actualizar.</param>
        public static void Actualizar(ExpCli ExpCli)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ExpCli">ExpCli a eliminar.</param>
        public static void Eliminar(ExpCli ExpCli)
        {
            ExpCli ObjBorrar = GetExpCliOP(ExpCli.IdExplotacion, ExpCli.IdCliente);

            BDController.BDOperaciones.ExpCli.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ExpCli GetExpCliOP(int idExplotacion, int idCliente)
        {
            return BDController.BDOperaciones.ExpCli.Single(E => E.IdExplotacion == idExplotacion && E.IdCliente == idCliente);
        }

        /// <summary>
        /// Obtiene un/una ExpCli a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ExpCli GetExpCli(int idExplotacion, int idCliente)
        {
            ExpCli Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.ExpCli.Single(E => E.IdExplotacion == idExplotacion && E.IdCliente == idCliente);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            {}
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
        
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las ExpCli que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ExpCli> GetExpClis(int? idExplotacion, int? idCliente, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<ExpCli> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<ExpCli> Consulta = BD.ExpCli;

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (idCliente != null)
                    Consulta = Consulta.Where(E => E.IdCliente == idCliente);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio == fechaInicio);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin == fechaFin);

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
