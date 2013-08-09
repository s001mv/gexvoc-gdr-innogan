using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ExtendidaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Extendida">Extendida a insertar.</param>
        public static void Insertar(Extendida Extendida)
        {
            BDController.BDOperaciones.Extendidas.InsertOnSubmit(Extendida);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Extendida">Extendida a actualizar.</param>
        public static void Actualizar(Extendida Extendida)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Extendida">Extendida a eliminar.</param>
        public static void Eliminar(Extendida Extendida)
        {
            Extendida ObjBorrar = GetExtendidaOP(Extendida.Id);
            BDController.BDOperaciones.Extendidas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Extendida GetExtendidaOP(int id)
        {
            Extendida rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Extendidas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Extendida a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Extendida GetExtendida(int id)
        {
            Extendida Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Extendidas.Single(E => E.Id == id);
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
        /// Obtiene los/las Extendida que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Extendida> GetExtendidas(int? idLactacion, decimal? proteina,decimal? extracto, decimal? leche, decimal? lactosa, decimal? grasa, decimal? proteinaNorm, decimal? extractoNorm, decimal? lecheNorm, decimal? lactosaNorm, decimal? grasaNorm, decimal? proteinaExt, decimal? extractoExt, decimal? lecheExt, decimal?lactosaExt, decimal? grasaExt)
        {
            List<Extendida> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Extendida> Consulta = BD.Extendidas;

                if (idLactacion != null)
                    Consulta = Consulta.Where(E => E.IdLactacion==idLactacion);
                if (proteina != null)
                    Consulta = Consulta.Where(E => E.Proteina == proteina);
                if (extracto != null)
                    Consulta = Consulta.Where(E => E.Extracto == extracto);
                if (leche != null)
                    Consulta = Consulta.Where(E => E.Leche == leche);
                if (lactosa != null)
                    Consulta = Consulta.Where(E => E.Lactosa == lactosa);
                if (grasa != null)
                    Consulta = Consulta.Where(E => E.Grasa == grasa);
                if (proteinaNorm != null)
                    Consulta = Consulta.Where(E => E.ProteinaNorm == proteinaNorm);
                if (extractoNorm != null)
                    Consulta = Consulta.Where(E => E.ExtractoNorm == extractoNorm);
                if (lecheNorm != null)
                    Consulta = Consulta.Where(E => E.LecheNorm == lecheNorm);
                if (lactosaNorm != null)
                    Consulta = Consulta.Where(E => E.LactosaNorm == lactosaNorm);
                if (grasaNorm != null)
                    Consulta = Consulta.Where(E => E.GrasaNorm == grasaNorm);
                if (proteinaExt != null)
                    Consulta = Consulta.Where(E => E.ProteinaExt == proteinaExt);
                if (extractoExt != null)
                    Consulta = Consulta.Where(E => E.ExtractoExt == extractoExt);
                if (lecheExt != null)
                    Consulta = Consulta.Where(E => E.LecheExt == lecheExt);
                if (lactosaExt != null)
                    Consulta = Consulta.Where(E => E.LactosaExt == lactosaExt);
                if (grasaExt != null)
                    Consulta = Consulta.Where(E => E.GrasaExt == grasaExt);

                Consulta = Consulta.OrderBy(E => E.IdLactacion);//Ordenacion Inicial
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
