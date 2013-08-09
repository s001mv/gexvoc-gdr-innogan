using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class BajaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Baja">Baja a insertar.</param>
        public static void Insertar(Baja Baja)
        {
            BDController.BDOperaciones.Bajas.InsertOnSubmit(Baja);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Baja">Baja a actualizar.</param>
        public static void Actualizar(Baja Baja)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Baja">Baja a eliminar.</param>
        public static void Eliminar(Baja Baja)
        {
            Baja ObjBorrar = GetBajaOP(Baja.Id);
            BDController.BDOperaciones.Bajas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Baja GetBajaOP(int id)
        {
            Baja rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Bajas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Baja a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Baja GetBaja(int id)
        {
            Baja Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Bajas.Single(E => E.Id == id);
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
        public static Baja GetBajaAnimal(int idAnimal)
        {
            Baja Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Bajas.Single(E => E.IdAnimal == idAnimal);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Baja que coinciden con los criterios de búsqueda.
        /// </summary>
        //public static List<Baja> GetBajas(string descripcion)
        //{
        //    List<Baja> lista = null;
        //    GEXVOCDataContext BD = BDController.NuevoContexto;
        //    try
        //    {

        //        IQueryable<Baja> Consulta = BD.Bajas;

        //        if (descripcion != string.Empty)
        //            Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


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