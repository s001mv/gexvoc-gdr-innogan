using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TratHigieneData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TratHigiene">TratHigiene a insertar.</param>
        public static void Insertar(TratHigiene TratHigiene)
        {
            BDController.BDOperaciones.TratHigiene.InsertOnSubmit(TratHigiene);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TratHigiene">TratHigiene a actualizar.</param>
        public static void Actualizar(TratHigiene TratHigiene)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TratHigiene">TratHigiene a eliminar.</param>
        public static void Eliminar(TratHigiene TratHigiene)
        {
            TratHigiene ObjBorrar = GetTratHigieneOP(TratHigiene.Id);
            BDController.BDOperaciones.TratHigiene.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TratHigiene GetTratHigieneOP(int id)
        {
            TratHigiene rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TratHigiene.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TratHigiene a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TratHigiene GetTratHigiene(int id)
        {
            TratHigiene Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TratHigiene.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
               
            }
            catch (Exception)
            {  }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las TratHigiene que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TratHigiene> GetTratHigiene(int? idPlan,int? idExplotacion,string detalle,DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<TratHigiene> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TratHigiene> Consulta = BD.TratHigiene;

                if (idPlan!=null)
                    Consulta = Consulta.Where(E => E.IdPlan == idPlan);
                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (!string.IsNullOrEmpty(detalle))
                    Consulta = Consulta.Where(E => E.Detalle.Contains(detalle));
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin == fechaFin);


                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)
                lista = Consulta.ToList();//Convierte la consulta en una lista
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