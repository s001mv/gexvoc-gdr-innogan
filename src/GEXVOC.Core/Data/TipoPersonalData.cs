using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoPersonalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoPersonal">TipoPersonal a insertar.</param>
        public static void Insertar(TipoPersonal TipoPersonal)
        {
            BDController.BDOperaciones.TipoPersonal.InsertOnSubmit(TipoPersonal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoPersonal">TipoPersonal a actualizar.</param>
        public static void Actualizar(TipoPersonal TipoPersonal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoPersonal">TipoPersonal a eliminar.</param>
        public static void Eliminar(TipoPersonal TipoPersonal)
        {
            TipoPersonal ObjBorrar = GetTipoPersonalOP(TipoPersonal.Id);
            BDController.BDOperaciones.TipoPersonal.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoPersonal GetTipoPersonalOP(int id)
        {
            TipoPersonal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TipoPersonal.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoPersonal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoPersonal GetTipoPersonal(int id)
        {
            TipoPersonal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TipoPersonal.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoPersonal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoPersonal> GetTipoPersonals(string descripcion)
        {
            List<TipoPersonal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoPersonal> Consulta = BD.TipoPersonal;

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