using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class SiembraData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Siembra">Siembra a insertar.</param>
        public static void Insertar(Siembra Siembra)
        {
            BDController.BDOperaciones.Siembras.InsertOnSubmit(Siembra);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Siembra">Siembra a actualizar.</param>
        public static void Actualizar(Siembra Siembra)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Siembra">Siembra a eliminar.</param>
        public static void Eliminar(Siembra Siembra)
        {
            Siembra ObjBorrar = GetSiembraOP(Siembra.Id);
            BDController.BDOperaciones.Siembras.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Siembra GetSiembraOP(int id)
        {
            Siembra rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Siembras.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Siembra a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Siembra GetSiembra(int id)
        {
            Siembra Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Siembras.Single(E => E.Id == id);
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
        /// Obtiene los/las Siembra que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Siembra> GetSiembras(int? idSemilla, int? idParcela, decimal? cantidad, DateTime? fecha)
        {
            List<Siembra> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Siembra> Consulta = BD.Siembras;

                if (idSemilla != null)
                    Consulta = Consulta.Where(E => E.IdSemilla==idSemilla);
                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela == idParcela);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
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

        public static List<Siembra> GetSiembras(int? idSemilla, int? idParcela, decimal? cantidad, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            List<Siembra> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Siembra> Consulta = BD.Siembras;

                if (idSemilla != null)
                    Consulta = Consulta.Where(E => E.IdSemilla == idSemilla);
                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela == idParcela);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);

                Consulta = Consulta.OrderByDescending(E => E.Fecha).ThenBy(E => E.Semilla.Descripcion);
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