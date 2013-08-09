using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class AniLotData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="AniLot">AniLot a insertar.</param>
        public static void Insertar(AniLot AniLot)
        {
            BDController.BDOperaciones.AniLot.InsertOnSubmit(AniLot);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="AniLot">AniLot a actualizar.</param>
        public static void Actualizar(AniLot AniLot)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="AniLot">AniLot a eliminar.</param>
        public static void Eliminar(AniLot AniLot)
        {
            AniLot ObjBorrar = GetAniLotOP(AniLot.IdLote,AniLot.IdAnimal);
            BDController.BDOperaciones.AniLot.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static AniLot GetAniLotOP(int idLote,int idAnimal)
        {
            AniLot rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.AniLot.Single(E => E.IdLote == idLote && E.IdAnimal==idAnimal);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una AniLot a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static AniLot GetAniLot(int idLote,int idAnimal)
        {
            AniLot Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                Obj = BD.AniLot.Single(E => E.IdLote == idLote && E.IdAnimal == idAnimal);
                Funciones.DescubrirPropiedades(Obj);

            }
            catch (Exception) { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las AniLot que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<AniLot> GetAniLotes(int? idLote,int? idAnimal,DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<AniLot> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<AniLot> Consulta = BD.AniLot;
                if (idLote != null)
                    Consulta = Consulta.Where(E => E.IdLote == idLote);
                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio == fechaInicio);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin == fechaFin);
                

                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);//Ordenacion Inicial
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

        /// <summary>
        /// Obtiene los/las AniLot que coinciden con los criterios de búsqueda.
        /// </summary>
        public static AniLot GetLoteActivo(int idAnimal)
        {
            AniLot Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                Obj = BD.AniLot.Single(E => E.IdAnimal == idAnimal && E.FechaFin == null);
                Funciones.DescubrirPropiedades(Obj);

            }
            catch (Exception) { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }



        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}