using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoAnalisisData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoAnalisis">TipoAnalisis a insertar.</param>
        public static void Insertar(TipoAnalisis TipoAnalisis)
        {
            BDController.BDOperaciones.TipoAnalisis.InsertOnSubmit(TipoAnalisis);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoAnalisis">TipoAnalisis a actualizar.</param>
        public static void Actualizar(TipoAnalisis TipoAnalisis)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoAnalisis">TipoAnalisis a eliminar.</param>
        public static void Eliminar(TipoAnalisis TipoAnalisis)
        {
            TipoAnalisis ObjBorrar = GetTipoAnalisisOP(TipoAnalisis.Id);
            BDController.BDOperaciones.TipoAnalisis.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoAnalisis GetTipoAnalisisOP(int id)
        {
            TipoAnalisis rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TipoAnalisis.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoAnalisis a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoAnalisis GetTipoAnalisis(int id)
        {
            TipoAnalisis Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TipoAnalisis.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las TipoAnalisis que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoAnalisis> GetTipoAnalisis(string descripcion)
        {
            List<TipoAnalisis> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoAnalisis> Consulta = BD.TipoAnalisis;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial
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