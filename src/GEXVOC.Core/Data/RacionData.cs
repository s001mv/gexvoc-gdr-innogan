using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class RacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Racion">Racion a insertar.</param>
        public static void Insertar(Racion Racion)
        {
            BDController.BDOperaciones.Raciones.InsertOnSubmit(Racion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Racion">Racion a actualizar.</param>
        public static void Actualizar(Racion Racion)
        {
            if (BDController.BDOperaciones.Asignaciones.Where(E=>E.IdRacion==Racion.Id).Count()>0)            
                throw new LogicException("No es posible modificar la ración: " + Racion.Descripcion + " porque ha sido utilizada en alguna asignación alimentaria.");

            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Racion">Racion a eliminar.</param>
        public static void Eliminar(Racion Racion)
        {
            if (BDController.BDOperaciones.Asignaciones.Where(E => E.IdRacion == Racion.Id).Count() > 0)
                throw new LogicException("No es posible eliminar la ración: " + Racion.Descripcion + " porque ha sido utilizada en alguna asignación alimentaria.");

            Racion ObjBorrar = GetRacionOP(Racion.Id);
            BDController.BDOperaciones.Raciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Racion GetRacionOP(int id)
        {
            Racion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Raciones.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Racion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Racion GetRacion(int id)
        {
            Racion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Raciones.Single(E => E.Id == id);
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
        /// Obtiene los/las Racion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Racion> GetRaciones(string descripcion,decimal? peso)
        {
            List<Racion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Racion> Consulta = BD.Raciones;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (peso != null)
                    Consulta = Consulta.Where(E => E.Peso==peso);


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial
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