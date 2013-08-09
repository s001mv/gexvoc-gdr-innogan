using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoVentaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoVenta">TipoVenta a insertar.</param>
        public static void Insertar(TipoVenta TipoVenta)
        {
            BDController.BDOperaciones.TiposVentas.InsertOnSubmit(TipoVenta);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoVenta">TipoVenta a actualizar.</param>
        public static void Actualizar(TipoVenta TipoVenta)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoVenta">TipoVenta a eliminar.</param>
        public static void Eliminar(TipoVenta TipoVenta)
        {
            TipoVenta ObjBorrar = GetTipoVentaOP(TipoVenta.Id);
            BDController.BDOperaciones.TiposVentas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoVenta GetTipoVentaOP(int id)
        {
            TipoVenta rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TiposVentas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoVenta a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoVenta GetTipoVenta(int id)
        {
            TipoVenta Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposVentas.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoVenta que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoVenta> GetTipoVentas(string descripcion)
        {
            List<TipoVenta> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoVenta> Consulta = BD.TiposVentas;

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