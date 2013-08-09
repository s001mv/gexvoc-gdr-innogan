using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoEnfermedadData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoEnfermedad">TipoEnfermedad a insertar.</param>
        public static void Insertar(TipoEnfermedad TipoEnfermedad)
        {
            BDController.BDOperaciones.TiposEnfermedades.InsertOnSubmit(TipoEnfermedad);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoEnfermedad">TipoEnfermedad a actualizar.</param>
        public static void Actualizar(TipoEnfermedad TipoEnfermedad)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoEnfermedad">TipoEnfermedad a eliminar.</param>
        public static void Eliminar(TipoEnfermedad TipoEnfermedad)
        {
            TipoEnfermedad ObjBorrar = GetTipoEnfermedadOP(TipoEnfermedad.Id);
            BDController.BDOperaciones.TiposEnfermedades.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoEnfermedad GetTipoEnfermedadOP(int id)
        {
            TipoEnfermedad rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TiposEnfermedades.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoEnfermedad a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoEnfermedad GetTipoEnfermedad(int id)
        {
            TipoEnfermedad Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposEnfermedades.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoEnfermedad que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoEnfermedad> GetTiposEnfermedades(string descripcion)
        {
            List<TipoEnfermedad> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<TipoEnfermedad> Consulta = BD.TiposEnfermedades;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial

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
