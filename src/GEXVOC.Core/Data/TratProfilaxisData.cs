using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;

namespace GEXVOC.Core.Data
{
    public class TratProfilaxisData
    {
        #region  ACTUALIZACIÓN DE DATOS (Insertar,Actualizar,Eliminar,...)

        /// <summary>
        /// Inserta un registro.
        /// </summary>
        /// <param name="TratProfilaxis">TratProfilaxis a insertar.</param>
        public static void Insertar(TratProfilaxis TratProfilaxis)
        {
            BDController.BDOperaciones.TratProfilaxis.InsertOnSubmit(TratProfilaxis);
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Actualiza un registro.
        /// </summary>
        /// <param name="TratProfilaxis">TratProfilaxis a actualizar.</param>
        public static void Actualizar(TratProfilaxis TratProfilaxis)
        {
            BDController.BDOperaciones.SubmitChanges();
        }

        /// <summary>
        /// Elimina un registro.
        /// </summary>
        /// <param name="TratProfilaxis">TratProfilaxis a eliminar.</param>
        public static void Eliminar(TratProfilaxis TratProfilaxis)
        {
            TratProfilaxis ObjBorrar = GetTratProfilaxisOP(TratProfilaxis.Id);
            BDController.BDOperaciones.TratProfilaxis.DeleteOnSubmit(ObjBorrar);
            BDController.BDOperaciones.SubmitChanges();
        }

        #endregion

        #region OBTENCIÓN DE REGISTROS (Tipos de Búsqueda)

        public static TratProfilaxis GetTratProfilaxisOP(int id)
        {
            TratProfilaxis rtno = null;
            try
            {
                rtno = BDController.BDOperaciones.TratProfilaxis.Single(E => E.Id == id);
            }
            catch (Exception) { }

            return rtno;
        }

        /// <summary>
        /// Obtiene un/una TratProfilaxis a partir de su id.
        /// </summary>
        /// <param name="id">Identificador principal.</param>
        public static TratProfilaxis GetTratProfilaxis(int id)
        {
            TratProfilaxis Obj = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {
                Obj = BD.TratProfilaxis.Single(E => E.Id == id);
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
        /// Obtiene los/las TratProfilaxis que coinciden con los criterios de búsqueda.
        /// </summary>
        public static List<TratProfilaxis> GetTratProfilaxis(int? idExplotacion,int? idPrograma,string detalle,DateTime? fecha)
        {
            List<TratProfilaxis> lista = null;
            GEXVOCDataContext BD = BDController.NuevoContexto;
            try
            {

                IQueryable<TratProfilaxis> Consulta = BD.TratProfilaxis;

                //var Consulta = from p in BD.TratProfilaxis
                //               from o in p.AniPro
                //               where (o.Animal.IdExplotacion == Configuracion.Explotacion.Id & p.Id==o.IdTratProfilaxis)                            
                //               select (p);
                if (idExplotacion.HasValue)                                       
                    Consulta = Consulta.Where(E => E.IdExplotacion == idExplotacion);
                else
                    Consulta = Consulta.Where(E => E.IdExplotacion == Configuracion.Explotacion.Id);                
              
                if (idPrograma != null)
                    Consulta = Consulta.Where(E => E.IdPrograma == idPrograma);
                if (!string.IsNullOrEmpty(detalle))
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