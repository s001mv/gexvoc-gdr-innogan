using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class VentaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Venta">Venta a insertar.</param>
        public static void Insertar(Venta Venta)
        {
            BDController.BDOperaciones.Ventas.InsertOnSubmit(Venta);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Venta">Venta a actualizar.</param>
        public static void Actualizar(Venta Venta)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Venta">Venta a eliminar.</param>
        public static void Eliminar(Venta Venta)
        {
            Venta ObjBorrar = GetVentaOP(Venta.Id);
            BDController.BDOperaciones.Ventas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Venta GetVentaOP(int id)
        {
            Venta rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Ventas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Venta a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Venta GetVenta(int id)
        {
            Venta Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Ventas.Single(E => E.Id == id);
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
        /// Obtiene los/las Venta que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Venta> GetVentas(int? idExplotacion,int? idTipo, int? idProducto,int? idCliente, string concepto, int? cantidad,DateTime? fechaMayorIgual,DateTime? fechaMenorIgual,decimal?importe,Boolean? cobrada)
        {
            List<Venta> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Venta> Consulta = BD.Ventas;

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion==idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (idCliente != null)
                    Consulta = Consulta.Where(E => E.IdCliente == idCliente);
                if (concepto != string.Empty)
                    Consulta = Consulta.Where(E => E.Concepto.Contains(concepto));
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha>= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);
                if (importe != null)
                    Consulta = Consulta.Where(E => E.Importe == importe);
                if (cobrada != null)
                    Consulta = Consulta.Where(E => E.Cobrada == cobrada);


                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
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
        /// Nos indica si un producto ha sido utilizado en ventas alguna vez o no.
        /// Lo podemos utilizar para saber si un determinado producto tiene alguna fila en Ventas por ejemplo para los borrados del producto.
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns></returns>
        public static bool ProductoExistenteEnVentas(int idProducto)
        {
            bool rtno = false;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                rtno = !(BD.Ventas.Where(E => E.IdProducto == idProducto).Count() == 0);
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