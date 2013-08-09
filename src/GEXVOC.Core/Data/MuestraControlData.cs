using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class MuestraControlData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="MuestraControl">MuestraControl a insertar.</param>
        public static void Insertar(MuestraControl MuestraControl)
        {
            BDController.BDOperaciones.MuestrasControles.InsertOnSubmit(MuestraControl);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="MuestraControl">MuestraControl a actualizar.</param>
        public static void Actualizar(MuestraControl MuestraControl)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="MuestraControl">MuestraControl a eliminar.</param>
        public static void Eliminar(MuestraControl MuestraControl)
        {
            MuestraControl ObjBorrar = GetMuestraControlOP(MuestraControl.Id);
            BDController.BDOperaciones.MuestrasControles.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static MuestraControl GetMuestraControlOP(int id)
        {
            MuestraControl rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.MuestrasControles.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una MuestraControl a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static MuestraControl GetMuestraControl(int id)
        {
            MuestraControl Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.MuestrasControles.Single(E => E.Id == id);
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
        /// Obtiene los/las MuestraControl que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<MuestraControl> GetMuestraControles(int? idControl, int? idLaboratorio,DateTime? fecha, decimal? rctoRegular, decimal? grasa, decimal? urea, decimal? proteina, decimal? lactosa, decimal? extractoSeco, decimal? linealPto, decimal? germenes, decimal? puntoCrioscopico,Boolean? ionhibidores)
        {
            List<MuestraControl> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<MuestraControl> Consulta = BD.MuestrasControles;

                if (idControl != null)
                    Consulta = Consulta.Where(E => E.IdControl == idControl);
                if (idLaboratorio != null)
                    Consulta = Consulta.Where(E => E.IdLaboratorio == idLaboratorio);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);
                if (rctoRegular != null)
                    Consulta = Consulta.Where(E => E.RctoCelular == rctoRegular);
                if (grasa != null)
                    Consulta = Consulta.Where(E => E.Grasa == grasa);
                if (urea != null)
                    Consulta = Consulta.Where(E => E.Urea == urea);
                if (proteina != null)
                    Consulta = Consulta.Where(E => E.Proteina == proteina);
                if (lactosa != null)
                    Consulta = Consulta.Where(E => E.Lactosa == lactosa);
                if (extractoSeco != null)
                    Consulta = Consulta.Where(E => E.ExtractoSeco == extractoSeco);
                if (linealPto != null)
                    Consulta = Consulta.Where(E => E.LinealPto == linealPto);
                if (germenes != null)
                    Consulta = Consulta.Where(E => E.Germenes == germenes);
                if (puntoCrioscopico != null)
                    Consulta = Consulta.Where(E => E.PuntoCrioscopico == puntoCrioscopico);
                if (ionhibidores != null)
                    Consulta = Consulta.Where(E => E.Ionhibidores == ionhibidores);

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
