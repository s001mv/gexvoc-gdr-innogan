using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ConformacionData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Conformacion">Conformacion a insertar.</param>
        public static void Insertar(Conformacion Conformacion)
        {
            BDController.BDOperaciones.Conformaciones.InsertOnSubmit(Conformacion);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Conformacion">Conformacion a actualizar.</param>
        public static void Actualizar(Conformacion Conformacion)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Conformacion">Conformacion a eliminar.</param>
        public static void Eliminar(Conformacion Conformacion)
        {
            Conformacion ObjBorrar = GetConformacionOP(Conformacion.Id);
            BDController.BDOperaciones.Conformaciones.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Conformacion GetConformacionOP(int id)
        {
            return BDController.BDOperaciones.Conformaciones.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una Conformacion a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Conformacion GetConformacion(int id)
        {
            Conformacion Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Conformaciones.Single(E => E.Id == id);
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
        /// Obtiene los/las Conformacion que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Conformacion> GetConformaciones(string descripcion)
        {
            List<Conformacion> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Conformacion> Consulta = BD.Conformaciones;         
                

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


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