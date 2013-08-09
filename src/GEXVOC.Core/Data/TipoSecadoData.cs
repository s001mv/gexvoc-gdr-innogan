using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoSecadoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoSecado">TipoSecado a insertar.</param>
        public static void Insertar(TipoSecado TipoSecado)
        {
            BDController.BDOperaciones.TiposSecados.InsertOnSubmit(TipoSecado);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoSecado">TipoSecado a actualizar.</param>
        public static void Actualizar(TipoSecado TipoSecado)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoSecado">TipoSecado a eliminar.</param>
        public static void Eliminar(TipoSecado TipoSecado)
        {
            TipoSecado ObjBorrar = GetTipoSecadoOP(TipoSecado.Id);
            BDController.BDOperaciones.TiposSecados.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoSecado GetTipoSecadoOP(int id)
        {
            return BDController.BDOperaciones.TiposSecados.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una TipoSecado a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoSecado GetTipoSecado(int id)
        {
            TipoSecado Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposSecados.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoSecado que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoSecado> GetTipoSecados(string descripcion,Boolean? sistema)
        {
            List<TipoSecado> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<TipoSecado> Consulta = BD.TiposSecados;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema != null)
                    Consulta = Consulta.Where(E => E.Sistema == sistema);


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                          //(estas propiedades se utilizan habitualmente en los grids)
                lista = Consulta.ToList();

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