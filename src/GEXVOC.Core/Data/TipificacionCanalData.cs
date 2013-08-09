using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipificacionCanalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipificacionCanal">TipificacionCanal a insertar.</param>
        public static void Insertar(TipificacionCanal TipificacionCanal)
        {
            BDController.BDOperaciones.TipificacionesCanal.InsertOnSubmit(TipificacionCanal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipificacionCanal">TipificacionCanal a actualizar.</param>
        public static void Actualizar(TipificacionCanal TipificacionCanal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipificacionCanal">TipificacionCanal a eliminar.</param>
        public static void Eliminar(TipificacionCanal TipificacionCanal)
        {
            TipificacionCanal ObjBorrar = GetTipificacionCanalOP(TipificacionCanal.Id);
            BDController.BDOperaciones.TipificacionesCanal.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipificacionCanal GetTipificacionCanalOP(int id)
        {
            TipificacionCanal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TipificacionesCanal.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipificacionCanal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipificacionCanal GetTipificacionCanal(int id)
        {
            TipificacionCanal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TipificacionesCanal.Single(E => E.Id == id);
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
        /// Obtiene los/las TipificacionCanal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipificacionCanal> GetTipificacionesCanal(int? idAnimal, int? idConformacion, int? idCategoria, DateTime? fechaMayorIgual, DateTime? fechaMenorIgual)
        {
            List<TipificacionCanal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipificacionCanal> Consulta = BD.TipificacionesCanal;

                Consulta = Consulta.Where(E => E.Animal.IdExplotacion == Configuracion.Explotacion.Id);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal==idAnimal);
                if (idConformacion != null)
                    Consulta = Consulta.Where(E => E.IdConformacion == idConformacion);
                if (idCategoria != null)
                    Consulta = Consulta.Where(E => E.IdCategoria == idCategoria);
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

        /// <summary>
        /// Nos retorna la tipificacion en canal del animal
        /// Deber ser una única, por animal.
        /// </summary>
        /// <param name="idAnimal"></param>
        /// <returns></returns>
        public static TipificacionCanal GetTipificacionCanalAnimal(int idAnimal)
        {
            TipificacionCanal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TipificacionesCanal.Single(E => E.IdAnimal == idAnimal);
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


   

        #endregion

        #region FUNCIONALIDAD AÑADIDA
        //Puede contener propiedades o funciones tipicas de la instancia de ptlGereric
        //Estos elementos proveen de nuevas características.


        #endregion

    }
}
