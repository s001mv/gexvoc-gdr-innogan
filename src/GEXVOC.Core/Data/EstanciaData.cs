using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class EstanciaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Estancia">Estancia a insertar.</param>
        public static void Insertar(Estancia Estancia)
        {
            BDController.BDOperaciones.Estancias.InsertOnSubmit(Estancia);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Estancia">Estancia a actualizar.</param>
        public static void Actualizar(Estancia Estancia)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Estancia">Estancia a eliminar.</param>
        public static void Eliminar(Estancia Estancia)
        {
            Estancia ObjBorrar = GetEstanciaOP(Estancia.IdCubricion,Estancia.IdMacho,Estancia.FechaInicio);
            BDController.BDOperaciones.Estancias.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Estancia GetEstanciaOP(int idCubricion,int idMacho,DateTime fechaInicio)
        {
            Estancia rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Estancias.Single(E => E.IdCubricion == idCubricion & E.IdMacho == idMacho & E.FechaInicio==fechaInicio);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Estancia a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Estancia GetEstancia(int idCubricion, int idMacho,DateTime fechaInicio)
        {
            Estancia Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Estancias.Single(E => E.IdCubricion == idCubricion & E.IdMacho == idMacho & E.FechaInicio == fechaInicio);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception)
            {  }//Ojo no lanza excepción, nos interesa así para comparar directamente si existe o no nulo
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Estancia que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Estancia> GetEstancias(int? idCubricion,int? idMacho,DateTime? fechaInicio,DateTime? fechaFin)
        {
            List<Estancia> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Estancia> Consulta = BD.Estancias;

                if (idCubricion != null)
                    Consulta = Consulta.Where(E => E.IdCubricion == idCubricion);
                if (idMacho != null)
                    Consulta = Consulta.Where(E => E.IdMacho==idMacho);
                if (fechaInicio != null)
                    Consulta = Consulta.Where(E => E.FechaInicio == fechaInicio);
                if (fechaFin != null)
                    Consulta = Consulta.Where(E => E.FechaFin == fechaFin);


                Consulta = Consulta.OrderByDescending(E => E.FechaInicio).ThenBy(E=>E.FechaFin);//Ordenacion Inicial
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