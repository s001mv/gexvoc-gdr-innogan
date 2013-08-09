using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class CondicionCorporalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="CondicionCorporal">CondicionCorporal a insertar.</param>
        public static void Insertar(CondicionCorporal CondicionCorporal)
        {
            BDController.BDOperaciones.CondicionesCorporales.InsertOnSubmit(CondicionCorporal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="CondicionCorporal">CondicionCorporal a actualizar.</param>
        public static void Actualizar(CondicionCorporal CondicionCorporal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="CondicionCorporal">CondicionCorporal a eliminar.</param>
        public static void Eliminar(CondicionCorporal CondicionCorporal)
        {
            CondicionCorporal ObjBorrar = GetCondicionCorporalOP(CondicionCorporal.Id);
            BDController.BDOperaciones.CondicionesCorporales.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static CondicionCorporal GetCondicionCorporalOP(int id)
        {
            CondicionCorporal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.CondicionesCorporales.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una CondicionCorporal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static CondicionCorporal GetCondicionCorporal(int id)
        {
            CondicionCorporal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.CondicionesCorporales.Single(E => E.Id == id);
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
        /// Obtiene los/las CondicionCorporal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<CondicionCorporal> GetCondicionesCorporales(int? idHembra,int? idTipo,DateTime? fecha)
        {
            List<CondicionCorporal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<CondicionCorporal> Consulta = BD.CondicionesCorporales;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra==idHembra);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo==idTipo);
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

        public static List<CondicionCorporal> GetCondicionesCorporales(int? idHembra, int? idTipo, DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<CondicionCorporal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<CondicionCorporal> Consulta = BD.CondicionesCorporales;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);
                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (fechaInicio.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                if (fechaFin.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaFin);


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

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}