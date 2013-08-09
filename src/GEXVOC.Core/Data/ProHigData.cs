using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ProHigData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ProHig">ProHig a insertar.</param>
        public static void Insertar(ProHig ProHig)
        {
            BDController.BDOperaciones.ProHig.InsertOnSubmit(ProHig);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ProHig">ProHig a actualizar.</param>
        public static void Actualizar(ProHig ProHig)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ProHig">ProHig a eliminar.</param>
        public static void Eliminar(ProHig ProHig)
        {
            ProHig ObjBorrar = GetProHigOP(ProHig.IdTratHigiene,ProHig.IdProducto);
            BDController.BDOperaciones.ProHig.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ProHig GetProHigOP(int idTratHigiene,int idProducto)
        {
            ProHig rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.ProHig.Single(E => E.IdTratHigiene == idTratHigiene & E.IdProducto==idProducto);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una ProHig a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ProHig GetProHig(int idTratHigiene,int idProducto)
        {
            ProHig Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.ProHig.Single(E => E.IdTratHigiene == idTratHigiene & E.IdProducto==idProducto);
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
        /// Obtiene los/las ProHig que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ProHig> GetProHig(int? idTratHigiene,int? idProducto,decimal? cantidad)
        {
            List<ProHig> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<ProHig> Consulta = BD.ProHig;

                if (idTratHigiene != null)
                    Consulta = Consulta.Where(E => E.IdTratHigiene==idTratHigiene);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);


                Consulta = Consulta.OrderBy(E => E.Producto.Descripcion);//Ordenacion Inicial
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