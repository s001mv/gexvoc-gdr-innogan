using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class FamiliaSemillaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="FamiliaSemilla">FamiliaSemilla a insertar.</param>
        public static void Insertar(FamiliaSemilla FamiliaSemilla)
        {
            BDController.BDOperaciones.FamiliasSemillas.InsertOnSubmit(FamiliaSemilla);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="FamiliaSemilla">FamiliaSemilla a actualizar.</param>
        public static void Actualizar(FamiliaSemilla FamiliaSemilla)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="FamiliaSemilla">FamiliaSemilla a eliminar.</param>
        public static void Eliminar(FamiliaSemilla FamiliaSemilla)
        {
            FamiliaSemilla ObjBorrar = GetFamiliaSemillaOP(FamiliaSemilla.Id);
            BDController.BDOperaciones.FamiliasSemillas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static FamiliaSemilla GetFamiliaSemillaOP(int id)
        {
            FamiliaSemilla rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.FamiliasSemillas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una FamiliaSemilla a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static FamiliaSemilla GetFamiliaSemilla(int id)
        {
            FamiliaSemilla Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.FamiliasSemillas.Single(E => E.Id == id);
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
        /// Obtiene los/las FamiliaSemilla que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<FamiliaSemilla> GetFamiliasSemillas(string descripcion)
        {
            List<FamiliaSemilla> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<FamiliaSemilla> Consulta = BD.FamiliasSemillas;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


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