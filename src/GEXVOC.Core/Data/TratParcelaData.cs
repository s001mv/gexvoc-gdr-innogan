using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TratParcelaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TratParcela">TratParcela a insertar.</param>
        public static void Insertar(TratParcela TratParcela)
        {
            BDController.BDOperaciones.TratsParcelas.InsertOnSubmit(TratParcela);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TratParcela">TratParcela a actualizar.</param>
        public static void Actualizar(TratParcela TratParcela)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TratParcela">TratParcela a eliminar.</param>
        public static void Eliminar(TratParcela TratParcela)
        {
            TratParcela ObjBorrar = GetTratParcelaOP(TratParcela.Id);
            BDController.BDOperaciones.TratsParcelas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TratParcela GetTratParcelaOP(int id)
        {
            TratParcela rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TratsParcelas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TratParcela a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TratParcela GetTratParcela(int id)
        {
            TratParcela Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TratsParcelas.Single(E => E.Id == id);
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
        /// Obtiene los/las TratParcela que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TratParcela> GetTratsParcelas(int? idParcela, int? idPlaga, int? idProducto, DateTime? fecha )
        {
            List<TratParcela> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TratParcela> Consulta = BD.TratsParcelas;

                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela==idParcela);
                if (idPlaga != null)
                    Consulta = Consulta.Where(E => E.IdPlaga == idPlaga);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
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

        public static List<TratParcela> GetTratsParcelas(int? idParcela, int? idPlaga, int? idProducto, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            List<TratParcela> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<TratParcela> Consulta = BD.TratsParcelas;

                if (idParcela != null)
                    Consulta = Consulta.Where(E => E.IdParcela == idParcela);
                if (idPlaga != null)
                    Consulta = Consulta.Where(E => E.IdPlaga == idPlaga);
                if (idProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == idProducto);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);

                Consulta = Consulta.OrderByDescending(E => E.Fecha);
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