using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class AbonoData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Abono">Abono a insertar.</param>
        public static void Insertar(Abono Abono)
        {
            BDController.BDOperaciones.Abonos.InsertOnSubmit(Abono);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Abono">Abono a actualizar.</param>
        public static void Actualizar(Abono Abono)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Abono">Abono a eliminar.</param>
        public static void Eliminar(Abono Abono)
        {
            Abono ObjBorrar = GetAbonoOP(Abono.Id);
            BDController.BDOperaciones.Abonos.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Abono GetAbonoOP(int id)
        {
            Abono rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Abonos.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Abono a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Abono GetAbono(int id)
        {
            Abono Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Abonos.Single(E => E.Id == id);
            }
            catch (Exception)
            { throw; }
            finally
            {
                if (!BDController.TransaccionActiva)
                    BD.Dispose();
            }
            return Obj;
        }

        /// <summary>
        /// Obtiene los/las Abono que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Abono> GetAbonos(int? id,string descripcion)
        {
            List<Abono> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Abono> Consulta = BD.Abonos;
                if (id != null)
                    Consulta = Consulta.Where(E => E.Id == id);
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