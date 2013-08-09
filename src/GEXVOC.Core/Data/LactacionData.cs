using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class LactacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Lactacion">Lactacion a insertar.</param>
        public static void Insertar(Lactacion Lactacion)
        {
            BDController.BDOperaciones.Lactaciones.InsertOnSubmit(Lactacion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Lactacion">Lactacion a actualizar.</param>
        public static void Actualizar(Lactacion Lactacion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Lactacion">Lactacion a eliminar.</param>
        public static void Eliminar(Lactacion Lactacion)
        {
            Lactacion ObjBorrar = GetLactacionOP(Lactacion.Id);
            BDController.BDOperaciones.Lactaciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Lactacion GetLactacionOP(int id)
        {
            Lactacion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Lactaciones.Single(E => E.Id == id);
            }
            catch (Exception) { }
            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Lactacion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Lactacion GetLactacion(int id)
        {
            Lactacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Lactaciones.Single(E => E.Id == id);
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
        /// Obtiene los/las Lactacion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Lactacion> GetLactaciones(int? idHembra, DateTime? fechaInicio, DateTime? fechaFin,Boolean? modificable)
        {
            List<Lactacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Lactacion> Consulta = BD.Lactaciones;

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra==idHembra);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio == fechaInicio);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin == fechaFin);
                if (modificable != null)
                    Consulta = Consulta.Where(E => E.Modificable == modificable);


                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);//Ordenacion Inicial

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
        public static List<Lactacion> GetLactaciones(int? idHembra, DateTime? fechaIntervaloInicio, DateTime? fechaIntervaloFin)
        {
            List<Lactacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Lactacion> Consulta = BD.Lactaciones;

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);
                if (fechaIntervaloInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio >= fechaIntervaloInicio);
                if (fechaIntervaloFin != null)
                    Consulta = Consulta.Where(E => E.FechaInicio <= fechaIntervaloFin);               


                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);//Ordenacion Inicial

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


        public static Lactacion GetLactacioAbierta(int idHembra)
        {
            Lactacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Lactaciones.Single(E => E.IdHembra == idHembra && E.FechaFin==null);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception){}
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }
        public static Lactacion GetLactacioAbiertaIdLactacion(int idLactacion)
        {
            Lactacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Lactaciones.Single(E => E.Id == idLactacion && E.FechaFin == null);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception) { }
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

        public static Lactacion GetUltimaLactacion(int idAnimal)
        {
            Lactacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Lactaciones.Where(E => E.IdHembra == idAnimal).OrderByDescending(E => E.Id).First();
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception) { }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;



        }

        #endregion

    }
}
