using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class SemillaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Semilla">Semilla a insertar.</param>
        public static void Insertar(Semilla Semilla)
        {
            BDController.BDOperaciones.Semillas.InsertOnSubmit(Semilla);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Semilla">Semilla a actualizar.</param>
        public static void Actualizar(Semilla Semilla)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Semilla">Semilla a eliminar.</param>
        public static void Eliminar(Semilla Semilla)
        {
            Semilla ObjBorrar = GetSemillaOP(Semilla.Id);
            BDController.BDOperaciones.Semillas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Semilla GetSemillaOP(int id)
        {
            Semilla rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Semillas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Semilla a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Semilla GetSemilla(int id)
        {
            Semilla Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Semillas.Single(E => E.Id == id);
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
        /// Obtiene los/las Semilla que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Semilla> GetSemillas(int? idFamilia,string descripcion)
        {
            List<Semilla> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Semilla> Consulta = BD.Semillas;
                if (idFamilia != null)
                    Consulta = Consulta.Where(E => E.IdFamilia==idFamilia);
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


                Consulta = Consulta.OrderBy(E => E.Familia.Descripcion).ThenBy(E => E.Descripcion);//Ordenacion Inicial

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