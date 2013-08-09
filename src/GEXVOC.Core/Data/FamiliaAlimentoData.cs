using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class FamiliaAlimentoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="FamiliaAlimento">FamiliaAlimento a insertar.</param>
        public static void Insertar(FamiliaAlimento FamiliaAlimento)
        {
            BDController.BDOperaciones.FamiliasAlimentos.InsertOnSubmit(FamiliaAlimento);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="FamiliaAlimento">FamiliaAlimento a actualizar.</param>
        public static void Actualizar(FamiliaAlimento FamiliaAlimento)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="FamiliaAlimento">FamiliaAlimento a eliminar.</param>
        public static void Eliminar(FamiliaAlimento FamiliaAlimento)
        {
            FamiliaAlimento ObjBorrar = GetFamiliaAlimentoOP(FamiliaAlimento.Id);
            BDController.BDOperaciones.FamiliasAlimentos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static FamiliaAlimento GetFamiliaAlimentoOP(int id)
        {
            FamiliaAlimento rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.FamiliasAlimentos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una FamiliaAlimento a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static FamiliaAlimento GetFamiliaAlimento(int id)
        {
            FamiliaAlimento Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.FamiliasAlimentos.Single(E => E.Id == id);
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
        /// Obtiene los/las FamiliaAlimento que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<FamiliaAlimento> GetFamiliasAlimentos(string descripcion)
        {
            List<FamiliaAlimento> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<FamiliaAlimento> Consulta = BD.FamiliasAlimentos;

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