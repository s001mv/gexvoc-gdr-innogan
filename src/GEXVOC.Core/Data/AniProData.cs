using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class AniProData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="AniPro">AniPro a insertar.</param>
        public static void Insertar(AniPro AniPro)
        {
            BDController.BDOperaciones.AniPro.InsertOnSubmit(AniPro);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="AniPro">AniPro a actualizar.</param>
        public static void Actualizar(AniPro AniPro)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="AniPro">AniPro a eliminar.</param>
        public static void Eliminar(AniPro AniPro)
        {
            AniPro ObjBorrar = GetAniProOP(AniPro.IdTratProfilaxis, AniPro.IdAnimal);
            BDController.BDOperaciones.AniPro.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static AniPro GetAniProOP(int IdTratProfilaxis, int IdAnimal)
        {
            AniPro rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.AniPro.Single(E => E.IdTratProfilaxis == IdTratProfilaxis & E.IdAnimal == IdAnimal);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una AniPro a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static AniPro GetAniPro(int IdTratProfilaxis, int IdAnimal)
        {
            AniPro Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.AniPro.Single(E => E.IdTratProfilaxis == IdTratProfilaxis & E.IdAnimal == IdAnimal);
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
        /// Obtiene los/las AniPro que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<AniPro> GetAniPro(int? IdTratProfilaxis, int? IdAnimal)
        {
            List<AniPro> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<AniPro> Consulta = BD.AniPro;

                if (IdTratProfilaxis != null)
                    Consulta = Consulta.Where(E => E.IdTratProfilaxis == IdTratProfilaxis);
                if (IdAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == IdAnimal);



                Consulta = Consulta.OrderBy(E => E.IdAnimal);//Ordenacion Inicial
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