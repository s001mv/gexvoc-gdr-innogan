using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TareaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Tarea">Tarea a insertar.</param>
        public static void Insertar(Tarea Tarea)
        {
            BDController.BDOperaciones.Tareas.InsertOnSubmit(Tarea);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Tarea">Tarea a actualizar.</param>
        public static void Actualizar(Tarea Tarea)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Tarea">Tarea a eliminar.</param>
        public static void Eliminar(Tarea Tarea)
        {
            Tarea ObjBorrar = GetTareaOP(Tarea.Id);
            BDController.BDOperaciones.Tareas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Tarea GetTareaOP(int id)
        {
            Tarea rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Tareas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Tarea a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Tarea GetTarea(int id)
        {
            Tarea Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Tareas.Single(E => E.Id == id);
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
        /// Obtiene los/las Tarea que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Tarea> GetTareas(int? idExplotacion,string descripcion,DateTime? fecha)
        {
            List<Tarea> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Tarea> Consulta = BD.Tareas;
                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);


                Consulta = Consulta.OrderBy(E => E.Fecha);//Ordenacion Inicial
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

        public static List<Tarea> GetTareas(int? idExplotacion, string descripcion, DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<Tarea> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Tarea> Consulta = BD.Tareas;
                if (idExplotacion != null)
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.Fecha.Date >= ((DateTime)fechaInicio).Date);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.Fecha.Date <= ((DateTime)fechaFin).Date);


                Consulta = Consulta.OrderBy(E => E.Fecha);//Ordenacion Inicial
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