using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class RecolectaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Recolecta">Recolecta a insertar.</param>
        public static void Insertar(Recolecta Recolecta)
        {
            BDController.BDOperaciones.Recolectas.InsertOnSubmit(Recolecta);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Recolecta">Recolecta a actualizar.</param>
        public static void Actualizar(Recolecta Recolecta)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Recolecta">Recolecta a eliminar.</param>
        public static void Eliminar(Recolecta Recolecta)
        {
            Recolecta ObjBorrar = GetRecolectaOP(Recolecta.Id);
            BDController.BDOperaciones.Recolectas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Recolecta GetRecolectaOP(int id)
        {
            Recolecta rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Recolectas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Recolecta a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Recolecta GetRecolecta(int id)
        {
            Recolecta Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Recolectas.Single(E => E.Id == id);
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
        /// Obtiene los/las Recolecta que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Recolecta> GetRecolectas(int? idForraje, int? idParcela, decimal? cantidad, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            List<Recolecta> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Recolecta> Consulta = BD.Recolectas;

                if (idForraje != null)
                    Consulta = Consulta.Where(E => E.IdForraje==idForraje);
                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela == idParcela);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);


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