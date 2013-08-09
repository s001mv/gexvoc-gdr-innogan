using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoDiagnosticoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoDiagnostico">TipoDiagnostico a insertar.</param>
        public static void Insertar(TipoDiagnostico TipoDiagnostico)
        {
            BDController.BDOperaciones.TiposDiagnosticos.InsertOnSubmit(TipoDiagnostico);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoDiagnostico">TipoDiagnostico a actualizar.</param>
        public static void Actualizar(TipoDiagnostico TipoDiagnostico)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoDiagnostico">TipoDiagnostico a eliminar.</param>
        public static void Eliminar(TipoDiagnostico TipoDiagnostico)
        {
            TipoDiagnostico ObjBorrar = GetTipoDiagnosticoOP(TipoDiagnostico.Id);
            BDController.BDOperaciones.TiposDiagnosticos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoDiagnostico GetTipoDiagnosticoOP(int id)
        {
            return BDController.BDOperaciones.TiposDiagnosticos.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una TipoDiagnostico a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoDiagnostico GetTipoDiagnostico(int id)
        {
            TipoDiagnostico Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposDiagnosticos.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoDiagnostico que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoDiagnostico> GetTipoDiagnosticos(string descripcion)
        {
            List<TipoDiagnostico> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<TipoDiagnostico> Consulta = BD.TiposDiagnosticos;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


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