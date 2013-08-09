using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class SecadoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Secado">Secado a insertar.</param>
        public static void Insertar(Secado secado)
        {
            BDController.BDOperaciones.Secados.InsertOnSubmit(secado);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Secado">Secado a actualizar.</param>
        public static void Actualizar(Secado secado)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Secado">Secado a eliminar.</param>
        public static void Eliminar(Secado secado)
        {
            Secado ObjBorrar = GetSecadoOP(secado.Id);
            BDController.BDOperaciones.Secados.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Secado GetSecadoOP(int id)
        {
            return BDController.BDOperaciones.Secados.Single(E => E.Id == id);
        }

        
        /// <summary>
        /// Obtiene un/una Secado a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Secado GetSecado(int id)
        {
            Secado Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Secados.Single(E => E.Id == id);
                Funciones.DescubrirPropiedades(Obj);
            }
            catch (Exception){ }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
          
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Secado que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Secado> GetSecados(int? idTipo,int? idMotivo,int? idHembra, DateTime? fecha,Boolean? modificable)
        {
            List<Secado> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Secado> Consulta = BD.Secados;

                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo==idTipo);
                if (idMotivo != null)
                    Consulta = Consulta.Where(E => E.IdMotivo == idMotivo);

                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);

                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);

                if (modificable != null)
                    Consulta = Consulta.Where(E => E.Modificable == modificable);


                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                          //(estas propiedades se utilizan habitualmente en los grids)

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

        public static List<Secado> GetSecados(int? idTipo, int? idMotivo,int? idHembra, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual,Boolean? modificable)
        {
            List<Secado> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Secado> Consulta = BD.Secados;

                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);
                if (idMotivo != null)
                    Consulta = Consulta.Where(E => E.IdMotivo == idMotivo);
                if (idHembra != null)
                    Consulta = Consulta.Where(E => E.IdHembra == idHembra);
                if (fechaMayorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha >= fechaMayorIgual);
                if (fechaMenorIgual != null)
                    Consulta = Consulta.Where(E => E.Fecha <= fechaMenorIgual);
                if (modificable != null)
                    Consulta = Consulta.Where(E => E.Modificable == modificable);



                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial

                Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
                                                          //(estas propiedades se utilizan habitualmente en los grids)


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