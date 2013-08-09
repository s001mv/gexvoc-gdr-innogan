using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class ProProData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="ProPro">ProPro a insertar.</param>
        public static void Insertar(ProPro ProPro)
        {
            BDController.BDOperaciones.ProPro.InsertOnSubmit(ProPro);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="ProPro">ProPro a actualizar.</param>
        public static void Actualizar(ProPro ProPro)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="ProPro">ProPro a eliminar.</param>
        public static void Eliminar(ProPro ProPro)
        {
            ProPro ObjBorrar = GetProProOP(ProPro.IdTratProfilaxis, ProPro.IdProducto);
            BDController.BDOperaciones.ProPro.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static ProPro GetProProOP(int IdTratProfilaxis, int IdProducto)
        {
            ProPro rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.ProPro.Single(E => E.IdTratProfilaxis == IdTratProfilaxis & E.IdProducto == IdProducto);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una ProPro a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static ProPro GetProPro(int IdTratProfilaxis, int IdProducto)
        {
            ProPro Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.ProPro.Single(E => E.IdTratProfilaxis == IdTratProfilaxis & E.IdProducto == IdProducto);
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
        /// Obtiene los/las ProPro que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<ProPro> GetProPro(int? IdTratProfilaxis, int? IdProducto,decimal? cantidad)
        {
            List<ProPro> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<ProPro> Consulta = BD.ProPro;

                if (IdTratProfilaxis != null)
                    Consulta = Consulta.Where(E => E.IdTratProfilaxis == IdTratProfilaxis);
                if (IdProducto != null)
                    Consulta = Consulta.Where(E => E.IdProducto == IdProducto);
                if (cantidad != null)
                    Consulta = Consulta.Where(E => E.Cantidad == cantidad);



                Consulta = Consulta.OrderBy(E => E.IdProducto);//Ordenacion Inicial
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