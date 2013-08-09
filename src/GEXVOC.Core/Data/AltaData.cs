using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class AltaData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="Alta">Alta a insertar.</param>
        public static void Insertar(Alta Alta)
        {
            BDController.BDOperaciones.Altas.InsertOnSubmit(Alta);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="Alta">Alta a actualizar.</param>
        public static void Actualizar(Alta Alta)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="Alta">Alta a eliminar.</param>
        public static void Eliminar(Alta Alta)
        {
            Alta ObjBorrar = GetAltaOP(Alta.Id);
            BDController.BDOperaciones.Altas.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static Alta GetAltaOP(int id)
        {
            Alta rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.Altas.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una Alta a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static Alta GetAlta(int id)
        {
            Alta Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Altas.Single(E => E.Id == id);
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

        public static Alta GetAltaAnimal(int idAnimal)
        {
            Alta Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.Altas.Single(E => E.IdAnimal == idAnimal);
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
        /// Obtiene los/las Alta que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<Alta> GetAltas(int? idTipo,int? idAnimal,string detalle,DateTime? fecha)
        {
            List<Alta> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<Alta> Consulta = BD.Altas;

                if (idTipo != null)
                    Consulta = Consulta.Where(E => E.IdTipo == idTipo);

                if (idAnimal != null)
                    Consulta = Consulta.Where(E => E.IdAnimal == idAnimal);

                if (detalle != string.Empty)
                    Consulta = Consulta.Where(E => E.Detalle.Contains(detalle));

                if (fecha != null)
                    Consulta = Consulta.Where(E => E.Fecha == fecha);


                Consulta = Consulta.OrderByDescending(E => E.Fecha);//Ordenacion Inicial
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