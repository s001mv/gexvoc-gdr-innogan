using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ExpTitData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ExpTit">ExpTit a insertar.</param>
        public static void Insertar(ExpTit ExpTit)
        {
            BDController.BDOperaciones.ExpTit.InsertOnSubmit(ExpTit);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ExpTit">ExpTit a actualizar.</param>
        public static void Actualizar(ExpTit ExpTit)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ExpTit">ExpTit a eliminar.</param>
        public static void Eliminar(ExpTit ExpTit)
        {
            ExpTit ObjBorrar = GetExpTitOP(ExpTit.IdExplotacion,ExpTit.IdTitular);
            BDController.BDOperaciones.ExpTit.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ExpTit GetExpTitOP(int idExplotacion,int idTitular)
        {
            return BDController.BDOperaciones.ExpTit.Single(E => E.IdExplotacion == idExplotacion && E.IdTitular==idTitular);
        }

        /// <summary>
        /// Obtiene un/una ExpTit a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ExpTit GetExpTit(int idExplotacion,int idTitular)
        {
            ExpTit Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 Obj = BD.ExpTit.Single(E => E.IdExplotacion == idExplotacion && E.IdTitular==idTitular);
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
        /// Obtiene los/las ExpTit que coinciden con los criterios de búsqueda.
        /// </summary>
          public static List<ExpTit> GetExpTits(int? idExplotacion,int? idTitular,DateTime? fechaInicio,DateTime? fechaFin)
          {
            List<ExpTit> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
               IQueryable<ExpTit> Consulta = BD.ExpTit;
                 
                  if (idExplotacion != null)
                      Consulta = Consulta.Where(E => E.IdExplotacion==idExplotacion);

                  if (idTitular != null)
                      Consulta = Consulta.Where(E => E.IdTitular==idTitular);
                  if (fechaInicio != null)
                      Consulta = Consulta.Where(E => E.FechaInicio==fechaInicio);
                  if (fechaFin != null)
                      Consulta = Consulta.Where(E => E.FechaFin==fechaFin);              
        
                  lista=Consulta.ToList();
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
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}
