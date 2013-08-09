using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoCondicionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoCondicion">TipoCondicion a insertar.</param>
        public static void Insertar(TipoCondicion TipoCondicion)
        {
            BDController.BDOperaciones.TiposCondiciones.InsertOnSubmit(TipoCondicion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoCondicion">TipoCondicion a actualizar.</param>
        public static void Actualizar(TipoCondicion TipoCondicion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoCondicion">TipoCondicion a eliminar.</param>
        public static void Eliminar(TipoCondicion TipoCondicion)
        {
            TipoCondicion ObjBorrar = GetTipoCondicionOP(TipoCondicion.Id);
            BDController.BDOperaciones.TiposCondiciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoCondicion GetTipoCondicionOP(int id)
        {
            TipoCondicion rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TiposCondiciones.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoCondicion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoCondicion GetTipoCondicion(int id)
        {
            TipoCondicion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TiposCondiciones.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoCondicion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoCondicion> GetTiposCondiciones(int? idEspecie,string codigo,string descripcion,string detalle,bool? apta)
        {            
            List<TipoCondicion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoCondicion> Consulta = BD.TiposCondiciones;
                if (idEspecie != null)
                    Consulta = Consulta.Where(E => E.IdEspecie == idEspecie);
                if (!string.IsNullOrEmpty(codigo))
                    Consulta = Consulta.Where(E => E.Codigo.Contains(codigo));
                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (!string.IsNullOrEmpty(detalle))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(detalle));
                if (apta != null)
                    Consulta = Consulta.Where(E => E.Apta == apta);


                Consulta = Consulta.OrderBy(E => E.Especie.Descripcion).ThenBy(E=>E.Codigo);//Ordenacion Inicial
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