using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class CompraData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Compra">Compra a insertar.</param>
        public static void Insertar(Compra Compra)
        {
            BDController.BDOperaciones.Compras.InsertOnSubmit(Compra);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Compra">Compra a actualizar.</param>
        public static void Actualizar(Compra Compra)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Compra">Compra a eliminar.</param>
        public static void Eliminar(Compra Compra)
        {
            Compra ObjBorrar = GetCompraOP(Compra.Id);
            BDController.BDOperaciones.Compras.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Compra GetCompraOP(int id)
        {
            Compra rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Compras.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Compra a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Compra GetCompra(int id)
        {
            Compra Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Compras.Single(E => E.Id == id);
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
        /// Obtiene los/las Compra que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Compra> GetCompras(int? idExplotacion,int? idTipo, int? idProducto, int? idMacho, int? idProveedor,string concepto,int? cantidad, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual, decimal? Importe, Boolean? pagada )
        {
            List<Compra> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Compra> Consulta = BD.Compras;
           

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion==idExplotacion);   
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);

                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (idMacho != null)
                    Consulta = Consulta.Where(E => E.IdMacho == idMacho);
                if (idProveedor != null)
                    Consulta = Consulta.Where(E => E.IdProveedor == idProveedor);
                if (concepto != string.Empty)
                    Consulta = Consulta.Where(E => E.Concepto.Contains(concepto));
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >=fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);
                if (Importe != null)
                    Consulta = Consulta.Where(E => E.Importe == Importe);
                if (pagada != null)
                    Consulta = Consulta.Where(E => E.Pagada == pagada);

                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta);//Ejecuta las propiedades del objeto que empiezan por Desc 
                Funciones.DescubrirPropiedades(Consulta, "Id");
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


        /// <summary>
        /// Nos indica si un producto ha sido comprado alguna vez o no.
        /// Lo podemos utilizar para saber si un determinado producto tiene alguna fila en compras por ejemplo para los borrados del producto.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public static bool ProductoExistenteEnCompras(int idProducto)
        {
            bool rtno = false;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                rtno = !(BD.Compras.Where(E => E.IdProducto == idProducto).Count() == 0);
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

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}