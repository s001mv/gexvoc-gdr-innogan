using System;
using System.Linq;
using GEXVOC.Core.Logic;
using System.Collections.Generic;

namespace GEXVOC.Core.Data
{
    /// <summary>
    /// Realiza el acceso a datos para las operaciones con condiciones jurídicas.
    /// </summary>
    public class CondicionJuridicaData
    {
        #region ACTUALIZACIÓN DE DATOS (Insertar, Actualizar, Eliminar)

        /// <summary>
        /// Inserta una condición jurídica.
        /// </summary>
        /// <param name="cJuridica">Condición jurídica a insertar.</param>
        public static void Insertar(CondicionJuridica cJuridica)
        {
            BDController.BDOperaciones.CondicionesJuridicas.InsertOnSubmit(cJuridica);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza una condición jurídica.
        /// </summary>
        /// <param name="cJuridica">Condición jurídica a actualizar.</param>
        public static void Actualizar(CondicionJuridica cJuridica)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina una condición jurídica.
        /// </summary>
        /// <param name="cJuridica">Condición jurídica a eliminar.</param>
        public static void Eliminar(CondicionJuridica cJuridica)
        {
            CondicionJuridica ObjBorrar = GetCondicionJuridicaOP(cJuridica.Id);
            BDController.BDOperaciones.CondicionesJuridicas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)
        public static CondicionJuridica GetCondicionJuridicaOP(int id)
        {
            return BDController.BDOperaciones.CondicionesJuridicas.Single(E => E.Id == id);
        }
        /// <summary>
        /// Obtiene una Condición Jurídica a partir de su id.
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns></returns>
        public static CondicionJuridica GetCondicionJuridica(int id)
        {
            CondicionJuridica Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
               Obj = BD.CondicionesJuridicas.Single(E => E.Id == id);
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
        /// Obtine las condiciones jurídicas que coinciden con los criterios de busqueda.
        /// </summary>
        /// <param name="condicionJuridica">Condición Jurídica</param>
        /// <returns></returns>
        public static List<CondicionJuridica> GetCondicionesJuridicas(string condicionJuridica)
        {
            List<CondicionJuridica> rtno = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 IQueryable<CondicionJuridica> Consulta = BD.CondicionesJuridicas;
                if (condicionJuridica != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(condicionJuridica));
                Consulta = Consulta.OrderBy(E => E.Descripcion);

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                          //(estas propiedades se utilizan habitualmente en los grids)

                rtno = Consulta.ToList();
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
