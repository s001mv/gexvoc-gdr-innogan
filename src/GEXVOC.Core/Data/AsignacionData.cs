using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class AsignacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Asignacion">Asignacion a insertar.</param>
        public static void Insertar(Asignacion Asignacion)
        {
            BDController.BDOperaciones.Asignaciones.InsertOnSubmit(Asignacion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Asignacion">Asignacion a actualizar.</param>
        public static void Actualizar(Asignacion Asignacion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Asignacion">Asignacion a eliminar.</param>
        public static void Eliminar(Asignacion Asignacion)
        {           
            Asignacion ObjBorrar = GetAsignacionOP(Asignacion.Id);
            BDController.BDOperaciones.Asignaciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Asignacion GetAsignacionOP(int id)
        {
            Asignacion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Asignaciones.Single(E => E.Id==id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Asignacion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Asignacion GetAsignacion(int idAsignacion)
        {
            Asignacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Asignaciones.Single(E => E.Id == idAsignacion);
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
        /// Obtiene los/las Asignacion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Asignacion> GetAsignaciones(int? idRacion, int? idAnimal, decimal? porcentaje,DateTime? fechaIntervalo, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Asignacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Asignacion> Consulta = BD.Asignaciones;

                if (idRacion !=null)
                    Consulta = Consulta.Where(E => E.IdRacion==idRacion);
                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);
                if (porcentaje != null)
                    Consulta = Consulta.Where(E => E.Porcentaje == porcentaje);
                if (fechaIntervalo != null)
                    Consulta = Consulta.Where(E => E.FechaInicio>=fechaIntervalo && (E.FechaFin.HasValue?E.FechaFin:DateTime.Today)<=fechaIntervalo);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio == fechaInicio);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin == fechaFin);


                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);//Ordenacion Inicial
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

        public static List<Asignacion> GetAsignaciones(int? idRacion, int? idAnimal, DateTime? fechaIntervaloInicio, DateTime? fechaIntervaloFin)
        {
            List<Asignacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Asignacion> Consulta = BD.Asignaciones;

                if (idRacion != null)
                    Consulta = Consulta.Where(E => E.IdRacion == idRacion);
                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);
                if (fechaIntervaloInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio >= fechaIntervaloInicio);
                if (fechaIntervaloFin != null)
                    Consulta = Consulta.Where(E => E.FechaInicio <= fechaIntervaloFin);               
              

                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);//Ordenacion Inicial
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