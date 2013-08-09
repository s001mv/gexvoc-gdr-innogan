using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ModuloData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Modulo">Modulo a insertar.</param>
        public static void Insertar(Modulo Modulo)
        {
            BDController.BDOperaciones.Modulos.InsertOnSubmit(Modulo);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Modulo">Modulo a actualizar.</param>
        public static void Actualizar(Modulo Modulo)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Modulo">Modulo a eliminar.</param>
        public static void Eliminar(Modulo Modulo)
        {
            Modulo ObjBorrar = GetModuloOP(Modulo.Id);
            BDController.BDOperaciones.Modulos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Modulo GetModuloOP(int id)
        {
            Modulo rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Modulos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Modulo a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Modulo GetModulo(int id)
        {
            Modulo Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Modulos.Single(E => E.Id == id);
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
        /// Obtiene los/las Modulo que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Modulo> GetModulos(int? idPrincipal,string descripcion)
        {
            List<Modulo> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Modulo> Consulta = BD.Modulos;

                if (idPrincipal != null)
                    Consulta = Consulta.Where(E => E.IdPrincipal==idPrincipal);
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));


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