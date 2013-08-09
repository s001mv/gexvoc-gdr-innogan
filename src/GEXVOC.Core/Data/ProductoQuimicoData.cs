using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ProductoQuimicoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ProductoQuimico">ProductoQuimico a insertar.</param>
        public static void Insertar(ProductoQuimico ProductoQuimico)
        {
            BDController.BDOperaciones.ProductosQuimicos.InsertOnSubmit(ProductoQuimico);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ProductoQuimico">ProductoQuimico a actualizar.</param>
        public static void Actualizar(ProductoQuimico ProductoQuimico)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ProductoQuimico">ProductoQuimico a eliminar.</param>
        public static void Eliminar(ProductoQuimico ProductoQuimico)
        {
            ProductoQuimico ObjBorrar = GetProductoQuimicoOP(ProductoQuimico.Id);
            BDController.BDOperaciones.ProductosQuimicos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ProductoQuimico GetProductoQuimicoOP(int id)
        {
            ProductoQuimico rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.ProductosQuimicos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una ProductoQuimico a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ProductoQuimico GetProductoQuimico(int id)
        {
            ProductoQuimico Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.ProductosQuimicos.Single(E => E.Id == id);
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
        /// Obtiene los/las ProductoQuimico que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ProductoQuimico> GetProductoQuimicos(string descripcion)
        {
            List<ProductoQuimico> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<ProductoQuimico> Consulta = BD.ProductosQuimicos;

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