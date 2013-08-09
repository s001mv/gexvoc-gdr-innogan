using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class StockData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Stock">Stock a insertar.</param>
        public static void Insertar(Stock Stock)
        {
            BDController.BDOperaciones.Stocks.InsertOnSubmit(Stock);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Stock">Stock a actualizar.</param>
        public static void Actualizar(Stock Stock)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Stock">Stock a eliminar.</param>
        public static void Eliminar(Stock Stock)
        {
            Stock ObjBorrar = GetStockOP(Stock.Id);
            BDController.BDOperaciones.Stocks.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Stock GetStockOP(int id)
        {
            Stock rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Stocks.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Stock a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Stock GetStock(int id)
        {
            Stock Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Stocks.Single(E => E.Id == id);
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

       public static Stock GetStockproducto(int? idProducto)
        {
            Stock Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                //IQueryable<Stock> lstStock=BD.Stocks.Where(E => E.IdProducto == idProducto).OrderByDescending(E=>E.Id);

                Obj = BD.Stocks.Where(E => E.IdProducto == idProducto & E.IdExplotacion==Configuracion.Explotacion.Id).OrderByDescending(E => E.Id).First();
                Funciones.DescubrirPropiedades(Obj);

            }
            catch (Exception)
            { //throw; 

            }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;

        }

        /// <summary>
        /// Obtiene los/las Stock que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Stock> GetStocks(int? idExplotacion,int? idProducto, int? idMacho,decimal? cantidad,decimal? precio)
        {
            List<Stock> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Stock> Consulta = BD.Stocks;

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion==idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (idMacho != null)
                    Consulta = Consulta.Where(E => E.IdMacho == idMacho);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
                if (precio != null)
                    Consulta = Consulta.Where(E => E.Precio == precio);
             
                
                Consulta = Consulta.OrderBy(E => E.Producto.Tipo.Descripcion).ThenBy(E=>E.Producto.Descripcion);//Ordenacion Inicial
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

        /// <summary>
        /// Nos indica si un producto ha sido utilizado en stock alguna vez o no.
        /// Lo podemos utilizar para saber si un determinado producto tiene alguna fila en Stocks por ejemplo para los borrados del producto.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public static bool ProductoExistenteEnStocks(int idProducto)
        {
            bool rtno = false;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                rtno = !(BD.Stocks.Where(E => E.IdProducto == idProducto & E.IdExplotacion == Configuracion.Explotacion.Id).Count() == 0);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return rtno;

        }
        #endregion

    }
}