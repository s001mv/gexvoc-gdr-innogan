using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ProvinciaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Provincia">Provincia a insertar.</param>
        public static void Insertar(Provincia Provincia)
        {
            BDController.BDOperaciones.Provincias.InsertOnSubmit(Provincia);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Provincia">Provincia a actualizar.</param>
        public static void Actualizar(Provincia Provincia)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Provincia">Provincia a eliminar.</param>
        public static void Eliminar(Provincia Provincia)
        {
            Provincia ObjBorrar = GetProvinciaOP(Provincia.Id);
            BDController.BDOperaciones.Provincias.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Provincia GetProvinciaOP(int id)
        {
            return BDController.BDOperaciones.Provincias.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una Provincia a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Provincia GetProvincia(int id)
        {
            Provincia Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Provincias.Single(E => E.Id == id);
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
        /// Obtiene los/las Provincia que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Provincia> GetProvincias(string codigo, string descripcion)
        {
            List<Provincia> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<Provincia> Consulta = BD.Provincias;

                if (codigo != string.Empty)
                    Consulta = Consulta.Where(E => E.Codigo.Contains(codigo));
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