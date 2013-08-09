using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoProductoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoProducto">TipoProducto a insertar.</param>
        public static void Insertar(TipoProducto TipoProducto)
        {
            BDController.BDOperaciones.TiposProductos.InsertOnSubmit(TipoProducto);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoProducto">TipoProducto a actualizar.</param>
        public static void Actualizar(TipoProducto TipoProducto)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoProducto">TipoProducto a eliminar.</param>
        public static void Eliminar(TipoProducto TipoProducto)
        {
            TipoProducto ObjBorrar = GetTipoProductoOP(TipoProducto.Id);
            BDController.BDOperaciones.TiposProductos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoProducto GetTipoProductoOP(int id)
        {
            TipoProducto rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TiposProductos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoProducto a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoProducto GetTipoProducto(int id)
        {
            TipoProducto Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposProductos.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoProducto que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoProducto> GetTiposProductos(string descripcion,Boolean? familia,Boolean? sistema)
        {
            List<TipoProducto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoProducto> Consulta = BD.TiposProductos;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (familia !=null)
                    Consulta = Consulta.Where(E => E.Familia  == familia);
                if (sistema != null)
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
