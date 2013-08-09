using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ConformacionCanalData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ConformacionCanal">ConformacionCanal a insertar.</param>
        public static void Insertar(ConformacionCanal ConformacionCanal)
        {
            BDController.BDOperaciones.ConformacionesCanal.InsertOnSubmit(ConformacionCanal);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ConformacionCanal">ConformacionCanal a actualizar.</param>
        public static void Actualizar(ConformacionCanal ConformacionCanal)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ConformacionCanal">ConformacionCanal a eliminar.</param>
        public static void Eliminar(ConformacionCanal ConformacionCanal)
        {
            ConformacionCanal ObjBorrar = GetConformacionCanalOP(ConformacionCanal.Id);
            BDController.BDOperaciones.ConformacionesCanal.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ConformacionCanal GetConformacionCanalOP(int id)
        {
            ConformacionCanal rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.ConformacionesCanal.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una ConformacionCanal a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ConformacionCanal GetConformacionCanal(int id)
        {
            ConformacionCanal Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.ConformacionesCanal.Single(E => E.Id == id);
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
        /// Obtiene los/las ConformacionCanal que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ConformacionCanal> GetConformacionesCanal(char? codigo,string descripcion,string detalle)
        {
            List<ConformacionCanal> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<ConformacionCanal> Consulta = BD.ConformacionesCanal;

                if (codigo != null)
                    Consulta = Consulta.Where(E => E.Codigo == codigo);
                if (descripcion != string.Empty)
                    Consulta = Consulta.Where(E => E.Descripcion.Contains(descripcion));
                if (detalle != string.Empty)
                    Consulta = Consulta.Where(E => E.Detalle.Contains(detalle));


                Consulta = Consulta.OrderBy(E => E.Codigo);//Ordenacion Inicial
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
