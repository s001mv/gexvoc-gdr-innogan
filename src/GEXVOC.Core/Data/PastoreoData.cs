using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class PastoreoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Pastoreo">Pastoreo a insertar.</param>
        public static void Insertar(Pastoreo Pastoreo)
        {
            BDController.BDOperaciones.Pastoreos.InsertOnSubmit(Pastoreo);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Pastoreo">Pastoreo a actualizar.</param>
        public static void Actualizar(Pastoreo Pastoreo)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Pastoreo">Pastoreo a eliminar.</param>
        public static void Eliminar(Pastoreo Pastoreo)
        {
            Pastoreo ObjBorrar = GetPastoreoOP(Pastoreo.Id);
            BDController.BDOperaciones.Pastoreos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Pastoreo GetPastoreoOP(int id)
        {
            Pastoreo rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Pastoreos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Pastoreo a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Pastoreo GetPastoreo(int id)
        {
            Pastoreo Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Pastoreos.Single(E => E.Id == id);
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
        /// Obtiene los/las Pastoreo que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Pastoreo> GetPastoreos(int? idParcela, int? idLote, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Pastoreo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Pastoreo> Consulta = BD.Pastoreos;
                Consulta = Consulta.Where(E => E.LoteAnimal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idParcela!=null)
                    Consulta = Consulta.Where(E => E.IdParcela==idParcela);
                if (idLote != null)
                    Consulta = Consulta.Where(E => E.IdLote == idLote);
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

        /// <summary>
        /// Obtiene los/las Pastoreo que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Pastoreo> GetPastoreosXIntervalo(int? idParcela, int? idLote, DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Pastoreo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Pastoreo> Consulta = BD.Pastoreos;
                Consulta = Consulta.Where(E => E.LoteAnimal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela == idParcela);
                if (idLote != null)
                    Consulta = Consulta.Where(E => E.IdLote == idLote);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => (E.FechaInicio <= fechaInicio && (E.FechaFin == null || E.FechaFin.Value >= fechaInicio))
                        || (E.FechaInicio <= fechaFin && (E.FechaFin == null || E.FechaFin.Value >= fechaFin))
                        || (E.FechaInicio >= fechaInicio && E.FechaInicio <= fechaFin));

                Consulta = Consulta.OrderByDescending(E => E.FechaInicio);
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