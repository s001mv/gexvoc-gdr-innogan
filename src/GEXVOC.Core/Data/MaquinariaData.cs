using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class MaquinariaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="maquinaria">Maquinaria a insertar.</param>
        public static void Insertar(Maquinaria maquinaria)
        {
            BDController.BDOperaciones.Maquinaria.InsertOnSubmit(maquinaria);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="maquinaria">Maquinaria a actualizar.</param>
        public static void Actualizar(Maquinaria maquinaria)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="maquinaria">Maquinaria a eliminar.</param>
        public static void Eliminar(Maquinaria maquinaria)
        {
            Maquinaria ObjBorrar = GetMaquinariaOP(maquinaria.Id);

            BDController.BDOperaciones.Maquinaria.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Maquinaria GetMaquinariaOP(int id)
        {
            Maquinaria rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.Maquinaria.Single(M => M.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene una máquina a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Maquinaria GetMaquinaria(int id)
        {
            Maquinaria Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.Maquinaria.Single(M => M.Id == id);
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
        /// Obtiene las máquinas que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Maquinaria> GetMaquinas(int idExplotacion, string descripcion)
        {
            List<Maquinaria> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Maquinaria> Consulta = BD.Maquinaria;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(M => M.Descripcion.Contains(descripcion));

                Consulta = Consulta.Where(M => M.IdExplotacion == idExplotacion);

                Consulta = Consulta.OrderBy(M => M.Descripcion); //Ordenacion Inicial
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
        #endregion
    }
}
