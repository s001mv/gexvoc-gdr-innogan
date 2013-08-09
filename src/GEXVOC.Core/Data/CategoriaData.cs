using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class CategoriaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Categoria">Categoria a insertar.</param>
        public static void Insertar(Categoria Categoria)
        {
            BDController.BDOperaciones.Categorias.InsertOnSubmit(Categoria);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Categoria">Categoria a actualizar.</param>
        public static void Actualizar(Categoria Categoria)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Categoria">Categoria a eliminar.</param>
        public static void Eliminar(Categoria Categoria)
        {
            Categoria ObjBorrar = GetCategoriaOP(Categoria.Id);
            BDController.BDOperaciones.Categorias.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Categoria GetCategoriaOP(int id)
        {
            Categoria rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Categorias.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Categoria a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Categoria GetCategoria(int id)
        {
            Categoria Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Categorias.Single(E => E.Id == id);
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
        /// Obtiene los/las Categoria que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Categoria> GetCategorias(string descripcion,string detalle)
        {
            List<Categoria> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Categoria> Consulta = BD.Categorias;

                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (detalle != string.Empty)
                    Consulta = Consulta.Where(E => E.Detalle.Contains(detalle));


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
