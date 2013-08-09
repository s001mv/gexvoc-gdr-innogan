using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoInseminacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoInseminacion">TipoInseminacion a insertar.</param>
        public static void Insertar(TipoInseminacion TipoInseminacion)
        {
            BDController.BDOperaciones.TiposInseminaciones.InsertOnSubmit(TipoInseminacion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoInseminacion">TipoInseminacion a actualizar.</param>
        public static void Actualizar(TipoInseminacion TipoInseminacion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoInseminacion">TipoInseminacion a eliminar.</param>
        public static void Eliminar(TipoInseminacion TipoInseminacion)
        {
            TipoInseminacion ObjBorrar = GetTipoInseminacionOP(TipoInseminacion.Id);
            BDController.BDOperaciones.TiposInseminaciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoInseminacion GetTipoInseminacionOP(int id)
        {
            return BDController.BDOperaciones.TiposInseminaciones.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una TipoInseminacion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoInseminacion GetTiposInseminaciones(int id)
        {
            TipoInseminacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposInseminaciones.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoInseminacion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoInseminacion> GetTiposInseminaciones(string descripcion,bool? sistema)
        {
            List<TipoInseminacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<TipoInseminacion> Consulta = BD.TiposInseminaciones;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));

                if (sistema != null)
                    Consulta = Consulta.Where(E => E.Sistema==sistema);


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