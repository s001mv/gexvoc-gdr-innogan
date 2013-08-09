using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class CubricionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Cubricion">Cubricion a insertar.</param>
        public static void Insertar(Cubricion Cubricion)
        {
            BDController.BDOperaciones.Cubriciones.InsertOnSubmit(Cubricion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Cubricion">Cubricion a actualizar.</param>
        public static void Actualizar(Cubricion Cubricion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Cubricion">Cubricion a eliminar.</param>
        public static void Eliminar(Cubricion Cubricion)
        {
            Cubricion ObjBorrar = GetCubricionOP(Cubricion.Id);
            BDController.BDOperaciones.Cubriciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Cubricion GetCubricionOP(int id)
        {
            Cubricion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Cubriciones.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Cubricion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Cubricion GetCubricion(int id)
        {
            Cubricion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Cubriciones.Single(E => E.Id == id);
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
        /// Obtiene los/las Cubricion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Cubricion> GetCubriciones(int? idLote,int? idTipo,DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<Cubricion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Cubricion> Consulta = BD.Cubriciones;
                Consulta = Consulta.Where(E => E.LoteAnimal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idLote != null)
                    Consulta = Consulta.Where(E => E.IdLote==idLote);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
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

        public static List<Cubricion> GetCubricionesEntreFechas(int? idLote, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Cubricion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Cubricion> Consulta = BD.Cubriciones;
                Consulta = Consulta.Where(E => E.LoteAnimal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idLote != null)
                    Consulta = Consulta.Where(E => E.IdLote == idLote);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio <= fechaInicio);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin >= fechaFin);


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
        public static List<Cubricion> GetCubricionesSinFechaFin(int? idLote)
        {
            List<Cubricion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Cubricion> Consulta = BD.Cubriciones;
                Consulta = Consulta.Where(E => E.LoteAnimal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idLote != null)
                    Consulta = Consulta.Where(E => E.IdLote == idLote);
              
                Consulta = Consulta.Where(E => E.FechaFin ==null);


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