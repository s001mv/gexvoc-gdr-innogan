using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class InsParData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="InsPar">InsPar a insertar.</param>
        public static void Insertar(InsPar InsPar)
        {
            BDController.BDOperaciones.InsPar.InsertOnSubmit(InsPar);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="InsPar">InsPar a actualizar.</param>
        public static void Actualizar(InsPar InsPar)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="InsPar">InsPar a eliminar.</param>
        public static void Eliminar(InsPar InsPar)
        {
            InsPar ObjBorrar = GetInsParOP(InsPar.IdInseminacion,InsPar.IdParto);
            BDController.BDOperaciones.InsPar.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static InsPar GetInsParOP(int idInseminacion,int idParto)
        {
            InsPar rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.InsPar.Single(E => E.IdInseminacion == idInseminacion & E.IdParto==idParto);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una InsPar a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static InsPar GetInsPar(int id)
        {
            InsPar Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.InsPar.Single(E => E.Id == id);
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
        /// Obtiene los/las InsPar que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<InsPar> GetInsPar(int? idInseminacion,int? idParto)
        {
            List<InsPar> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<InsPar> Consulta = BD.InsPar;

                if (idInseminacion != null)
                    Consulta = Consulta.Where(E => E.IdInseminacion==idInseminacion);
                if (idParto != null)
                    Consulta = Consulta.Where(E => E.IdParto == idParto);


                Consulta = Consulta.OrderByDescending(E => E.Inseminacion.Fecha);//Ordenacion Inicial
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