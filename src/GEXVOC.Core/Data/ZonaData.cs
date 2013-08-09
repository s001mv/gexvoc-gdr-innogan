using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ZonaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="zona">Zona a insertar.</param>
        public static void Insertar(Zona zona)
        {
            BDController.BDOperaciones.Zonas.InsertOnSubmit(zona);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="zona">Zona a actualizar.</param>
        public static void Actualizar(Zona zona)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="zona">Zona a eliminar.</param>
        public static void Eliminar(Zona zona)
        {
            Zona ObjBorrar = GetZonaOP(zona.Id);

            BDController.BDOperaciones.Zonas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Zona GetZonaOP(int id)
        {
            Zona rtno = null;

            try
            {
                rtno = BDController.BDOperaciones.Zonas.Single(Z => Z.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene una máquina a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Zona GetZona(int id)
        {
            Zona Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                Obj = BD.Zonas.Single(Z => Z.Id == id);
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
        public static List<Zona> GetZonas(int idExplotacion, string descripcion)
        {
            List<Zona> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;

            try
            {
                IQueryable<Zona> Consulta = BD.Zonas;

                if (!string.IsNullOrEmpty(descripcion))
                    Consulta = Consulta.Where(Z => Z.Descripcion.Contains(descripcion));

                Consulta = Consulta.Where(Z => Z.IdExplotacion == idExplotacion);

                Consulta = Consulta.OrderBy(Z => Z.Descripcion); //Ordenacion Inicial
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

