using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class PlanHigieneData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="PlanHigiene">PlanHigiene a insertar.</param>
        public static void Insertar(PlanHigiene PlanHigiene)
        {
            BDController.BDOperaciones.PlanHigiene.InsertOnSubmit(PlanHigiene);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="PlanHigiene">PlanHigiene a actualizar.</param>
        public static void Actualizar(PlanHigiene PlanHigiene)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="PlanHigiene">PlanHigiene a eliminar.</param>
        public static void Eliminar(PlanHigiene PlanHigiene)
        {
            PlanHigiene ObjBorrar = GetPlanHigieneOP(PlanHigiene.Id);
            if (ObjBorrar.TratHigiene.Count>0)
                throw new LogicException("No es posible eliminar el plan de higiene: " + ObjBorrar.Descripcion + " porque es utilizado en algún Tratamiento de Higiene.");
    
            BDController.BDOperaciones.PlanHigiene.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static PlanHigiene GetPlanHigieneOP(int id)
        {
            PlanHigiene rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.PlanHigiene.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una PlanHigiene a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static PlanHigiene GetPlanHigiene(int id)
        {
            PlanHigiene Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.PlanHigiene.Single(E => E.Id == id);
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
        /// Obtiene los/las PlanHigiene que coinciden con los criterios de búsqueda.
        /// </summary>
          public static List<PlanHigiene> GetPlanesHigiene(string descripcion)
          {
            	List<PlanHigiene> lista = null;
         		GEXVOCDataContext BD = BDController.NuevoContexto;
        		try
        		{                
            
               	IQueryable<PlanHigiene> Consulta = BD.PlanHigiene;
                 
                  if (descripcion != string.Empty)
                      Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                 
        
                  Consulta = Consulta.OrderBy(E => E.Descripcion);//Ordenacion Inicial
        			Funciones.DescubrirPropiedades(Consulta); //Ejecuta las propiedades del objeto que empiezan por Desc 
        													  //(estas propiedades se utilizan habitualmente en los grids)
                  lista=Consulta.ToList();//Convierte la consulta en una lista
            }
            catch (Exception)
            {throw;}
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