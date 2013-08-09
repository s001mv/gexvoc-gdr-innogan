using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class MenuData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Menu">Menu a insertar.</param>
        public static void Insertar(Menu Menu)
        {
            BDController.BDOperaciones.Menus.InsertOnSubmit(Menu);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Menu">Menu a actualizar.</param>
        public static void Actualizar(Menu Menu)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Menu">Menu a eliminar.</param>
        public static void Eliminar(Menu Menu)
        {
            Menu ObjBorrar = GetMenuOP(Menu.Id);
            BDController.BDOperaciones.Menus.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Menu GetMenuOP(int id)
        {
            Menu rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Menus.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Menu a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Menu GetMenu(int id)
        {
            Menu Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Menus.Single(E => E.Id == id);
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
        /// Obtiene los/las Menu que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Menu> GetMenus(int? idModulo,int? idMenuSuperior,int? orden,string texto)
        {
            List<Menu> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Menu> Consulta = BD.Menus;

                if (idModulo != null)
                    Consulta = Consulta.Where(E => E.IdModulo == idModulo);
                if (idMenuSuperior != null)
                    Consulta = Consulta.Where(E => E.IdMenuSuperior == idMenuSuperior);
                if (orden != null)
                    Consulta = Consulta.Where(E => E.Orden == orden);
                if (texto != string.Empty)
                    Consulta = Consulta.Where(E => E.Texto==texto);


                Consulta = Consulta.OrderBy(E => E.Orden);//Ordenacion Inicial
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
        public static List<Menu> GetMenusPadres(int? idModulo, int? orden, string texto)
        {
            List<Menu> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Menu> Consulta = BD.Menus;

                if (idModulo != null)
                    Consulta = Consulta.Where(E => E.IdModulo == idModulo);
                if (orden != null)
                    Consulta = Consulta.Where(E => E.Orden == orden);
                if (texto != string.Empty)
                    Consulta = Consulta.Where(E => E.Texto == texto);

                Consulta = Consulta.Where(E => E.IdMenuSuperior == null);

                Consulta = Consulta.OrderBy(E => E.Orden);//Ordenacion Inicial
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