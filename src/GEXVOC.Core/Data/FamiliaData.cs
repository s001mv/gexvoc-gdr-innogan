using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class FamiliaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Familia">Familia a insertar.</param>
        public static void Insertar(Familia Familia)
        {
            BDController.BDOperaciones.Familias.InsertOnSubmit(Familia);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Familia">Familia a actualizar.</param>
        public static void Actualizar(Familia Familia)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Familia">Familia a eliminar.</param>
        public static void Eliminar(Familia Familia)
        {
            Familia ObjBorrar = GetFamiliaOP(Familia.Id);
            BDController.BDOperaciones.Familias.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Familia GetFamiliaOP(int id)
        {
            Familia rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Familias.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Familia a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Familia GetFamilia(int id)
        {
            Familia Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Familias.Single(E => E.Id == id);
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
        /// Obtiene los/las Familia que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Familia> GetFamilias(int? idTipo,string descripcion,bool? sistema)
        {
            List<Familia> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Familia> Consulta = BD.Familias;
                if (idTipo.HasValue)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema.HasValue)
                    Consulta = Consulta.Where(E => E.Sistema == sistema);


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial
              //  Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
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
        //public static List<Familia> GetFamilias()
        //{
        //    List<Familia> lista = null;
        //    GEXVOCDataContext BD = BDController.NuevoContexto;
        //    try
        //    {

        //        IQueryable<Familia> Consulta = BD.Familias;                

        //        Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial
        //        Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
        //        //(estas propiedades se utilizan habitualmente en los grids)
        //        lista = Consulta.ToList();//Convierte la consulta en una lista
        //    }
        //    catch (Exception)
        //    { throw; }
        //    finally
        //    {
        //        if (!BDController.TransaccionActiva)
        //            BD.Dispose();
        //    }
        //    return lista;
        //}


        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}