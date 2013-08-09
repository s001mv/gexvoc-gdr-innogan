using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ControlLecheData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ControlLeche">ControlLeche a insertar.</param>
        public static void Insertar(ControlLeche ControlLeche)
        {
            BDController.BDOperaciones.Controles.InsertOnSubmit(ControlLeche);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ControlLeche">ControlLeche a actualizar.</param>
        public static void Actualizar(ControlLeche ControlLeche)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ControlLeche">ControlLeche a eliminar.</param>
        public static void Eliminar(ControlLeche ControlLeche)
        {
            ControlLeche ObjBorrar = GetControlLecheOP(ControlLeche.Id);
            BDController.BDOperaciones.Controles.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ControlLeche GetControlLecheOP(int id)
        {
            ControlLeche rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Controles.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una ControlLeche a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ControlLeche GetControlLeche(int id)
        {
            ControlLeche Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Controles.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            { //throw;
            }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las ControlLeche que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ControlLeche> GetControlesLeche(Nullable<int> idLactacion, Nullable<int> idControl, Nullable<int> idOrdeno,
                                                           Nullable<DateTime> fecha, Nullable<decimal> lecheManana, Nullable<decimal> lecheTarde,
                                                           Nullable<decimal> lecheNoche, Nullable<Boolean> modificable)
        {
            List<ControlLeche> ListaObj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<ControlLeche> Consulta = BD.Controles;


                if (idLactacion != null)
                    Consulta = Consulta.Where(E => E.IdLactacion == idLactacion);
                if (idControl != null)
                    Consulta = Consulta.Where(E => E.IdControl == idControl);
                if (idOrdeno != null)
                    Consulta = Consulta.Where(E => E.IdOrdeno == idOrdeno);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);
                if (lecheManana != null)
                    Consulta = Consulta.Where(E => E.LecheManana == lecheManana);
                if (lecheTarde != null)
                    Consulta = Consulta.Where(E => E.LecheTarde == lecheTarde);
                if (lecheNoche != null)
                    Consulta = Consulta.Where(E => E.LecheNoche == lecheNoche);
                if (modificable != null)
                    Consulta = Consulta.Where(E => E.Modificable == modificable);




                Consulta = Consulta.OrderByDescending(E => E.Fecha);

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)

                ListaObj = Consulta.ToList();
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }


            return ListaObj;

        }

        public static List<ControlLeche> GetControlesLeche(int? idLactacion, DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<ControlLeche> ListaObj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<ControlLeche> Consulta = BD.Controles;


                if (idLactacion.HasValue)
                    Consulta = Consulta.Where(E => E.IdLactacion == idLactacion);
                
                if (fechaInicio.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaInicio);
                if (fechaFin.HasValue)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaFin);
            

                Consulta = Consulta.OrderByDescending(E => E.Fecha);

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                //(estas propiedades se utilizan habitualmente en los grids)

                ListaObj = Consulta.ToList();
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }


            return ListaObj;

        }

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}
