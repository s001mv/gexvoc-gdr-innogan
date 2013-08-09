using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoAltaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoAlta">TipoAlta a insertar.</param>
        public static void Insertar(TipoAlta TipoAlta)
        {
            BDController.BDOperaciones.TiposAltas.InsertOnSubmit(TipoAlta);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoAlta">TipoAlta a actualizar.</param>
        public static void Actualizar(TipoAlta TipoAlta)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoAlta">TipoAlta a eliminar.</param>
        public static void Eliminar(TipoAlta TipoAlta)
        {
            TipoAlta ObjBorrar = GetTipoAltaOP(TipoAlta.Id);
            BDController.BDOperaciones.TiposAltas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoAlta GetTipoAltaOP(int id)
        {
            TipoAlta rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TiposAltas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoAlta a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoAlta GetTipoAlta(int id)
        {
            TipoAlta Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposAltas.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoAlta que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoAlta> GetTiposAltas(string descripcion,bool? sistema)
        {
            List<TipoAlta> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoAlta> Consulta = BD.TiposAltas;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema != null)
                    Consulta = Consulta.Where(E => E.Sistema==sistema);


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