using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class StatusOrdenoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="StatusOrdeno">StatusOrdeno a insertar.</param>
        public static void Insertar(StatusOrdeno StatusOrdeno)
        {
            BDController.BDOperaciones.StatusOrdenos.InsertOnSubmit(StatusOrdeno);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="StatusOrdeno">StatusOrdeno a actualizar.</param>
        public static void Actualizar(StatusOrdeno StatusOrdeno)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="StatusOrdeno">StatusOrdeno a eliminar.</param>
        public static void Eliminar(StatusOrdeno StatusOrdeno)
        {
            StatusOrdeno ObjBorrar = GetStatusOrdenoOP(StatusOrdeno.Id);
            BDController.BDOperaciones.StatusOrdenos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static StatusOrdeno GetStatusOrdenoOP(int id)
        {
            return BDController.BDOperaciones.StatusOrdenos.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una StatusOrdeno a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static StatusOrdeno GetStatusOrdeno(int id)
        {
            StatusOrdeno Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.StatusOrdenos.Single(E => E.Id == id);
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
        /// Obtiene los/las StatusOrdeno que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<StatusOrdeno> GetStatusOrdenos(string descripcion)
        {
            List<StatusOrdeno> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<StatusOrdeno> Consulta = BD.StatusOrdenos;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                          //(estas propiedades se utilizan habitualmente en los grids)
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
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}