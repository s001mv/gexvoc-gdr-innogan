using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ExpEspData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ExpEsp">ExpEsp a insertar.</param>
        public static void Insertar(ExpEsp ExpEsp)
        {
            BDController.BDOperaciones.ExpEsp.InsertOnSubmit(ExpEsp);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ExpEsp">ExpEsp a actualizar.</param>
        public static void Actualizar(ExpEsp ExpEsp)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ExpEsp">ExpEsp a eliminar.</param>
        public static void Eliminar(ExpEsp expEsp)
        {
            ExpEsp ObjBorrar = GetExpEspOP(expEsp.IdEspecie, expEsp.IdExplotacion);
            BDController.BDOperaciones.ExpEsp.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ExpEsp GetExpEspOP(int idEspecie,int idExplotacion)
        {
            return BDController.BDOperaciones.ExpEsp.Single(E => E.IdEspecie == idEspecie && E.IdExplotacion == idExplotacion);
        }

        /// <summary>
        /// Obtiene un/una ExpEsp a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ExpEsp GetExpEsp(int id)
        {
            ExpEsp Obj = null;

            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 Obj = BD.ExpEsp.Single(E => E.Id == id);
                 Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception){ }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
                     
            return Obj;
        }

        
        /// Obtiene los/las ExpEsp que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ExpEsp> GetExpEsp(int? idExplotacion, int? idEspecie)
        {
            List<ExpEsp> rtno = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;           
            try
            {
                IQueryable<ExpEsp> Consulta = BD.ExpEsp;

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);

                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.IdEspecie == idEspecie);

                Consulta = Consulta.OrderBy(E => E.Explotacion.Nombre);//Ordenacion Inicial

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

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}
