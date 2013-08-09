using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class FacilidadData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Facilidad">Facilidad a insertar.</param>
        public static void Insertar(Facilidad facilidad)
        {
            BDController.BDOperaciones.Facilidades.InsertOnSubmit(facilidad);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Facilidad">Facilidad a actualizar.</param>
        public static void Actualizar(Facilidad facilidad)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Facilidad">Facilidad a eliminar.</param>
        public static void Eliminar(Facilidad facilidad)
        {
            Facilidad ObjBorrar = GetFacilidadOP(facilidad.Id);
            BDController.BDOperaciones.Facilidades.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Facilidad GetFacilidadOP(int id)
        {
            return BDController.BDOperaciones.Facilidades.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una Facilidad a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Facilidad GetFacilidad(int id)
        {
            Facilidad Obj = null;

            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Facilidades.Single(E => E.Id == id);
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

        /// <summary>
        /// Obtiene los/las Facilidad que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Facilidad> GetFacilidades(string descripcion,Boolean? sistema)
        {
            List<Facilidad> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                 IQueryable<Facilidad> Consulta = BD.Facilidades;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (sistema != null)
                    Consulta = Consulta.Where(E => E.Sistema==sistema);


                Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial

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