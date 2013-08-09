using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoEngrasamientoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoEngrasamiento">TipoEngrasamiento a insertar.</param>
        public static void Insertar(TipoEngrasamiento TipoEngrasamiento)
        {
            BDController.BDOperaciones.TiposEngrasamientos.InsertOnSubmit(TipoEngrasamiento);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoEngrasamiento">TipoEngrasamiento a actualizar.</param>
        public static void Actualizar(TipoEngrasamiento TipoEngrasamiento)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoEngrasamiento">TipoEngrasamiento a eliminar.</param>
        public static void Eliminar(TipoEngrasamiento TipoEngrasamiento)
        {
            TipoEngrasamiento ObjBorrar = GetTipoEngrasamientoOP(TipoEngrasamiento.Id);
            BDController.BDOperaciones.TiposEngrasamientos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoEngrasamiento GetTipoEngrasamientoOP(int id)
        {
            TipoEngrasamiento rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TiposEngrasamientos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoEngrasamiento a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoEngrasamiento GetTipoEngrasamiento(int id)
        {
            TipoEngrasamiento Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposEngrasamientos.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoEngrasamiento que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoEngrasamiento> GetTiposEngrasamientos(string descripcion, string detalle)
        {
            List<TipoEngrasamiento> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoEngrasamiento> Consulta = BD.TiposEngrasamientos;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));

                if (detalle != string.Empty)
                    Consulta = Consulta.Where(E => E.Detalle.Contains(detalle));


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