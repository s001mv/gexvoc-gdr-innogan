using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ExpProData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ExpPro">ExpPro a insertar.</param>
        public static void Insertar(ExpPro ExpPro)
        {
            BDController.BDOperaciones.ExpPro.InsertOnSubmit(ExpPro);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ExpPro">ExpPro a actualizar.</param>
        public static void Actualizar(ExpPro ExpPro)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ExpPro">ExpPro a eliminar.</param>
        public static void Eliminar(ExpPro ExpPro)
        {
            ExpPro ObjBorrar = GetExpProOP(ExpPro.IdExplotacion, ExpPro.IdProveedor);

            BDController.BDOperaciones.ExpPro.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ExpPro GetExpProOP(int idExplotacion, int idProveedor)
        {
            return BDController.BDOperaciones.ExpPro.Single(E => E.IdExplotacion == idExplotacion && E.IdProveedor == idProveedor);
        }

        /// <summary>
        /// Obtiene un/una ExpPro a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ExpPro GetExpPro(int idExplotacion, int idProveedor)
        {
            ExpPro Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.ExpPro.Single(E => E.IdExplotacion == idExplotacion && E.IdProveedor == idProveedor);
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
        /// Obtiene los/las ExpPro que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ExpPro> GetExpPros(int? idExplotacion, int? idProveedor, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<ExpPro> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<ExpPro> Consulta = BD.ExpPro;

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (idProveedor != null)
                    Consulta = Consulta.Where(E => E.IdProveedor == idProveedor);
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
