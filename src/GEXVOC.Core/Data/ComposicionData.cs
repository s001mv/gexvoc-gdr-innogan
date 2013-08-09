using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ComposicionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Composicion">Composicion a insertar.</param>
        public static void Insertar(Composicion Composicion)
        {
            BDController.BDOperaciones.Composiciones.InsertOnSubmit(Composicion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Composicion">Composicion a actualizar.</param>
        public static void Actualizar(Composicion Composicion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Composicion">Composicion a eliminar.</param>
        public static void Eliminar(Composicion Composicion)
        {
            Composicion ObjBorrar = GetComposicionOP(Composicion.IdRacion,Composicion.IdAlimento);
            BDController.BDOperaciones.Composiciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Composicion GetComposicionOP(int idRacion, int idAlimento)
        {
            Composicion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Composiciones.Single(E => E.IdRacion == idRacion && E.IdAlimento == idAlimento);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Composicion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Composicion GetComposicion(int idRacion,int idAlimento)
        {
            Composicion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Composiciones.Single(E => E.IdRacion == idRacion && E.IdAlimento == idAlimento);
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
        /// Obtiene los/las Composicion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Composicion> GetComposiciones(int? idRacion, int? idAlimento,decimal? porcentaje)
        {
            List<Composicion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Composicion> Consulta = BD.Composiciones;
                if (idRacion != null)
                    Consulta = Consulta.Where(E => E.IdRacion == idRacion);
                if (idAlimento != null)
                    Consulta = Consulta.Where(E => E.IdAlimento == idAlimento);
                if (porcentaje != null)
                    Consulta = Consulta.Where(E => E.Porcentaje == porcentaje);


                Consulta = Consulta.OrderBy(E => E.Racion.Descripcion).ThenBy(E => E.Alimento.Descripcion);//Ordenacion Inicial
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