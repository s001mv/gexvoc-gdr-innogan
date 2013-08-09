using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TipoContactoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TipoContacto">TipoContacto a insertar.</param>
        public static void Insertar(TipoContacto TipoContacto)
        {
            BDController.BDOperaciones.TipoContacto.InsertOnSubmit(TipoContacto);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TipoContacto">TipoContacto a actualizar.</param>
        public static void Actualizar(TipoContacto TipoContacto)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TipoContacto">TipoContacto a eliminar.</param>
        public static void Eliminar(TipoContacto TipoContacto)
        {
            TipoContacto ObjBorrar = GetTipoContactoOP(TipoContacto.Id);
            BDController.BDOperaciones.TipoContacto.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TipoContacto GetTipoContactoOP(int id)
        {
            TipoContacto rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TipoContacto.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TipoContacto a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TipoContacto GetTipoContacto(int id)
        {
            TipoContacto Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TipoContacto.Single(E => E.Id == id);
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
        /// Obtiene los/las TipoContacto que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TipoContacto> GetTiposContactos(string descripcion, bool? sistema)
        {
            List<TipoContacto> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TipoContacto> Consulta = BD.TipoContacto;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema!=null)
                    Consulta = Consulta.Where(E => E.Sistema==sistema);


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