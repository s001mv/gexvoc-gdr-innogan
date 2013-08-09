using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class StatusControlData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="StatusControl">StatusControl a insertar.</param>
        public static void Insertar(StatusControl StatusControl)
        {
            BDController.BDOperaciones.StatusControles.InsertOnSubmit(StatusControl);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="StatusControl">StatusControl a actualizar.</param>
        public static void Actualizar(StatusControl StatusControl)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="StatusControl">StatusControl a eliminar.</param>
        public static void Eliminar(StatusControl StatusControl)
        {
            StatusControl ObjBorrar = GetStatusControlOP(StatusControl.Id);
            BDController.BDOperaciones.StatusControles.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static StatusControl GetStatusControlOP(int id)
        {
            return BDController.BDOperaciones.StatusControles.Single(E => E.Id == id);
        }

        /// <summary>
        /// Obtiene un/una StatusControl a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static StatusControl GetStatusControl(int id)
        {
            StatusControl Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.StatusControles.Single(E => E.Id == id);
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
        /// Obtiene los/las StatusControl que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<StatusControl> GetStatusControls(string codigo,string descripcion)
        {
            List<StatusControl> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                IQueryable<StatusControl> Consulta = BD.StatusControles;


                if (!string.IsNullOrEmpty(codigo))
                    Consulta = Consulta.Where(E => E.Codigo.Contains(codigo));

                if (!string.IsNullOrEmpty(descripcion))
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