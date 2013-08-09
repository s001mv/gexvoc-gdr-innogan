using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoPartoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoParto">TipoParto a insertar.</param>
        public static void Insertar(TipoParto TipoParto)
        {
            BDController.BDOperaciones.TiposPartos.InsertOnSubmit(TipoParto);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoParto">TipoParto a actualizar.</param>
        public static void Actualizar(TipoParto TipoParto)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoParto">TipoParto a eliminar.</param>
        public static void Eliminar(TipoParto TipoParto)
        {
            TipoParto ObjBorrar = GetTipoPartoOP(TipoParto.Id);
            BDController.BDOperaciones.TiposPartos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoParto GetTipoPartoOP(int id)
        {
            return BDController.BDOperaciones.TiposPartos.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una TipoParto a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoParto GetTipoParto(int id)
        {
            TipoParto Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposPartos.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoParto que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoParto> GetTiposPartos(string descripcion,Boolean? sistema)
        {
            List<TipoParto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<TipoParto> Consulta = BD.TiposPartos;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema != null)
                    Consulta = Consulta.Where(E => E.Sistema==sistema);


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