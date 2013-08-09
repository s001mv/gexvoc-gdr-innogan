using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class AlimentoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Alimento">Alimento a insertar.</param>
        public static void Insertar(Alimento Alimento)
        {
            BDController.BDOperaciones.Alimentos.InsertOnSubmit(Alimento);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Alimento">Alimento a actualizar.</param>
        public static void Actualizar(Alimento Alimento)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Alimento">Alimento a eliminar.</param>
        public static void Eliminar(Alimento Alimento)
        {
            Alimento ObjBorrar = GetAlimentoOP(Alimento.Id);
            BDController.BDOperaciones.Alimentos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Alimento GetAlimentoOP(int id)
        {
            return BDController.BDOperaciones.Alimentos.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una Alimento a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Alimento GetAlimento(int id)
        {
            Alimento Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Alimentos.Single(E => E.Id == id);
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
        /// Obtiene los/las Alimento que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Alimento> GetAlimentos(int? idfamilia,string descripcion)
        {
            List<Alimento> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Alimento> Consulta = BD.Alimentos;

                if (idfamilia != null)
                    Consulta = Consulta.Where(E => E.IdFamilia == idfamilia);
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


                Consulta = Consulta.OrderBy(E => E.Familia.Descripcion).ThenBy(E => E.Descripcion);//Ordenacion Inicial

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)

                lista = Consulta.ToList();
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