using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class AnalisisData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Analisis">Analisis a insertar.</param>
        public static void Insertar(Analisis Analisis)
        {
            BDController.BDOperaciones.Analisis.InsertOnSubmit(Analisis);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Analisis">Analisis a actualizar.</param>
        public static void Actualizar(Analisis Analisis)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Analisis">Analisis a eliminar.</param>
        public static void Eliminar(Analisis Analisis)
        {
            Analisis ObjBorrar = GetAnalisisOP(Analisis.Id);
            BDController.BDOperaciones.Analisis.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Analisis GetAnalisisOP(int id)
        {
            Analisis rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Analisis.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Analisis a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Analisis GetAnalisis(int id)
        {
            Analisis Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Analisis.Single(E => E.Id == id);
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
        /// Obtiene los/las Analisis que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Analisis> GetAnalisis(int? idTipoAnalisis, int? idAnimal, int? idLaboratorio, DateTime? fecha, string registro, Boolean? filiacion)
        {
            List<Analisis> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Analisis> Consulta = BD.Analisis;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idTipoAnalisis!= null)
                    Consulta = Consulta.Where(E => E.IdTipo==idTipoAnalisis);
                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);
                if (idLaboratorio != null)
                    Consulta = Consulta.Where(E => E.IdLaboratorio == idLaboratorio);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);
                if (registro != string.Empty)
                    Consulta = Consulta.Where(E => E.Registro.Contains(registro));
                if (filiacion != null)
                    Consulta = Consulta.Where(E => E.FiliacionCompatible == filiacion);


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
