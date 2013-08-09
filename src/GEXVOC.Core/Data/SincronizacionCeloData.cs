using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class SincronizacionCeloData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="SincronizacionCelo">SincronizacionCelo a insertar.</param>
        public static void Insertar(SincronizacionCelo SincronizacionCelo)
        {
            BDController.BDOperaciones.SincronizacionCelos.InsertOnSubmit(SincronizacionCelo);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="SincronizacionCelo">SincronizacionCelo a actualizar.</param>
        public static void Actualizar(SincronizacionCelo SincronizacionCelo)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="SincronizacionCelo">SincronizacionCelo a eliminar.</param>
        public static void Eliminar(SincronizacionCelo SincronizacionCelo)
        {
            SincronizacionCelo ObjBorrar = GetSincronizacionCeloOP(SincronizacionCelo.Id);
            BDController.BDOperaciones.SincronizacionCelos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static SincronizacionCelo GetSincronizacionCeloOP(int id)
        {
            SincronizacionCelo rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.SincronizacionCelos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una SincronizacionCelo a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static SincronizacionCelo GetSincronizacionCelo(int id)
        {
            SincronizacionCelo Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.SincronizacionCelos.Single(E => E.Id == id);
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
        /// Obtiene los/las SincronizacionCelo que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<SincronizacionCelo> GetSincronizacionCelos(int? idHembra,int? idVeterinario,DateTime? fechaColocacion,
            DateTime? fechaInyeccion, DateTime? fechaPrevision, DateTime? fechaRetirada)
        {
            List<SincronizacionCelo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<SincronizacionCelo> Consulta = BD.SincronizacionCelos;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);
                if (idVeterinario != null)
                    Consulta = Consulta.Where(E => E.IdVeterinario == idVeterinario);
                if (fechaColocacion != null)
                    Consulta = Consulta.Where(E => E.FechaColocacion == fechaColocacion);
                if (fechaInyeccion != null)
                    Consulta = Consulta.Where(E => E.FechaInyeccion == fechaInyeccion);
                if (fechaPrevision != null)
                    Consulta = Consulta.Where(E => E.FechaPrevision == fechaPrevision);
                if (fechaRetirada != null)
                    Consulta = Consulta.Where(E => E.FechaRetirada == fechaRetirada);

                

                Consulta = Consulta.OrderByDescending(E => E.FechaColocacion??E.FechaInyeccion);//Ordenacion Inicial
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
        public static List<SincronizacionCelo> GetSincronizacionFecha(int? idHembra, DateTime fecha)
        {
            List<SincronizacionCelo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<SincronizacionCelo> Consulta = BD.SincronizacionCelos;
                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);

                Consulta = Consulta.Where(E => E.FechaColocacion == fecha);
                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 

                IQueryable<SincronizacionCelo> Consulta2 = BD.SincronizacionCelos;
                Consulta2 = Consulta2.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);
                if (idHembra != null)
                    Consulta2 = Consulta2.Where(E => E.IdHembra == idHembra);
                Consulta2 = Consulta2.Where(E => E.FechaInyeccion == fecha);
                Funciones.DescubrirPropiedades(Consulta2); //Ejecuta las propiedades del objeto que empiezan por Desc 


                            

                
              
                //(estas propiedades se utilizan habitualmente en los grids)
                lista = Consulta.Union(Consulta2).ToList();//Convierte la consulta en una lista
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

        public static List<SincronizacionCelo> GetSincronizacionFecha(int? idHembra, DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<SincronizacionCelo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<SincronizacionCelo> Consulta = BD.SincronizacionCelos;
                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);

                if (fechaInicio.HasValue)                
                    Consulta = Consulta.Where(E => E.FechaColocacion >= fechaInicio | E.FechaInyeccion>=fechaInicio);

                if (fechaFin.HasValue)
                    Consulta = Consulta.Where(E => (E.FechaRetirada??E.FechaColocacion) <= fechaFin | E.FechaInyeccion<=fechaFin);
                

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 

                Consulta = Consulta.OrderByDescending(E => E.FechaColocacion ?? E.FechaInyeccion);
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

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}