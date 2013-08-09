using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ProductoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Producto">Producto a insertar.</param>
        public static void Insertar(Producto Producto)
        {
            BDController.BDOperaciones.Productos.InsertOnSubmit(Producto);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Producto">Producto a actualizar.</param>
        public static void Actualizar(Producto Producto)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Producto">Producto a eliminar.</param>
        public static void Eliminar(Producto Producto)
        {
            Producto ObjBorrar = GetProductoOP(Producto.Id);
            BDController.BDOperaciones.Productos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Producto GetProductoOP(int id)
        {
            Producto rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Productos.Single(E => E.Id == id);              
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Producto a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Producto GetProducto(int id)
        {
            Producto Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Productos.Single(E => E.Id == id);
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
        /// Obtiene los/las Producto que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Producto> GetProductos(int? idTipo,int? idFamilia,string descripcion,decimal? supresionLeche,decimal? supresionCarne,bool? sistema)
        {
            List<Producto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Producto> Consulta = BD.Productos;

                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (idFamilia != null)
                    Consulta = Consulta.Where(E => E.IdFamilia == idFamilia);
                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (supresionLeche != null)
                    Consulta = Consulta.Where(E => E.SupresionLeche == supresionLeche);
                if (supresionCarne != null)
                    Consulta = Consulta.Where(E => E.SupresionCarne == supresionCarne);
                if (sistema != null)
                    Consulta = Consulta.Where(E => E.Sistema == sistema);


                Consulta = Consulta.OrderBy(E => E.Tipo.Descripcion).ThenBy(E => E.Familia.Descripcion).ThenBy(E => E.Descripcion);//Ordenacion Inicial
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


        public static List<Producto> GetProductosSinFamilia(int? idTipo, string descripcion, decimal? supresionLeche, decimal? supresionCarne)
        {
            List<Producto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {


                IQueryable<Producto> Consulta = BD.Productos;
                Consulta = Consulta.Where(E => E.IdFamilia == null);

                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (supresionLeche != null)
                    Consulta = Consulta.Where(E => E.SupresionLeche == supresionLeche);
                if (supresionCarne != null)
                    Consulta = Consulta.Where(E => E.SupresionCarne == supresionCarne);


                Consulta = Consulta.OrderBy(E => E.Tipo.Descripcion).ThenBy(E => E.Familia.Descripcion).ThenBy(E => E.Descripcion);//Ordenacion Inicial
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