using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class InseminacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Inseminacion">Inseminacion a insertar.</param>
        public static void Insertar(Inseminacion Inseminacion)
        {
            BDController.BDOperaciones.Inseminaciones.InsertOnSubmit(Inseminacion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Inseminacion">Inseminacion a actualizar.</param>
        public static void Actualizar(Inseminacion Inseminacion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Inseminacion">Inseminacion a eliminar.</param>
        public static void Eliminar(Inseminacion Inseminacion)
        {
            Inseminacion ObjBorrar = GetInseminacionOP(Inseminacion.Id);

            if ( BDController.BDOperaciones.InsPar.Where(E=>E.IdInseminacion==ObjBorrar.Id).Count()!=0)            
                throw new LogicException("No es posible eliminar la inseminación para el animal: " + ObjBorrar.DescHembra +
                    " porque se encuentra asociada a un parto.");
            

            
            BDController.BDOperaciones.Inseminaciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Inseminacion GetInseminacionOP(int id)
        {
            return BDController.BDOperaciones.Inseminaciones.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una Inseminacion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Inseminacion GetInseminacion(int id)
        {
            Inseminacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 Obj = BD.Inseminaciones.Single(E => E.Id == id);
                 Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception){  }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
           
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Inseminacion que coinciden con los criterios de búsqueda.
        /// </summary>      
        public static List<Inseminacion> GetInseminaciones(int? idMacho, int? idHembra, int? idTipo, int? idVeterinario, 
                                                         int? idEmbrion, int? dosis, DateTime? fecha,Boolean? modificable)
        {
            List<Inseminacion> listaRtno = null;

            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Inseminacion> Consulta = BD.Inseminaciones;
                Consulta = Consulta.Where(E => E.Animal1.IdExplotacion == Configuracion.Explotacion.Id);

                if (idMacho != null)
                    Consulta = Consulta.Where(E => E.IdMacho == idMacho);
                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (idVeterinario != null)
                    Consulta = Consulta.Where(E => E.IdVeterinario == idVeterinario);           
                if (idEmbrion != null)
                    Consulta = Consulta.Where(E => E.IdEmbrion == idEmbrion);
                if (dosis != null)
                    Consulta = Consulta.Where(E => E.Dosis == dosis);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);
                if (modificable != null)
                    Consulta = Consulta.Where(E => E.Modificable == modificable);




                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)


                Consulta=Consulta.OrderByDescending(E => E.Fecha);

                listaRtno = Consulta.ToList();
            }
            catch (Exception) { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
          
            return listaRtno;
        }

        public static List<Inseminacion> GetInseminaciones( int? idHembra, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Inseminacion> listaRtno = null;

            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Inseminacion> Consulta = BD.Inseminaciones;
                Consulta = Consulta.Where(E => E.Animal1.IdExplotacion == Configuracion.Explotacion.Id);

              
                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);              
                if (fechaInicio.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                if (fechaFin.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaFin);
            



                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)


                Consulta = Consulta.OrderByDescending(E => E.Fecha);

                listaRtno = Consulta.ToList();
            }
            catch (Exception) { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }

            return listaRtno;
        }

        public static List<Inseminacion> GetInseminacionesLibres(int? idHembra,DateTime? fechaMayorDe)
        {
            List<Inseminacion> listaRtno = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Inseminacion> Consulta = BD.Inseminaciones                                                                                                                                                                                                            ;

                Consulta = Consulta.Where(E => E.Animal1.IdExplotacion == Configuracion.Explotacion.Id);
                    
                Consulta = Consulta.Where(E => E.InsPar.Count==0);
                   
                    if (idHembra != null)
                        Consulta = Consulta.Where(E => E.IdHembra == idHembra);
                    if (fechaMayorDe != null)
                        Consulta = Consulta.Where(E => E.Fecha >= fechaMayorDe);
                
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)


                Consulta = Consulta.OrderByDescending(E => E.Fecha);

                listaRtno = Consulta.ToList();
            }
            catch (Exception) { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
          
            return listaRtno;
        }
     



      

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}