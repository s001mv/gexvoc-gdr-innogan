using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoLoteData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoLote">TipoLote a insertar.</param>
        public static void Insertar(TipoLote TipoLote)
        {
            BDController.BDOperaciones.TipoLote.InsertOnSubmit(TipoLote);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoLote">TipoLote a actualizar.</param>
        public static void Actualizar(TipoLote TipoLote)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoLote">TipoLote a eliminar.</param>
        public static void Eliminar(TipoLote TipoLote)
        {
            TipoLote ObjBorrar = GetTipoLoteOP(TipoLote.Id);
            BDController.BDOperaciones.TipoLote.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoLote GetTipoLoteOP(int id)
        {
            TipoLote rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TipoLote.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoLote a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoLote GetTipoLote(int id)
        {
            TipoLote Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TipoLote.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoLote que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoLote> GetTipoLote(string descripcion, bool? sistema)
        {
            List<TipoLote> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoLote> Consulta = BD.TipoLote;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema.HasValue)
                    Consulta = Consulta.Where(E => E.Sistema == sistema);


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