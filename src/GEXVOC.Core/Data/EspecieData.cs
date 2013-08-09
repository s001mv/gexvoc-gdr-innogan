using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class EspecieData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Especie">Especie a insertar.</param>
        public static void Insertar(Especie Especie)
        {
            BDController.BDOperaciones.Especies.InsertOnSubmit(Especie);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Especie">Especie a actualizar.</param>
        public static void Actualizar(Especie Especie)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Especie">Especie a eliminar.</param>
        public static void Eliminar(Especie Especie)
        {
            Especie ObjBorrar = GetEspecieOP(Especie.Id);
            BDController.BDOperaciones.Especies.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Especie GetEspecieOP(int id)
        {
            Especie rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Especies.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Especie a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Especie GetEspecie(int id)
        {
            Especie Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Especies.Single(E => E.Id == id);
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
        /// Obtiene los/las Especie que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Especie> GetEspecies(string descripcion)
        {
            List<Especie> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Especie> Consulta = BD.Especies;

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