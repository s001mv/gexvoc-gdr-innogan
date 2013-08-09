using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoCubricionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoCubricion">TipoCubricion a insertar.</param>
        public static void Insertar(TipoCubricion TipoCubricion)
        {
            BDController.BDOperaciones.TipoCubricion.InsertOnSubmit(TipoCubricion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoCubricion">TipoCubricion a actualizar.</param>
        public static void Actualizar(TipoCubricion TipoCubricion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoCubricion">TipoCubricion a eliminar.</param>
        public static void Eliminar(TipoCubricion TipoCubricion)
        {
            TipoCubricion ObjBorrar = GetTipoCubricionOP(TipoCubricion.Id);
            BDController.BDOperaciones.TipoCubricion.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoCubricion GetTipoCubricionOP(int id)
        {
            TipoCubricion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TipoCubricion.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoCubricion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoCubricion GetTipoCubricion(int id)
        {
            TipoCubricion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TipoCubricion.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoCubricion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoCubricion> GetTipoCubricions(string descripcion)
        {
            List<TipoCubricion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoCubricion> Consulta = BD.TipoCubricion;

                if (descripcion != string.Empty)
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