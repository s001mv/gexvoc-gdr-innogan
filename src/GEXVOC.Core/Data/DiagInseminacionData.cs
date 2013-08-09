using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class DiagInseminacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="DiagInseminacion">DiagInseminacion a insertar.</param>
        public static void Insertar(DiagInseminacion DiagInseminacion)
        {
            BDController.BDOperaciones.DiagsInseminaciones.InsertOnSubmit(DiagInseminacion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="DiagInseminacion">DiagInseminacion a actualizar.</param>
        public static void Actualizar(DiagInseminacion DiagInseminacion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="DiagInseminacion">DiagInseminacion a eliminar.</param>
        public static void Eliminar(DiagInseminacion DiagInseminacion)
        {
            DiagInseminacion ObjBorrar = GetDiagInseminacionOP(DiagInseminacion.Id);
            BDController.BDOperaciones.DiagsInseminaciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static DiagInseminacion GetDiagInseminacionOP(int id)
        {
            DiagInseminacion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.DiagsInseminaciones.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una DiagInseminacion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static DiagInseminacion GetDiagInseminacion(int id)
        {
            DiagInseminacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.DiagsInseminaciones.Single(E => E.Id == id);
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
        /// Obtiene los/las DiagInseminacion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<DiagInseminacion> GetDiagInseminaciones(int? idAnimal, int? idTipo, DateTime? fecha, Boolean? resultado, Boolean? modificable)
        {
            List<DiagInseminacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 IQueryable<DiagInseminacion> Consulta = BD.DiagsInseminaciones;

                 Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);
                 
                if (idAnimal != null)                     
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);                    
                if (idTipo !=null)
                    Consulta = Consulta.Where(E => E.IdTipo==idTipo);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);
                if (resultado != null)
                    Consulta = Consulta.Where(E => E.Resultado == resultado);
                if (modificable != null)
                    Consulta = Consulta.Where(E => E.Modificable == modificable);


                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial

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
        public static List<DiagInseminacion> GetDiagInseminaciones(int? idAnimal,  DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<DiagInseminacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<DiagInseminacion> Consulta = BD.DiagsInseminaciones;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);

                if (fechaInicio.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                if (fechaFin.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial

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

        public static List<DiagInseminacion> GetDiagInseminaciones(int? idAnimal, DateTime? fechaInicio, DateTime? fechaFin, bool? resultado)
        {
            List<DiagInseminacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<DiagInseminacion> Consulta = BD.DiagsInseminaciones;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);

                if (fechaInicio.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);

                if (fechaFin.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaFin);

                if (resultado.HasValue)
                    Consulta = Consulta.Where(E => E.Resultado == resultado);

                Consulta = Consulta.OrderByDescending(E => E.Fecha);

                Funciones.DescubrirPropiedades(Consulta);

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