using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class CombinacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Combinacion">Combinacion a insertar.</param>
        public static void Insertar(Combinacion Combinacion)
        {
            BDController.BDOperaciones.Combinaciones.InsertOnSubmit(Combinacion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Combinacion">Combinacion a actualizar.</param>
        public static void Actualizar(Combinacion Combinacion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Combinacion">Combinacion a eliminar.</param>
        public static void Eliminar(Combinacion Combinacion)
        {
            Combinacion ObjBorrar = GetCombinacionOP(Combinacion.Id);
            BDController.BDOperaciones.Combinaciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Combinacion GetCombinacionOP(int id)
        {
            Combinacion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Combinaciones.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Combinacion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Combinacion GetCombinacion(int id)
        {
            Combinacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Combinaciones.Single(E => E.Id == id);
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
        /// Obtiene los/las Combinacion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Combinacion> GetCombinaciones(int? idMarcador1, int? idMarcador2, string grupo, string riesgo)
        {
            List<Combinacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Combinacion> Consulta = BD.Combinaciones;

                if (idMarcador1 != null)
                    Consulta = Consulta.Where(E => E.IdMarcador1==idMarcador1);
                if (idMarcador2 != null)
                    Consulta = Consulta.Where(E => E.IdMarcador2 == idMarcador2);
                if (grupo != string.Empty)
                    Consulta = Consulta.Where(E => E.Grupo.Contains(grupo));
                if (riesgo != string.Empty)
                    Consulta = Consulta.Where(E => E.Riesgo.Contains(riesgo));


                Consulta = Consulta.OrderBy(E => E.Grupo);//Ordenacion Inicial
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
