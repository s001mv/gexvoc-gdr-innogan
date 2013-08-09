using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class EngrasamientoCanalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="EngrasamientoCanal">EngrasamientoCanal a insertar.</param>
        public static void Insertar(EngrasamientoCanal EngrasamientoCanal)
        {
            BDController.BDOperaciones.EngrasamientosCanal.InsertOnSubmit(EngrasamientoCanal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="EngrasamientoCanal">EngrasamientoCanal a actualizar.</param>
        public static void Actualizar(EngrasamientoCanal EngrasamientoCanal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="EngrasamientoCanal">EngrasamientoCanal a eliminar.</param>
        public static void Eliminar(EngrasamientoCanal EngrasamientoCanal)
        {
            EngrasamientoCanal ObjBorrar = GetEngrasamientoCanalOP(EngrasamientoCanal.Id);
            BDController.BDOperaciones.EngrasamientosCanal.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static EngrasamientoCanal GetEngrasamientoCanalOP(int id)
        {
            EngrasamientoCanal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.EngrasamientosCanal.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una EngrasamientoCanal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static EngrasamientoCanal GetEngrasamientoCanal(int id)
        {
            EngrasamientoCanal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.EngrasamientosCanal.Single(E => E.Id == id);
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
        /// Obtiene los/las EngrasamientoCanal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<EngrasamientoCanal> GetEngrasamientosCanal(int? idAnimal, int? idTipo, DateTime? fecha)
        {
            List<EngrasamientoCanal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<EngrasamientoCanal> Consulta = BD.EngrasamientosCanal;
                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal==idAnimal);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);


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
        public static List<EngrasamientoCanal> GetEngrasamientosCanal(int? idAnimal, int? idTipo, DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<EngrasamientoCanal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<EngrasamientoCanal> Consulta = BD.EngrasamientosCanal;
                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (fechaInicio.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                if (fechaFin.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaFin);


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
        /// Nos retorna el engrasamiento en canal del animal
        /// Deber ser uno único, por animal.
        /// </summary>
        /// <param name="idAnimal"></param>
        /// <returns></returns>
        public static EngrasamientoCanal GetEngrasamientoCanalAnimal(int idAnimal)
        {
            EngrasamientoCanal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.EngrasamientosCanal.Single(E => E.IdAnimal == idAnimal);
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