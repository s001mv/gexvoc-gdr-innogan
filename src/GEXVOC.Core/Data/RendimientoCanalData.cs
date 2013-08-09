using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class RendimientoCanalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="RendimientoCanal">RendimientoCanal a insertar.</param>
        public static void Insertar(RendimientoCanal RendimientoCanal)
        {
            BDController.BDOperaciones.RendimientosCanal.InsertOnSubmit(RendimientoCanal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="RendimientoCanal">RendimientoCanal a actualizar.</param>
        public static void Actualizar(RendimientoCanal RendimientoCanal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="RendimientoCanal">RendimientoCanal a eliminar.</param>
        public static void Eliminar(RendimientoCanal RendimientoCanal)
        {
            RendimientoCanal ObjBorrar = GetRendimientoCanalOP(RendimientoCanal.Id);
            BDController.BDOperaciones.RendimientosCanal.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static RendimientoCanal GetRendimientoCanalOP(int id)
        {
            RendimientoCanal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.RendimientosCanal.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una RendimientoCanal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static RendimientoCanal GetRendimientoCanal(int id)
        {
            RendimientoCanal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.RendimientosCanal.Single(E => E.Id == id);
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
        /// Obtiene los/las RendimientoCanal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<RendimientoCanal> GetRendimientosCanal(int? idAnimal, decimal? rendimiento, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            List<RendimientoCanal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<RendimientoCanal> Consulta = BD.RendimientosCanal;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal==idAnimal);
                if (rendimiento != null)
                    Consulta = Consulta.Where(E => E.Rendimiento == rendimiento);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);

                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
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
        /// Nos retorna la Rendimiento en canal del animal
        /// Deber ser uno único, por animal.
        /// </summary>
        /// <param name="idAnimal"></param>
        /// <returns></returns>
        public static RendimientoCanal GetRendimientoCanalAnimal(int idAnimal)
        {
            RendimientoCanal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.RendimientosCanal.Single(E => E.IdAnimal == idAnimal);
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


        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}