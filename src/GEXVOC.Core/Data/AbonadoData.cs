using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class AbonadoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Abonado">Abonado a insertar.</param>
        public static void Insertar(Abonado Abonado)
        {
            BDController.BDOperaciones.Abonados.InsertOnSubmit(Abonado);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Abonado">Abonado a actualizar.</param>
        public static void Actualizar(Abonado Abonado)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Abonado">Abonado a eliminar.</param>
        public static void Eliminar(Abonado Abonado)
        {
            Abonado ObjBorrar = GetAbonadoOP(Abonado.Id);
            BDController.BDOperaciones.Abonados.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Abonado GetAbonadoOP(int id)
        {
            Abonado rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Abonados.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Abonado a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Abonado GetAbonado(int id)
        {
            Abonado Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Abonados.Single(E => E.Id == id);
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
        /// Obtiene los/las Abonado que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Abonado> GetAbonados(int? idAbono, int? idParcela,decimal? cantidad, DateTime? fecha)
        {
            List<Abonado> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Abonado> Consulta = BD.Abonados;
                if (idAbono != null)
                    Consulta = Consulta.Where(E => E.IdAbono==idAbono);
                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela == idParcela);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);


                Consulta = Consulta.OrderByDescending(E => E.Fecha).ThenBy(E=>E.Abono.Descripcion);//Ordenacion Inicial
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
        public static List<Abonado> GetAbonados(int? idAbono, int? idParcela, decimal? cantidad, DateTime? fechaMayorIgual,DateTime? fechaMenorIgual)
        {
            List<Abonado> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Abonado> Consulta = BD.Abonados;
                if (idAbono != null)
                    Consulta = Consulta.Where(E => E.IdAbono == idAbono);
                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela == idParcela);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);



                Consulta = Consulta.OrderByDescending(E => E.Fecha).ThenBy(E => E.Abono.Descripcion);//Ordenacion Inicial
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