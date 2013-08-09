using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoCompraData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoCompra">TipoCompra a insertar.</param>
        public static void Insertar(TipoCompra TipoCompra)
        {
            BDController.BDOperaciones.TiposCompras.InsertOnSubmit(TipoCompra);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoCompra">TipoCompra a actualizar.</param>
        public static void Actualizar(TipoCompra TipoCompra)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoCompra">TipoCompra a eliminar.</param>
        public static void Eliminar(TipoCompra TipoCompra)
        {
            TipoCompra ObjBorrar = GetTipoCompraOP(TipoCompra.Id);
            BDController.BDOperaciones.TiposCompras.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoCompra GetTipoCompraOP(int id)
        {
            TipoCompra rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TiposCompras.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoCompra a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoCompra GetTipoCompra(int id)
        {
            TipoCompra Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposCompras.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoCompra que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoCompra> GetTiposCompras(string descripcion)
        {
            List<TipoCompra> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoCompra> Consulta = BD.TiposCompras;

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