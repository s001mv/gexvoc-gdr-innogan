using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class APPCCData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="APPCC">APPCC a insertar.</param>
        public static void Insertar(APPCC APPCC)
        {
            BDController.BDOperaciones.APPCC.InsertOnSubmit(APPCC);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="APPCC">APPCC a actualizar.</param>
        public static void Actualizar(APPCC APPCC)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="APPCC">APPCC a eliminar.</param>
        public static void Eliminar(APPCC APPCC)
        {
            APPCC ObjBorrar = GetAPPCCOP(APPCC.Id);
            BDController.BDOperaciones.APPCC.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static APPCC GetAPPCCOP(int id)
        {
            APPCC rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.APPCC.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una APPCC a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static APPCC GetAPPCC(int id)
        {
            APPCC Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.APPCC.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las APPCC que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<APPCC> GetAPPCC(int? idExplotacion, int? idPlantilla, string fase, string peligro, string prevencion,
            string limiteCritico, string vigilancia, string frecuencia, string correccion)
        {
            List<APPCC> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<APPCC> Consulta = BD.APPCC;

                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (idPlantilla != null)
                    Consulta = Consulta.Where(E => E.IdPlantilla == idPlantilla);
                if (!string.IsNullOrEmpty(fase))
                    Consulta = Consulta.Where(E => E.Fase.Contains(fase));
                if (!string.IsNullOrEmpty(peligro))
                    Consulta = Consulta.Where(E => E.Peligro.Contains(peligro));
                if (!string.IsNullOrEmpty(prevencion))
                    Consulta = Consulta.Where(E => E.Prevencion.Contains(prevencion));
                if (!string.IsNullOrEmpty(limiteCritico))
                    Consulta = Consulta.Where(E => E.LimiteCritico.Contains(limiteCritico));
                if (!string.IsNullOrEmpty(vigilancia))
                    Consulta = Consulta.Where(E => E.Vigilancia.Contains(vigilancia));
                if (!string.IsNullOrEmpty(frecuencia))
                    Consulta = Consulta.Where(E => E.Frecuencia.Contains(frecuencia));
                if (!string.IsNullOrEmpty(correccion))
                    Consulta = Consulta.Where(E => E.Correccion.Contains(correccion));

                //Consulta = Consulta.OrderBy(E => E.Fase);//Ordenacion Inicial
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