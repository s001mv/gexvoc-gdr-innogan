using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoBajaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoBaja">TipoBaja a insertar.</param>
        public static void Insertar(TipoBaja TipoBaja)
        {
            BDController.BDOperaciones.TiposBajas.InsertOnSubmit(TipoBaja);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoBaja">TipoBaja a actualizar.</param>
        public static void Actualizar(TipoBaja TipoBaja)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoBaja">TipoBaja a eliminar.</param>
        public static void Eliminar(TipoBaja TipoBaja)
        {
            TipoBaja ObjBorrar = GetTipoBajaOP(TipoBaja.Id);
            BDController.BDOperaciones.TiposBajas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoBaja GetTipoBajaOP(int id)
        {
            TipoBaja rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TiposBajas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoBaja a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoBaja GetTipoBaja(int id)
        {
            TipoBaja Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposBajas.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoBaja que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoBaja> GetTipoBajas(string descripcion,bool? sistema)
        {
            List<TipoBaja> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoBaja> Consulta = BD.TiposBajas;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema != null)
                    Consulta = Consulta.Where(E => E.Sistema==sistema);



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