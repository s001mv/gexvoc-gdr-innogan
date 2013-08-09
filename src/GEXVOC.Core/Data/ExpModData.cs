using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ExpModData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ExpMod">ExpMod a insertar.</param>
        public static void Insertar(ExpMod ExpMod)
        {
            BDController.BDOperaciones.ExpMod.InsertOnSubmit(ExpMod);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ExpMod">ExpMod a actualizar.</param>
        public static void Actualizar(ExpMod ExpMod)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ExpMod">ExpMod a eliminar.</param>
        public static void Eliminar(ExpMod ExpMod)
        {
            ExpMod ObjBorrar = GetExpModOP(ExpMod.IdExplotacion,ExpMod.IdModulo);
            BDController.BDOperaciones.ExpMod.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ExpMod GetExpModOP(int idExplotacion,int idModulo)
        {
            ExpMod rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.ExpMod.Single(E => E.IdExplotacion == idExplotacion & E.IdModulo==idModulo);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una ExpMod a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ExpMod GetExpMod(int idExplotacion,int idModulo)
        {
            ExpMod Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.ExpMod.Single(E => E.IdExplotacion == idExplotacion & E.IdModulo==idModulo);
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
        /// Obtiene los/las ExpMod que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ExpMod> GetExpMod(int?idExplotacion,int?idModulo)
        {
            List<ExpMod> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<ExpMod> Consulta = BD.ExpMod;

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion==idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);
                if (idModulo != null)
                    Consulta = Consulta.Where(E => E.IdModulo == idModulo);


                Consulta = Consulta.OrderBy(E => E.Modulo.Descripcion);//Ordenacion Inicial
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